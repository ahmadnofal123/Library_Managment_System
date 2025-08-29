using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managment_System
{
    internal class Book
    {
        private string title;
        private string author;  
   
        private bool isBorrowed { get; set; }
        
        public Book (string title, string author)
        {
            this.title = title;
            this.author = author;   
            isBorrowed = false;

        }

        public void SetTitle(string title)
        {
            this.title = title;
        }
        public string GetTitle()
        {
            return title;
        }
        public void SetAuthor(string author)
        {
            this.author = author;
        }
        public string GetAuthor()
        {
            return author;
        }

        public void Borrow()
        {
            if (!isBorrowed)
            {
                isBorrowed = true;
                Console.WriteLine(title + ": has been borrowed.");
            }
            else
            {
                Console.WriteLine(title + ": is already borrowed.");
            }
        }

        public void Return()
        {
            if (isBorrowed)
            {
                isBorrowed = false;
                Console.WriteLine(title + ": has been returned");
            }
            else
            {
                Console.WriteLine(title +": was not borrowed.");
            }
        }


    }
}
