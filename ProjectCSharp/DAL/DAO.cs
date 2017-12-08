using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ProjectCSharp.DAL
{
    class DAO
    {
        protected string cs = ConfigurationManager.ConnectionStrings["DBI"].ConnectionString;
        protected SqlConnection con;
    }
}
