using SomeQuery.Entity;
using SomeQuery.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace SomeQuery.Forms
{
	public partial class QueryForm : Form
	{
		private readonly AccountDataAccess pwdDataHandler = AccountDataAccess.Instance;
		private readonly LockForm lockForm;
		public QueryForm()
		{
			InitializeComponent();
			ColumnHeader ch0 = GetHeader("序号", 60);
			ColumnHeader ch1 = GetHeader("应用", 180);
			ColumnHeader ch2 = GetHeader("账户", 240);
			ColumnHeader ch3 = GetHeader("邮箱", 360);
			ColumnHeader ch4 = GetHeader("密码", 240);
			ColumnHeader ch5 = GetHeader("备注", 300);
			ColumnHeader[] columns = new ColumnHeader[] { ch0, ch1, ch2, ch3, ch4, ch5 };
			PwdListView.Columns.AddRange(columns);
			PwdListView.MultiSelect = false;
			PwdListView.FullRowSelect = true;
			PwdListView.GridLines = true;
			lockForm = new LockForm(this);
		}

		private ColumnHeader GetHeader(string text, int width)
		{
			ColumnHeader columnHeader = new ColumnHeader();
			columnHeader.Text = text;
			columnHeader.Width = width;
			columnHeader.TextAlign = HorizontalAlignment.Center;
			return columnHeader;
		}

		private void LoadPwdData()
		{
			List<AccountInfo> infoList = pwdDataHandler.GetPwdDataByFilter(null);
			LoadSelectedListView(infoList);
		}

		private void LoadSelectedListView(List<AccountInfo> infoList)
		{
			ListView listView = TabControl.SelectedTab.GetChildAtPoint(new Point(3, 3)) as ListView;
			listView.Items.Clear();
			foreach (AccountInfo info in infoList)
			{
				//int num = listView.Items.Count + 1;
				ListViewItem item = new ListViewItem
				{
					Text = info.Id.ToString()
				};
				string[] s = new string[] { info.App, info.Account, info.Email, info.Password, info.Note };
				item.SubItems.AddRange(s);
				listView.Items.Add(item);
				
			}
		}

		private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListView listView = TabControl.SelectedTab.GetChildAtPoint(new Point(3, 3)) as ListView;
			if (listView == PwdListView)
			{

			}
			else if (listView == TermListView)
			{

			}
		}

		private void QueryBtn_Click(object sender, EventArgs e)
		{
			Hide();	
			lockForm.StartPosition = FormStartPosition.CenterScreen;
			lockForm.Show();
		}

		private void ReLoadPwdData()
		{
			string filter = QueryText.Text;
			List<AccountInfo> infoList = pwdDataHandler.GetPwdDataByFilter(filter);
			LoadSelectedListView(infoList);
		}

		private void QueryForm_Load(object sender, EventArgs e)
		{
			LoadPwdData();
		}

		private void QueryForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			pwdDataHandler.SavePwdDataFile();
		}

		private void AddAccount_Click(object sender, EventArgs e)
		{
			int id = 0;
			if (PwdListView.Items.Count>0)
				id = Convert.ToInt32(PwdListView.Items[PwdListView.Items.Count-1].Text);
			DetailForm detailForm = new DetailForm(OperateData,id+1, "add");
			detailForm.StartPosition = FormStartPosition.CenterParent;
			detailForm.Show();
		}

		private void OperateData(AccountInfo info, string action)
		{
			if (action=="add")
			{
				pwdDataHandler.AddPwdData(info); 
			}
			else if(action=="update")
			{
				pwdDataHandler.UpdatePwdData(info);
			}
			ReLoadPwdData();
		}

		private void DeleteAccount_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(PwdListView.SelectedItems[0].Text);
			pwdDataHandler.DeletePwdData(id);
			ReLoadPwdData();
		}

		private void UpdateAccount_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(PwdListView.SelectedItems[0].Text);
			AccountInfo info = new AccountInfo
			{
				Id = id,
				App = PwdListView.SelectedItems[0].SubItems[1].Text,
				Account = PwdListView.SelectedItems[0].SubItems[2].Text,
				Email = PwdListView.SelectedItems[0].SubItems[3].Text,
				Password = PwdListView.SelectedItems[0].SubItems[4].Text,
				Note = PwdListView.SelectedItems[0].SubItems[5].Text
			};
			DetailForm detailForm = new DetailForm(OperateData, id, "update", info);
			detailForm.StartPosition = FormStartPosition.CenterParent;
			detailForm.Show();
		}

		private void QueryText_KeyUp(object sender, KeyEventArgs e)
		{
			ReLoadPwdData();
		}
	}
}
