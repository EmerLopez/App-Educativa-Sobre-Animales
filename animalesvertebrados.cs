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

namespace vertebrados
{
    public partial class Vertebrados : Form

    {
        public string cadena_conexion = "server=Localhost;user id=root;password=;database=vertebrados";
        public Vertebrados()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.vertebradosBindingSource.MoveFirst();
            if (txtnombre.Text == "Elefante")
            {
                pvaca.Visible = false;
                pajolote.Visible = false;
                pcaballo.Visible = false;
                plemur.Visible = false;
                pelefante.Visible = true;

            }
            if (txtnombre.Text == "Lemur")
            {
                pajolote.Visible = false;
                pvaca.Visible = false;
                pcaballo.Visible = false;
                pelefante.Visible = false;
                plemur.Visible = true;
            }
            if (txtnombre.Text == "Vacas")
            {
                plemur.Visible = false;
                pajolote.Visible = false;
                pcaballo.Visible = false;
                pelefante.Visible = false;
                pvaca.Visible = true;
            }
            if (txtnombre.Text == "Ajolote")
            {
                pvaca.Visible = false;
                plemur.Visible = false;
                pcaballo.Visible = false;
                pelefante.Visible = false;
                pajolote.Visible = true;
            }
            if (txtnombre.Text == "Caballo")
            {
                pvaca.Visible = false;
                pajolote.Visible = false;
                pelefante.Visible = false;
                plemur.Visible = false;
                pcaballo.Visible = true;
            }
        }

        private void Vertebrados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vertebradosDataSet.vertebrados' Puede moverla o quitarla según sea necesario.
            this.vertebradosTableAdapter.Fill(this.vertebradosDataSet.vertebrados);
            pelefante.Visible = true;

        }

        private void banterior_Click(object sender, EventArgs e)
        {
            this.vertebradosBindingSource.MovePrevious();
            if (txtnombre.Text == "Elefante")
            {
                pvaca.Visible = false;
                pajolote.Visible = false;
                pcaballo.Visible = false;
                plemur.Visible = false;
                pelefante.Visible = true;

            }
            if (txtnombre.Text == "Lemur")
            {
                pajolote.Visible = false;
                pvaca.Visible = false;
                pcaballo.Visible = false;
                pelefante.Visible = false;
                plemur.Visible = true;
            }
            if (txtnombre.Text == "Vacas")
            {
                plemur.Visible = false;
                pajolote.Visible = false;
                pcaballo.Visible = false;
                pelefante.Visible = false;
                pvaca.Visible = true;
            }
            if (txtnombre.Text == "Ajolote")
            {
                pvaca.Visible = false;
                plemur.Visible = false;
                pcaballo.Visible = false;
                pelefante.Visible = false;
                pajolote.Visible = true;
            }
            if (txtnombre.Text == "Caballo")
            {
                pvaca.Visible = false;
                pajolote.Visible = false;
                pelefante.Visible = false;
                plemur.Visible = false;
                pcaballo.Visible = true;
            }
        }

        private void bsiguiente_Click(object sender, EventArgs e)
        {
            this.vertebradosBindingSource.MoveNext();
            if (txtnombre.Text == "Elefante")
            {
                pvaca.Visible = false;
                pajolote.Visible = false;
                pcaballo.Visible = false;
                plemur.Visible = false;
                pelefante.Visible = true;

            }
            if (txtnombre.Text == "Lemur")
            {
                pajolote.Visible = false;
                pvaca.Visible = false;
                pcaballo.Visible = false;
                pelefante.Visible = false;
                plemur.Visible = true;
            }
            if (txtnombre.Text == "Vacas")
            {
                plemur.Visible = false;
                pajolote.Visible = false;
                pcaballo.Visible = false;
                pelefante.Visible = false;
                pvaca.Visible = true;
            }
            if (txtnombre.Text == "Ajolote")
            {
                pvaca.Visible = false;
                plemur.Visible = false;
                pcaballo.Visible = false;
                pelefante.Visible = false;
                pajolote.Visible = true;
            }
            if (txtnombre.Text == "Caballo")
            {
                pvaca.Visible = false;
                pajolote.Visible = false;
                pelefante.Visible = false;
                plemur.Visible = false;
                pcaballo.Visible = true;
            }
        }

        private void bultimo_Click(object sender, EventArgs e)
        {
            this.vertebradosBindingSource.MoveLast();
            if (txtnombre.Text == "Elefante")
            {
                pvaca.Visible = false;
                pajolote.Visible = false;
                pcaballo.Visible = false;
                plemur.Visible = false;
                pelefante.Visible = true;

            }
            if (txtnombre.Text == "Lemur")
            {
                pajolote.Visible = false;
                pvaca.Visible = false;
                pcaballo.Visible = false;
                pelefante.Visible = false;
                plemur.Visible = true;
            }
            if (txtnombre.Text == "Vacas")
            {
                plemur.Visible = false;
                pajolote.Visible = false;
                pcaballo.Visible = false;
                pelefante.Visible = false;
                pvaca.Visible = true;
            }
            if (txtnombre.Text == "Ajolote")
            {
                pvaca.Visible = false;
                plemur.Visible = false;
                pcaballo.Visible = false;
                pelefante.Visible = false;
                pajolote.Visible = true;
            }
            if (txtnombre.Text == "Caballo")
            {
                pvaca.Visible = false;
                pajolote.Visible = false;
                pelefante.Visible = false;
                plemur.Visible = false;
                pcaballo.Visible = true;
            }
        }

        private void bbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                myConnection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = myConnection;
                comando.CommandText = ("select * from vertebrados Where nombre = '" + txtbuscar.Text + "'");
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
            if (txtnombre.Text == "Elefante")
            {
                pvaca.Visible = false;
                pajolote.Visible = false;
                pcaballo.Visible = false;
                plemur.Visible = false;
                pelefante.Visible = true;

            }
            if (txtnombre.Text == "Lemur")
            {
                pajolote.Visible = false;
                pvaca.Visible = false;
                pcaballo.Visible = false;
                pelefante.Visible = false;
                plemur.Visible = true;
            }
            if (txtnombre.Text == "Vacas")
            {
                plemur.Visible = false;
                pajolote.Visible = false;
                pcaballo.Visible = false;
                pelefante.Visible = false;
                pvaca.Visible = true;
            }
            if (txtnombre.Text == "Ajolote")
            {
                pvaca.Visible = false;
                plemur.Visible = false;
                pcaballo.Visible = false;
                pelefante.Visible = false;
                pajolote.Visible = true;
            }
            if (txtnombre.Text == "Caballo")
            {
                pvaca.Visible = false;
                pajolote.Visible = false;
                pelefante.Visible = false;
                plemur.Visible = false;
                pcaballo.Visible = true;
            }
        }
    }
}
