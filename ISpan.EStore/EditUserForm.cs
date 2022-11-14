using ISpan.EStore.Models.VIewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.EStore
{
	public partial class EditUserForm : Form
	{
		private int id;
		public EditUserForm(int id)
		{
			InitializeComponent();
			this.id = id;
			BindData(id);
		}
		private void EditProductForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}
		private void BindData(int id)
		{
			string sql = "SELECt * FROM Users WHERE Id=@Id";
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
				UserVM model = ToUserVM(data.Rows[0]);

				// 再將 ViewModel 值繫結到個控制項
				//categoryIdComboBox.SelectedItem = ((List<ProductCategoryVM>)categoryIdComboBox.DataSource)
				//								.FirstOrDefault(x => x.Id == model.CategoryId);

				accountTxtBox.Text = model.Account;
				passwordTxtBox.Text = model.Password;
				nameTxtBox.Text = model.Name;
			}
		}
		private UserVM ToUserVM(DataRow row)
		{
			return new UserVM
			{
				Id = row.Field<int>("Id"),
				Account = row.Field<string>("Account"),
				Password = row.Field<string>("Password"),
				Name = row.Field<string>("Name")
			};
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			// 取得表單各欄位的值
			string account = accountTxtBox.Text;
			string password = passwordTxtBox.Text;
			string name = nameTxtBox.Text;

			// 將它們繫結到 ViewModel
			UserVM model = new UserVM
			{
				Account = account,
				Password = password,
				Name = name
			};
			//// 針對 ViewModel 進行欄位驗證
			//string errorMsg = string.Empty;
			//if (string.IsNullOrEmpty(model.ProductName)) errorMsg += "商品名稱必填\r\n";
			//if (listPrice < 0) errorMsg += "牌價必須為大於或等於零的整數\r\n";
			//if (string.IsNullOrEmpty(errorMsg) == false)
			//{
			//	// 表示至少有一欄有錯誤
			//	MessageBox.Show(errorMsg);
			//	return; // 不再向下執行
			//			// }

				// 如果通過驗證, 就新增紀錄
				string sql = @"UPDATE Users SET Account=@Account, Password=@Password, Name=@Name
							WHERE Id=@Id";

			var parameters = new SqlParameterBuilder().AddNVarchar("Account", 50, model.Account)
														.AddNVarchar("Password", 50, model.Password)
														.AddNVarchar("Name", 50, model.Name)
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
			string sql = @"DELETE FROM Users WHERE Id=@Id";
			var parameters = new SqlParameterBuilder().AddInt("Id", this.id)
													  .Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

			this.DialogResult = DialogResult.OK;
		}
	}
}
