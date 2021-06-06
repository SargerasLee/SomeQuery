using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomeQuery.Entity;
namespace SomeQuery.Forms
{
	public delegate void OperateData(AccountInfo info, string action);
	public partial class DetailForm : Form
	{
		private readonly OperateData operate;
		private readonly string action;
		private readonly AccountInfo info;
		public DetailForm()
		{
			InitializeComponent();
		}

		public DetailForm(OperateData d, int Id, string act, AccountInfo account=null):this()
		{
			operate = d;
			IdText.Text = Id.ToString();
			action = act;
			info = account;
			if(info!=null)
				SetTextValue(info);
		}

		private void SetTextValue(AccountInfo info)
		{
			AppText.Text = info.App;
			AccountText.Text = info.Account;
			PwdText.Text = info.Password;
			EmailText.Text = info.Email;
			NoteText.Text = info.Note;
		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{
			AccountInfo info = new AccountInfo()
			{
				Id = Convert.ToInt32(IdText.Text),
				App = AppText.Text,
				Account=AccountText.Text,
				Email=EmailText.Text,
				Password=PwdText.Text,
				Note=NoteText.Text
			};
			operate(info, action);
			Close();
		}
	}
}
