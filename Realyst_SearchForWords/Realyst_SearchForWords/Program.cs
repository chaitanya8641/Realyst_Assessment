
namespace Realyst_SearchForWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the full path of the text fine (.txt).");
            var lines = File.ReadAllLines(Console.ReadLine());
            Array.Sort(lines);


            string[,] Grid = new string[5, 5];
            string[] randomLetter = new string[26] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            Random rng = new Random();

            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                for (int j = 0; j < Grid.GetLength(1); j++)
                {
                    int nextRandom = rng.Next(0, 26);

                    string actualRandomLetter = randomLetter[nextRandom];

                    Grid[i, j] = actualRandomLetter;

                    Console.Write(actualRandomLetter + "\t");
                }
                Console.WriteLine();
            }
            searchWord(lines);

            Console.WriteLine("Enter \"y\" to restart the program and \"n\" to exit the Program");
            string selectedOption = Console.ReadLine();
            if (selectedOption == "y")
            {
                Main(args);
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public static void searchWord(string[] lines)
        {
            Console.WriteLine("Please Enter Search Word");
            var word = Console.ReadLine().ToLower();
            if (word.Length == 0)
            {
                Console.WriteLine("Please enter the word for search."); 
            }
            else
            {
                var IsCharRepeated = IsSortedNoRepeats(word);

                if (!IsCharRepeated)
                {
                    Console.WriteLine("You entered duplicate charcters.");
                }
                else
                {
                    var result = Array.Find(lines, element => element == word);
                    Console.WriteLine("Congrats!! You have found word.");
                }
            }
        }

        public static bool IsSortedNoRepeats(string word)
        {
            for (int i = 1; i < word.Length; i++)
            {
                if (word[i] <= word[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

    }
}
