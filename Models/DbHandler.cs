using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;
using CsvHelper;

namespace Models
{
    public static class DbHandler
    {
        private static string transactionPath { get; set; } = @"C:\Users\hp\source\repos\CynicBank\db\transactions.csv";


        public static void AddTransaction(Transaction transaction)
        {
            using(var writer = new StreamWriter(transactionPath))
            using(var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteHeader<Transaction>();
                csv.WriteRecord(transaction);
            }
        }
    }
}
