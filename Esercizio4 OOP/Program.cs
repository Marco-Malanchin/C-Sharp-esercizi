using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio4_OOP
{
    class Cerchio
    {
        //attributi
        float raggio;

        //metodo costruttore
        public Cerchio()
        {
            float raggio = 0;
        }
        public void lunghezzaRaggio()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Quanto è lungo il raggio del cerchio? inserisci misura maggiore di 0");
                raggio = float.Parse(Console.ReadLine());
            }
            while (raggio <= 0);
        }
        public void misuraDiametro()
        { 
            Console.WriteLine("La misura del diametro e': {0}", raggio * 2);
        }
        public void misuraCirconferenza()
        {
            Console.WriteLine("La misura della circonferenza e': {0}", 2 * raggio * Math.PI);
        }
        public void misuraArea()
        {
            Console.WriteLine("La misura dell' area e': {0}", (raggio * raggio) * Math.PI);
        }
        static void Main(string[] args)
        {
            Cerchio c = new Cerchio();
            c.lunghezzaRaggio();
            Console.WriteLine("\n");
            c.misuraDiametro();
            Console.WriteLine("\n");
            c.misuraCirconferenza();
            Console.WriteLine("\n");
            c.misuraArea();
            Console.ReadKey();
        }
    }
}
