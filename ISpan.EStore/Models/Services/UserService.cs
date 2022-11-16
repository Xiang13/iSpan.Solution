using ISpan.EStore.Models.VIewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.EStore.Models.Services
{
	public class UserService
	{
		private int id;
		/// <summary>
		/// 傳回所有使用者紀錄
		/// </summary>
		/// <returns></returns>
		public IEnumerable<UserIndexVM> GetAll()
		{
			string sql = @"SELECT U.Id, U.Account, U.Name
						   FROM  Users U";
			var dbHelper = new SqlDbHelper("default");
			return dbHelper.Select(sql, null)
								.AsEnumerable()
								.Select(row => ParseToIndexVM(row));
								// .ToList();
		}
		public UserIndexVM ParseToIndexVM(DataRow row)
		{
			return new UserIndexVM
			{
				Id = row.Field<int>("Id"),
				Account = row.Field<string>("Account"),
				// Password = row.Field<string>("Password"),
				Name = row.Field<string>("Name"),
			};
		}
		public UserVM ToUserVM(DataRow row)
		{
			return new UserVM
			{
				Id = row.Field<int>("Id"),
				Account = row.Field<string>("Account"),
				Password = row.Field<string>("Password"),
				Name = row.Field<string>("Name"),
			};
		}
		public void Create(UserVM model)
		{
			bool isExists = AccountExists(model.Account);
			if (isExists) throw new Exception("帳號已存在");
			string sql = @"INSERT INTO Users (Account, Password, Name)
						VALUES(@Account, @Password, @Name)";
			var parameters = new SqlParameterBuilder().AddNVarchar("Account", 50, model.Account)
													  .AddNVarchar("Password", 50, model.Password)
													  .AddNVarchar("Name", 50, model.Name)
													  .Build();
			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
		public void Edit(UserVM model)
		{
			bool isExists = AccountExists(model.Account);
			if (isExists) throw new Exception("帳號已存在");
			string sql = @"UPDATE Users SET Account=@Account, Password=@Password, Name=@Name
							WHERE Id=@Id";

			var parameters = new SqlParameterBuilder().AddNVarchar("Account", 50, model.Account)
														.AddNVarchar("Password", 50, model.Password)
														.AddNVarchar("Name", 50, model.Name)
														.AddInt("Id", model.Id)
														.Build();
			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
		public void Delete(UserVM model)
		{
			if (MessageBox.Show("您真的要刪除嗎?", "刪除紀錄", MessageBoxButtons.YesNo,
														   MessageBoxIcon.Question)
														  != DialogResult.Yes)
			{
				return;
			}
			string sql = @"DELETE FROM Users WHERE Id=@Id";
			var parameters = new SqlParameterBuilder().AddInt("Id", model.Id)
													  .Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
		private bool AccountExists(string account)
		{
			string sql = @"Select Count(*) as count From Users WHERE Account=@Account";
			var parameters = new SqlParameterBuilder().AddNVarchar("Account", 50, account)
													  .Build();
			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}
		public bool Authenticate(LoginVM model)
		{
			var user = Get(model.Account);
			if (user == null) return false; // 找不到符合的帳號
			return (user.Password == model.Password);
		}
		public UserVM Get(string account)
		{
			string sql = @"SELECT * FROM Users Where Account=@Account";
			var parameters = new SqlParameterBuilder()
									.AddNVarchar("Account", 50, account)
									.Build();
			var dbHelper = new SqlDbHelper("default").Select(sql, parameters);
			if  (dbHelper.Rows.Count == 0)
			{
				return null;
			}
			// 將找到的一筆紀錄由 DataTable 轉換到 UserVM
			return ToUserVM(dbHelper.Rows[0]);
		}
	}
}
