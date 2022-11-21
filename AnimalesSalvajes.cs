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
    public partial class AnimalesSalvajes : Form
    {
        public string cadena_conexion = "server=Localhost;user id=wzadmins;password=12345;database=wonderzoo";
        public AnimalesSalvajes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'wonderzooDataSet.salvajes' Puede moverla o quitarla según sea necesario.
            this.salvajesTableAdapter.Fill(this.wonderzooDataSet.salvajes);

            pleopardo.Visible = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                myConnection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = myConnection;
                comando.CommandText = ("select * from salvajes Where nombre = '" + txtbuscar.Text + "'");
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


            if (txtnombre.Text == "leopardo")
            {
                pscobra.Visible = false;
            
                plobo.Visible = false;
                ptiburon.Visible = false;
                ptigre.Visible = false;
                pleopardo.Visible = true;
            }

            if (txtnombre.Text == "tigre")
            {
                pscobra.Visible = false;

                plobo.Visible = false;
                ptiburon.Visible = false;
                pleopardo.Visible = false;
                ptigre.Visible = true;
            }
            if (txtnombre.Text == "tiburon")
            {
                pscobra.Visible = false;

                plobo.Visible = false;
                pleopardo.Visible = false;
                ptigre.Visible = false;
                ptiburon.Visible = true;
            }
            if (txtnombre.Text == "lobos")
            {
                pscobra.Visible = false;

                pleopardo.Visible = false;
                ptiburon.Visible = false;
                ptigre.Visible = false;
                plobo.Visible = true;
            }
            if (txtnombre.Text == "serpiente cobra")
            {
                pleopardo.Visible = false;

                plobo.Visible = false;
                ptiburon.Visible = false;
                ptigre.Visible = false;
                pscobra.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.salvajesBindingSource.MoveFirst();
            if (txtnombre.Text == "leopardo")
            {
                pscobra.Visible = false;

                plobo.Visible = false;
                ptiburon.Visible = false;
                ptigre.Visible = false;
                pleopardo.Visible = true;
            }

            if (txtnombre.Text == "tigre")
            {
                pscobra.Visible = false;

                plobo.Visible = false;
                ptiburon.Visible = false;
                pleopardo.Visible = false;
                ptigre.Visible = true;
            }
            if (txtnombre.Text == "tiburon")
            {
                pscobra.Visible = false;

                plobo.Visible = false;
                pleopardo.Visible = false;
                ptigre.Visible = false;
                ptiburon.Visible = true;
            }
            if (txtnombre.Text == "lobos")
            {
                pscobra.Visible = false;

                pleopardo.Visible = false;
                ptiburon.Visible = false;
                ptigre.Visible = false;
                plobo.Visible = true;
            }
            if (txtnombre.Text == "serpiente cobra")
            {
                pleopardo.Visible = false;

                plobo.Visible = false;
                ptiburon.Visible = false;
                ptigre.Visible = false;
                pscobra.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.salvajesBindingSource.MovePrevious();
            if (txtnombre.Text == "leopardo")
            {
                pscobra.Visible = false;

                plobo.Visible = false;
                ptiburon.Visible = false;
                ptigre.Visible = false;
                pleopardo.Visible = true;
            }

            if (txtnombre.Text == "tigre")
            {
                pscobra.Visible = false;

                plobo.Visible = false;
                ptiburon.Visible = false;
                pleopardo.Visible = false;
                ptigre.Visible = true;
            }
            if (txtnombre.Text == "tiburon")
            {
                pscobra.Visible = false;

                plobo.Visible = false;
                pleopardo.Visible = false;
                ptigre.Visible = false;
                ptiburon.Visible = true;
            }
            if (txtnombre.Text == "lobos")
            {
                pscobra.Visible = false;

                pleopardo.Visible = false;
                ptiburon.Visible = false;
                ptigre.Visible = false;
                plobo.Visible = true;
            }
            if (txtnombre.Text == "serpiente cobra")
            {
                pleopardo.Visible = false;

                plobo.Visible = false;
                ptiburon.Visible = false;
                ptigre.Visible = false;
                pscobra.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.salvajesBindingSource.MoveNext();
            if (txtnombre.Text == "leopardo")
            {
                pscobra.Visible = false;

                plobo.Visible = false;
                ptiburon.Visible = false;
                ptigre.Visible = false;
                pleopardo.Visible = true;
            }

            if (txtnombre.Text == "tigre")
            {
                pscobra.Visible = false;

                plobo.Visible = false;
                ptiburon.Visible = false;
                pleopardo.Visible = false;
                ptigre.Visible = true;
            }
            if (txtnombre.Text == "tiburon")
            {
                pscobra.Visible = false;

                plobo.Visible = false;
                pleopardo.Visible = false;
                ptigre.Visible = false;
                ptiburon.Visible = true;
            }
            if (txtnombre.Text == "lobos")
            {
                pscobra.Visible = false;

                pleopardo.Visible = false;
                ptiburon.Visible = false;
                ptigre.Visible = false;
                plobo.Visible = true;
            }
            if (txtnombre.Text == "serpiente cobra")
            {
                pleopardo.Visible = false;

                plobo.Visible = false;
                ptiburon.Visible = false;
                ptigre.Visible = false;
                pscobra.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.salvajesBindingSource.MoveLast();
            if (txtnombre.Text == "leopardo")
            {
                pscobra.Visible = false;

                plobo.Visible = false;
                ptiburon.Visible = false;
                ptigre.Visible = false;
                pleopardo.Visible = true;
            }

            if (txtnombre.Text == "tigre")
            {
                pscobra.Visible = false;

                plobo.Visible = false;
                ptiburon.Visible = false;
                pleopardo.Visible = false;
                ptigre.Visible = true;
            }
            if (txtnombre.Text == "tiburon")
            {
                pscobra.Visible = false;

                plobo.Visible = false;
                pleopardo.Visible = false;
                ptigre.Visible = false;
                ptiburon.Visible = true;
            }
            if (txtnombre.Text == "lobos")
            {
                pscobra.Visible = false;

                pleopardo.Visible = false;
                ptiburon.Visible = false;
                ptigre.Visible = false;
                plobo.Visible = true;
            }
            if (txtnombre.Text == "serpiente cobra")
            {
                pleopardo.Visible = false;

                plobo.Visible = false;
                ptiburon.Visible = false;
                ptigre.Visible = false;
                pscobra.Visible = true;
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

        private void bsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
