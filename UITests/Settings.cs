using System;
using Xamarin.UITest;

namespace UITests
{
    public class Settings
    {
        public static IApp AppContext {
            set {
                AppContext = value;
            }
            get {
                if (AppContext == null) {
                    throw new NullReferenceException("AppContext is null");
                }
                return AppContext;
            }
            
        } 
    }
}
