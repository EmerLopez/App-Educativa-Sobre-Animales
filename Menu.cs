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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vertebrados f = new Vertebrados();
            f.Show();
        }

        private void acercadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acercade f = new Acercade();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Domésticos f = new Domésticos();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vivíparos f = new Vivíparos();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ovíparos f = new Ovíparos();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Omnívoros f = new Omnívoros();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Anfibios f = new Anfibios();
            f.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void terminosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Terminos f = new Terminos();
            f.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportar f = new Reportar();
            f.Show();
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.SteelBlue;
            BackColor = Color.CornflowerBlue;

        }

        private void negroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.DeepPink;
            BackColor = Color.HotPink;
        }

        private void reestablecerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormularioAyuda f = new FormularioAyuda();
            f.Show();
           
            
        }

        private void administrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //fusuario kk = new fusuario();
            //kk.Show();
        }

        private void uGBVerdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UGBVerde Vd = new UGBVerde();
            Vd.Show();
        }

        private void administrarUsuariosConMysqlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fusuariosMySQL rr = new fusuariosMySQL();
            rr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            invertebrados inverte = new invertebrados();
            inverte.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            herviboros her = new herviboros();
            her.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Carnivoros CC = new Carnivoros();
            CC.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Salvajes sal = new Salvajes();
            sal.Show();
        }
    }
}
