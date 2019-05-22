using System;

namespace _16_determinar_si_un_numero_es_primo
{
    class Program
    {
        static void Main(string[] args)
        {
            char seguir='y';
            int numero;
            do{
                Console.WriteLine("Ingrese un numero entero para determinar si es primo: ");
                if(Int32.TryParse(Console.ReadLine(), out numero)){
                    if(EsPrimo(numero)){
                        Console.WriteLine($"el {numero} : es primo");
                    }
                    else{
                         Console.WriteLine($"el {numero} : no pertenece a los numero primos");
                    }
                }else{
                    Console.WriteLine($"El dato ingresado {numero} no es un numero");
                }
                Console.WriteLine("Ingrese 'y' para volver a ejecutar el programa 'n' para salir");
                if(!char.TryParse(Console.ReadLine(),out seguir) || seguir!='y' && seguir!='n'){
                    Console.WriteLine("entrada no valida");
                }
		        else if(seguir=='n'){
		            Console.WriteLine("Termino la ejecucion del programa");
		        }
            }while(seguir=='y');
        }
        public static bool EsPrimo(int numero){
            for(int i=2; i<=Math.Sqrt(numero); i++){
                if(numero%i==0){
                    return false;
                }
            }
            return true;
        }
    }
}
