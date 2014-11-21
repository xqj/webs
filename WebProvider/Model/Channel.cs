using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Webs.Model
{
    [DataContract]
    public class Channel : ModelBase
    {
        [DataMember]
        public int ChannelId { set; get; }
        [DataMember]
        public string ChannelName { set; get; }
        [DataMember]
        public int InfoTotal { set; get; }
        [DataMember]
        public bool IsShowIndex { set; get; }
        [DataMember]
        public int IndexShowSort { set; get; }
          [DataMember]
        public int SiteId { set; get; }
    }
}
