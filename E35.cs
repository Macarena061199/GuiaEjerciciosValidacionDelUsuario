using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjerciciosValidacionDelUsuario
{
    internal class E35
    {
        /*Solicitar el ingreso de un número al usuario, repitiendo la operación (presentando un mensaje de 
         * error) hasta que el ingreso sea válido.*/

        public void Ej35()
        {
            bool flag = false;
            do
            {
                Console.Write("Por favor ingrese un número: ");
                string ingreso = Console.ReadLine();

                flag=ValidarNumero(ingreso);

                if(flag==true)
                {
                    Console.WriteLine($"Usted ingreso el número {ingreso}");
                }
            }while (flag==false);
        }

        private bool ValidarNumero(string ingreso)
        {
            bool flag = false;
            if (!int.TryParse(ingreso, out int salida))
            {
                Console.WriteLine("El valor ingresado debe ser un dato numérico.");
            }
            else
            {
                flag = true;
            }

            return flag;
        }
    }
}
