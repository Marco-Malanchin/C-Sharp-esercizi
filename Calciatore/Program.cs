//Tramite la programmazione ad oggetti scrivere un programma in c# che dopo aver costruito la classe Calciatore
// visualizzi in output: il nome calciatore del calciatore, il ruola, la squadra ed i gol segnati ( i dati vengo no assegnati all'interno
// del codice).
using System; //Istruzione per utilizzo della libreria System, che permette di usare alcune classi: console e i metodi write e 
//ReadLine
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciatore //parola chiave per dichiarare in ambito che contiene un set di oggetti correlati 
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
        public void aggiornaGolSegnati(int gol)
        {
            golSegnati = golSegnati + gol;
        }
        public void visualizzaGol()
        {
            Console.WriteLine("{0} - {2} - gol segnati: {1}",nome,golSegnati,ruolo);
        }

        static void Main(string[] args)
        {
            Calciatore c = new Calciatore("Filippo Inzaghi", "Milan", "Attaccante");
            c.visualizzaGol();
            c.aggiornaGolSegnati(2);
            c.visualizzaGol();
            Console.ReadKey();
        }
    }
}
