using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeQuery.Services
{
	public class CryptogramUtil
	{
		public static string ToBase64(string str, Encoding encoding)
		{
			byte[] b = encoding.GetBytes(str);
			return Convert.ToBase64String(b, Base64FormattingOptions.InsertLineBreaks);
		}
		public static string FromBase64(string str, Encoding encoding)
		{
			byte[] b = Convert.FromBase64String(str);
			return encoding.GetString(b);
		}
	}
}
