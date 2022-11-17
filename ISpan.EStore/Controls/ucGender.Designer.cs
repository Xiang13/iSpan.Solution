namespace ISpan.EStore.Controls
{
	partial class ucGender
	{
		/// <summary> 
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 元件設計工具產生的程式碼

		/// <summary> 
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.gender1RadioBtn = new System.Windows.Forms.RadioButton();
			this.gender0RadioBtn = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// gender1RadioBtn
			// 
			this.gender1RadioBtn.AutoSize = true;
			this.gender1RadioBtn.Location = new System.Drawing.Point(19, 20);
			this.gender1RadioBtn.Name = "gender1RadioBtn";
			this.gender1RadioBtn.Size = new System.Drawing.Size(35, 16);
			this.gender1RadioBtn.TabIndex = 0;
			this.gender1RadioBtn.TabStop = true;
			this.gender1RadioBtn.Tag = "1";
			this.gender1RadioBtn.Text = "男";
			this.gender1RadioBtn.UseVisualStyleBackColor = true;
			// 
			// gender0RadioBtn
			// 
			this.gender0RadioBtn.AutoSize = true;
			this.gender0RadioBtn.Location = new System.Drawing.Point(97, 20);
			this.gender0RadioBtn.Name = "gender0RadioBtn";
			this.gender0RadioBtn.Size = new System.Drawing.Size(35, 16);
			this.gender0RadioBtn.TabIndex = 1;
			this.gender0RadioBtn.TabStop = true;
			this.gender0RadioBtn.Tag = "0";
			this.gender0RadioBtn.Text = "女";
			this.gender0RadioBtn.UseVisualStyleBackColor = true;
			// 
			// ucGender
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.gender0RadioBtn);
			this.Controls.Add(this.gender1RadioBtn);
			this.Name = "ucGender";
			this.Size = new System.Drawing.Size(159, 56);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton gender1RadioBtn;
		private System.Windows.Forms.RadioButton gender0RadioBtn;
	}
}
