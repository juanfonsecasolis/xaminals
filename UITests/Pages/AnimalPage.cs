using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITests.Pages
{
    public class AnimalPage : Page
    {

        Func<AppQuery, AppQuery> labels = x => x.Class("LabelRenderer");
        

        public AnimalPage(IApp app): base(app)
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
