using ISpan.Inseparable.BLL.Interface;
using ISpan.Inseparable.SqlDataLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.Inseparable.Win
{
    public partial class FormAddMember : Form
    {
        InseparableEntities InseparableDb = new InseparableEntities();
        Members member = new Members();

        private MemberRepository repo;

        private int? genderId => comboBoxGender.SelectedIndex > 0 ? InseparableDb.Gender.First(g => g.GenderType == comboBoxGender.Text).GenderID : (int?)null;
        //private int? cellPhone => int.TryParse(textBoxCellPhone.Text, out int cellPhone) ? cellPhone : (int?)null;

        public FormAddMember()
        {
            InitializeComponent();
            repo = new MemberRepository();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddMember_Load(object sender, EventArgs e)
        {
            foreach (var item in InseparableDb.Gender) // 加入所有性別
            {
                comboBoxGender.Items.Add(item.GenderType);
            }

        }

        private void buttonAddMember_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == string.Empty || textBoxLastName.Text == string.Empty 
                || textBoxFirstName.Text == string.Empty || textBoxPassword.Text == string.Empty)
            {
                MessageBox.Show("輸入資料錯誤!!");
                return;
            }

            string memberEmail = string.Empty;

            var get = repo.GetMemberByEmail(textBoxEmail.Text);

            foreach (var item in get) // 取得Email
            {
                memberEmail = item.Email;
            }

            if (memberEmail != string.Empty) // 如果在資料庫有找到Email
            {
                memberEmail = get.First().Email;

                MessageBox.Show("該Email已註冊過！");
                return;
            }


            member.LastName = textBoxLastName.Text;
            member.FirstName = textBoxFirstName.Text;
            member.GenderID = genderId;
            member.DateOfBirth = dateTimePickerDateOfBirth.Value;
            member.Email = textBoxEmail.Text;
            member.Password = textBoxPassword.Text;
            member.CellPhone = textBoxCellPhone.Text;
            member.Address = textBoxAddress.Text;

            if ( string.IsNullOrEmpty(pathStr) == false)
            {
                member.PhotoImageType = FormEditMember.ImageTranse(pathStr);
            }
            

            try
            {
                InseparableDb.Members.Add(member);
                InseparableDb.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("新增失敗！\r\n" + ex.Message);
            }

            IGridContainer container = this.Owner as IGridContainer;
            if (container != null) container.Display();
            this.DialogResult = DialogResult.OK;
        }

        string pathStr = string.Empty;
        private void buttonOpenPhoto_Click(object sender, EventArgs e)
        {
            // todo 開啟圖片檔
            if (openFileDialogPhoto.ShowDialog() == DialogResult.OK)
            {
                pathStr = openFileDialogPhoto.FileName;
                pictureBoxMemberPhoto.Image = Image.FromFile(pathStr);
            }
        }
    }
}
