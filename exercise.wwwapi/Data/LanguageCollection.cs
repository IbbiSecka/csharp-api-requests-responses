using exercise.wwwapi.Models;

namespace exercise.wwwapi.Data
{

    public class LanguageCollection
    {
        private static List<Language> languages = new List<Language>(){
            new Language("Java"),
            new Language("C#")
        };
        public static Language Add(Language language)
        {
            languages.Add(language);

            return language;
        }

        public static List<Language> getAll()
        {
            return languages.ToList();
        }
        public static Language  GetOneLanguage(string name)
        {

            return languages.Where(x => x.name == name).FirstOrDefault();
        }
        public static Language UpdateLanguage(string name, Language newLang)
        {
            Language  lang = languages.Where(x => x.name == name).FirstOrDefault();
            lang.name = newLang.name;
            return lang;
        }
        public static Language DeleteLanguage(string name)
        {
            Language removedLang = languages.Where(x => x.name == name).FirstOrDefault();
            languages.Remove(removedLang);
            return removedLang;
        }
    }
}
