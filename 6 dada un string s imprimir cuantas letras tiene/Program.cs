using System;

namespace _6_dada_un_string_s_imprimir_cuantas_letras_tiene
{
    class Program
    {
        static void Main(string[] args)
        {
            char seguir='y';
            char[] cad;
            do{
                Console.WriteLine("Ingrese caracteres: ");
                cad=Console.ReadLine().ToCharArray();

                Console.WriteLine("En tus caracteres hay: "+numeroDeLetras(cad)+" Letras" );
                
                Console.WriteLine("Ingrese 'y' para volver a ingresar otros caracteres 'n' para salir");
                if(!char.TryParse(Console.ReadLine(),out seguir) || seguir!='y' && seguir!='n'){
                    Console.WriteLine("entrada no valida");
                }
            }while(seguir=='y');
        }

        public static int numeroDeLetras(char[] cadena){
            int i=0;
            foreach(char a in cadena){
               if( (((int)a)>=65 && ((int)a)<=90) || (((int)a)>=97 && ((int)a)<=122)){
                   i++;
               } 
            }
            return i;
        }
    }
}
