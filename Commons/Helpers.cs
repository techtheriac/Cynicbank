﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Commons
{
    public static class Helpers
    {
        public static string GenerateAccountNumber()
        {
            StringBuilder accountNumber = new StringBuilder();
            Random seeder = new Random();

            for (int i = 0; i < 10; i++)
            {
                accountNumber.Append(seeder.Next(10));
            }

            return accountNumber.ToString();
        }

    }
}
