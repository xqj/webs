using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webs.Model;

namespace Webs.Dao
{
    internal class InfoDao
    {
        internal static List<Info> GetListByChannelId(int channelId)
        {
            List<Info> list = new List<Info>();
            StringBuilder sqlCmd = new StringBuilder("SELECT a.ShowSort,a.InfoTitle,a.InfoContent,a.TitleImg,a.`Enable`,a.CreateTime,a.ModifyTime,a.CreateBy,a.ModifyBy,a.IsDelete,b.InfoId FROM Info AS a INNER JOIN Channel_Info_Relation AS b ON a.InfoId = b.InfoId WHERE a.IsDelete=0 and a.Enable=1 and b.ChannelId =");
            sqlCmd.Append(channelId.ToString());
            using (var dr = MysqlHelper.ExcuteReader(sqlCmd.ToString()))
            {
                while (dr.Read())
                {
                    Info data = new Info()
                    {
                        InfoContent = dr["InfoTitle"].ToString(),
                        ShowSort = dr.GetInt32("ShowSort"),
                        InfoId = dr.GetInt32("InfoId"),
                        InfoTitle = dr["InfoTitle"].ToString(),
                        CreateBy = dr.GetInt32("CreateBy"),
                        CreateTime = dr.GetDateTime("CreateTime"),
                        Enable = dr.GetBoolean("Enable"),
                        ModifyBy = dr.GetInt32("ModifyBy"),
                        ModifyTime = dr.GetDateTime("ModifyTime"),
                        TitleImg = dr["TitleImg"].ToString(),

                    };
                    list.Add(data);
                }
            }
            if (list.Count == 0) list = null;
            return list;
        }

        internal static Model.Info GetInfoById(int id)
        {
            StringBuilder sqlCmd = new StringBuilder("SELECT * FROM Info WHERE IsDelete=0 and Enable=1 and InfoId =");
            sqlCmd.Append(id.ToString());
            Info data = null;
            using (var dr = MysqlHelper.ExcuteReader(sqlCmd.ToString()))
            {
                if (dr.Read())
                {
                    data = new Info()
                   {
                       InfoContent = dr["InfoTitle"].ToString(),
                       ShowSort = dr.GetInt32("ShowSort"),
                       InfoId = dr.GetInt32("InfoId"),
                       InfoTitle = dr["InfoTitle"].ToString(),
                       CreateBy = dr.GetInt32("CreateBy"),
                       CreateTime = dr.GetDateTime("CreateTime"),
                       Enable = dr.GetBoolean("Enable"),
                       ModifyBy = dr.GetInt32("ModifyBy"),
                       ModifyTime = dr.GetDateTime("ModifyTime"),
                       TitleImg = dr["TitleImg"].ToString(),

                   };
                }
            }
            return data;
        }

        internal static List<Info> GetListByChannelId(int channelId, int total)
        {
            List<Info> list = new List<Info>();
            StringBuilder sqlCmd = new StringBuilder("SELECT a.ShowSort,a.InfoTitle,a.InfoContent,a.TitleImg,a.`Enable`,a.CreateTime,a.ModifyTime,a.CreateBy,a.ModifyBy,a.IsDelete,b.InfoId FROM Info AS a INNER JOIN Channel_Info_Relation AS b ON a.InfoId = b.InfoId WHERE a.IsDelete=0 and a.Enable=1 and b.ChannelId =");
            sqlCmd.Append(channelId.ToString());
            sqlCmd.Append(" order by ShowSort desc");
            sqlCmd.Append(" limit ");
            sqlCmd.Append(total.ToString());
           
            using (var dr = MysqlHelper.ExcuteReader(sqlCmd.ToString()))
            {
                while (dr.Read())
                {
                    Info data = new Info()
                    {
                        InfoContent = dr["InfoTitle"].ToString(),
                        ShowSort = dr.GetInt32("ShowSort"),
                        InfoId = dr.GetInt32("InfoId"),
                        InfoTitle = dr["InfoTitle"].ToString(),
                        CreateBy = dr.GetInt32("CreateBy"),
                        CreateTime = dr.GetDateTime("CreateTime"),
                        Enable = dr.GetBoolean("Enable"),
                        ModifyBy = dr.GetInt32("ModifyBy"),
                        ModifyTime = dr.GetDateTime("ModifyTime"),
                        TitleImg = dr["TitleImg"].ToString(),

                    };
                    list.Add(data);
                }
            }
            if (list.Count == 0) list = null;
            return list;
        }

