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
    public partial class EditingData : Form
    {
        OleDbConnection Connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Manch\Desktop\LogReg\Miss\BD\Login.mdb");

        public EditingData()
        {
            InitializeComponent();
            Connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Manch\Desktop\LogReg\Miss\BD\Login.mdb";
        }

        private void ReplaceNameTB_Click(object sender, EventArgs e)
        {
            if (LastNameTB.Text == Program.Name)
            {
                
                string quary = "update Users set w_Login='" + NewNameTB.Text + "' where w_Login='" + LastNameTB.Text + "'";
                OleDbCommand Command = new OleDbCommand(quary, Connection);
                Connection.Open();
                    if (Command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Succefully!");
                    }
                    else
                    {
                        MessageBox.Show("Bad,bad,bad....");
                    }
                Connection.Close();
            }
            else
            {
                MessageBox.Show("Repeat,Please!");
                LastNameTB.Text = "";
                NewNameTB.Text = "";
                LastNameTB.Focus();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LastPassTB.Text == Program.Password)
            {
                string quary = "update Users set w_Password='" + PassTB.Text + "' where w_Password='" + LastPassTB.Text + "'";
                OleDbCommand Command = new OleDbCommand(quary, Connection);
                Connection.Open();
                if (Command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Succefully!");
                }
                else
                {
                    MessageBox.Show("Bad,bad,bad....");
                }
                Connection.Close();
            }
            else
            {
                MessageBox.Show("Repeat,Please!");
                LastPassTB.Text = "";
                PassTB.Text = "";
                RepeatPassTB.Text = "";
                LastPassTB.Focus();
            }
        }
    }
}
