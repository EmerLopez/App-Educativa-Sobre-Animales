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
    public partial class herviborosanimales : Form
    {
        public string cadena_conexion = "server=Localhost;user id=wzadmins;password=12345;database=wonderzoo";

        public herviborosanimales()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'wonderzooDataSet.herviboros' Puede moverla o quitarla según sea necesario.
           // this.herviborosTableAdapter.Fill(this.wonderzooDataSet.herviboros);
            // TODO: esta línea de código carga datos en la tabla 'wonderzooDataSet.herviboros' Puede moverla o quitarla según sea necesario.
           // this.herviborosTableAdapter.Fill(this.wonderzooDataSet.herviboros);
            // TODO: esta línea de código carga datos en la tabla 'fenaheDataSet4.oviparos' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'fenaheDataSet3.oviparos' Puede moverla o quitarla según sea necesario.
            //this.oviparosTableAdapter.Fill(this.fenaheDataSet3.oviparos);

            posopanda.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                myConnection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = myConnection;
                comando.CommandText = ("select * from herviboros Where nombre = '" + txtbuscar.Text + "'");
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
            if (txtnombre.Text == "panda") ;
            {
                posopanda.Visible = true;
                pgacela.Visible = false;
                pjirafa.Visible = false;
                pcanguro.Visible = false;
                poveja.Visible = false;
            }
            if (txtnombre.Text == "gacela")
            {
                posopanda.Visible = false;
                pgacela.Visible = true;
                pjirafa.Visible = false;
                pcanguro.Visible = false;
                poveja.Visible = false;
            }
            if (txtnombre.Text == "jirafa")
            {
                posopanda.Visible = false;
                pgacela.Visible = false;
                pjirafa.Visible = true;
                pcanguro.Visible = false;
                poveja.Visible = false;
            }
            if (txtnombre.Text == "canguro")
            {
                posopanda.Visible = false;
                pgacela.Visible = false;
                pjirafa.Visible = false;
                pcanguro.Visible = true;
                poveja.Visible = false;
            }
            if (txtnombre.Text == "oveja")
            {
                posopanda.Visible = false;
                pgacela.Visible = false;
                pjirafa.Visible = false;
                pcanguro.Visible = false;
                poveja.Visible = true;
            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.herviborosBindingSource.MoveFirst();
            if (txtnombre.Text == "panda") ;
            {
                posopanda.Visible = true;
                pgacela.Visible = false;
                pjirafa.Visible = false;
                pcanguro.Visible = false;
                poveja.Visible = false;
            }
            if (txtnombre.Text == "gacela")
            {
                posopanda.Visible = false;
                pgacela.Visible = true;
                pjirafa.Visible = false;
                pcanguro.Visible = false;
                poveja.Visible = false;
            }
            if (txtnombre.Text == "jirafa")
            {
                posopanda.Visible = false;
                pgacela.Visible = false;
                pjirafa.Visible = true;
                pcanguro.Visible = false;
                poveja.Visible = false;
            }
            if (txtnombre.Text == "canguro")
            {
                posopanda.Visible = false;
                pgacela.Visible = false;
                pjirafa.Visible = false;
                pcanguro.Visible = true;
                poveja.Visible = false;
            }
            if (txtnombre.Text == "oveja")
            {
                posopanda.Visible = false;
                pgacela.Visible = false;
                pjirafa.Visible = false;
                pcanguro.Visible = false;
                poveja.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.herviborosBindingSource.MovePrevious();
            if (txtnombre.Text == "panda");
            {
                posopanda.Visible = true;
                pgacela.Visible = false;
                pjirafa.Visible = false;
                pcanguro.Visible = false;
                poveja.Visible = false;
            }
            if (txtnombre.Text == "gacela")
            {
                posopanda.Visible = false;
                pgacela.Visible = true;
                pjirafa.Visible = false;
                pcanguro.Visible = false;
                poveja.Visible = false;
            }
            if (txtnombre.Text == "jirafa")
            {
                posopanda.Visible = false;
                pgacela.Visible = false;
                pjirafa.Visible =true;
                pcanguro.Visible = false;
                poveja.Visible = false;
            }
            if (txtnombre.Text == "canguro")
            {
                posopanda.Visible = false;
                pgacela.Visible = false;
                pjirafa.Visible = false;
                pcanguro.Visible = true;
                poveja.Visible = false;
            }
            if (txtnombre.Text == "oveja")
            {
                posopanda.Visible = false;
                pgacela.Visible = false;
                pjirafa.Visible = false;
                pcanguro.Visible = false;
                poveja.Visible = true;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.herviborosBindingSource.MoveNext();
            if (txtnombre.Text == "panda") ;
            {
                posopanda.Visible = true;
                pgacela.Visible = false;
                pjirafa.Visible = false;
                pcanguro.Visible = false;
                poveja.Visible = false;
            }
            if (txtnombre.Text == "gacela")
            {
                posopanda.Visible = false;
                pgacela.Visible = true;
                pjirafa.Visible = false;
                pcanguro.Visible = false;
                poveja.Visible = false;
            }
            if (txtnombre.Text == "jirafa")
            {
                posopanda.Visible = false;
                pgacela.Visible = false;
                pjirafa.Visible = true;
                pcanguro.Visible = false;
                poveja.Visible = false;
            }
            if (txtnombre.Text == "canguro")
            {
                posopanda.Visible = false;
                pgacela.Visible = false;
                pjirafa.Visible = false;
                pcanguro.Visible = true;
                poveja.Visible = false;
            }
            if (txtnombre.Text == "oveja")
            {
                posopanda.Visible = false;
                pgacela.Visible = false;
                pjirafa.Visible = false;
                pcanguro.Visible = false;
                poveja.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.herviborosBindingSource.MoveLast();
            if (txtnombre.Text == "panda") ;
            {
                posopanda.Visible = true;
                pgacela.Visible = false;
                pjirafa.Visible = false;
                pcanguro.Visible = false;
                poveja.Visible = false;
            }
            if (txtnombre.Text == "gacela")
            {
                posopanda.Visible = false;
                pgacela.Visible = true;
                pjirafa.Visible = false;
                pcanguro.Visible = false;
                poveja.Visible = false;
            }
            if (txtnombre.Text == "jirafa")
            {
                posopanda.Visible = false;
                pgacela.Visible = false;
                pjirafa.Visible = true;
                pcanguro.Visible = false;
                poveja.Visible = false;
            }
            if (txtnombre.Text == "canguro")
            {
                posopanda.Visible = false;
                pgacela.Visible = false;
                pjirafa.Visible = false;
                pcanguro.Visible = true;
                poveja.Visible = false;
            }
            if (txtnombre.Text == "oveja")
            {
                posopanda.Visible = false;
                pgacela.Visible = false;
                pjirafa.Visible = false;
                pcanguro.Visible = false;
                poveja.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
