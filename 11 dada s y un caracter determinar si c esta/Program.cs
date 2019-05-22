using System;

namespace _11_dada_s_y_un_caracter_determinar_si_c_esta
{
    class Program
    {
        static void Main(string[] args)
        {
            char seguir='y';
            string cadena;
            char a;
            do{
                Console.WriteLine("Ingrese una cadena: ");
                cadena=Console.ReadLine();
                Console.WriteLine("Ingrese el caracter a identificar en la cadena: ");

                a=Console.ReadLine().ToCharArray()[0];
                
                Console.WriteLine("Ingrese 'y' para volver a ingresar otra cadena 'n' para salir");
                if(!char.TryParse(Console.ReadLine(),out seguir) || seguir!='y' && seguir!='n'){
                    Console.WriteLine("entrada no valida");
                }
            }while(seguir=='y');
        }
        public static bool Esta(char[] cadena,char a){
            foreach(char c in cadena){
                if(c==a){
                    return true;
                }
            }
            return false;
        }
    }
}
