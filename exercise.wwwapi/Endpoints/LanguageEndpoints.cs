using exercise.wwwapi.Models;
using exercise.wwwapi.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;

namespace exercise.wwwapi.Endpoints
{
    public static class LanguageEndpoints
    {
        public static void Initialize(WebApplication app)
        {
            var language = app.MapGroup("/language");

            language.MapPost("/create/{name}", CreateLanguage);
            language.MapGet("/getbyname/{name}", GetByName);
            language.MapGet("/getall", GetAll);
            language.MapPut("/update/{name}", UpdateLanguage);
            language.MapDelete("/delete/{name}", DeleteLanguage);

        }

        // Methods for the endpoints
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateLanguage(IRepository<Language> repository, Language lang)
        {
            repository.Add(lang);
            return TypedResults.Created("Created", lang);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetByName(IRepository<Language> repository, string name)
        {
            return TypedResults.Ok(repository.GetByName(name));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAll(IRepository<Language> repository)
        {
            return TypedResults.Ok(repository.GetAll());
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateLanguage(IRepository<Language> repository, string name, string update)
        {
            return TypedResults.Created("Created",repository.Update(name, update));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteLanguage(IRepository<Language> repository, string name)
        {
            return TypedResults.Ok(repository.Delete(name));
        }
    }
}
