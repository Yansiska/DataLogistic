using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LogisticData
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtUser.Text.Length == 0) || (txtPassword.Text.Length == 0))
            {
                MessageBox.Show("Username and Password Cannot be Empty");
            }
            else
            {
                FileStream fs = new FileStream("LoginAdmin.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string[] file = File.ReadAllLines("LoginAdmin.txt");
                foreach (string dataLogin in file)
                {
                    var ArrLog = dataLogin.Split('~');
                    if ((ArrLog[0].Contains(txtUser.Text)) && (ArrLog[1].Contains(txtPassword.Text)))
                    {
                        MenuLogistic frm = new MenuLogistic();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username or Password invalid !");
                    }
                }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbPassword_Click(object sender, EventArgs e)
        {

        }

        private void lbUser_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
