using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticLibrary
{
    public class SciFiBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsBorrowed { get; private set; } = false;

        public SciFiBook(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void Borrow()
        {
            if (!IsBorrowed)
            {
                IsBorrowed = true;
                Console.WriteLine($"\nThe book {Title} has been borrowed to the reader.");
            }
            else
            {
                Console.WriteLine($"\nThe {Title} has already been borrowed to the reader!");
            }
        }

        public void Return()
        {
            if (IsBorrowed)
            {
                IsBorrowed = false;
                Console.WriteLine($"\nThe book {Title} has been returned to the library.");
            }
            else
            {
                Console.WriteLine($"\nThe book {Title} has already been returned to the library.");
            }
        }

        public void Info()
        {
            string bookStatus;

            if (IsBorrowed)
            {
                bookStatus = "The book has been borrowed to the reader.";
            }
            else
            {
                bookStatus = "The book has been returned to the library.";
            }
            Console.WriteLine($"{Title}, {Author} - {bookStatus}");
        }
    }
}
