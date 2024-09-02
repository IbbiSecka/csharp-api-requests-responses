using exercise.wwwapi.Models;

namespace exercise.wwwapi.Repository
{
    public interface ILRepository
    {
        Language Add(Language language);
        List<Language> getAll();
        Language UpdateLanguage(string name, Language lang);
        Language DeleteLanguage(string name );
        Language GetOneLanguage(string name);
    }
}
