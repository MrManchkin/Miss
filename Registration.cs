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
    public partial class Registration : Form
    {
        OleDbConnection Connection = new OleDbConnection();
        OleDbCommand Command = new OleDbCommand();
        OleDbDataAdapter Adapter = new OleDbDataAdapter();
        public Registration()
        {
            InitializeComponent();
            Connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Manch\Desktop\LogReg\Miss\BD\Login.mdb";
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login lg = new Login();
            lg.Show();
        }

        private void EnterBT_Click(object sender, EventArgs e)
        {
            if (LoginTB.Text == "" && PasswordTB.Text == "" && RepeatPasswordTB.Text=="")
            {
                MessageBox.Show("Empte Username or Password");
            }
            else if (PasswordTB.Text == RepeatPasswordTB.Text)
            {
                Connection.Open();
                string register = "INSERT INTO Users (w_login, w_password) VALUES ('" + LoginTB.Text + "', '" + PasswordTB.Text + "')";
                Command = new OleDbCommand(register, Connection);
                Command.ExecuteNonQuery();
                Connection.Close();

                MessageBox.Show("Your Account has been succefully created");
                Login lg = new Login();
                lg.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Password does not match, Please Re-enter");
                PasswordTB.Text = "";
                RepeatPasswordTB.Text = "";
                PasswordTB.Focus();
            }
        }

        private void LoginTB_MouseEnter(object sender, EventArgs e)
        {
            LoginTB.Focus();
            if (LoginTB.Text == "Name")
            {
                LoginTB.Text = "";
                return;
            }
        }

        private void PasswordTB_MouseEnter(object sender, EventArgs e)
        {
            PasswordTB.Focus();
            if (PasswordTB.Text == "Password")
            {
                PasswordTB.Text = "";
                return;
            }
        }

        private void RepeatPasswordTB_MouseEnter(object sender, EventArgs e)
        {
            RepeatPasswordTB.Focus();
            if (RepeatPasswordTB.Text == "Repeat Password")
            {
                RepeatPasswordTB.Text = "";
                return;
            }
        }

        private void LoginTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
