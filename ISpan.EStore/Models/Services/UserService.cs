using ISpan.EStore.InfraStructures.DAOs;
using ISpan.EStore.Models.DTOs;
using ISpan.EStore.Models.VIewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
		private UserDAO _dao;
		public UserService()
		{
			_dao = new UserDAO();
		}
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
		//public UserVM ToUserVM(DataRow row)
		//{
		//	return new UserVM
		//	{
		//		Id = row.Field<int>("Id"),
		//		Account = row.Field<string>("Account"),
		//		Password = row.Field<string>("Password"),
		//		Name = row.Field<string>("Name"),
		//	};
		//}
		public void Create(UserDTO dto)
		{
			bool isExists = _dao.AccountExists(dto.Account);
			if (isExists) throw new Exception("帳號已存在");
			#region 將 sql, parmeters 移到 UserDAO 裡
			//string sql = @"INSERT INTO Users (Account, Password, Name)
			//			VALUES(@Account, @Password, @Name)";
			//var parameters = new SqlParameterBuilder().AddNVarchar("Account", 50, dto.Account)
			//										  .AddNVarchar("Password", 50, dto.Password)
			//										  .AddNVarchar("Name", 50, dto.Name)
			//										  .Build();
			//new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			#endregion
			new UserDAO().Create(dto);
		}
		public void Edit(UserDTO dto)
		{
			bool isExists = _dao.AccountExists(dto.Account);
			if (isExists) throw new Exception("帳號已存在");
			#region 將 sql, parmeters 移到 UserDAO 裡
			//string sql = @"UPDATE Users SET Account=@Account, Password=@Password, Name=@Name
			//				WHERE Id=@Id";

			//var parameters = new SqlParameterBuilder().AddNVarchar("Account", 50, dto.Account)
			//											.AddNVarchar("Password", 50, dto.Password)
			//											.AddNVarchar("Name", 50, dto.Name)
			//											.AddInt("Id", dto.Id)
			//											.Build();
			//new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			#endregion
			new UserDAO().Edit(dto);
		}
		public void Delete(UserVM model)
		{
			if (MessageBox.Show("您真的要刪除嗎?", "刪除紀錄", MessageBoxButtons.YesNo,
														   MessageBoxIcon.Question)
														  != DialogResult.Yes)
			{
				return;
			}
			#region 將 sql, parmeters 移到 UserDAO 裡
			//string sql = @"DELETE FROM Users WHERE Id=@Id";
			//var parameters = new SqlParameterBuilder().AddInt("Id", model.Id)
			//										  .Build();

			//new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			#endregion
			new UserDAO().Delete(model.Id);
		}
		public bool Authenticate(LoginVM model)
		{
			var user = new UserDAO().Get(model.Account);
			if (user == null) return false; // 找不到符合的帳號
			return (user.Password == model.Password);
		}
		
	}
}
