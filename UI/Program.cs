using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            string mensaje = "este es el mensaje";

            Logger.Current.Guardar(mensaje);
            Console.ReadLine();
        }

    }
}
