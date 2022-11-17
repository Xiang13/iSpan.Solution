using ISpan.EStore.Controls;
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
	public partial class DemoHobby : Form
	{
		public DemoHobby()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string hobby = this.uchobby1.GetValue();
			MessageBox.Show(hobby);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string vaule = textBox1.Text;
			this.uchobby1.SetValue(vaule);
		}
	}
}
