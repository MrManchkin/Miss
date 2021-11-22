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
    public partial class EditingPost : Form
    {
        public EditingPost()
        {
            InitializeComponent();
        }

        private void EditingPost_FormClosed(object sender, FormClosedEventArgs e)
        {
            PagePost pagePost = new PagePost();
            pagePost.Show();
            this.Hide();
        }
    }
}
