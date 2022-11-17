using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ISpan.EStore.Controls
{
	public partial class ucGender : UserControl
	{
		public ucGender()
		{
			InitializeComponent();
		}

		internal int GetValue()
		{
			RadioButton[] controls = new RadioButton[] { gender0RadioBtn, gender1RadioBtn };
			int value = -1;
			foreach (RadioButton item in controls)
			{
				if (item.Checked == true)
				{
					value = Convert.ToInt32(item.Tag);
					break;
				}
			}
			return value;
		}

		internal void SetValue(int value)
		{
			RadioButton[] controls = new RadioButton[] { gender1RadioBtn, gender0RadioBtn };
			// 先清空空控制項勾選的狀態
			foreach (RadioButton item in controls)
			{
				item.Checked = false;
			}

			// 根據 value , 決定哪一個 radio button 要被選取
			foreach (RadioButton item in controls)
			{
				int controlTag = Convert.ToInt32(item.Tag);
				if (controlTag == value)
				{
					item.Checked = true;
					break;
				}
			}
		}
	}
}
