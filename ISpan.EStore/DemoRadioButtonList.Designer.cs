namespace ISpan.EStore
{
	partial class DemoRadioButtonList
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
			this.gender1 = new System.Windows.Forms.RadioButton();
			this.gender0 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.radioButton6 = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.getValueBtn = new System.Windows.Forms.Button();
			this.setValueBtn = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// gender1
			// 
			this.gender1.AutoSize = true;
			this.gender1.Location = new System.Drawing.Point(24, 18);
			this.gender1.Name = "gender1";
			this.gender1.Size = new System.Drawing.Size(35, 16);
			this.gender1.TabIndex = 0;
			this.gender1.Tag = "1";
			this.gender1.Text = "男";
			this.gender1.UseVisualStyleBackColor = true;
			// 
			// gender0
			// 
			this.gender0.AutoSize = true;
			this.gender0.Location = new System.Drawing.Point(106, 18);
			this.gender0.Name = "gender0";
			this.gender0.Size = new System.Drawing.Size(35, 16);
			this.gender0.TabIndex = 0;
			this.gender0.Tag = "0";
			this.gender0.Text = "女";
			this.gender0.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(33, 35);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(85, 16);
			this.radioButton3.TabIndex = 0;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "radioButton1";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.Location = new System.Drawing.Point(155, 35);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(85, 16);
			this.radioButton4.TabIndex = 0;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "radioButton1";
			this.radioButton4.UseVisualStyleBackColor = true;
			// 
			// radioButton5
			// 
			this.radioButton5.AutoSize = true;
			this.radioButton5.Location = new System.Drawing.Point(33, 79);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new System.Drawing.Size(85, 16);
			this.radioButton5.TabIndex = 0;
			this.radioButton5.TabStop = true;
			this.radioButton5.Text = "radioButton1";
			this.radioButton5.UseVisualStyleBackColor = true;
			// 
			// radioButton6
			// 
			this.radioButton6.AutoSize = true;
			this.radioButton6.Location = new System.Drawing.Point(155, 79);
			this.radioButton6.Name = "radioButton6";
			this.radioButton6.Size = new System.Drawing.Size(85, 16);
			this.radioButton6.TabIndex = 0;
			this.radioButton6.TabStop = true;
			this.radioButton6.Text = "radioButton1";
			this.radioButton6.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.gender0);
			this.panel1.Controls.Add(this.gender1);
			this.panel1.Location = new System.Drawing.Point(57, 43);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(167, 49);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.radioButton6);
			this.panel2.Controls.Add(this.radioButton4);
			this.panel2.Controls.Add(this.radioButton3);
			this.panel2.Controls.Add(this.radioButton5);
			this.panel2.Location = new System.Drawing.Point(57, 114);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(289, 123);
			this.panel2.TabIndex = 2;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(246, 45);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 3;
			// 
			// getValueBtn
			// 
			this.getValueBtn.Location = new System.Drawing.Point(373, 43);
			this.getValueBtn.Name = "getValueBtn";
			this.getValueBtn.Size = new System.Drawing.Size(75, 23);
			this.getValueBtn.TabIndex = 4;
			this.getValueBtn.Text = "Get Value";
			this.getValueBtn.UseVisualStyleBackColor = true;
			this.getValueBtn.Click += new System.EventHandler(this.getValueBtn_Click);
			// 
			// setValueBtn
			// 
			this.setValueBtn.Location = new System.Drawing.Point(373, 101);
			this.setValueBtn.Name = "setValueBtn";
			this.setValueBtn.Size = new System.Drawing.Size(75, 23);
			this.setValueBtn.TabIndex = 4;
			this.setValueBtn.Text = "Set Value";
			this.setValueBtn.UseVisualStyleBackColor = true;
			this.setValueBtn.Click += new System.EventHandler(this.setValueBtn_Click);
			// 
			// DemoRadioButtonList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.setValueBtn);
			this.Controls.Add(this.getValueBtn);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "DemoRadioButtonList";
			this.Text = "DemoRadioButtonList";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton gender1;
		private System.Windows.Forms.RadioButton gender0;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.RadioButton radioButton6;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button getValueBtn;
		private System.Windows.Forms.Button setValueBtn;
	}
}