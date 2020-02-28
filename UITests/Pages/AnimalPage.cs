using System;
using Xamarin.UITest.Queries;

namespace UITests.Pages
{
    public class AnimalPage
    {

        Func<AppQuery, AppQuery> labels = x => x.Class("LabelRenderer");
        String animal;

        public AnimalPage(String animal)
        {
            this.animal = animal;
        }

        public String getDescription()
        {
            return Settings.AppContext.Query(labels)[2].Text;
        }

    }
}
