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
    public partial class PagePost : Form
    {
        public PagePost()
        {
            InitializeComponent();
        }

        private void PagePost_Load(object sender, EventArgs e)
        {
            label1.Text = Program.Name;
        }

        private void CreatePostTB_Click(object sender, EventArgs e)
        {
            Post post = new Post();
            post.Show();
            this.Hide();
        }

        private void ShowPostTB_Click(object sender, EventArgs e)
        {
            ShowPost show = new ShowPost();
            show.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditingPost edit = new EditingPost();
            edit.Show();
            this.Hide();
        }

        private void EditingDataBT_Click(object sender, EventArgs e)
        {
            EditingData editingData = new EditingData();
            editingData.Show();
            this.Hide();
        }
    }
}
