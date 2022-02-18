using System;

namespace reviwe_C_Sharp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            void tipos_datos()
            {
                sbyte x = 120;  //-128 y 127
                short y = 30000;    //-32767 y 32767
                int edad = 15;  //-2147483648 y 2147483647
                long z = 9000000000;    //-9___ ___ ___ ___ ___ ___

                float a = 99.99f;   //1.5x10^-45 3.4x10^38 7 digitos de precision
                double b = 1.5;     // presicion de 15 digitos
                decimal c = 12.343m; // presicion de 28 digitos

                bool interruptor = false;  // true / False

                char letra = 'a';       //letra en conmilla simple
                string cadena = "Jorge";    //comilla doble

                Console.WriteLine($"cadena de respuesta {interruptor}") ;
            }

            void metodos_string()
            {
                string miNombre = "Jorge";
                string mensaje = "Mi nombre es " + miNombre;
                Console.WriteLine($"el mensaje es {mensaje}");

                Console.WriteLine($"{mensaje.ToUpper()}");
                Console.WriteLine($"{mensaje.ToLower()}");

            }

            
            //tipos_datos();
            metodos_string();
            Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("end of the World.");
        }
    }
}
