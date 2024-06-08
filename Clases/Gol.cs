using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutBol_Torneos_Management.Clases
{
    public class Gol
    {
        public string nombreJugador {  get; set; }
        public int min {  get; set; }
        public string tipo {  get; set; }
        public Gol() 
        {
            nombreJugador = string.Empty;
            min = 0;
            tipo = string.Empty;
        }

        public Gol (string pNombreJugador, int pMin, string pTipo)
        {
            nombreJugador = pNombreJugador;
            min = pMin;
            tipo = pTipo;
        }
    }
}
