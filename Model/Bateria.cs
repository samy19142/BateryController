using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace BateryController.Model
{
    internal class Bateria
    {
        private string Conectado { get; }
        private string Desconectado { get; }
        private string Error { get; }


        public Bateria()
        {
            Conectado = "Conectado";
            Desconectado = "Desconectado";
            Error = "Error";
        }

        public String EstadoBateria()
        {
            try
            {
                switch (SystemInformation.PowerStatus.PowerLineStatus)
                {
                    case PowerLineStatus.Offline:
                        return Desconectado;

                    case PowerLineStatus.Online:
                        return Conectado;

                    default: return Error;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return Error;
            }

        }

        public int PorcentajeBateria()
        {
            try
            {
                float dato = SystemInformation.PowerStatus.BatteryLifePercent * 100;
                int porcentaje = int.Parse(dato.ToString());
                return porcentaje;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }

        }







    }


}
