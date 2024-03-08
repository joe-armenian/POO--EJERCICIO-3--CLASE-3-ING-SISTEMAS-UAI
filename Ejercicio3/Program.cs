using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Program
    {

        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese la longitud de las contraseñas");
            int longitud =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de las contraseñas");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            Password[] contraseñas = new Password[cantidad];
            bool[] esFuerte=new bool[cantidad];

            

            for (int i = 0;i<cantidad;i++)
            {
                contraseñas[i]= new Password(longitud);
                esFuerte[i]= contraseñas[i].EsFuerte(); 
            }

            for (int i=0;i<cantidad;i++)
            {
                Console.WriteLine($"Contraseña {i+1}: {contraseñas[i].GetContraseña()}-¿Es segura?:{esFuerte[i]}");
            }

            Console.ReadKey();

        }
    }
}
