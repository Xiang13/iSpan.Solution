using ISpan.EStore.Models.Services;
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
		private UserIndexVM[] users = null;
		public UsersForm()
		{
			InitializeComponent();
			DisplayUsers();
		}
		private void BinData(UserIndexVM[] data)
		{
			dataGridView1.DataSource = data;
		}		
		private void DisplayUsers()
		{
			users = new UserService().GetAll().ToArray();
			BinData(users);
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
