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

        public void delete(object x)
        {
            // get all playlist linked to this account
            List<Playlist> playlists = DataModel.plMdl.searchByAccount((int)x);

            // get all media related to this account
            List<Media> medias = new List<Media>();

            foreach (Playlist pl in playlists)
            {
                List<Media> mdl = DataModel.medMdl.searchByPlaylist(pl.id);
                medias.AddRange(mdl);
            }

            // delete all playlist linked to this account
            DataModel.plMdl.deleteByAccount((int) x);

            // delete all media related to this account
            foreach (Media media in medias)
            {
                DataModel.medMdl.delete(media.id);
            }

            // delete itself
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
