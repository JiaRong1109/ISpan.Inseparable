using ISpan.Inseparable.BLL.Interface;
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
    public partial class FormEditActivity : Form
    {
        InseparableEntities InseparableDb = new InseparableEntities();
        private ActivityRepository repo;

        private readonly int activityID;

        private int? peopleLimit => int.TryParse(textBoxPeopleLimit.Text, out int pLimit) ? pLimit : (int?)null;

        public FormEditActivity(int activityID)
        {
            InitializeComponent();
            this.activityID = activityID;
            repo = new ActivityRepository();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditActivity_Load(object sender, EventArgs e)
        {
            var get = repo.GetActivity(activityID);

            foreach (var item in get) // 將該會員資料填入各控制項
            {
                textBoxActivityID.Text = item.ActivityTitle.ToString();
                textBoxTitle.Text = item.ActivityTitle;
                dateTimePickerDateTime.Value = item.DateTime;
                textBoxPeopleLimit.Text = item.PeopleLimit.ToString();
                textBoxDescription.Text = item.Description;

            }
        }

        private void buttonEditActivity_Click(object sender, EventArgs e)
        {
            var edit = InseparableDb.Activities.Where(act => act.ActivityID == activityID);

            foreach (var item in edit)
            {
                item.ActivityTitle = textBoxTitle.Text;
                item.DateTime = dateTimePickerDateTime.Value;
                item.PeopleLimit = (int)peopleLimit;
                item.Description = textBoxDescription.Text;
            }

            try
            {
                InseparableDb.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("更新失敗！\n" + ex.Message);
            }

            IGridContainer container = this.Owner as IGridContainer;
            if (container != null) { container.Display(); }
            this.DialogResult = DialogResult.OK;
        }

        private void buttonDeleteActivity_Click(object sender, EventArgs e)
        {
            Activities delete = InseparableDb.Activities.First(act => act.ActivityID == activityID);

            try
            {
                InseparableDb.Activities.Remove(delete);
                InseparableDb.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("刪除失敗！\r\n" + ex.Message);
            }

            IGridContainer container = this.Owner as IGridContainer;
            if (container != null) container.Display();
            this.DialogResult = DialogResult.OK;
        }
    }
}
