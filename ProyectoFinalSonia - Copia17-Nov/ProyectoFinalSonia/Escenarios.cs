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
    public partial class Escenarios : Form
    {
        public Escenarios()
        {
            InitializeComponent();
        }

        private void Escenarios_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PantallaCarga loading = new PantallaCarga();
            loading.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PantallaCarga loading = new PantallaCarga();
            loading.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
