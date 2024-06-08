using EstructuraDeClases.Arboles;
using FutBol_Torneos_Management.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutBol_Torneos_Management
{
    public partial class Form_Equipos : Form
    {
        ArbolAVL arbolAVLEquipos = new ArbolAVL(); //Estructura que almacena todos los equipos para el uso de este formulario.
        Principal form_Principal = new Principal();//Creacion de un formulario Principal
        public Form_Equipos()
        {
            InitializeComponent();
        }

        private void Form_Equipos_Load(object sender, EventArgs e)
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

            //Se cargan los todos nombres de los equipos en la combo box cbBuscar.
            actualizarComboBox();

            //Deshabilitamos botones Modificar y Eliminar Equipo hasta que se haya realizado una Busqueda.
            btnModificarEquipo.Enabled = false;
            btnEliminarEquipo.Enabled = false;
        }

        private void btnBuscarEquipo_Click(object sender, EventArgs e)
        {
            Equipo EquipoTemp = new Equipo();
            EquipoTemp.nombre = cbBuscar.Text;
            Nodo NodoTemp = arbolAVLEquipos.buscar(EquipoTemp, 1);
            EquipoTemp = (Equipo)NodoTemp.valorNodo();
            txtbNombreEquipo.Text = EquipoTemp.nombre;
            txtbEntrenador.Text = EquipoTemp.nombreEntrenador;
            txtbPaisOrigen.Text = EquipoTemp.paisOrigen;
            txtbPartidosJugados.Text = Convert.ToString(EquipoTemp.partidosJugados);
            txtbPartidosGanados.Text = Convert.ToString(EquipoTemp.partidosGanados);
            txtbPartidosPerdidos.Text = Convert.ToString(EquipoTemp.partidosPerdidos);
            txtbPartidosEmpatados.Text = Convert.ToString(EquipoTemp.partidosEmpatados);
            txtbGolesMarcados.Text = Convert.ToString(EquipoTemp.conteoTotalGolesMarcados);
            txtbGolesContra.Text = Convert.ToString(EquipoTemp.conteoTotalGolesContra);
            btnModificarEquipo.Enabled = true;
            btnEliminarEquipo.Enabled = true;
        }

        private void btnModificarEquipo_Click(object sender, EventArgs e)
        {
            bool x = VerificacionCampos();
            if (x == true)
            {
                Equipo EquipoTemp = new Equipo();
                EquipoTemp.nombre = cbBuscar.Text;
                arbolAVLEquipos.eliminar(EquipoTemp);
                Equipo nuevo = new Equipo(txtbNombreEquipo.Text, txtbPaisOrigen.Text, txtbEntrenador.Text, Convert.ToInt32(txtbPartidosJugados.Text), Convert.ToInt32(txtbPartidosGanados.Text), Convert.ToInt32(txtbPartidosEmpatados.Text), Convert.ToInt32(txtbPartidosPerdidos.Text), Convert.ToInt32(txtbGolesMarcados.Text), Convert.ToInt32(txtbGolesContra.Text));
                arbolAVLEquipos.insertar(nuevo);
                LimpiarCampos();
                actualizarComboBox();
                MessageBox.Show("El Equipo Buscado ha sido MODIFICADO exitosamente!");
            }
            else
                MessageBox.Show("Por favor revisa los campos para continuar, uno de ellos se encuentra vacio.");

        }

        //Procedimiento utilizado para limiar todas los datos en las TextBoxes.
        private void LimpiarCampos()
        {
            txtbNombreEquipo.Text = "";
            txtbEntrenador.Text = "";
            txtbPaisOrigen.Text = "";
            txtbPartidosJugados.Text = "";
            txtbPartidosGanados.Text = "";
            txtbPartidosPerdidos.Text = "";
            txtbPartidosEmpatados.Text = "";
            txtbGolesMarcados.Text = "";
            txtbGolesContra.Text = "";
            cbBuscar.Items.Clear();
        }
        //Procedimiento utilzado para actualizar los datos en el ComboBox que se usa para buscar Equipos.
        private void actualizarComboBox()
        {
            string NombresEquipos = ArbolAVL.preorden(arbolAVLEquipos.raizArbol());
            string[] subNombresEquipos = NombresEquipos.Split(',');
            for (int i = 0; i <= subNombresEquipos.Length; i = i + 9)
            { cbBuscar.Items.Add(subNombresEquipos[i]); }
        }

        private void btnEliminarEquipo_Click(object sender, EventArgs e)
        {
            bool x = VerificacionCampos();
            if (x == true)
            {
                Equipo EquipoTemp = new Equipo();
                EquipoTemp.nombre = cbBuscar.Text;
                arbolAVLEquipos.eliminar(EquipoTemp);
                LimpiarCampos();
                actualizarComboBox();
                MessageBox.Show("El Equipo Buscado ha sido ELIMINADO exitosamente!");
            }
            else
                MessageBox.Show("Por favor haz las busqueda de nuevo.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadena = "";
            string NombresEquipos = ArbolAVL.preorden(arbolAVLEquipos.raizArbol());
            var Delimitador = ',';
            string[] subNombresEquipos = NombresEquipos.Split(Delimitador);
            string cadena2 = "";
            using (StreamWriter writer = new StreamWriter("C:\\PROYECTO FINAL PROGRAMACION 3\\Equipos.csv"))
            {
                for (int i = 0; i < subNombresEquipos.Length; i++)
                {

                    cadena2 = cadena2 + subNombresEquipos[i] + ",";
                    if (i != 0 && (i % 9) == 8)
                    {
                        writer.WriteLine(cadena2);
                        cadena2 = "";
                    }
                }
            }

            this.Close();
            form_Principal.Show();

            //string rutaArchivo = "C:\\PROYECTO FINAL PROGRAMACION 3\\Premier_Equipos.csv";
            //Char Delimitador = ',';
            //try
            //{
            //    using (var reader = new StreamReader(rutaArchivo))
            //    {
            //        int contador = 0;
            //        string linea = "";
            //        while ((linea = reader.ReadLine()) != null)
            //        {
            //            if (contador == 0)
            //                contador++;
            //            else
            //            {
            //                string[] subCadenas = linea.Split(Delimitador);
            //                string cadena2 = subCadenas[1] + Delimitador + subCadenas[3] + Delimitador + subCadenas[4] + Delimitador + subCadenas[8] + Delimitador + subCadenas[11] + Delimitador + subCadenas[14] + Delimitador + subCadenas[24] + Delimitador + subCadenas[25] + Delimitador + subCadenas[27];
            //                using (StreamWriter writer = new StreamWriter("C:\\PROYECTO FINAL PROGRAMACION 3\\Equipos.csv", true))
            //                {
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

        private void btnNuevoEquipo_Click(object sender, EventArgs e)
        {
            bool x = VerificacionCampos();
            if (x == true)
            {
                Equipo nuevo = new Equipo(txtbNombreEquipo.Text, txtbPaisOrigen.Text, txtbEntrenador.Text, Convert.ToInt32(txtbPartidosJugados.Text), Convert.ToInt32(txtbPartidosGanados.Text), Convert.ToInt32(txtbPartidosEmpatados.Text), Convert.ToInt32(txtbPartidosPerdidos.Text), Convert.ToInt32(txtbGolesMarcados.Text), Convert.ToInt32(txtbGolesContra.Text));
                arbolAVLEquipos.insertar(nuevo);
                LimpiarCampos();
                actualizarComboBox();
                MessageBox.Show("El Equipo Buscado ha sido CREADO exitosamente!");
            }
            else
                MessageBox.Show("Por favor revisa los campos para continuar, uno de ellos se encuentra vacio.");
        }

        public bool VerificacionCampos()
        {
            if (txtbNombreEquipo.Text == "" || txtbPaisOrigen.Text == "" || txtbEntrenador.Text == "" || txtbPartidosJugados.Text == "" || txtbPartidosGanados.Text == "" || txtbPartidosEmpatados.Text == "" || txtbPartidosPerdidos.Text == "" || txtbGolesMarcados.Text == "" || txtbGolesContra.Text == "")
            {
                return false;
            }
            else { return true; }
        }
    }
}
