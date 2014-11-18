using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Webs.Model;

namespace Webs.Provider
{
  public  class ChannelProvider
    {
        private static ChannelProvider _intance = new ChannelProvider();

        public static ChannelProvider Intance
        {
            get { return ChannelProvider._intance; }           
        }

        internal List<Channel> GetShowIndexChannels(int channelCount,int siteId)
        {
            throw new NotImplementedException();
        }

        internal List<Channel> GetAllList(int siteId)
        {
            throw new NotImplementedException();
        }
    }
}
