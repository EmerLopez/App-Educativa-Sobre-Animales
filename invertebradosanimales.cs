using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace App_Educativa_Sobre_Animales
{
    public partial class invertebradosanimales : Form
    {
        public string cadena_conexion = "server=Localhost;user id=wzadmins; password=12345;database=wonderzoo";

        public invertebradosanimales()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            if (txtnombre.Text == "mariquitas")
            {
                pmariquitas.Visible = true;
                pabeja.Visible = false;
                pmedusas.Visible = false;
                pestrella.Visible = false;
                porugas.Visible = false;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                myConnection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = myConnection;
                comando.CommandText = ("select * from invertebrados Where nombre = '" + txtbuscar.Text + "'");
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {
                    txtnombre.Text = leer["nombre"].ToString();
                    txtpeso.Text = leer["peso"].ToString();
                    txtalimentacion.Text = leer["alimentacion"].ToString();
                    txthabitat.Text = leer["habitat"].ToString();
                    txtcomportamiento.Text = leer["comportamiento"].ToString();
                }
                else
                {
                    MessageBox.Show("No fue posible encontrar el animal ingresado", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                myConnection.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Campo de busqueda está vacío", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //throw;
            }
            if(txtnombre.Text == "mariquitas")
            {
                pmariquitas.Visible = true;
                pabeja.Visible = false;
                pmedusas.Visible = false;
                pestrella.Visible = false;
                porugas.Visible = false;
            }
            if (txtnombre.Text == "abeja")
            {
                pmariquitas.Visible = false;
                pabeja.Visible = true;
                pmedusas.Visible = false;
                pestrella.Visible = false;
                porugas.Visible = false;
            }
            if (txtnombre.Text == "medusas")
            {
                pmariquitas.Visible = false;
                pabeja.Visible = false;
                pmedusas.Visible = true;
                pestrella.Visible = false;
                porugas.Visible = false;
            }
            if (txtnombre.Text == "estrella de mar")
            {
                pmariquitas.Visible = false;
                pabeja.Visible = false;
                pmedusas.Visible = false;
                pestrella.Visible = true;
                porugas.Visible = false;
            }
            if (txtnombre.Text == "orugas")
            {
                pmariquitas.Visible = false;
                pabeja.Visible = false;
                pmedusas.Visible = false;
                pestrella.Visible = false;
                porugas.Visible = true;
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.invertebradosBindingSource.MoveFirst();
            if (txtnombre.Text == "mariquitas")
            {
                pmariquitas.Visible = true;
                pabeja.Visible = false;
                pmedusas.Visible = false;
                pestrella.Visible = false;
                porugas.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.invertebradosBindingSource.MovePrevious();
            if (txtnombre.Text == "mariquitas")
            {
                pmariquitas.Visible = true;
                pabeja.Visible = false;
                pmedusas.Visible = false;
                pestrella.Visible = false;
                porugas.Visible = false;
            }
            if (txtnombre.Text == "abeja")
            {
                pmariquitas.Visible = false;
                pabeja.Visible = true;
                pmedusas.Visible = false;
                pestrella.Visible = false;
                porugas.Visible = false;
            }
            if (txtnombre.Text == "medusas")
            {
                pmariquitas.Visible = false;
                pabeja.Visible = false;
                pmedusas.Visible = true;
                pestrella.Visible = false;
                porugas.Visible = false;
            }
            if (txtnombre.Text == "estrella de mar")
            {
                pmariquitas.Visible = false;
                pabeja.Visible = false;
                pmedusas.Visible = false;
                pestrella.Visible = true;
                porugas.Visible = false;
            }
            if (txtnombre.Text == "orugas")
            {
                pmariquitas.Visible = false;
                pabeja.Visible = false;
                pmedusas.Visible = false;
                pestrella.Visible = false;
                porugas.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.invertebradosBindingSource.MoveNext();
            if (txtnombre.Text == "mariquitas")
            {
                pmariquitas.Visible = true;
                pabeja.Visible = false;
                pmedusas.Visible = false;
                pestrella.Visible = false;
                porugas.Visible = false;
            }
            if (txtnombre.Text == "abeja")
            {
                pmariquitas.Visible = false;
                pabeja.Visible = true;
                pmedusas.Visible = false;
                pestrella.Visible = false;
                porugas.Visible = false;
            }
            if (txtnombre.Text == "medusas")
            {
                pmariquitas.Visible = false;
                pabeja.Visible = false;
                pmedusas.Visible = true;
                pestrella.Visible = false;
                porugas.Visible = false;
            }
            if (txtnombre.Text == "estrella de mar")
            {
                pmariquitas.Visible = false;
                pabeja.Visible = false;
                pmedusas.Visible = false;
                pestrella.Visible = true;
                porugas.Visible = false;
            }
            if (txtnombre.Text == "orugas")
            {
                pmariquitas.Visible = false;
                pabeja.Visible = false;
                pmedusas.Visible = false;
                pestrella.Visible = false;
                porugas.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.invertebradosBindingSource.MoveLast();
            if (txtnombre.Text == "orugas")
            {
                pmariquitas.Visible = false;
                pabeja.Visible = false;
                pmedusas.Visible = false;
                pestrella.Visible = false;
                porugas.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void porugas_Click(object sender, EventArgs e)
        {

        }
    }
}
