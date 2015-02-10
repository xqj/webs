using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Webs.Model;

namespace Webs.Model
{
    [DataContract]
    public class Info : ModelBase
    {
        [DataMember]
        public int InfoId { set; get; }
        [DataMember]
        public string InfoTitle { set; get; }
        [DataMember]
        public string InfoContent { set; get; }
        [DataMember]
        public string TitleImg { set; get; }
		[DataMember]
		public bool IsTitleImg { set; get; }
        [DataMember]
        public int ShowSort { set; get; }
    }
}
