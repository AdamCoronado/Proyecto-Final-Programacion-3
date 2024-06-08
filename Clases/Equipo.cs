using EstructuraDeClases.Arboles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutBol_Torneos_Management.Clases
{
    //Clase Equipo: Esta clase contiene todos los datos necesarios para la clase Equipo.
    public class Equipo : Comparador
    {
        public string nombre {  get; set; }
        public string paisOrigen {  get; set; }
        public string nombreEntrenador { get; set; }
        public int partidosJugados { get; set; }
        public int partidosGanados { get; set; }
        public int partidosEmpatados { get; set; }
        public int partidosPerdidos { get; set; }
        public int conteoTotalGolesMarcados { get; set; }
        public int conteoTotalGolesContra {  get; set; }

        //Constructor
        public Equipo (string nombre, string paisOrigen, string pNombreEntrenador, int partidosJugados, int partidosGanados, int partidosEmpatados, int partidosPerdidos, int conteoTotalGolesMarcados, int conteoTotalGolesContra)
        {            
            this.nombre = nombre;
            this.paisOrigen = paisOrigen;
            this.nombreEntrenador = pNombreEntrenador;
            this.partidosJugados = partidosJugados;
            this.partidosGanados = partidosGanados;
            this.partidosEmpatados = partidosEmpatados;
            this.partidosPerdidos = partidosPerdidos;
            this.conteoTotalGolesMarcados = conteoTotalGolesMarcados;
            this.conteoTotalGolesContra = conteoTotalGolesContra;
        }

        public Equipo()
        {
            nombre = "";
            paisOrigen = "";
            nombreEntrenador = "";
            partidosJugados = 0;
            partidosGanados=0;
            partidosEmpatados=0;
            partidosPerdidos=0;
            conteoTotalGolesMarcados=0;
            conteoTotalGolesContra=0;
        }

        public bool igualQue(object q)
        {
            Equipo Temp = (Equipo)q;
            if (nombre == Temp.nombre)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool menorQue(object q)
        {
            Equipo Temp = (Equipo)q;
            int comparacion = string.Compare(Temp.nombre, nombre);
            if (comparacion < 0)
            {
                return true;
            }
            else
            { return false; }
        }

        public bool menorIgualQue(object q)
        {
            throw new NotImplementedException();
        }

        public bool mayorQue(object q)
        {
            Equipo Temp = (Equipo)q;
            int comparacion = string.Compare(Temp.nombre, nombre);
            if (comparacion > 0)
            {
                return true;
            }
            else { return false; }
        }

        public bool mayorIgualQue(object q)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return nombre + ","+paisOrigen+","+nombreEntrenador+","+partidosJugados+","+partidosGanados+","+partidosEmpatados+","+partidosPerdidos+","+conteoTotalGolesMarcados+","+conteoTotalGolesContra+",";
        }
    }
}
