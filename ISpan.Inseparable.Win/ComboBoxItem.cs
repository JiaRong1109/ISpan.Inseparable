using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Inseparable.Win
{
	public class ComboBoxItem
	{
		public int? Value { get; set; }
		public string Text { get; set; }
		public ComboBoxItem(int? value, string text)
		{
			Value = value;
			Text = text;
		}
		public override string ToString()
		{
			return Text;
		}
	}
}
