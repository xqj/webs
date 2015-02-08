using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Webs.Dao;
using Webs.Model;

namespace Webs.Provider
{
  public  class InfoProvider
    {
        private static InfoProvider _instance = new InfoProvider();

		public static InfoProvider Instance
        {
            get { return InfoProvider._instance; }           
        }

		public OperationResult<List<Info>> GetListByChannelId(int channelId)
        {
            List<Info> list = InfoDao.GetListByChannelId(channelId);
            var result = new OperationResult<List<Info>>(list, (list != null));
            return result;
        }
		public OperationResult<List<Info>> GetTopListByChannelId(int channelId,int total)
        {
            List<Info> list = InfoDao.GetListByChannelId(channelId, total);
            var result = new OperationResult<List<Info>>(list, (list != null));
            return result;
        }
		public OperationResult<Info> GetInfoById(int id)
        {
            Info list = InfoDao.GetInfoById(id);
            var result = new OperationResult<Info>(list, (list != null));
            return result;
        }

		public GridPage<Info> GetPager(int pageSize, int pageCurrentIndex,int channelId)
        {
            return InfoDao.GetPager(pageSize, pageCurrentIndex, channelId);
        }

		public OperationMsg Edit(int userId,int infoId, int channelId, int ShowSort, string infoTitle, string infoContent, bool Enable, string TitleImg,string jumpUrl)
        {
            if (infoId > 0)
                return new OperationMsg(InfoDao.Edit(userId, infoId, channelId, ShowSort, infoTitle, infoContent, Enable, TitleImg));
            else
            {
                int id = InfoDao.Insert(userId, channelId, ShowSort, infoTitle, infoContent, Enable, TitleImg, jumpUrl);
                if (id > 0)
                {
                    Channel_Info_RelationDao.Insert(id, channelId);
                }
                return new OperationMsg(id > 0);
            }
        }

		public OperationResult<Info> GetAdminInfoById(int id)
        {
            Info info = InfoDao.GetAdminInfoById(id);
            var result = new OperationResult<Info>(info, (info != null));
            return result;
        }

		public OperationResult<bool> Delete(int id)
        {
             var result = new OperationResult<bool>(InfoDao.Delete(id));
            return result;
        }
    }
}
