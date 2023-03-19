using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
namespace BateryController.Model
{

    internal class ArduinoConfig
    {

        public string Com { get; set; }
        public int Baud { get; set; }
        public string Mensaje { get; set; }
        System.IO.Ports.SerialPort Arduino = new SerialPort();
        public bool estado  {get;set;}

        public ArduinoConfig()
        {
            Com = "COM3";
            Baud = 9600;
            estado = false;
        }


        public void CerrarConexion()
        {
            if (Arduino.IsOpen)
            {
                Arduino.Close();
                estado = false;
            }
        }

        public void Abrirconexion()
        {
            try {
                if (!Arduino.IsOpen)
                {
                    Arduino.PortName = Com;
                    Arduino.BaudRate = Baud;
                    Arduino.Open();
                    estado= true;
                }
                Console.WriteLine("Conexion ya abierta");
                    

            } catch (Exception e) {
                Console.WriteLine(e.Message);
                Console.WriteLine("Error intentando Establecer Conexión");
                estado = false;
            }
        }
        public string EnviarMensaje(string msj) {
            if (!Arduino.IsOpen) {
                Abrirconexion();
                return "Abriendo Comunicacion Arduino";
            }
            Arduino.Write(msj);
            estado = true;
            return "Enviado";
          
        }
    }
}
