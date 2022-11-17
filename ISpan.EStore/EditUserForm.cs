using ISpan.EStore.InfraStructures;
using ISpan.EStore.InfraStructures.DAOs;
using ISpan.EStore.Models.DTOs;
using ISpan.EStore.Models.Services;
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
			#region
			//string sql = "SELECt * FROM Users WHERE Id=@Id";
			//var parameters = new SqlParameterBuilder().AddInt("Id", id).Build();

			//DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			//if (data.Rows.Count == 0)
			//{
			//	MessageBox.Show("抱歉, 找不到要編輯的資料");
			//	this.DialogResult = DialogResult.OK;

			//	// this.Close();
			//	return;
			//}
			//else
			//{
			//	// 將找到的一筆紀錄由 DataTable 轉換到 productVM
			//	UserVM model = ToUserVM(data.Rows[0]);

			//	// 再將 ViewModel 值繫結到個控制項
			//	//categoryIdComboBox.SelectedItem = ((List<ProductCategoryVM>)categoryIdComboBox.DataSource)
			//	//								.FirstOrDefault(x => x.Id == model.CategoryId);
			#endregion
			UserDTO dto = new UserDAO().Get(id);

			UserVM model = dto.ToVM();
			accountTxtBox.Text = model.Account;
			passwordTxtBox.Text = model.Password;
			nameTxtBox.Text = model.Name;
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
				Id = this.id,
				Account = account,
				Password = password,
				Name = name
			};

			// 如果通過驗證, 就新增紀錄
			// 針對 viewModel 進行欄位驗證
			// 大小寫不同仍視為相同的key
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Account", accountTxtBox },
				{"Password", passwordTxtBox },
				{"Name", nameTxtBox },
			};
			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;

			// 如果通過驗證, 就新增紀錄
			// 將 ViewModel 轉成 DTO
			UserDTO dto = model.ToDTO();
			try
			{
				new UserService().Edit(dto);
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"新增失敗, 原因: {ex.Message}");
			}
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			UserVM model = new UserVM
			{
				Id = this.id,
			};
				new UserService().Delete(model);
			this.DialogResult = DialogResult.OK;
		}

		private void EditUserForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}
	}
}
