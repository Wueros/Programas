using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Juego1P
{
    public class LogicaJuego
    {
        Panel PanelEnTurno, PanelContrario, panel1;
        ProgressBar VidaEnTurno, VidaContrario, vida1;
        Point LocationPanel2;
        public LogicaJuego(Panel p1, Panel p2, ProgressBar VidaP1, ProgressBar VidaP2)
        {
            PanelEnTurno_SetGet = p1;
            PanelContrario_SetGet = p2;
            VidaEnTurno = VidaP1;
            VidaContrario = VidaP2;
            VidaEnTurno.Value = 100; VidaContrario.Value = 100;
            //Cambio de tamaño para identificar el turno
            VidaEnTurno.Height = 50;
            VidaEnTurno.Width = 530;
            VidaContrario.Height = 40;
            VidaContrario.Width = 520;
        }
        public void UsoTarjeta(Tarjetas TarjetaSelect)
        {

            if (VidaEnTurno_SetGet.Value < 100)
                VidaEnTurno_SetGet.Value += TarjetaSelect.AumentoDeVida;
            ///animacion curacion
            if(VidaContrario_SetGet.Value>TarjetaSelect.Daño)
            VidaContrario_SetGet.Value -= TarjetaSelect.Daño;
            else
            {
                ///animacion ganador
                VidaContrario_SetGet.Value = 0;
            }
            TarjetaSelect.Daño = 0;

            CambioTurno();
        }
        public void CambioTurno()
        {
            vida1 = VidaEnTurno_SetGet;
            VidaEnTurno_SetGet = VidaContrario_SetGet;
            VidaContrario_SetGet = vida1;
            panel1 = PanelEnTurno_SetGet;
            PanelEnTurno_SetGet = PanelContrario_SetGet;
            PanelContrario_SetGet = panel1;

            LocationPanel2 = PanelEnTurno_SetGet.Location;
            PanelEnTurno_SetGet.Location = PanelContrario_SetGet.Location;
            PanelContrario_SetGet.Location = LocationPanel2;

            PanelContrario_SetGet.Height = 156;
            PanelContrario_SetGet.Width = 374;
            PanelEnTurno_SetGet.Height = 287;
            PanelEnTurno_SetGet.Width = 635;
            VidaEnTurno.Height = 50;
            VidaEnTurno.Width = 530;
            VidaContrario.Height = 40;
            VidaContrario.Width = 520;
            PanelContrario_SetGet.Enabled = false;
            PanelEnTurno_SetGet.Enabled = true;
           
        }


        public Panel PanelContrario_SetGet
        {
            get
            {
                return PanelContrario;
            }

            set
            {
                PanelContrario = value;
            }
        }

        public Panel PanelEnTurno_SetGet
        {
            get
            {
                return PanelEnTurno;
            }

            set
            {
                PanelEnTurno = value;
            }
        }
        public ProgressBar VidaContrario_SetGet
        {
            get
            {
                return VidaContrario;
            }

            set
            {
                VidaContrario = value;
            }
        }

        public ProgressBar VidaEnTurno_SetGet
        {
            get
            {
                return VidaEnTurno;
            }

            set
            {
                VidaEnTurno = value;
            }
        }
        public void NuevasTargetas(Tarjetas tar)
        {
            if (tar != null)
            {
                Tarjetas nuevTar;
                Random r = new Random();
                if (VidaContrario_SetGet.Value <= 40)
                    nuevTar = new Tarjetas(PanelEnTurno_SetGet, r.Next(1, 8));
                else
                    nuevTar = new Tarjetas(PanelEnTurno_SetGet, r.Next(1, 7));
                nuevTar.Vando = tar.Vando;

                nuevTar.ImagenTarjeta(nuevTar, tar);
                PanelEnTurno_SetGet.Controls.Add(nuevTar);
                PanelEnTurno_SetGet.Controls.Remove(tar);
                NewTarget = nuevTar;
            }
        }
        private Tarjetas newTarget;

        public Tarjetas NewTarget
        {
            get { return newTarget; }
            set { newTarget = value; }
        }

    }
}
