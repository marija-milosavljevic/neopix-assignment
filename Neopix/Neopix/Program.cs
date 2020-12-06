using Neopix.Tests;
using System;

namespace Neopix
{
    class Program
    {

        static void Main()
        {
            try
            {
                InvalidLoginTest invalidLoginTest = new InvalidLoginTest();
                ValidLoginTest validLoginTest = new ValidLoginTest();
                MakeReservationBeforeLoginTest makeReservationBeforeLoginTest = new MakeReservationBeforeLoginTest();
                MakeReservationAfterLoginTest makeReservationAfterLoginTest = new MakeReservationAfterLoginTest();

                invalidLoginTest.RunTest();
                validLoginTest.RunTest();
                makeReservationBeforeLoginTest.RunTest();
                makeReservationAfterLoginTest.RunTest();

                Console.WriteLine("All tests passed!");
            }
            catch (Exception exception)
            {
                Console.WriteLine("Some of tests failed!");
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Driver.driver.Quit();
            }
        }
    }
}
