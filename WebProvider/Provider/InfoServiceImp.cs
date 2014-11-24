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

        internal static InfoProvider Instance
        {
            get { return InfoProvider._instance; }           
        }

        internal OperationResult<List<Info>> GetListByChannelId(int channelId)
        {
            List<Info> list = InfoDao.GetListByChannelId(channelId);
            var result = new OperationResult<List<Info>>(list, (list == null));
            return result;
        }
        internal OperationResult<List<Info>> GetTopListByChannelId(int channelId,int total)
        {
            List<Info> list = InfoDao.GetListByChannelId(channelId, total);
            var result = new OperationResult<List<Info>>(list, (list == null));
            return result;
        }
        internal OperationResult<Info> GetInfoById(int id)
        {
            Info list = InfoDao.GetInfoById(id);
            var result = new OperationResult<Info>(list, (list == null));
            return result;
        }

        internal GridPage<Info> GetPager(int pageSize, int pageCurrentIndex,int channelId)
        {
            return InfoDao.GetPager(pageSize, pageCurrentIndex, channelId);
        }
    }
}
