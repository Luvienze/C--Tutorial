using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string aTitle, string aAuthor, int aPages)//this is constructor for class
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}
