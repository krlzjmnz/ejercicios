using System;

namespace _7_dada_un_string_s_invertirla_hola___aloh
{
    class Program
    {
        static void Main(string[] args)
        {
            char seguir='y';
            char[] cadena1, cadena2;
            do{
                Console.WriteLine("Ingresa una cadena para mostrarla invertida");
                cadena1=Console.WriteLine();


                Console.WriteLine("Ingrese 'y' para volver a ingresar otro numero 'n' para salir");
                if(!char.TryParse(Console.ReadLine(),out seguir) || seguir!='y' && seguir!='n'){
                    Console.WriteLine("entrada no valida");
                }
            }while(seguir=='y');
        }
    }
}
