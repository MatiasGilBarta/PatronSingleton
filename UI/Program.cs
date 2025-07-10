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
            string a = "lo que hay que guardar";

            Logger.Current.Guardar(a);
            Console.ReadLine();
        }

    }
}
