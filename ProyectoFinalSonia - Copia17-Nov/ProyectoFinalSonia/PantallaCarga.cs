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
    public partial class PantallaCarga : Form
    {
        Juego game;
        public PantallaCarga(Image P1, Image P2,Image Esenario)
        {
            InitializeComponent();
              game  = new Juego(P1, P2, Esenario);
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i == 30)
            {
                game.Show();
                this.Hide();
                timer1.Stop();
                
            }
            else i++;
           
        }
    }
}
