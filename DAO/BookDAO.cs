using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp113.DTO;

namespace WinFormsApp113.DAO
{
    internal class BookDAO
    {
        public static List<Book> GetAllBook()
        {
            string query = "SELECT * FROM BOOK";
            List<Book> books = [];
            SqlCommand cmd = new(query, Database.GetInstance());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                books.Add(new Book((string)reader[0], (string)reader[1], (string)reader[2], (string)reader[3]));
            }
            reader.Close();
            return books;
        }

        public static bool GetBookByID(string id)
        {
            string query = "SELECT * FROM BOOK WHERE BOOK_ID = @id";
            SqlCommand cmd = new(query, Database.GetInstance());
            cmd.Parameters.AddWithValue("id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                return true;
            }
            reader.Close();
            return false;
        }

        public static bool AddBook(Book book)
        {
            bool result = false;
            try
            {
                string query = "INSERT INTO BOOK (BOOK_ID, BOOKNAME, AUTHOR, PUBLICATION_YEAR) VALUES (@id, @name, @author, @year)";
                SqlCommand sqlCommand = new(query, Database.GetInstance());
                sqlCommand.Parameters.AddWithValue("@id", book.Id);
                sqlCommand.Parameters.AddWithValue("@name", book.Name);
                sqlCommand.Parameters.AddWithValue("@author", book.Author);
                sqlCommand.Parameters.AddWithValue("@year", book.Year);
                if (sqlCommand.ExecuteNonQuery() != 0)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return result;

        }

        public static bool DeleteBook(string book_id) {
            bool result = false;
            try
            {
                string query = "DELETE FROM BOOK WHERE BOOK_ID = @id";
                SqlCommand sqlCommand = new(query, Database.GetInstance());
                sqlCommand.Parameters.AddWithValue("@id", book_id);
                if (sqlCommand.ExecuteNonQuery() != 0)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return result;

        }
    }
}
