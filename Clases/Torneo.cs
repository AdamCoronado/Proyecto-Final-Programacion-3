using Biblioteca_de_Clases;
using EstructuraDeClases.Arboles;
using EstructuraDeClases.Listas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutBol_Torneos_Management.Clases
{
    public class Torneo : Comparador
    {
        public string nombre { get; set; }
        public string fechaInicio { get; set; }
        public string fechaFin {  get; set; }
        public string localizacion { get; set; }
        public string estado {  get; set; }
        public Lista listaEquipos { get; set; }
        public int contadorEquipos { get; set; }
        public int CantidadPartidos { get; set; }

        public Torneo(string pNombre, string pFechaInicio, string pFechaFin, string Localicacion, string pEstado, Lista pLista, int cont)
        {
            nombre = pNombre;
            fechaInicio = pFechaInicio;
            fechaFin = pFechaFin;
            localizacion = Localicacion;
            estado = pEstado;
            listaEquipos = pLista;
            contadorEquipos = cont;
            CantidadPartidos = contadorEquipos * (contadorEquipos - 1);
        }
        
        public Torneo()
        {
            this.nombre = string.Empty;
            this.fechaInicio = string.Empty;
            this.fechaFin = string.Empty;
            this.localizacion = string.Empty;
            this.estado = string.Empty;
            this.listaEquipos = new Lista();
            this.contadorEquipos = 0;
            this.CantidadPartidos = 0;
        }

        public override string ToString()
        {
            //return nombre + "," + fechaInicio + "," + fecha + "," + partidosJugados + "," + partidosGanados + "," + partidosEmpatados + "," + partidosPerdidos + "," + conteoTotalGolesMarcados + "," + conteoTotalGolesContra + ",";
            return nombre;
        }

        public bool igualQue(object q)
        {
            Torneo Temp = (Torneo)q;
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
            Torneo Temp = (Torneo)q;
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
            Torneo Temp = (Torneo)q;
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
    }
}
