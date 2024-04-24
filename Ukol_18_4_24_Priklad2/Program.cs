using System;

namespace Ukol_18_4_24_Priklad2
{
    //Napište program, který se zeptá na počet hvězdiček a potom je v cyklu zobrazí na konzoli.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte počet hvězdiček:");

            // Čtení vstupu od uživatele a převod na int
            int pocetHvezdicek = int.Parse(Console.ReadLine());
            // Cyklus pro zobrazení hvězdiček
            for (int i = 0; i < pocetHvezdicek; i++)
            {
                Console.Write("*");
            }
            // Udržení konzole otevřené po dokončení cyklu
            Console.WriteLine("\nStiskněte libovolnou klávesu pro ukončení...");
            Console.ReadKey();
        }
    }
}
