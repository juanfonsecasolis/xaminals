using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITestsSpecFlow.Pages
{
    public class AnimalPage : BasePage
    {

        Func<AppQuery, AppQuery> labels = x => x.Class("LabelRenderer");
        

        public AnimalPage()
        {
        }

        public String getDescription()
        {
            return app.Query(labels)[2].Text;
        }

        internal String getHeader()
        {
            return app.Query(labels)[0].Text;
        }
    }
}
