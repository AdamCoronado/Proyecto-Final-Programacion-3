using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutBol_Torneos_Management.Clases
{
    public class Tarjeta
    {
        public string tipo {  get; set; }
        public string nombreJugador { get; set; }
        public int min {  get; set; }
        public Tarjeta() 
        {
            tipo = string.Empty;
            nombreJugador = string.Empty;
            min = 0;
        }
        public Tarjeta (string pTipo, string pNombreJugador, int PMin)
        {
            this.tipo = pTipo;
            this.nombreJugador= pNombreJugador;
            this.min = PMin;
        }
    }
}
