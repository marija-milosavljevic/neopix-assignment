using System;
using System.Collections.Generic;
using System.Text;

namespace Neopix
{
    public class Utility
    {
        // go to start point and maximize window
        public static void GoToDialysisPage()
        {
            Driver.driver.Navigate().GoToUrl(Config.URL);
            Driver.driver.Manage().Window.Maximize();
        }
    }
}
