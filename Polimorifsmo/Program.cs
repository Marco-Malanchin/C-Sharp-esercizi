using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorifsmo
{
    class Dipendente
    {
        string matricola, nome, cognome;

        public Dipendente(string matricola, string nome, string cognome)
        {
            this.matricola = matricola;
            this.nome = nome;
            this.cognome = cognome;
        }
    }
    class Operaio : Dipendente
    {
        public int ore;
        public Operaio(string matricola, string nome, string cognome, int ore) : base(matricola, nome, cognome)
        {
            this.ore = ore;
        }
        public float Retribuzione(int a)
        {   
            float stipendio = (a * 35);
            return stipendio;
        }
    }
    class Impiegato : Dipendente
    {
        public int ore;
        public Impiegato(string matricola, string nome, string cognome, int ore) : base(matricola, nome, cognome)
        {
            this.ore = ore;
        }
        public float Retribuzione(int a)
        {
            float stipendio = (a * 35) + (((a * 35) * 30)/100);
            return stipendio;
        }
    }
    class Dirigente : Dipendente
    {
        public int ore;
        public Dirigente(string matricola, string nome, string cognome, int ore) : base(matricola, nome, cognome)
        {
            this.ore = ore;
        }
        public float Retribuzione(int a)
        {
            float stipendio = (a * 35) + (((a * 35) * 50) / 100);
            return stipendio;
        }



        static void Main(string[] args)
        {
            Operaio Simone = new Operaio("123", "Simone", "Giuriato", 25);
            float stipendio1 = Simone.Retribuzione(Simone.ore);
            Console.WriteLine("Stipendio di operaio = {0}", stipendio1);
            Impiegato Angelo = new Impiegato("124", "Angelo", "Pavan", 25);
            float stipendio2 = Angelo.Retribuzione(Angelo.ore);
            Console.WriteLine("Stipendio di operaio = {0}", stipendio2);
            Dirigente Marco = new Dirigente("125", "Marco", "Malanchin", 25);
            float stipendio3 = Marco.Retribuzione(Marco.ore);
            Console.WriteLine("Stipendio di operaio = {0}", stipendio3);
            Console.ReadKey();
        }
    }
   
}
