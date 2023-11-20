using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalSonia
{
    public partial class Perdiste : Form
    {
        public Perdiste()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModoJuego modojuego = new ModoJuego();
            modojuego.Show();
            this.Hide();
        }
    }
}
