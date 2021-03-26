using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Globalization;


namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // string text = "word word, Word; Pet. Pet,Andrii ";
            // var words = new Dictionary<string, int>();
            // static Dictionary<string, int> GetWordsFrequency(string sentence)
            // {
            //     var counters = new Dictionary<string, int>();

            //     var wordPattern = new Regex(@"\w+");
            //     sentence = sentence.ToLower();

            //     foreach (Match match in wordPattern.Matches(sentence))
            //     {
                    
            //         int currentCount=0;
            //         counters.TryGetValue(match.Value, out currentCount);

            //         counters[match.Value] = ++currentCount;
                    
            //     }

            //     return counters;
            // }

            // words = GetWordsFrequency(text);

            // foreach (var word in words)
            // {
            //     Console.WriteLine(word);
            // }

            var calendar = new Calendar();

            // var calendar = new Dictionary<string, DateTime>();
            calendar.AddEmployee("Andrii Voinarovskyi", new DateTime(2000, 3, 30));
            calendar.AddEmployee("Petro Grishyn", new DateTime(1998, 7, 8));
            calendar.AddEmployee("Anton Shkliar", new DateTime(1970, 5, 5));

            calendar.ShowCalendar(2);
            
        }

        class Calendar
        {
            public static Dictionary<string, DateTime> birthdays = new Dictionary<string, DateTime>();


            public void AddEmployee(string key, DateTime value)
            {
                birthdays.Add(key, value);
            }

            public void ShowCalendar(int number)
            {
                for (int i = 0; i <= number; i++)
                {
                    DateTime currentMonth = DateTime.Now.AddMonths(i);
                    Console.WriteLine(currentMonth.ToString("MMMM yyyy"));
                    foreach (var employee in birthdays)
                    {
                        if (Convert.ToInt32(DateTime.Now.ToString("MM")) == Convert.ToInt32(employee.Value.ToString("MM")) - i)
                        {
                            int willBeYears = Convert.ToInt32(DateTime.Now.ToString("yyyy")) - Convert.ToInt32(employee.Value.ToString("yyyy"));

                            Console.WriteLine($"({employee.Value.ToString("dd")}) - {employee.Key} ({willBeYears} years)");
                        }
                        else continue;
                    }
                }
            }

        }
    }
}