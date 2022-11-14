namespace ISpan.EStore
{
	partial class CreateUserForm
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
			this.saveBtn = new System.Windows.Forms.Button();
			this.categoryIdComboBox = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.passwordTxtBox = new System.Windows.Forms.TextBox();
			this.accountTxtBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.nameTxtBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// saveBtn
			// 
			this.saveBtn.Location = new System.Drawing.Point(160, 179);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(75, 23);
			this.saveBtn.TabIndex = 4;
			this.saveBtn.Text = "儲存";
			this.saveBtn.UseVisualStyleBackColor = true;
			this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
			// 
			// categoryIdComboBox
			// 
			this.categoryIdComboBox.DisplayMember = "CategoryName";
			this.categoryIdComboBox.FormattingEnabled = true;
			this.categoryIdComboBox.Location = new System.Drawing.Point(114, 34);
			this.categoryIdComboBox.Name = "categoryIdComboBox";
			this.categoryIdComboBox.Size = new System.Drawing.Size(121, 20);
			this.categoryIdComboBox.TabIndex = 0;
			this.categoryIdComboBox.ValueMember = "Id";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(47, 37);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 12);
			this.label3.TabIndex = 5;
			this.label3.Text = "分類:";
			// 
			// passwordTxtBox
			// 
			this.passwordTxtBox.Location = new System.Drawing.Point(114, 107);
			this.passwordTxtBox.Name = "passwordTxtBox";
			this.passwordTxtBox.Size = new System.Drawing.Size(121, 22);
			this.passwordTxtBox.TabIndex = 2;
			// 
			// accountTxtBox
			// 
			this.accountTxtBox.Location = new System.Drawing.Point(114, 72);
			this.accountTxtBox.Name = "accountTxtBox";
			this.accountTxtBox.Size = new System.Drawing.Size(121, 22);
			this.accountTxtBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(47, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 7;
			this.label2.Text = "密碼:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(47, 75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 12);
			this.label1.TabIndex = 6;
			this.label1.Text = "帳號:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(47, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 12);
			this.label4.TabIndex = 8;
			this.label4.Text = "名字:";
			// 
			// nameTxtBox
			// 
			this.nameTxtBox.Location = new System.Drawing.Point(114, 145);
			this.nameTxtBox.Name = "nameTxtBox";
			this.nameTxtBox.Size = new System.Drawing.Size(121, 22);
			this.nameTxtBox.TabIndex = 3;
			// 
			// CreateUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(300, 250);
			this.Controls.Add(this.saveBtn);
			this.Controls.Add(this.categoryIdComboBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.nameTxtBox);
			this.Controls.Add(this.passwordTxtBox);
			this.Controls.Add(this.accountTxtBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "CreateUserForm";
			this.Text = "新增資料";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button saveBtn;
		private System.Windows.Forms.ComboBox categoryIdComboBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox passwordTxtBox;
		private System.Windows.Forms.TextBox accountTxtBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox nameTxtBox;
	}
}