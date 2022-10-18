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
using MySql.Data.MySqlClient;
using System.Data.OleDb;


namespace App_Educativa_Sobre_Animales
{
    public partial class Login : Form
    {
        MySqlConnection conn = new MySqlConnection("server=Localhost;user id=wzadmins;password=12345;database=wonderzoo");
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-LMJ3198;Initial Catalog=FENAHE;Integrated Security=True");
        
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
            Registro res = new Registro();
            res.Show();
            this.Hide();
        }

        private void lmysql_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void lmysql_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand Pedir = new MySqlCommand("Select nombre, clave, correo from usuarios where nombre = '" + textBox1.Text + "'And clave = '" + textBox2.Text + "'", conn);
                Pedir.ExecuteNonQuery();
                DataSet fe = new DataSet();
                MySqlDataAdapter te = new MySqlDataAdapter(Pedir);

                te.Fill(fe, "usuarios");


                DataRow res;
                res = fe.Tables["usuarios"].Rows[0];

                if ((textBox1.Text == res["nombre"].ToString()) || (textBox2.Text == res["clave"].ToString()))
                {

                    Menu fprincipal = new Menu();
                    fprincipal.Show();
                    this.Hide();




                }

            }
            catch
            {


                textBox1.Clear();
                textBox2.Clear();

                MessageBox.Show("Error de usuario o clave de acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }

}
