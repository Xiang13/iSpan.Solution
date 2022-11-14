using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.EStore.Models.VIewModels
{
	internal class ProductCategoryVM
	{
		public int Id { get; set; }
		public string CategoryName { get; set; }
		public int DisplayOrder { get; set; }
	}
}
