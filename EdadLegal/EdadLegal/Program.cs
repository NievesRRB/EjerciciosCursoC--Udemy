using System;


namespace EdadLegal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicito el nombre al usuario 
            Console.WriteLine("Introduzca su nombre:");
            
            //Creo mi variable q almacene mi nombre q he pedido al usuario 
            string nombre = Console.ReadLine();

            //Solicito la edad al usuario 
            Console.WriteLine("Introduzca su edad:");

            //Creo la variable donde almacenare la edad del usuario, pero la parseo a tipo entero
            //ya q la consola lo interpreta como una cadena
            int edad = int.Parse(Console.ReadLine());

            //Controlamos q sea o no mayor de edad para el posterior saludo 
            if (edad >=18)
            {
                Console.WriteLine("Tu nombre es " + nombre + " y eres mayor de edad");
            }
            else
            {
                Console.WriteLine("Tu nombre es " + nombre + " y NO eres mayor de edad");
            }
        }
    }
}
