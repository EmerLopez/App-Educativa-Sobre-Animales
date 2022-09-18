using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace App_Educativa_Sobre_Animales
{
    public partial class fusuario : Form
    {
        OleDbConnection miconexion = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\Users\Edwin\Documents\LoginAccess.mdb; Persist Security Info=False;");
        //public OleDbCommand miconexion;

        public string usuario_modificar;
        public fusuario()
        {
            

            InitializeComponent();
        }

        private void fusuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'loginAccessDataSet1.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter1.Fill(this.loginAccessDataSet1.Usuarios);
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;

            this.usuariosTableAdapter1.Fill(this.loginAccessDataSet1.Usuarios);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bprimero_Click(object sender, EventArgs e)
        {
            this.usuariosBindingSource1.MoveFirst();
        }

        private void banterior_Click(object sender, EventArgs e)
        {
            this.usuariosBindingSource1.MovePrevious();
        }

        private void bsiguiente_Click(object sender, EventArgs e)
        {
            this.usuariosBindingSource1.MoveNext();
        }

        private void bultimo_Click(object sender, EventArgs e)
        {
            this.usuariosBindingSource1.MoveLast();
        }

        private void bnuevo_Click(object sender, EventArgs e)
        {
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            lstnivel.Enabled = true;
            txtusuario.Text = "";
            txtclave.Text = "";
            lstnivel.Text = "Seleccione nivel";
            txtusuario.Focus();
            bnuevo.Visible = false;
            bguardar.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void belimiar_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand eliminar = new OleDbCommand();
                miconexion.Open();
                eliminar.Connection = miconexion;
                eliminar.CommandType = CommandType.Text;

                eliminar.CommandText = "DELETE FROM Usuarios WHERE nombre = '" + txtusuario.Text.ToString() + "'";


                eliminar.ExecuteNonQuery();
                this.usuariosBindingSource1.MoveNext();
                miconexion.Close();

                //Mensaje que se guardó correctamente 
                MessageBox.Show("Usuario eliminado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //this.tusuarioTableAdapter.Fill(this.sistemaDataSet.tusuario);  
                this.usuariosBindingSource1.MovePrevious();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            try
            {

                OleDbCommand guardar = new OleDbCommand();
                miconexion.Open();
                guardar.Connection = miconexion;
                guardar.CommandType = CommandType.Text;

                guardar.CommandText = "INSERT INTO Usuarios ([nombre], [password],[Nivel]) Values('" + txtusuario.Text.ToString() + "', '" + txtclave.Text.ToString() + "','" + lstnivel.Text.ToString() + "')";

                guardar.ExecuteNonQuery();
                miconexion.Close();

                bnuevo.Visible = true;
                bguardar.Visible = false;

                //Deshabilitar campos, se activan al crear nuevo registro 
                txtusuario.Enabled = false;
                txtclave.Enabled = false;
                lstnivel.Enabled = false;
                bnuevo.Focus();

                //Mensaje que se guardó correctamente 
                MessageBox.Show("Usuario agregado con éxito", "Ok",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.usuariosTableAdapter1.Fill(this.loginAccessDataSet1.Usuarios);
                this.usuariosBindingSource1.MoveLast();
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void bmodificar_Click(object sender, EventArgs e)
        {
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            lstnivel.Enabled = true;
            txtusuario.Focus();
            bmodificar.Visible = false;
            bactualizar.Visible = true;

            usuario_modificar = txtusuario.Text.ToString();
        }

        private void bactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand actualizar = new OleDbCommand();
                miconexion.Open();
                actualizar.Connection = miconexion;
                actualizar.CommandType = CommandType.Text;


                string nom = txtusuario.Text.ToString();
                string cla = txtclave.Text.ToString();
                string niv = lstnivel.Text.ToString();

                actualizar.CommandText = "UPDATE Usuarios set nombre = '" + nom + "'WHERE nombre = '" + usuario_modificar + "'";

                actualizar.CommandText = "UPDATE Usuarios set password = '" + cla + "'  WHERE nombre = '" + usuario_modificar + "'";

                actualizar.CommandText = "UPDATE Usuarios set Nivel = '" + niv + "' WHERE nombre = '" + usuario_modificar + "'";

                actualizar.ExecuteNonQuery();
                miconexion.Close();

                bmodificar.Visible = true;
                bactualizar.Visible = false;
                txtusuario.Enabled = false;
                txtclave.Enabled = false;
                lstnivel.Enabled = false;

                MessageBox.Show("Usuario actualizado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            try
            { 
                OleDbCommand actualizar = new OleDbCommand();
                miconexion.Open();
                actualizar.Connection = miconexion;
                actualizar.CommandType = CommandType.Text;


                string nom = txtusuario.Text.ToString();
                string cla = txtclave.Text.ToString();
                string niv = lstnivel.Text.ToString(); 

                actualizar.CommandText = "UPDATES Usuarios SET nombre = '" + nom + "', password = '" + cla + "',Nivel = '" + niv + "' WHERE nombre = '" + usuario_modificar + "'";

                actualizar.ExecuteNonQuery();
                miconexion.Close();

                bmodificar.Visible = true;
                bactualizar.Visible = false;

                txtusuario.Enabled = false;
                txtclave.Enabled = false;
                lstnivel.Enabled = false;

                MessageBox.Show("Usuario actualizado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}

