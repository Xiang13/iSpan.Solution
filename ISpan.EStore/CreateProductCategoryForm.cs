﻿using ISpan.EStore.InfraStructures.Extensions;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.EStore
{
	public partial class CreateProductCategoryForm : Form
	{
		public CreateProductCategoryForm()
		{
			InitializeComponent();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			string categoryName = nameTextBox.Text;

			int displayOrder = displayOrderTextBox.Text.Toint(-1);

			if (displayOrder > 0	)
			{
				string sql = @"INSERT INTO ProductCategories (CategoryName, DisplayOrder)
							VALUES(@CategoryName, @DisplayOrder)";
				var parameters = new SqlParameterBuilder().AddNVarchar("CategoryName", 50, categoryName)
														  .AddInt("DisplayOrder", displayOrder)
														  .Build();
				new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

				this.DialogResult = DialogResult.OK;
			}
			else
			{
				MessageBox.Show("無法新增");
			}

		}
	}
}
