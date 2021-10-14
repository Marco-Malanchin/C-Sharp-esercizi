using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_oop_temperature3
{
        class Temperature
        {
            double[] TemperatureCittà { get; set; }
            public double min { get; set; }
            public double max { get; set; }
            public Temperature(double[] TemperatureCittà)
            {
                this.TemperatureCittà = TemperatureCittà;
            }
            public double[] OrdinaTemperature()
            {
                Array.Sort(TemperatureCittà); //ordino l'array
            min = TemperatureCittà[0]; //la temperatura minore sarà in poszione 0 quando l'array sarà ordinato
                max = TemperatureCittà[TemperatureCittà.Length - 2]; //la temperatura maggiore sarà nell'ultima posizione quando l'array sarà ordinato
            return TemperatureCittà;
            }
        }

        class Program
        {
            static double[] TemperatureCittà = new double[1];
            static string nomeCittà;
            static void Main(string[] args)
            {
                Console.WriteLine("Benvenuto nel programma. Inserisci il nome della città:"); //chiedo il nome della città
                nomeCittà = Console.ReadLine(); //Converto il nome della città<inserita da tastiera in una stringa
                int n = 0;
                while (TemperatureCittà[n] != 999) //se il numero inserito è 999 la misurazione si ferma
                {
                    Console.WriteLine($"\nInserisci la {n + 1}a temperatura: (se vuoi fermarti inserisci i caratteri \"999\")");
                    TemperatureCittà[n] = int.Parse(Console.ReadLine()); //converto il numero inserito da tastiera in int e lo posiziono all'interno dell array
                    if (TemperatureCittà[n] != 999)
                    {
                        n++;
                        Array.Resize(ref TemperatureCittà, TemperatureCittà.Length + 1);//aggiorno l'array aggiungendo le nuove temperature
                    }
                }
                Temperature t = new Temperature(TemperatureCittà);
                Console.WriteLine($"\nLe temperature di {nomeCittà} (gradi centigradi) sono, ordinate in modo crescente: ");
                for (int i = 1; i < TemperatureCittà.Length; i++)
                {
                    Console.WriteLine($"\n{i}) {t.OrdinaTemperature()[i - 1]}."); //ordino le temperature in modo crescente
                }
                Console.WriteLine($"\nLa temperatura minima è {t.min}, mentre quella massima è {t.max}"); //dichiaro le temperature minime e massime richiamando i metodi
                Console.WriteLine("\nPer uscire dal programma premere un tasto qualsiasi...");
                Console.ReadKey();
            }
        }
    }