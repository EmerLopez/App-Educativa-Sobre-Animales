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
    public partial class Form1 : Form
    {
        public Form1()
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
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
