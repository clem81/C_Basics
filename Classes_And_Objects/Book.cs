using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_And_Objects
{
    internal class Book
    {
        public string title;
        public string author;
        public int pages;

        //This is the constructor, the values are passed when called saving having to declare the bookX.title = ..., bookX.author = ...
        public Book(string aTitle, string aAuthor, int aPages)
        {
            // THis is setting the passed in arguments to the parameters of the class
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }

        //You can have multiple constructors with different arguments being passed
        public Book(string aTitle)
        {
            title = aTitle;
        }
        public Book()
        {

        }
    }
}
