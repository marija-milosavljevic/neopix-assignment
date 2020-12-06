using Neopix.Pages;
using OpenQA.Selenium.Support.Extensions;
using System;

namespace Neopix
{
    public static class Methods
    {
        private static DialysisPage dialysisPage = new DialysisPage();
        private static SuggestionPage suggestionPage = new SuggestionPage();
        private static ReserveDetailsPage reserveDetailsPage = new ReserveDetailsPage();
        private static ReservationReviewPage reservationReviewPage = new ReservationReviewPage();
        private static ReservationsPage reservationsPage = new ReservationsPage();

        // login user with valid parameters
        public static void ValidLogin(string ValidUserName, string ValidPassword, bool isRedirectred = false)
        {
            try
            {
                if (!isRedirectred)
                {
                    dialysisPage.LoginOptionButton.Click();
                }

                dialysisPage.EmailAdressField.SendKeys(ValidUserName);
                dialysisPage.PasswordField.SendKeys(ValidPassword);
                dialysisPage.LoginActionButton.Click();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Failed to login!");
                Console.WriteLine(exception.Message);
            }
        }

        // try to login user with invalid parameters
        public static void InvalidLogin(string InvalidUsername, string InvalidPassword)
        {
            try
            {
                dialysisPage.LoginOptionButton.Click();
                dialysisPage.EmailAdressField.SendKeys(InvalidUsername);
                dialysisPage.PasswordField.SendKeys(InvalidPassword);
                dialysisPage.LoginActionButton.Click();
                if (!dialysisPage.WrongEmailPaswordMessage.Displayed)
                {
                    Console.WriteLine("Test with username:" + InvalidUsername + " password: " + InvalidPassword + " failed!");
                }
                dialysisPage.CloseDialogButton.Click();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Failed to invalid login!");
                Console.WriteLine(exception.Message);
            }
        }

        // search for treatment before login
        public static void SearchTreatment(string Location)
        {
            try
            {
                dialysisPage.Treatment.Click();
                dialysisPage.TreatmentElement1.Click();
                dialysisPage.Location.SendKeys(Location);
                dialysisPage.Clinic_checkin.Click();
                dialysisPage.WebDriver.ExecuteJavaScript("window.scrollBy(0,300)");
                dialysisPage.CheckInDate.Click();
                dialysisPage.CheckOutDate.Click();
                dialysisPage.SearchButton.Click();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Failed to search treatment!");
                Console.WriteLine(exception.Message);
            }
        }

        // make and confirm reservation with login if passed as parameter
        public static void ReserveTreatment(bool login = false)
        {
            try
            {
                suggestionPage.ReserveButton.Click();
                reserveDetailsPage.TreatmentDaysFiled.Click();
                reserveDetailsPage.DaysOption1.Click();
                reserveDetailsPage.PreferredShiftField.Click();
                reserveDetailsPage.ShiftOption1.Click();
                reserveDetailsPage.ReserveButton.Click();
                if (!login)
                {
                    Methods.ValidLogin(LoginConfig.VALID_USERNAME, LoginConfig.VALID_PASSWORD, true);
                }
                reservationReviewPage.WebDriver.ExecuteJavaScript("arguments[0].scrollIntoView();", reservationReviewPage.ChoosePatientField);
                reservationReviewPage.ChoosePatientField.Click();
                reservationReviewPage.PatientOption1.Click();
                reservationReviewPage.WebDriver.ExecuteJavaScript("arguments[0].scrollIntoView();", reservationReviewPage.ConfirmButton);
                reservationReviewPage.ConfirmButton.Click();
                reservationReviewPage.GoToReservationsButton.Click();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Failed to reserve treatment!");
                Console.WriteLine(exception.Message);
            }
        }

        // search for treatment after login
        public static void SearchClinic()
        {
            try
            {
                suggestionPage.TreatmentField.Click();
                suggestionPage.TreatmentOption1.Click();
                suggestionPage.LocationField.SendKeys(SearchConfig.LOCATION);
                suggestionPage.CheckInField.Click();
                suggestionPage.CheckInDate.Click();
                suggestionPage.CheckOutDate.Click();
                suggestionPage.SearchButton.Click();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Failed to search clinic!");
                Console.WriteLine(exception.Message);
            }
        }

        // cancel reservation
        public static void CancelReservation()
        {
            try
            {
                reservationsPage.CancelReservationButton.Click();
                reservationsPage.CancelReservationActionButton.Click();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Failed to cancel reservation!");
                Console.WriteLine(exception.Message);
            }
        }

        // logout user after login
        public static void Logout()
        {
            try
            {
                suggestionPage.AccountOptionsButton.Click();
                suggestionPage.LogoutOption.Click();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Failed to logut!");
                Console.WriteLine(exception.Message);
            }
        }

        // logut user after confirmed reservation
        public static void LogoutAfterReservation()
        {
            try
            {
                reservationsPage.AccountOptionsButton.Click();
                reservationsPage.LogoutOption.Click();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Failed to logut after reservation!");
                Console.WriteLine(exception.Message);
            }
        }
    }
}
