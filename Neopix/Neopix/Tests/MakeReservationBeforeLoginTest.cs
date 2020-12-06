using System;
using System.Collections.Generic;
using System.Text;

namespace Neopix.Tests
{
    class MakeReservationBeforeLoginTest : Test
    {
        // try to make reservation before user login
        public void RunTest()
        {
            Utility.GoToDialysisPage();
            Methods.SearchTreatment(SearchConfig.LOCATION);
            Methods.ReserveTreatment();
            Methods.CancelReservation();
            Methods.LogoutAfterReservation();
            Console.WriteLine("Make reservation before login test passed!");
        }
    }
}
