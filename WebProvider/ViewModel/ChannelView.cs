using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Webs.Model;

namespace Webs.ViewModel
{
   public class ChannelView:Channel
    {
       public List<Info> ChannelContent { set; get; }
    }
}
