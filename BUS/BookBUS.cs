using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp113.DAO;
using WinFormsApp113.DTO;

namespace WinFormsApp113.BUS
{
    internal class BookBUS
    {
        public static List<Book> books = [];
        public static bool AddBook(Book book)
        {
            if (BookDAO.GetBookByID(book.Id))
            {
                return false;
            }
            return BookDAO.AddBook(book);
        }

        public static List<Book> GetAllBook()
        {
            books = BookDAO.GetAllBook();
            return books;
        }

        public static bool DeleteBook(string id)
        {
            return BookDAO.DeleteBook(id);
        }
    }
}
