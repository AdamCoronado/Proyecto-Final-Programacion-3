using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutBol_Torneos_Management.Clases
{
    //Clase Jugador, contiene todosl los datos necesarios para un jugador.
    public class Jugador
    {
        public string nombre {get; set;}
        public int edad { get; set;}
        public string cumpleaños { get; set;}
        public string nacionalidad { get; set;}
        public string posicion {  get; set;}
        public string clubActual { get; set;}
        public int totalMinJugados { get; set;}
        public int totalAsistencias { get; set;}    
        public int totalPasesCompletados { get; set;}
        public int totalGoles { get; set;}
        public int golesXPenal {  get; set;}
        public int penalesFallados { get; set;}
        public int totalTarjetasAmarillas { get; set;}
        public int totalTarjetasRojas { get; set;}

        //Constructor
        public Jugador (string pNombre, int pEdad, string pCumpleaños,string pNacionalidad, string pPosicion, string pClubActual, int pTotalMinJugados, int pTotalAsistencias, int pTotalPasesCompletados, int pTotalGoles, int pGolesXPenal, int pPenalesFallados, int pTotalTarjetasAmarillas, int pTotalTarjetasRojas)
        {
            nombre = pNombre;
            edad = pEdad;
            cumpleaños = pCumpleaños;
            nacionalidad = pNacionalidad;
            posicion = pPosicion;
            clubActual = pClubActual;
            totalMinJugados = pTotalMinJugados;
            totalAsistencias = pTotalAsistencias;
            totalPasesCompletados = pTotalPasesCompletados;
            totalGoles = pTotalGoles;
            golesXPenal = pGolesXPenal;
            penalesFallados = pPenalesFallados;
            totalTarjetasAmarillas = pTotalTarjetasAmarillas;
            totalTarjetasRojas = pTotalTarjetasRojas;
        }


    }
}
