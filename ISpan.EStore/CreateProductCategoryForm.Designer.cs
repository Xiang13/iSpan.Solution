namespace ISpan.EStore
{
	partial class CreateProductCategoryForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.displayOrderTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.saveButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(41, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "分類名稱: ";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(117, 36);
			this.nameTextBox.MaxLength = 50;
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(172, 22);
			this.nameTextBox.TabIndex = 1;
			// 
			// displayOrderTextBox
			// 
			this.displayOrderTextBox.Location = new System.Drawing.Point(117, 87);
			this.displayOrderTextBox.MaxLength = 4;
			this.displayOrderTextBox.Name = "displayOrderTextBox";
			this.displayOrderTextBox.Size = new System.Drawing.Size(172, 22);
			this.displayOrderTextBox.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(41, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "顯示順序: ";
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(214, 130);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 4;
			this.saveButton.Text = "保存";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// CreateProductCategoryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(347, 179);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.displayOrderTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CreateProductCategoryForm";
			this.Text = "新增商品種類";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.TextBox displayOrderTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button saveButton;
	}
}