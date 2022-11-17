namespace ISpan.EStore
{
	partial class DemoCheckBox
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
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.setValueBtn = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.getValueBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(37, 33);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(77, 16);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "checkBox1";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// setValueBtn
			// 
			this.setValueBtn.Location = new System.Drawing.Point(214, 86);
			this.setValueBtn.Name = "setValueBtn";
			this.setValueBtn.Size = new System.Drawing.Size(75, 23);
			this.setValueBtn.TabIndex = 1;
			this.setValueBtn.Text = "Set Value";
			this.setValueBtn.UseVisualStyleBackColor = true;
			this.setValueBtn.Click += new System.EventHandler(this.setValueBtn_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(37, 86);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 2;
			// 
			// getValueBtn
			// 
			this.getValueBtn.Location = new System.Drawing.Point(214, 29);
			this.getValueBtn.Name = "getValueBtn";
			this.getValueBtn.Size = new System.Drawing.Size(75, 23);
			this.getValueBtn.TabIndex = 1;
			this.getValueBtn.Text = "Get Value";
			this.getValueBtn.UseVisualStyleBackColor = true;
			this.getValueBtn.Click += new System.EventHandler(this.getValueBtn_Click);
			// 
			// DemoCheckBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(342, 172);
			this.Controls.Add(this.getValueBtn);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.setValueBtn);
			this.Controls.Add(this.checkBox1);
			this.Name = "DemoCheckBox";
			this.Text = "DemoCheckBox";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button setValueBtn;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button getValueBtn;
	}
}