using System;

namespace Webs.Common
{
	public class StringHelper
	{
		public static String GetString(string source,int length){
			if(string.IsNullOrEmpty(source)) return string.Empty;
			if(source.Length<length) return source;
			return source.Substring(0,length);
		}
	}
}

