using exercise.wwwapi.Models;

namespace exercise.wwwapi.Data
{

    public static class LanguageCollection
    {
        public static List<Language> languages = new List<Language>(){
            new Language("Java"),
            new Language("C#")
        };

        public static Language Add(Language language)
        {
            languages.Add(language);

            return language;
        }

        public static Language Remove(Language language)
        {
            languages.Remove(language);

            return language;
        }

        public static List<Language> GetAll()
        {
            return languages.ToList();
        }
    }
}
