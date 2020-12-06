using System;

namespace Neopix.Tests
{
    public class ValidLoginTest : Test
    {
        // try to login with valid data and logout after success
        public void RunTest()
        {
            Utility.GoToDialysisPage();
            Methods.ValidLogin(LoginConfig.VALID_USERNAME, LoginConfig.VALID_PASSWORD);
            Methods.Logout();
            Console.WriteLine("Valid login test passed!");
        }
    }
}
