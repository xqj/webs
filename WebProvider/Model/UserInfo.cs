using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Webs.Model
{
    [DataContract]
    public class UserInfo : ModelBase
    {
        [DataMember]
        public int UserId { get; set; }
        [DataMember]
        public string LoginName { set; get; }
        [DataMember]
        public string pwd { set; get; }
        [DataMember]
        public string UserName { set; get; }
        [DataMember]
        public string Mobile { set; get; }
        [DataMember]
        public string QQ { set; get; }
        [DataMember]
        public string Email { set; get; }
      
    }
}
