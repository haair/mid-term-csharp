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
    public partial class SearchBookForm : Form
    {
        public SearchBookForm()
        {
            InitializeComponent();
            LoadBook();
        }

        private void LoadBook()
        {
            foreach (var book in BookBUS.GetAllBook())
            {
                dataGridView1.Rows.Add(book.Id, book.Name, book.Author, book.Year);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (var book in BookBUS.books)
            {
                if (book.Name.ToLower().Contains(textBox1.Text.ToLower()))
                {
                    dataGridView1.Rows.Add(book.Id, book.Name, book.Author, book.Year);
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            string id = (string)dataGridView1.Rows[row].Cells[0].Value;
            string name = (string)dataGridView1.Rows[row].Cells[1].Value;
            string author = (string)dataGridView1.Rows[row].Cells[2].Value;
            string year = (string)dataGridView1.Rows[row].Cells[3].Value;
            UpdateBookForm updateBookForm = new(new Book(id, name, author, year));
            updateBookForm.ShowDialog();
        }
    }
}
