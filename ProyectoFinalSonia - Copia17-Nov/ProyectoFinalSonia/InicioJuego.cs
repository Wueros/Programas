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
    public partial class InicioJuego : Form
    {
        public InicioJuego()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ModoJuego modojuego = new ModoJuego();
            modojuego.Show();
            this.Hide();
        }
    }
}
