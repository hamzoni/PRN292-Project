using ProjectCSharp.Database;
using ProjectCSharp.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProjectCSharp.DAL
{
    class PlayListDAO : DAO, IDAO<Playlist>
    {
        public Playlist search(string listname, string username)
        {
            Playlist playlist = null;
            DataRowCollection rows = (DataRowCollection) QueryBuilder.table("PlayList")
                .select()
                .where("ListName", QueryBuilder.AND, listname)
                .where("UserName", QueryBuilder.AND, username)
                .execute();

            foreach (DataRow row in rows)
            {
                playlist = new Playlist();
                playlist.name = listname;
                playlist.medias = DataModel.medMdl.searchByPlaylist(listname);
                playlist.count = count(listname);
                break;
            }
            return playlist;
        }

        public int count(string listname)
        {
            int c = (int) QueryBuilder.table("PlayList")
                .count()
                .where("ListName", QueryBuilder.AND, listname)
                .execute();
            return c;
        }

        public void delete(object x)
        {
            // delete in n-n table first
            QueryBuilder.table("PlayList_Media")
                .delete()
                .where("ListName", QueryBuilder.AND, x)
                .execute();
            // delete in official table
            QueryBuilder.table("PlayList")
                .delete()
                .where("ListName", QueryBuilder.AND, x)
                .execute();
        }

        public bool insert(Playlist x, string username)
        {
            // there must be no duplicated playlist name
            if (count(x.name) != 0) return false;
            // the username must be available to be valid
            if (DataModel.accMdl.count(username) == 0) return false;

            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("ListName", x.name);

            int c = (int) QueryBuilder.table("PlayList")
                .insert(dict)
                .execute();
            // add medias



            if (c == 0) return false;

            return true;
        }

        public List<Playlist> list()
        {
            return null;
        }

        public List<Playlist> list(int account_id)
        {
            List<Playlist> lists = new List<Playlist>();
            DataRowCollection rows = (DataRowCollection) QueryBuilder.table("Playlist")
                .select()
                .where("account_id", account_id)
                .execute();

            foreach (DataRow row in rows)
            {
                Playlist pl = new Playlist();
                pl.id = (int)row["id"];
                pl.name = (string)row["name"];
                pl.count = DataModel.medMdl.count(pl.id);
                pl.id = (int)row["id"];
            }
            return null;
        }

        public bool insert(Playlist x)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("name", x.name);

            int c = (int) QueryBuilder.table("PlayList")
                .insert(pairs)
                .execute();

            return c != 0;
        }

        public void update(Playlist x)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("name", x.name);

            QueryBuilder.table("PlayList")
                .update(pairs)
                .where("id", x.id)
                .execute();
        }
    }
}
