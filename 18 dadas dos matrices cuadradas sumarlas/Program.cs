using System;
using System.Text;

namespace _18_dadas_dos_matrices_cuadradas_sumarlas
{
    class Program
    {
        static void Main(string[] args)
        {
            char seguir='y';
            int numero, matrices;
            int [,,] matriz;
            string [] arreglo;

            do{
                Console.WriteLine("Ingrese el numero de matrices a sumar: ");
                matrices=int.Parse(Console.ReadLine());
                Console.WriteLine("Vamos a crear las matrices cuadradas ingrese un numero entero");
                if(matrices>1 && int.TryParse(Console.ReadLine(),out numero)){
                    matriz= new int[numero, numero,matrices+1];
                    for(int h=0;h<matrices;h++){
                        Console.WriteLine($"Elementos de la matriz {h+1}");        
                        for(int i=0; i<numero; i++){
                            Console.WriteLine("ingrese registro del arreglo separado por comas");
                            arreglo=Console.ReadLine().Split(",");
                            for(int j=0; j<numero;j++){
                                matriz[i,j,h]=int.Parse(arreglo[j]);
                            }
                        }
                    }
                    Console.WriteLine(matrizsumada(ConstruirMatriz(matriz,numero,matrices),numero,matrices));
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
        public static int [,,] ConstruirMatriz(int [,,]m, int n, int length){
            for(int h=0;h<length;h++){
                for(int i=0; i<n; i++){
                    for(int j=0; j<n; j++){
                        m[i,j,length]+=m[i,j,h];
                    }        
                }
            }
            return m;
        }

        public static string matrizsumada(int [,,] m, int n, int length){
            StringBuilder s= new StringBuilder();
            for(int i=0; i<n; i++){
                for(int j=0; j<n;j++){
                    s.Append("["+m[i,j,length]+"]");
                }
                s.Append("\n");
            }
            return s.ToString();
        }
    }
}
