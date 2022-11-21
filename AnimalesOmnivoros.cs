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
    public partial class AnimalesOmnivoros : Form
    {
        public string cadena_conexion = "server=Localhost;user id=wzadmins;password=12345;database=wonderzoo";

        public AnimalesOmnivoros()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'wonderzooDataSet.omnivoros' Puede moverla o quitarla según sea necesario.
            this.omnivorosTableAdapter.Fill(this.wonderzooDataSet.omnivoros);



            pgorila.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                myConnection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = myConnection;
                comando.CommandText = ("select * from omnivoros Where nombre = '" + txtbuscar.Text + "'");
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
            if (txtnombre.Text == "gorila")
            {
                ptucan.Visible = false;
                pzorro.Visible = false;
                perizo.Visible = false;
                pmapache.Visible = false;
                pgorila.Visible = true;
            }
            if (txtnombre.Text == "mapache")
            {
                ptucan.Visible = false;
                pzorro.Visible = false;
                perizo.Visible = false;
                pgorila.Visible = false;
                pmapache.Visible = true;
            }
            if (txtnombre.Text == "erizo")
            {
                ptucan.Visible = false;
                pzorro.Visible = false;
                pgorila.Visible = false;
                pmapache.Visible = false;
                perizo.Visible = true;
            }
            if (txtnombre.Text == "zorro")
            {
                ptucan.Visible = false;
                pgorila.Visible = false;
                perizo.Visible = false;
                pmapache.Visible = false;
                pzorro.Visible = true;
            }
            if (txtnombre.Text == "tucan")
            {
                pgorila.Visible = false;
                pzorro.Visible = false;
                perizo.Visible = false;
                pmapache.Visible = false;
                ptucan.Visible = true;
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.omnivorosBindingSource.MoveFirst();
            if (txtnombre.Text == "gorila")
            {
                ptucan.Visible = false;
                pzorro.Visible = false;
                perizo.Visible = false;
                pmapache.Visible = false;
                pgorila.Visible = true;
            }
            if (txtnombre.Text == "mapache")
            {
                ptucan.Visible = false;
                pzorro.Visible = false;
                perizo.Visible = false;
                pgorila.Visible = false;
                pmapache.Visible = true;
            }
            if (txtnombre.Text == "erizo")
            {
                ptucan.Visible = false;
                pzorro.Visible = false;
                pgorila.Visible = false;
                pmapache.Visible = false;
                perizo.Visible = true;
            }
            if (txtnombre.Text == "zorro")
            {
                ptucan.Visible = false;
                pgorila.Visible = false;
                perizo.Visible = false;
                pmapache.Visible = false;
                pzorro.Visible = true;
            }
            if (txtnombre.Text == "tucan")
            {
                pgorila.Visible = false;
                pzorro.Visible = false;
                perizo.Visible = false;
                pmapache.Visible = false;
                ptucan.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.omnivorosBindingSource.MovePrevious();
            if (txtnombre.Text == "gorila")
            {
                ptucan.Visible = false;
                pzorro.Visible = false;
                perizo.Visible = false;
                pmapache.Visible = false;
                pgorila.Visible = true;
            }
            if (txtnombre.Text == "mapache")
            {
                ptucan.Visible = false;
                pzorro.Visible = false;
                perizo.Visible = false;
                pgorila.Visible = false;
                pmapache.Visible = true;
            }
            if (txtnombre.Text == "erizo")
            {
                ptucan.Visible = false;
                pzorro.Visible = false;
                pgorila.Visible = false;
                pmapache.Visible = false;
                perizo.Visible = true;
            }
            if (txtnombre.Text == "zorro")
            {
                ptucan.Visible = false;
                pgorila.Visible = false;
                perizo.Visible = false;
                pmapache.Visible = false;
                pzorro.Visible = true;
            }
            if (txtnombre.Text == "tucan")
            {
                pgorila.Visible = false;
                pzorro.Visible = false;
                perizo.Visible = false;
                pmapache.Visible = false;
                ptucan.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.omnivorosBindingSource.MoveNext();
            if (txtnombre.Text == "gorila")
            {
                ptucan.Visible = false;
                pzorro.Visible = false;
                perizo.Visible = false;
                pmapache.Visible = false;
                pgorila.Visible = true;
            }
            if (txtnombre.Text == "mapache")
            {
                ptucan.Visible = false;
                pzorro.Visible = false;
                perizo.Visible = false;
                pgorila.Visible = false;
                pmapache.Visible = true;
            }
            if (txtnombre.Text == "erizo")
            {
                ptucan.Visible = false;
                pzorro.Visible = false;
                pgorila.Visible = false;
                pmapache.Visible = false;
                perizo.Visible = true;
            }
            if (txtnombre.Text == "zorro")
            {
                ptucan.Visible = false;
                pgorila.Visible = false;
                perizo.Visible = false;
                pmapache.Visible = false;
                pzorro.Visible = true;
            }
            if (txtnombre.Text == "tucan")
            {
                pgorila.Visible = false;
                pzorro.Visible = false;
                perizo.Visible = false;
                pmapache.Visible = false;
                ptucan.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.omnivorosBindingSource.MoveLast();
            if (txtnombre.Text == "gorila")
            {
                ptucan.Visible = false;
                pzorro.Visible = false;
                perizo.Visible = false;
                pmapache.Visible = false;
                pgorila.Visible = true;
            }
            if (txtnombre.Text == "mapache")
            {
                ptucan.Visible = false;
                pzorro.Visible = false;
                perizo.Visible = false;
                pgorila.Visible = false;
                pmapache.Visible = true;
            }
            if (txtnombre.Text == "erizo")
            {
                ptucan.Visible = false;
                pzorro.Visible = false;
                pgorila.Visible = false;
                pmapache.Visible = false;
                perizo.Visible = true;
            }
            if (txtnombre.Text == "zorro")
            {
                ptucan.Visible = false;
                pgorila.Visible = false;
                perizo.Visible = false;
                pmapache.Visible = false;
                pzorro.Visible = true;
            }
            if (txtnombre.Text == "tucan")
            {
                pgorila.Visible = false;
                pzorro.Visible = false;
                perizo.Visible = false;
                pmapache.Visible = false;
                ptucan.Visible = true;
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
