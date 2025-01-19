using exercise.wwwapi.Models;

namespace exercise.wwwapi.Data
{
    public static class BookCollection
    {
        public static List<Book> books = new List<Book>(){
            new Book() { Id = 0, Title = "Lord of the rings", Author = "Tolkien", Genre = "Fantasy", NumPages = 5000},
            new Book() { Id = 1,Title = "Harry Potter", Author = "JK", Genre = "Fantasy", NumPages = 370},
            new Book() { Id = 2,Title = "Sherlock Holmes", Author = "Arthur", Genre = "Mystery", NumPages = 589}
        };

        public static Book Add(Book book)
        {
            books.Add(book);

            return book;
        }

        public static Book Remove(Book book)
        {
            books.Remove(book);

            return book;
        }

        public static List<Book> GetAll()
        {
            return books.ToList();
        }
    }
}
