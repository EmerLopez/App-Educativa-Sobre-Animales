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
    public partial class Pcobra : Form
    {
        public string cadena_conexion = "server=Localhost;user id=wzadmins;password=12345;database=wonderzoo";
        public Pcobra()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'fenaheDataSet4.oviparos' Puede moverla o quitarla según sea necesario.
            this.oviparosTableAdapter.Fill(this.fenaheDataSet4.oviparos);
            // TODO: esta línea de código carga datos en la tabla 'fenaheDataSet3.oviparos' Puede moverla o quitarla según sea necesario.
            //this.oviparosTableAdapter.Fill(this.fenaheDataSet3.oviparos);
            Pleopardo.Visible = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                myConnection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = myConnection;
                comando.CommandText = ("select * from salvaje Where nombre = '" + txtbuscar.Text + "'");
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


            if (txtnombre.Text == "leopardo")
            {
                Pcobras.Visible = false;
            
                Plobos.Visible = false;
                Ptiburon.Visible = false;
                Ptigre.Visible = false;
                Pleopardo.Visible = true;
            }

            if (txtnombre.Text == "tigre")
            {
                Pcobras.Visible = false;

                Plobos.Visible = false;
                Ptiburon.Visible = false;
                Pleopardo.Visible = false;
                Ptigre.Visible = true;
            }
            if (txtnombre.Text == "tiburon")
            {
                Pcobras.Visible = false;

                Plobos.Visible = false;
                Pleopardo.Visible = false;
                Ptigre.Visible = false;
                Ptiburon.Visible = true;
            }
            if (txtnombre.Text == "lobos")
            {
                Pcobras.Visible = false;

                Pleopardo.Visible = false;
                Ptiburon.Visible = false;
                Ptigre.Visible = false;
                Plobos.Visible = true;
            }
            if (txtnombre.Text == "cobras")
            {
                Pleopardo.Visible = false;

                Plobos.Visible = false;
                Ptiburon.Visible = false;
                Ptigre.Visible = false;
                Pcobras.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.oviparosBindingSource.MoveFirst();
            if (txtnombre.Text == "leopardo")
            {
                Pcobras.Visible = false;

                Plobos.Visible = false;
                Ptiburon.Visible = false;
                Ptigre.Visible = false;
                Pleopardo.Visible = true;
            }

            if (txtnombre.Text == "tigre")
            {
                Pcobras.Visible = false;

                Plobos.Visible = false;
                Ptiburon.Visible = false;
                Pleopardo.Visible = false;
                Ptigre.Visible = true;
            }
            if (txtnombre.Text == "tiburon")
            {
                Pcobras.Visible = false;

                Plobos.Visible = false;
                Pleopardo.Visible = false;
                Ptigre.Visible = false;
                Ptiburon.Visible = true;
            }
            if (txtnombre.Text == "lobos")
            {
                Pcobras.Visible = false;

                Pleopardo.Visible = false;
                Ptiburon.Visible = false;
                Ptigre.Visible = false;
                Plobos.Visible = true;
            }
            if (txtnombre.Text == "cobras")
            {
                Pleopardo.Visible = false;

                Plobos.Visible = false;
                Ptiburon.Visible = false;
                Ptigre.Visible = false;
                Pcobras.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.oviparosBindingSource.MovePrevious();
            if (txtnombre.Text == "leopardo")
            {
                Pcobras.Visible = false;

                Plobos.Visible = false;
                Ptiburon.Visible = false;
                Ptigre.Visible = false;
                Pleopardo.Visible = true;
            }

            if (txtnombre.Text == "tigre")
            {
                Pcobras.Visible = false;

                Plobos.Visible = false;
                Ptiburon.Visible = false;
                Pleopardo.Visible = false;
                Ptigre.Visible = true;
            }
            if (txtnombre.Text == "tiburon")
            {
                Pcobras.Visible = false;

                Plobos.Visible = false;
                Pleopardo.Visible = false;
                Ptigre.Visible = false;
                Ptiburon.Visible = true;
            }
            if (txtnombre.Text == "lobos")
            {
                Pcobras.Visible = false;

                Pleopardo.Visible = false;
                Ptiburon.Visible = false;
                Ptigre.Visible = false;
                Plobos.Visible = true;
            }
            if (txtnombre.Text == "cobras")
            {
                Pleopardo.Visible = false;

                Plobos.Visible = false;
                Ptiburon.Visible = false;
                Ptigre.Visible = false;
                Pcobras.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.oviparosBindingSource.MoveNext();
            if (txtnombre.Text == "leopardo")
            {
                Pcobras.Visible = false;

                Plobos.Visible = false;
                Ptiburon.Visible = false;
                Ptigre.Visible = false;
                Pleopardo.Visible = true;
            }

            if (txtnombre.Text == "tigre")
            {
                Pcobras.Visible = false;

                Plobos.Visible = false;
                Ptiburon.Visible = false;
                Pleopardo.Visible = false;
                Ptigre.Visible = true;
            }
            if (txtnombre.Text == "tiburon")
            {
                Pcobras.Visible = false;

                Plobos.Visible = false;
                Pleopardo.Visible = false;
                Ptigre.Visible = false;
                Ptiburon.Visible = true;
            }
            if (txtnombre.Text == "lobos")
            {
                Pcobras.Visible = false;

                Pleopardo.Visible = false;
                Ptiburon.Visible = false;
                Ptigre.Visible = false;
                Plobos.Visible = true;
            }
            if (txtnombre.Text == "cobras")
            {
                Pleopardo.Visible = false;

                Plobos.Visible = false;
                Ptiburon.Visible = false;
                Ptigre.Visible = false;
                Pcobras.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.oviparosBindingSource.MoveLast();
            if (txtnombre.Text == "leopardo")
            {
                Pcobras.Visible = false;

                Plobos.Visible = false;
                Ptiburon.Visible = false;
                Ptigre.Visible = false;
                Pleopardo.Visible = true;
            }

            if (txtnombre.Text == "tigre")
            {
                Pcobras.Visible = false;

                Plobos.Visible = false;
                Ptiburon.Visible = false;
                Pleopardo.Visible = false;
                Ptigre.Visible = true;
            }
            if (txtnombre.Text == "tiburon")
            {
                Pcobras.Visible = false;

                Plobos.Visible = false;
                Pleopardo.Visible = false;
                Ptigre.Visible = false;
                Ptiburon.Visible = true;
            }
            if (txtnombre.Text == "lobos")
            {
                Pcobras.Visible = false;

                Pleopardo.Visible = false;
                Ptiburon.Visible = false;
                Ptigre.Visible = false;
                Plobos.Visible = true;
            }
            if (txtnombre.Text == "cobras")
            {
                Pleopardo.Visible = false;

                Plobos.Visible = false;
                Ptiburon.Visible = false;
                Ptigre.Visible = false;
                Pcobras.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Ptigre_Click(object sender, EventArgs e)
        {

        }
    }
}
