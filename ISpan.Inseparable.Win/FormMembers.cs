using ISpan.Inseparable.BLL.Interface;
using ISpan.Inseparable.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.Inseparable.Win
{


    public partial class FormMembers : Form, IGridContainer
    {
        InseparableEntities InseparableDb = new InseparableEntities();
        private MemberRepository repo;


        public string memberID
        {
            get
            {
                string memberID = int.TryParse(textBoxMemberID.Text, out int id)
                    ? id.ToString() : string.Empty;

                textBoxMemberID.Text = memberID;
                return memberID;
            }
            
        }
        public string lastName => textBoxLastName.Text;
        public string firstName => textBoxFirstName.Text;

        public FormMembers()
        {
            InitializeComponent();

            repo = new MemberRepository();
            this.Load += FormMembers_Load;
        }

        private void FormMembers_Load(object sender, EventArgs e)
        {
            Display();
        }

        /// <summary>
        /// 顯示紀錄
        /// </summary>
        public void Display()
        {
            var qMember = repo.Search(memberID, lastName, firstName).OrderByDescending(mb => mb.MemberID)
                .Select(mb => new
                {
                    會員ID = mb.MemberID,
                    姓氏 = mb.LastName,
                    名字 = mb.FirstName,
                    Email = mb.Email,
                    性別 = mb.Gender.GenderType,
                    //手機 = mb.CellPhone,
                    //生日 = mb.DateOfBirth,
                    //住址 = mb.Address
                });

            dataGridViewMember.DataSource = qMember.ToList();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewMember.RowCount > 0)
            {
                int memberId = (int)dataGridViewMember.CurrentRow.Cells[0].Value;

                var frm = new FormEditMember(memberId);
                frm.Owner = this;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("請選擇欲編輯之會員！");
            }

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var frm = new FormAddMember();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void dataGridViewMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int memberId = (int)dataGridViewMember.CurrentRow.Cells[0].Value;

            repo = new MemberRepository();
            var get = repo.GetMember(memberId);

            foreach (var item in get)
            {
                labelMemberID.Text = item.MemberID.ToString();
                labelLastName.Text = item.LastName;
                labelFirstName.Text = item.FirstName;
                labelGender.Text = item.Gender.GenderType;
                labelDateOfBirth.Text = item.DateOfBirth.ToString();
                labelEmail.Text = item.Email;
                labelPassword.Text = item.Password;
                labelCellPhone.Text = item.CellPhone.ToString();
                labelAddress.Text = item.Address;
                pictureBoxMemberPhoto.Image = null;
                if (item.PhotoImageType != null)
                {
                    MemoryStream myStream = new MemoryStream(item.PhotoImageType);
                    pictureBoxMemberPhoto.Image = Image.FromStream(myStream);
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxLastName.Text = string.Empty;
            textBoxFirstName.Text = string.Empty;
            textBoxMemberID.Text = string.Empty;
        }
    }
}
