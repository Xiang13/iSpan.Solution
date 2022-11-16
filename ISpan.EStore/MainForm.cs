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
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			this.IsMdiContainer = true;
		}

		private void 維護商品ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new ProductsForm();
			frm.MdiParent = this;
			frm.Show();
		}

		private void 維護商品類別ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new ProductCategoriesForm();
			frm.MdiParent = this;
			frm.Show();
		}

		private void 維護使用者ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new UsersForm();
			frm.MdiParent = this;
			frm.Show();
		}

		private void 登出ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("您確定要登出嗎?", "登出", MessageBoxButtons.YesNo);
			if(result == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Owner.Show();
		}
	}
}
