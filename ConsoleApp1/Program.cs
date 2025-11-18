namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Zadanie 1
            int[] Z1_TablicaLiczb = [5, 10, 15, 20, 25];
            int Z1_SumaLiczb = 0;
            int Z1_LiczbaSum = 0;

            Console.WriteLine("Tablica liczb dla zadania 1: 5, 10, 15, 20, 25");

            foreach (int Z1_LiczbaCalkowita in Z1_TablicaLiczb)
            {
                Z1_LiczbaSum++;
                Z1_SumaLiczb += Z1_LiczbaCalkowita;
                Console.WriteLine("Suma numer " + Z1_LiczbaSum + ": " + Z1_SumaLiczb);
            }
            Console.WriteLine("");
            Console.WriteLine("Ostateczna suma: " + Z1_SumaLiczb);

            // Zadanie 2

            int[] Z2_TablicaLiczb = [20, 15, 10, 25, 5];
            int Z2_LCMin = 0;
            int Z2_LCMax = 0;

            Z2_LCMin = Z2_TablicaLiczb.Min();
            Z2_LCMax = Z2_TablicaLiczb.Max();
            Console.WriteLine("Tablica liczb dla zadania 2: 20, 15, 10, 25, 5");
            Console.WriteLine("Najmniejsza liczba w tablicy: " + Z2_LCMin);
            Console.WriteLine("Największa liczba w tablicy: " + Z2_LCMax);

            // Zadanie 3

            string[] Z3_LosoweImiona = ["Tymek", "Lesław", "Ignacy", "Daniil", "Romuald"];

            for (int i = Z3_LosoweImiona.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("Imiona od końca do początku: " + Z3_LosoweImiona[i]);
            }
        }
    }
}
