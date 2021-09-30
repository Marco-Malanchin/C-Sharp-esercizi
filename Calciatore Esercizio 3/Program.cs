using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciatore_Esercizio_3
{
    class mediaEta
    {
        //attributi
        int eta1, eta2, eta3;
        //metodo costruttore
        public mediaEta()
        {
            eta1 = 0;
            eta2 = 0;
            eta3 = 0;
        }
        //metodi
        public void aggiornaEta()
        {
            Console.Clear();
            Console.WriteLine("Quanti anni ha la prima perosna?");
            eta1 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Quanti anni ha la seconda perosna?");
            eta2 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Quanti anni ha la terza perosna?");
            eta3 = int.Parse(Console.ReadLine());
        }
        public float med()
        {
            Console.Clear();
            float media = 0;
            media = (float) (eta1 + eta2 + eta3) / 3;
            Console.WriteLine("La media delle eta e': {0}", media);
            return media;
        }


        static void Main(string[] args)
        {
            mediaEta a = new mediaEta();
            a.aggiornaEta();
            a.med();
            Console.ReadKey();
        }
    }
}
