﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form15SumarBotones : Form
    {

        List<Button> botones;
        int suma;

        public Form15SumarBotones()
        {
            InitializeComponent();
            this.botones = new List<Button>();
            this.suma = 0;

            //RECORREMOS TODA LA COLECCION CONTROL Y ACCEDEMOS A CADA         
            //UNO DE LOS BOTONES
            foreach (Control control in this.panelBotones.Controls)
            {
                if (control is Button)
                {
                    this.botones.Add((Button)control);
                }
            }

            //RECORREMOS NUESTROS CONTROLES Y ASIGNAMOS UN NUMERO RANDOM        
            //EN CADA UNO
            Random random = new Random();
            foreach (Button boton in this.botones)
            {
                int num = random.Next(1, 200);
                boton.Text = num.ToString();
                boton.Click += SumarNumeros;
            }


        }

        private void SumarNumeros(object? sender, EventArgs e)
        {
            //RECUPERAMOS EL NUMERO DEL CONTROL PULSADO
            Button boton = (Button)sender;
            int numero = int.Parse(boton.Text);
            this.suma += numero;
            this.txtSuma.Text = this.suma.ToString();
            boton.BackColor = Color.LightBlue;
        }


        private void lblSuma_Click(object sender, EventArgs e)
        {

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.suma = 0;
            this.txtSuma.Text = "0";
            foreach (Button boton in this.botones)
            {
                int num = random.Next(1, 200);
                boton.Text = num.ToString();
                boton.BackColor = Color.FromKnownColor(KnownColor.Control);
            }
        }
    }
}
