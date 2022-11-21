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
    public partial class AnimalesAnfibios : Form
    {
        public string cadena_conexion = "server=Localhost;user id=wzadmins;password=12345;database=wonderzoo";

        public AnimalesAnfibios()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'wonderzooDataSet.anfibios' Puede moverla o quitarla según sea necesario.
            this.anfibiosTableAdapter.Fill(this.wonderzooDataSet.anfibios);


            pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.iguana5;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                myConnection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = myConnection;
                comando.CommandText = ("select * from anfibios Where nombre = '" + Combobuscar.Text + "'");
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


            if (txtnombre.Text == "iguana")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.iguana5;

            }

            if (txtnombre.Text == "tortuga")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.tortuga5;

            }

            if (txtnombre.Text == "cocodrilo")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.cocodrilo5;


            }

            if (txtnombre.Text == "serpiente")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.serpiente5;

            }

            if (txtnombre.Text == "rana")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.rana5;

            }

        }


            private void button1_Click(object sender, EventArgs e)
        {
            this.anfibiosBindingSource.MoveFirst();
            if (txtnombre.Text == "iguana")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.iguana5;

            }

            if (txtnombre.Text == "tortuga")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.tortuga5;

            }

            if (txtnombre.Text == "cocodrilo")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.cocodrilo5;


            }

            if (txtnombre.Text == "serpiente")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.serpiente5;

            }

            if (txtnombre.Text == "rana")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.rana5;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.anfibiosBindingSource.MovePrevious();
            if (txtnombre.Text == "iguana")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.iguana5;

            }

            if (txtnombre.Text == "tortuga")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.tortuga5;

            }

            if (txtnombre.Text == "cocodrilo")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.cocodrilo5;


            }

            if (txtnombre.Text == "serpiente")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.serpiente5;

            }

            if (txtnombre.Text == "rana")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.rana5;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.anfibiosBindingSource.MoveNext();
            if (txtnombre.Text == "iguana")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.iguana5;
               
            }

            if (txtnombre.Text == "tortuga")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.tortuga5;
               
            }

            if (txtnombre.Text == "cocodrilo")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.cocodrilo5;
                

            }

            if (txtnombre.Text == "serpiente")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.serpiente5;
                
            }

            if (txtnombre.Text == "rana")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.rana5;
               
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.anfibiosBindingSource.MoveLast();
            if (txtnombre.Text == "iguana")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.iguana5;
                
            }

            if (txtnombre.Text == "tortuga")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.tortuga5;
                
            }

            if (txtnombre.Text == "cocodrilo")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.cocodrilo5;
                

            }

            if (txtnombre.Text == "serpiente")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.serpiente5;
               
            }

            if (txtnombre.Text == "rana")
            {
                pbimage.Image = App_Educativa_Sobre_Animales.Properties.Resources.rana5;
               
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pcaballo_Click(object sender, EventArgs e)
        {

        }

        private void ptortuga_Click(object sender, EventArgs e)
        {

        }

        private void pcoco_Click(object sender, EventArgs e)
        {

        }
    }
}
