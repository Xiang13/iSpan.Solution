using ISpan.EStore.InfraStructures.Extensions;
using ISpan.EStore.Models.VIewModels;
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
	public partial class EditProductForm : Form
	{
		private int id;
		public EditProductForm(int id)
		{
			InitializeComponent();
			InitForm();
			this.id = id;
			BindData(id);
		}
		private void InitForm()
		{
			categoryIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			var sql = "SELECT * FROM ProductCategories ORDER BY DisplayOrder";
			var dbHelper = new SqlDbHelper("default");

			List<ProductCategoryVM> categories = dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ToCategoryVM(row))
				//.Prepend(new ProductCategoryVM { Id = 0, CategoryName = String.Empty })
				.ToList();

			this.categoryIdComboBox.DataSource = categories;
		}
		private void EditProductForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}
		private void BindData(int id)
		{
			string sql = "SELECt * FROM ProductsTable WHERE Id=@Id";
			var parameters = new SqlParameterBuilder().AddInt("Id", id).Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			if (data.Rows.Count == 0)
			{
				MessageBox.Show("抱歉, 找不到要編輯的資料");
				this.DialogResult = DialogResult.OK;

				// this.Close();
				return;
			}
			else
			{
				// 將找到的一筆紀錄由 DataTable 轉換到 productVM
				ProductVM model = ToProductVM(data.Rows[0]);

				// 再將 ViewModel 值繫結到個控制項
				categoryIdComboBox.SelectedItem = ((List<ProductCategoryVM>)categoryIdComboBox.DataSource)
												.FirstOrDefault(x => x.Id == model.CategoryId);

				productNameTxtBox.Text = model.ProductName;
				listPriceTxtBox.Text = model.ListPrice.ToString();
			}
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
		private ProductVM ToProductVM(DataRow row)
		{
			return new ProductVM
			{
				Id = row.Field<int>("Id"),
				CategoryId = row.Field<int>("CategoryId"),
				ProductName = row.Field<string>("ProductName"),
				ListPrice = row.Field<int>("ListPrice"),
			};
		}
		private void saveButton_Click(object sender, EventArgs e)
		{
			// 取得表單各欄位的值
			int categoryId = ((ProductCategoryVM)this.categoryIdComboBox.SelectedItem).Id;
			string productName = productNameTxtBox.Text;
			int listPrice = listPriceTxtBox.Text.Toint(-1);

			// 將它們繫結到 ViewModel
			ProductVM model = new ProductVM
			{
				CategoryId = categoryId,
				ProductName = productName,
				ListPrice = listPrice
			};
			// 針對 ViewModel 進行欄位驗證
			string errorMsg = string.Empty;
			if (string.IsNullOrEmpty(model.ProductName)) errorMsg += "商品名稱必填\r\n";
			if (listPrice < 0) errorMsg += "牌價必須為大於或等於零的整數\r\n";
			if (string.IsNullOrEmpty(errorMsg) == false)
			{
				// 表示至少有一欄有錯誤
				MessageBox.Show(errorMsg);
				return; // 不再向下執行
			}

			// 如果通過驗證, 就新增紀錄
			string sql = @"UPDATE ProductsTable SET CategoryId=@CategoryId, ProductName=@ProductName, ListPrice=@ListPrice
							WHERE Id=@Id";
			var parameters = new SqlParameterBuilder().AddInt("CategoryId", model.CategoryId)
														.AddNVarchar("ProductName", 50, model.ProductName)
														.AddInt("ListPrice", model.ListPrice)
														.AddInt("Id", this.id)
														.Build();
			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

			this.DialogResult = DialogResult.OK;
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("您真的要刪除嗎?", "刪除紀錄", MessageBoxButtons.YesNo,
														   MessageBoxIcon.Question)
														  != DialogResult.Yes)
			{
				return;
			}
			string sql = @"DELETE FROM ProductsTable WHERE Id=@Id";
			var parameters = new SqlParameterBuilder().AddInt("Id", this.id)
													  .Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

			this.DialogResult = DialogResult.OK;
		}
	}
}
