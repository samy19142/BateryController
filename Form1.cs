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
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            ActualizarEstado();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Bateria msj = new Bateria();
            //Console.WriteLine("Estado: " + msj.EstadoBateria());
            //Console.WriteLine("Porcentaje: " + msj.PorcentajeBateria());
            /*ArduinoConfig arduino = new ArduinoConfig();
            arduino.Abrirconexion();
            Console.WriteLine(arduino.EnviarMensaje("100"));
            arduino.CerrarConexion();*/
            //ActualizarEstado();

            Task tarea = new Task(consola);
            tarea.Start();
        }
        private void consola() {
            while (!checkJuego.Checked)
            {
                Console.WriteLine("test");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Modo Juego Desactivado");
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

    

        public void ActualizarEstado() {

            lblMensajes.Text = bat.EstadoBateria();
            progressBar1.Value = bat.PorcentajeBateria();
            lblPorcentaje.Text = $"{bat.PorcentajeBateria()} % de Bateria";
            Console.WriteLine("cuanto lleva"+bat.PorcentajeBateria());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            Console.WriteLine("Ejecutando");
            ActualizarEstado();
        }

      

      
    }

}
