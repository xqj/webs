using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webs.Common;
using Webs.Model;

namespace Webs.Dao
{
    internal class ChannelDao
    {
        internal static List<Model.Channel> GetShowIndexChannels(int channelCount, int siteId)
        {
            List<Channel> list = new List<Model.Channel>();
            StringBuilder sqlCmd = new StringBuilder("select * from Channel");           
            sqlCmd.Append(" where IsDelete=0 and Enable=1 and IsShowIndex=1 and SiteId=");
            sqlCmd.Append(siteId.ToString());
			sqlCmd.Append(" order by IndexShowSort asc limit");
			sqlCmd.Append(channelCount.ToString());
            using (var dr = MysqlHelper.ExcuteReader(sqlCmd.ToString()))
            {
                while (dr.Read())
                {
                    Channel data = new Channel() {
                        ChannelId = dr.GetInt32("ChannelId"),
                        ChannelName = dr["ChannelName"].ToString(),
                        CreateBy = dr.GetInt32("CreateBy"),
                        CreateTime = dr.GetDateTime("CreateTime"),
                        Enable = dr.GetBoolean("Enable"),
                        IndexShowSort = dr.GetInt32("IndexShowSort"),
                        InfoTotal = dr.GetInt32("InfoTotal"),
                        IsShowIndex = dr.GetBoolean("IsShowIndex"),
                        ModifyBy = dr.GetInt32("ModifyBy"),
                        ModifyTime = dr.GetDateTime("ModifyTime"),
                        SiteId = dr.GetInt32("SiteId"),
                    };
                    list.Add(data);
                }
            }
            if (list.Count == 0) list = null;
            return list;
        }

        internal static List<Model.Channel> GetAllList(int siteId)
        {
            List<Model.Channel> list = new List<Model.Channel>();
            StringBuilder sqlCmd = new StringBuilder("select * from Channel");
            sqlCmd.Append(" where IsDelete=0 and Enable=1 and SiteId=");
            sqlCmd.Append(siteId.ToString());
            using (var dr = MysqlHelper.ExcuteReader(sqlCmd.ToString()))
            {
                while (dr.Read())
                {
                    Channel data = new Channel()
                    {
                        ChannelId = dr.GetInt32("ChannelId"),
                        ChannelName = dr["ChannelName"].ToString(),
                        CreateBy = dr.GetInt32("CreateBy"),
                        CreateTime = dr.GetDateTime("CreateTime"),
                        Enable = dr.GetBoolean("Enable"),
                        IndexShowSort = dr.GetInt32("IndexShowSort"),
                        InfoTotal = dr.GetInt32("InfoTotal"),
                        IsShowIndex = dr.GetBoolean("IsShowIndex"),
                        ModifyBy = dr.GetInt32("ModifyBy"),
                        ModifyTime = dr.GetDateTime("ModifyTime"),
                        SiteId = dr.GetInt32("SiteId"),
                    };
                    list.Add(data);
                }
            }
            if (list.Count == 0) list = null;
            return list;
        }
		internal static Channel GetInfoById(int channelid)
		{
			StringBuilder sqlCmd = new StringBuilder("select * from Channel");
			sqlCmd.Append(" where ChannelId=");
			sqlCmd.Append(channelid.ToString());
			Channel data = null;
			using (var dr = MysqlHelper.ExcuteReader(sqlCmd.ToString()))
			{
				if (dr.Read())
				{
					data = new Channel()
					{
						ChannelId = dr.GetInt32("ChannelId"),
						ChannelName = dr["ChannelName"].ToString(),
						CreateBy = dr.GetInt32("CreateBy"),
						CreateTime = dr.GetDateTime("CreateTime"),
						Enable = dr.GetBoolean("Enable"),
						IndexShowSort = dr.GetInt32("IndexShowSort"),
						InfoTotal = dr.GetInt32("InfoTotal"),
						IsShowIndex = dr.GetBoolean("IsShowIndex"),
						ModifyBy = dr.GetInt32("ModifyBy"),
						ModifyTime = dr.GetDateTime("ModifyTime"),
						SiteId = dr.GetInt32("SiteId"),
					};                  
				}
			}

			return data;
		}
    }
}
