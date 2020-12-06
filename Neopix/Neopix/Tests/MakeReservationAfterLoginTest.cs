using System;

namespace Neopix.Tests
{
    class MakeReservationAfterLoginTest : Test
    {
        // try to make reservation after user login
        public void RunTest()
        {
            Utility.GoToDialysisPage();
            Methods.ValidLogin(LoginConfig.VALID_USERNAME, LoginConfig.VALID_PASSWORD);
            Methods.SearchClinic();
            Methods.ReserveTreatment(true);
            Methods.CancelReservation();
            Methods.LogoutAfterReservation();
            Console.WriteLine("Make reservation after login test passed!");
        }
    }
}
