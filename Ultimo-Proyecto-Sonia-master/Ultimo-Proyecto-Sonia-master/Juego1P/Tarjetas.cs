using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Juego1P
{
    public class Tarjetas : PictureBox
    {

        public Tarjetas()
        {
            Tarselected = null;
        }
        public Tarjetas(Control control, int numTar)
        {
            Tarselected = null;
            Parent = control;
            Width = (control.Width / 4) - 15;
            Height = control.Height;
            Dock = DockStyle.Left;
            SizeMode = PictureBoxSizeMode.Zoom;
            NumTarjeta = numTar;
            this.Click += Tarjetas_Click;
        }
        private Tarjetas tarjeta;

        public Tarjetas Tarselected
        {
            get { return tarjeta; }
            set { tarjeta = value; }
        }

        private void Tarjetas_Click(object sender, EventArgs e)
        {
            Tarselected = (Tarjetas)sender;
            AsignacionDeDaño(Tarselected);
            int i = 0;
            while (i < 8)
            {
                ImagenTarjeta(this, Tarselected);
                i++;
            }

        }
        private int numTarjeta;

        public int NumTarjeta
        {
            get { return numTarjeta; }
            set { numTarjeta = value; }
        }

        public void ImagenTarjeta(Tarjetas tar, Tarjetas tarSelected)
        {
            if (tar == tarSelected)
            {
                switch (tar.NumTarjeta)
                {
                    case 1:
                        if (Vando) tar.Image = Juego1P.Properties.Resources.AtackHeroeNv1Seleccion;
                        else tar.Image = Juego1P.Properties.Resources.AtackVillnv1Seleccion;
                        break;
                    case 2:
                        if (Vando) tar.Image = Juego1P.Properties.Resources.AtackNv2HeroesSeleccion;
                        else tar.Image = Juego1P.Properties.Resources.AtackVillnv2Seleccion;
                        break;
                    case 3:
                        if (Vando) tar.Image = Juego1P.Properties.Resources.AtackHeroeNv3Seleccion;
                        else tar.Image = Juego1P.Properties.Resources.AtackVillanNv3Seleccion;
                        break;
                    case 4:
                        if (Vando) tar.Image = Juego1P.Properties.Resources.Atacknv4HeroeSeleccion;
                        else tar.Image = Juego1P.Properties.Resources.AtackVillanNv4Seleccion;
                        break;
                    case 5:
                        if (Vando) tar.Image = Juego1P.Properties.Resources.EscudoHeroesSeleccion;
                        else tar.Image = Juego1P.Properties.Resources.EscudoVillSeleccion;
                        break;
                    case 6:
                        if (Vando) tar.Image = Juego1P.Properties.Resources.VidaHeoresSeleccion;
                        else tar.Image = Juego1P.Properties.Resources.VidaVillSeleccion;
                        break;
                    case 7:

                        if (Vando) tar.Image = Juego1P.Properties.Resources.EspecialHeroesSeleccion;
                        else tar.Image = Juego1P.Properties.Resources.AtackVillanEspecialSeleccion;
                        break;



                }
            }
            else
            {
                switch (NumTarjeta)
                {
                    case 1:

                        if (Vando) tar.Image = Juego1P.Properties.Resources.AtackHeroeNv1;
                        else tar.Image = Juego1P.Properties.Resources.AtackVillnv1;
                        break;
                    case 2:
                        if (Vando) tar.Image = Juego1P.Properties.Resources.AtackNv2Heroes;
                        else tar.Image = Juego1P.Properties.Resources.AtackVillnv2;
                        break;
                    case 3:
                        if (Vando) tar.Image = Juego1P.Properties.Resources.AtackHeroeNv3__1_;
                        else tar.Image = Juego1P.Properties.Resources.AtackVillanNv3;
                        break;
                    case 4:
                        if (Vando) tar.Image = Juego1P.Properties.Resources.Atacknv4Heroe;
                        else tar.Image = Juego1P.Properties.Resources.AtackVillanNv4;
                        break;
                    case 5:
                        if (Vando) tar.Image = Juego1P.Properties.Resources.EscudoHeroes;
                        else tar.Image = Juego1P.Properties.Resources.EscudoVill;
                        break;
                    case 6:
                        if (Vando) tar.Image = Juego1P.Properties.Resources.VidaHeores;
                        else tar.Image = Juego1P.Properties.Resources.VidaVill__1_;
                        break;
                    case 7:
                        if (Vando) tar.Image = Juego1P.Properties.Resources.EspecialHeroes;
                        else tar.Image = Juego1P.Properties.Resources.AtackVillanEspecial;
                        break;

                }
            }
        }


        private bool vando;  //true = vando heroes

        public bool Vando
        {
            get { return vando; }
            set { vando = value; }
        }

        private int aumentoDeVida;

        public int AumentoDeVida
        {
            get { return aumentoDeVida; }
            set { aumentoDeVida = value; }
        }
        private bool escudoP2;

        public bool EscudoActivoP2
        {
            get { return escudoP2; }
            set { escudoP2 = value; }
        }
        private bool escudoP1;

        public bool EscudoActivoP1
        {
            get { return escudoP1; }
            set { escudoP1 = value; }
        }

        private int daño;

        public int Daño
        {
            get { return daño; }
            set { daño = value; }
        }
        public void AsignacionDeDaño(Tarjetas tar)
        {
          
                switch (tar.NumTarjeta)
                {
                    case 1:
                      Daño = 10;
                        AumentoDeVida = 0;
                        break;
                    case 2:
                        Daño = 15;
                        AumentoDeVida = 0;
                        break;
                    case 3:
                       Daño = 20;
                        AumentoDeVida = 0;
                        break;
                    case 4:
                        Daño = 25;
                        AumentoDeVida = 0;
                        break;
                    case 5:
                        Daño = 0;
                        AumentoDeVida = 0;
                        break;
                    case 6:
                        Daño = 0;
                        AumentoDeVida = 10;
                        break;
                    case 7:
                        Daño = 50;
                        break;
                }
            
           
            
        }
        public void AdaptarTamaño(Tarjetas tar, Control Contenedor)
        {
            
                tar.Width = (Contenedor.Width / 4)-15 ;
                tar.Height = Contenedor.Height;
                tar.Dock = DockStyle.Left;
        }


    }
}


