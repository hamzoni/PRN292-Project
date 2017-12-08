using ProjectCSharp.Database;
using ProjectCSharp.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProjectCSharp.DAL
{
    class MediaDAO : DAO, IDAO<Media>
    {

        public int count(int playlist_id)
        {

            return -1;
        }

        public void delete(object x)
        {
            QueryBuilder.table("Media")
                .delete()
                .where("id", x);
        }

        public bool insert(Media x)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("name", x.name);
            dict.Add("url", x.url);
            dict.Add("type", x.type);

            int c = (int) QueryBuilder.table("Media")
                .insert(dict)
                .execute();

            return c != 0;
        }

        public List<Media> searchByPlaylist(string listname)
        {
            List<Media> items = new List<Media>();

            DataRowCollection rows = (DataRowCollection)QueryBuilder.table("Account")
                .select()
                .where("name", QueryBuilder.AND, listname)
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

            QueryBuilder.table("Media")
                .update(pairs)
                .where("id", x.id)
                .execute();
        }
    }
}
