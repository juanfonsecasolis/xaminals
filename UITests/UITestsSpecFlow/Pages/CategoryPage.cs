using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITestsSpecFlow.Pages
{
    public class CategoryPage : BasePage
    {
        // https://www.infoworld.com/article/2996770/how-to-work-with-delegates-in-c.html:
        // In essence, a delegate holds a reference to a method and also to the target object on which the method should be called.

        Func<AppQuery, AppQuery> searchBtn = x => x.Class("AppCompatAutoCompleteTextView");
        Func<AppQuery, AppQuery> animalItem = x => x.Class("ItemContentView");

        // Internal types or members are accessible only within files in the same assembly        // assembly: a reusable, versionable, and self-describing building block of a common language runtime application
        // def 2. An assembly is the compiled output of your code, typically a DLL, but your EXE is also an assembly. It's the smallest unit of deployment for any .NET project.

        internal AnimalPage searchAnimal(String animal)
        {
            app.ClearText(searchBtn);            app.EnterText(searchBtn, animal);
            app.WaitForElement(x => x.Text(animal));
            app.Tap(x => x.Text(animal));
            return new AnimalPage();
        }

        internal AnimalPage tapAnimal(string category, string animal)
        {
            app.Tap(x => x.Text(category));
            app.ScrollDownTo(x => x.Text(animal));
            app.Tap(x => x.Text(animal));
            return new AnimalPage();
        }

        internal void switchToCategory(String category) {
            app.Tap(x => x.Text(category));
        }

        internal int countVisibleAnimals()
        {
            return app.Query(animalItem).Length;
        }
    }
    
}
