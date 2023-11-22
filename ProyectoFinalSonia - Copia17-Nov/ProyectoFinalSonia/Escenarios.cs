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
        Image p1, p2;
        List<PictureBox> Esenarios = new List<PictureBox>();
        public Escenarios(Image P1,Image P2)
        {
            InitializeComponent();
            p1 = P1; p2 = P2;
            Esenarios.Add(PBmapa1);
            Esenarios.Add(PBmapa2);
            Esenarios.Add(PBmapa3);
            Esenarios.Add(PBmapa4);
            Esenarios.Add(PBmapa5);
            Esenarios.Add(PBmapa6);
        }
        PantallaCarga loading;

        private void Escenarios_Load(object sender, EventArgs e)
        {
            PbMapSelected.Image = PBmapa1.BackgroundImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loading = new PantallaCarga(p1, p2, PbMapSelected.Image);
            loading.Show();
            this.Hide();
        }
        Random r = new Random();
        private void BAleatoreo_Click(object sender, EventArgs e)
        {
            PbMapSelected.Image = Esenarios[r.Next(0, 6)].BackgroundImage;
        }

        private void PBmapa2_Click(object sender, EventArgs e)
        {
            PbMapSelected.Image = PBmapa2.BackgroundImage;

        }

        private void PBmapa3_Click(object sender, EventArgs e)
        {
            PbMapSelected.Image = PBmapa3.BackgroundImage;

        }

        private void PBmapa4_Click(object sender, EventArgs e)
        {
            PbMapSelected.Image = PBmapa4.BackgroundImage;

        }

        private void PBmapa5_Click(object sender, EventArgs e)
        {
            PbMapSelected.Image = PBmapa5.BackgroundImage;

        }

        private void PBmapa6_Click(object sender, EventArgs e)
        {
            PbMapSelected.Image = PBmapa6.BackgroundImage;
        }

        private void PBmapa1_Click(object sender, EventArgs e)
        {
            PbMapSelected.Image = PBmapa1.BackgroundImage;
        }
    }
}
