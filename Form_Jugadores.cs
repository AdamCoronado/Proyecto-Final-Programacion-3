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
    public partial class Form_Jugadores : Form
    {
        ArbolAVL arbolAVLEquipos = new ArbolAVL(); //Estructura que almacena todos los equipos para el uso de este formulario.
        Lista listaJugadores = new Lista();
        public Form_Jugadores()
        {
            InitializeComponent();
        }

        private void Form_Jugadores_Load(object sender, EventArgs e)
        {
            //Ruta actual del archivo de Equipos que se cargara.
            string rutaArchivo = "C:\\PROYECTO FINAL PROGRAMACION 3\\Equipos.csv";
            Char Delimitador = ',';
            try
            {
                using (var reader = new StreamReader(rutaArchivo))
                {
                    int contador = 0;
                    string linea = "";
                    while ((linea = reader.ReadLine()) != null)
                    {
                        if (contador == 0)
                            contador++;
                        else
                        {
                            string[] subCadenas = linea.Split(Delimitador);
                            subCadenas[8] = subCadenas[8].Replace(",", "");
                            arbolAVLEquipos.insertar(new Equipo(subCadenas[0], subCadenas[1], subCadenas[2], Convert.ToInt32(subCadenas[3]), Convert.ToInt32(subCadenas[4]), Convert.ToInt32(subCadenas[5]), Convert.ToInt32(subCadenas[6]), Convert.ToInt32(subCadenas[7]), Convert.ToInt32(subCadenas[8])));
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo : " + ex);
            }

            // En el siguiente proceso se cargaran todos los jugadores en una Lista Enlazada
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

            //Se cargan los todos nombres de los equipos en la combo box cbBuscar.
            actualizarComboBox();

            //Deshabilitamos botones Modificar y Eliminar Equipo hasta que se haya realizado una Busqueda.
            btnModJugador.Enabled = false;
            btnEliminarJugador.Enabled = false;
        }

        private void LimpiarCampos()
        {
            txtbNombreJ.Text = "";
            txtbFechaNacJ.Text = "";
            txtbEdadJ.Text = "";
            txtbPosicionJ.Text = "";
            txtbMinJugadosJ.Text = "";
            txtbGolesMarcadosJ.Text = "";
            txtbPenalesFallados.Text = "";
            txtbTarjetasAmarillas.Text = "";
            txtbTarjetasRojas.Text = "";
            txtbPasesComplJ.Text = "";
            txtbAsistenciasJ.Text = "";
            txtbGolesXPenalJ.Text = "";
            cbBuscarJugador.Text = "";
            txtbNacionalidadJ.Text = "";
            cbClub.Text = "";
            cbdClubBusqueda.Text = "";
        }
        private void actualizarComboBox()
        {
            cbBuscarJugador.Items.Clear();
            cbdClubBusqueda.Items.Clear();
            cbClub.Items.Clear();
            //Actualiza la lista de Equipos Disponibles en la Busqueda e informacion
            string NombresEquipos = ArbolAVL.preorden(arbolAVLEquipos.raizArbol());
            string[] subNombresEquipos = NombresEquipos.Split(',');
            for (int i = 0; i <= subNombresEquipos.Length; i = i + 9)
            {
                cbClub.Items.Add(subNombresEquipos[i]);
                cbdClubBusqueda.Items.Add(subNombresEquipos[i]);
            }
            //Actualizar lista de Jugadores en la Busqueda
            NodoLista temp = listaJugadores.Primero;
            string tempClub = cbdClubBusqueda.Text;
            while (temp != null)
            {
                Jugador JugadorTemp = (Jugador)temp.Dato;
                cbBuscarJugador.Items.Add(JugadorTemp.nombre);
                temp = temp.Enlace;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            NodoLista nodoTemp = listaJugadores.Primero;
            var delimitador = ',';
            using (StreamWriter writer = new StreamWriter("C:\\PROYECTO FINAL PROGRAMACION 3\\Jugadores.csv"))
            {
                while (nodoTemp != null)
                {
                    Jugador JugadorTemp = (Jugador)nodoTemp.Dato;
                    string cadena = JugadorTemp.nombre + delimitador + Convert.ToString(JugadorTemp.edad) + delimitador + JugadorTemp.cumpleaños + delimitador + JugadorTemp.nacionalidad + delimitador + JugadorTemp.posicion + delimitador + JugadorTemp.clubActual + delimitador + Convert.ToString(JugadorTemp.totalMinJugados) + delimitador + Convert.ToString(JugadorTemp.totalAsistencias) + delimitador + Convert.ToString(JugadorTemp.totalPasesCompletados) + delimitador + Convert.ToString(JugadorTemp.totalGoles) + delimitador + Convert.ToString(JugadorTemp.golesXPenal) + delimitador + Convert.ToString(JugadorTemp.penalesFallados) + delimitador + Convert.ToString(JugadorTemp.totalTarjetasAmarillas) + delimitador + Convert.ToString(JugadorTemp.totalTarjetasRojas);
                    writer.WriteLine(cadena);
                    nodoTemp = nodoTemp.Enlace;
                }
            }

            this.Close();
            Principal form_P = new Principal();
            form_P.Show();


            //string rutaArchivo = "C:\\PROYECTO FINAL PROGRAMACION 3\\Premier_jugadores.csv";
            //Char Delimitador = ',';
            //try
            //{
            //    using (var reader = new StreamReader(rutaArchivo))
            //    {
            //        int contador = 0;
            //        string linea = "";
            //        using (StreamWriter writer = new StreamWriter("C:\\PROYECTO FINAL PROGRAMACION 3\\Jugadores.csv"))
            //        {
            //            while ((linea = reader.ReadLine()) != null)
            //            {
            //                if (contador == 0)
            //                    contador++;
            //                else
            //                {
            //                    string[] subCadenas = linea.Split(Delimitador);
            //                    string cadena2 = subCadenas[0] + Delimitador + subCadenas[1] + Delimitador + subCadenas[3] + Delimitador + subCadenas[11] + Delimitador + subCadenas[6] + Delimitador + subCadenas[7] + Delimitador + subCadenas[8] + Delimitador + subCadenas[18] + Delimitador + subCadenas[55] + Delimitador + subCadenas[15] + Delimitador + subCadenas[21] + Delimitador + subCadenas[22] + Delimitador + subCadenas[29] + Delimitador + subCadenas[30];
            //                    writer.WriteLine(cadena2);
            //                }
            //            }
            //        }

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al leer el archivo : " + ex);
            //}



        }

        private void cbdClubBusqueda_TextChanged(object sender, EventArgs e)
        {
            cbBuscarJugador.Items.Clear();
            NodoLista temp = listaJugadores.Primero;
            string tempClub = cbdClubBusqueda.Text;
            while (temp != null)
            {
                Jugador JugadorTemp = (Jugador)temp.Dato;
                if (JugadorTemp.clubActual == tempClub)
                {
                    cbBuscarJugador.Items.Add(JugadorTemp.nombre);
                }
                if (tempClub == "")
                    cbBuscarJugador.Items.Add(JugadorTemp.nombre);
                temp = temp.Enlace;
            }
        }

        private void btnBuscarJugador_Click(object sender, EventArgs e)
        {
            NodoLista temp = listaJugadores.Primero;
            string tempNombre = cbBuscarJugador.Text;
            while (temp != null)
            {
                Jugador JugadorTemp = (Jugador)temp.Dato;
                if (JugadorTemp.nombre == tempNombre)
                {
                    txtbNombreJ.Text = JugadorTemp.nombre;
                    txtbFechaNacJ.Text = JugadorTemp.cumpleaños;
                    txtbEdadJ.Text = Convert.ToString(JugadorTemp.edad);
                    cbClub.Text = JugadorTemp.clubActual;
                    txtbPosicionJ.Text = JugadorTemp.posicion;
                    txtbMinJugadosJ.Text = Convert.ToString(JugadorTemp.totalMinJugados);
                    txtbGolesMarcadosJ.Text = Convert.ToString(JugadorTemp.totalGoles);
                    txtbPenalesFallados.Text = Convert.ToString(JugadorTemp.penalesFallados);
                    txtbTarjetasAmarillas.Text = Convert.ToString(JugadorTemp.totalTarjetasAmarillas);
                    txtbTarjetasRojas.Text = Convert.ToString(JugadorTemp.totalTarjetasRojas);
                    txtbPasesComplJ.Text = Convert.ToString(JugadorTemp.totalPasesCompletados);
                    txtbAsistenciasJ.Text = Convert.ToString(JugadorTemp.totalAsistencias);
                    txtbGolesXPenalJ.Text = Convert.ToString(JugadorTemp.golesXPenal);
                    txtbNacionalidadJ.Text = JugadorTemp.nacionalidad;
                }
                temp = temp.Enlace;
            }

            btnModJugador.Enabled = true;
            btnEliminarJugador.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnNuevoJugador_Click(object sender, EventArgs e)
        {
            if (txtbNombreJ.Text == "" || txtbFechaNacJ.Text == "" || txtbEdadJ.Text == "" || txtbPosicionJ.Text == "" || txtbMinJugadosJ.Text == "" || txtbGolesMarcadosJ.Text == "" || txtbPenalesFallados.Text == "" || txtbTarjetasAmarillas.Text == "" || txtbTarjetasRojas.Text == "" || txtbPasesComplJ.Text == "" || txtbAsistenciasJ.Text == "" || txtbGolesXPenalJ.Text == "" || txtbNacionalidadJ.Text == "")
            {
                MessageBox.Show("Por favor revisa todos los camos, es necesario llenarlos todos para crear un nuevo Jugador.");
            }
            else
            {
                Jugador nuevo = new Jugador(txtbNombreJ.Text, Convert.ToInt32(txtbEdadJ.Text), txtbFechaNacJ.Text, txtbNacionalidadJ.Text, txtbPosicionJ.Text, cbClub.Text, Convert.ToInt32(txtbMinJugadosJ.Text), Convert.ToInt32(txtbAsistenciasJ.Text), Convert.ToInt32(txtbPasesComplJ.Text), Convert.ToInt32(txtbGolesMarcadosJ.Text), Convert.ToInt32(txtbGolesXPenalJ.Text), Convert.ToInt32(txtbPenalesFallados.Text), Convert.ToInt32(txtbTarjetasAmarillas.Text), Convert.ToInt32(txtbTarjetasRojas.Text));
                listaJugadores.InsertarCabezaLista(nuevo);
                LimpiarCampos();
                actualizarComboBox();
                MessageBox.Show("El nuevo JUGADOR ha sido creado exitosamente!");
            }
        }

        private void btnModJugador_Click(object sender, EventArgs e)
        {
            Jugador jugadorModificado = new Jugador(txtbNombreJ.Text, Convert.ToInt32(txtbEdadJ.Text), txtbFechaNacJ.Text, txtbNacionalidadJ.Text, txtbPosicionJ.Text, cbClub.Text, Convert.ToInt32(txtbMinJugadosJ.Text), Convert.ToInt32(txtbAsistenciasJ.Text), Convert.ToInt32(txtbPasesComplJ.Text), Convert.ToInt32(txtbGolesMarcadosJ.Text), Convert.ToInt32(txtbGolesXPenalJ.Text), Convert.ToInt32(txtbPenalesFallados.Text), Convert.ToInt32(txtbTarjetasAmarillas.Text), Convert.ToInt32(txtbTarjetasRojas.Text));
            NodoLista nodoModificado = new NodoLista(jugadorModificado);
            Lista listaModificada = new Lista();

            NodoLista nodoTemp = listaJugadores.Primero;

            while (nodoTemp != null)
            {
                Jugador tempJugador = (Jugador)nodoTemp.Dato;
                if ((cbBuscarJugador.Text == tempJugador.nombre) && (cbdClubBusqueda.Text == tempJugador.clubActual))
                {

                    nodoModificado.Enlace = nodoTemp.Enlace;
                    nodoTemp = nodoModificado;
                }
                listaModificada.InsertarCabezaLista(nodoTemp.Dato);
                nodoTemp = nodoTemp.Enlace;
            }
            listaJugadores = listaModificada;

            LimpiarCampos();
            actualizarComboBox();
            MessageBox.Show("El JUGADOR ha sido MODIFICADO exitosamente!");

        }

        private void btnEliminarJugador_Click(object sender, EventArgs e)
        {
            Lista ListaModificada = new Lista();
            NodoLista actual = listaJugadores.Primero;
            while (actual != null)
            {
                Jugador temp = (Jugador)actual.Dato;
                if (cbBuscarJugador.Text == temp.nombre && temp.clubActual == cbdClubBusqueda.Text)
                {
                    actual = actual.Enlace;
                }
                if (actual != null)
                    ListaModificada.InsertarCabezaLista(actual.Dato);
                if (actual == null)
                    break;
                actual = actual.Enlace;
            }
            listaJugadores = ListaModificada;
            LimpiarCampos();
            actualizarComboBox();
            MessageBox.Show("El JUGADOR ha sido ELIMINADO exitosamente!");
        }
    }
}
