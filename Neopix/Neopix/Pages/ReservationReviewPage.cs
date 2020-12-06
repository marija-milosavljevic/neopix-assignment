using OpenQA.Selenium;
using System;

namespace Neopix.Pages
{
    public class ReservationReviewPage : Page
    {
        public ReservationReviewPage() : base()
        {

        }

        public IWebDriver WebDriver => _driver;

        public IWebElement ChoosePatientField => WebDriver.FindElement(By.Name("patientId"));

        public IWebElement PatientOption1 => WebDriver.FindElement(By.CssSelector("body > app-root > bnm-checkout-page > bnm-layout > div > main > bnm-paper > form > div > div.patient-details > div.picker.ng-star-inserted > label > bnm-select > select > option:nth-child(2)"));

        public IWebElement ConfirmButton => WebDriver.FindElement(By.CssSelector("body > app-root > bnm-checkout-page > bnm-layout > div > main > bnm-paper > form > div > div.actions-wrapper.ng-star-inserted > div > button > div"));

        public IWebElement GoToReservationsButton => WebDriver.FindElement(By.CssSelector("body > app-root > bnm-checkout-page > bnm-layout > div > main > bnm-success-message > bnm-paper > div > footer > a"));
    }
}
