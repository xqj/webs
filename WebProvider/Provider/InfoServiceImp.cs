using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Webs.Provider
{
  public  class InfoProvider
    {
        private static InfoProvider _instance = new InfoProvider();

        public static InfoProvider Instance
        {
            get { return InfoProvider._instance; }           
        }

        internal List<Model.Info> GetListByChannelId(int channelId)
        {
            throw new NotImplementedException();
        }

        internal Model.Info GetInfoById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
