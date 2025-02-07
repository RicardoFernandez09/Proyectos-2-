using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonDice_C_
{
    public partial class Form1 : Form
    {
        int ControlSencuencia = 0;
        Random NumeroAleatorio;

        List<int> SimonDice = new List<int>();
        bool Hablando = false;
        public Form1()
        {
            InitializeComponent();
            NumeroAleatorio = new Random();
        }
        public void IniciarJuego()
        {
            Thread.Sleep(200);
            Hablando = true;
            foreach (int ParteActiva in SimonDice)
            {
                switch (ParteActiva)
                {

                    case 0:
                        p_0.Image = Properties.Resources.Rostros_Capitan_America_ico;
                        Thread.Sleep(200);
                        p_0.Image = Properties.Resources.Rostros_Capitan_America;
                        break;
                    case 1:
                        p_1.Image = Properties.Resources.Rostros_Iron_Man_ico;
                        Thread.Sleep(200);
                        p_1.Image = Properties.Resources.Rostros_Iron_Man;
                        break;
                    case 2:
                        p_2.Image = Properties.Resources.Rostros_Hulk_ico;
                        Thread.Sleep(200);
                        p_2.Image = Properties.Resources.Rostros_Hulk;
                        break;
                    case 3:
                        p_3.Image = Properties.Resources.Rostros_Thor_ico;
                        Thread.Sleep(200);
                        p_3.Image = Properties.Resources.Rostros_Thor;
                        break;
                }
                Thread.Sleep(200);
            }
            Hablando = false;
        }

        public void VerificarBotonPresionado(int Valor)
        {
            if (Hablando || SimonDice.Count == 0) return;
            if (SimonDice[ControlSencuencia] = ValorBoton) ControlSencuencia++;
            else
            {
                MessageBox.Show("Tu record Final es:" + SimonDice.Count);
                ControlSencuencia = 0;
                SimonDice = new List<int>();
            }
            if (ControlSencuencia >= SimonDice.Count)
            {
                ControlSencuencia = 0;
                SimonDice.Add(NumeroAleatorio.Next(0, 4));
                new Thread(IniciarJuego).Start();
            }
            lbl_puntaje.Text = SimonDice.Count.ToString();
        }
        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            SimonDice.Add(NumeroAleatorio.Next(0, 4));
            new Thread(IniciarJuego).Start();
        }

        private void p_0_Click(object sender, EventArgs e)
        {
            String Presionado = ((PictureBox)sender).Name;
            string[] NumeroBoton = Presionado.Split(',');
            VerificarBotonPresionado(Convert.ToInt32(NumeroBoton[1]));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void p_3_MouseDown(object sender, MouseEventArgs e)
        {
            p_3.Image = Properties.Resources.Rostros_Thor_ico;
        }

        private void p_3_MouseUp(object sender, MouseEventArgs e)
        {
            p_3.Image = Properties.Resources.Rostros_Thor;

        }

        private void p_0_MouseDown(object sender, MouseEventArgs e)
        {
            p_0.Image = Properties.Resources.Rostros_Capitan_America_ico;
        }

        private void p_0_MouseUp(object sender, MouseEventArgs e)
        {
            p_0.Image = Properties.Resources.Rostros_Capitan_America;

        }

        private void p_1_MouseDown(object sender, MouseEventArgs e)
        {
            p_1.Image = Properties.Resources.Rostros_Iron_Man_ico;
        }

        private void p_1_MouseUp(object sender, MouseEventArgs e)
        {
            p_1.Image = Properties.Resources.Rostros_Iron_Man;
        }

        private void p_2_MouseDown(object sender, MouseEventArgs e)
        {
            p_2.Image = Properties.Resources.Rostros_Hulk_ico;
        }

        private void p_2_MouseUp(object sender, MouseEventArgs e)
        {
            p_2.Image = Properties.Resources.Rostros_Hulk;
        }
    }
}
