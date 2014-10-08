using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Webs.Model
{
    [DataContract]
    public class UserInfo
    {
        [DataMember]
        public int UserId { get; set; }
    }
}
