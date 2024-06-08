using Biblioteca_de_Clases;
using EstructuraDeClases.Arboles;
using EstructuraDeClases.Listas;
using FutBol_Torneos_Management.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutBol_Torneos_Management
{
    public partial class Principal : Form
    {
        //Arbol AVL que contiene todos los equipos.
        ArbolAVL arbolAVLEquipos = new ArbolAVL();

        //TablaHash que contiene la informacion de todos los partidos.
        TablaHash TablaHashPartidos = new TablaHash();

        //Lista que contiene todos los jugadores.
        Lista ListaJugadores = new Lista();

        //Creamos el formulario Form_Torneos, Form_Jugadores
        Form_Torneos form_T = new Form_Torneos();
        public Principal()
        {
            InitializeComponent();
        }

        //En este proceso se cargan los datos iniciales de partidos, jugadores y equipos desde un archivo CSV.
        private void Principal_Load(object sender, EventArgs e)
        {
        }

        private void btnCrearTorneo_Click(object sender, EventArgs e)
        {
            Form_Torneos f_menuTorneos = new Form_Torneos();
            this.Hide();
            f_menuTorneos.Show();
        }

        private void btnCrearEquipo_Click(object sender, EventArgs e)
        {
            Form_Equipos form_E = new Form_Equipos();
            form_E.Show();
            this.Hide();
        }

        private void btn_AdminJugadores_Click(object sender, EventArgs e)
        {
            Form_Jugadores form_J = new Form_Jugadores();
            this.Hide();
            form_J.Show();
        }
    }
}
