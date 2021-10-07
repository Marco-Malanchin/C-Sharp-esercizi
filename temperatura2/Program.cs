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
            Console.WriteLine("Inserisci le temperatura");
            t = int.Parse(Console.ReadLine());
        }

        public int minimo()
        {
            if (min > t)
                min = t;
            return min;
        }
        public int massimo()
        {
            if (max < t)
                max = t;
            return max;
        }

        static void Main(string[] args)
        {
            int n, t = 0;
            temperatura2 k = new temperatura2(t);
            Console.WriteLine("Quante temperature vuoi inserire?");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                k.setTemp();
                k.minimo();
                k.massimo();
            }
            Console.WriteLine("La temperatura massima e' : {0}, quella minima e' : {1}", k.massimo(), k.minimo());
            Console.ReadKey();
        }
    }
}
