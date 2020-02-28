using System;
using Xamarin.UITest.Queries;

namespace UITests.Pages
{
    public class CategoryPage
    {
        // https://www.infoworld.com/article/2996770/how-to-work-with-delegates-in-c.html:
        // In essence, a delegate holds a reference to a method and also to the target object on which the method should be called.

        Func<AppQuery, AppQuery> searchBtn = x => x.Class("AppCompatAutoCompleteTextView");
        Func<AppQuery, AppQuery> animalItem = x => x.Class("ItemContentView");

        public CategoryPage()
        {
            
        }

        // Internal types or members are accessible only within files in the same assembly        // assembly: a reusable, versionable, and self-describing building block of a common language runtime application
        // def 2. An assembly is the compiled output of your code, typically a DLL, but your EXE is also an assembly. It's the smallest unit of deployment for any .NET project.

        internal AnimalPage searchAnimal(String animal)
        {
            Settings.AppContext.ClearText(searchBtn);            Settings.AppContext.EnterText(searchBtn, animal);
            Settings.AppContext.Tap(x => x.Text(animal));
            return new AnimalPage(animal);
        }

        internal AnimalPage tapAnimal(string category, string animal)
        {
            Settings.AppContext.Tap(x => x.Text(category));
            Settings.AppContext.ScrollDownTo(x => x.Text(animal));
            Settings.AppContext.Tap(x => x.Text(animal));
            return new AnimalPage(animal);
        }

        internal void switchToCategory(String category) {
            Settings.AppContext.Tap(x => x.Text(category));
        }

        internal int countVisibleAnimals()
        {
            return Settings.AppContext.Query(animalItem).Length;
        }
    }
    
}
