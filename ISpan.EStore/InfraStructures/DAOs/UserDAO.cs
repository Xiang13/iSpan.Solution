using ISpan.EStore.Models.DTOs;
using ISpan.EStore.Models.VIewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.EStore.InfraStructures.DAOs
{
	public class UserDAO
	{
		public IEnumerable<UserDTO> GetAll()
		{
			string sql = @"SELECT * FROM Users ORDER BY ID";

			var dbHelper = new SqlDbHelper("default");
			// 存放在field裡, 稍後在 grid CellClick事件會需要再度用到它
			return dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ToUserDTO(row));

		}
		public void Create(UserDTO dto)
		{
			string sql = @"INSERT INTO Users (Account, Password, Name)
						VALUES(@Account, @Password, @Name)";
			var parameters = new SqlParameterBuilder().AddNVarchar("Account", 50, dto.Account)
													  .AddNVarchar("Password", 50, dto.Password)
													  .AddNVarchar("Name", 50, dto.Name)
													  .Build();
			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
		public void Edit(UserDTO dto)
		{
			string sql = @"UPDATE Users SET Account=@Account, Password=@Password, Name=@Name
							WHERE Id=@Id";

			var parameters = new SqlParameterBuilder().AddNVarchar("Account", 50, dto.Account)
														.AddNVarchar("Password", 50, dto.Password)
														.AddNVarchar("Name", 50, dto.Name)
														.AddInt("Id", dto.Id)
														.Build();
			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
		public void Delete(int Id)
		{
			string sql = @"DELETE FROM Users WHERE Id=@Id";
			var parameters = new SqlParameterBuilder().AddInt("Id", Id)
													  .Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
		public UserDTO Get(string account)
		{
			string sql = @"SELECT * FROM Users Where Account=@Account";
			var parameters = new SqlParameterBuilder()
									.AddNVarchar("Account", 50, account)
									.Build();
			var dbHelper = new SqlDbHelper("default").Select(sql, parameters);
			if (dbHelper.Rows.Count == 0)
			{
				return null;
			}
			// 將找到的一筆紀錄由 DataTable 轉換到 UserVM
			return ToUserDTO(dbHelper.Rows[0]);
		}
		public UserDTO Get(int id)
		{
			string sql = "SELECt * FROM Users WHERE Id=@Id";
			var parameters = new SqlParameterBuilder().AddInt("Id", id).Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			if (data.Rows.Count == 0)
			{
				
				// this.Close();
				throw new Exception("抱歉, 找不到要編輯的資料");
			}
			// 將找到的一筆記錄由DataTable 轉換到 ProductVM
			return ToUserDTO(data.Rows[0]);
		}
		public UserDTO ToUserDTO(DataRow row)
		{
			return new UserDTO
			{
				Id = row.Field<int>("Id"),
				Account = row.Field<string>("Account"),
				Password = row.Field<string>("Password"),
				Name = row.Field<string>("Name"),
			};
		}
		public bool AccountExists(string account)
		{
			string sql = @"Select Count(*) as count From Users WHERE Account=@Account";
			var parameters = new SqlParameterBuilder().AddNVarchar("Account", 50, account)
													  .Build();
			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}
	}
}
