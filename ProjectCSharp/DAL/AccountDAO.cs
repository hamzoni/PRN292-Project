using ProjectCSharp.Database;
using ProjectCSharp.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ProjectCSharp.DAL
{
    class AccountDAO : DAO, IDAO<Account>
    {
        public int count(int id)
        {
            int count = (int)QueryBuilder.table("Account")
                .count()
                .where("id", id)
                .execute();
            return count;
        }

        public int count(string username)
        {
            int count = (int)QueryBuilder.table("Account")
                .count()
                .where("username", username)
                .execute();
            return count;
        }

        public bool login(Account acc)
        {
            int count = (int) QueryBuilder.table("Account")
                .count()
                .where("username", QueryBuilder.AND, acc.username)
                .where("password", QueryBuilder.AND, acc.password)
                .execute();
            return count != 0;
        }

        public void delete(object x)
        {
            QueryBuilder.table("Account")
                .delete()
                .where("id", QueryBuilder.AND, x)
                .execute();
        }

        public bool insert(Account x)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("username", x.username);
            pairs.Add("password", x.password);

            int c = (int) QueryBuilder.table("Account")
                .insert(pairs)
                .execute();

            return c != 0;
        }

        public List<Account> list()
        {
            List<Account> accounts = new List<Account>();
            DataRowCollection rows = (DataRowCollection)QueryBuilder.table("Account")
                .select()
                .execute();

            foreach (DataRow row in rows)
            {
                Account account = new Account();
                account.id = (int) row["id"];
                account.username = (string) row["username"];
                account.password = (string) row["password"];
                accounts.Add(account);
            }
            return accounts;
        }

        public void update(Account x) 
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("username", x.username);
            pairs.Add("password", x.password);

            QueryBuilder.table("Account")
                .update(pairs)
                .where("id", QueryBuilder.AND, x.id)
                .execute();
        }
    }
}
