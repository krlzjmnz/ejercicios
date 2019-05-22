using System;
using System.Text;

namespace _10_dada_s_recorrer_13_pocosiones_la_letra
{
    class Program
    {
        static void Main(string[] args)
        {
            char seguir='y';
            string mensaje;
            int op;
            do{
                Console.WriteLine("ingresa una cadena para cifrar:");
                mensaje=Console.ReadLine().ToLower();
                Console.WriteLine("recorrer a la izquierda 1)\n recorrer a la derecha 2)");
                if(int.TryParse(Console.ReadLine(),out op)){
                switch(op){
                    case 1:
                    Console.WriteLine("tu cadena es:\n"+RecorrerIzq(mensaje));
                    break;
                    case 2:
                    Console.WriteLine("tu cadena es:\n"+RecorrerDer(mensaje));
                    break;
                }
                }
                Console.WriteLine("Ingrese 'y' para volver a ingresar otra cadena 'n' para salir");
                if(!char.TryParse(Console.ReadLine(),out seguir) || seguir!='y' && seguir!='n'){
                    Console.WriteLine("entrada no valida");
                }
            }while(seguir=='y');
        }
        public static string RecorrerIzq(string cad){
            char [] arr=cad.ToCharArray();
            int aux=13;

            StringBuilder texto= new StringBuilder();

            foreach(char a in arr){
                if((int)a>=97 && (int)a<=122){
                    if(((((int)a)-aux)<97)){
                        aux=(int)a-97;
                        texto.Append((char)(((int)(122-aux))));
                    }
                    else{
                        texto.Append((char)(((int)(a-aux))));
                    }
                    aux=13;
                }
                else{
                    texto.Append(a);
                }
            }
            return texto.ToString();
        }
           public static string RecorrerDer(string cad){
            char [] arr=cad.ToCharArray();
            int aux=13;

            StringBuilder texto= new StringBuilder();

            foreach(char a in arr){
                if((int)a>=97 && (int)a<=122){
                    if((((int)a)+aux)>122){
                        aux=122-(int)a;
                        texto.Append((char)(((int)(97+aux))));
                    }
                    else{
                        texto.Append((char)(((int)(a+aux))));
                    }
                    aux=13;
                }
                else{
                    texto.Append(a);
                }
            }
            return texto.ToString();
        }
    }
}
