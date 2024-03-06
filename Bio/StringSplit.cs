using System.Text.RegularExpressions;

namespace Bio
{
    internal class StringSplit
    {
        /* 
         * Tar en user input, trimmar den och splittar in till en array. Exta whitespaces tas bort.
         * Spliten görs med String.Split och som char delimiter används ett whitespace. 
         * Säkerställer även att minst 3 ord matas in.
         * Slutligen så presenteras det tredje ordet av det som använderen skrev in. 
         */

        public static void SplitTheString()
        {
            Console.Clear();
            Console.WriteLine("Type some words and lets see which was your 3rd word.");
            Console.Write("Type your words:   ");

            do
            {
                string userString = Console.ReadLine()!.Trim();

                if (!string.IsNullOrWhiteSpace(userString))
                {
                    userString = Regex.Replace(userString, @"\s+", " ");
                    string[] wordSplit = userString.Split(new char[] { ' ' });
                    int wordCount = wordSplit.Count();

                    if (wordCount > 2)
                    {
                        Console.WriteLine("\nThe third word was: " + wordSplit[2]);
                        break;
                    }
                }
                Utilities.ClearPreviousConsoleLine();
                Console.Write("Type your words:   ");
            }
            while (true);
        }
    }
}
