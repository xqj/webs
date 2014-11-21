using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Webs.Common
{
   public class WebConfigHelper
    {
       public static string GetConfig(string key)
       {
           return ConfigurationManager.ConnectionStrings[key].ToString();
       }
    }
}
