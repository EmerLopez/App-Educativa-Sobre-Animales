using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace App_Educativa_Sobre_Animales
{
    public partial class FormularioAyuda : Form
    {
        public FormularioAyuda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormularioAyuda_Load(object sender, EventArgs e)
        {
            /*{
                if (label1.Visible == true)
                {

                    StreamReader Archivo = new StreamReader("");
                    string Linea = "";
                    ArrayList Contenido = new ArrayList();
                    while (Linea != null)
                    {
                        Linea = Archivo.ReadLine();
                        if (Linea != null)
                            Contenido.Add(Linea);
                        richTextBox1.Text = Linea;
                    }
                    Archivo.Close();
                    richTextBox1.Text = "";
                    foreach (string Linea_mostrar in Contenido)
                    {
                        richTextBox1.Text = richTextBox1.Text + Linea_mostrar;
                    }
                }
                
        }
            */
        }
    }
}
