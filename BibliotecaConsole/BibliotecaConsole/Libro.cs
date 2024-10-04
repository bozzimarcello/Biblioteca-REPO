using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaConsole
{
    class Libro
    {
        // proprietà
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public int Pagine { get; set; }
        public decimal Prezzo { get; set; }
        private int CodiceSegreto { get; }

        // costruttore
        public Libro()
        {
            // questo blocco di codice viene eseguito
            // alla creazione (new) degli oggetti di questa classe
            CodiceSegreto = 321;
        }

        // esempi di overload del costruttore
        public Libro(string titolo)
        {
            Titolo = titolo;
            CodiceSegreto = 456;
        }

        public Libro(
            string titolo,
            string autore)
        {
            Titolo = titolo;
            Autore = autore;
            CodiceSegreto = 789;
        }

        public Libro(
            string titolo,
            string autore,
            int pagine)
        {
            Titolo = titolo;
            Autore = autore;
            Pagine = pagine;
            CodiceSegreto = 265;
        }

        public Libro(
            string titolo,
            string autore,
            int pagine,
            decimal prezzo)
        {
            Titolo = titolo;
            Autore = autore;
            Pagine = pagine;
            Prezzo = prezzo;
            CodiceSegreto = 654;
        }


        public decimal PrezzoInDollari()
        {
            decimal prezzoConvertito = Prezzo / 0.89M;
            return prezzoConvertito;
        }

        // esempio di metodo virtuale sul quale è possibile
        // eseguire l'override
        public virtual string ResituisciValori()
        {
            return Titolo + " " + Autore + " " + Pagine + " " + Prezzo;
        }

    }
}
