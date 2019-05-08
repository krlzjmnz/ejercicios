using System;
using System.Text;

namespace _4_imprimir_el_numero_de_fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
             char seguir='y';
            int numero;
            do{
                Console.WriteLine("Escribe un numero entero para mostrar su serie de fibonacci");
                if(Int32.TryParse(Console.ReadLine(), out numero)){
                    if(numero>0){
                        Console.WriteLine(fibonacci(numero));
                    }
                    else{
                        Console.WriteLine("El numero debe ser entero y positivo");
                    }
                }else{
                    Console.WriteLine($"El dato ingresado {numero} no es un numero");
                }
                Console.WriteLine("Ingrese 'y' para volver a ingresar otro numero 'n' para salir");
                if(!char.TryParse(Console.ReadLine(),out seguir) || seguir!='y' && seguir!='n'){
                    Console.WriteLine("entrada no valida");
                }
            }while(seguir=='y');
        }
        
        public static string fibonacci(int numFibonacci){
            StringBuilder text= new StringBuilder();
            int numserie=1, aux=0, aux2;
            for(int i=0; i<=numFibonacci; i++){
                aux2=aux;
                aux=numserie+aux;
                numserie=aux2;
                text.Append($"{numserie}");
                if(i!=numFibonacci){
                    text.Append(", ");
                }
            }
            return text.ToString();
        }
    }
}
