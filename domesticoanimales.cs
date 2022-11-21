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
    public partial class domesticoanimales : Form
    {
        public string cadena_conexion = "server=Localhost;user id=wzadmins;password=12345;database=wonderzoo";
        private object domesticosTableAdapter;
        private object wonderzoDataSet;

        public domesticoanimales()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'wonderzooDataSet.domesticos' Puede moverla o quitarla según sea necesario.
            this.domesticosTableAdapter1.Fill(this.wonderzooDataSet.domesticos);

            pperro.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                myConnection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = myConnection;
                comando.CommandText = ("select * from domesticos Where nombre = '" + txtbuscar.Text + "'");
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
                    MessageBox.Show("ENo fue posible encontrar el animal ingresado", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                myConnection.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Campo de busqueda está vacío", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //throw;
            }

            if (txtnombre.Text == "perro")
            {
                pperro.Visible = true;
                pgato.Visible = false;
                pconejo.Visible = false;
                pcerdo.Visible = false;
                ppato.Visible = false;
            }
            if (txtnombre.Text == "gato")
            {
                pperro.Visible = false;
                pgato.Visible = true;
                pconejo.Visible = false;
                pcerdo.Visible = false;
                ppato.Visible = false;
            }
            if (txtnombre.Text == "conejo")
            {
                pperro.Visible = false;
                pgato.Visible = false;
                pconejo.Visible = true;
                pcerdo.Visible = false;
                ppato.Visible = false;
            }
            if (txtnombre.Text == "cerdo")
            {
                pperro.Visible = false;
                pgato.Visible = false;
                pconejo.Visible = false;
                pcerdo.Visible = true;
                ppato.Visible = false;
            }
            if (txtnombre.Text == "pato")
            {
                pperro.Visible = false;
                pgato.Visible = false;
                pconejo.Visible = false;
                pcerdo.Visible = false;
                ppato.Visible = true;
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.domesticosBindingSource.MoveFirst();
            if (txtnombre.Text == "perro")
            {
                pperro.Visible = true;
                pgato.Visible = false;
                pconejo.Visible = false;
                pcerdo.Visible = false;
                ppato.Visible = false;
            }
            if (txtnombre.Text == "gato")
            {
                pperro.Visible = false;
                pgato.Visible = true;
                pconejo.Visible = false;
                pcerdo.Visible = false;
                ppato.Visible = false;
            }
            if (txtnombre.Text == "conejo")
            {
                pperro.Visible = false;
                pgato.Visible = false;
                pconejo.Visible = true;
                pcerdo.Visible = false;
                ppato.Visible = false;
            }
            if (txtnombre.Text == "cerdo")
            {
                pperro.Visible = false;
                pgato.Visible = false;
                pconejo.Visible = false;
                pcerdo.Visible = true;
                ppato.Visible = false;
            }
            if (txtnombre.Text == "pato")
            {
                pperro.Visible = false;
                pgato.Visible = false;
                pconejo.Visible = false;
                pcerdo.Visible = false;
                ppato.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.domesticosBindingSource.MovePrevious();
            if (txtnombre.Text == "perro")
            {
                pperro.Visible = true;
                pgato.Visible = false;
                pconejo.Visible = false;
                pcerdo.Visible = false;
                ppato.Visible = false;
            }
            if (txtnombre.Text == "gato")
            {
                pperro.Visible = false;
                pgato.Visible = true;
                pconejo.Visible = false;
                pcerdo.Visible = false;
                ppato.Visible = false;
            }
            if (txtnombre.Text == "conejo")
            {
                pperro.Visible = false;
                pgato.Visible = false;
                pconejo.Visible = true;
                pcerdo.Visible = false;
                ppato.Visible = false;
            }
            if (txtnombre.Text == "cerdo")
            {
                pperro.Visible = false;
                pgato.Visible = false;
                pconejo.Visible = false;
                pcerdo.Visible = true;
                ppato.Visible = false;
            }
            if (txtnombre.Text == "pato")
            {
                pperro.Visible = false;
                pgato.Visible = false;
                pconejo.Visible = false;
                pcerdo.Visible = false;
                ppato.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.domesticosBindingSource.MoveNext();
            if (txtnombre.Text == "perro")
            {
                pperro.Visible = true;
                pgato.Visible = false;
                pconejo.Visible = false;
                pcerdo.Visible = false;
                ppato.Visible = false;
            }
            if (txtnombre.Text == "gato")
            {
                pperro.Visible = false;
                pgato.Visible = true;
                pconejo.Visible = false;
                pcerdo.Visible = false;
                ppato.Visible = false;
            }
            if (txtnombre.Text == "conejo")
            {
                pperro.Visible = false;
                pgato.Visible = false;
                pconejo.Visible = true;
                pcerdo.Visible = false;
                ppato.Visible = false;
            }
            if (txtnombre.Text == "cerdo")
            {
                pperro.Visible = false;
                pgato.Visible = false;
                pconejo.Visible = false;
                pcerdo.Visible = true;
                ppato.Visible = false;
            }
            if (txtnombre.Text == "pato")
            {
                pperro.Visible = false;
                pgato.Visible = false;
                pconejo.Visible = false;
                pcerdo.Visible = false;
                ppato.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.domesticosBindingSource.MoveLast();
            if (txtnombre.Text == "perro")
            {
                pperro.Visible = true;
                pgato.Visible = false;
                pconejo.Visible = false;
                pcerdo.Visible = false;
                ppato.Visible = false;
            }
            if (txtnombre.Text == "gato")
            {
                pperro.Visible = false;
                pgato.Visible = true;
                pconejo.Visible = false;
                pcerdo.Visible = false;
                ppato.Visible = false;
            }
            if (txtnombre.Text == "conejo")
            {
                pperro.Visible = false;
                pgato.Visible = false;
                pconejo.Visible = true;
                pcerdo.Visible = false;
                ppato.Visible = false;
            }
            if (txtnombre.Text == "cerdo")
            {
                pperro.Visible = false;
                pgato.Visible = false;
                pconejo.Visible = false;
                pcerdo.Visible = true;
                ppato.Visible = false;
            }
            if (txtnombre.Text == "pato")
            {
                pperro.Visible = false;
                pgato.Visible = false;
                pconejo.Visible = false;
                pcerdo.Visible = false;
                ppato.Visible = true;
            }
           // pPato.Visible = true;
            
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
