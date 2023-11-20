using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace ProyectoFinalSonia
{
    public class Personaje:PictureBox
    {
        Panel PanelHeroes, PanelVillanos;
        public Personaje(Control con,Panel PanelHeroes,Panel PanelVillanos,int numP)
        {
            this.PanelHeroes = PanelHeroes;
            this.PanelVillanos = PanelVillanos;
            this.Parent = con;
            Width = Height = 110;
            SizeMode = PictureBoxSizeMode.StretchImage;
            con.Controls.Add(this);
            NumPersonaje = numP;
            this.BackColor = Color.Red;
            this.Click += Personaje_Click;
        }

        private void Personaje_Click(object sender, EventArgs e)
        {

        }

        private int numPersonaje;

        public int NumPersonaje
        {
            get { return numPersonaje; }
            set { numPersonaje = value; }
        }
      
        public void CargarImagen(Personaje pers)
        {
            switch (pers.NumPersonaje)
            {
                case 1:
                    if (pers.PersonajeVando) pers.Image = ProyectoFinalSonia.Properties.Resources.gwen;
                    else pers.Image = ProyectoFinalSonia.Properties.Resources.miguelitoO;
                    break;
                case 2:
                    if (pers.PersonajeVando) pers.Image = ProyectoFinalSonia.Properties.Resources.hobie_brown;
                    else pers.Image = ProyectoFinalSonia.Properties.Resources.miguelitoO;
                    break;
                case 3:
                    if (pers.PersonajeVando) pers.Image = ProyectoFinalSonia.Properties.Resources.miguelitoO;
                    else pers.Image = ProyectoFinalSonia.Properties.Resources.miguelitoO;
                    break;
                case 4:
                    if (pers.PersonajeVando) pers.Image = ProyectoFinalSonia.Properties.Resources.miles_morales_CARA;
                    else pers.Image = ProyectoFinalSonia.Properties.Resources.miguelitoO;
                    break;
                case 5:
                    if (pers.PersonajeVando) pers.Image = ProyectoFinalSonia.Properties.Resources.piterman;
                    else pers.Image = ProyectoFinalSonia.Properties.Resources.miguelitoO;
                    break;
                case 6:
                    pers.Image = ProyectoFinalSonia.Properties.Resources._85315938_icono_de_signo_de_interrogación;
                    break;
            }
        }
        private bool vando;

        public bool PersonajeVando
        {
            get { return vando; }
            set { vando = value; }
        }
    }
}
