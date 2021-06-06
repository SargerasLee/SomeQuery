namespace SomeQuery.Forms
{
	partial class LockForm
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
			this.LockText = new System.Windows.Forms.TextBox();
			this.Msg = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// LockText
			// 
			this.LockText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LockText.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.LockText.Location = new System.Drawing.Point(3, 3);
			this.LockText.Name = "LockText";
			this.LockText.Size = new System.Drawing.Size(358, 34);
			this.LockText.TabIndex = 0;
			this.LockText.UseSystemPasswordChar = true;
			this.LockText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Lock_KeyDown);
			// 
			// Msg
			// 
			this.Msg.AutoSize = true;
			this.Msg.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Msg.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Msg.Location = new System.Drawing.Point(3, 49);
			this.Msg.Name = "Msg";
			this.Msg.Size = new System.Drawing.Size(358, 50);
			this.Msg.TabIndex = 1;
			this.Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.Msg, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.LockText, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 99);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// LockForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(364, 99);
			this.Controls.Add(this.tableLayoutPanel1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LockForm";
			this.Text = "锁定";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LockForm_FormClosed);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox LockText;
		private System.Windows.Forms.Label Msg;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}