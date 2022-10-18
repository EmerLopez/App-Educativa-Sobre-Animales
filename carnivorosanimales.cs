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
    public partial class WonderZoo : Form
    {
        public string cadena_conexion = "server=localhost;user id=wzadmins;database=wonderzoo;persistsecurityinfo=True";

        public WonderZoo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'wonderzooDataSet.carnivoros' Puede moverla o quitarla según sea necesario.
            //this.carnivorosTableAdapter.Fill(this.wonderzooDataSet.carnivoros);
            pAguila.Visible = true;
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
                    MessageBox.Show("El usuario no existe", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                pAguila.Visible = true;
                pGaviota.Visible = false;
                pZorro.Visible = false;
                pTigre.Visible = false;
                pPuma.Visible = false;
            }
            if (txtnombre.Text == "gaviota")
            {
                pAguila.Visible = false;
                pGaviota.Visible = true;
                pZorro.Visible = false;
                pTigre.Visible = false;
                pPuma.Visible = false;
            }
            if (txtnombre.Text == "zorro")
            {
                pAguila.Visible = false;
                pGaviota.Visible = false;
                pZorro.Visible = true;
                pTigre.Visible = false;
                pPuma.Visible = false;
            }
            if (txtnombre.Text == "tigre")
            {
                pAguila.Visible = false;
                pGaviota.Visible = false;
                pZorro.Visible = false;
                pTigre.Visible = true;
                pPuma.Visible = false;
            }
            if (txtnombre.Text == "puma")
            {
                pAguila.Visible = false;
                pGaviota.Visible = false;
                pZorro.Visible = false;
                pTigre.Visible = false;
                pPuma.Visible = true;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.carnivorosBindingSource.MoveFirst();
            if (txtnombre.Text == "aguila")
            {
                pAguila.Visible = true;
                pGaviota.Visible = false;
                pZorro.Visible = false;
                pTigre.Visible = false;
                pPuma.Visible = false;
            }
            if (txtnombre.Text == "gaviota")
            {
                pAguila.Visible = false;
                pGaviota.Visible = true;
                pZorro.Visible = false;
                pTigre.Visible = false;
                pPuma.Visible = false;
            }
            if (txtnombre.Text == "zorro")
            {
                pAguila.Visible = false;
                pGaviota.Visible = false;
                pZorro.Visible = true;
                pTigre.Visible = false;
                pPuma.Visible = false;
            }
            if (txtnombre.Text == "tigre")
            {
                pAguila.Visible = false;
                pGaviota.Visible = false;
                pZorro.Visible = false;
                pTigre.Visible = true;
                pPuma.Visible = false;
            }
            if (txtnombre.Text == "puma")
            {
                pAguila.Visible = false;
                pGaviota.Visible = false;
                pZorro.Visible = false;
                pTigre.Visible = false;
                pPuma.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.carnivorosBindingSource.MovePrevious();
            if (txtnombre.Text == "aguila")
            {
                pAguila.Visible = true;
                pGaviota.Visible = false;
                pZorro.Visible = false;
                pTigre.Visible = false;
                pPuma.Visible = false;
            }
            if (txtnombre.Text == "gaviota")
            {
                pAguila.Visible = false;
                pGaviota.Visible = true;
                pZorro.Visible = false;
                pTigre.Visible = false;
                pPuma.Visible = false;
            }
            if (txtnombre.Text == "zorro")
            {
                pAguila.Visible = false;
                pGaviota.Visible = false;
                pZorro.Visible = true;
                pTigre.Visible = false;
                pPuma.Visible = false;
            }
            if (txtnombre.Text == "tigre")
            {
                pAguila.Visible = false;
                pGaviota.Visible = false;
                pZorro.Visible = false;
                pTigre.Visible = true;
                pPuma.Visible = false;
            }
            if (txtnombre.Text == "puma")
            {
                pAguila.Visible = false;
                pGaviota.Visible = false;
                pZorro.Visible = false;
                pTigre.Visible = false;
                pPuma.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.carnivorosBindingSource.MoveNext();
            if (txtnombre.Text == "aguila")
            {
                pAguila.Visible = true;
                pGaviota.Visible = false;
                pZorro.Visible = false;
                pTigre.Visible = false;
                pPuma.Visible = false;
            }
            if (txtnombre.Text == "gaviota")
            {
                pAguila.Visible = false;
                pGaviota.Visible = true;
                pZorro.Visible = false;
                pTigre.Visible = false;
                pPuma.Visible = false;
            }
            if (txtnombre.Text == "zorro")
            {
                pAguila.Visible = false;
                pGaviota.Visible = false;
                pZorro.Visible = true;
                pTigre.Visible = false;
                pPuma.Visible = false;
            }
            if (txtnombre.Text == "tigre")
            {
                pAguila.Visible = false;
                pGaviota.Visible = false;
                pZorro.Visible = false;
                pTigre.Visible = true;
                pPuma.Visible = false;
            }
            if (txtnombre.Text == "puma")
            {
                pAguila.Visible = false;
                pGaviota.Visible = false;
                pZorro.Visible = false;
                pTigre.Visible = false;
                pPuma.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.carnivorosBindingSource.MoveLast();
            if (txtnombre.Text == "aguila")
            {
                pAguila.Visible = true;
                pGaviota.Visible = false;
                pZorro.Visible = false;
                pTigre.Visible = false;
                pPuma.Visible = false;
            }
            if (txtnombre.Text == "gaviota")
            {
                pAguila.Visible = false;
                pGaviota.Visible = true;
                pZorro.Visible = false;
                pTigre.Visible = false;
                pPuma.Visible = false;
            }
            if (txtnombre.Text == "zorro")
            {
                pAguila.Visible = false;
                pGaviota.Visible = false;
                pZorro.Visible = true;
                pTigre.Visible = false;
                pPuma.Visible = false;
            }
            if (txtnombre.Text == "tigre")
            {
                pAguila.Visible = false;
                pGaviota.Visible = false;
                pZorro.Visible = false;
                pTigre.Visible = true;
                pPuma.Visible = false;
            }
            if (txtnombre.Text == "puma")
            {
                pAguila.Visible = false;
                pGaviota.Visible = false;
                pZorro.Visible = false;
                pTigre.Visible = false;
                pPuma.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
