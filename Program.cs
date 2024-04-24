// See https://aka.ms/new-console-template for more information
using ORM_Migrations_Task.DAL;
using ORM_Migrations_Task.Models;

Console.WriteLine("Hello, World!");
GetAllBooks();

void AddBook()
{
    List<Book> books = new()
    {
        new(){Name="Book1"},
        new(){Name="Book2"},
        new(){Name="Book3"},
    };
    using var dataContext = new AppDbContext();
    dataContext.Books.AddRange(books);
    dataContext.SaveChanges();

}

void AddGenre()
{
    List<Genre> genres = new()
    {
        new(){Name="Fiction"},
        new(){Name="Dram"},
        new(){Name="Romantic"},
    };
    using var dataContext = new AppDbContext();
    dataContext.Genres.AddRange(genres);
    dataContext.SaveChanges();


}
void AddBookGenre()
{
    List<BookGenre> bookgenre = new()
    {
        new(){BookId=1, GenreId=1},
        new(){BookId=1, GenreId=2},
        new(){BookId=2,GenreId=1},
    };
    using var dataContext = new AppDbContext();
    dataContext.BookGenres.AddRange(bookgenre);
    dataContext.SaveChanges();


}
void GetAllBooks()
{
    using var datacontext= new AppDbContext();
   var books=  datacontext.Books.ToList();
    foreach (var book in books)
    {
        Console.WriteLine(book.Name);
    }
}
void GetBookById(int id)
{
    using var dataContext = new AppDbContext();
    var book = dataContext.Books.First();
    Console.WriteLine(book.Name);
}