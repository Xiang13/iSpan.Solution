using ISpan.EStore.Models.VIewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.EStore
{
	public partial class ProductsForm : Form
	{
		public ProductsForm()
		{
			InitializeComponent();

			InitForm();

			// 顯示商品紀錄
			DisplayProducts();			
		}

		private void InitForm()
		{
			categoryIdCombox.DropDownStyle = ComboBoxStyle.DropDownList;
			var sql = "SELECT * FROM productCategories ORDER BY DisplayOrder";
			var dbHelper = new SqlDbHelper("default");

			List<ProductCategoryVM> categories = dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ToCategoryVM(row))
				.Prepend(new ProductCategoryVM { Id=0, CategoryName=String.Empty})
				.ToList();

			this.categoryIdCombox.DataSource = categories;
		}
		private ProductCategoryVM ToCategoryVM(DataRow row)
		{
			return new ProductCategoryVM
			{
				Id = row.Field<int>("Id"),
				CategoryName = row.Field<string>("CategoryName"),
				DisplayOrder = row.Field<int>("DisplayOrder"),
			};
		}

		private ProductIndexVM[] products = null;
		private void DisplayProducts()
		{
			string sql = @"SELECT P.Id, P.ProductName, P.ListPrice, C.CategoryName
						   FROM  ProductsTable P INNER JOIN ProductCategories C ON P.CategoryId = C.Id";

			SqlParameter[] parameters = new SqlParameter[] { };

			// 取得篩選值
			int categoryId = ((ProductCategoryVM)categoryIdCombox.SelectedItem).Id;

			if (categoryId > 0)
			{
				sql += " WHERE CategoryId=@CategoryId";
				parameters = new SqlParameterBuilder()
					.AddInt("CategoryId", categoryId)
					.Build();
			}
			// 加入排序子句
			sql += " ORDER BY C.DisplayOrder, P.ProductName";
			var dbHelper = new SqlDbHelper("default");
			// 存放在 Field, 稍後在 grid CellClick 事件會需要再度用到它
			products = dbHelper.Select(sql, parameters)
				.AsEnumerable()
				.Select(row=> ParseToIndexVM(row))
				.ToArray();
			BinData(products);
		}
		private void BinData(ProductIndexVM[] data)
		{
			dataGridView1.DataSource = data;
		}
		private ProductIndexVM ParseToIndexVM(DataRow row)
		{
			return new ProductIndexVM
			{
				Id = row.Field<int>("Id"),
				CategoryName = row.Field<string>("CategoryName"),
				ProductName = row.Field<string>("ProductName"),
				ListPrice = row.Field<int>("ListPrice"),
			};
		}
		private void searchBtn_Click(object sender, EventArgs e)
		{
			DisplayProducts();
		}
		private void addNewBtn_Click(object sender, EventArgs e)
		{
			var frm = new CreateProductForm();
			DialogResult result = frm.ShowDialog();
			if (result == DialogResult.OK)
			{
				DisplayProducts();
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;  // 使用者點到的索引值

			if (rowIndx < 0) return;

			ProductIndexVM row = this.products[rowIndx];  // 使用者點到的那一筆紀錄
			int id = row.Id;            // 使用者點到的那一筆紀錄的 id 值

			// 把 id 傳給編輯表單的建構函數
			var frm = new EditProductForm(id);
			// frm.Show();
			DialogResult result = frm.ShowDialog();
			if (result == DialogResult.OK)
			{
				DisplayProducts();
			}
		}
	}
}
