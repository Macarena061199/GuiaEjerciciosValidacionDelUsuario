using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjerciciosValidacionDelUsuario
{
    internal class E36
    {
        /*Solicitar el ingreso de una fecha al usuario, repitiendo la operación 
         * (presentando un mensaje de error) hasta que el ingreso sea válido.*/
        public void Ej36()
        {
            bool flag = false;
            do
            {
                Console.Write("Por favor ingrese una fecha: ");
                string ingreso = Console.ReadLine();

                flag = ValidarFecha(ingreso);

                if (flag == true)
                {
                    Console.WriteLine($"Usted ingreso la fecha {ingreso}.");
                }
            } while (flag == false);
        }

        private bool ValidarFecha(string ingreso)
        {
            bool flag = false;
            if (!DateTime.TryParse(ingreso, out DateTime salida))
            {
                Console.WriteLine("El valor ingresado debe ser una fecha.");
            }
            else
            {
                flag = true;
            }

            return flag;
        }
    }
}
