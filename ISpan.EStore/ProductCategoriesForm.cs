using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.EStore
{
	public partial class ProductCategoriesForm : Form
	{
		DataTable categories;
		public ProductCategoriesForm()
		{
			InitializeComponent();

			DisplayProductCategories();
		}
		private void DisplayProductCategories()
		{
			string sql = @"SELECT [Id], [CategoryName] ,[DisplayOrder]
						  FROM [ProductCategories] 
						  ORDER BY Id";
			categories = new SqlDbHelper("default").Select(sql, null);

			BinData(categories);
		}
		private void BinData(DataTable model)
		{
			dataGridView1.DataSource = model;
		}

		private void addNewBtn_Click(object sender, EventArgs e)
		{
			var frm = new CreateProductCategoryForm();
			DialogResult result = frm.ShowDialog();
			if (result == DialogResult.OK)
			{
				DisplayProductCategories();
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;  // 使用者點到的索引值

			if (rowIndx < 0) return;

			DataRow row = this.categories.Rows[rowIndx];  // 使用者點到的那一筆紀錄
			int id = row.Field<int>("Id");				  // 使用者點到的那一筆紀錄的 id 值

			// 把 id 傳給編輯表單的建構函數
			var frm = new EditProductCategoryForm(id);
			// frm.Show();
			DialogResult result = frm.ShowDialog();
			if (result == DialogResult.OK)
			{
				DisplayProductCategories();
			}
		}
	}
}
