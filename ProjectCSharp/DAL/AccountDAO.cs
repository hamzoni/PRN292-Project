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
        private string table = "Account";

        public int count(int id)
        {
            int count = (int)QueryBuilder.table(table)
                .count()
                .where("id", id)
                .execute();
            return count;
        }

        public int count(string username)
        {
            int count = (int)QueryBuilder.table(table)
                .count()
                .where("username", username)
                .execute();
            return count;
        }

        public bool login(Account acc)
        {
            int count = (int) QueryBuilder.table(table)
                .count()
                .where("username", acc.username)
                .where("password", acc.password)
                .execute();
            return count != 0;
        }

        public Account search(Account acc)
        {
            Account a = null;
            DataRowCollection rows = (DataRowCollection)QueryBuilder.table(table)
                .select()
                .where("username", acc.username)
                .where("password", acc.password)
                .execute();
            foreach (DataRow row in rows)
            {
                a = new Account();
                a.id = (int)row["id"];
                a.username = (string)row["username"];
                a.password = (string)row["password"];
            }
            return a;
        }

        public void delete(object x)
        {

            List<int> ids = DataModel.medMdl.searchByAccount((int)x);

            // delete relationship
            DataModel.plmedMdl.deleteByAccount((int)x);

            // delete medias
            foreach (int id in ids)
            {
                delete(id);
            }

            // delete playlist
            DataModel.plMdl.deleteByAccount((int)x);

            // delete account
            QueryBuilder.table(table)
                .delete()
                .where("id", x)
                .execute();
        }

        public bool insert(Account x)
        {
            var pairs = QueryBuilder.getDictionary();
            pairs.Add("username", x.username);
            pairs.Add("password", x.password);

            int c = (int) QueryBuilder.table(table)
                .insert(pairs)
                .execute();

            return c != 0;
        }

        public List<Account> list()
        {
            List<Account> accounts = new List<Account>();
            DataRowCollection rows = (DataRowCollection)QueryBuilder.table(table)
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
            var pairs = QueryBuilder.getDictionary();
            pairs.Add("username", x.username);
            pairs.Add("password", x.password);

            QueryBuilder.table("Account")
                .update(pairs)
                .where("id", x.id)
                .execute();
        }
    }
}
