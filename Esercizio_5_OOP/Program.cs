using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_5_OOP
{
    class Temperature
    {
        //attributi
        string nomeCitta;
        
        //Metodi
        public void assegnaNomeCitta()
        {
            Console.WriteLine("Inserisci il nome della citta' da prendere le temperature");
            nomeCitta = Console.ReadLine();
        }
        public void misurazuioniTemperature()
        {
            Console.WriteLine("Quante misurazioni sono state effetuate?");
            int nMisurazioni = Convert.ToInt32(Console.ReadLine());
            float[] temperature = new float[nMisurazioni];
            for (int i = 1; i <= nMisurazioni; i++)
            {
                Console.Clear();
                Console.WriteLine("Inserisci la {0}^ temperatura", i);
                temperature[i-1] = float.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Nella citta' di {0}, la temperatura massima e':{1}, qualla minima e' {2}", nomeCitta, temperature.Max(), temperature.Min());
        }

        static void Main(string[] args)
        {
            Temperature t = new Temperature();
            t.assegnaNomeCitta();
            t.misurazuioniTemperature();
            Console.ReadKey();
        }
    }
}
