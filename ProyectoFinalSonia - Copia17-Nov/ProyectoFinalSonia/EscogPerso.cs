﻿using System;
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
    public partial class EscogPerso : Form
    {
        Personaje[] personajesArreglo = new Personaje[12];
        public EscogPerso()
        {
            InitializeComponent();
            for (int i = 0; i < 12; i++)
            {
                if (i < 6)
                {
                    personajesArreglo[i] = new Personaje(PanelHeroes, PanelHeroes, PanelVillanos, i + 1);
                    personajesArreglo[i].PersonajeVando = true;
                }
                else
                {
                    personajesArreglo[i] = new Personaje(PanelVillanos, PanelHeroes, PanelVillanos, i-5);
                    personajesArreglo[i].PersonajeVando = false;

                }
                personajesArreglo[i].CargarImagen(personajesArreglo[i]);
            }
            UbicaionHeroes(0, 20, 10);
            UbicacionVillanos(6,20, 10);
        }
        public void UbicacionVillanos(int i, int x, int y)
        {
            if (i < 12)
            {
                if (x >= personajesArreglo[i].Width * 2)
                {
                    UbicacionVillanos(i + 1, 20, y + personajesArreglo[i].Height + 10);
                }
                else
                {
                    UbicacionVillanos(i + 1, x +( personajesArreglo[i].Width + 20), y);
                }
                personajesArreglo[i].Top = y;
                personajesArreglo[i].Left = x;
            }
        }
        public void UbicaionHeroes (int i,int x,int y)
        {
            if (i < 6)
            {
                if(x >= personajesArreglo[i].Width * 2)
                {
                    UbicaionHeroes(i + 1, 20, y + personajesArreglo[i].Height+10);
                }
                else
                {
                    UbicaionHeroes(i + 1, x+personajesArreglo[i].Width+20, y);
                }
                personajesArreglo[i].Top = y;
                personajesArreglo[i].Left = x;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Escenarios mapa = new Escenarios();
            mapa.Show();
            this.Hide();
        }
        private void EscogPerso_Load(object sender, EventArgs e)
        {

        }
    }
}
