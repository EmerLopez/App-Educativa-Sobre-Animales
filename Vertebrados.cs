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
    public partial class Vertebrados : Form
    {
        public Vertebrados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            animalesvertebrados av = new animalesvertebrados();
            this.Hide();
            av.Show();


        }

        private void Vertebrados_Load(object sender, EventArgs e)
        {

        }
    }
}
