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
    public partial class Form_TorneosNuevo : Form
    {
        ArbolAVL arbolAVLEquipos = new ArbolAVL(); //Estructura que almacena todos los equipos para el uso de este formulario.
        Lista listaGlobalTorneos = new Lista();
        Lista listaEquiposAgregados = new Lista();
        int contadorEquipos = 0;
        public Form_TorneosNuevo()
        {
            InitializeComponent();
        }

        private void Form_TorneosNuevo_Load(object sender, EventArgs e)
        {
            //Se leeran los datos del archivo de Equipos y se almaneceran en una arbolAVL
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
                            string[] subCadenas = linea.Split(Delimitador);
                            subCadenas[8] = subCadenas[8].Replace(",", "");
                            arbolAVLEquipos.insertar(new Equipo(subCadenas[0], subCadenas[1], subCadenas[2], Convert.ToInt32(subCadenas[3]), Convert.ToInt32(subCadenas[4]), Convert.ToInt32(subCadenas[5]), Convert.ToInt32(subCadenas[6]), Convert.ToInt32(subCadenas[7]), Convert.ToInt32(subCadenas[8])));

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo : " + ex);
            }           

            actualizarComboBox();
        }

        private void actualizarComboBox()
        {
            cbEquiposDisponibles.Items.Clear();
            //Actualiza la lista de Equipos Disponibles en combo box cbEquipos Disponibles
            string NombresEquipos = ArbolAVL.preorden(arbolAVLEquipos.raizArbol());
            string[] subNombresEquipos = NombresEquipos.Split(',');
            for (int i = 0; i <= subNombresEquipos.Length; i = i + 9)
            {
                cbEquiposDisponibles.Items.Add(subNombresEquipos[i]);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            NodoLista nodoTemp = listaGlobalTorneos.Primero;
            var delimitador = ',';
            using (StreamWriter writer = new StreamWriter("C:\\PROYECTO FINAL PROGRAMACION 3\\Torneos.csv",true))
            {
                while (nodoTemp != null)
                {
                    Torneo torneoTemp = (Torneo)nodoTemp.Dato;
                    string cadena = torneoTemp.nombre + delimitador + torneoTemp.fechaInicio + delimitador + torneoTemp.fechaFin + delimitador + torneoTemp.localizacion + delimitador + torneoTemp.estado + delimitador + torneoTemp.contadorEquipos;
                    NodoLista nodoTempEquipos = torneoTemp.listaEquipos.Primero;
                    string cadena2 = "";
                    while (nodoTempEquipos != null)
                    {
                        string equipoTemp = (string)nodoTempEquipos.Dato;

                        cadena2 = cadena2 + delimitador + equipoTemp;
                        nodoTempEquipos = nodoTempEquipos.Enlace;
                    }
                    cadena = cadena + cadena2;
                    writer.WriteLine(cadena);
                    nodoTemp = nodoTemp.Enlace;
                }
            }

            this.Close();
            Form_Torneos f_menuTorneos = new Form_Torneos();
            f_menuTorneos.Show();
        }

        private void btnCrearTorneo_Click(object sender, EventArgs e)
        {
            if (txtbNombreTorneo.Text == "" || txtbFechaFinal.Text == "" || txtbFechaFinal.Text == "" || txtbLocalizacion.Text == "")
            {
                MessageBox.Show("Debes de llenar todos los campos para CREAR el torneo!!!");
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Deseas continuar? Si continuas, no podras modificar los datos del TORNEO", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Torneo nuevoTorneo = new Torneo();
                    nuevoTorneo.nombre = txtbNombreTorneo.Text;
                    nuevoTorneo.localizacion = txtbLocalizacion.Text;
                    nuevoTorneo.fechaInicio = txtbFechaInicio.Text;
                    nuevoTorneo.fechaFin = txtbFechaFinal.Text;
                    nuevoTorneo.contadorEquipos = contadorEquipos;
                    nuevoTorneo.estado = "Activo";
                    nuevoTorneo.listaEquipos = listaEquiposAgregados;
                    nuevoTorneo.CantidadPartidos = contadorEquipos * (contadorEquipos - 1);

                    listaGlobalTorneos.InsertarCabezaLista(nuevoTorneo);
                    limpiarCampos();
                    MessageBox.Show("El torneo ha sido CREADO exitosamente!!!");
                }
            }
        }

        private void limpiarCampos()
        {
            txtbNombreTorneo.Text = "";
            contadorEquipos = 0;
            txtbFechaFinal.Text = "";
            txtbFechaInicio.Text = "";
            txtbLocalizacion.Text = "";
            lbEquiposAgregados.Items.Clear();
            actualizarComboBox();
            btnCrearTorneo.Enabled = false;
            listaEquiposAgregados = new Lista();
        }

        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            if (cbEquiposDisponibles.Text == "")
                MessageBox.Show("Por favor selecciona un EQUIPO al torneo para continuar.");
            else
            {
                listaEquiposAgregados.InsertarCabezaLista(cbEquiposDisponibles.Text);
                lbEquiposAgregados.Items.Add(cbEquiposDisponibles.Text);
                cbEquiposDisponibles.Items.Remove(cbEquiposDisponibles.Text);
                contadorEquipos++;
                btnEliminarEquipo.Enabled = true;
                btnCrearTorneo.Enabled = true;

                if (contadorEquipos <= 1)
                    btnCrearTorneo.Enabled = false;
                else
                    btnCrearTorneo.Enabled = true;
            }
        }

        private void btnEliminarEquipo_Click(object sender, EventArgs e)
        {
            Lista ListaModificada = new Lista();
            NodoLista actual = listaEquiposAgregados.Primero;
            if (lbEquiposAgregados.SelectedItem != null)
            {
                while (actual != null)
                {
                    string temp = (string)actual.Dato;
                    if (temp == Convert.ToString(lbEquiposAgregados.SelectedItem))
                    {
                        actual = actual.Enlace;
                    }
                    if (actual != null)
                        ListaModificada.InsertarCabezaLista(actual.Dato);
                    if (actual == null)
                        break;
                    actual = actual.Enlace;
                }
                listaEquiposAgregados = ListaModificada;

                cbEquiposDisponibles.Items.Add(Convert.ToString(lbEquiposAgregados.SelectedItem));
                lbEquiposAgregados.Items.Remove(lbEquiposAgregados.SelectedItem);
                contadorEquipos--;

                if (listaEquiposAgregados.Primero == null)
                    MessageBox.Show("Debes agregar equipos a tu torneo para poder crearlo!!!");
                if (contadorEquipos <= 1)
                {
                    btnCrearTorneo.Enabled = false;
                }
            }
            else
                MessageBox.Show("Debes SELECCIONAR un equipo para poder eliminarlo.");

            if (lbEquiposAgregados.Items.Count==0)
            {
                btnEliminarEquipo.Enabled = false;
                actualizarComboBox();
            }              

        }
    }
}
