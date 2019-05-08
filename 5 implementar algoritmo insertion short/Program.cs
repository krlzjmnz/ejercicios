using System;

namespace _5_implementar_algoritmo_insertion_short
{
    class Program
    {
        static void Main(string[] args)
        {
            char seguir='y';
            string[] cad;

            do{
                Console.WriteLine("Ingresa una serie de numeros separados por comas para odernarlo");
                Console.WriteLine("Ejemplo: 5,2,4,6,3,1,7");
                    cad = Console.ReadLine().Split(",");
                    Console.WriteLine("arreglo ordenado por metodo inserion sort:");
                    foreach(string cadena in insertionSort(cad)){                        
                        Console.Write(cadena+" "+"\n");
                    }
                
                Console.WriteLine("Ingrese 'y' para volver a ingresar otro numero 'n' para salir");
                if(!char.TryParse(Console.ReadLine(),out seguir) || seguir!='y' && seguir!='n'){
                    Console.WriteLine("entrada no valida");
                }
            }while(seguir=='y');
        }
        public static string[] insertionSort(string[] cadena){
            int j, i = 1;
            string cad1, cad2;
            while (i < cadena.Length){
                j = i;
                while(j > 0 && int.Parse(cadena[j-1]) > int.Parse(cadena[j])){
                    cad1=cadena[j];
                    cad2=cadena[j-1];
                    cadena[j]=cad2;
                    cadena[j-1]=cad1;
                    j = j - 1;
                }
                i = i + 1;
            }
            return cadena;
        }
    }
}
