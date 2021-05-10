using System;

namespace ConsoleApp01
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = 250; 
            var counts = new int[range]; 
            string text = "something"; 

            while (!string.IsNullOrWhiteSpace(text)) 
            {
                text = Console.ReadLine(); 
                UpdateCharCounts(text, counts);
                ShowCounts(range, counts);
            }
        }

        private static void ShowCounts(int, range, int[] counts) 
        {
            for (var i = 0; i < range; i++)
            {
                if (counts[i] == 0) continue;
                var character = (char)i;
                Console.WriteLine("\"" + character + "\" - " + counts[i]);
            }
        }

        private static void UpdateCharCounts(string text, int[] counts) 
        {
            foreach (var character in text) 
            {
                counts[(int)character]++;
            }
        }
    }
}
