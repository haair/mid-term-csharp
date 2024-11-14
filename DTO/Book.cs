using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp113.DTO
{
    public class Book
    {
        private string id;
        private string name;
        private string author;
        private string year;

        public Book(string id, string name, string author, string year)
        {
            this.Id = id;
            this.Name = name;
            this.Author = author;
            this.Year = year;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Author { get => author; set => author = value; }
        public string Year { get => year; set => year = value; }
    }
}
