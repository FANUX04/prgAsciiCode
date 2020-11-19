using System;

namespace prgAsciiCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci un valore numerico o alfanumerico da convertire in ASCII");
            char carattere = Convert.ToChar(Console.ReadLine());

            int number = carattere;
            // aggiunge 4 al numero decimale corrispondente della lettera inserita
            //number = number + 4;
            
            Console.WriteLine($"il carattere digitato corrisponde al numero....{number.ToString()}");
            string binario = Convert.ToString(number, 2).PadLeft(8,'0');

            Console.WriteLine($"il carattere in codice binario corrisponde alla sequenza di bit {binario}");
            Console.ReadKey();
        }
    }
}
