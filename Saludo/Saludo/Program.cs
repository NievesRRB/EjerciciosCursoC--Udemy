using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saludo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenamos cadenas
            //Console.WriteLine("Hola" + " Nieves");

            //Ahora generamos el saludo pasándole argumentos 
            Console.WriteLine("Hola " + args[0] + " " + args[1] + " " + args[2] + " " + args [3] + " " + args[4]);
        }
    }
}


//Errores de sintaxis 
/*Errores de escritura, error al cerrar llaves*/

//Errores de runtime --> Se trabajan con el debugging
/*No le pasamos los parametros adecuados a una funcion*/

/*Si le doy a la pestaña Depurar --> Iniciar depuración, me salta un error de fuera del rango pq no le estoy pasando los 
/parametros adecuadamente. Para ello, generamos un punto de interrupcion.
Para evitar los errores, me voy a mi proyecto Saludo (boton derecho raton --> Propiedades y en la pestaña de depurar,
en argumento de la linea de comandos, le añado los parametros q le paso a mi cadena.*/