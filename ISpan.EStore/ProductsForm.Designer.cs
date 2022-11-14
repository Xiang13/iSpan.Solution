namespace ISpan.EStore
{
	partial class ProductsForm
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
			this.categoryIdCombox = new System.Windows.Forms.ComboBox();
			this.productCategoryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.searchBtn = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.listPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.addNewBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.productCategoryVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// categoryIdCombox
			// 
			this.categoryIdCombox.DataSource = this.productCategoryVMBindingSource;
			this.categoryIdCombox.DisplayMember = "CategoryName";
			this.categoryIdCombox.FormattingEnabled = true;
			this.categoryIdCombox.Location = new System.Drawing.Point(38, 47);
			this.categoryIdCombox.Name = "categoryIdCombox";
			this.categoryIdCombox.Size = new System.Drawing.Size(120, 20);
			this.categoryIdCombox.TabIndex = 0;
			this.categoryIdCombox.ValueMember = "Id";
			// 
			// productCategoryVMBindingSource
			// 
			this.productCategoryVMBindingSource.DataSource = typeof(ISpan.EStore.Models.VIewModels.ProductCategoryVM);
			// 
			// searchBtn
			// 
			this.searchBtn.Location = new System.Drawing.Point(191, 39);
			this.searchBtn.Name = "searchBtn";
			this.searchBtn.Size = new System.Drawing.Size(75, 34);
			this.searchBtn.TabIndex = 1;
			this.searchBtn.Text = "搜尋";
			this.searchBtn.UseVisualStyleBackColor = true;
			this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.listPriceDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.productIndexVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(38, 98);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(638, 287);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// categoryNameDataGridViewTextBoxColumn
			// 
			this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
			this.categoryNameDataGridViewTextBoxColumn.HeaderText = "分類名稱";
			this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
			this.categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// productNameDataGridViewTextBoxColumn
			// 
			this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
			this.productNameDataGridViewTextBoxColumn.HeaderText = "產品名稱";
			this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
			this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// listPriceDataGridViewTextBoxColumn
			// 
			this.listPriceDataGridViewTextBoxColumn.DataPropertyName = "ListPrice";
			this.listPriceDataGridViewTextBoxColumn.HeaderText = "牌價";
			this.listPriceDataGridViewTextBoxColumn.Name = "listPriceDataGridViewTextBoxColumn";
			this.listPriceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// productIndexVMBindingSource
			// 
			this.productIndexVMBindingSource.DataSource = typeof(ISpan.EStore.Models.VIewModels.ProductIndexVM);
			// 
			// addNewBtn
			// 
			this.addNewBtn.Location = new System.Drawing.Point(494, 39);
			this.addNewBtn.Name = "addNewBtn";
			this.addNewBtn.Size = new System.Drawing.Size(75, 34);
			this.addNewBtn.TabIndex = 2;
			this.addNewBtn.Text = "新增";
			this.addNewBtn.UseVisualStyleBackColor = true;
			this.addNewBtn.Click += new System.EventHandler(this.addNewBtn_Click);
			// 
			// ProductsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(723, 419);
			this.Controls.Add(this.addNewBtn);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.searchBtn);
			this.Controls.Add(this.categoryIdCombox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "ProductsForm";
			this.Text = "檢視商品紀錄";
			((System.ComponentModel.ISupportInitialize)(this.productCategoryVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox categoryIdCombox;
		private System.Windows.Forms.Button searchBtn;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource productIndexVMBindingSource;
		private System.Windows.Forms.Button addNewBtn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn listPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource productCategoryVMBindingSource;
	}
}