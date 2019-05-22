using System;

namespace _13_un_arreglo_de_enteros_cuantos_son_divibles_por_2
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
                Console.WriteLine($"ahi: {Divisibles(cad)} divisibles entre 2");
                Console.WriteLine("Ingrese 'y' para volver a ejecutar el programa 'n' para salir");
                if(!char.TryParse(Console.ReadLine(),out seguir) || seguir!='y' && seguir!='n'){
                    Console.WriteLine("entrada no valida");
                }
            }while(seguir=='y');
        }
        public static int Divisibles(string [] cad){
            int suma=0;
            foreach(string c in cad){
                if(int.Parse(c)%2==0){
                    suma++;
                }
            }
            return suma;
        }
    }
}
