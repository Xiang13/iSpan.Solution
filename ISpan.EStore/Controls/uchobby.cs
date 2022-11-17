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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;

namespace ISpan.EStore.Controls
{
	public partial class uchobby : UserControl
	{
		public uchobby()
		{
			InitializeComponent();
		}
		public string GetValue()
		{
			CheckBox[] contorls = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6 };
			string value = string.Empty; // 紀錄哪些值被勾選
			foreach (CheckBox item in contorls)
			{
				if (item.Checked)
				{
					value += "," + item.Tag.ToString();
				}
			}
			if (string.IsNullOrEmpty(value) == false)
			{
				value = value.Substring(1);
			}
			return value;
		}
		public void SetValue(string value)
		{
			CheckBox[] contorls = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6 };

			// 先將所以 CheckBox 全部取消勾選
			foreach (CheckBox item in contorls)
			{
				item.Checked = false;
			}

			// 如果 textBox1 是空的就回傳
			string valueInDb = value;
			if (string.IsNullOrEmpty(valueInDb)) return;

			// 找出 checkbox, tag 對照表
			Dictionary<string, CheckBox> map = new Dictionary<string, CheckBox>();

			// [{"A", checkbox1}, {"B", checkbox2}, {"C", checkbox3}, ...]
			foreach (CheckBox item in contorls)
			{
				map.Add(item.Tag.ToString(), item);
			}

			// 根據 valueInDb 的值, 決定哪些 checkbox 要勾選
			string[] values = valueInDb.Split(','); // {"C", "D", "XXXXX"}
			foreach (string key in values)
			{
				if (map.ContainsKey(key))
				{
					CheckBox contorl = map[key];
					contorl.Checked = true;
				}
			}
		}
	}
}
