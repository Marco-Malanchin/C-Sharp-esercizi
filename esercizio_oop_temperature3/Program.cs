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
                Array.Sort(TemperatureCittà);
                min = TemperatureCittà[0];
                max = TemperatureCittà[TemperatureCittà.Length - 2];
                return TemperatureCittà;
            }
        }

        class Program
        {
            static double[] TemperatureCittà = new double[1];
            static string nomeCittà;
            static void Main(string[] args)
            {
                Console.WriteLine("Benvenuto nel programma. Inserisci il nome della città:");
                nomeCittà = Console.ReadLine();
                int n = 0;
                while (TemperatureCittà[n] != 999)
                {
                    Console.WriteLine($"\nInserisci la {n + 1}a temperatura: (se vuoi fermarti inserisci i caratteri \"999\")");
                    TemperatureCittà[n] = int.Parse(Console.ReadLine());
                    if (TemperatureCittà[n] != 999)
                    {
                        n++;
                        Array.Resize(ref TemperatureCittà, TemperatureCittà.Length + 1);
                    }
                }
                Temperature t = new Temperature(TemperatureCittà);
                Console.WriteLine($"\nLe temperature di {nomeCittà} (gradi centigradi) sono, ordinate in modo crescente: ");
                for (int i = 1; i < TemperatureCittà.Length; i++)
                {
                    Console.WriteLine($"\n{i}) {t.OrdinaTemperature()[i - 1]}.");
                }
                Console.WriteLine($"\nLa temperatura minima è {t.min}, mentre quella massima è {t.max}");
                Console.WriteLine("\nPer uscire dal programma premere un tasto qualsiasi...");
                Console.ReadKey();
            }
        }
    }