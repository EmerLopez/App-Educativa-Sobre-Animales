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
            // TODO: esta línea de código carga datos en la tabla 'wonderZooDataSet.anfibios' Puede moverla o quitarla según sea necesario.
            //this.anfibiosTableAdapter.Fill(this.wonderZooDataSet.anfibios);
            // TODO: esta línea de código carga datos en la tabla 'fenaheDataSet.anfibios' Puede moverla o quitarla según sea necesario.
            //this.anfibiosTableAdapter.Fill(this.fenaheDataSet.anfibios);

            piguana.Visible = true;
            
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
                    MessageBox.Show("El usuario no existe", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                pserpiente.Visible = false;
                pcoco.Visible = false;
                prana.Visible = false;
                ptortuga.Visible = false;
                piguana.Visible = true;
            }

            if (txtnombre.Text == "tortuga marina")
            {
                pserpiente.Visible = false;
                pcoco.Visible = false;
                prana.Visible = false;
                piguana.Visible = false;
                ptortuga.Visible = true;
            }

            if (txtnombre.Text == "cocodrilo")
            {
                pcoco.Visible = true;
                pserpiente.Visible = false;
                piguana.Visible = false;
                prana.Visible = false;
                ptortuga.Visible = false;
              
            }

            if (txtnombre.Text == "serpiente")
            {
                piguana.Visible = false;
                pcoco.Visible = false;
                prana.Visible = false;
                ptortuga.Visible = false;
                pserpiente.Visible = true;
            }

            if (txtnombre.Text == "rana")
            {
                piguana.Visible = false;
                pcoco.Visible = false;
                pserpiente.Visible = false;
                ptortuga.Visible = false;
                prana.Visible = true;
            }
            
        }


            private void button1_Click(object sender, EventArgs e)
        {
            this.anfibiosBindingSource.MoveFirst();
            if (txtnombre.Text == "iguana")
            {
                pserpiente.Visible = false;
                pcoco.Visible = false;
                prana.Visible = false;
                ptortuga.Visible = false;
                piguana.Visible = true;
            }

            if (txtnombre.Text == "tortuga marina")
            {
                pserpiente.Visible = false;
                pcoco.Visible = false;
                prana.Visible = false;
                piguana.Visible = false;
                ptortuga.Visible = true;
            }

            if (txtnombre.Text == "cocodrilo")
            {
                pcoco.Visible = true;
                pserpiente.Visible = false;
                piguana.Visible = false;
                prana.Visible = false;
                ptortuga.Visible = false;
                
            }

            if (txtnombre.Text == "serpiente")
            {
                piguana.Visible = false;
                pcoco.Visible = false;
                prana.Visible = false;
                ptortuga.Visible = false;
                pserpiente.Visible = true;
            }

            if (txtnombre.Text == "rana")
            {
                piguana.Visible = false;
                pcoco.Visible = false;
                pserpiente.Visible = false;
                ptortuga.Visible = false;
                prana.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.anfibiosBindingSource.MovePrevious();
            if (txtnombre.Text == "iguana")
            {
                pserpiente.Visible = false;
                pcoco.Visible = false;
                prana.Visible = false;
                ptortuga.Visible = false;
                piguana.Visible = true;
            }

            if (txtnombre.Text == "tortuga marina")
            {
                pserpiente.Visible = false;
                pcoco.Visible = false;
                prana.Visible = false;
                piguana.Visible = false;
                ptortuga.Visible = true;
            }

            if (txtnombre.Text == "cocodrilo")
            {
                pcoco.Visible = true;
                pserpiente.Visible = false;
                piguana.Visible = false;
                prana.Visible = false;
                ptortuga.Visible = false;
             
            }

            if (txtnombre.Text == "serpiente")
            {
                piguana.Visible = false;
                pcoco.Visible = false;
                prana.Visible = false;
                ptortuga.Visible = false;
                pserpiente.Visible = true;
            }

            if (txtnombre.Text == "rana")
            {
                piguana.Visible = false;
                pcoco.Visible = false;
                pserpiente.Visible = false;
                ptortuga.Visible = false;
                prana.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.anfibiosBindingSource.MoveNext();
            if (txtnombre.Text == "iguana")
            {
                pserpiente.Visible = false;
                pcoco.Visible = false;
                prana.Visible = false;
                ptortuga.Visible = false;
                piguana.Visible = true;
            }

            if (txtnombre.Text == "tortuga marina")
            {
                pserpiente.Visible = false;
                pcoco.Visible = false;
                prana.Visible = false;
                piguana.Visible = false;
                ptortuga.Visible = true;
            }

            if (txtnombre.Text == "cocodrilo")
            {
                pcoco.Visible = true;
                pserpiente.Visible = false;
                piguana.Visible = false;
                prana.Visible = false;
                ptortuga.Visible = false;
               
            }

            if (txtnombre.Text == "serpiente")
            {
                piguana.Visible = false;
                pcoco.Visible = false;
                prana.Visible = false;
                ptortuga.Visible = false;
                pserpiente.Visible = true;
            }

            if (txtnombre.Text == "rana")
            {
                piguana.Visible = false;
                pcoco.Visible = false;
                pserpiente.Visible = false;
                ptortuga.Visible = false;
                prana.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.anfibiosBindingSource.MoveLast();
            if (txtnombre.Text == "iguana")
            {
                pserpiente.Visible = false;
                pcoco.Visible = false;
                prana.Visible = false;
                ptortuga.Visible = false;
                piguana.Visible = true;
            }

            if (txtnombre.Text == "tortuga marina")
            {
                pserpiente.Visible = false;
                pcoco.Visible = false;
                prana.Visible = false;
                piguana.Visible = false;
                ptortuga.Visible = true;
            }

            if (txtnombre.Text == "cocodrilo")
            {
                pcoco.Visible = true;
                pserpiente.Visible = false;
                piguana.Visible = false;
                prana.Visible = false;
                ptortuga.Visible = false;
                
            }

            if (txtnombre.Text == "serpiente")
            {
                piguana.Visible = false;
                pcoco.Visible = false;
                prana.Visible = false;
                ptortuga.Visible = false;
                pserpiente.Visible = true;
            }

            if (txtnombre.Text == "rana")
            {
                piguana.Visible = false;
                pcoco.Visible = false;
                pserpiente.Visible = false;
                ptortuga.Visible = false;
                prana.Visible = true;
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
