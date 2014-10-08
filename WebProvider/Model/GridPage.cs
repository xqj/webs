using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Webs.Model
{
    [DataContract]
    public class GridPage<T>
    {
        public GridPage(int total, int pageSize,List<T> list)
        {
            this.List = list;
            this.Total = total;
            this.PageSize = pageSize;
            TotalPage = total / pageSize;
        }
        public GridPage()
        {
          
        }
        [DataMember]
        public int CurrentPage
        {
            get;
            set;
        }
        [DataMember]
        public int PageSize
        {
            get;
            set;
        }
        [DataMember]
        public int TotalPage
        {
            get;
            set;
        }
        [DataMember]
        public int Total
        {
            get;
            set;
        }
        [DataMember]
        public List<T> List
        {
            get;
            set;
        }
    }
}
