namespace ISpan.EStore
{
	partial class EditProductForm
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
			this.categoryIdComboBox = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.listPriceTxtBox = new System.Windows.Forms.TextBox();
			this.productNameTxtBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// categoryIdComboBox
			// 
			this.categoryIdComboBox.DisplayMember = "CategoryName";
			this.categoryIdComboBox.FormattingEnabled = true;
			this.categoryIdComboBox.Location = new System.Drawing.Point(127, 56);
			this.categoryIdComboBox.Name = "categoryIdComboBox";
			this.categoryIdComboBox.Size = new System.Drawing.Size(121, 20);
			this.categoryIdComboBox.TabIndex = 0;
			this.categoryIdComboBox.ValueMember = "Id";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(60, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 12);
			this.label3.TabIndex = 5;
			this.label3.Text = "分類:";
			// 
			// listPriceTxtBox
			// 
			this.listPriceTxtBox.Location = new System.Drawing.Point(127, 129);
			this.listPriceTxtBox.Name = "listPriceTxtBox";
			this.listPriceTxtBox.Size = new System.Drawing.Size(121, 22);
			this.listPriceTxtBox.TabIndex = 2;
			// 
			// productNameTxtBox
			// 
			this.productNameTxtBox.Location = new System.Drawing.Point(127, 94);
			this.productNameTxtBox.Name = "productNameTxtBox";
			this.productNameTxtBox.Size = new System.Drawing.Size(121, 22);
			this.productNameTxtBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(60, 132);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 7;
			this.label2.Text = "牌價:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(60, 97);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 12);
			this.label1.TabIndex = 6;
			this.label1.Text = "商品名稱:";
			// 
			// DeleteButton
			// 
			this.DeleteButton.Location = new System.Drawing.Point(173, 186);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(75, 23);
			this.DeleteButton.TabIndex = 4;
			this.DeleteButton.Text = "刪除";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(62, 186);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 3;
			this.saveButton.Text = "保存";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// EditProductForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(321, 259);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.categoryIdComboBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.listPriceTxtBox);
			this.Controls.Add(this.productNameTxtBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "EditProductForm";
			this.Text = "編輯商品";
			this.Load += new System.EventHandler(this.EditProductForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox categoryIdComboBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox listPriceTxtBox;
		private System.Windows.Forms.TextBox productNameTxtBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.Button saveButton;
	}
}