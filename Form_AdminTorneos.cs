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
    public partial class Form_AdminTorneos : Form
    {
        TablaHash TablaHashArbolAVLTorneos = new TablaHash();
        //En la siguiente Tabla Hash se guardaran todos los partidos del archivo Partidos.csv
        TablaHash TablaHashListasPartidos = new TablaHash();
        //En esta lista se guardan todos los jugares previamente guardados para manejarlos
        Lista listaJugadores = new Lista();
        //En las siguientes variables se guardaras las tarjetas de los equipos para guardarlas al final en el archivo Partidos.csv
        Lista tarjetasLocal = new Lista();
        Lista tarjetasVisitante = new Lista();
        //En las siguientes variables se guardaran los goles de los equipos para guardarlas al final en el archivo Partidos.csv
        Lista golLocal = new Lista();
        Lista golVisitante = new Lista();
        public Form_AdminTorneos()
        {
            InitializeComponent();
        }

        private void Form_AdminTorneos_Load(object sender, EventArgs e)
        {
            //Damos valor a las combo box que no cambiaran como el tipo de Gol y tipo de tarjeta
            string[] tipoGol = { "Penal", "Tiro Libre Directo", "Tiro Libre Indirecto", "Olimpico", "Normal", "Autogol", "" };
            cbTipoGolesVisitante.Items.AddRange(tipoGol);
            cbTipoGolLocal.Items.AddRange(tipoGol);
            string[] tipoTarjeta = { "Amarilla", "Roja", "" };
            cbTipoTarjetaLocal.Items.AddRange(tipoTarjeta);
            cbTipoTarjetaVisitante.Items.AddRange(tipoTarjeta);

            //A continuacion se cargan todos los torneos en una estructura de datos para su administracion.
            string rutaArchivo = "C:\\PROYECTO FINAL PROGRAMACION 3\\Torneos.csv";
            Char Delimitador = ',';
            try
            {
                using (var reader = new StreamReader(rutaArchivo))
                {
                    int contador = 0;
                    string linea = "";
                    while ((linea = reader.ReadLine()) != null)
                    {
                        string[] subCadenas = linea.Split(Delimitador);
                        Lista tempLista = new Lista();
                        for (int i = 6; i < subCadenas.Length; i++)
                            tempLista.InsertarCabezaLista(subCadenas[i]);
                        Torneo tempTorneo = new Torneo(subCadenas[0], subCadenas[1], subCadenas[2], subCadenas[3], subCadenas[4], tempLista, Convert.ToInt32(subCadenas[5]));
                        TablaHashArbolAVLTorneos.InsertarArbolAVHashL(tempTorneo, subCadenas[0]);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo : " + ex);
            }
            actualizarComboBox();
            cbEquiposLocales.Items.Add("");
            cbEquiposVisitantes.Items.Add("");
            //En el siguiente codigo se lee el archivo de Jugadores y se agregan los datos a una lista
            rutaArchivo = "C:\\PROYECTO FINAL PROGRAMACION 3\\Jugadores.csv";
            try
            {
                using (var reader = new StreamReader(rutaArchivo))
                {
                    int contador = 0;
                    string linea = "";
                    while ((linea = reader.ReadLine()) != null)
                    {
                        string[] subCadenas = linea.Split(Delimitador);
                        if (subCadenas[8] == "N/A")
                            subCadenas[8] = "0";
                        Jugador nuevo = new Jugador(subCadenas[0], Convert.ToInt32(subCadenas[1]), subCadenas[2], subCadenas[3], subCadenas[4], subCadenas[5], Convert.ToInt32(subCadenas[6]), Convert.ToInt32(subCadenas[7]), Convert.ToInt32(subCadenas[8]), Convert.ToInt32(subCadenas[9]), Convert.ToInt32(subCadenas[10]), Convert.ToInt32(subCadenas[11]), Convert.ToInt32(subCadenas[12]), Convert.ToInt32(subCadenas[13]));
                        listaJugadores.InsertarCabezaLista(nuevo);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo : " + ex);
            }
            cbEquiposVisitantes.Enabled = false;

            //En el siguiente codigo se lee el archivo de Partidos y se agregan los datos a una TablaHash de Listas
            rutaArchivo = "C:\\PROYECTO FINAL PROGRAMACION 3\\Partidos.csv";
            try
            {
                using (var reader = new StreamReader(rutaArchivo))
                {
                    int contador = 0;
                    string linea = "";
                    while ((linea = reader.ReadLine()) != null)
                    {
                        string[] subCadenas = linea.Split(Delimitador);
                        Partido nuevoPartido = new Partido();
                        nuevoPartido.Torneo = subCadenas[0];
                        nuevoPartido.equipoVisitante = subCadenas[1];
                        nuevoPartido.equipoLocal = subCadenas[2];
                        nuevoPartido.sede = subCadenas[3];
                        nuevoPartido.golesLocal = Convert.ToInt32(subCadenas[4]);
                        nuevoPartido.golesVisitante = Convert.ToInt32(subCadenas[5]);
                        nuevoPartido.tarjetasVisitante = Convert.ToInt32(subCadenas[7]);
                        nuevoPartido.tarjetasLocal = Convert.ToInt32(subCadenas[6]);
                        nuevoPartido.fechaPartido = subCadenas[8];
                        int i;
                        for (i = 9; i < 9 + nuevoPartido.golesLocal; i++)
                        {
                            string[] subCadenasGoles = subCadenas[i].Split('-');
                            Gol tempGol = new Gol(subCadenasGoles[0], Convert.ToInt32(subCadenasGoles[1]), subCadenasGoles[2]);
                            nuevoPartido.listaGolesLocal.InsertarCabezaLista(tempGol);
                        }
                        for (i = 9 + nuevoPartido.golesLocal; i < 9 + nuevoPartido.golesLocal + nuevoPartido.golesVisitante; i++)
                        {
                            string[] subCadenasGoles = subCadenas[i].Split('-');
                            Gol tempGol = new Gol(subCadenasGoles[0], Convert.ToInt32(subCadenasGoles[1]), subCadenasGoles[2]);
                            nuevoPartido.ListaGolesVisitante.InsertarCabezaLista(tempGol);
                        }
                        for (i = 9 + nuevoPartido.golesLocal + nuevoPartido.golesVisitante; i < (9 + nuevoPartido.golesLocal + nuevoPartido.golesVisitante + nuevoPartido.tarjetasVisitante); i++)
                        {
                            string[] subCadenasTarjetas = subCadenas[i].Split('-');
                            Tarjeta tempTarjeta = new Tarjeta(subCadenasTarjetas[0], subCadenasTarjetas[1], Convert.ToInt32(subCadenasTarjetas[2]));
                            nuevoPartido.ListaTarjetasLocal.InsertarCabezaLista(tempTarjeta);
                        }
                        for (i = 9 + nuevoPartido.golesLocal + nuevoPartido.golesVisitante + nuevoPartido.tarjetasVisitante; i < (9 + nuevoPartido.golesLocal + nuevoPartido.golesVisitante + nuevoPartido.tarjetasVisitante + nuevoPartido.tarjetasLocal); i++)
                        {
                            string[] subCadenasTarjetas = subCadenas[i].Split('-');
                            Tarjeta tempTarjeta = new Tarjeta(subCadenasTarjetas[0], subCadenasTarjetas[1], Convert.ToInt32(subCadenasTarjetas[2]));
                            nuevoPartido.ListaTarjetasVisitante.InsertarCabezaLista(tempTarjeta);
                        }
                        TablaHashListasPartidos.Insertar(nuevoPartido, nuevoPartido.Torneo);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo : " + ex);
            }
            cbEquiposVisitantes.Enabled = false;


        }

        private void actualizarComboBox()
        {
            //Actualizamos el combo box que muestra los torneos guardados
            string rutaArchivo = "C:\\PROYECTO FINAL PROGRAMACION 3\\Torneos.csv";
            Char Delimitador = ',';
            try
            {
                using (var reader = new StreamReader(rutaArchivo))
                {
                    int contador = 0;
                    string linea = "";
                    while ((linea = reader.ReadLine()) != null)
                    {
                        string[] subCadenas = linea.Split(Delimitador);
                        cbTorneos.Items.Add(subCadenas[0]);

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo : " + ex);
            }
        }

        private void cbTorneos_TextChanged(object sender, EventArgs e)
        {
            cbEquiposBusqueda.Items.Clear();
            cbEquiposLocales.Items.Clear();
            cbEquiposVisitantes.Items.Clear();
            string torneoAdministrar = cbTorneos.Text;
            if (cbTorneos.Text == "")
            {
                cbEquiposBusqueda.Items.Clear();
                cbEquiposLocales.Items.Clear();
                cbEquiposVisitantes.Items.Clear();
            }
            else
            {
                string rutaArchivo = "C:\\PROYECTO FINAL PROGRAMACION 3\\Torneos.csv";
                Char Delimitador = ',';
                try
                {
                    using (var reader = new StreamReader(rutaArchivo))
                    {
                        int contador = 0;
                        string linea = "";
                        while ((linea = reader.ReadLine()) != null)
                        {
                            string[] subCadenas = linea.Split(Delimitador);
                            Lista tempLista = new Lista();
                            if (subCadenas[0] == torneoAdministrar)
                                for (int i = 6; i < subCadenas.Length; i++)
                                {
                                    cbEquiposLocales.Items.Add(subCadenas[i]);
                                    cbEquiposVisitantes.Items.Add(subCadenas[i]);
                                }
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer el archivo : " + ex);
                }

                cbEquiposBusqueda.Enabled = true;
                string torneoBusqueda = cbTorneos.Text;
                NodoLista nodoTemp = (NodoLista)TablaHashListasPartidos.Buscar(torneoBusqueda);
                while (nodoTemp != null)
                {
                    Partido partidoTemp = (Partido)nodoTemp.Dato;
                    if (partidoTemp.Torneo == torneoBusqueda)
                    {
                        string cadenaTemp = partidoTemp.equipoLocal + "-" + partidoTemp.equipoVisitante;
                        cbEquiposBusqueda.Items.Add(cadenaTemp);
                    }
                    nodoTemp = nodoTemp.Enlace;
                }

            }
        }

        private void cbEquiposLocales_TextChanged(object sender, EventArgs e)
        {
            cbEquiposVisitantes.Enabled = true;
            //Al cambiar el valor del Equipo Local, se lee la lista total de jugadores y se agregan a las combo box
            //los jugadores del equipo local elegido
            cbJugadoresTarjetasLocal.Items.Clear();
            cbJugadoresGolesLocal.Items.Clear();
            lbGolesEquipoLocal.Items.Clear();
            lbTarjetasEquipoLocal.Items.Clear();
            NodoLista nodoTemp = listaJugadores.Primero;
            while (nodoTemp != null)
            {
                Jugador JugadorTemp = (Jugador)nodoTemp.Dato;
                if (JugadorTemp.clubActual == cbEquiposLocales.Text)
                {
                    cbJugadoresTarjetasLocal.Items.Add(JugadorTemp.nombre);
                    cbJugadoresGolesLocal.Items.Add(JugadorTemp.nombre);
                }
                nodoTemp = nodoTemp.Enlace;
            }
        }

        private void cbEquiposVisitantes_TextChanged(object sender, EventArgs e)
        {
            //El siguiente codigo sirve para avisar al usuario que se escogio el mismo equipo local y visitante.
            if (cbEquiposLocales.Text == cbEquiposVisitantes.Text)
            {
                MessageBox.Show("El equipo LOCAL no puede ser igual al equipo VISITANTE.");
                cbEquiposLocales.Text = " ";
            }
            //Al cambiar el valor del Equipo Visitante, se lee la lista total de jugadores y se agregan a las
            //Combo boxes los jugadores del equipo Visitante elegido
            cbJugadoresTarjetasVisitante.Items.Clear();
            cbJugadoresGolesVisitante.Items.Clear();
            lbGolesVisitante.Items.Clear();
            lbTarjetasVisitante.Items.Clear();
            NodoLista nodoTemp = listaJugadores.Primero;
            while (nodoTemp != null)
            {
                Jugador JugadorTemp = (Jugador)nodoTemp.Dato;
                if (JugadorTemp.clubActual == cbEquiposVisitantes.Text)
                {
                    cbJugadoresTarjetasVisitante.Items.Add(JugadorTemp.nombre);
                    cbJugadoresGolesVisitante.Items.Add(JugadorTemp.nombre);
                }
                nodoTemp = nodoTemp.Enlace;
            }
        }

        private void btnGuardarTarjetaLocal_Click(object sender, EventArgs e)
        {
            Tarjeta tarjetaTemp = new Tarjeta(cbTipoTarjetaLocal.Text, cbJugadoresTarjetasLocal.Text, Convert.ToInt32(txtbMinTarjetaLocal.Text));
            tarjetasLocal.InsertarCabezaLista(tarjetaTemp);
            string tarjetaCadena = cbTipoTarjetaLocal.Text + "," + cbJugadoresTarjetasLocal.Text + "," + txtbMinTarjetaLocal.Text;
            cbTipoTarjetaLocal.Text = "";
            cbJugadoresTarjetasLocal.Text = "";
            txtbMinTarjetaLocal.Text = "";
            lbTarjetasEquipoLocal.Items.Add(tarjetaCadena);
        }

        private void btnGuardarTarjetaVisitante_Click(object sender, EventArgs e)
        {
            Tarjeta tarjetaTemp = new Tarjeta(cbTipoTarjetaVisitante.Text, cbJugadoresTarjetasVisitante.Text, Convert.ToInt32(txtbMinTarjetaVisitante.Text));
            tarjetasVisitante.InsertarCabezaLista(tarjetaTemp);
            string tarjetaCadena = cbTipoTarjetaVisitante.Text + "," + cbJugadoresTarjetasVisitante.Text + "," + txtbMinTarjetaVisitante.Text;
            cbTipoTarjetaVisitante.Text = "";
            cbJugadoresTarjetasVisitante.Text = "";
            txtbMinTarjetaVisitante.Text = "";
            lbTarjetasVisitante.Items.Add(tarjetaCadena);
        }

        private void btnEliminarTarjetaLocal_Click(object sender, EventArgs e)
        {
            if (lbTarjetasEquipoLocal.SelectedItem == null)
                MessageBox.Show("Debes de seleccionar una TARJETA de la lista de Tarjetas para eliminarlo!");
            else
            {
                string cadena = lbTarjetasEquipoLocal.Text;
                string[] subCadenas = cadena.Split(',');
                Tarjeta tarjetaComparacion = new Tarjeta(subCadenas[0], subCadenas[1], Convert.ToInt32(subCadenas[2]));
                NodoLista nodoTemp = tarjetasLocal.Primero;
                Lista ListaModificada = new Lista();
                while (nodoTemp != null)
                {
                    Tarjeta temp = (Tarjeta)nodoTemp.Dato;
                    if (temp.tipo == tarjetaComparacion.tipo && temp.nombreJugador == tarjetaComparacion.nombreJugador && temp.min == tarjetaComparacion.min)
                    {
                        nodoTemp = nodoTemp.Enlace;
                    }
                    if (nodoTemp != null)
                        ListaModificada.InsertarCabezaLista(nodoTemp.Dato);
                    if (nodoTemp == null)
                        break;
                    nodoTemp = nodoTemp.Enlace;
                }
                tarjetasLocal = ListaModificada;
                lbTarjetasEquipoLocal.Items.Remove(lbTarjetasEquipoLocal.Text);
            }
        }

        private void btnEliminarTarjetaVisitante_Click(object sender, EventArgs e)
        {
            if (lbTarjetasVisitante.SelectedItem == null)
                MessageBox.Show("Debes de seleccionar un TARJETA de la lista de Tarjetas para eliminarlo!");
            else
            {
                string cadena = lbTarjetasVisitante.Text;
                string[] subCadenas = cadena.Split(',');
                Tarjeta tarjetaComparacion = new Tarjeta(subCadenas[0], subCadenas[1], Convert.ToInt32(subCadenas[2]));
                NodoLista nodoTemp = tarjetasVisitante.Primero;
                Lista ListaModificada = new Lista();
                while (nodoTemp != null)
                {
                    Tarjeta temp = (Tarjeta)nodoTemp.Dato;
                    if (temp.tipo == tarjetaComparacion.tipo && temp.nombreJugador == tarjetaComparacion.nombreJugador && temp.min == tarjetaComparacion.min)
                    {
                        nodoTemp = nodoTemp.Enlace;
                    }
                    if (nodoTemp != null)
                        ListaModificada.InsertarCabezaLista(nodoTemp.Dato);
                    if (nodoTemp == null)
                        break;
                    nodoTemp = nodoTemp.Enlace;
                }
                tarjetasVisitante = ListaModificada;
                lbTarjetasVisitante.Items.Remove(lbTarjetasVisitante.Text);
            }
        }

        private void btnGuardarGolLocal_Click(object sender, EventArgs e)
        {
            Gol golTemp = new Gol(cbJugadoresGolesLocal.Text, Convert.ToInt32(txtbMinGolLocal.Text), cbTipoGolLocal.Text);
            golLocal.InsertarCabezaLista(golTemp);
            string golCadena = cbJugadoresGolesLocal.Text + "," + txtbMinGolLocal.Text + "," + cbTipoGolLocal.Text;
            cbTipoGolLocal.Text = "";
            cbJugadoresGolesLocal.Text = "";
            txtbMinGolLocal.Text = "";
            lbGolesEquipoLocal.Items.Add(golCadena);
        }

        private void btnGuardarGolVisitante_Click(object sender, EventArgs e)
        {
            Gol golTemp = new Gol(cbJugadoresGolesVisitante.Text, Convert.ToInt32(txtbMinGolVisitante.Text), cbTipoGolesVisitante.Text);
            golVisitante.InsertarCabezaLista(golTemp);
            string golCadena = cbJugadoresGolesVisitante.Text + "," + txtbMinGolVisitante.Text + "," + cbTipoGolesVisitante.Text;
            cbTipoGolesVisitante.Text = "";
            cbJugadoresGolesVisitante.Text = "";
            txtbMinGolVisitante.Text = "";
            lbGolesVisitante.Items.Add(golCadena);
        }

        private void btnEliminarGolLocal_Click(object sender, EventArgs e)
        {
            if (lbGolesEquipoLocal.SelectedItem == null)
                MessageBox.Show("Debes de seleccionar un GOL de la lista de Goles para eliminarlo!");
            else
            {
                string cadena = lbGolesEquipoLocal.Text;
                string[] subCadenas = cadena.Split(',');
                Gol golComparacion = new Gol(subCadenas[0], Convert.ToInt32(subCadenas[1]), subCadenas[2]);
                NodoLista nodoTemp = golLocal.Primero;
                Lista ListaModificada = new Lista();
                while (nodoTemp != null)
                {
                    Gol temp = (Gol)nodoTemp.Dato;
                    if (temp.tipo == golComparacion.tipo && temp.nombreJugador == golComparacion.nombreJugador && temp.min == golComparacion.min)
                    {
                        nodoTemp = nodoTemp.Enlace;
                    }
                    if (nodoTemp != null)
                        ListaModificada.InsertarCabezaLista(nodoTemp.Dato);
                    if (nodoTemp == null)
                        break;
                    nodoTemp = nodoTemp.Enlace;
                }
                golLocal = ListaModificada;
                lbGolesEquipoLocal.Items.Remove(lbGolesEquipoLocal.Text);
            }
        }

        private void btnEliminarGolVisitante_Click(object sender, EventArgs e)
        {
            if (lbGolesVisitante.SelectedItem == null)
                MessageBox.Show("Debes de seleccionar un GOL de la lista de Goles para eliminarlo!");
            else
            {
                string cadena = lbGolesVisitante.Text;
                string[] subCadenas = cadena.Split(',');
                Gol golComparacion = new Gol(subCadenas[0], Convert.ToInt32(subCadenas[1]), subCadenas[2]);
                NodoLista nodoTemp = golVisitante.Primero;
                Lista ListaModificada = new Lista();
                while (nodoTemp != null)
                {
                    Gol temp = (Gol)nodoTemp.Dato;
                    if (temp.tipo == golComparacion.tipo && temp.nombreJugador == golComparacion.nombreJugador && temp.min == golComparacion.min)
                    {
                        nodoTemp = nodoTemp.Enlace;
                    }
                    if (nodoTemp != null)
                        ListaModificada.InsertarCabezaLista(nodoTemp.Dato);
                    if (nodoTemp == null)
                        break;
                    nodoTemp = nodoTemp.Enlace;
                }
                golVisitante = ListaModificada;
                lbGolesVisitante.Items.Remove(lbGolesVisitante.Text);
            }
        }

        private void LimpiarCampos()
        {
            txtbSede.Text = string.Empty;
            txtbFechaPartido.Text = string.Empty;
            txtbMinGolLocal.Text = string.Empty;
            txtbMinGolVisitante.Text = string.Empty;
            txtbMinTarjetaLocal.Text = string.Empty;
            txtbMinTarjetaVisitante.Text = string.Empty;
            cbEquiposBusqueda.Text = string.Empty;
            cbEquiposVisitantes.Text = string.Empty;
            cbEquiposLocales.Text = string.Empty;
            cbJugadoresTarjetasLocal.Text = string.Empty;
            cbJugadoresTarjetasVisitante.Text = string.Empty;
            cbJugadoresGolesLocal.Text = string.Empty;
            cbJugadoresGolesVisitante.Text = string.Empty;
            cbTipoGolLocal.Text = string.Empty;
            cbTipoGolesVisitante.Text = string.Empty;
            cbTipoTarjetaLocal.Text = string.Empty;
            cbTipoTarjetaVisitante.Text = string.Empty;
            lbTarjetasEquipoLocal.Items.Clear();
            lbTarjetasVisitante.Items.Clear();
            lbGolesEquipoLocal.Items.Clear();
            lbGolesVisitante.Items.Clear();
            golLocal = new Lista();
            golVisitante = new Lista();
            tarjetasLocal = new Lista();
            tarjetasVisitante = new Lista();
        }

        private void btnAgregarPartido_Click(object sender, EventArgs e)
        {
            if (txtbFechaPartido.Text == "" || txtbSede.Text == "" || cbEquiposLocales.Text == "" || cbEquiposVisitantes.Text == "")
                MessageBox.Show("Debe de llenar los campos: Sede, Fecha, Equipo Local y Equipo Visitante para poder guardar el partido");
            else
            {
                Partido nuevoPartido = new Partido();
                nuevoPartido.Torneo = cbTorneos.Text;
                nuevoPartido.equipoVisitante = cbEquiposVisitantes.Text;
                nuevoPartido.equipoLocal = cbEquiposLocales.Text;
                nuevoPartido.sede = txtbSede.Text;
                if (lbGolesEquipoLocal.Items.Count == 0)
                    nuevoPartido.golesLocal = 0;
                else
                    nuevoPartido.golesLocal = lbGolesEquipoLocal.Items.Count;
                if (lbGolesVisitante.Items.Count == 0)
                    nuevoPartido.golesVisitante = 0;
                else
                    nuevoPartido.golesVisitante = lbGolesVisitante.Items.Count;
                if (lbTarjetasVisitante.Items.Count == 0)
                    nuevoPartido.tarjetasVisitante = 0;
                else
                    nuevoPartido.tarjetasVisitante = lbTarjetasVisitante.Items.Count;
                if (lbTarjetasEquipoLocal.Items.Count == 0)
                    nuevoPartido.tarjetasLocal = 0;
                else
                    nuevoPartido.tarjetasLocal = lbTarjetasEquipoLocal.Items.Count;
                nuevoPartido.fechaPartido = txtbFechaPartido.Text;
                nuevoPartido.listaGolesLocal = golLocal;
                nuevoPartido.ListaGolesVisitante = golVisitante;
                nuevoPartido.ListaTarjetasVisitante = tarjetasVisitante;
                nuevoPartido.ListaTarjetasLocal = tarjetasLocal;
                TablaHashListasPartidos.Insertar(nuevoPartido, nuevoPartido.Torneo);

                string cadena = cbTorneos.Text + "," + cbEquiposVisitantes.Text + "," + cbEquiposLocales.Text + "," + txtbSede.Text + "," + nuevoPartido.golesLocal + "," + nuevoPartido.golesVisitante + "," + nuevoPartido.tarjetasLocal + "," + nuevoPartido.tarjetasVisitante + "," + txtbFechaPartido.Text;

                //Recorremos las listas de Goles y Tarjetas local y visitante para agregarlos a la cadena que se agregara al archivo Partidos.csv
                NodoLista nodoTemp = golLocal.Primero;
                while (nodoTemp != null)
                {
                    Gol golTemp = (Gol)nodoTemp.Dato;
                    cadena = cadena + "," + golTemp.nombreJugador + "-" + Convert.ToString(golTemp.min) + "-" + golTemp.tipo;
                    nodoTemp = nodoTemp.Enlace;
                }
                nodoTemp = golVisitante.Primero;
                while (nodoTemp != null)
                {
                    Gol golTemp = (Gol)nodoTemp.Dato;
                    cadena = cadena + "," + golTemp.nombreJugador + "-" + golTemp.min + "-" + golTemp.tipo;
                    nodoTemp = nodoTemp.Enlace;
                }
                nodoTemp = tarjetasLocal.Primero;
                while (nodoTemp != null)
                {
                    Tarjeta tarjetaTemp = (Tarjeta)nodoTemp.Dato;
                    cadena = cadena + "," + tarjetaTemp.tipo + "-" + tarjetaTemp.nombreJugador + "-" + tarjetaTemp.min;
                    nodoTemp = nodoTemp.Enlace;
                }
                nodoTemp = tarjetasVisitante.Primero;
                while (nodoTemp != null)
                {
                    Tarjeta tarjetaTemp = (Tarjeta)nodoTemp.Dato;
                    cadena = cadena + "," + tarjetaTemp.tipo + "-" + tarjetaTemp.nombreJugador + "-" + tarjetaTemp.min;
                    nodoTemp = nodoTemp.Enlace;
                }
                using (StreamWriter writer = new StreamWriter("C:\\PROYECTO FINAL PROGRAMACION 3\\Partidos.csv", true))
                {
                    writer.WriteLine(cadena);
                }
                LimpiarCampos();
                cbEquiposBusqueda.Items.Clear();
                string torneoBusqueda = cbTorneos.Text;
                NodoLista nodoTemp2 = (NodoLista)TablaHashListasPartidos.Buscar(torneoBusqueda);
                while (nodoTemp2 != null)
                {
                    Partido partidoTemp = (Partido)nodoTemp2.Dato;
                    if (partidoTemp.Torneo == torneoBusqueda)
                    {
                        string cadenaTemp = partidoTemp.equipoLocal + "-" + partidoTemp.equipoVisitante;
                        cbEquiposBusqueda.Items.Add(cadenaTemp);
                    }
                    nodoTemp2 = nodoTemp2.Enlace;
                }
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string[] Equipos = cbEquiposBusqueda.Text.Split('-');
            lbGolesEquipoLocal.Items.Clear();
            lbGolesVisitante.Items.Clear();
            lbTarjetasEquipoLocal.Items.Clear();
            lbTarjetasVisitante.Items.Clear();

            NodoLista nodoTemp = (NodoLista)TablaHashListasPartidos.Buscar(cbTorneos.Text);
            while (nodoTemp != null)
            {
                Partido partidoTemp = (Partido)nodoTemp.Dato;
                if (partidoTemp.equipoLocal == Equipos[0] && partidoTemp.equipoVisitante == Equipos[1])
                {
                    txtbSede.Text = partidoTemp.sede;
                    txtbFechaPartido.Text = partidoTemp.fechaPartido;
                    cbEquiposLocales.Text = partidoTemp.equipoLocal;
                    cbEquiposVisitantes.Text = partidoTemp.equipoVisitante;

                    NodoLista nodoTempTarjetas = partidoTemp.ListaTarjetasLocal.Primero;
                    while (nodoTempTarjetas != null)
                    {
                        Tarjeta tempTarjeta = (Tarjeta)nodoTempTarjetas.Dato;
                        lbTarjetasEquipoLocal.Items.Add(tempTarjeta.tipo + "-" + tempTarjeta.nombreJugador + "-Min " + tempTarjeta.min);
                        nodoTempTarjetas = nodoTempTarjetas.Enlace;
                    }
                    NodoLista nodoTempTarjetas2 = partidoTemp.ListaTarjetasVisitante.Primero;
                    while (nodoTempTarjetas2 != null)
                    {
                        Tarjeta tempTarjeta = (Tarjeta)nodoTempTarjetas2.Dato;
                        lbTarjetasVisitante.Items.Add(tempTarjeta.tipo + "-" + tempTarjeta.nombreJugador + "-Min " + tempTarjeta.min);
                        nodoTempTarjetas2 = nodoTempTarjetas2.Enlace;
                    }
                    NodoLista nodoTempGoles = partidoTemp.listaGolesLocal.Primero;
                    while (nodoTempGoles != null)
                    {
                        Gol tempGol = (Gol)nodoTempGoles.Dato;
                        lbGolesEquipoLocal.Items.Add(tempGol.nombreJugador + "-Min " + tempGol.min + "-" + tempGol.tipo);
                        nodoTempGoles = nodoTempGoles.Enlace;
                    }
                    NodoLista nodoTempGoles2 = partidoTemp.ListaGolesVisitante.Primero;
                    while (nodoTempGoles2 != null)
                    {
                        Gol tempGol = (Gol)nodoTempGoles2.Dato;
                        lbGolesVisitante.Items.Add(tempGol.nombreJugador + "-Min " + tempGol.min + "-" + tempGol.tipo);
                        nodoTempGoles2 = nodoTempGoles2.Enlace;
                    }
                }
                nodoTemp = nodoTemp.Enlace;
            }
            btnAgregarPartido.Enabled = false;
            btnElimnarPartido.Enabled = true;
        }

        private void btnBorrarDatos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnAgregarPartido.Enabled = true;
            btnElimnarPartido.Enabled = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form_Torneos f_Torneos = new Form_Torneos();
            this.Close();
            f_Torneos.Show();
        }

        private void btnEliminarTorneo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas continuar? Si continuas, el TORNEO seleccionado se eliminara permanentemente!!!", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                NodoAvl nodoTemp = (NodoAvl)TablaHashArbolAVLTorneos.BuscarArbolAVLHash(cbTorneos.Text);
                int clave = TablaHashArbolAVLTorneos.convertir(cbTorneos.Text);
                int posicion = TablaHashArbolAVLTorneos.HashMod(clave);
                Torneo torneoTemp = new Torneo();
                torneoTemp.nombre = cbTorneos.Text;
                TablaHashArbolAVLTorneos.ArbolAVlHash[posicion].eliminar(torneoTemp);



                string rutaArchivo = "C:\\PROYECTO FINAL PROGRAMACION 3\\Torneos.csv";
                Char Delimitador = ',';
                try
                {
                    using (StreamWriter writer = new StreamWriter("C:\\PROYECTO FINAL PROGRAMACION 3\\TorneosMOD.csv"))
                    {
                        using (var reader = new StreamReader(rutaArchivo))
                        {
                            int contador = 0;
                            string linea = "";
                            while ((linea = reader.ReadLine()) != null)
                            {
                                string[] subCadenas = linea.Split(Delimitador);
                                if (subCadenas[0] != cbTorneos.Text)
                                {
                                    writer.WriteLine(linea);
                                }
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer el archivo : " + ex);
                }
                File.Delete("C:\\PROYECTO FINAL PROGRAMACION 3\\Torneos.csv");
                File.Move("C:\\PROYECTO FINAL PROGRAMACION 3\\TorneosMOD.csv", "C:\\PROYECTO FINAL PROGRAMACION 3\\Torneos.csv");
                cbTorneos.Items.Remove(cbTorneos.Text);
                MessageBox.Show("El TORNEO ha sido ELIMINADO exitosamente!");
            }
        }

        private void btnElimnarPartido_Click(object sender, EventArgs e)
        {
            if (cbEquiposLocales.Text == "" || cbEquiposVisitantes.Text == "")
                MessageBox.Show("Debes realizar una busqueda de PARTIDOS primero!");
            else
            {
                NodoLista nodoListaTemp = (NodoLista)TablaHashListasPartidos.Buscar(cbTorneos.Text);
                Lista ListaModificada = new Lista();
                while (nodoListaTemp != null)
                {
                    Partido temp = (Partido)nodoListaTemp.Dato;
                    if (cbTorneos.Text == temp.Torneo && cbEquiposLocales.Text == temp.equipoLocal && cbEquiposVisitantes.Text == temp.equipoVisitante)
                    {
                        nodoListaTemp = nodoListaTemp.Enlace;
                    }
                    if (nodoListaTemp != null)
                        ListaModificada.InsertarCabezaLista(nodoListaTemp.Dato);
                    if (nodoListaTemp == null)
                        break;
                    nodoListaTemp = nodoListaTemp.Enlace;
                }
                int posicion = TablaHashListasPartidos.HashMod(TablaHashListasPartidos.convertir(cbTorneos.Text));
                TablaHashListasPartidos.ListaHash[posicion] = ListaModificada;
            }

            string rutaArchivo = "C:\\PROYECTO FINAL PROGRAMACION 3\\Partidos.csv";
            Char Delimitador = ',';
            try
            {
                using (StreamWriter writer = new StreamWriter("C:\\PROYECTO FINAL PROGRAMACION 3\\PartidosMOD.csv"))
                {
                    using (var reader = new StreamReader(rutaArchivo))
                    {
                        int contador = 0;
                        string linea = "";
                        while ((linea = reader.ReadLine()) != null)
                        {
                            string[] subCadenas = linea.Split(Delimitador);
                            if (subCadenas[0] != cbTorneos.Text)
                            {
                                writer.WriteLine(linea);
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo : " + ex);
            }
            File.Delete("C:\\PROYECTO FINAL PROGRAMACION 3\\Partidos.csv");
            File.Move("C:\\PROYECTO FINAL PROGRAMACION 3\\PartidosMOD.csv", "C:\\PROYECTO FINAL PROGRAMACION 3\\Partidos.csv");
            cbEquiposBusqueda.Items.Remove(cbEquiposBusqueda.Text);
            LimpiarCampos();
            MessageBox.Show("El PARTIDO ha sido ELIMINADO exitosamente!");
        }
    }
}
