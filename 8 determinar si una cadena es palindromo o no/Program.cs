using System;
using System.Text;

namespace _8_determinar_si_una_cadena_es_palindromo_o_no
{
    class Program
    {
        static void Main(string[] args)
        {
            char seguir='y';
            char[] cadena;
            do{
                Console.WriteLine("Ingresa una oracion para saber si es palindromo");
                cadena=quitarEspacios(Console.ReadLine().ToCharArray()).ToLower().ToCharArray();
                
                if(esPalindromo(cadena)){
                    Console.WriteLine("La cadena es un palindromo");
                }
                else{
                    Console.WriteLine("No es un palindromo");
                }
                Console.WriteLine("Ingrese 'y' para volver a ingresar otro numero 'n' para salir");
                if(!char.TryParse(Console.ReadLine(),out seguir) || seguir!='y' && seguir!='n'){
                    Console.WriteLine("entrada no valida");
                }
            }while(seguir=='y');
        }
        public static bool esPalindromo(char[] cad){
            int aux =cad.Length/2, i=0, length=cad.Length-1;
            while(i<=aux){
                if(cad[i]!=cad[length]){
                    return false;
                }
                i++;
                length--;
            }
            return true;
        }

        public static string quitarEspacios(char[] cad){
            StringBuilder cadena= new StringBuilder();
            for(int i=0; i<cad.Length; i++){
                if(cad[i]!=' '){
                    cadena.Append(cad[i]);
                }
            }
            return cadena.ToString();
        }
    }
}
