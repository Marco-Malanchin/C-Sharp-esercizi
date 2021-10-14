using System;

namespace smartPhone
{
    class smartPhone
    {
        //attributi
        double[] prezziSmartphone;
        //costruttore
        public smartPhone(double[] prezziSmartPhone)
        {
            this.prezziSmartphone = new double[1];
        }
        //Metodi
        public double[] Arrayresize()
        {
            Array.Resize(ref prezziSmartphone, prezziSmartphone.Length + 1);//Aumenta la dimensione dell'array ogni volta che si aggiunge un prezzo
            return prezziSmartphone;
        }



        static void Main(string[] args)
        {
            double[] prezziSmartPhone = new double[0]; // dichiaro l'array
            smartPhone c = new smartPhone(prezziSmartPhone);
            Console.WriteLine("Quanti prezzi vuoi inserire?");
            int numeroCellulari = int.Parse(Console.ReadLine()); //numero dei cellulari da inserire
            int n = 0;
            do
            {
                Console.WriteLine("Inserisci il {0}° prezzo:", n + 1); //chiede il prezzo 
                c.prezziSmartphone[n] = double.Parse(Console.ReadLine()); //aggiunge il prezzo all'array
                n++;
                c.Arrayresize(); // allarga l'array
            }
            while (n < numeroCellulari);
            Console.WriteLine("i prezzi maggiori di 100 euro sono:");
            for (int i = 0; i < numeroCellulari; i++)
            {
                if (c.prezziSmartphone[i] >= 100) //Controlla dentro l'array quali cellulari hanno il prezzo maggiore di 100
                {
                    Console.WriteLine("{0}", c.prezziSmartphone[i]); //stampa i valori maggiori di 100
                }

            }
            Console.ReadKey();
        }
    }
}

