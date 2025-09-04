using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace GalacticLibrary
{
    public class GreatGalacticLibrary
    {
        public List<SciFiBook> BooksList { get; private set; } = new List<SciFiBook>();

        public void AddBook(SciFiBook book)
        {
            BooksList.Add(book);
            Console.WriteLine($"The book “{book.Title}” has been added to the archive.");
        }

        public void ShowAvailableBooks()
        {
            Console.WriteLine("\nBooks available in the galactic library:");
            foreach (var book in BooksList.Where(b => !b.IsBorrowed))
            {
                Console.WriteLine($" - {book.Title}, {book.Author}");
            }
        }

        public SciFiBook FindBook(string title)
        {
            return BooksList.FirstOrDefault(book => book.Title == title);
        }
    }
}
