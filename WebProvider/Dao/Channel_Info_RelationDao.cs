using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webs.Dao
{
  internal  class Channel_Info_RelationDao
    {
        internal static bool Insert(int id, int channelId)
        {
            string sqlCmd = string.Format("insert Channel_Info_Relation(ChannelId,InfoId,CreateTime) values ({0},{1},{2})",channelId.ToString(),id.ToString(),"now()");
            return MysqlHelper.ExecuteNonQuery(sqlCmd) > 0;
        }
    }
}
