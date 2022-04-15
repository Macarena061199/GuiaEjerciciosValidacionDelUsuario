using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjerciciosValidacionDelUsuario
{
    internal class E37
    {
        /*Solicitar el ingreso de una cadena al usuario, repitiendo la operación 
         * (presentando un mensaje de error) hasta que el ingreso sea válido. Debe tener entre 10 y 20 
         * caracteres.*/
        public void Ej37()
        {
            bool flag = false;
            do
            {
                Console.Write("Por favor ingrese un texto que contenga entre 10 y 20 caracteres: ");
                string ingreso = Console.ReadLine();

                flag = ValidarLongitudCadena(ingreso, "Texto");

                if (flag == true)
                {
                    Console.WriteLine($"Usted ingreso {ingreso}.");
                }
            } while (flag == false);
        }

        private bool ValidarLongitudCadena(string ingreso,string campo)
        {
            bool flag = false;
            if (string.IsNullOrEmpty(ingreso))
            {
                Console.WriteLine($"El campo {campo} no debe estar vacío.");
                
            }
            else if(ingreso.Length < 10 || ingreso.Length>20)
            {
                Console.WriteLine($"El campo {campo} debe tener entre 10 y 20 carácteres.");
            }
            else
            {
                flag = true;
            }

            return flag;
        }
    }
}
