using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Webs.Model
{
    [DataContract]
   public class ModelBase
    {
        [DataMember]
        public bool Enable { set; get; }
        [DataMember]
        public DateTime CreateTime { set; get; }
        [DataMember]
        public DateTime ModifyTime { set; get; }
        [DataMember]
        public int CreateBy { set; get; }
        [DataMember]
        public int ModifyBy { set; get; }
    }
}
