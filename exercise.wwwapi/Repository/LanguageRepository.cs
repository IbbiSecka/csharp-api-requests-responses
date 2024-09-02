using exercise.wwwapi.Data;
using exercise.wwwapi.Models;

namespace exercise.wwwapi.Repository
{
    public class LanguageRepository : ILRepository
    {
        public Language Add(Language language)
        {
            return LanguageCollection.Add(language);
        }

        public Language DeleteLanguage(string name)
        {
            return LanguageCollection.DeleteLanguage(name);
        }

        public List<Language> getAll()
        {
            return LanguageCollection.getAll();
        }

        public Language GetOneLanguage(string name)
        {
            return LanguageCollection.GetOneLanguage(name);
        }

        public Language UpdateLanguage(string name, Language lang)
        {
            return LanguageCollection.UpdateLanguage(name, lang);  
        }
    }
}
