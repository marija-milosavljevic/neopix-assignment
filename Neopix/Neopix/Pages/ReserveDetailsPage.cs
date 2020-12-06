using OpenQA.Selenium;
using System;

namespace Neopix.Pages
{
    public class ReserveDetailsPage : Page
    {
        public ReserveDetailsPage() : base()
        {

        }

        public IWebDriver WebDriver => _driver;

        public IWebElement TreatmentDaysFiled => WebDriver.FindElement(By.Name("days"));

        public IWebElement DaysOption1 => WebDriver.FindElement(By.CssSelector("body > app-root > ng-component > bnm-layout > div > aside > bnm-single-clinic-aside > bnm-aside-widget > main > form > div:nth-child(2) > label > bnm-select > select > option:nth-child(2)"));

        public IWebElement PreferredShiftField => WebDriver.FindElement(By.Name("preferredShift"));

        public IWebElement ShiftOption1 => WebDriver.FindElement(By.CssSelector("body > app-root > ng-component > bnm-layout > div > aside > bnm-single-clinic-aside > bnm-aside-widget > main > form > div:nth-child(4) > label > bnm-select > select > option:nth-child(2)"));

        public IWebElement ReserveButton => WebDriver.FindElement(By.CssSelector("body > app-root > ng-component > bnm-layout > div > aside > bnm-single-clinic-aside > bnm-aside-widget > main > form > button > div"));

    }
}
