using System;
using System.Diagnostics;
using System.Threading;

namespace excepciones
{
    class Program : Exception
    {
        static void Main(string[] args)
        {
            char seguir='y';
            int op;
            do{
                Console.WriteLine("1) Ejecutar Excepciones\n2) Ejecutar codigo controlado ");
                if(int.TryParse(Console.ReadLine(),out op)){
                    Stopwatch stopWatch = new Stopwatch();
                    stopWatch.Start();
                    for(int i=0;i<600000;i++){
                        switch(op){
                            case 1: 
                                tryAndCatch();
                            break;
                            case 2:
                                controlado();
                            break;
                        }
                    }   
                    stopWatch.Stop();
                    // Get the elapsed time as a TimeSpan value.
                    TimeSpan ts = stopWatch.Elapsed;

                    // Format and display the TimeSpan value.
                    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);
                    Console.WriteLine("RunTime " + elapsedTime);
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
        public static void tryAndCatch(){
             try{
                string n=null;
                int.Parse(n);
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }

        public static void controlado(){
                string n=null;
                if(n!=null){
                    int.Parse(n);
                }
                else{
                    Console.WriteLine("n=null no se convirtio a entero");
                }
        }
    }
}
