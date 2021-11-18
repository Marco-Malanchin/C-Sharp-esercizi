using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eridetarietà
{
    class ClassDeriv
    {
        // Classe base.
        class Persona
        {
            public int Badge { get; set; }
            public string Cognome { get; set; }
            public string Nome { get; set; }

            public void StampaInformazioni()
            {
                Console.WriteLine("Badge: {0} Cognome: {1} Nome: {2} ", Badge.ToString(), Cognome, Nome);
            }
        }
        // Prima classe derivata.
        class Dipendente : Persona
        {
            public int Matricola { get; set; }
            public int Rettribuzione { get; set; }
            public void StampaInformazioni2()
            {
                //Console.WriteLine("Badge: {0} Cognome: {1} Nome: {2} : {3} Retribuzione: {4} ", Badge.ToString(), Cognome, Nome, Matricola, Rettribuzione);
                base.StampaInformazioni();
                Console.WriteLine("Matricola: {0} Retribuzione: {1}", Matricola, Rettribuzione);
            }
        }
        // Seconda classe derivata.
        class Collaboratore : Persona
        {
            public string Azienda { get; set; }
            public void StampaInformazioni3()
            {
                //Console.WriteLine("Badge: {0} Cognome: {1} Nome: {2} Azienda: {3}", Badge.ToString(), Cognome, Nome, Azienda);
                base.StampaInformazioni();
                Console.WriteLine("Azienda: {0}", Azienda);
            }
        }
        static void Main(string[] args)
        {
            Persona p = new Persona()
            {
                Badge = 1,
                Cognome = "Da Vinci",
                Nome = "Leonardo"
            };
            Dipendente d = new Dipendente()
            {
                Badge = 2,
                Cognome = "Buonarroti",
                Nome = "Michelangelo",
                Matricola = 1,
                Rettribuzione = 100
            };
            Collaboratore c = new Collaboratore()
            {
                Badge = 3,
                Cognome = "Vecellio",
                Nome = "Tiziano",
                Azienda = "Abc"
            };
            p.StampaInformazioni();
            d.StampaInformazioni2();
            c.StampaInformazioni3();
            Console.ReadKey(); 
        }
    }
}
