using OpenQA.Selenium;

namespace Neopix.Pages
{
    public class ReservationsPage : Page
    {
        public ReservationsPage() : base()
        {

        }

        public IWebDriver WebDriver => _driver;

        public IWebElement CancelReservationButton => WebDriver.FindElement(By.CssSelector("body > app-root > bnm-profile-page > bnm-layout > div > main > bnm-reservations > bnm-layout > div > main > bnm-pending-reservations > bnm-reservations-patient > bnm-reservations-patient-card > bnm-paper > div.card-header > bnm-reservations-patient-header > div.button-wrapper.ng-star-inserted > button"));

        public IWebElement CancelReservationActionButton => WebDriver.FindElement(By.CssSelector("body > lrn-modal > bnm-paper > div > bnm-cancel-reservation-dialog > div > button.tertiary"));
        
        public IWebElement AccountOptionsButton => WebDriver.FindElement(By.CssSelector("body > app-root > bnm-profile-page > bnm-layout > header > bnm-header-wrapper > bnm-header > bnm-header-patient > bnm-header-base > div.right-section > bnm-header-navigation > nav > ul > li > button"));

        public IWebElement LogoutOption => WebDriver.FindElement(By.CssSelector("body > app-root > bnm-profile-page > bnm-layout > header > bnm-header-wrapper > bnm-header > bnm-header-patient > bnm-header-base > div.right-section > bnm-header-navigation > nav > ul > li > ng-component > bnm-dropdown-item:nth-child(4) > button"));

    }
}
