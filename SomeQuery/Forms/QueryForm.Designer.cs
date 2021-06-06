namespace SomeQuery.Forms
{
	partial class QueryForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.QueryBtn = new System.Windows.Forms.Button();
			this.QueryText = new System.Windows.Forms.TextBox();
			this.TabControl = new System.Windows.Forms.TabControl();
			this.PwdQuery = new System.Windows.Forms.TabPage();
			this.PwdListView = new System.Windows.Forms.ListView();
			this.ContextMenuStripPwd = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.AddAccount = new System.Windows.Forms.ToolStripMenuItem();
			this.DeleteAccount = new System.Windows.Forms.ToolStripMenuItem();
			this.UpdateAccount = new System.Windows.Forms.ToolStripMenuItem();
			this.TermQuery = new System.Windows.Forms.TabPage();
			this.TermListView = new System.Windows.Forms.ListView();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.TabControl.SuspendLayout();
			this.PwdQuery.SuspendLayout();
			this.ContextMenuStripPwd.SuspendLayout();
			this.TermQuery.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.TabControl, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.QueryBtn, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.QueryText, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 39);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// QueryBtn
			// 
			this.QueryBtn.AutoSize = true;
			this.QueryBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.QueryBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.QueryBtn.Location = new System.Drawing.Point(400, 3);
			this.QueryBtn.Name = "QueryBtn";
			this.QueryBtn.Size = new System.Drawing.Size(391, 33);
			this.QueryBtn.TabIndex = 0;
			this.QueryBtn.Text = "锁定";
			this.QueryBtn.UseVisualStyleBackColor = true;
			this.QueryBtn.Click += new System.EventHandler(this.QueryBtn_Click);
			// 
			// QueryText
			// 
			this.QueryText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.QueryText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.QueryText.Location = new System.Drawing.Point(3, 3);
			this.QueryText.Name = "QueryText";
			this.QueryText.Size = new System.Drawing.Size(391, 30);
			this.QueryText.TabIndex = 1;
			this.QueryText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.QueryText_KeyUp);
			// 
			// TabControl
			// 
			this.TabControl.Controls.Add(this.PwdQuery);
			this.TabControl.Controls.Add(this.TermQuery);
			this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabControl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.TabControl.Location = new System.Drawing.Point(3, 48);
			this.TabControl.Name = "TabControl";
			this.TabControl.SelectedIndex = 0;
			this.TabControl.Size = new System.Drawing.Size(794, 399);
			this.TabControl.TabIndex = 2;
			this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
			// 
			// PwdQuery
			// 
			this.PwdQuery.Controls.Add(this.PwdListView);
			this.PwdQuery.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.PwdQuery.Location = new System.Drawing.Point(4, 30);
			this.PwdQuery.Name = "PwdQuery";
			this.PwdQuery.Padding = new System.Windows.Forms.Padding(3);
			this.PwdQuery.Size = new System.Drawing.Size(786, 365);
			this.PwdQuery.TabIndex = 0;
			this.PwdQuery.Text = "账户信息";
			this.PwdQuery.UseVisualStyleBackColor = true;
			// 
			// PwdListView
			// 
			this.PwdListView.ContextMenuStrip = this.ContextMenuStripPwd;
			this.PwdListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PwdListView.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.PwdListView.HideSelection = false;
			this.PwdListView.Location = new System.Drawing.Point(3, 3);
			this.PwdListView.Name = "PwdListView";
			this.PwdListView.Size = new System.Drawing.Size(780, 359);
			this.PwdListView.TabIndex = 0;
			this.PwdListView.UseCompatibleStateImageBehavior = false;
			this.PwdListView.View = System.Windows.Forms.View.Details;
			// 
			// ContextMenuStripPwd
			// 
			this.ContextMenuStripPwd.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.ContextMenuStripPwd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddAccount,
            this.DeleteAccount,
            this.UpdateAccount});
			this.ContextMenuStripPwd.Name = "ContextMenuStripPwd";
			this.ContextMenuStripPwd.Size = new System.Drawing.Size(109, 76);
			// 
			// AddAccount
			// 
			this.AddAccount.Name = "AddAccount";
			this.AddAccount.Size = new System.Drawing.Size(108, 24);
			this.AddAccount.Text = "增加";
			this.AddAccount.Click += new System.EventHandler(this.AddAccount_Click);
			// 
			// DeleteAccount
			// 
			this.DeleteAccount.Name = "DeleteAccount";
			this.DeleteAccount.Size = new System.Drawing.Size(108, 24);
			this.DeleteAccount.Text = "删除";
			this.DeleteAccount.Click += new System.EventHandler(this.DeleteAccount_Click);
			// 
			// UpdateAccount
			// 
			this.UpdateAccount.Name = "UpdateAccount";
			this.UpdateAccount.Size = new System.Drawing.Size(108, 24);
			this.UpdateAccount.Text = "修改";
			this.UpdateAccount.Click += new System.EventHandler(this.UpdateAccount_Click);
			// 
			// TermQuery
			// 
			this.TermQuery.Controls.Add(this.TermListView);
			this.TermQuery.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.TermQuery.Location = new System.Drawing.Point(4, 30);
			this.TermQuery.Name = "TermQuery";
			this.TermQuery.Padding = new System.Windows.Forms.Padding(3);
			this.TermQuery.Size = new System.Drawing.Size(786, 365);
			this.TermQuery.TabIndex = 1;
			this.TermQuery.Text = "专业名词";
			this.TermQuery.UseVisualStyleBackColor = true;
			// 
			// TermListView
			// 
			this.TermListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TermListView.HideSelection = false;
			this.TermListView.Location = new System.Drawing.Point(3, 3);
			this.TermListView.Name = "TermListView";
			this.TermListView.Size = new System.Drawing.Size(780, 359);
			this.TermListView.TabIndex = 0;
			this.TermListView.UseCompatibleStateImageBehavior = false;
			// 
			// QueryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tableLayoutPanel1);
			this.MaximizeBox = false;
			this.Name = "QueryForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "查询页";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QueryForm_FormClosed);
			this.Load += new System.EventHandler(this.QueryForm_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.TabControl.ResumeLayout(false);
			this.PwdQuery.ResumeLayout(false);
			this.ContextMenuStripPwd.ResumeLayout(false);
			this.TermQuery.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button QueryBtn;
		private System.Windows.Forms.TextBox QueryText;
		private System.Windows.Forms.TabControl TabControl;
		private System.Windows.Forms.TabPage PwdQuery;
		private System.Windows.Forms.TabPage TermQuery;
		private System.Windows.Forms.ListView PwdListView;
		private System.Windows.Forms.ListView TermListView;
		private System.Windows.Forms.ContextMenuStrip ContextMenuStripPwd;
		private System.Windows.Forms.ToolStripMenuItem AddAccount;
		private System.Windows.Forms.ToolStripMenuItem DeleteAccount;
		private System.Windows.Forms.ToolStripMenuItem UpdateAccount;
	}
}