using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.Inseparable.Win
{
	public partial class FormMaintainer : Form
	{
        private readonly bool isMdi = false;

        public FormMaintainer(bool isMdi)
		{
			InitializeComponent();
			IsMdiContainer = true;
        }

		private void buttonArticles_Click(object sender, EventArgs e)
		{
			FormArticles formArticles = new FormArticles();
			formArticles.MdiParent = this;
			this.splitContainer2.Panel2.Controls.Clear();
			this.splitContainer2.Panel2.Controls.Add(formArticles);
			formArticles.Show();
		}

		private void buttonComments_Click(object sender, EventArgs e)
		{
			FormComments formComments = new FormComments();
			formComments.MdiParent = this;
			this.splitContainer2.Panel2.Controls.Clear();
			this.splitContainer2.Panel2.Controls.Add(formComments);
			formComments.Show();
		}

		private void buttonKeywords_Click(object sender, EventArgs e)
		{
			FormKeywords formKeywords = new FormKeywords();
			formKeywords.MdiParent = this;
			this.splitContainer2.Panel2.Controls.Clear();
			this.splitContainer2.Panel2.Controls.Add(formKeywords);
			formKeywords.Show();
		}

		private void buttonMembers_Click(object sender, EventArgs e)
		{
			FormMembers formMembers = new FormMembers();
			formMembers.MdiParent = this;
			this.splitContainer2.Panel2.Controls.Clear();
			this.splitContainer2.Panel2.Controls.Add(formMembers);
			formMembers.Show();
		}

		private void buttonOrders_Click(object sender, EventArgs e)
		{
			FormOrders formOrders = new FormOrders();
			formOrders.MdiParent = this;
			this.splitContainer2.Panel2.Controls.Clear();
			this.splitContainer2.Panel2.Controls.Add(formOrders);
			formOrders.Show();
		}

		private void buttonOrderRepos_Click(object sender, EventArgs e)
		{
			FormOrderRepos formOrderRepos = new FormOrderRepos();
			formOrderRepos.MdiParent = this;
			this.splitContainer2.Panel2.Controls.Clear();
			this.splitContainer2.Panel2.Controls.Add(formOrderRepos);
			formOrderRepos.Show();
		}

		private void buttonRooms_Click(object sender, EventArgs e)
		{
			FormRooms formRooms = new FormRooms();
			formRooms.MdiParent = this;
			this.splitContainer2.Panel2.Controls.Clear();
			this.splitContainer2.Panel2.Controls.Add(formRooms);
			formRooms.Show();
		}

		private void buttonProducts_Click(object sender, EventArgs e)
		{
			FormProducts formProducts = new FormProducts();
			formProducts.MdiParent = this;
			this.splitContainer2.Panel2.Controls.Clear();
			this.splitContainer2.Panel2.Controls.Add(formProducts);
			formProducts.Show();
		}

		private void buttonSessions_Click(object sender, EventArgs e)
		{
			FormSessions formSessions = new FormSessions();
			formSessions.MdiParent = this;
			this.splitContainer2.Panel2.Controls.Clear();
			this.splitContainer2.Panel2.Controls.Add(formSessions);
			formSessions.Show();
		}

		private void buttonActivities_Click(object sender, EventArgs e)
		{
			FormActivities formActivities = new FormActivities();
			formActivities.MdiParent = this;
			this.splitContainer2.Panel2.Controls.Clear();
			this.splitContainer2.Panel2.Controls.Add(formActivities);
			formActivities.Show();
		}

		private void buttonMovies_Click(object sender, EventArgs e)
		{
			FormMovies formMovies = new FormMovies();
			formMovies.MdiParent = this;
			this.splitContainer2.Panel2.Controls.Clear();
			this.splitContainer2.Panel2.Controls.Add(formMovies);
			formMovies.Show();
		}

		private void buttonCinemas_Click(object sender, EventArgs e)
		{
			FormCinemas formCinemas = new FormCinemas();
			formCinemas.MdiParent = this;
			this.splitContainer2.Panel2.Controls.Clear();
			this.splitContainer2.Panel2.Controls.Add(formCinemas);
			formCinemas.Show();
		}

        private void FormMaintainer_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}
