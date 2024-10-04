using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaConsole
{
    internal class Rivista : Libro
    {
        public string Periodicità { get; set; }

        public decimal CostoAbbonamento()
        {
            return Prezzo * 12;
        }

        // esempio di override di un metodo
        public override string ResituisciValori()
        {
            return base.ResituisciValori() + " " + Periodicità;
        }

    }
}
