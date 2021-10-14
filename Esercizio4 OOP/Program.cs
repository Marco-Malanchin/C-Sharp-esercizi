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
                Console.WriteLine("Quanto è lungo il raggio del cerchio? inserisci misura maggiore di 0");//Chiede la misura del raggio
                raggio = float.Parse(Console.ReadLine()); // Converte la misura del raggio in una variabile float
            }
            while (raggio <= 0); // se il raggio è minore di 0 la variabile non viene presa e viene riproposta la domanda
        }
        public void misuraDiametro()
        { 
            Console.WriteLine("La misura del diametro e': {0}", raggio * 2); // si calcola il diametro moltiplicando x 2 il raggio
        }
        public void misuraCirconferenza()
        {
            Console.WriteLine("La misura della circonferenza e': {0}", 2 * raggio * Math.PI); // si calcola la circonferenza facendo la formula= diametro x pgreco
        }
        public void misuraArea()
        {
            Console.WriteLine("La misura dell' area e': {0}", (raggio * raggio) * Math.PI);// si calcola l'area facendo la formula= raggio al quadrato x pgreco
        }
        static void Main(string[] args)
        {
            Cerchio c = new Cerchio();
            c.lunghezzaRaggio(); //richiamo i vari metodi
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
