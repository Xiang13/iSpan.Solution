namespace ISpan.EStore
{
	partial class DeomCheckListBox
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
			this.getValueBtn = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.setValueBtn = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.checkBox6 = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// getValueBtn
			// 
			this.getValueBtn.Location = new System.Drawing.Point(402, 75);
			this.getValueBtn.Name = "getValueBtn";
			this.getValueBtn.Size = new System.Drawing.Size(75, 23);
			this.getValueBtn.TabIndex = 1;
			this.getValueBtn.Text = "Get Value";
			this.getValueBtn.UseVisualStyleBackColor = true;
			this.getValueBtn.Click += new System.EventHandler(this.getValueBtn_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(81, 213);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 2;
			// 
			// setValueBtn
			// 
			this.setValueBtn.Location = new System.Drawing.Point(247, 213);
			this.setValueBtn.Name = "setValueBtn";
			this.setValueBtn.Size = new System.Drawing.Size(75, 23);
			this.setValueBtn.TabIndex = 1;
			this.setValueBtn.Text = "Set Value";
			this.setValueBtn.UseVisualStyleBackColor = true;
			this.setValueBtn.Click += new System.EventHandler(this.setValueBtn_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(70, 60);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(77, 16);
			this.checkBox1.TabIndex = 3;
			this.checkBox1.Tag = "A";
			this.checkBox1.Text = "checkBox1";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(162, 60);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(77, 16);
			this.checkBox2.TabIndex = 3;
			this.checkBox2.Tag = "B";
			this.checkBox2.Text = "checkBox2";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new System.Drawing.Point(247, 60);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(77, 16);
			this.checkBox3.TabIndex = 3;
			this.checkBox3.Tag = "C";
			this.checkBox3.Text = "checkBox3";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// checkBox4
			// 
			this.checkBox4.AutoSize = true;
			this.checkBox4.Location = new System.Drawing.Point(70, 97);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(77, 16);
			this.checkBox4.TabIndex = 3;
			this.checkBox4.Tag = "D";
			this.checkBox4.Text = "checkBox4";
			this.checkBox4.UseVisualStyleBackColor = true;
			// 
			// checkBox5
			// 
			this.checkBox5.AutoSize = true;
			this.checkBox5.Location = new System.Drawing.Point(162, 97);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(77, 16);
			this.checkBox5.TabIndex = 3;
			this.checkBox5.Tag = "E";
			this.checkBox5.Text = "checkBox5";
			this.checkBox5.UseVisualStyleBackColor = true;
			// 
			// checkBox6
			// 
			this.checkBox6.AutoSize = true;
			this.checkBox6.Location = new System.Drawing.Point(247, 97);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(77, 16);
			this.checkBox6.TabIndex = 3;
			this.checkBox6.Tag = "F";
			this.checkBox6.Text = "checkBox6";
			this.checkBox6.UseVisualStyleBackColor = true;
			// 
			// DeomCheckListBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.checkBox6);
			this.Controls.Add(this.checkBox5);
			this.Controls.Add(this.checkBox4);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.setValueBtn);
			this.Controls.Add(this.getValueBtn);
			this.Name = "DeomCheckListBox";
			this.Text = "DeomCheckListBox";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button getValueBtn;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button setValueBtn;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.CheckBox checkBox6;
	}
}