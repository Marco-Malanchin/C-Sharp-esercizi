using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperatura2
{
    class temperatura2
    {
        //attributi
        int t, min, max;
        //costuttore
        public temperatura2(int t)
        {
            this.t = t;
            min = 9999;
            max = -9999;
        }
        //metodi
        public void setTemp()
        {
            Console.WriteLine("Inserisci le temperatura"); // chiedo la temperatura misurata
            t = int.Parse(Console.ReadLine()); //Converto la temperatura in una int
        }

        public int minimo()
        {
            if (min > t) //se la temperatura minima misurata in precedenza è maggiore della temperatura appena misurata, allora la nuova temperatura misurata sarà la temperatura minima.
                min = t;
            return min;
        }
        public int massimo()
        {
            if (max < t)//se la temperatura massima misurata in precedenza è minore della temperatura appena misurata, allora la nuova temperatura misurata sarà la temperatura massima.
                min = t;
            max = t;
            return max;
        }

        static void Main(string[] args)
        {
            int n, t = 0;
            temperatura2 k = new temperatura2(t);
            Console.WriteLine("Quante temperature vuoi inserire?");// chiedo quante misurazioni ho fatto 
            n = int.Parse(Console.ReadLine());// converto il numero delle misurazioni in una int
            for (int i = 0; i < n; i++)//chiedo le temperature per il numero di volte richieste in precedenza e confronto quale temperatura è la minore e quale è la maggiore
            {
                k.setTemp();
                k.minimo();
                k.massimo();
            }
            Console.WriteLine("La temperatura massima e' : {0}, quella minima e' : {1}", k.massimo(), k.minimo()); // comunico all'utente quali temperature sono le minori e maggiori.
            Console.ReadKey();
        }
    }
}
