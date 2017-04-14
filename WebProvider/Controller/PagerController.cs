using Webs.Model;
using Webs.Provider;

namespace Webs.WebProvider
{
  public  class PagerController
    {
        private int _siteId = 2;
        public GridPage<Info> List(int pageSize, int pageCurrentIndex, int channelId, int simpleSize)
        {
            var infos = InfoProvider.Instance.GetPager(pageSize, pageCurrentIndex, channelId);
            if (infos.List != null)
            {
                infos.List.ForEach(a => {
                    if(simpleSize>0)
                    a.InfoContent = (a.InfoContent.Length > simpleSize) ? (a.InfoContent.Substring(0, (simpleSize - 4)) + "...") : a.InfoContent;
                });
            }
            return infos;
        }
    }
}
