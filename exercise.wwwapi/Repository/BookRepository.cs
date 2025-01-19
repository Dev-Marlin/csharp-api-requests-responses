using exercise.wwwapi.Data;
using exercise.wwwapi.Models;
using exercise.wwwapi.ViewModel;

namespace exercise.wwwapi.Repository
{
    public class BookRepository : IBookRepository
    {
        public Book Add(Book entity)
        {
            entity.Id = BookCollection.GetAll().Max(x => x.Id)+1;
            BookCollection.Add(entity);

            return entity;
        }

        public Book Delete(int id)
        {
            Book entity = BookCollection.GetAll().Find(x => x.Id == id);

            BookCollection.Remove(entity);
            return entity;
        }

        public IEnumerable<Book> GetAll()
        {
            return BookCollection.GetAll();
        }

        public Book GetById(int id)
        {
            Book entity = BookCollection.GetAll().Find(x => x.Id == id);

            return entity;
        }

        public Book Update(int id, BookPut bp)
        {
            Book b = BookCollection.GetAll().Find(x => x.Id == id);

            if(bp.Title != null)
            {
                b.Title = bp.Title;
            }
            if (bp.Genre != null)
            {
                b.Genre = bp.Genre;
            }
            if (bp.Author != null)
            {
                b.Author = bp.Author;
            }
            if (bp.NumPages != null)
            {
                b.NumPages = (int)bp.NumPages;
            }

            return b;
        }
    }
}
