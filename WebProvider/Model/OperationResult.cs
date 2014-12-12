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
         public static  class DefaultConfig
         {            
             /// <summary>
             /// 方法调用成功
             /// </summary>
             public static readonly String DefaultMessage = "方法已调用";
             /// <summary>
             /// 1
             /// </summary>
             public static readonly OperationResultCodeType DefaultResultCode = OperationResultCodeType.Fail;
         }
         public OperationResult(T data,bool result)
         {
             Data = data;
             m_Result = result;
             if (!result)
             Code = DefaultConfig.DefaultResultCode;
             Message = DefaultConfig.DefaultMessage;
         }
         public OperationResult(bool result)
         {
             m_Result = result;
             if(!result)
             Code = DefaultConfig.DefaultResultCode;
             Message = DefaultConfig.DefaultMessage;
         }
         /// <summary>
         /// 默认结果失败
         /// </summary>
         public OperationResult()
         {
             Code = DefaultConfig.DefaultResultCode;
             Message = DefaultConfig.DefaultMessage;
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
          public OperationResultCodeType Code
        {
            set;
            get;
        }
    }
}
