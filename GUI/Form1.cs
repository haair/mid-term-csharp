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
using WinFormsApp113.DAO;
using WinFormsApp113.DTO;

namespace WinFormsApp113.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want delete this champion?", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int row = dataGridView1.CurrentCell.RowIndex;
                string champ = (string)dataGridView1.Rows[row].Cells[0].Value;

                if (row > 0)
                {
                    if (BookBUS.DeleteBook(champ))
                    {
                        //LoadChampion();
                        textBox4.Text = string.Empty;
                        MessageBox.Show("Delete ok");
                        return;
                    }
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            //foreach (var champion in BookBUS.books)
            //{
            //    if (champion.Field1.ToLower().Contains(textBox4.Text))
            //    {
            //        dataGridView1.Rows.Add(champion.Field1, champion.Field2, champion.Field3);
            //    }
            //}
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            textBox1.Text = (string)dataGridView1.Rows[row].Cells[0].Value;
            textBox2.Text = (string)dataGridView1.Rows[row].Cells[1].Value;
            textBox3.Text = (string)dataGridView1.Rows[row].Cells[2].Value;
        }
    }
}
