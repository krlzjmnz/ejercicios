using System;

namespace _25_combinar_colores_consola
{
    class Program
    {
        static void Main(string[] args)
        {
             char seguir='y';
             int numero;
            do{
                Console.WriteLine("Selecciona un numero para cambiar el color\n1) Rojo\n2)Azul\n3)Amarillo");
                if(Int32.TryParse(Console.ReadLine(), out numero)){
                    CambiarColor(numero);
                    Console.WriteLine("Ingrese un texto:");
                    Console.WriteLine("el texto que ingresaste es: "+Console.ReadLine());
                }else{
                    Console.WriteLine($"El dato ingresado {numero} no es un numero");
                }
                Console.WriteLine("Ingrese 'y' para volver a ejecutar el programa 'n' para salir");
                if(!char.TryParse(Console.ReadLine(),out seguir) || seguir!='y' && seguir!='n'){
                    Console.WriteLine("entrada no valida");
                }
		else if(seguir=='n'){
		Console.WriteLine("Teminando la ejecucion del programa");
		}
            }while(seguir=='y');
        }
        public static void CambiarColor(int color){
            switch (color)
            {

                    case 1: Console.BackgroundColor=ConsoleColor.Red;
                        break;

                        

                        case 2: Console.BackgroundColor=ConsoleColor.Blue;
                         break;

                case 3:Console.BackgroundColor=ConsoleColor.Yellow; 
                 break;
                 
                  default://defecto

                        Console.Write("Se ingreso un valor fuera de rango");

                        break;

            }

            Console.WriteLine();
        }
    }
}
