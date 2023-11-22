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
    public partial class Juego : Form
    {
        
        Tarjetas[] TarjetasArreglo = new Tarjetas[8];
        LogicaJuego juego;
        Tarjetas TarjetSelected;
        Random r = new Random();
        bool escudoP1 = false, escudoP2 = false;

        public Juego(Image P1,Image P2,Image mapa)
        {
            InitializeComponent();
            Tim.Start();
            juego = new LogicaJuego(PanelP1, PanelP2, VidaP1, VidaP2);
            PBFondo.Image = mapa;
            this.BackgroundImage = mapa;
            PbPersonajeP1.Image = P1;
            PbPersonajeP2.Image = P2;
            PbPersonajeP1.SizeMode = PictureBoxSizeMode.StretchImage;
            PbPersonajeP2.SizeMode = PictureBoxSizeMode.StretchImage;
            TarjetSelected = new Tarjetas();
            int i = 0;
            foreach (Tarjetas tar in TarjetasArreglo)
            {
                if (i < 4)
                {
                    TarjetasArreglo[i] = new Tarjetas(PanelP1, r.Next(1, 7));
                    PanelP1.Controls.Add(TarjetasArreglo[i]);
                    TarjetasArreglo[i].Vando = true;
                    TarjetasArreglo[i].ImagenTarjeta(TarjetasArreglo[i], TarjetSelected);

                }
                else
                {
                    TarjetasArreglo[i] = new Tarjetas(PanelP2, r.Next(1, 7));
                    PanelP2.Controls.Add(TarjetasArreglo[i]);
                    TarjetasArreglo[i].Vando = false;
                    TarjetasArreglo[i].ImagenTarjeta(TarjetasArreglo[i], TarjetSelected);
                    TarjetasArreglo[i].Image = ProyectoFinalSonia.Properties.Resources.Reverso;
                }
                TarjetasArreglo[i].Click += F1_Click;
                i++;
            }
            TarjetSelected = TarjetasArreglo[0];
            SeleccionCarta(TarjetSelected);
        }


        private void F1_Click(object sender, EventArgs e)
        {
            TarjetSelected.Tarselected = (Tarjetas)sender;
            TarjetSelected = TarjetSelected.Tarselected;
            TarjetSelected.AsignacionDeDaño(TarjetSelected);
            foreach (Tarjetas t in TarjetasArreglo)
            {
                t.ImagenTarjeta(t, TarjetSelected);
                SeleccionCarta(t);
                if (t.Parent == juego.PanelContrario_SetGet)
                    t.Image = ProyectoFinalSonia.Properties.Resources.Reverso;
            }

        }
        public void SeleccionCarta(Tarjetas tar)
        {
            if (tar == TarjetSelected)
            {
                tar.Width = (tar.Parent.Width / 4) + 30;
            }
            else
            {
                tar.Width = (tar.Parent.Width / 4) - 10;

            }
        }
        int i = 120;
        private void Tim_Tick(object sender, EventArgs e)
        {
            if (i == 0)
            {
                if (VidaP1.Value > VidaP2.Value)
                {
                    ///Gana jugador 1
                    MessageBox.Show("Gana el P1");
                }
                else
                {
                    MessageBox.Show("Gana el P2");
                    ///Gana jugador 2
                }
                PanelP1.Visible = false;
                PanelP2.Visible = false;
                LTiempo.Text = "00";
                Tim.Stop();
            }
            else 
            {
                if (VidaP1.Value == 0)
                {
                    MessageBox.Show("Gana el P2");
                    PanelP1.Visible = false;
                    PanelP2.Visible = false;
                    Tim.Stop();

                }
                else if (VidaP2.Value == 0)
                {
                    MessageBox.Show("Gana el P1");
                    PanelP1.Visible = false;
                    PanelP2.Visible = false;
                    Tim.Stop();
                }
              

            }

                LTiempo.Text = i.ToString();
            i--;
        }
        int j = 1;
        private void Animacion_Tick(object sender, EventArgs e)
        {
            if(j != 3)
            {
                foreach (Tarjetas tar in TarjetasArreglo)
                    tar.Image = ProyectoFinalSonia.Properties.Resources.Reverso;
                PanelP1.Enabled = PanelP2.Enabled = false;
            }
            else
            {
                int a = 0;
                foreach (Tarjetas tar in TarjetasArreglo)
                {
                    if (TarjetasArreglo[a].Parent == juego.PanelContrario_SetGet)
                    {
                        TarjetasArreglo[a].Image = ProyectoFinalSonia.Properties.Resources.Reverso;
                    }
                    else
                    {
                        TarjetasArreglo[a].ImagenTarjeta(tar, TarjetSelected);
                    }
                    tar.AdaptarTamaño(tar, tar.Parent);
                    a++;
                }
                if (PanelP1 == juego.PanelContrario_SetGet) TarjetSelected = TarjetasArreglo[4];
                else TarjetSelected = TarjetasArreglo[0];
                TarjetSelected.ImagenTarjeta(TarjetSelected, TarjetSelected);
                Animacion.Stop();
                SeleccionCarta(TarjetSelected);
                PanelP1.Enabled = PanelP2.Enabled = true;
                PanelP1.Visible = true;
                PanelP2.Visible = true;
            }
            j++;
        }

        private void Juego_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.K)
            {
                PanelP1.Visible = false;
                PanelP2.Visible = false;
                if (TarjetSelected == null)
                {
                    if (PanelP1 == juego.PanelEnTurno_SetGet) TarjetSelected = TarjetasArreglo[0];
                    else TarjetSelected = TarjetasArreglo[4];
                }

                TarjetSelected.AsignacionDeDaño(TarjetSelected);
                if (TarjetSelected.NumTarjeta == 5)
                {
                    if (TarjetSelected.Vando)
                    {
                        escudoP1 = true;
                        escudoP2 = false;
                    }
                    else
                    {
                        escudoP2 = true;
                        escudoP1 = false;
                    }
                }

                int i = 0;
                while (i < 8)
                {
                    if (TarjetSelected == TarjetasArreglo[i])
                    {
                        juego.NuevasTargetas(TarjetSelected);
                        TarjetasArreglo[i] = juego.NewTarget;
                        if (TarjetSelected.Vando)
                        {
                            if (escudoP2)
                            {
                                TarjetSelected.Daño = 0;
                                escudoP2 = false;
                            }
                        }
                        else
                        {
                            if (escudoP1)
                            {
                                TarjetSelected.Daño = 0;
                                escudoP1 = false;
                            }
                        }
                        juego.UsoTarjeta(TarjetSelected);
                        TarjetSelected.Tarselected = null;
                        TarjetSelected = null;
                    }

                    TarjetasArreglo[i].Click += F1_Click;

                    i++;
                }
                i = 0;
                j = 1;
                Animacion.Start();
            }
        }
    }
}
