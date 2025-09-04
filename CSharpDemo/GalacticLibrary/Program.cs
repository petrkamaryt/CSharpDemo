// See https://aka.ms/new-console-template for more information
using GalacticLibrary;

GreatGalacticLibrary library = new GreatGalacticLibrary();

// Add books
library.AddBook(new SciFiBook("Space Odyssey 3001", "Arthur C. Clarke"));
library.AddBook(new SciFiBook("Children of the Orion Nebula", "E. Rice"));
library.AddBook(new SciFiBook("Quantum Dreams of Titan", "R. Castro"));

// Check avaliable books
library.ShowAvailableBooks();

// Borrow book
var searchBook = library.FindBook("Children of the Orion Nebula");
if (searchBook != null)
{
    searchBook.Borrow();
}
else
{
    Console.WriteLine("There is no such book in the library.");
}

// Check once again
library.ShowAvailableBooks();