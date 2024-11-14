using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp113.GUI
{
    public partial class LMS : Form
    {
        public LMS()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBookForm updateBookForm = new UpdateBookForm();
            updateBookForm.ShowDialog();
        }

        private void searchByBookNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBookForm searchBookForm = new SearchBookForm();
            searchBookForm.ShowDialog();
        }
    }
}
