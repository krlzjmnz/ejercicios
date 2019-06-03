using System;
using System.Text.RegularExpressions;

namespace _22_si_es_biciesto_o_no
{
    class Program
    {
        static void Main(string[] args)
        {
          char seguir='y';
           string date;
            do{
                Console.WriteLine("Ingresa un año para saber si es bisiesto"); 
                date=Console.ReadLine();
                if(Regex.IsMatch(date,@"^[0-9]{4}$")){
                    Console.WriteLine((esBisiesto(int.Parse(date)))?$"El año {date} es bisiesto":$"El año {date} no lo es");
                }
                else{
                    Console.WriteLine($"No es un formto valido: {date}");
                }
                Console.WriteLine("Ingrese 'y' para volver ejecutar el programa 'n' para salir");
                if(!char.TryParse(Console.ReadLine(),out seguir) || seguir!='y' && seguir!='n'){
                    Console.WriteLine("entrada no valida");
                }
            }while(seguir=='y');
        }
        public static bool esBisiesto(int date){
            if ((date % 4 == 0) && ((date % 100 != 0) || (date % 400 == 0))){
                return true;
            }
            return false;
        }
    }
}
