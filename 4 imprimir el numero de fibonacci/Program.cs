using System;

namespace _4_imprimir_el_numero_de_fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
             char seguir='y';
            int numero;
            do{
                Console.WriteLine("Escribe un numero entero para mostrar su serie de fibonacci");
                if(Int32.TryParse(Console.ReadLine(), out numero)){
                    Console.WriteLine();
                }else{
                    Console.WriteLine($"El dato ingresado {numero} no es un numero");
                }
                Console.WriteLine("Ingrese 'y' para volver a ingresar otro numero 'n' para salir");
                if(!char.TryParse(Console.ReadLine(),out seguir) || seguir!='y' && seguir!='n'){
                    Console.WriteLine("entrada no valida");
                }
            }while(seguir=='y');
        }
        
        public static string fibonacci(){

            return null;
        }
    }
}
