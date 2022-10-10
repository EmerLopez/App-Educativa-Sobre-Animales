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
    public partial class Anfibios : Form
    {
        public string cadena_conexion = "server=Localhost;user id=nilderson;password=dba1234;database=fenahe";

        public Anfibios()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'fenaheDataSet.anfibios' Puede moverla o quitarla según sea necesario.
            this.anfibiosTableAdapter.Fill(this.fenaheDataSet.anfibios);
            // TODO: esta línea de código carga datos en la tabla 'fenaheDataSet4.oviparos' Puede moverla o quitarla según sea necesario.
            this.anfibiosTableAdapter.Fill(this.fenaheDataSet.anfibios);
            // TODO: esta línea de código carga datos en la tabla 'fenaheDataSet3.oviparos' Puede moverla o quitarla según sea necesario.
            //this.oviparosTableAdapter.Fill(this.fenaheDataSet3.oviparos);

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
                comando.CommandText = ("select * from anfibios Where nombre = '" + txtbuscar.Text + "'");
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


            if (txtnombre.Text == "iguana") ;
            {
                ptortuga.Visible = false;
                pcocodrilo.Visible = false;
                pserpiente.Visible = false;
                prana.Visible = false;
                piguana.Visible = true;
            }
            if (txtnombre.Text == "tortuga marina")
            {
                pcocodrilo.Visible = false;
                pserpiente.Visible = false;
                prana.Visible = false;
                piguana.Visible = false;
                ptortuga.Visible = true;
            }
            if (txtnombre.Text == "cocodrilo")
            {
                pcocodrilo.Visible = true;
                pserpiente.Visible = false;
                prana.Visible = false;
                piguana.Visible = false;
                ptortuga.Visible = false;
            }
            if (txtnombre.Text == "serpientes")
            {
                pcocodrilo.Visible = false;
                pserpiente.Visible = true;
                prana.Visible = false;
                piguana.Visible = false;
                ptortuga.Visible = false;
            }
            if (txtnombre.Text == "ranas")
            {
                pcocodrilo.Visible = false;
                pserpiente.Visible = false;
                prana.Visible = true;
                piguana.Visible = false;
                ptortuga.Visible = false;
            }






        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.anfibiosBindingSource.MoveFirst();
            if (txtnombre.Text == "iguana") ;
            {
                ptortuga.Visible = false;
                pcocodrilo.Visible = false;
                pserpiente.Visible = false;
                prana.Visible = false;
                piguana.Visible = true;
            }
            if (txtnombre.Text == "tortuga marina")
            {
                pcocodrilo.Visible = false;
                pserpiente.Visible = false;
                prana.Visible = false;
                piguana.Visible = false;
                ptortuga.Visible = true;
            }
            if (txtnombre.Text == "cocodrilo")
            {
                pcocodrilo.Visible = true;
                pserpiente.Visible = false;
                prana.Visible = false;
                piguana.Visible = false;
                ptortuga.Visible = false;
            }
            if (txtnombre.Text == "serpientes")
            {
                pcocodrilo.Visible = false;
                pserpiente.Visible = true;
                prana.Visible = false;
                piguana.Visible = false;
                ptortuga.Visible = false;
            }
            if (txtnombre.Text == "ranas")
            {
                pcocodrilo.Visible = false;
                pserpiente.Visible = false;
                prana.Visible = true;
                piguana.Visible = false;
                ptortuga.Visible = false;
            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.anfibiosBindingSource.MovePrevious();
            if (txtnombre.Text == "iguana") ;
            {
                ptortuga.Visible = false;
                pcocodrilo.Visible = false;
                pserpiente.Visible = false;
                prana.Visible = false;
                piguana.Visible = true;
            }
            if (txtnombre.Text == "tortuga marina")
            {
                pcocodrilo.Visible = false;
                pserpiente.Visible = false;
                prana.Visible = false;
                piguana.Visible = false;
                ptortuga.Visible = true;
            }
            if (txtnombre.Text == "cocodrilo")
            {
                pcocodrilo.Visible = true;
                pserpiente.Visible = false;
                prana.Visible = false;
                piguana.Visible = false;
                ptortuga.Visible = false;
            }
            if (txtnombre.Text == "serpientes")
            {
                pcocodrilo.Visible = false;
                pserpiente.Visible = true;
                prana.Visible = false;
                piguana.Visible = false;
                ptortuga.Visible = false;
            }
            if (txtnombre.Text == "ranas")
            {
                pcocodrilo.Visible = false;
                pserpiente.Visible = false;
                prana.Visible = true;
                piguana.Visible = false;
                ptortuga.Visible = false;
            }





        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.anfibiosBindingSource.MoveNext();
            if (txtnombre.Text == "iguana") ;
            {
                ptortuga.Visible = false;
                pcocodrilo.Visible = false;
                pserpiente.Visible = false;
                prana.Visible = false;
                piguana.Visible = true;
            }
            if (txtnombre.Text == "tortuga marina")
            {
                pcocodrilo.Visible = false;
                pserpiente.Visible = false;
                prana.Visible = false;
                piguana.Visible = false;
                ptortuga.Visible = true;
            }
            if (txtnombre.Text == "cocodrilo")
            {
                pcocodrilo.Visible = true;
                pserpiente.Visible = false;
                prana.Visible = false;
                piguana.Visible = false;
                ptortuga.Visible = false;
            }
            if (txtnombre.Text == "serpientes")
            {
                pcocodrilo.Visible = false;
                pserpiente.Visible = true;
                prana.Visible = false;
                piguana.Visible = false;
                ptortuga.Visible = false;
            }
            if (txtnombre.Text == "ranas")
            {
                pcocodrilo.Visible = false;
                pserpiente.Visible = false;
                prana.Visible = true;
                piguana.Visible = false;
                ptortuga.Visible = false;
            }





        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.anfibiosBindingSource.MoveLast();
            if (txtnombre.Text == "iguana") ;
            {
                ptortuga.Visible = false;
                pcocodrilo.Visible = false;
                pserpiente.Visible = false;
                prana.Visible = false;
                piguana.Visible = true;
            }
            if (txtnombre.Text == "tortuga marina")
            {
                pcocodrilo.Visible = false;
                pserpiente.Visible = false;
                prana.Visible = false;
                piguana.Visible = false;
                ptortuga.Visible = true;
            }
            if (txtnombre.Text == "cocodrilo")
            {
                pcocodrilo.Visible = true;
                pserpiente.Visible = false;
                prana.Visible = false;
                piguana.Visible = false;
                ptortuga.Visible = false;
            }
            if (txtnombre.Text == "serpientes")
            {
                pcocodrilo.Visible = false;
                pserpiente.Visible = true;
                prana.Visible = false;
                piguana.Visible = false;
                ptortuga.Visible = false;
            }
            if (txtnombre.Text == "ranas")
            {
                pcocodrilo.Visible = false;
                pserpiente.Visible = false;
                prana.Visible = true;
                piguana.Visible = false;
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
