using System;

namespace _3_factorial_de_un_numero_n
{
    class Program
    {
        static void Main(string[] args)
        {
            char seguir='y';
            int numero;
            do{
                Console.WriteLine("Escribe un numero entero para mostrar su factorial");
                if(Int32.TryParse(Console.ReadLine(), out numero)){
                    Console.WriteLine($"el {numero}! es: "+factorial(numero));
                }else{
                    Console.WriteLine($"El dato ingresado {numero} no es un numero");
                }
                Console.WriteLine("Ingrese 'y' para volver a ingresar otro numero 'n' para salir");
                if(!char.TryParse(Console.ReadLine(),out seguir) || seguir!='y' && seguir!='n'){
                    Console.WriteLine("entrada no valida");
                }
            }while(seguir=='y');
        }

        public static int factorial(int n){
            var aux=1;
            for(int i=n; i>0; i--){
                aux=aux*i;
            }
            return aux;
        }
        }
    }
