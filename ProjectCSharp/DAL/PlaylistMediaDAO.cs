using ProjectCSharp.Database;
using ProjectCSharp.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ProjectCSharp.DAL
{
    class PlaylistMediaDAO : DAO, IDAO<PlaylistMedia>
    {
        private string table = "PlayList_Media";

        public void deleteByPlaylist(int id)
        {
            QueryBuilder.table(table)
                .delete()
                .where("playlist_id", id)
                .execute();
        }

        public void deleteByMedia(int id)
        {
            QueryBuilder.table(table)
                .delete()
                .where("media_id", id)
                .execute();
        }

        public void deleteByAccount(int id)
        {
            string query = "DELETE Playlist_Media FROM Playlist_Media " +
                " RIGHT JOIN Playlist " +
                " ON Playlist_Media.playlist_id = Playlist.id " +
                " WHERE account_id = " + id;

            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void delete(object x)
        {
        }

        public bool insert(PlaylistMedia x)
        {
            var pairs = QueryBuilder.getDictionary();
            pairs.Add("playlist_id", x.playlist.id);
            pairs.Add("media_id", x.media.id);

            int c = (int)QueryBuilder.table(table)
                .insert(pairs)
                .execute();

            return c != 0;
        }

        public List<PlaylistMedia> list()
        {
            return null;
        }

        public void update(PlaylistMedia x)
        {
        }
    }
}
