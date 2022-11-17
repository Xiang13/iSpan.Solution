namespace ISpan.EStore
{
	partial class DemoGender
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
			this.getvalueBtn = new System.Windows.Forms.Button();
			this.setvalueBtn = new System.Windows.Forms.Button();
			this.ucGender1 = new ISpan.EStore.Controls.ucGender();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// getvalueBtn
			// 
			this.getvalueBtn.Location = new System.Drawing.Point(268, 36);
			this.getvalueBtn.Name = "getvalueBtn";
			this.getvalueBtn.Size = new System.Drawing.Size(75, 23);
			this.getvalueBtn.TabIndex = 1;
			this.getvalueBtn.Text = "Get Value";
			this.getvalueBtn.UseVisualStyleBackColor = true;
			this.getvalueBtn.Click += new System.EventHandler(this.getvalueBtn_Click);
			// 
			// setvalueBtn
			// 
			this.setvalueBtn.Location = new System.Drawing.Point(268, 99);
			this.setvalueBtn.Name = "setvalueBtn";
			this.setvalueBtn.Size = new System.Drawing.Size(75, 23);
			this.setvalueBtn.TabIndex = 1;
			this.setvalueBtn.Text = "Set Value";
			this.setvalueBtn.UseVisualStyleBackColor = true;
			this.setvalueBtn.Click += new System.EventHandler(this.setvalueBtn_Click);
			// 
			// ucGender1
			// 
			this.ucGender1.Location = new System.Drawing.Point(64, 36);
			this.ucGender1.Name = "ucGender1";
			this.ucGender1.Size = new System.Drawing.Size(159, 56);
			this.ucGender1.TabIndex = 2;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(84, 113);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 3;
			// 
			// DemoGender
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.ucGender1);
			this.Controls.Add(this.setvalueBtn);
			this.Controls.Add(this.getvalueBtn);
			this.Name = "DemoGender";
			this.Text = "DemoGender";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button getvalueBtn;
		private System.Windows.Forms.Button setvalueBtn;
		private Controls.ucGender ucGender1;
		private System.Windows.Forms.TextBox textBox1;
	}
}