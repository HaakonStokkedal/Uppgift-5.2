using System;

namespace Uppgift_5._2
{
    class Porgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många heltal vill du skriva in?");
            int antal = int.Parse(Console.ReadLine());
            Console.WriteLine($"Skriv in {antal} heltal. (ha ett mellanslag mellan varje tal.");
            string talenText = Console.ReadLine();
            string[] talText = talenText.Split(' ');

            for (int i = 0; i < antal; i++) 
            {
                Console.WriteLine($"Tal {i + 1}: {talText[i]}");
            }
            Console.ReadKey();
        }
    }
}