using System;
using System.Text.RegularExpressions;

namespace Commons
{
    public static class Validate
    {

        enum Valid
        {
            Valid,
            Invalid
        }

        public static int SafeParseInt(string x)
        {
            if (Int32.TryParse(x, out int j))
            {
                return j;
            }
            else
            {
                Console.WriteLine("Your Input is Invalid");
                return -1;
            }
        }

        public static bool IsValidAmount(string x)
        {
            return (SafeParseInt(x) != -1 && SafeParseInt(x) >= 0);
        }

        public static bool IsValidAcount(int x)
        {
            return x == 1 || x == 2;
        }
        public static bool IsValidAction(string action)
        {
            return action == "login"
                 || action == "logout"
                 || action == "send"
                 || action == "deposit"
                 || action == "withdraw"
                 || action == "statement"
                 || action == "signup"
                 || action == "balance"
                 || action == "create";
        }

        public static bool IsValidEmail(string email)
        {
            string pattern = @"\b[\w\.-]+@[\w\.-]+\.\w{2,4}\b";
            Regex CodeRgx = new Regex(pattern, RegexOptions.IgnoreCase);
            return CodeRgx.IsMatch(email);
        }

        public static bool IsValidName(string name)
        {
            string pattern = @"(^[a-zA-Z]+$)";

            Regex CodeRgx = new Regex(pattern, RegexOptions.IgnoreCase);
            return CodeRgx.IsMatch(name);
        }

        /// <summary>
        /// Methods prefixed with 'Parse' make relevant success/error
        /// messages based on validity of user input
        /// </summary>
        private static string ParseName(Valid message) =>
        message switch
        {
            Valid.Valid => "Added Successfully",
            Valid.Invalid => "You have entered an invalid string. Please try again",
            _ => throw new ArgumentOutOfRangeException()
        };

        private static string ParseEmail(Valid message) =>
        message switch
        {
            Valid.Valid => "Added Successfully",
            Valid.Invalid => "You have entered an invalid emial. Please try again",
            _ => throw new ArgumentOutOfRangeException()
        };

        private static string ParseAction(Valid message) =>
        message switch
        {
            Valid.Valid => "Successful",
            Valid.Invalid => "You have made an invalid selection. Please try again",
            _ => throw new ArgumentOutOfRangeException()
        };

        /// <summary>
        /// Method corresponding to Input fields run validation
        /// on respective fields.
        /// Left of tuple is Valid or Empty field
        /// Right of tuple is Success or Error message
        /// </summary>
        public static Tuple<string, string> Name(string name)
        {
            if (!IsValidName(name))
            {
                return Tuple.Create(String.Empty, ParseName(Valid.Invalid));
            }

            return Tuple.Create(name, ParseName(Valid.Valid));
        }


        public static Tuple<string, string> Email(string email)
        {
            if (!IsValidEmail(email))
            {
                return Tuple.Create(String.Empty, ParseEmail(Valid.Invalid));
            }

            return Tuple.Create(email, ParseEmail(Valid.Valid));
        }

        public static Tuple<string, string> Action(string action)
        {
            if (!IsValidAction(action))
            {
                return Tuple.Create(String.Empty, ParseAction(Valid.Invalid));
            }

            return Tuple.Create(action, ParseAction(Valid.Valid));
        }

    }
}
