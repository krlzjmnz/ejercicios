using System;

namespace _19_determinar_el_numero_mas_grande
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
                Console.WriteLine($"El numero más Grande en el arreglo es {numeroMayor(cad)}");
                Console.WriteLine("Ingrese 'y' para volver a ejecutar el programa 'n' para salir");
                if(!char.TryParse(Console.ReadLine(),out seguir) || seguir!='y' && seguir!='n'){
                    Console.WriteLine("entrada no valida");
                }
            }while(seguir=='y');
        }
        public static int numeroMayor(string [] arr){
            int aux=0;
            foreach(string a in arr){
                if(int.Parse(a)>aux){
                    aux=int.Parse(a);
                }
            }
            return aux;
        }
    }
}
