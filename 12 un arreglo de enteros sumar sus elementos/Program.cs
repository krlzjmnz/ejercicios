using System;

namespace _12_un_arreglo_de_enteros_sumar_sus_elementos
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
                Console.WriteLine($"El resultado de la suma es: {sumarArr(cad)}");
                Console.WriteLine("Ingrese 'y' para volver a ingresar otro numero 'n' para salir");
                if(!char.TryParse(Console.ReadLine(),out seguir) || seguir!='y' && seguir!='n'){
                    Console.WriteLine("entrada no valida");
                }
            }while(seguir=='y');
        }
        public static double sumarArr(string [] cad){
            double suma=0;
            foreach(string c in cad){
                suma+= int.Parse(c);
            }
            return suma;
        }
    }
}
