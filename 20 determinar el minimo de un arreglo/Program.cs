using System;

namespace _20_determinar_el_minimo_de_un_arreglo
{
    class Program
    {
        static void Main(string[] args)
        {
             char seguir='y';
            string[] cad;
            do{
                Console.WriteLine("Ingresa una serie de numeros separados por comas");
                Console.WriteLine("Ejemplo: 5,2,4,6,3,1,7");
                cad = Console.ReadLine().Split(",");
                Console.WriteLine($"El numero más Grande en el arreglo es {numeroMinimo(cad)}");
                Console.WriteLine("Ingrese 'y' para volver a ejecutar el programa 'n' para salir");
                if(!char.TryParse(Console.ReadLine(),out seguir) || seguir!='y' && seguir!='n'){
                    Console.WriteLine("entrada no valida");
                }
            }while(seguir=='y');
        }
        public static int numeroMinimo(string [] arr){
            int aux=int.Parse(arr[0]);
            foreach(string a in arr){
                if(int.Parse(a)<aux){
                    aux=int.Parse(a);
                }
            }
            return aux;
        }
    }
    }
}
