using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webs.Model;

namespace Webs.Dao
{
  internal  class LableDao
    {
        internal static List<Lable> GetShowIndexLables(int lableCount)
        {
            List<Lable> list = new List<Model.Lable>();
            StringBuilder sqlCmd = new StringBuilder("select * from Lable");           
			sqlCmd.Append(" where Enable=1 and IsShowIndex=1 order by IndexShowSort asc limit ");
			sqlCmd.Append(lableCount.ToString());
            using (var dr = MysqlHelper.ExcuteReader(sqlCmd.ToString()))
            {
                while (dr.Read())
                {
                    Lable data = new Lable()
                    {
                        LableId = dr.GetInt32("LableId"),
                        LableName = dr["LableName"].ToString(),
                        CreateBy = dr.GetInt32("CreateBy"),
                        CreateTime = dr.GetDateTime("CreateTime"),
                        Enable = dr.GetBoolean("Enable"),
                        IndexShowSort = dr.GetInt32("IndexShowSort"),
                        IsShowIndex = dr.GetBoolean("IsShowIndex"),
                        ModifyBy = dr.GetInt32("ModifyBy"),
                        ModifyTime = dr.GetDateTime("ModifyTime"),                        
                    };
                    list.Add(data);
                }
            }
            if (list.Count == 0) list = null;
            return list;
        }
    }
}
