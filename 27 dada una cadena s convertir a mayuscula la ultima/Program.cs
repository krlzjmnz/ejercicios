using System;

namespace _27_dada_una_cadena_s_convertir_a_mayuscula_la_ultima
{
    class Program
    {
        static void Main(string[] args)
        {
             char seguir='y';
            string cadena;
            do{
                Console.WriteLine("Ingresa una cadena de texto");
                cadena=Console.ReadLine();
                Console.WriteLine(ultimaLetraMayuscula(cadena));
                Console.WriteLine("Ingrese 'y' para volver a ejecutar el programa 'n' para salir");
                if(!char.TryParse(Console.ReadLine(),out seguir) || seguir!='y' && seguir!='n'){
                    Console.WriteLine("entrada no valida");
                }
		else if(seguir=='n'){
		Console.WriteLine("Teminando la ejecucion del programa");
		}
            }while(seguir=='y');
        }
        public static string ultimaLetraMayuscula(string cad){
            return cad.Replace(cad.ToCharArray()[cad.Length-1],char.Parse(cad.ToCharArray()[cad.Length-1].ToString().ToUpper()));
        }
    }
}
