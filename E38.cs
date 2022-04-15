using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjerciciosValidacionDelUsuario
{
    internal class E38
    {
        /*Solicitar el ingreso de una serie de números al usuario, donde cada número de la serie debe 
         * ser mayor al anterior.*/
        public void Ej38()
        {
            bool flag = false;
            string serie = "";
            do
            {
                int contado = 0;
                do
                {
                    
                    int num1 = 0;
                    int guardar = 0;
                    int num2 = 0;
                    for (contado = 0; contado < 5; contado++)
                    {
                        
                            num1 = IngresarNum();
                            if (contado == 0)
                            {

                                guardar = num1;
                                serie = serie + Convert.ToString(num1) + " - ";


                            }
                            else
                            {
                                flag = EsMayor(guardar, num1);
                                if (flag == true)
                                {
                                    guardar = num1;
                                    serie = serie + Convert.ToString(num1) + " - ";

                                }
                            }
                       
                     
                        
                    }
                    

                } while (contado < 5);
                flag = true;
                Console.WriteLine("La serie igresada fue: " + System.Environment.NewLine +
                    serie);

            } while(flag==false);
        }
        private int IngresarNum()
        {
            int num = 0;
            bool flag= false;
            do
            {
                Console.Write("Por favor ingrese un número: ");
                string ingreso = Console.ReadLine();


                flag = ValidarNumero(ingreso, ref num);

                
            } while (flag == false);

            return num;
        }
        private bool ValidarNumero(string ingreso, ref int salida)
        {
            bool flag = false;
            if (!int.TryParse(ingreso, out salida))
            {
                Console.WriteLine("El valor ingresado debe ser un dato numérico.");
            }
            else
            {
                flag = true;
            }

            return flag;
        }
        private bool EsMayor(int num1, int num2)
        {
            bool flag=false;
            if(num1<num2)
            {
                flag= true;
            }
            else
            {
                Console.WriteLine("El número ingresado debe ser mayor al anterior.");
            }
            return flag;
        }
    }
}
