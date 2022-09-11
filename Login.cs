﻿using System;
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


namespace App_Educativa_Sobre_Animales
{
    public partial class Login : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost; Database=fenahe; Uid=Diego; Pwd=12345");
        SqlConnection conexion = new SqlConnection("Data Source=desktop-2j7g32a;Initial Catalog=FENAHE;Integrated Security=True");
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand Pedir = new MySqlCommand("Select Nombre, Contrasena, CORREO from usuarios where Nombre = '" + textBox1.Text + "'And Contrasena = '" + textBox2.Text + "'", conn);
                Pedir.ExecuteNonQuery();
                DataSet fe = new DataSet();
                MySqlDataAdapter te = new MySqlDataAdapter(Pedir);

                te.Fill(fe, "usuarios");

                DataRow res;
                res = fe.Tables["usuarios"].Rows[0];

                if ((textBox1.Text == res["Nombre"].ToString()) || (textBox2.Text == res["Contrasena"].ToString()))
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
