using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Educativa_Sobre_Animales
{
    public partial class Registro : Form
    {
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
            Conexion.Open();
            SqlCommand f = new SqlCommand("insert into PERSONAS ([USUARIOS] ,[CONTRASENA], [CORREO]) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "' ) ", Conexion);
            f.ExecuteNonQuery();
            MessageBox.Show("Registro guardado");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            Conexion.Close();
        }
    }
}
