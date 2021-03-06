﻿using ProjectCSharp.Database;
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
        private string table = "PlayList";

        public List<Playlist> searchByAccount(int accountID)
        {
            List<Playlist> lists = new List<Playlist>();

            DataRowCollection rows = (DataRowCollection)QueryBuilder.table(table)
                .select()
                .where("account_id", accountID)
                .execute();

            foreach (DataRow row in rows)
            {
                Playlist playlist = new Playlist();
                playlist.id = (int)row["id"]; ;
                playlist.name = (string)row["name"];
                playlist.medias = DataModel.medMdl.searchByPlaylist(playlist.id);
                playlist.count = count(playlist.id);

                lists.Add(playlist);
            }
            return lists;
        }

        public Playlist search(int playlistID, int accountID)
        {
            Playlist playlist = null;
            DataRowCollection rows = (DataRowCollection) QueryBuilder.table(table)
                .select()
                .where("id", playlistID)
                .where("account_id", accountID)
                .execute();

            foreach (DataRow row in rows)
            {
                playlist = new Playlist();
                playlist.id = playlistID;
                playlist.name = (string) row["name"];
                playlist.medias = DataModel.medMdl.searchByPlaylist(playlistID);
                playlist.count = count(playlistID);
                break;
            }
            return playlist;
        }

        public int count(int id)
        {
            int c = (int) QueryBuilder.table(table)
                .count()
                .where("id", id)
                .execute();
            return c;
        }

        public int count(string name)
        {
            int c = (int)QueryBuilder.table(table)
                .count()
                .where("name", name)
                .execute();
            return c;
        }

        public void delete(object x)
        {
            List<Media> mIDs = DataModel.medMdl.searchByPlaylist((int)x);

            // delete in n-n table first
            DataModel.plmedMdl.deleteByPlaylist((int)x);

            // delete medias
            foreach (Media m in mIDs)
            {
                DataModel.medMdl.delete(m.id);
            }

            // delete in official table
            QueryBuilder.table(table)
                .delete()
                .where("id", x)
                .execute();
        }

        public void deleteByAccount(int accountID)
        {
            QueryBuilder.table(table)
                .delete()
                .where("account_id", accountID)
                .execute();
        }

        public bool insert(Playlist playlist)
        {
            // there must be no duplicated playlist name
            if (count(playlist.name) != 0) return false;

            // the user account must be available to be added
            
            if (DataModel.accMdl.count(playlist.user.id) == 0) return false;

            // create playlist first
            var dict = QueryBuilder.getDictionary();
            dict.Add("name", playlist.name);
            dict.Add("account_id", playlist.user.id);

            int playlistID = (int)QueryBuilder.table(table)
                .insertGetID(dict);

            // add medias
            foreach (Media media in playlist.medias)
            {
                // create media
                int mediaID = DataModel.medMdl.insertGetId(media);

                // create relationship between media and playlist
                PlaylistMedia plmed = new PlaylistMedia();
                plmed.playlist.id = playlistID;
                plmed.media.id = mediaID;
                
                DataModel.plmedMdl.insert(plmed);
            }

            return true;
        }

        public List<Playlist> list()
        {
            return null;
        }

        public List<Playlist> list(int account_id)
        {
            List<Playlist> lists = new List<Playlist>();
            DataRowCollection rows = (DataRowCollection) QueryBuilder.table(table)
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

        public void update(Playlist x)
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
