using ISpan.Inseparable.BLL;
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
	public partial class FormCharts : Form
	{
		InseparableEntities InseparableDb = new InseparableEntities();
		private ArticleService articleService;
		private KeywordDetailService detailService;
		private KeywordService keywordService;

		public FormCharts()
		{
			IArticleRepository articleRepo = new ArticleRepository();
			articleService = new ArticleService(articleRepo);
			IKeywordDetailRepository detailRepo = new KeywordDetailRepository();
			detailService = new KeywordDetailService(detailRepo);
			IKeywordRepository keywordRepo = new KeywordRepository();
			keywordService = new KeywordService(keywordRepo);

			InitializeComponent();
		}

		private void FormCharts_Load(object sender, EventArgs e)
		{
			ChartColumn();
        }

		string chartColumn = "Column";
		string chartPie = "Pie";
		string chartBar = "Bar";
		string chartLine = "Line";
		public void ChartColumn()
		{
			chart1.Titles.Add("各類別文章數統計圖");
			chart1.Series.Add(chartColumn);
			chart1.Series[chartColumn].ChartType = SeriesChartType.Column;


			chart1.Series[chartColumn].XValueType = ChartValueType.String;
			chart1.Series[chartColumn].YValueType = ChartValueType.Int32;


			var x = InseparableDb.KeywordDetails.GroupBy(acd => acd.KeywordID).Where(g => g.Count() > 0);
			int[] xarr = { };
			foreach (var item in x)
			{
				Array.Resize(ref xarr, xarr.Length + 1);
				xarr[xarr.Length - 1] = item.Key;
			}
			String[] AllX = { };
			foreach (var item in xarr)
			{
				var Name = InseparableDb.Keywords.First(ac => ac.KeywordID == item).KeywordName;
				Array.Resize(ref AllX, AllX.Length + 1);
				AllX[AllX.Length - 1] = Name;
			}

			var y = InseparableDb.KeywordDetails.GroupBy(acd => acd.KeywordID);
			int[] CloumnY = { };
			foreach (var item in y)
			{
				Array.Resize(ref CloumnY, CloumnY.Length + 1);
				CloumnY[CloumnY.Length - 1] = item.Count();
			}
			chart1.Series[chartColumn].Points.DataBindXY(AllX, CloumnY);
			chart1.Series[chartColumn].ToolTip = "#VAL";


		}
		public void ChartPie()
		{
			chart1.Titles.Add("各類別文章數統計圖");
			chart1.Series.Add(chartPie);
			chart1.Series[chartPie].ChartType = SeriesChartType.Pie;


			chart1.Series[chartPie].XValueType = ChartValueType.String;
			chart1.Series[chartPie].YValueType = ChartValueType.Int32;


			var x = InseparableDb.KeywordDetails.GroupBy(acd => acd.KeywordID).Where(g => g.Count() > 0);
			int[] xarr = { };
			foreach (var item in x)
			{
				Array.Resize(ref xarr, xarr.Length + 1);
				xarr[xarr.Length - 1] = item.Key;
			}
			String[] AllX = { };
			foreach (var item in xarr)
			{
				var Name = InseparableDb.Keywords.First(ac => ac.KeywordID == item).KeywordName;
				Array.Resize(ref AllX, AllX.Length + 1);
				AllX[AllX.Length - 1] = Name;
			}

			var y = InseparableDb.KeywordDetails.GroupBy(acd => acd.KeywordID);
			int[] CloumnY = { };
			foreach (var item in y)
			{
				Array.Resize(ref CloumnY, CloumnY.Length + 1);
				CloumnY[CloumnY.Length - 1] = item.Count();
			}
			chart1.Series[chartPie].Points.DataBindXY(AllX, CloumnY);
			chart1.Series[chartPie].ToolTip = "#VAL";


		}
		public void ChartBar()
		{
			chart1.Titles.Add("各類別文章數統計圖");
			chart1.Series.Add(chartBar);
			chart1.Series[chartBar].ChartType = SeriesChartType.Bar;


			chart1.Series[chartBar].XValueType = ChartValueType.String;
			chart1.Series[chartBar].YValueType = ChartValueType.Int32;


			var x = InseparableDb.KeywordDetails.GroupBy(acd => acd.KeywordID).Where(g => g.Count() > 0);
			int[] xarr = { };
			foreach (var item in x)
			{
				Array.Resize(ref xarr, xarr.Length + 1);
				xarr[xarr.Length - 1] = item.Key;
			}
			String[] AllX = { };
			foreach (var item in xarr)
			{
				var Name = InseparableDb.Keywords.First(ac => ac.KeywordID == item).KeywordName;
				Array.Resize(ref AllX, AllX.Length + 1);
				AllX[AllX.Length - 1] = Name;
			}

			var y = InseparableDb.KeywordDetails.GroupBy(acd => acd.KeywordID);
			int[] CloumnY = { };
			foreach (var item in y)
			{
				Array.Resize(ref CloumnY, CloumnY.Length + 1);
				CloumnY[CloumnY.Length - 1] = item.Count();
			}
			chart1.Series[chartBar].Points.DataBindXY(AllX, CloumnY);
			chart1.Series[chartBar].ToolTip = "#VAL";


		}
		public void ChartLine()
		{
			chart1.Titles.Add("各類別文章數統計圖");
			chart1.Series.Add(chartLine);
			chart1.Series[chartLine].ChartType = SeriesChartType.Line;


			chart1.Series[chartLine].XValueType = ChartValueType.String;
			chart1.Series[chartLine].YValueType = ChartValueType.Int32;


			var x = InseparableDb.KeywordDetails.GroupBy(acd => acd.KeywordID).Where(g => g.Count() > 0);
			int[] xarr = { };
			foreach (var item in x)
			{
				Array.Resize(ref xarr, xarr.Length + 1);
				xarr[xarr.Length - 1] = item.Key;
			}
			String[] AllX = { };
			foreach (var item in xarr)
			{
				var Name = InseparableDb.Keywords.First(ac => ac.KeywordID == item).KeywordName;
				Array.Resize(ref AllX, AllX.Length + 1);
				AllX[AllX.Length - 1] = Name;
			}

			var y = InseparableDb.KeywordDetails.GroupBy(acd => acd.KeywordID);
			int[] CloumnY = { };
			foreach (var item in y)
			{
				Array.Resize(ref CloumnY, CloumnY.Length + 1);
				CloumnY[CloumnY.Length - 1] = item.Count();
			}
			chart1.Series[chartLine].Points.DataBindXY(AllX, CloumnY);
			chart1.Series[chartLine].ToolTip = "#VAL";


		}

		private void buttonColumn_Click(object sender, EventArgs e)
		{
			chart1.Titles.Clear();
			chart1.Series.Clear();

			ChartColumn();
		}

		private void buttonPie_Click(object sender, EventArgs e)
		{
			chart1.Titles.Clear();
			chart1.Series.Clear();

			ChartPie();
		}

		private void buttonBar_Click(object sender, EventArgs e)
		{
			chart1.Titles.Clear();
			chart1.Series.Clear();

			ChartBar();
		}

		private void buttomLine_Click(object sender, EventArgs e)
		{
			chart1.Titles.Clear();
			chart1.Series.Clear();

			ChartLine();
		}
	}
}
