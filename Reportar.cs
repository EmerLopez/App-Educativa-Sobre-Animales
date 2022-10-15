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
    public partial class Reportar : Form
    {
        public string cadena_conexion = "Database=fenahe;Data Source=localhost;User Id=edwin;Password=1234";
        public Reportar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

            string myInsertQuery = "INSERT INTO reportes(descripcion,correo)Values(?descripcion,?correo)";
            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

            //myCommand.Parameters.Add("?idreporte", MySqlDbType.Int32, 11).Value = textBox3.Text;
            myCommand.Parameters.Add("?descripcion", MySqlDbType.VarChar, 400).Value = textBox1.Text;
            myCommand.Parameters.Add("?correo", MySqlDbType.VarChar, 100).Value = textBox2.Text;

            myCommand.Connection = myConnection;
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myCommand.Connection.Close();

            MessageBox.Show("Gracias por su reporte", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
