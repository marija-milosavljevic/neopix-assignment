using System;
using System.Collections.Generic;
using System.Text;

namespace Neopix
{
    class Config
    {
        public static string URL = "https://bnm.neopixdev.com/dialysis";
        public static int IMPLICIT_WAIT_SECONDS = 10;
    }

    class LoginConfig
    {
        // valid data
        public static string VALID_USERNAME = "milosavljevicmarija19@gmail.com";
        public static string VALID_PASSWORD = "test1234";

        //invalid data
        public static string INVALID_USERNAME = "milosavljevicmarija";
        public static string INVALID_PASSWORD = "test";
    }

    class SearchConfig
    {
        public static string LOCATION = "Greece";
    }

}
