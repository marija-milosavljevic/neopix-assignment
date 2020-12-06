using System;

namespace Neopix.Tests
{
    class InvalidLoginTest : Test
    {
        // Try to login user with invalid combination parameters
        public void RunTest()
        {
            Utility.GoToDialysisPage();
            Methods.InvalidLogin(LoginConfig.INVALID_USERNAME, LoginConfig.VALID_PASSWORD);
            Methods.InvalidLogin(LoginConfig.VALID_USERNAME, LoginConfig.INVALID_PASSWORD);
            Console.WriteLine("Invalid login test passed!");
        }
    }
}
