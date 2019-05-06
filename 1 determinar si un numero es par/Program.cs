using System;

namespace determinar_si_un_numero_es_par
{
    class Program
    {
        static void Main(string[] args)
        {
            char seguir='y';
            int numero;
            do{
                Console.WriteLine("Escribe un numero entero para determinar si es par");
                if(Int32.TryParse(Console.ReadLine(), out numero) && numero%2==0){
                    Console.WriteLine($"El numero: {numero} es par");
                }else{
                    Console.WriteLine($"El numero {numero} no es par");
                }
                Console.WriteLine("Ingrese 'y' para volver a ingresar otro numero 'n' para salir");
                if(!char.TryParse(Console.ReadLine(),out seguir) || seguir!='y' && seguir!='n'){
                    Console.WriteLine("entrada no valida");
                }
            }while(seguir=='y');
        }
    }
}
