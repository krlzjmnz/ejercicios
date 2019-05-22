using System;
using System.Text.RegularExpressions;

namespace _17_determinar_si_n_es_un_cuadrado_perfecto
{
    class Program
    {
        static void Main(string[] args)
        {
               char seguir='y';
            int numero;
            do{
                Console.WriteLine("Ingrese un numero entero para determinar si es un cuadrado perfecto");
                if(Int32.TryParse(Console.ReadLine(), out numero)){
                    if(EsCuadradoPerfecto(numero)){
                        Console.WriteLine($"El {numero} : es un cuadrado perfecto");
                    }
                    else{
                        Console.WriteLine($"El {numero}: no es un cuadrado perfecto");
                    }
                }else{
                    Console.WriteLine($"El dato ingresado {numero} no es un numero");
                }
                Console.WriteLine("Ingrese 'y' para volver a ejecutar el programa 'n' para salir");
                if(!char.TryParse(Console.ReadLine(),out seguir) || seguir!='y' && seguir!='n'){
                    Console.WriteLine("entrada no valida");
                }
		        else if(seguir=='n'){
		            Console.WriteLine("Teminando la ejecucion del programa");
		        }
            }while(seguir=='y');
        }
        public static bool EsCuadradoPerfecto(double n){
            if(Regex.IsMatch(Math.Sqrt(n).ToString(),@"^\d+(\.\d{0,2})?$")){
                return true;
            }
            return false;
        }
    }
}
