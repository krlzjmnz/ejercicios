using System;
using System.Text;

namespace _9_sustituir_las_letras_repetidas_por_el_numero_de_veces
{
    class Program
    {
        static void Main(string[] args)
        {
            char seguir='y';
            do{
                Console.WriteLine("Ingresa caracteres para convertir cadena");
                Console.WriteLine(convertirCadena(Console.ReadLine().ToCharArray()));

                Console.WriteLine("Ingrese 'y' para volver a escribir caracteres 'n' para salir");
                if(!char.TryParse(Console.ReadLine(),out seguir) || seguir!='y' && seguir!='n'){
                    Console.WriteLine("entrada no valida");
                }
            }while(seguir=='y');
        }
        public static string convertirCadena(char[] cadena){
            StringBuilder cad=new StringBuilder();
            int i=0, num;
            while(i<cadena.Length){
                cad.Append(cadena[i]);
                num=contar(cadena,i,out i);
                cad.Append((num!=1)? ""+num : "");
            }
            return cad.ToString();
        }

        public static int contar(char[] cadena,int inicio, out int fin){
            int num=0, i=inicio;
            char a=cadena[inicio];
            while(i<cadena.Length && a==cadena[i]){
                    num++;
                    i++;
            }
            fin=i;
            return num;
        }
    }
}
