namespace ISpan.EStore
{
	partial class EditUserForm
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
			this.DeleteButton = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			this.nameTxtBox = new System.Windows.Forms.TextBox();
			this.accountTxtBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.passwordTxtBox = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// DeleteButton
			// 
			this.DeleteButton.Location = new System.Drawing.Point(159, 190);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(75, 23);
			this.DeleteButton.TabIndex = 5;
			this.DeleteButton.Text = "刪除";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(46, 190);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 4;
			this.saveButton.Text = "保存";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// nameTxtBox
			// 
			this.nameTxtBox.Location = new System.Drawing.Point(112, 132);
			this.nameTxtBox.Name = "nameTxtBox";
			this.nameTxtBox.Size = new System.Drawing.Size(122, 22);
			this.nameTxtBox.TabIndex = 3;
			// 
			// accountTxtBox
			// 
			this.accountTxtBox.Location = new System.Drawing.Point(112, 43);
			this.accountTxtBox.Name = "accountTxtBox";
			this.accountTxtBox.Size = new System.Drawing.Size(121, 22);
			this.accountTxtBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(44, 135);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 9;
			this.label2.Text = "名字:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(44, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 12);
			this.label1.TabIndex = 7;
			this.label1.Text = "帳號:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(44, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 12);
			this.label4.TabIndex = 8;
			this.label4.Text = "密碼:";
			// 
			// passwordTxtBox
			// 
			this.passwordTxtBox.Location = new System.Drawing.Point(112, 85);
			this.passwordTxtBox.Name = "passwordTxtBox";
			this.passwordTxtBox.Size = new System.Drawing.Size(122, 22);
			this.passwordTxtBox.TabIndex = 2;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// EditUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(300, 250);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.passwordTxtBox);
			this.Controls.Add(this.nameTxtBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.accountTxtBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "EditUserForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "編輯資料";
			this.Load += new System.EventHandler(this.EditUserForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.TextBox nameTxtBox;
		private System.Windows.Forms.TextBox accountTxtBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox passwordTxtBox;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}