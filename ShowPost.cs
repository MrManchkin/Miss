using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miss
{
    public partial class ShowPost : Form
    {
        public ShowPost()
        {
            InitializeComponent();
        }

        private void ShowPost_FormClosed(object sender, FormClosedEventArgs e)
        {
            PagePost pagePost = new PagePost();
            pagePost.Show();
            this.Hide();
        }

        private void ShowPost_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
