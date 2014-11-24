using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webs.Common;

namespace Webs.Dao
{
    internal class MysqlHelper
    {
        internal static MySqlDataReader ExcuteReader(string sqlCmd)
        {
            MySqlConnection con = new MySqlConnection(WebConfigHelper.GetConfig(DefineTable.DatabaseConstr));
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
            return cmd.ExecuteReader();
        }
      
    }
}
