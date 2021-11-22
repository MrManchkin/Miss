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
    public partial class Post : Form
    {
        OleDbConnection Connection = new OleDbConnection();
        OleDbCommand Command = new OleDbCommand();
        OleDbDataAdapter Adapter = new OleDbDataAdapter();
        public Post()
        {
            InitializeComponent();
            Connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Manch\Desktop\LogReg\Miss\BD\Post.mdb";
        }

        private void EnterBT_Click(object sender, EventArgs e)
        {
            Connection.Open();
            string Post = "INSERT INTO Posts (w_Post, w_User, w_Text) VALUES ('" + PostTB.Text + "', '" + Program.Name + "' , '" + TextTB.Text + "')";
            Command = new OleDbCommand(Post, Connection);
            Command.ExecuteNonQuery();
            Connection.Close();
            MessageBox.Show("I'm create your Post!");
        }

        private void Post_FormClosed(object sender, FormClosedEventArgs e)
        {
            PagePost pagePost = new PagePost();
            pagePost.Show();
            this.Hide();
        }

        private void TextTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
