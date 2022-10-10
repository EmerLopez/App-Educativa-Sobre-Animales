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
    public partial class domestico : Form
    {
        public string cadena_conexion = "server=localhost;user id=root;database=wonderzo";
        private object domesticosTableAdapter;
        private object wonderzoDataSet;

        public domestico()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'wonderzoDataSet1.domesticos' Puede moverla o quitarla según sea necesario.
            this.domesticosTableAdapter1.Fill(this.wonderzoDataSet1.domesticos);
            pPerro.Visible = true;
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
                    MessageBox.Show("El usuario no existe", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                myConnection.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Campo de busqueda está vacío", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //throw;
            }

            if (txtnombre.Text == "Perro")
            {
                pPerro.Visible = true;
                pGato.Visible = false;
                pConejo.Visible = false;
                pCerdo.Visible = false;
                pPato.Visible = false;
            }
            if (txtnombre.Text == "Gato")
            {
                pPerro.Visible = false;
                pGato.Visible = true;
                pConejo.Visible = false;
                pCerdo.Visible = false;
                pPato.Visible = false;
            }
            if (txtnombre.Text == "Conejo")
            {
                pPerro.Visible = false;
                pGato.Visible = false;
                pConejo.Visible = true;
                pCerdo.Visible = false;
                pPato.Visible = false;
            }
            if (txtnombre.Text == "Cerdo")
            {
                pPerro.Visible = false;
                pGato.Visible = false;
                pConejo.Visible = false;
                pCerdo.Visible = true;
                pPato.Visible = false;
            }
            if (txtnombre.Text == "Pato")
            {
                pPerro.Visible = false;
                pGato.Visible = false;
                pConejo.Visible = false;
                pCerdo.Visible = false;
                pPato.Visible = true;
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.domesticosBindingSource.MoveFirst();
            if (txtnombre.Text == "Perro")
            {
                pPerro.Visible = true;
                pGato.Visible = false;
                pConejo.Visible = false;
                pCerdo.Visible = false;
                pPato.Visible = false;
            }
            if (txtnombre.Text == "Gato")
            {
                pPerro.Visible = false;
                pGato.Visible = true;
                pConejo.Visible = false;
                pCerdo.Visible = false;
                pPato.Visible = false;
            }
            if (txtnombre.Text == "Conejo") 
            {
                pPerro.Visible = false;
                pGato.Visible = false;
                pConejo.Visible = true;
                pCerdo.Visible = false;
                pPato.Visible = false;
            }
            if (txtnombre.Text == "Cerdo")
            {
                pPerro.Visible = false;
                pGato.Visible = false;
                pConejo.Visible = false;
                pCerdo.Visible = true;
                pPato.Visible = false;
            }
            if (txtnombre.Text == "Pato")
            {
                pPerro.Visible = false;
                pGato.Visible = false;
                pConejo.Visible = false;
                pCerdo.Visible = false;
                pPato.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.domesticosBindingSource.MovePrevious();
            if (txtnombre.Text == "Perro")
            {
                pPerro.Visible = true;
                pGato.Visible = false;
                pConejo.Visible = false;
                pCerdo.Visible = false;
                pPato.Visible = false;
            }
            if (txtnombre.Text == "Gato")
            {
                pPerro.Visible = false;
                pGato.Visible = true;
                pConejo.Visible = false;
                pCerdo.Visible = false;
                pPato.Visible = false;
            }
            if (txtnombre.Text == "Conejo")
            {
                pPerro.Visible = false;
                pGato.Visible = false;
                pConejo.Visible = true;
                pCerdo.Visible = false;
                pPato.Visible = false;
            }
            if (txtnombre.Text == "Cerdo")
            {
                pPerro.Visible = false;
                pGato.Visible = false;
                pConejo.Visible = false;
                pCerdo.Visible = true;
                pPato.Visible = false;
            }
            if (txtnombre.Text == "Pato")
            {
                pPerro.Visible = false;
                pGato.Visible = false;
                pConejo.Visible = false;
                pCerdo.Visible = false;
                pPato.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.domesticosBindingSource.MoveNext();
            if (txtnombre.Text == "Perro")
            {
                pPerro.Visible = true;
                pGato.Visible = false;
                pConejo.Visible = false;
                pCerdo.Visible = false;
                pPato.Visible = false;
            }
            if (txtnombre.Text == "Gato")
            {
                pPerro.Visible = false;
                pGato.Visible = true;
                pConejo.Visible = false;
                pCerdo.Visible = false;
                pPato.Visible = false;
            }
            if (txtnombre.Text == "Conejo")
            {
                pPerro.Visible = false;
                pGato.Visible = false;
                pConejo.Visible = true;
                pCerdo.Visible = false;
                pPato.Visible = false;
            }
            if (txtnombre.Text == "Cerdo")
            {
                pPerro.Visible = false;
                pGato.Visible = false;
                pConejo.Visible = false;
                pCerdo.Visible = true;
                pPato.Visible = false;
            }
            if (txtnombre.Text == "Pato")
            {
                pPerro.Visible = false;
                pGato.Visible = false;
                pConejo.Visible = false;
                pCerdo.Visible = false;
                pPato.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.domesticosBindingSource.MoveLast();
            if (txtnombre.Text == "Perro")
            {
                pPerro.Visible = true;
                pGato.Visible = false;
                pConejo.Visible = false;
                pCerdo.Visible = false;
                pPato.Visible = false;
            }
            if (txtnombre.Text == "Gato")
            {
                pPerro.Visible = false;
                pGato.Visible = true;
                pConejo.Visible = false;
                pCerdo.Visible = false;
                pPato.Visible = false;
            }
            if (txtnombre.Text == "Conejo")
            {
                pPerro.Visible = false;
                pGato.Visible = false;
                pConejo.Visible = true;
                pCerdo.Visible = false;
                pPato.Visible = false;
            }
            if (txtnombre.Text == "Cerdo")
            {
                pPerro.Visible = false;
                pGato.Visible = false;
                pConejo.Visible = false;
                pCerdo.Visible = true;
                pPato.Visible = false;
            }
            if (txtnombre.Text == "Pato")
            {
                pPerro.Visible = false;
                pGato.Visible = false;
                pConejo.Visible = false;
                pCerdo.Visible = false;
                pPato.Visible = true;
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
