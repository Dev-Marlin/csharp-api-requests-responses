using exercise.wwwapi.Models;
using exercise.wwwapi.ViewModel;

namespace exercise.wwwapi.Repository
{
    public interface IBookRepository
    {
        public Book GetById(int id);
        public IEnumerable<Book> GetAll();
        public Book Add(Book entity);
        public Book Update(int id, BookPut bp);
        public Book Delete(int id);
    }
}
