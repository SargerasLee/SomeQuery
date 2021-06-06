using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomeQuery.Entity;
using Newtonsoft.Json;
using System.IO;

namespace SomeQuery.Services
{
	internal class AccountDataAccess
	{
		internal static AccountDataAccess Instance => new AccountDataAccess();
		private const string JsonPath = "./Resources/AccountData";
		private readonly AccountData<AccountInfo> data;

		private AccountDataAccess()
		{
			data = GetAccountData();
			if(data==null || data.Data==null)
			{
				data = new AccountData<AccountInfo>
				{
					Data = new List<AccountInfo>()
				};
			}
		}

		private AccountData<AccountInfo> GetAccountData()
		{
			string pwdStr = string.Empty;
			if(!File.Exists(JsonPath))
			{
				File.Create(JsonPath).Close();
			}
			using (StreamReader sr = new StreamReader(JsonPath, Encoding.Default))
			{
				pwdStr = sr.ReadToEnd();
			}
			pwdStr = CryptogramUtil.FromBase64(pwdStr, Encoding.Default);
			AccountData<AccountInfo> pwd = JsonConvert.DeserializeObject<AccountData<AccountInfo>>(pwdStr);
			return pwd;
		}

		internal List<AccountInfo> GetPwdDataByFilter(string filter)
		{
			if (filter == null || filter.Trim() == string.Empty)
				return data.Data;
			return data.Data.Where((info) =>
			info.App.Contains(filter) || info.Account.Contains(filter) || info.Email.Contains(filter) || info.Password.Contains(filter))
			.OrderBy((info) => info.Id).ToList();
		}

		internal void SavePwdDataFile()
		{
			string pwdStr = JsonConvert.SerializeObject(data, Formatting.Indented);
			pwdStr = CryptogramUtil.ToBase64(pwdStr, Encoding.Default);
			using (StreamWriter sw = new StreamWriter(JsonPath, false, Encoding.Default))
			{
				sw.Write(pwdStr);
				sw.Flush();
			}
		}

		internal void AddPwdData(AccountInfo info)
		{
			data.Data.Add(info);
		}

		internal void DeletePwdData(int id)
		{
			data.Data.RemoveAll((info) => info.Id == id);
		}

		internal void UpdatePwdData(AccountInfo accInfo)
		{
			AccountInfo account = data.Data.Where((info) => info.Id == accInfo.Id).ToList()[0];
			account.Account = accInfo.Account;
			account.Email = accInfo.Email;
			account.App = accInfo.App;
			account.Password = accInfo.Password;
			account.Note = accInfo.Note;
		}
	}
}
