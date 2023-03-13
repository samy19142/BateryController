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
        bool MODO_JUEGO=false;
        ArduinoConfig arduino = new ArduinoConfig();

        public Form1()
        {
            InitializeComponent();
            arduino.Abrirconexion();
            Task tarea = new Task(modoJuegoController);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            ActualizarEstado();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            arduino.EnviarMensaje("1");
        }
        private void smartControl() {

            while (checkJuego.Checked)
            {
                Console.WriteLine("Cargador Siempre Conectado");
                Thread.Sleep(1000);
            }

            if (bat.PorcentajeBateria() >= 90)
            {
                Console.WriteLine("enviando orden de desconexion");
                arduino.EnviarMensaje("1");
            }
            else
            {
                Console.WriteLine("enviando orden de carga");
            }

            Console.WriteLine("Modo de juego no Activo");
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
           
        }

        public void modoJuegoController() {
           // Task tarea = new Task()
        }
    

        public void ActualizarEstado() {
            //Actualiza el estado de la bateria mostrando su porcentaje.

            lblMensajes.Text = bat.EstadoBateria();
            progressBar1.Value = bat.PorcentajeBateria();
            lblPorcentaje.Text = $"{bat.PorcentajeBateria()} % de Bateria";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            Console.WriteLine("Ejecutando Timer");
            ActualizarEstado();
            smartControl();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //Metodo para mostrar u ocultar el icono de notificacion en la barra de tareas de Windows

            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                this.ShowInTaskbar = false;
            }
            if(this.WindowState == FormWindowState.Normal)
            {
                notifyIcon1.Visible = false;
                this.ShowInTaskbar=true;
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
            MessageBox.Show("Modo Juego Activado");
        }

        private void modoAutomaticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modo Inteligente de carga Activado");
        }

        private void checkJuego_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Cambio a estado" + checkJuego);
        }
    }

}
