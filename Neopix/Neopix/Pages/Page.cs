using OpenQA.Selenium;
using System;

namespace Neopix.Pages
{
    public class Page
    {
        protected IWebDriver _driver;

        // set driver attribute
        protected Page()
        {
            _driver = Driver.driver;
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Config.IMPLICIT_WAIT_SECONDS);
        }
    }
}
