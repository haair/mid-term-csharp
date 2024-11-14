using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp113.BUS;
using WinFormsApp113.DTO;

namespace WinFormsApp113.GUI
{
    public partial class UpdateBookForm : Form
    {
        public UpdateBookForm()
        {
            InitializeComponent();

        }

        public UpdateBookForm(Book book)
        {
            InitializeComponent();
            textBox1.Text = book.Id;
            textBox2.Text = book.Name;
            textBox3.Text = book.Author;
            textBox4.Text = book.Year;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string name = textBox2.Text;
            string author = textBox3.Text;
            string year = textBox4.Text;

            if (id == string.Empty || name == string.Empty || author == string.Empty || year == string.Empty)
            {
                MessageBox.Show("Cant not empty");
                return;
            }

            Book book = new(id, name, author, year);
            if (BookBUS.AddBook(book))
            {
                MessageBox.Show("Add ok");
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                textBox4.Text = string.Empty;
                return;
            }
            MessageBox.Show("Mã sách tồn tại");

        }

        private void UpdateBookForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;

            if (id != string.Empty)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want delete this book?", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (BookBUS.DeleteBook(id))
                    {
                        MessageBox.Show("Delete ok");
                        Close();
                    }
                }
            }
        }

        private void UpdateBookForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
