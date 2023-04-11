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
    public partial class FormEditMember : Form
    {
        InseparableEntities InseparableDb = new InseparableEntities();
        private MemberRepository repo;

        private readonly int memberID;

        private int? genderId => comboBoxGender.SelectedIndex > 0 ? InseparableDb.Gender.First(g => g.GenderType == comboBoxGender.Text).GenderID : (int?)null;

        public FormEditMember(int memberID)
        {
            InitializeComponent();
            this.memberID = memberID;
            repo = new MemberRepository();
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditMembers_Load(object sender, EventArgs e)
        {
            var get = repo.GetMember(memberID);

            foreach (var item in InseparableDb.Gender) // 加入所有性別
            {
                comboBoxGender.Items.Add(item.GenderType);
            }

            foreach (var item in get) // 將該會員資料填入各控制項
            {
                textBoxMemberID.Text = item.MemberID.ToString();
                textBoxLastName.Text = item.LastName;
                textBoxFirstName.Text = item.FirstName;
                comboBoxGender.Text = item.Gender.GenderType;
                dateTimePickerDateOfBirth.Value = item.DateOfBirth.Value;
                textBoxEmail.Text = item.Email;
                textBoxCellPhone.Text = item.CellPhone;
                textBoxAddress.Text = item.Address;
                if (item.PhotoImageType != null)
                {
                    MemoryStream myStream = new MemoryStream(item.PhotoImageType);
                    pictureBoxMemberPhoto.Image = Image.FromStream(myStream);
                }

            }
        }

        private void buttonEditMember_Click(object sender, EventArgs e)
        {
            // 驗證欄位
            if (textBoxEmail.Text == string.Empty || textBoxLastName.Text == string.Empty
                || textBoxFirstName.Text == string.Empty) // || textBoxPassword.Text == string.Empty)
            {
                MessageBox.Show("輸入資料錯誤!!");
                return;
            }

            string memberEmail = string.Empty;
            int memberId = 0;

            var get = repo.GetMemberByEmail(textBoxEmail.Text);

            foreach (var item in get) // 取得Email
            {
                memberEmail = item.Email;
                memberId = item.MemberID;
            }

            if (memberEmail != string.Empty) // 如果在資料庫有找到Email
            {
                if (memberId != memberID)
                {
                    memberEmail = get.First().Email;

                    MessageBox.Show("該Email已註冊過！");
                    return;
                }
                
            }


            var edit = InseparableDb.Members.Where(m => m.MemberID == memberID);

            foreach (var item in edit)
            {
                item.LastName = textBoxLastName.Text;
                item.FirstName = textBoxFirstName.Text;
                item.GenderID = genderId;
                item.DateOfBirth = dateTimePickerDateOfBirth.Value;
                item.Email = textBoxEmail.Text;
                item.CellPhone = textBoxCellPhone.Text;
                item.Address = textBoxAddress.Text;
                
                if (string.IsNullOrEmpty(pathStr) == false)
                {
                    item.PhotoImageType = FormEditMember.ImageTranse(pathStr);
                }
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

        internal static byte[] ImageTranse(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] imgBytesIn = br.ReadBytes(Convert.ToInt32(fs.Length));
            return imgBytesIn;
        }

        private void buttonDeleteMember_Click(object sender, EventArgs e)
        {
            Members delete = InseparableDb.Members.First(m => m.MemberID == memberID);

            try
            {
                InseparableDb.Members.Remove(delete);
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
