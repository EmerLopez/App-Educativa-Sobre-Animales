using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace App_Educativa_Sobre_Animales
{
    public partial class Registro : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=desktop-2j7g32a;Initial Catalog=FENAHE;Integrated Security=True");

        public Registro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false && textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {

                MessageBox.Show("Ingrese sus datos correctamente y acepte los terminos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conexion.Open();
                SqlCommand f = new SqlCommand("insert into PERSONAS ([USUARIOS] ,[CONTRASENA], [CORREO]) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "' ) ", conexion);
                f.ExecuteNonQuery();
                MessageBox.Show("Registro guardado");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                conexion.Close();

            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            
        }
    }
}
