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
    public partial class Login : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-6SBSS7S;Initial Catalog=FENAHE;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Seguir_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand consulta = new SqlCommand("select USUARIOS, CONTRASENA from PERSONAS where USUARIOS = '" + textBox1.Text + "'And CONTRASENA = '" + textBox2.Text + "' ", conexion);

                consulta.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(consulta);

                da.Fill(ds, "PERSONAS");

                DataRow registro;
                registro = ds.Tables["PERSONAS"].Rows[0];

                if ((textBox1.Text == registro["USUARIOS"].ToString()) || (textBox2.Text == registro["CONTRASENA"].ToString()))
                {

                    Menu fprincipal = new Menu();
                    fprincipal.Show();
                    this.Hide();
                }


            }
            catch
            {
                MessageBox.Show("Error de usuario o clave de acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand f = new SqlCommand("insert into PERSONAS ([USUARIOS] ,[CONTRASENA]) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "') ", conexion);
            f.ExecuteNonQuery();
            MessageBox.Show("Registro guardado");

            conexion.Close();
        }
    }
}
