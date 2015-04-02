using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Webs.Dao;
using Webs.Model;

namespace Webs.Provider
{
  public  class ChannelProvider
    {
        private static ChannelProvider _intance = new ChannelProvider();

		public static ChannelProvider Intance
        {
            get { return _intance; }           
        }

        internal OperationResult<List<Channel>> GetShowIndexChannels(int channelCount,int siteId)
        {
            List<Channel> list = ChannelDao.GetShowIndexChannels(channelCount, siteId);
            var result = new OperationResult<List<Channel>>(list,(list == null));
            return result;
        }

        internal OperationResult<List<Channel>> GetAllList(int siteId)
        {
            List<Channel> list = ChannelDao.GetAllList(siteId);
            var result = new OperationResult<List<Channel>>(list, (list != null));
            return result;
        }
		public OperationResult<Channel> GetById(int siteId,int id)
		{
			Channel info = ChannelDao.GetById (siteId, id);
			var result = new OperationResult<Channel>(info, (info != null));
			return result;
		}
    }
}
