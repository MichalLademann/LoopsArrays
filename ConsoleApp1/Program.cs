namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Zadanie 1
            int[] Z1_TablicaLiczb = [5, 10, 15, 20, 25];
            int Z1_SumaLiczb = 0;
            int Z1_LiczbaSum = 0;

            Console.WriteLine("Tablica liczb dla zadania 1: " + string.Join(", ", Z1_TablicaLiczb));
            Console.WriteLine("");

            foreach (int Z1_LiczbaCalkowita in Z1_TablicaLiczb)
            {
                Z1_LiczbaSum++;
                Z1_SumaLiczb += Z1_LiczbaCalkowita;
                Console.WriteLine("Suma numer " + Z1_LiczbaSum + ": " + Z1_SumaLiczb);
            }
            Console.WriteLine("");
            Console.WriteLine("Ostateczna suma: " + Z1_SumaLiczb);
            Console.WriteLine("");

            // Zadanie 2

            int[] Z2_TablicaLiczb = [20, 15, 10, 25, 5];
            int Z2_LCMin = 0;
            int Z2_LCMax = 0;

            Z2_LCMin = Z2_TablicaLiczb.Min();
            Z2_LCMax = Z2_TablicaLiczb.Max();
            Console.WriteLine("Tablica liczb dla zadania 2: " + string.Join(", ", Z2_TablicaLiczb));
            Console.WriteLine("");
            Console.WriteLine("Najmniejsza liczba w tablicy: " + Z2_LCMin);
            Console.WriteLine("Największa liczba w tablicy: " + Z2_LCMax);

            // Zadanie 3

            string[] Z3_LosoweImiona = ["Tymek", "Lesław", "Ignacy", "Daniil", "Romuald"];

            Console.WriteLine("");
            Console.WriteLine("Tablica imion dla zadania 3: " + string.Join(", ", Z3_LosoweImiona));
            Console.WriteLine("");

            for (int i = Z3_LosoweImiona.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("Imiona od końca do początku: " + Z3_LosoweImiona[i]);
            }
            Console.WriteLine("");

            // Zadanie 4

            int[] Z4_TablicaLiczb = [1, 2, 3, 4, 5, 6, 8, 10];
            int Z4_Parzysta = 0;
            int Z4_Nieparzysta = 0;

            foreach(int Z4_LiczbaCalkowita in Z4_TablicaLiczb)
            {
                int Z4_Check = Z4_LiczbaCalkowita % 2;

                if(Z4_Check == 0)
                {
                    Z4_Parzysta++;
                }

                else
                {
                    Z4_Nieparzysta++;
                }
            }
            Console.WriteLine("Tablica liczb dla zadania 4: " + string.Join(", ", Z4_TablicaLiczb));
            Console.WriteLine("");
            Console.WriteLine("Liczba liczb parzystych: " + Z4_Parzysta);
            Console.WriteLine("Liczba liczb nieparzystych: " + Z4_Nieparzysta);
            Console.WriteLine("");

            // Zadanie 5

            int[] Z5_A = { 3, 5, 8, 12, 17 };

            int[] Z5_B = new int[Z5_A.Length];

            for (int i = 0; i < Z5_A.Length; i++)
            {
                Z5_B[i] = Z5_A[i] * 2;
            }

            Console.WriteLine("Tablica liczb dla zadania 5: 3, 5, 8, 12, 17");
            Console.WriteLine("");
            Console.WriteLine("Tablica B (Pomnożona tablica A razy 2): " + string.Join(", ", Z5_B));


        }
    }
}
