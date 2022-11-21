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
    public partial class animalescarnivoros : Form
    {
        public string cadena_conexion = "server=Localhost;user id=wzadmins;password=12345;database=wonderzoo";

        public animalescarnivoros()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'wonderzooDataSet.carnivoros' Puede moverla o quitarla según sea necesario.
            this.carnivorosTableAdapter.Fill(this.wonderzooDataSet.carnivoros);
            // TODO: esta línea de código carga datos en la tabla 'wonderzooDataSet.omnivoros' Puede moverla o quitarla según sea necesario.
            // this.omnivorosTableAdapter.Fill(this.wonderzooDataSet.omnivoros);


            if (txtnombre.Text == "aguila")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.aguila5;

            }

            if (txtnombre.Text == "gaviota")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.gaviota5;

            }

            if (txtnombre.Text == "puma")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.puma5;


            }

            if (txtnombre.Text == "tigre")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.tigre5;

            }

            if (txtnombre.Text == "zorro")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.zorro5;

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
                comando.CommandText = ("select * from carnivoros Where nombre = '" + txtbuscar.Text + "'");
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
                    MessageBox.Show("No fue posible encontrar el animal ingresadote", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                myConnection.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Campo de busqueda está vacío", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //throw;
            }
            if (txtnombre.Text == "aguila")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.aguila5;

            }

            if (txtnombre.Text == "gaviota")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.gaviota5;

            }

            if (txtnombre.Text == "puma")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.puma5;


            }

            if (txtnombre.Text == "tigre")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.tigre5;

            }

            if (txtnombre.Text == "zorro")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.zorro5;

            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.carnivorosBindingSource.MoveFirst();
            if (txtnombre.Text == "aguila")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.aguila5;

            }

            if (txtnombre.Text == "gaviota")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.gaviota5;

            }

            if (txtnombre.Text == "puma")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.puma5;


            }

            if (txtnombre.Text == "tigre")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.tigre5;

            }

            if (txtnombre.Text == "zorro")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.zorro5;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.carnivorosBindingSource.MovePrevious();
            if (txtnombre.Text == "aguila")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.aguila5;

            }

            if (txtnombre.Text == "gaviota")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.gaviota5;

            }

            if (txtnombre.Text == "puma")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.puma5;


            }

            if (txtnombre.Text == "tigre")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.tigre5;

            }

            if (txtnombre.Text == "zorro")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.zorro5;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.carnivorosBindingSource.MoveNext();
            if (txtnombre.Text == "aguila")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.aguila5;

            }

            if (txtnombre.Text == "gaviota")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.gaviota5;

            }

            if (txtnombre.Text == "puma")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.puma5;


            }

            if (txtnombre.Text == "tigre")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.tigre5;

            }

            if (txtnombre.Text == "zorro")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.zorro5;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.carnivorosBindingSource.MoveLast();
            if (txtnombre.Text == "aguila")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.aguila5;

            }

            if (txtnombre.Text == "gaviota")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.gaviota5;

            }

            if (txtnombre.Text == "puma")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.puma5;


            }

            if (txtnombre.Text == "tigre")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.tigre5;

            }

            if (txtnombre.Text == "zorro")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.zorro5;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Perizo_Click(object sender, EventArgs e)
        {

        }

        private void bsalir_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
