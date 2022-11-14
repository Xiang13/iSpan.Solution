using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.EStore.Models.VIewModels
{
	public class ProductIndexVM
	{
		/// <summary>
		/// 供 productsForm 使用
		/// </summary>
		public int Id { get; set; }
		public string CategoryName { get; set; }
		public string ProductName { get; set; }
		public int ListPrice { get; set; }
	}
	/// <summary>
	/// 供 CreateProductForm, EditProductForm 使用
	/// </summary>
	public class ProductVM
	{
		public int Id { get; set; }
		public int CategoryId { get; set; }
		public string ProductName { get; set; }
		public int ListPrice { get; set; }
	}
}
