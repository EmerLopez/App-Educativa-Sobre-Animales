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
    public partial class AnimalesViviparos : Form
    {
        public string cadena_conexion = "server=Localhost;user id=wzadmins;password=12345;database=wonderzoo";

        public AnimalesViviparos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'wonderzooDataSet.viviparos' Puede moverla o quitarla según sea necesario.
            this.viviparosTableAdapter.Fill(this.wonderzooDataSet.viviparos);
            // TODO: esta línea de código carga datos en la tabla 'wonderZooDataSet.viviparos' Puede moverla o quitarla según sea necesario.
            //this.viviparosTableAdapter.Fill(this.wonderZooDataSet.viviparos);
            // TODO: esta línea de código carga datos en la tabla 'fenaheDataSet.viviparos' Puede moverla o quitarla según sea necesario.
            //this.viviparosTableAdapter.Fill(this.fenaheDataSet.viviparos);
            // TODO: esta línea de código carga datos en la tabla 'viviparosDataSet.viviparos' Puede moverla o quitarla según sea necesario.
            //this.viviparosTableAdapter.Fill(this.viviparosDataSet.viviparos);
            // TODO: esta línea de código carga datos en la tabla 'viviparosDataSet.viviparos' Puede moverla o quitarla según sea necesario.
            //this.viviparosTableAdapter.Fill(this.viviparosDataSet.viviparos);

            prinoceronte.Visible = true;
            //prinoceronte.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                myConnection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = myConnection;
                comando.CommandText = ("select * from viviparos Where nombre = '" + Combobuscar.Text + "'");
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


            if (txtnombre.Text == "rinoceronte")
            {
                pdelfin.Visible = false;
                pjirafa.Visible = false;
                pkoala.Visible = false;
                poso.Visible = false;
                prinoceronte.Visible = true;
            }

            if (txtnombre.Text == "delfin")
            {
                prinoceronte.Visible = false;
                pjirafa.Visible = false;
                pkoala.Visible = false;
                poso.Visible = false;
                pdelfin.Visible = true;
            }

            if (txtnombre.Text == "jirafa")
            {
                prinoceronte.Visible = false;
                pdelfin.Visible = false;
                pkoala.Visible = false;
                poso.Visible = false;
                pjirafa.Visible = true;
            }
            if (txtnombre.Text == "koala")
            {
                prinoceronte.Visible = false;
                pdelfin.Visible = false;
                pjirafa.Visible = false;
                poso.Visible = false;
                pkoala.Visible = true;
            }
            if (txtnombre.Text == "oso")
            {
                prinoceronte.Visible = false;
                pdelfin.Visible = false;
                pjirafa.Visible = false;
                pkoala.Visible = false;
                poso.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.viviparosBindingSource.MoveFirst();
            if (txtnombre.Text == "rinoceronte")
            {
                pdelfin.Visible = false;
                pjirafa.Visible = false;
                pkoala.Visible = false;
                poso.Visible = false;
                prinoceronte.Visible = true;
            }
            if (txtnombre.Text == "delfin")
            {
                prinoceronte.Visible = false;
                pjirafa.Visible = false;
                pkoala.Visible = false;
                poso.Visible = false;
                pdelfin.Visible = true;
            }

            if (txtnombre.Text == "jirafa")
            {
                prinoceronte.Visible = false;
                pdelfin.Visible = false;
                pkoala.Visible = false;
                poso.Visible = false;
                pjirafa.Visible = true;
            }
            if (txtnombre.Text == "koala")
            {
                prinoceronte.Visible = false;
                pdelfin.Visible = false;
                pjirafa.Visible = false;
                poso.Visible = false;
                pkoala.Visible = true;
            }
            if (txtnombre.Text == "oso")
            {
                prinoceronte.Visible = false;
                pdelfin.Visible = false;
                pjirafa.Visible = false;
                pkoala.Visible = false;
                poso.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.viviparosBindingSource.MovePrevious();
            if (txtnombre.Text == "rinoceronte")
            {
                pdelfin.Visible = false;
                pjirafa.Visible = false;
                pkoala.Visible = false;
                poso.Visible = false;
                prinoceronte.Visible = true;
            }
            if (txtnombre.Text == "delfin")
            {
                prinoceronte.Visible = false;
                pjirafa.Visible = false;
                pkoala.Visible = false;
                poso.Visible = false;
                pdelfin.Visible = true;
            }

            if (txtnombre.Text == "jirafa")
            {
                prinoceronte.Visible = false;
                pdelfin.Visible = false;
                pkoala.Visible = false;
                poso.Visible = false;
                pjirafa.Visible = true;
            }
            if (txtnombre.Text == "koala")
            {
                prinoceronte.Visible = false;
                pdelfin.Visible = false;
                pjirafa.Visible = false;
                poso.Visible = false;
                pkoala.Visible = true;
            }
            if (txtnombre.Text == "oso")
            {
                prinoceronte.Visible = false;
                pdelfin.Visible = false;
                pjirafa.Visible = false;
                pkoala.Visible = false;
                poso.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.viviparosBindingSource.MoveNext();
            if (txtnombre.Text == "rinoceronte")
            {
                pdelfin.Visible = false;
                pjirafa.Visible = false;
                pkoala.Visible = false;
                poso.Visible = false;
                prinoceronte.Visible = true;
            }
            if (txtnombre.Text == "delfin")
            {
                prinoceronte.Visible = false;
                pjirafa.Visible = false;
                pkoala.Visible = false;
                poso.Visible = false;
                pdelfin.Visible = true;
            }

            if (txtnombre.Text == "jirafa")
            {
                prinoceronte.Visible = false;
                pdelfin.Visible = false;
                pkoala.Visible = false;
                poso.Visible = false;
                pjirafa.Visible = true;
            }
            if (txtnombre.Text == "koala")
            {
                prinoceronte.Visible = false;
                pdelfin.Visible = false;
                pjirafa.Visible = false;
                poso.Visible = false;
                pkoala.Visible = true;
            }
            if (txtnombre.Text == "oso")
            {
                prinoceronte.Visible = false;
                pdelfin.Visible = false;
                pjirafa.Visible = false;
                pkoala.Visible = false;
                poso.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.viviparosBindingSource.MoveLast();
            if (txtnombre.Text == "rinoceronte")
            {
                pdelfin.Visible = false;
                pjirafa.Visible = false;
                pkoala.Visible = false;
                poso.Visible = false;
                prinoceronte.Visible = true;
            }
            if (txtnombre.Text == "delfin")
            {
                prinoceronte.Visible = false;
                pjirafa.Visible = false;
                pkoala.Visible = false;
                poso.Visible = false;
                pdelfin.Visible = true;
            }

            if (txtnombre.Text == "jirafa")
            {
                prinoceronte.Visible = false;
                pdelfin.Visible = false;
                pkoala.Visible = false;
                poso.Visible = false;
                pjirafa.Visible = true;
            }
            if (txtnombre.Text == "koala")
            {
                prinoceronte.Visible = false;
                pdelfin.Visible = false;
                pjirafa.Visible = false;
                poso.Visible = false;
                pkoala.Visible = true;
            }
            if (txtnombre.Text == "oso")
            {
                prinoceronte.Visible = false;
                pdelfin.Visible = false;
                pjirafa.Visible = false;
                pkoala.Visible = false;
                poso.Visible = true;
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
    }
}
