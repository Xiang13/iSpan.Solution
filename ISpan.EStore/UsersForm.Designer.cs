namespace ISpan.EStore
{
	partial class UsersForm
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
			this.addNewBtn = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.accountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.searchBtn = new System.Windows.Forms.Button();
			this.categoryIdCombox = new System.Windows.Forms.ComboBox();
			this.usersFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.usersFormBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// addNewBtn
			// 
			this.addNewBtn.Location = new System.Drawing.Point(511, 45);
			this.addNewBtn.Name = "addNewBtn";
			this.addNewBtn.Size = new System.Drawing.Size(75, 34);
			this.addNewBtn.TabIndex = 2;
			this.addNewBtn.Text = "新增";
			this.addNewBtn.UseVisualStyleBackColor = true;
			this.addNewBtn.Click += new System.EventHandler(this.addNewBtn_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.accountDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.userVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(55, 104);
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
			// accountDataGridViewTextBoxColumn
			// 
			this.accountDataGridViewTextBoxColumn.DataPropertyName = "Account";
			this.accountDataGridViewTextBoxColumn.HeaderText = "Account";
			this.accountDataGridViewTextBoxColumn.Name = "accountDataGridViewTextBoxColumn";
			this.accountDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// passwordDataGridViewTextBoxColumn
			// 
			this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
			this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
			this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
			this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// userVMBindingSource
			// 
			this.userVMBindingSource.DataSource = typeof(ISpan.EStore.Models.VIewModels.UserVM);
			// 
			// searchBtn
			// 
			this.searchBtn.Location = new System.Drawing.Point(208, 45);
			this.searchBtn.Name = "searchBtn";
			this.searchBtn.Size = new System.Drawing.Size(75, 34);
			this.searchBtn.TabIndex = 1;
			this.searchBtn.Text = "搜尋";
			this.searchBtn.UseVisualStyleBackColor = true;
			// 
			// categoryIdCombox
			// 
			this.categoryIdCombox.DisplayMember = "CategoryName";
			this.categoryIdCombox.FormattingEnabled = true;
			this.categoryIdCombox.Location = new System.Drawing.Point(55, 53);
			this.categoryIdCombox.Name = "categoryIdCombox";
			this.categoryIdCombox.Size = new System.Drawing.Size(120, 20);
			this.categoryIdCombox.TabIndex = 0;
			this.categoryIdCombox.ValueMember = "Id";
			// 
			// usersFormBindingSource
			// 
			this.usersFormBindingSource.DataSource = typeof(ISpan.EStore.UsersForm);
			// 
			// UsersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.addNewBtn);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.searchBtn);
			this.Controls.Add(this.categoryIdCombox);
			this.Name = "UsersForm";
			this.Text = "檢視紀錄";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.usersFormBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button addNewBtn;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button searchBtn;
		private System.Windows.Forms.ComboBox categoryIdCombox;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn accountDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource userVMBindingSource;
		private System.Windows.Forms.BindingSource usersFormBindingSource;
	}
}