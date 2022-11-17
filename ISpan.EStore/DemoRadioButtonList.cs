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
	public partial class DemoRadioButtonList : Form
	{
		public DemoRadioButtonList()
		{
			InitializeComponent();
		}

		private void getValueBtn_Click(object sender, EventArgs e)
		{
			RadioButton[] controls = new RadioButton[] { gender1, gender0 };
			int value = -1;
			foreach(RadioButton item in controls)
			{
				if(item.Checked == true)
				{
					value = Convert.ToInt32(item.Tag);
					break;
				}
			}
			MessageBox.Show(value.ToString());
		}

		private void setValueBtn_Click(object sender, EventArgs e)
		{
			bool isInt = int.TryParse(textBox1.Text, out int number);
			int value = (isInt== true) ? number : -1;
			RadioButton[] controls = new RadioButton[] { gender1, gender0 };

			// 先清空空控制項勾選的狀態
			foreach(RadioButton item in controls)
			{
				item.Checked = false;
			}

			// 根據 value , 決定哪一個 radio button 要被選取
			foreach(RadioButton item in controls)
			{
				int controlTag = Convert.ToInt32(item.Tag);
				if(controlTag == value)
				{
					item.Checked = true;
					break;
				}
			}
		}
	}
}
