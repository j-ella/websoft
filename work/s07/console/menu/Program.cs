using System;

using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ConsoleTables;

namespace menu
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {   
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) View account");
            Console.WriteLine("2) View account by number");
            Console.WriteLine("3) Type 'exit' to quit");
            Console.Write("\r\nSelect an option: ");

            
             var accounts = ReadAccounts();


            switch (Console.ReadLine())
            {
                case "1":
                    var table = new ConsoleTable("Number", "Owner", "Label", "Balance");

                    foreach (var account in accounts){
                    table.AddRow(account.Number, account.Owner, account.Label, account.Balance);
                    }
                    table.Write();
                    Console.WriteLine();
                    return true;
                case "2":
                    Console.Write("Enter account number: ");
                    var accountNumber = Console.ReadLine();
                    foreach (var account in accounts){
                        if(account.Number.ToString().Equals(accountNumber)){
                            table = new ConsoleTable("Number", "Owner", "Label", "Balance");
                            table.AddRow(account.Number, account.Owner, account.Label, account.Balance);
                            table.Write();
                            Console.WriteLine();
                        }
                    }
                    return true;
                case "exit":
                    Console.WriteLine("Goodbye");
                    return false;
                default:
                Console.WriteLine("Invalid");
                    return true;
            }
        }


        static IEnumerable<Account> ReadAccounts()
        {
            String file = "../data/account.json";

            using (StreamReader r = new StreamReader(file))
            {
                string data = r.ReadToEnd();

                var json = JsonSerializer.Deserialize<Account[]>(
                    data, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                );
                return json;
            }

        }

        public class Account
        {
            public int Number { get; set; }
            public int Balance { get; set; }
            public string Label { get; set; }
            public int Owner { get; set; }

            public override string ToString()
            {
                return JsonSerializer.Serialize<Account>(this);
            }
        }
    }
}
