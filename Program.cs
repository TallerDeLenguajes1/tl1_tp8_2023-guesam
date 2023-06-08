using tareas;
int a;
List<tarea> lista = new List<tarea>();
var random = new Random(Environment.TickCount);

Console.WriteLine("Ingrese la cantidad de tareas: ");
int.TryParse(Console.ReadLine(), out a);

for (int i = 0; i < a; i++)
{
    
}

/* using System;
 
namespace prueba
{
    class MainClass
    {
        public static void Main (string[] args)
        {
 
            Random r= new Random ();
 
            //Genera un numero entre 10 y 100 (101 no se incluye)
            for (int i = 0; i <5; i++)
            {   
                Console.WriteLine(r.Next (10,101));
            }
 
            Console.ReadLine ();
        }
 
    }
} */