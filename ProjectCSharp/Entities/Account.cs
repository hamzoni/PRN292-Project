using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectCSharp.Entities
{
    [Serializable]
    public class Account
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
