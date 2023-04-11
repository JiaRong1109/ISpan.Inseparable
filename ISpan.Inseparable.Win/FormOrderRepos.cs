using ISpan.Inseparable.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ISpan.Inseparable.Win
{
	public partial class FormOrderRepos : Form
	{
		InseparableEntities InseparableDb = new InseparableEntities();
		public FormOrderRepos()
		{
			InitializeComponent();
			ChartCal();


		}

		public void ChartCal()
		{
			chartOrderCal.Titles.Add("訂單統計圖");
			chartOrderCal.Series.Add("訂單數統計");
			chartOrderCal.Series["訂單數統計"].ChartType = SeriesChartType.Column;
			

			chartOrderCal.Series["訂單數統計"].XValueType = ChartValueType.String;
			chartOrderCal.Series["訂單數統計"].YValueType = ChartValueType.Int32;
			

			var x = InseparableDb.Orders.GroupBy(o => o.CinemaID).Where(g => g.Count() > 0);
			int[] xarr = { };
			foreach (var item in x)
			{
				Array.Resize(ref xarr, xarr.Length + 1);
				xarr[xarr.Length - 1] = item.Key;
			}
			String[] AllX = { };
			foreach (var item in xarr)
			{
				var Name = InseparableDb.Cinemas.First(c => c.CinemaID == item).CinemaName;
				Array.Resize(ref AllX, AllX.Length + 1);
				AllX[AllX.Length - 1] = Name;
			}

			var y = InseparableDb.Orders.GroupBy(o => o.CinemaID);
			int[] CloumnY = { };
			foreach (var item in y)
			{
				Array.Resize(ref CloumnY, CloumnY.Length + 1);
				CloumnY[CloumnY.Length - 1] = item.Count();
			}
			chartOrderCal.Series["訂單數統計"].Points.DataBindXY(AllX, CloumnY);
			chartOrderCal.Series["訂單數統計"].ToolTip = "#VAL";

			
		}
		public void ChartTotal()
		{
			chartOrderCal.Titles.Add("訂單累積金額圖");
			chartOrderCal.Series.Add("累積金額");
			chartOrderCal.Series["累積金額"].ChartType = SeriesChartType.Column;

			chartOrderCal.Series["累積金額"].XValueType = ChartValueType.String;
			chartOrderCal.Series["累積金額"].YValueType = ChartValueType.Int32;

			var x = InseparableDb.Orders.GroupBy(o => o.CinemaID).Where(g => g.Count() > 0);
			int[] xarr = { };
			foreach (var item in x)
			{
				Array.Resize(ref xarr, xarr.Length + 1);
				xarr[xarr.Length - 1] = item.Key;
			}
			String[] AllX = { };
			foreach (var item in xarr)
			{
				var Name = InseparableDb.Cinemas.First(c => c.CinemaID == item).CinemaName;
				Array.Resize(ref AllX, AllX.Length + 1);
				AllX[AllX.Length - 1] = Name;
			}

			var total = InseparableDb.Orders.GroupBy(o => o.CinemaID);
			int[] totalY = { };
			foreach (var item in total)
			{
				Array.Resize(ref totalY, totalY.Length + 1);
				totalY[totalY.Length - 1] = item.Sum(o => o.TotalMoney);
			}

			chartOrderCal.Series["累積金額"].Points.DataBindXY(AllX, totalY);
			chartOrderCal.Series["累積金額"].ToolTip = "累積金額：#VAL(元)";

		}

		public void ChartProduct()
		{
			chartOrderCal.Titles.Add("產品銷售統計圖");
			chartOrderCal.Series.Add("產品銷售量");

			chartOrderCal.Series["產品銷售量"].ChartType = SeriesChartType.Pie;
			chartOrderCal.Series["產品銷售量"].XValueType = ChartValueType.String;
			chartOrderCal.Series["產品銷售量"].YValueType = ChartValueType.Int32;

			var x = InseparableDb.ProductOrderDetails.GroupBy(po => po.ProductName).Where(g => g.Count() > 0);
			string[] AllX = { };
			foreach(var item in x)
			{
				Array.Resize(ref AllX, AllX.Length + 1);
				AllX[AllX.Length-1]=item.Key;
			}

			var y = InseparableDb.ProductOrderDetails.GroupBy(po => po.ProductID);
			int[] yCount = { };
			foreach(var item in y)
			{
				Array.Resize(ref yCount, yCount.Length + 1);
				yCount[yCount.Length - 1] = item.Sum(p=>p.ProductQty);
			}

			chartOrderCal.Series["產品銷售量"].Points.DataBindXY(AllX, yCount);
			chartOrderCal.Series["產品銷售量"].ToolTip = "#VAL(個)  佔#PERCENT{P1}";
			chartOrderCal.Series["產品銷售量"].Label ="#VALX：#PERCENT{P1}";
		}

		public void ChartMovie()
		{
			chartOrderCal.Titles.Add("電影銷售統計圖");
			chartOrderCal.Series.Add("電影銷售量");

			chartOrderCal.Series["電影銷售量"].ChartType = SeriesChartType.Bar;
			chartOrderCal.Series["電影銷售量"].XValueType = ChartValueType.String;
			chartOrderCal.Series["電影銷售量"].YValueType = ChartValueType.Int32;

			var x = InseparableDb.TicketOrderDetails.GroupBy(po => po.MovieID).Where(g => g.Count() > 0);
			int[] xId = { };
			foreach (var item in x)
			{
				Array.Resize(ref xId, xId.Length + 1);
				xId[xId.Length - 1] = item.Key;
			}
			string[] AllX = { };
			foreach (var item in xId)
			{
				var Name = InseparableDb.Movies.First(p => p.MovieID == item).MovieName;
				Array.Resize(ref AllX, AllX.Length + 1);
				AllX[AllX.Length - 1] = Name;
			}

			var y = InseparableDb.TicketOrderDetails.GroupBy(po => po.MovieID);
			int[] yCount = { };
			foreach (var item in y)
			{
				Array.Resize(ref yCount, yCount.Length + 1);
				yCount[yCount.Length - 1] = item.Count();
			}

			chartOrderCal.Series["電影銷售量"].Points.DataBindXY(AllX, yCount);
			chartOrderCal.Series["電影銷售量"].ToolTip = "#VAL(張)";
		}
		private void button1_Click(object sender, EventArgs e)
		{
			chartOrderCal.Titles.Clear();
			chartOrderCal.Series.Clear();
			ChartCal();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			chartOrderCal.Titles.Clear();
			chartOrderCal.Series.Clear();
			ChartTotal();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			chartOrderCal.Titles.Clear();
			chartOrderCal.Series.Clear();
			ChartProduct();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			chartOrderCal.Titles.Clear();
			chartOrderCal.Series.Clear();
			ChartMovie();
		}
	}
}
