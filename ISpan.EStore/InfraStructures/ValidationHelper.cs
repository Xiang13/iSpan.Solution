using ISpan.EStore.Models.VIewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.EStore.InfraStructures
{
	public class ValidationHelper
	{
		public static bool Validate<T>(T model, Dictionary<string, Control> map, ErrorProvider errorProvider)
		{
			// 得知驗證規則
			ValidationContext context = new ValidationContext(model, null, null);
			// 用來存放錯誤的集合, 因為可能有零到多個的錯誤
			List<ValidationResult> errors = new List<ValidationResult>();
			// 驗證 model
			errorProvider.Clear();

			bool validateAllPreperies = true; // 是否驗證所有規則, 而非只驗證 Required 規則
			bool isValid = Validator.TryValidateObject(model, context, errors, validateAllPreperies);
			if (!isValid)
			{
				DisplayErrorsByErrorProvider(errors, map, errorProvider);
			}
			return isValid;
		}

		private static void DisplayErrorsByErrorProvider(List<ValidationResult> errors, Dictionary<string, Control> map, ErrorProvider errorProvider)
		{
			// this.errorProvider1.Clear();
			foreach (ValidationResult error in errors)
			{
				string propName = error.MemberNames.FirstOrDefault();
				if (map.TryGetValue(propName, out Control ctrl))
				{
					errorProvider.SetError(ctrl, error.ErrorMessage);
				}
			}
		}
	}
}
