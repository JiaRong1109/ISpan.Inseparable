using ISpan.Inseparable.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.Inseparable.Win
{
    public partial class FormActivities : Form
    {
        InseparableEntities InseparableDb = new InseparableEntities();
        private ActivityRepository repo;

        public string ActivityID
        {
            get
            {
                string activityID = int.TryParse(textBoxActivityID.Text, out int id)
                    ? id.ToString() : string.Empty;

                textBoxActivityID.Text = activityID;
                return activityID;
            }

        }
        public string ActivityTitle => textBoxActivityTitle.Text;
        public DateTime dateTime => dateTimePickerActivity.Value;

        public FormActivities()
        {
            InitializeComponent();
            repo = new ActivityRepository();
            this.Load += FormActivities_Load;
        }

        private void FormActivities_Load(object sender, EventArgs e)
        {
            Display();
        }

        public void Display()
        {
            // todo datetime不能查
            var qActivity = repo.Search(ActivityID, ActivityTitle) // , dateTime)
                .Select(act => new
                {
                    活動ID = act.ActivityID,
                    標題 = act.ActivityTitle,
                    //時間 = act.DateTime,
                    人數限制 = act.PeopleLimit,
                    //描述 = act.Description
                });

            dataGridViewActivity.DataSource = qActivity.ToList();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxActivityTitle.Text = string.Empty;
            dateTimePickerActivity.Text = string.Empty;
            textBoxActivityID.Text = string.Empty;
        }

        private void buttonEditActivity_Click(object sender, EventArgs e)
        {
            if (dataGridViewActivity.RowCount > 0)
            {
                int activityId = (int)dataGridViewActivity.CurrentRow.Cells[0].Value;

                var frm = new FormEditActivity(activityId);
                frm.Owner = this;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("請選擇欲編輯之活動！");
            }
        }

        private void dataGridViewActivity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int activityId = (int)dataGridViewActivity.CurrentRow.Cells[0].Value;

            repo = new ActivityRepository();
            var get = repo.GetActivity(activityId);

            foreach (var item in get)
            {
                labelActivityID.Text = item.ActivityID.ToString();
                labelActivityTitle.Text = item.ActivityTitle;
                //labelActivityDateTime.Text = item.DateTime.ToString();
                labelPeopleLimit.Text = item.PeopleLimit.ToString();
                textBoxActivityDescription.Text = item.Description;
                
            }
        }

        private void buttonAddActivity_Click(object sender, EventArgs e)
        {
            var frm = new FormAddActivity();
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
