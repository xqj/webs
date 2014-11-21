﻿using System;
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

        internal static ChannelProvider Intance
        {
            get { return ChannelProvider._intance; }           
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
            var result = new OperationResult<List<Channel>>(list, (list == null));
            return result;
        }
    }
}
