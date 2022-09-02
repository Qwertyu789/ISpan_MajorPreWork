using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace MajorHW
{
    public partial class Login : Form
    {
        bool loginBlock = true;
        iSpanProjectEntities dbispan = new iSpanProjectEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {            
            var q = from ac in dbispan.MemberAccount
                    where ac.MemberAcc == tbAC.Text && ac.MemberPw ==tbPW.Text
                    select ac;
            dataGridView1.DataSource = q.ToList();
            if (q.Any())
            {
                loginBlock = false;
                acc = tbAC.Text;
                Close();
                return;
            }
            MessageBox.Show("帳號密碼不符");
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = loginBlock;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            loginBlock = false;
            Application.Exit();
        }
        public string acc
        {
            get { return tbAC.Text; }
            set { tbAC.Text = value; }
        }
    }
}
