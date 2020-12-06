using Neopix.Pages;
using OpenQA.Selenium;
using System;

namespace Neopix
{
    public class SuggestionPage : Page
    {

        public SuggestionPage() : base()
        {

        }

        public IWebDriver WebDriver => _driver;

        public IWebElement ReserveButton => WebDriver.FindElement(By.CssSelector("body > app-root > ng-component > bnm-layout > div.container.is-sidebar-above > main > div:nth-child(3) > bnm-search-result-card:nth-child(1) > bnm-paper > div.card-footer > div.action-buttons > a"));

        public IWebElement TreatmentField => WebDriver.FindElement(By.CssSelector("body > app-root > ng-component > bnm-layout > header > bnm-header-wrapper > bnm-header > bnm-header-patient > bnm-header-base > div.center-section > bnm-header-center > bnm-patient-search-bar > bnm-platform-search > div > bnm-custom-select > div.select"));

        public IWebElement TreatmentOption1 => WebDriver.FindElement(By.CssSelector("body > app-root > ng-component > bnm-layout > header > bnm-header-wrapper > bnm-header > bnm-header-patient > bnm-header-base > div.center-section > bnm-header-center > bnm-patient-search-bar > bnm-platform-search > div > bnm-custom-select > div.options > div > div.items > div:nth-child(1)"));

        public IWebElement LocationField => WebDriver.FindElement(By.CssSelector("body > app-root > ng-component > bnm-layout > header > bnm-header-wrapper > bnm-header > bnm-header-patient > bnm-header-base > div.center-section > bnm-header-center > bnm-patient-search-bar > bnm-platform-search > div > div.location > bnm-location-picker > div > input"));

        public IWebElement CheckInField => WebDriver.FindElement(By.CssSelector("body > app-root > ng-component > bnm-layout > header > bnm-header-wrapper > bnm-header > bnm-header-patient > bnm-header-base > div.center-section > bnm-header-center > bnm-patient-search-bar > bnm-platform-search > div > div.availability.ng-star-inserted > yahtee-popover-container > div > button > span"));

        public IWebElement CheckInDate => WebDriver.FindElement(By.CssSelector("body > app-root > ng-component > bnm-layout > header > bnm-header-wrapper > bnm-header > bnm-header-patient > bnm-header-base > div.center-section > bnm-header-center > bnm-patient-search-bar > bnm-platform-search > div > div.availability.ng-star-inserted > yahtee-popover-container > yahtee-popover-content > div > bnm-paper > main > bnm-date-picker > yahtee-date-range-picker > yahtee-dumb-calendar:nth-child(1) > table > tbody > tr:nth-child(6) > td:nth-child(3) > yahtee-date > div > span"));

        public IWebElement CheckOutDate => WebDriver.FindElement(By.CssSelector("body > app-root > ng-component > bnm-layout > header > bnm-header-wrapper > bnm-header > bnm-header-patient > bnm-header-base > div.center-section > bnm-header-center > bnm-patient-search-bar > bnm-platform-search > div > div.availability.ng-star-inserted > yahtee-popover-container > yahtee-popover-content > div > bnm-paper > main > bnm-date-picker > yahtee-date-range-picker > yahtee-dumb-calendar:nth-child(1) > table > tbody > tr:nth-child(6) > td:nth-child(4) > yahtee-date > div > span"));

        public IWebElement SearchButton => WebDriver.FindElement(By.CssSelector("body > app-root > ng-component > bnm-layout > header > bnm-header-wrapper > bnm-header > bnm-header-patient > bnm-header-base > div.center-section > bnm-header-center > bnm-patient-search-bar > bnm-platform-search > div > div.search > button:nth-child(1) > svg"));

        public IWebElement AccountOptionsButton => WebDriver.FindElement(By.CssSelector("body > app-root > ng-component > bnm-layout > header > bnm-header-wrapper > bnm-header > bnm-header-patient > bnm-header-base > div.right-section > bnm-header-navigation > nav > ul > li > button"));

        public IWebElement LogoutOption => WebDriver.FindElement(By.CssSelector("body > app-root > ng-component > bnm-layout > header > bnm-header-wrapper > bnm-header > bnm-header-patient > bnm-header-base > div.right-section > bnm-header-navigation > nav > ul > li > ng-component > bnm-dropdown-item:nth-child(4) > button"));

        public IWebElement Reservations => WebDriver.FindElement(By.CssSelector("body > app-root > bnm-profile-page > bnm-layout > header > bnm-header-wrapper > bnm-header > bnm-header-patient > bnm-header-base > div.right-section > bnm-header-navigation > nav > ul > li > ng-component > bnm-dropdown-item:nth-child(2) > a"));

        public IWebElement MyName => WebDriver.FindElement(By.CssSelector("body > app-root > bnm-checkout-page > bnm-layout > header > bnm-header-wrapper > bnm-header > bnm-header-patient > bnm-header-base > div.right-section > bnm-header-navigation > nav > ul > li > button > span"));

        public IWebElement CancelReservation => WebDriver.FindElement(By.CssSelector("body > app-root > bnm-profile-page > bnm-layout > div > main > bnm-reservations > bnm-layout > div > main > bnm-pending-reservations > bnm-reservations-patient > bnm-reservations-patient-card > bnm-paper > div.card-header > bnm-reservations-patient-header > div.button-wrapper.ng-star-inserted > button"));
    }
}

