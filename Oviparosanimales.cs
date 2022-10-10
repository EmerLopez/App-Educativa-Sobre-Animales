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

namespace Oviparos
{
    public partial class Oviparosanimales : Form
    {
        public string cadena_conexion = "server=Localhost;user id=Diego;password=12345;database=fenahe";

        public Oviparosanimales()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.oviparosTableAdapter.Fill(this.fenaheDataSet4.oviparos);
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
                    MessageBox.Show("El usuario no existe", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                myConnection.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Campo de busqueda está vacío", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //throw;
            }
            if (txtnombre.Text == "Pinguino")
            {
                pavestruz.Visible = false;
                ppinguinos.Visible = true;
                ppollos.Visible = false;
                ptorogoz.Visible = false;
                ptortuga.Visible = false;

            }
            if (txtnombre.Text == "Gallina")
            {
                pavestruz.Visible = false;
                ppinguinos.Visible = false;
                ppollos.Visible = true;
                ptorogoz.Visible = false;
                ptortuga.Visible = false;

            }
            if (txtnombre.Text == "Torogoz")
            {
                pavestruz.Visible = false;
                ppinguinos.Visible = false;
                ppollos.Visible = false;
                ptorogoz.Visible = true;
                ptortuga.Visible = false;

            }
            if (txtnombre.Text == "Tortuga Marina")
            {
                pavestruz.Visible = false;
                ppinguinos.Visible = false;
                ppollos.Visible = false;
                ptorogoz.Visible = false;
                ptortuga.Visible = true;

            }
            if (txtnombre.Text == "Avestruz")
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
            if(txtnombre.Text =="Tortuga Marina")
            {
                pavestruz.Visible = false;
                ppinguinos.Visible = false;
                ppollos.Visible = false;
                ptorogoz.Visible = false;
                ptortuga.Visible = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.oviparosBindingSource.MovePrevious();
            if (txtnombre.Text == "Pinguino")
            {
                pavestruz.Visible = false;
                ppinguinos.Visible = true;
                ppollos.Visible = false;
                ptorogoz.Visible = false;
                ptortuga.Visible = false;

            }
            if (txtnombre.Text == "Gallina")
            {
                pavestruz.Visible = false;
                ppinguinos.Visible = false;
                ppollos.Visible = true;
                ptorogoz.Visible = false;
                ptortuga.Visible = false;

            }
            if (txtnombre.Text == "Torogoz")
            {
                pavestruz.Visible = false;
                ppinguinos.Visible = false;
                ppollos.Visible = false;
                ptorogoz.Visible = true;
                ptortuga.Visible = false;

            }
            if (txtnombre.Text == "Tortuga Marina")
            {
                pavestruz.Visible = false;
                ppinguinos.Visible = false;
                ppollos.Visible = false;
                ptorogoz.Visible = false;
                ptortuga.Visible = true;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.oviparosBindingSource.MoveNext();
            if (txtnombre.Text == "Pinguino")
            {
                pavestruz.Visible = false;
                ppinguinos.Visible = true;
                ppollos.Visible = false;
                ptorogoz.Visible = false;
                ptortuga.Visible = false;

            }
            if (txtnombre.Text == "Gallina")
            {
                pavestruz.Visible = false;
                ppinguinos.Visible = false;
                ppollos.Visible = true;
                ptorogoz.Visible = false;
                ptortuga.Visible = false;

            }
            if (txtnombre.Text == "Torogoz")
            {
                pavestruz.Visible = false;
                ppinguinos.Visible = false;
                ppollos.Visible = false;
                ptorogoz.Visible = true;
                ptortuga.Visible = false;

            }
            if (txtnombre.Text == "Avestruz")
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
            if (txtnombre.Text == "Avestruz")
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
