using ISpan.EStore.Models.VIewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.EStore
{
	public partial class UsersForm : Form
	{
		int Id = 0;
		public UsersForm()
		{
			InitializeComponent();
			//InitForm();
			DisplayUsers();
		}
		//private void InitForm()
		//{
		//	categoryIdCombox.DropDownStyle = ComboBoxStyle.DropDownList;
		//	var sql = "SELECT * FROM Users ORDER BY Account";
		//	var dbHelper = new SqlDbHelper("default");

		//	List<ProductCategoryVM> categories = dbHelper.Select(sql, null)
		//		.AsEnumerable()
		//		.Select(row => ToCategoryVM(row))
		//		.Prepend(new ProductCategoryVM { Id = 0, CategoryName = String.Empty })
		//		.ToList();

		//	this.categoryIdCombox.DataSource = categories;
		//}
		//private ProductCategoryVM ToCategoryVM(DataRow row)
		//{
		//	return new ProductCategoryVM
		//	{
		//		Id = row.Field<int>("Id"),
		//		CategoryName = row.Field<string>("CategoryName"),
		//		DisplayOrder = row.Field<int>("DisplayOrder"),
		//	};
		//}
		private UserIndexVM[] users = null;
		private void BinData(UserIndexVM[] data)
		{
			dataGridView1.DataSource = data;
		}
		//private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		//{
		//	int rowIndx = e.RowIndex;  // 使用者點到的索引值

		//	if (rowIndx < 0) return;

		//	UserIndexVM row = this.users[rowIndx];  // 使用者點到的那一筆紀錄
		//	int id = row.Id;            // 使用者點到的那一筆紀錄的 id 值

		//	// 把 id 傳給編輯表單的建構函數
		//	var frm = new EditProductForm(id);
		//	// frm.Show();
		//	DialogResult result = frm.ShowDialog();
		//	if (result == DialogResult.OK)
		//	{
		//		DisplayUsers();
		//	}
		//}
		private void DisplayUsers()
		{
			string sql = @"SELECT U.Id, U.Account, U.Password, U.Name
						   FROM  Users U";

			SqlParameter[] parameters = new SqlParameter[] { };

			//// 取得篩選值
			//int categoryId = ((ProductCategoryVM)categoryIdCombox.SelectedItem).Id;

			//if (categoryId > 0)
			//{
			//	sql += " WHERE CategoryId=@CategoryId";
			parameters = new SqlParameterBuilder()
				.AddInt("Id", Id)
				.Build();
			//}
			//// 加入排序子句
			//sql += " ORDER BY C.DisplayOrder, P.ProductName";
			var dbHelper = new SqlDbHelper("default");
			// 存放在 Field, 稍後在 grid CellClick 事件會需要再度用到它
			users = dbHelper.Select(sql, parameters)
								.AsEnumerable()
								.Select(row => ParseToIndexVM(row))
								.ToArray();
			BinData(users);
		}
		private UserIndexVM ParseToIndexVM(DataRow row)
		{
			return new UserIndexVM
			{
				Id = row.Field<int>("Id"),
				Account = row.Field<string>("Account"),
				Password = row.Field<string>("Password"),
				Name = row.Field<string>("Name"),
			};
		}
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;  // 使用者點到的索引值

			if (rowIndx < 0) return;

			UserIndexVM row = this.users[rowIndx];  // 使用者點到的那一筆紀錄
			int id = row.Id;            // 使用者點到的那一筆紀錄的 id 值

			// 把 id 傳給編輯表單的建構函數
			var frm = new EditUserForm(id);
			// frm.Show();
			DialogResult result = frm.ShowDialog();
			if (result == DialogResult.OK)
			{
				DisplayUsers();
			}
		}

		private void addNewBtn_Click(object sender, EventArgs e)
		{
			var frm = new CreateUserForm();
			DialogResult result = frm.ShowDialog();
			if (result == DialogResult.OK)
			{
				DisplayUsers();
			}
		}
	}
}
