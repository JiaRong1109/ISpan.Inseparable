using ISpan.Inseparable.BLL.Interface;
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

namespace ISpan.Inseparable.Win
{
    public partial class FormAddActivity : Form
    {
        InseparableEntities InseparableDb = new InseparableEntities();
        Activities activity = new Activities();

        private int? peopleLimit => int.TryParse(textBoxPeopleLimit.Text, out int pLimit) ? pLimit : (int?)null;

        public FormAddActivity()
        {
            InitializeComponent();
            
        }

        private void buttonAddActivity_Click(object sender, EventArgs e)
        {
            activity.ActivityTitle = textBoxTitle.Text;
            activity.DateTime = dateTimePickerDateTime.Value;
            activity.PeopleLimit = (int)peopleLimit;
            activity.Description = textBoxDescription.Text;

            try
            {
                InseparableDb.Activities.Add(activity);
                InseparableDb.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("新增失敗！\r\n" + ex.Message);
            }

            IGridContainer container = this.Owner as IGridContainer;
            if (container != null) { container.Display(); }
            this.DialogResult = DialogResult.OK;
        }

        private void FormAddActivity_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
