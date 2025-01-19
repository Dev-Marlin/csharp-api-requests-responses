using exercise.wwwapi.Models;
using exercise.wwwapi.Repository;
using exercise.wwwapi.ViewModel;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;

namespace exercise.wwwapi.Endpoints
{
    public static class BookEndpoints
    {
        public static void Initialize(WebApplication app)
        {
            var book = app.MapGroup("/book");

            book.MapGet("/getall", GetAll);
            book.MapGet("/getbyid/{id}", GetById);
            book.MapPut("/update/{id}", UpdateBook);
            book.MapPost("/create", CreateBook);
            book.MapDelete("/delete/{id}", DeleteBook);
        }

        // Methods for the endpoints
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateBook(IBookRepository repository, Book book)
        {
            repository.Add(book);
            return TypedResults.Created("Created", book);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetById(IBookRepository repository, int id)
        {
            Book entity = repository.GetById(id);
            return TypedResults.Ok(entity);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAll(IBookRepository repository)
        {
            return TypedResults.Ok(repository.GetAll());
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateBook(IBookRepository repository, BookPut bp, int id)
        {
            Book book = repository.Update(id, bp);
            return TypedResults.Created("Created", book);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteBook(IBookRepository repository, int id)
        {
            Book entity = repository.Delete(id);
            return TypedResults.Ok(entity);
        }
    }
}
