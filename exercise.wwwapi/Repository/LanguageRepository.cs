using System.Reflection.Emit;
using exercise.wwwapi.Data;
using exercise.wwwapi.Models;

namespace exercise.wwwapi.Repository
{
    public class LanguageRepository : IRepository<Language>
    {
        public Language Add(Language entity)
        {
            LanguageCollection.Add(entity);
            
            return entity;
        }

        public Language Delete(string name)
        {
            Language entity = LanguageCollection.languages.Find(x => x.name.Equals(name));

            LanguageCollection.Remove(entity);

            return entity;
        }

        public IEnumerable<Language> GetAll()
        {
            return LanguageCollection.GetAll();
        }

        public Language GetByName(string name)
        {
            Language entity = LanguageCollection.languages.Find(x => x.name.Equals(name));

            return entity;
        }

        public Language Update(string name, string update)
        {
            Language entity = LanguageCollection.languages.Find(x => x.name.Equals(name));

            entity.name = update;

            return entity;
        }
    }
}
