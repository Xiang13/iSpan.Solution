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
	public partial class CreateUserForm : Form
	{
		public CreateUserForm()
		{
			InitializeComponent();
		}

		private void saveBtn_Click(object sender, EventArgs e)
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
			// 如果通過驗證, 就新增紀錄
			string sql = @"INSERT INTO Users (Account, Password, Name)
						VALUES(@Account, @Password, @Name)";
			var parameters = new SqlParameterBuilder().AddNVarchar("Account", 50, model.Account)
													  .AddNVarchar("Password", 50, model.Password)
													  .AddNVarchar("Name", 50, model.Name)
													  .Build();
			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

			this.DialogResult = DialogResult.OK;
		}
	}
}
