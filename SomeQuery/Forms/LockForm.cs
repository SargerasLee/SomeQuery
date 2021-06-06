using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeQuery.Forms
{
	public partial class LockForm : Form
	{
		private QueryForm queryForm;
		public LockForm()
		{
			InitializeComponent();
		}

		public LockForm(QueryForm query):this()
		{
			queryForm = query;
		}

		private void Lock_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				if(LockText.Text=="aaaaaa")
				{
					Hide();
					LockText.Text = string.Empty;
					Msg.Text = string.Empty;
					queryForm.Show();
				}
				else
				{
					Random ran = new Random((int)DateTime.Now.Ticks);
					Point point = Location;
					for (int i = 0; i < 20; i++)
					{
						Location = new Point(point.X + ran.Next(8) - 4, point.Y + ran.Next(8) - 4);
						System.Threading.Thread.Sleep(5);
						Location = point;
						System.Threading.Thread.Sleep(5);
					}
					Msg.Text = "密码不正确";
					Msg.ForeColor = Color.Red;
					//MessageBox.Show("密码不对");
				}
			}
		}

		private void LockForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			queryForm.Close();
		}
	}
}
