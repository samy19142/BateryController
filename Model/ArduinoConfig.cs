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

        public ArduinoConfig()
        {
            Com = "COM3";
            Baud = 9600;
        }


        public void CerrarConexion()
        {
            if (Arduino.IsOpen)
            {
                Arduino.Close();
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
                }
                Console.WriteLine("Conexion ya abierta");
                    

            } catch (Exception e) {
                Console.WriteLine(e.Message);
                Console.WriteLine("Error intentando Establecer Conexión");
            }
        }
        public string EnviarMensaje(string msj) {
            if (!Arduino.IsOpen) {
                return "Conexion Cerrada";
            }
            Arduino.Write(msj);
            return "Enviado";
        }
    }
}
