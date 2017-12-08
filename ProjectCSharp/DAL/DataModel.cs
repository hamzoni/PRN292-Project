using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectCSharp.DAL
{
    class DataModel
    {
        public static AccountDAO accMdl = new AccountDAO();
        public static MediaDAO medMdl = new MediaDAO();
        public static PlayListDAO plMdl = new PlayListDAO();
    }
}
