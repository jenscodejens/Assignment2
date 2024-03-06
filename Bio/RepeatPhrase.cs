using System.Text.RegularExpressions;

namespace Bio
{
    internal class RepeatPhrase
    {

        public static void RepeatUserPhrase()
        {
            string userPhrase = string.Empty;

            Console.Clear();
            Console.Write(StandardMessages.RepeatWordsInfo);
            do
            {
                userPhrase = Console.ReadLine()!.Trim();

                if (!string.IsNullOrWhiteSpace(userPhrase))
                {
                    userPhrase = Regex.Replace(userPhrase, @"\s+", " ");
                    for (int i = 1; i < 11; i++)
                    {
                        Console.Write(i + ". " + userPhrase);
                        if (i < 10)
                        {
                            Console.Write(", ");
                        }
                    }
                    break;
                }
                Utilities.ClearPreviousConsoleLine();
                Console.Write("Type your phrase: ");
            }
            while (true);
        }
    }
}
