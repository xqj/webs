using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Webs.Model;

namespace Webs.ViewModel
{
	[DataContract]
   public class ChannelView:Channel
    {
		public ChannelView(Channel channelBase){
			this.ChannelId = channelBase.ChannelId;
			this.ChannelName = channelBase.ChannelName;
			this.CreateBy = channelBase.CreateBy;
			this.CreateTime = channelBase.CreateTime;
			this.Enable = channelBase.Enable;
			this.IndexShowSort = channelBase.IndexShowSort;
			this.InfoTotal = channelBase.InfoTotal;
			this.IsShowIndex = channelBase.IsShowIndex;
			this.ModifyBy = channelBase.ModifyBy;
			this.ModifyTime = channelBase.ModifyTime;
			this.SiteId = channelBase.SiteId;
		
		}
		[DataMember]
       public List<Info> ChannelContent { set; get; }
    }
}
