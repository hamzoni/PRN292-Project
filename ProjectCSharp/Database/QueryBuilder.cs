using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ProjectCSharp.Database
{
    class QueryBuilder
    {
        private string cs = ConfigurationManager.ConnectionStrings["DBI"].ConnectionString;
        private List<SqlParameter> pr;
        private SqlConnection con;
        private SqlCommand cmd;
        private string query;
        private int type;

        private const int SELECT = 0;
        private const int INSERT = 1;
        private const int UPDATE = 2;
        private const int DELETE = 3;
        private const int COUNT = 4;

        public const int AND = 0;
        public const int OR = 1;
        public const int LARGER = 2;
        public const int SMALLER = 3;

        private static QueryBuilder qb;
        private string tbn;

        public QueryBuilder(string tbn)
        {
            this.tbn = tbn;
            this.type = -1;
        }

        public static QueryBuilder table(string tbn)
        {
            qb = new QueryBuilder(tbn);
            return qb;
        }

        public QueryBuilder join(string tbn, string cleft, string cright)
        {
            query += " LEFT JOIN " + tbn + " ON " + this.tbn + "." + cleft + " = " + tbn + "." + cright;

            cmd.CommandText = query;

            return this;
        }

        public QueryBuilder count()
        {
            type = QueryBuilder.COUNT;
            setup();

            query = "SELECT COUNT(*) FROM " + tbn;

            cmd.CommandText = query;

            return this;
        }

        public QueryBuilder select()
        {
            type = QueryBuilder.SELECT;
            setup();

            query = "SELECT * FROM " + tbn;

            cmd.Connection = con;
            cmd.CommandText = query;

            return this;
        }

        public QueryBuilder select(List<string> fields)
        {
            type = QueryBuilder.SELECT;
            setup();

            string fq = " ";
            foreach (string field in fields)
            {
                fq += field + ", ";
            }
            fq = fq.TrimEnd(',');

            query = "SELECT " + fq + " FROM " + tbn;

            cmd.Connection = con;
            cmd.CommandText = query;

            return this;
        }

        public QueryBuilder delete()
        {
            type = QueryBuilder.DELETE;
            setup();

            query = "DELETE FROM " + tbn;

            return this;
        }

        public QueryBuilder between(string field, int type, object[] values)
        {
            if (this.type == QueryBuilder.INSERT) return this;
            if (values.Length != 1) return this;
            if (pr == null) return this;
            if (pr.Count == 0) return this;

            string types = getConcatenate(type);

            int count = Regex.Matches(query, field).Count;
            string k1 = "@key" + (count + 1);
            string k2 = "@key" + (count + 2);

            query += query.Contains("WHERE") ? types : " WHERE ";
            query += type + " BETWEEN " + k1 + " AND " + k2;

            cmd.CommandText = query;
            cmd.Parameters.Add(new SqlParameter(k1, values[0]));
            cmd.Parameters.Add(new SqlParameter(k2, values[1]));

            return this;
        }

        public QueryBuilder where(string field, object value)
        {
            return where(field, QueryBuilder.AND, value);
        }

        public QueryBuilder where(string field, int type, object value)
        {
            if (this.type == QueryBuilder.INSERT) return this;
            if (pr == null) pr = new List<SqlParameter>();

            string types = getConcatenate(type);
            query += query.Contains("WHERE") ? types : " WHERE ";

            // count key occurences
            int count = Regex.Matches(query, field).Count;
            string key = "@" + field + (count > 0 ? count.ToString() : "");

            query += field + " = " + key;

            // update command
            cmd.CommandText = query;
            cmd.Parameters.Add(new SqlParameter(key, value));
            
            return this;
        }

        public QueryBuilder update(Dictionary<string, object> entries)
        {
            type = QueryBuilder.UPDATE;
            setup();

            pr = new List<SqlParameter>();

            query = "UPDATE " + tbn + " SET ";

            foreach (KeyValuePair<string, object> entry in entries)
            {
                query += entry.Key + " = @" + entry.Key + ",";
                pr.Add(new SqlParameter("@" + entry.Key, entry.Value));
            }
            query  = query.TrimEnd(',');

            // define parameters
            cmd.Connection = con;
            cmd.CommandText = query;

            foreach (SqlParameter p in pr)
            {
                cmd.Parameters.Add(p);
            }

            return this;
        }

        public QueryBuilder insert(Dictionary<string, object> entries)
        {
            type = QueryBuilder.INSERT;
            setup();

            pr = new List<SqlParameter>();

            query = "INSERT INTO " + tbn + "(";

            // define fields
            string ql = "";
            string qr = "";
            foreach (KeyValuePair<string, object> entry in entries)
            {
                ql += entry.Key + ",";
                qr += "@" + entry.Key + ",";
                pr.Add(new SqlParameter("@" + entry.Key, entry.Value));
            }
            query += ql.TrimEnd(',') + ") VALUES(" + qr.TrimEnd(',') + ")";

            // define parameters
            cmd.Connection = con;
            cmd.CommandText = query;

            foreach (SqlParameter p in pr)
            {
                cmd.Parameters.Add(p);
            }

            return this;
        }

        private string getConcatenate(int type)
        {
            if (type == QueryBuilder.AND) return " AND ";
            if (type == QueryBuilder.OR) return " OR ";
            return " AND ";
        }

        private void setup()
        {
            con = new SqlConnection(cs);
            cmd = new SqlCommand();
            cmd.Connection = con;
        }


        private DataRowCollection listing()
        {
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adt.Fill(ds);

            return ds.Tables[0].Rows;
        }

        public object execute()
        {
            object k = null;
            switch (type)
            {
                case QueryBuilder.SELECT:
                    k = listing();
                    break;
                case QueryBuilder.COUNT:
                    con.Open();
                    k = (Int32)cmd.ExecuteScalar();
                    con.Close();
                    break;
                case QueryBuilder.INSERT:
                case QueryBuilder.UPDATE:
                case QueryBuilder.DELETE:
                    if (type == QueryBuilder.DELETE)
                    {
                        if (!query.Contains("WHERE"))
                        {
                            break;
                        }
                    }
                    con.Open();
                    k = (object) cmd.ExecuteNonQuery();
                    con.Close();
                    break;
            }
            return k;
        }
    }
}
