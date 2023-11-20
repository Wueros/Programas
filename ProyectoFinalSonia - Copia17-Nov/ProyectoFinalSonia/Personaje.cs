using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            Width = Height = 100;
            SizeMode = PictureBoxSizeMode.StretchImage;
            Top = Left = 00;
            con.Controls.Add(this);
            NumPersonaje = numP;
            CargarImagen(this);
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
                    if (Vando(pers)) pers.Image = ProyectoFinalSonia.Properties.Resources.gwen;
                    else pers.Image = ProyectoFinalSonia.Properties.Resources.miguelitoO;
                    break;
                case 2:
                    if (Vando(pers)) pers.Image = ProyectoFinalSonia.Properties.Resources.hobie_brown;
                    else pers.Image = ProyectoFinalSonia.Properties.Resources.miguelitoO;
                    break;
                case 3:
                    if (Vando(pers)) pers.Image = ProyectoFinalSonia.Properties.Resources.miguelitoO;
                    else pers.Image = ProyectoFinalSonia.Properties.Resources.miguelitoO;
                    break;
                case 4:
                    if (Vando(pers)) pers.Image = ProyectoFinalSonia.Properties.Resources.miles_morales_CARA;
                    else pers.Image = ProyectoFinalSonia.Properties.Resources.miguelitoO;
                    break;
                case 5:
                    if (Vando(pers)) pers.Image = ProyectoFinalSonia.Properties.Resources.piterman;
                    else pers.Image = ProyectoFinalSonia.Properties.Resources.miguelitoO;
                    break;
                case 6:
                    pers.Image = ProyectoFinalSonia.Properties.Resources._85315938_icono_de_signo_de_interrogación;
                    break;
            }
        }
        public bool Vando(Personaje pers)
        {
            if (pers.Parent == PanelHeroes)
            {
                return true;//heroes
            }
            else return false;//villanos
        }
    }
}
