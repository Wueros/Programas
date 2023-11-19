using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego1P
{
    public partial class F1 : Form
    {
        Tarjetas[] TarjetasArreglo = new Tarjetas[8];
        LogicaJuego juego;
        Tarjetas TarjetSelected;
        Random r = new Random();
        bool escudoP1 = false, escudoP2 = false;
        public F1()
        {
            InitializeComponent();
            juego = new LogicaJuego(PanelP1, PanelP2, VidaP1, VidaP2);
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
                    TarjetasArreglo[i].Image = Juego1P.Properties.Resources.Reverso;
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
            foreach(Tarjetas t in TarjetasArreglo)
            {
                t.ImagenTarjeta(t,TarjetSelected);
                SeleccionCarta(t);
                if (t.Parent.Enabled == false)
                    t.Image = Juego1P.Properties.Resources.Reverso;
            }

        }
        public void SeleccionCarta(Tarjetas tar)
        {
            if(tar == TarjetSelected)
            {
                tar.Width = (tar.Parent.Width / 4) + 30;
            }
            else
            {
                tar.Width = (tar.Parent.Width / 4) - 10;

            }
        }

        private void F1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.K)
            {
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
                LVidaP1.Text = VidaP1.Value.ToString();
                LVidaP2.Text = VidaP2.Value.ToString();
                if (PanelP1 == juego.PanelContrario_SetGet) TarjetSelected = TarjetasArreglo[4];
                else TarjetSelected = TarjetasArreglo[0];
                TarjetSelected.ImagenTarjeta(TarjetSelected, TarjetSelected);
                SeleccionCarta(TarjetSelected);
                 i = 0;
                foreach (Tarjetas tar in TarjetasArreglo)
                {
                    if (TarjetasArreglo[i].Parent.Enabled == false)
                    {
                        TarjetasArreglo[i].Image = Juego1P.Properties.Resources.Reverso;
                    }
                    else
                    {
                        TarjetasArreglo[i].ImagenTarjeta(tar, TarjetSelected);
                    }
                        tar.AdaptarTamaño(tar, tar.Parent);
                    i++;
                }
            }
        }
    }
}