        internal static GridPage<Info> GetPager(int pageSize, int pageCurrentIndex,int channelId)
        {
            GridPage<Info> result = new GridPage<Info>() { 
             CurrentPage=pageCurrentIndex,
              PageSize=pageSize,               
            };
            List<Info> list = new List<Info>();
            StringBuilder sqlCmd = new StringBuilder("SELECT a.ShowSort,a.InfoTitle,a.InfoContent,a.TitleImg,a.`Enable`,a.CreateTime,a.ModifyTime,a.CreateBy,a.ModifyBy,a.IsDelete,b.InfoId FROM Info AS a INNER JOIN Channel_Info_Relation AS b ON a.InfoId = b.InfoId WHERE a.IsDelete=0 and a.Enable=1 and b.ChannelId =");
            sqlCmd.Append(channelId.ToString());
            sqlCmd.Append(" order by ShowSort desc");
            sqlCmd.Append(" limit ");
            sqlCmd.Append((pageCurrentIndex * pageSize - 1).ToString() + "," + pageSize.ToString());
            using (var dr = MysqlHelper.ExcuteReader(sqlCmd.ToString()))
            {
                while (dr.Read())
                {
                    Info data = new Info()
                    {
                        InfoContent = dr["InfoTitle"].ToString(),
                        ShowSort = dr.GetInt32("ShowSort"),
                        InfoId = dr.GetInt32("InfoId"),
                        InfoTitle = dr["InfoTitle"].ToString(),
                        CreateBy = dr.GetInt32("CreateBy"),
                        CreateTime = dr.GetDateTime("CreateTime"),
                        Enable = dr.GetBoolean("Enable"),
                        ModifyBy = dr.GetInt32("ModifyBy"),
                        ModifyTime = dr.GetDateTime("ModifyTime"),
                        TitleImg = dr["TitleImg"].ToString(),

                    };
                    list.Add(data);
                }
            }
            result.List = list;
            return result;
        }


        internal static bool Edit(int userId, int infoId, int channelId, int ShowSort, string infoTitle, string infoContent, bool Enable, string TitleImg)
        {
            string sqlCmd = string.Format("update info set ShowSort={0},InfoTitle={1},InfoContent={2},TitleImg={3},Enable={4},ModifyTime=now(),ModifyBy={5} where InfoId={6}", ShowSort.ToString(), infoTitle, infoContent, TitleImg, Enable ? "1" : "0", userId.ToString(), infoId.ToString());
           return MysqlHelper.ExecuteNonQuery(sqlCmd) > 0;
        }

        internal static int Insert(int userId,  int channelId, int ShowSort, string infoTitle, string infoContent, bool Enable, string TitleImg)
        {
            string sqlCmd = string.Format("insert Info(ShowSort,InfoTitle,InfoContent,TitleImg,Enable,CreateTime,CreateBy) values({0},{1},{2},{3},{4},{5},{6});select mysql_insert_id();", ShowSort.ToString(), infoTitle, infoContent, TitleImg, Enable ? "1" : "0", "now()", userId);
             int  dataId = 0;
            using (var dr = MysqlHelper.ExcuteReader(sqlCmd.ToString()))
            {
                if (dr.Read())
                {
                   dataId=dr.GetInt32(0);
                }
            }
            return dataId;
        }
    }
}
