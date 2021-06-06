using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeQuery.Entity
{
	public class AccountData<T>
	{
		public List<T> Data{ get; set; }
	}

	public class AccountInfo
	{
		public int Id{ get; set; }
		public string App{ get; set; }
		public string Account{ get; set; }
		public string Email{ get; set; }
		public string Password{ get; set; }
		public string Note{ get; set; }
	}
}
