using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace CynicBank.Core.Implementations
{
    public static class Session
    {
        public static User LoggedInUser = null;
        public static string UserName;
    }
}
