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
	public partial class FormLogin : Form
	{
        InseparableEntities InseparableDb = new InseparableEntities();
        private AdministratorRepository repo;

        public string inputEmail => textBoxAccount.Text != string.Empty ? textBoxAccount.Text : null;
        public string inputPassword => textBoxPassword.Text != string.Empty ? textBoxPassword.Text : null;

        public FormLogin()
		{
			InitializeComponent();
            repo = new AdministratorRepository();
		}

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // todo 驗證管理者帳密是否正確

            string adminEmail = string.Empty;

            var get = repo.GetAdministratorByEmail(inputEmail);

            foreach (var item in get) // 取得資料庫中的email
            {
                adminEmail = item.Email;
            }

            if (string.IsNullOrEmpty(adminEmail) == false) // 管理者email正確
            {
                adminEmail = get.First().Email;

                if ( get.First().Password == inputPassword) // 管理者密碼正確
                {
                    // 開啟主畫面
                    var frm = new FormMaintainer(false);
                    frm.Owner = this; // 稍後關閉時，要再度呈現 FormLogin 之用
                    frm.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("管理者密碼不正確！");
                }
            }
            else
            {
                MessageBox.Show("管理者帳號錯誤！");
            }

            

            // 開啟主畫面
            //var frm = new form(false);
            //frm.Owner = this; // 稍後關閉時，要再度呈現 FormLogin之用
            //frm.Show();

            //this.Hide();
        }
    }
}
