using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_System_Wepon
{
    class Program
    {
        static void Main(string[] args)
        {
            //elejir una clase
            Console.WriteLine("ingrese dato del personaje\n");
            Console.WriteLine("Nombre: ");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Sexo: ");
            string Sexo = Console.ReadLine();
            Console.WriteLine("Fisico: ");
            string Fisico = Console.ReadLine();
            Console.WriteLine("Cara: ");
            string Cara = Console.ReadLine();
            Console.WriteLine("Pelo: ");
            string Pelo = Console.ReadLine();
            Console.WriteLine("Ojo: ");
            string ojo = Console.ReadLine();
            Personaje player = new Personaje(Nombre, Sexo, Fisico, Cara, Pelo, ojo);
            Console.WriteLine("¿Que clase eliges?\nA)Guerrero\nB)Caballero\nC)Vagabundo\nD)Ladron\nE)Vandido\nF)Cazador\nG)Hechizero\nH)Piromantico\nI)Clerigo\nJ)Marginado");
            var input = Console.ReadKey();
            switch (input.Key)
            {
                case ConsoleKey.A:
                    player.Guerrero();
                    break;
                case ConsoleKey.B:
                    player.Caballero();
                    break;
                case ConsoleKey.C:
                    player.Vagabundo();
                    break;
                case ConsoleKey.D:
                    player.Ladron();
                    break;
                case ConsoleKey.E:
                    player.Vandido();
                    break;
                case ConsoleKey.F:
                    player.Cazador();
                    break;
                case ConsoleKey.G:
                    player.Hechizero();
                    break;
                case ConsoleKey.H:
                    player.Piromantico();
                    break;
                case ConsoleKey.I:
                    player.Clerigo();
                    break;
                case ConsoleKey.J:
                    player.Marginado();
                    break;
                
            }
            player.MostrarInfo();

            //subir de nivel
            //conseguir arma
            //reforza o modificar
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
