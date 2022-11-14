namespace ISpan.EStore
{
	partial class CreateProductForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.productNameTxtBox = new System.Windows.Forms.TextBox();
			this.listPriceTxtBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.categoryIdComboBox = new System.Windows.Forms.ComboBox();
			this.productCategoryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.saveBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.productCategoryVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(49, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 12);
			this.label1.TabIndex = 5;
			this.label1.Text = "商品名稱:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(49, 125);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 6;
			this.label2.Text = "牌價:";
			// 
			// productNameTxtBox
			// 
			this.productNameTxtBox.Location = new System.Drawing.Point(116, 87);
			this.productNameTxtBox.Name = "productNameTxtBox";
			this.productNameTxtBox.Size = new System.Drawing.Size(121, 22);
			this.productNameTxtBox.TabIndex = 1;
			// 
			// listPriceTxtBox
			// 
			this.listPriceTxtBox.Location = new System.Drawing.Point(116, 122);
			this.listPriceTxtBox.Name = "listPriceTxtBox";
			this.listPriceTxtBox.Size = new System.Drawing.Size(121, 22);
			this.listPriceTxtBox.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(49, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 12);
			this.label3.TabIndex = 4;
			this.label3.Text = "分類:";
			// 
			// categoryIdComboBox
			// 
			this.categoryIdComboBox.DataSource = this.productCategoryVMBindingSource;
			this.categoryIdComboBox.DisplayMember = "CategoryName";
			this.categoryIdComboBox.FormattingEnabled = true;
			this.categoryIdComboBox.Location = new System.Drawing.Point(116, 49);
			this.categoryIdComboBox.Name = "categoryIdComboBox";
			this.categoryIdComboBox.Size = new System.Drawing.Size(121, 20);
			this.categoryIdComboBox.TabIndex = 0;
			this.categoryIdComboBox.ValueMember = "Id";
			// 
			// productCategoryVMBindingSource
			// 
			this.productCategoryVMBindingSource.DataSource = typeof(ISpan.EStore.Models.VIewModels.ProductCategoryVM);
			// 
			// saveBtn
			// 
			this.saveBtn.Location = new System.Drawing.Point(161, 163);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(75, 23);
			this.saveBtn.TabIndex = 3;
			this.saveBtn.Text = "儲存";
			this.saveBtn.UseVisualStyleBackColor = true;
			this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
			// 
			// CreateProductForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(307, 228);
			this.Controls.Add(this.saveBtn);
			this.Controls.Add(this.categoryIdComboBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.listPriceTxtBox);
			this.Controls.Add(this.productNameTxtBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "CreateProductForm";
			this.Text = "新增商品紀錄";
			((System.ComponentModel.ISupportInitialize)(this.productCategoryVMBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox productNameTxtBox;
		private System.Windows.Forms.TextBox listPriceTxtBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox categoryIdComboBox;
		private System.Windows.Forms.Button saveBtn;
		private System.Windows.Forms.BindingSource productCategoryVMBindingSource;
	}
}