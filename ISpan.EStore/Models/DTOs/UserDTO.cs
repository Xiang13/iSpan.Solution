using ISpan.EStore.Models.VIewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.EStore.Models.DTOs
{
	public class UserDTO
	{
		public int Id { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
		public string Name { get; set; }
	}
	public static class UserDTOExts
	{
		public static UserVM ToVM(this UserDTO dto)
		{
			return new UserVM
			{
				Id = dto.Id,
				Account = dto.Account,
				Password = dto.Password,
				Name = dto.Name,
			};
		}

		public static UserIndexVM ToIndexVM(this UserDTO dto)
		{
			return new UserIndexVM
			{
				Id = dto.Id,
				Account = dto.Account,
				// Password = dto.Password,
				Name = dto.Name,
			};
		}
	}
}
