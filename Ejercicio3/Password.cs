using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ejercicio3
{
    public class Password
    {
        private int Longitud { get; set; }

        private string Contraseña { get; set; }

        private static  Random rnd=new Random();

        private const int longitudDefault = 8;
        public Password()
        {
         this.Longitud = longitudDefault;
         Contraseña =GenerarPassword();
        }
        public Password(int longitud)
        {
         this.Longitud = longitud;
         Contraseña =GenerarPassword();
        }
        //metodo para la contraseña aleatoria
        private string GenerarPassword()
        {
            StringBuilder builder = new StringBuilder(); 
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            for (int i=0;i<Longitud;i++) 
            {
                int indice=rnd.Next(caracteres.Length); 
                builder.Append(caracteres[indice]);
            }
            return Contraseña= builder.ToString(); 
        }
        public bool EsFuerte()
        {
            int mayusculas = 0, minusculas = 0, numeros = 0;
            foreach (char caracter in Contraseña) 
            {
                if (char.IsUpper(caracter))
                {
                    mayusculas++;
                }
                else if (char.IsLower(caracter)) 
                {
                    minusculas++;
                }
                else if (char.IsDigit(caracter))
                {
                    numeros++;
                }
            }

            return mayusculas > 2 && minusculas > 1 && numeros > 5;
        }
        public string GetContraseña()
        {
            return Contraseña;
        }
        public int GetLongitud()
        {
            return Longitud;
        }
        public void SetLongitud(int longitud)
        {
            Longitud = longitud;
        }
    }
}
