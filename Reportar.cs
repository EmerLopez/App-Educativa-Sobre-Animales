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
    public partial class Reportar : Form
    {
        public Reportar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            MessageBox.Show("Pronto nos comunicaremos con usted para solventar su problema");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
