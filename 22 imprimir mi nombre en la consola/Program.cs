using System;

namespace _21_imprimir_mi_nombre_en_la_consola
{
    class Program
    {
        static void Main(string[] args)
        {
           char seguir='y';
            
            do{
                Console.WriteLine("Escribe mi nombre:");
                
                    Console.WriteLine(Console.ReadLine());
                
                Console.WriteLine("Ingrese 'y' para volver ejecutar el programa 'n' para salir");
                if(!char.TryParse(Console.ReadLine(),out seguir) || seguir!='y' && seguir!='n'){
                    Console.WriteLine("entrada no valida");
                }
            }while(seguir=='y');
        }
    }
}
