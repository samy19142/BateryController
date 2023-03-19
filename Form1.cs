using BateryController.Model;
using Microsoft.Win32;
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

namespace BateryController
{
    public partial class Form1 : Form
    {
        Bateria bat = new Bateria();
        ArduinoConfig arduino = new ArduinoConfig();
        bool BANDERA_CARGA;
        bool MODO_JUEGO = false;
        string[] FONDO_PRINCIPAL = new string[2];
        



        public Form1()
        {
            InitializeComponent();
            BANDERA_CARGA = bat.PorcentajeBateria()<=30?true:false;
            arduino.Abrirconexion();
            FONDO_PRINCIPAL[0] = @"C:\Users\samsa\source\repos\BateryController\Background_images\background_main.gif";
            FONDO_PRINCIPAL[1] = @"C:\Users\samsa\source\repos\BateryController\Background_images\background_charge.gif";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            ActualizarEstado();
            pictureBox1.Image = Image.FromFile(FONDO_PRINCIPAL[0]);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            arduino.EnviarMensaje("L,1");
        }

        private void smartControl()
        {

            if (!arduino.estado)
                throw new Exception("No existe Conexion para el Arduino");

            if (MODO_JUEGO)
            {
                arduino.EnviarMensaje("L,1");
                Console.WriteLine("Modo de Juego Activo");
                pictureBox1.Image = Image.FromFile(FONDO_PRINCIPAL[1]);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                return;
            }


            if (!MODO_JUEGO &&  bat.PorcentajeBateria() >= 90)
            {
                BANDERA_CARGA = false;
                Console.WriteLine("enviando orden de desconexion");
                arduino.EnviarMensaje("L,0");
            }
            else if (!MODO_JUEGO  && bat.PorcentajeBateria() >30 && bat.PorcentajeBateria() <90 && BANDERA_CARGA)
            {
                arduino.EnviarMensaje("L,1");
                Console.WriteLine("enviando orden de carga");
            }

        }





        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            arduino.CerrarConexion();
        }


        public void ActualizarEstado()
        {
            //Actualiza el estado de la bateria mostrando su porcentaje.

            lblMensajes.Text = bat.EstadoBateria();
            progressBar1.Value = bat.PorcentajeBateria();
            lblPorcentaje.Text = $"{bat.PorcentajeBateria()} % de Bateria";
        }


        public void ActivarBandera()
        {
            if (bat.PorcentajeBateria() < 30)
            {
                BANDERA_CARGA=true;
            }
            Console.WriteLine($"El estado de la bandera de carga es: {BANDERA_CARGA}");
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            Console.WriteLine("Ejecutando Timer");
            ActualizarEstado();
            smartControl();
            ActivarBandera();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //Metodo para mostrar u ocultar el icono de notificacion en la barra de tareas de Windows

            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                this.ShowInTaskbar = false;
            }
            if (this.WindowState == FormWindowState.Normal)
            {
                notifyIcon1.Visible = false;
                this.ShowInTaskbar = true;
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void modoJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkJuego.Checked = true;
            MODO_JUEGO = true;
            MessageBox.Show("Modo Juego Activado");
            
            
        }

        private void modoAutomaticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MODO_JUEGO = false;
            checkJuego.Checked=false;
            MessageBox.Show("Modo Inteligente de carga Activado");
        }

        private void checkJuego_CheckedChanged(object sender, EventArgs e)
        {
            MODO_JUEGO = checkJuego.Checked;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
