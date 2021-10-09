using System;

namespace programa_valores
{


    class Program
    {
        static void Main(string[] args)
        {
            double promedioDeArreglo(string[] arreglo, int cantidadDeElementos)
            {
                double suma = 0;
                for (int x = 0; x < cantidadDeElementos; x++)
                {
                    suma = suma + Int32.Parse(arreglo[x]);
                 
                }
                return suma / cantidadDeElementos;
            }

            Console.WriteLine("media de un arreglo\n");

            Console.WriteLine("ingrese los valores para calcular su media\n");

            int f = 1;
            string [] numeros=new string [ 0 ];
            int i = 0;

            while (f==1)
            {
                Console.WriteLine("ingresar numero: \n");
                string numero = Console.ReadLine();
                Array.Resize(ref numeros, numeros.Length + 1);
                numeros[i] = numero;
                Console.WriteLine("desea ingresar otro numero? (1)SI (0)NO\n");
                f= Convert.ToInt32(Console.ReadLine());
                i++;
            }
            Console.WriteLine("la media del arreglo es: ");
            Console.WriteLine(promedioDeArreglo(numeros, numeros.Length));
        }
    }
}
