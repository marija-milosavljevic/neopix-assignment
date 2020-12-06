using Neopix.Pages;
using OpenQA.Selenium;
using System;

namespace Neopix
{
    public class DialysisPage : Page
    {
        public DialysisPage() : base()
        {

        }

        public IWebDriver WebDriver => _driver;

        public IWebElement LoginOptionButton => WebDriver.FindElement(By.CssSelector("body > app-root > ng-component > section.cover > bnm-header > bnm-header-public > bnm-header-base > div.right-section > bnm-header-navigation > nav > ul > li:nth-child(4) > a"));

        public IWebElement EmailAdressField => WebDriver.FindElement(By.Name("username"));

        public IWebElement PasswordField => WebDriver.FindElement(By.CssSelector("body > app-root > ng-component > bnm-login > bnm-modal > bnm-blackout > bnm-paper > form > div:nth-child(2) > label > bnm-password > bnm-padded-input > input"));

        public IWebElement LoginActionButton => WebDriver.FindElement(By.CssSelector("body > app-root > ng-component > bnm-login > bnm-modal > bnm-blackout > bnm-paper > form > button > div "));

        public IWebElement WrongEmailPaswordMessage => WebDriver.FindElement(By.CssSelector("body > app-root > ng-component > bnm-login > bnm-modal > bnm-blackout > bnm-paper > form > bnm-validation"));

        public IWebElement Treatment => WebDriver.FindElement(By.CssSelector("body > app-root > ng-component > section.cover > div > bnm-platform-search > div > bnm-custom-select > div.select > span"));

        public IWebElement TreatmentElement1 => WebDriver.FindElement(By.CssSelector("body > app-root > ng-component > section.cover > div > bnm-platform-search > div > bnm-custom-select > div.options > div > div.items > div:nth-child(1)"));

        public IWebElement TreatmentElement2 => WebDriver.FindElement(By.CssSelector("body > app-root > ng-component > section.cover > div > bnm-platform-search > div > bnm-custom-select > div.options > div > div.items > div:nth-child(2)"));

        public IWebElement Location => WebDriver.FindElement(By.CssSelector("body > app-root > ng-component > section.cover > div > bnm-platform-search > div > div.location > bnm-location-picker > div > input"));

        public IWebElement Clinic_checkin => WebDriver.FindElement(By.CssSelector("body > app-root > ng-component > section.cover > div > bnm-platform-search > div > div.availability.ng-star-inserted > yahtee-popover-container > div > button"));

        public IWebElement SearchButton => WebDriver.FindElement(By.CssSelector("body > app-root > ng-component > section.cover > div > bnm-platform-search > div > div.search.search-large > button:nth-child(1)"));

        public IWebElement CheckInDate => WebDriver.FindElement(By.CssSelector("body > app-root > ng-component > section.cover > div > bnm-platform-search > div > div.availability.ng-star-inserted > yahtee-popover-container > yahtee-popover-content > div > bnm-paper > main > bnm-date-picker > yahtee-date-range-picker > yahtee-dumb-calendar:nth-child(1) > table > tbody > tr:nth-child(6) > td:nth-child(3) > yahtee-date > div > span"));

        public IWebElement CheckOutDate => WebDriver.FindElement(By.CssSelector("body > app-root > ng-component > section.cover > div > bnm-platform-search > div > div.availability.ng-star-inserted > yahtee-popover-container > yahtee-popover-content > div > bnm-paper > main > bnm-date-picker > yahtee-date-range-picker > yahtee-dumb-calendar:nth-child(1) > table > tbody > tr:nth-child(6) > td:nth-child(4) > yahtee-date > div > span"));

        public IWebElement CloseDialogButton => WebDriver.FindElement(By.CssSelector("body > app-root > ng-component > bnm-login > bnm-modal > bnm-blackout > bnm-paper > a"));
    }
}
