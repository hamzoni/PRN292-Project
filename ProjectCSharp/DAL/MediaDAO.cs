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
    class MediaDAO : DAO, IDAO<Media>
    {
        private string table = "Media";

        public int count(int playlist_id)
        {
            int c = (int) QueryBuilder.table(table)
               .count()
               .join("PlayList_Media", "id", "media_id")
               .where("playlist_id", playlist_id)
               .execute();
            return c;
        }

        public void delete(object x)
        {
            QueryBuilder.table(table)
                .delete()
                .where("id", x);
        }

        public int insertGetId(Media x)
        {
            var dict = QueryBuilder.getDictionary();
            dict.Add("name", x.name);
            dict.Add("url", x.url);
            dict.Add("type", x.type);

            return QueryBuilder.table(table)
                .insertGetID(dict);
        }

        public bool insert(Media x)
        {
            var dict = QueryBuilder.getDictionary();
            dict.Add("name", x.name);
            dict.Add("url", x.url);
            dict.Add("type", x.type);

            int c = (int) QueryBuilder.table(table)
                .insert(dict)
                .execute();

            return c != 0;
        }

        public List<int> searchByAccount(int accountID)
        {
            List<int> list = new List<int>();

            string query = " SELECT Media.id FROM Media  " +
                " RIGHT JOIN Playlist_Media  " +
                " ON Media.id = Playlist_Media.media_id " +
                " RIGHT JOIN Playlist " +
                " ON Playlist.id = Playlist_Media.playlist_id " +
                " WHERE account_id = " + accountID;

            DataSet ds = new DataSet();

            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                list.Add((Int32.Parse(r["id"].ToString())));
            }

            return list;
        }

        public List<Media> searchByPlaylist(int playlistID)
        {
            List<Media> items = new List<Media>();

            DataRowCollection rows = (DataRowCollection)QueryBuilder.table(table)
                .select()
                .join("PlayList_Media", "id", "media_id")
                .where("playlist_id", playlistID)
                .execute();

            foreach (DataRow row in rows)
            {
                Media item = new Media();
                item.id = (int)row["id"];
                item.name = (string)row["name"];
                item.url = (string)row["url"];
                item.type = (bool)row["type"];
                items.Add(item);
            }

            return items;
        }

        public List<Media> list()
        {
            List<Media> items = new List<Media>();
            DataRowCollection rows = (DataRowCollection)QueryBuilder.table("Account")
                .select()
                .execute();
            foreach (DataRow row in rows)
            {
                Media item = new Media();
                item.id = (int)row["id"];
                item.name = (string)row["name"];
                item.url = (string)row["url"];
                item.type = (bool)row["type"];
                items.Add(item);
            }
            return items;
        }

        public void update(Media x)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("name", x.name);

            QueryBuilder.table(table)
                .update(pairs)
                .where("id", x.id)
                .execute();
        }
    }
}
