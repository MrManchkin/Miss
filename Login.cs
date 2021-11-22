using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Miss
{
    public partial class Login : Form
    {
        OleDbConnection Connection = new OleDbConnection();
        public Login()
        {
            InitializeComponent();
            Connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Manch\Desktop\LogReg\Miss\BD\Login.mdb";
        }

        private void EnterBT_Click(object sender, EventArgs e)
        {
            Connection.Open();
            OleDbCommand Command = new OleDbCommand();
            Command.Connection = Connection;
            Command.CommandText = "select * from Users where w_Login='" + LoginTB.Text+ "' and w_Password='" + PasswordTB.Text+"'";
            OleDbDataReader reader = Command.ExecuteReader();

            PagePost pp = new PagePost();

            int count = 0;
            while (reader.Read())
            {
                count += 1;
            }


            if (count==1)
            {
                Program.Name = LoginTB.Text;
                Program.Password = PasswordTB.Text;
                MessageBox.Show("Correct");
                pp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect");
            }

            Connection.Close();
        }
        private void RegBT_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            this.Hide();
            reg.Show();
        }

        private void LoginTB_MouseEnter(object sender, EventArgs e)
        {
            LoginTB.Focus();
            if (LoginTB.Text == "Vanya")
            {
                LoginTB.Text = "";
                return;
            }
        }

        private void PasswordTB_MouseEnter(object sender, EventArgs e)
        {
            PasswordTB.Focus();
            if (PasswordTB.Text == "12345")
            {
                PasswordTB.Text = "";
                return;
            }
        }
    }
}
