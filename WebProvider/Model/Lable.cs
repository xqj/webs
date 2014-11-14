using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Webs.Model
{
    [DataContract]
    public class Lable : ModelBase
    {
        [DataMember]
        public int LableId { set; get; }
        [DataMember]
        public string LableName { set; get; }
        [DataMember]
        public bool IsShowIndex { set; get; }
        [DataMember]
        public int IndexShowSort { set; get; }
    }
}
