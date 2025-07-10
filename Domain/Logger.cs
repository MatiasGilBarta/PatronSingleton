using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public sealed class Logger
    {   
        private static readonly Logger _instance = new Logger();

        public static Logger Current
        { 
            get 
            {
                return _instance;
            } 
        }
        private Logger() 
        {
            //implementacion del singleton
        }

        public void Guardar(string mensaje)
        { Console.WriteLine("guardando mensaje: " + mensaje); }
    }
}
