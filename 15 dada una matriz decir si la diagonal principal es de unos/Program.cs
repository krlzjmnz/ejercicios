using System;
using System.Text;

namespace _15_dada_una_matriz_decir_si_la_diagonal_principal_es_de_unos
{
    class Program
    {
        static void Main(string[] args)
        {
           char seguir='y';
            int numero;
            int [,] matriz;
            string [] arreglo;

            do{
                Console.WriteLine("Vamos a crear una matriz cuadrada ingrese un numero entero");
                if(int.TryParse(Console.ReadLine(),out numero)){
                    matriz= new int[numero, numero];        
                    for(int i=0; i<numero; i++){
                        Console.WriteLine("ingrese el primer arreglo separado por comas");
                        arreglo=Console.ReadLine().Split(",");
                        for(int j=0; j<numero;j++){
                            matriz[i, j]=int.Parse(arreglo[j]);
                        }
                    }
                    if(diagonalPrincipalEsUno(matriz,numero)){
                        Console.WriteLine("La matriz tiene una diagonal principal de unos");
                    }
                    else{
                        Console.WriteLine("Su diagonal no es de unos");
                    }
                }
                Console.WriteLine("Ingrese 'y' para volver a ingresar otro numero 'n' para salir");
                if(!char.TryParse(Console.ReadLine(),out seguir) || seguir!='y' && seguir!='n'){
                    Console.WriteLine("entrada no valida");
                }
            }while(seguir=='y');
        }
        public static bool diagonalPrincipalEsUno(int [,] m, int n){
            for(int i=0; i<n; i++){
                if(m[i,i]!=1){
                    return false;
                }
            }
            return true;
        }
    }
}
