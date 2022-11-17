using ISpan.EStore.InfraStructures;
using ISpan.EStore.Models.DTOs;
using ISpan.EStore.Models.Services;
using ISpan.EStore.Models.VIewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
				// new UserService().Create(model);
				new UserService().Create(dto);
				this.DialogResult = DialogResult.OK;
			}
			catch(Exception ex)
			{
				MessageBox.Show($"新增失敗, 原因: {ex.Message}");
			}
		}
	}
}
