using EstructuraDeClases.Listas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutBol_Torneos_Management.Clases
{
    public class Partido
    {
        public string Torneo { get; set; }                                                                                           
        public string equipoVisitante {  get; set; }
        public string equipoLocal {  get; set; }
        public string sede {  get; set; }
        public int golesLocal { get; set; }
        public int golesVisitante {  get; set; }
        public int tarjetasLocal { get; set; }
        public int tarjetasVisitante { get; set; }
        public string fechaPartido { get; set; }
        public Lista listaGolesLocal { get; set; }
        public Lista ListaGolesVisitante { get; set; }
        public Lista ListaTarjetasLocal { get; set; }
        public Lista ListaTarjetasVisitante { get; set; }

        public Partido(string pIdTorneo, string pEquipoVisitante, string pEquipoLocal, string pSede, int pGolesLocal, int pGolesVisitante, int pTarjetasLocal, int pTarjetasVisitante,string pFechaPartido, Lista pListaGolesLocal, Lista pListaGolesVisitante, Lista pListaTarjetasLocal, Lista pListaTarjetasVisitante) 
        {
            this.Torneo = pIdTorneo;
            this.equipoVisitante = pEquipoVisitante;
            this.equipoLocal = pEquipoLocal;
            this.sede = pSede;
            this.golesLocal = pGolesLocal;
            this.golesVisitante = pGolesVisitante;
            this.tarjetasLocal = pTarjetasLocal;
            this.tarjetasVisitante = pTarjetasVisitante;
            this.listaGolesLocal = pListaGolesLocal;
            this.ListaGolesVisitante = pListaGolesVisitante;
            this.ListaTarjetasLocal = pListaTarjetasLocal;
            this.ListaTarjetasVisitante = pListaTarjetasVisitante;
            this.fechaPartido = pFechaPartido;
        }

        public Partido()
        {
            this.Torneo = "";
            this.equipoVisitante = "";
            this.equipoLocal = "";
            this.sede = "";
            this.golesLocal = 0;
            this.golesVisitante = 0;
            this.tarjetasLocal = 0;
            this.tarjetasVisitante = 0;
            this.listaGolesLocal = new Lista();
            this.ListaGolesVisitante =  new Lista();
            this.ListaTarjetasLocal= new Lista();
            this.ListaTarjetasVisitante= new Lista();
            this.fechaPartido = "";
        }

    }
}
