using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peli
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] Classit = new string[7];
            LuoClassit(Classit);
            Console.WriteLine("Anna nimi");
            String nimi = Console.ReadLine();
            Console.WriteLine("Anna ikä");
            int ikä = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Mikä classi?");
            for (int i = 0; i < Classit.Length; i++)
            {
                Console.WriteLine((i + 1) + ")" + Classit[i]);
            }

            int indeksi = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Hieno homma!");
            Console.WriteLine("");
            Console.WriteLine("Nimesi on siis " + nimi + " Ja olet " + ikä + " vuotta vanha.");
            Console.WriteLine("Luokkasi on: " + Classit[indeksi - 1]);
            Console.WriteLine("");

            Random rand = new Random();

            int kerroin = rand.Next(32 , 38);
            int[] statsit = new int[7];
            ArvoStatsit(kerroin, statsit);

            Console.WriteLine("Statsisi ovat:");
            Console.WriteLine("Strength:     " + statsit[0]);
            Console.WriteLine("Perception:   " + statsit[1]);
            Console.WriteLine("Endurance:    " + statsit[2]);
            Console.WriteLine("Charisma:     " + statsit[3]);
            Console.WriteLine("Intelligence: " + statsit[4]);
            Console.WriteLine("Agility:      " + statsit[5]);
            Console.WriteLine("Luck:         " + statsit[6]);
            Console.WriteLine("");
            Console.WriteLine("Onnea loppu elämälle");
            Console.WriteLine("");

            Console.ReadKey();


        }
        public static void LuoClassit(String[] Classit)
        {
            Classit[0] = "Natsi";
            Classit[1] = "Kommunisti";
            Classit[2] = "Turri";
            Classit[3] = "Paavi";
            Classit[4] = "Trump";
            Classit[5] = "Napoleon";
            Classit[6] = "Kirahvi";

        }


        public static void Indeksoi(int[] indeksit)
        {
            for(int i = 0; i < indeksit.Length; i++)
            {
                indeksit[i] = 0;
            }
        }


        public static void ArvoStatsit(int kerroin, int[] statsit)
        {


            Random rand = new Random();
            int S = rand.Next(4, 8);   //Strength
            int P = rand.Next(4, 8);   //Perception
            int E = rand.Next(4, 8);   //Endurance
            int C = rand.Next(4, 8);   //Charisma
            int I = rand.Next(4, 8);   //Intelligence
            int A = rand.Next(4, 8);   //Agility
            int L = rand.Next(4, 8);   //Luck

            statsit[0] = S;
            statsit[1] = P;
            statsit[2] = E;
            statsit[3] = C;
            statsit[4] = I;
            statsit[5] = A;
            statsit[6] = L;

            return;
        }
    }
}
