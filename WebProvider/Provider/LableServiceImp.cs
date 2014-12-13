using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Webs.Dao;
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

        internal OperationResult<List<Lable>> GetShowIndexLables(int lableCount)
        {
            List<Lable> list = LableDao.GetShowIndexLables(lableCount);
            var result = new OperationResult<List<Lable>>(list, (list != null));
            return result;
        }
    }
}
