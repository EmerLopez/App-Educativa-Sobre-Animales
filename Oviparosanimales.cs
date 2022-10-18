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
    public partial class Oviparosanimales : Form
    {
        public string cadena_conexion = "server=Localhost;user id=wzadmins;password=12345;database=wonderzoo";

        public Oviparosanimales()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            ptortuga.Visible = true;
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                myConnection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = myConnection;
                comando.CommandText = ("select * from oviparos Where nombre = '" + txtbuscar.Text + "'");
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
            if (txtnombre.Text == "pinguino")
            {
                pavestruz.Visible = false;
                ppinguinos.Visible = true;
                ppollos.Visible = false;
                ptorogoz.Visible = false;
                ptortuga.Visible = false;

            }
            if (txtnombre.Text == "gallina")
            {
                pavestruz.Visible = false;
                ppinguinos.Visible = false;
                ppollos.Visible = true;
                ptorogoz.Visible = false;
                ptortuga.Visible = false;

            }
            if (txtnombre.Text == "torogoz")
            {
                pavestruz.Visible = false;
                ppinguinos.Visible = false;
                ppollos.Visible = false;
                ptorogoz.Visible = true;
                ptortuga.Visible = false;

            }
            if (txtnombre.Text == "tortuga Marina")
            {
                pavestruz.Visible = false;
                ppinguinos.Visible = false;
                ppollos.Visible = false;
                ptorogoz.Visible = false;
                ptortuga.Visible = true;

            }
            if (txtnombre.Text == "avestruz")
            {
                pavestruz.Visible = true;
                ppinguinos.Visible = false;
                ppollos.Visible = false;
                ptorogoz.Visible = false;
                ptortuga.Visible = false;

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.oviparosBindingSource.MoveFirst();
            if (txtnombre.Text == "pinguino")
            {
                pavestruz.Visible = false;
                ppinguinos.Visible = true;
                ppollos.Visible = false;
                ptorogoz.Visible = false;
                ptortuga.Visible = false;

            }
            if (txtnombre.Text == "gallina")
            {
                pavestruz.Visible = false;
                ppinguinos.Visible = false;
                ppollos.Visible = true;
                ptorogoz.Visible = false;
                ptortuga.Visible = false;

            }
            if (txtnombre.Text == "torogoz")
            {
                pavestruz.Visible = false;
                ppinguinos.Visible = false;
                ppollos.Visible = false;
                ptorogoz.Visible = true;
                ptortuga.Visible = false;

            }
            if (txtnombre.Text == "tortuga Marina")
            {
                pavestruz.Visible = false;
                ppinguinos.Visible = false;
                ppollos.Visible = false;
                ptorogoz.Visible = false;
                ptortuga.Visible = true;

            }
            if (txtnombre.Text == "avestruz")
            {
                pavestruz.Visible = true;
                ppinguinos.Visible = false;
                ppollos.Visible = false;
                ptorogoz.Visible = false;
                ptortuga.Visible = false;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.oviparosBindingSource.MovePrevious();
            if (txtnombre.Text == "pinguino")
            {
                pavestruz.Visible = false;
                ppinguinos.Visible = true;
                ppollos.Visible = false;
                ptorogoz.Visible = false;
                ptortuga.Visible = false;

            }
            if (txtnombre.Text == "gallina")
            {
                pavestruz.Visible = false;
                ppinguinos.Visible = false;
                ppollos.Visible = true;
                ptorogoz.Visible = false;
                ptortuga.Visible = false;

            }
            if (txtnombre.Text == "torogoz")
            {
                pavestruz.Visible = false;
                ppinguinos.Visible = false;
                ppollos.Visible = false;
                ptorogoz.Visible = true;
                ptortuga.Visible = false;

            }
            if (txtnombre.Text == "tortuga Marina")
            {
                pavestruz.Visible = false;
                ppinguinos.Visible = false;
                ppollos.Visible = false;
                ptorogoz.Visible = false;
                ptortuga.Visible = true;

            }
            if (txtnombre.Text == "avestruz")
            {
                pavestruz.Visible = true;
                ppinguinos.Visible = false;
                ppollos.Visible = false;
                ptorogoz.Visible = false;
                ptortuga.Visible = false;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.oviparosBindingSource.MoveNext();
            if (txtnombre.Text == "pinguino")
            {
                pavestruz.Visible = false;
                ppinguinos.Visible = true;
                ppollos.Visible = false;
                ptorogoz.Visible = false;
                ptortuga.Visible = false;

            }
            if (txtnombre.Text == "gallina")
            {
                pavestruz.Visible = false;
                ppinguinos.Visible = false;
                ppollos.Visible = true;
                ptorogoz.Visible = false;
                ptortuga.Visible = false;

            }
            if (txtnombre.Text == "torogoz")
            {
                pavestruz.Visible = false;
                ppinguinos.Visible = false;
                ppollos.Visible = false;
                ptorogoz.Visible = true;
                ptortuga.Visible = false;

            }
            if (txtnombre.Text == "tortuga Marina")
            {
                pavestruz.Visible = false;
                ppinguinos.Visible = false;
                ppollos.Visible = false;
                ptorogoz.Visible = false;
                ptortuga.Visible = true;

            }
            if (txtnombre.Text == "avestruz")
            {
                pavestruz.Visible = true;
                ppinguinos.Visible = false;
                ppollos.Visible = false;
                ptorogoz.Visible = false;
                ptortuga.Visible = false;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.oviparosBindingSource.MoveLast();
            if (txtnombre.Text == "pinguino")
            {
                pavestruz.Visible = false;
                ppinguinos.Visible = true;
                ppollos.Visible = false;
                ptorogoz.Visible = false;
                ptortuga.Visible = false;

            }
            if (txtnombre.Text == "gallina")
            {
                pavestruz.Visible = false;
                ppinguinos.Visible = false;
                ppollos.Visible = true;
                ptorogoz.Visible = false;
                ptortuga.Visible = false;

            }
            if (txtnombre.Text == "torogoz")
            {
                pavestruz.Visible = false;
                ppinguinos.Visible = false;
                ppollos.Visible = false;
                ptorogoz.Visible = true;
                ptortuga.Visible = false;

            }
            if (txtnombre.Text == "tortuga Marina")
            {
                pavestruz.Visible = false;
                ppinguinos.Visible = false;
                ppollos.Visible = false;
                ptorogoz.Visible = false;
                ptortuga.Visible = true;

            }
            if (txtnombre.Text == "avestruz")
            {
                pavestruz.Visible = true;
                ppinguinos.Visible = false;
                ppollos.Visible = false;
                ptorogoz.Visible = false;
                ptortuga.Visible = false;

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
