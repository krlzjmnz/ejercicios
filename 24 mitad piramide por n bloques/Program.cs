using System;
using System.Text;

namespace _23_mitad_piramide_por_n_bloques
{
    class Program
    {
        static void Main(string[] args)
        {
             char seguir='y';
            int numero;
            do{
                Console.WriteLine("Ingrese un numero entero positivo para imprimir la mitad\nde una piramide con esa cantidad de bloques");
                if(Int32.TryParse(Console.ReadLine(), out numero)){
                    Console.WriteLine($"Piramide:\n"+Piramide(numero));
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
        public static string Piramide(int n){
            StringBuilder cad = new StringBuilder();
            int aux=1;
            while(aux<=n){
                for(int i=1;i<=aux;i++){
                    cad.Append("*");
                }
                cad.Append("\n");
                aux++;
            }
            return cad.ToString();
        }
    }
}
