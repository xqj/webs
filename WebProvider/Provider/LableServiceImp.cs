using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Webs.Model;

namespace Webs.Provider
{
   public class LableProvider
    {
        private static LableProvider _instance = new LableProvider();

        public static LableProvider Instance
        {
            get { return LableProvider._instance; }          
        }

        internal List<Lable> GetShowIndexLables(int lableCount)
        {
            throw new NotImplementedException();
        }
    }
}
