using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Webs.Model
{
     [DataContract]
    public class OperationResult<T>
    {
         public OperationResult(T data,bool result)
         {
             Data = data;
             m_Result = result;
         }
         public OperationResult(bool result)
         {
             m_Result = result;
         }
        private bool m_Result = false;
         [DataMember]
        public bool Result
        {
            get
            {
                return m_Result;
            }
            set
            {
                m_Result = value;
            }
        }
          [DataMember]
        public string Message
        {
            set;
            get;
        }
          [DataMember]
        public T Data
        {
            set;
            get;
        }
          [DataMember]
        public int Code
        {
            set;
            get;
        }
    }
}
