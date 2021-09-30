using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_Claciatore_2
{
    class Calciatore
    {
        //attributi
        string nome;
        string squadra;
        string ruolo;
        int golSegnati;
        //metodo di default: costruttore
        public Calciatore(string nome, string squadra, string ruolo)
        {
            this.nome = nome; //la parola chiave "this" serve per inizializzare i campi membro(attributi)
            this.squadra = squadra;
            this.ruolo = ruolo;
            golSegnati = 0;
        }
        //metodi
        public void aggiornaGolSegnati()
        {
            Console.WriteLine("Quanti gol ha segnato il calciatore?");
            golSegnati = golSegnati + Convert.ToInt32(Console.ReadLine()) ;
        }
        public void visualizzaGol()
        {
            Console.WriteLine("{0} - {2} - {3} - gol segnati: {1}", nome, golSegnati, ruolo, squadra);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci nome e cognome del calciatore, separati da uno spazio");
            string nome = Console.ReadLine();//Prendo da tastiera ogni input da visualizzare
            Console.Clear(); 
            Console.WriteLine("Inserisci il ruolo del calciatore");
            string ruolo = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Inserisci la squadra del calciatore");
            string squadra = Console.ReadLine();
            Console.Clear();
            Calciatore c = new Calciatore(nome, squadra, ruolo);
            c.aggiornaGolSegnati();
            Console.Clear();
            c.visualizzaGol();
            Console.ReadKey();
        }
    }
}

