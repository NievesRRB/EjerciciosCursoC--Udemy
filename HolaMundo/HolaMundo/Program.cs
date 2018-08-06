//Por defecto me importa las librerias mas comunes, las q se suelen emplear
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Me importa mi namespace HolaMundo y dentro de el esta la clase Program
namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribimos el código
            Console.WriteLine("Hola Mundo, hoy es " +DateTime.Now.ToLongDateString()+ " y mi nombre es Nieves");
        }
    }
}
