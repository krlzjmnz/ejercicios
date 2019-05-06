using System;
using System.Text;

namespace _2_tabla_de_multiplicar_hasta_el_20
{
    class Program
    {
        static void Main(string[] args)
        {
            char seguir='y';
            int numero;
            do{
                Console.WriteLine("Escribe un numero entero para mostrar su tabla de multicar");
                if(Int32.TryParse(Console.ReadLine(), out numero)){
                    Console.WriteLine(tabla(numero));
                }else{
                    Console.WriteLine($"El dato ingresado {numero} no es un numero");
                }
                Console.WriteLine("Ingrese 'y' para volver a ingresar otro numero 'n' para salir");
                if(!char.TryParse(Console.ReadLine(),out seguir) || seguir!='y' && seguir!='n'){
                    Console.WriteLine("entrada no valida");
                }
            }while(seguir=='y');
        }
        public static string tabla(int n){
            StringBuilder str=new StringBuilder();
            for(int i=1; i<=20; i++){
                str.Append($"{n} * {i} = {n*i}\n");
            }
            return str.ToString();
        }
    }
}
