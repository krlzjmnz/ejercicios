using System;

namespace _7_dada_un_string_s_invertirla_hola___aloh
{
    class Program
    {
        static void Main(string[] args)
        {
            char seguir='y';
            char[] cadena1, cadena2;
            do{
                Console.WriteLine("Ingresa una cadena para mostrarla invertida");
                cadena1=Console.ReadLine().ToCharArray();
                Invertir(cadena1,out cadena2);
                Console.WriteLine("tu cadena invertida es:  ");
                foreach(char a in cadena2){
                    Console.Write(a);
                }
                Console.WriteLine("");
                Console.WriteLine("Ingrese 'y' para volver a ingresar otro cadena'n' para salir");
                if(!char.TryParse(Console.ReadLine(),out seguir) || seguir!='y' && seguir!='n'){
                    Console.WriteLine("entrada no valida");
                }
            }while(seguir=='y');
        }

        public static void Invertir(char[] cad1, out char[] cad2){
            cad2=new char[cad1.Length];
            for(int i=0, j=cad1.Length-1; i<cad1.Length; i++, j-- ){
                cad2[i]=cad1[j];
            }
        }
    }
}
