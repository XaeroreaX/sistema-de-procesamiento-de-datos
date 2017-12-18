using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_System_Wepon
{
    public class Personaje : jugador
    {

        //Atributos
        private string Clase;
        private int Nivel;
        private int Vitalidad;
        private int Aprendisaje;
        private int Aguante;
        private int Fuerza;
        private int Destreza;
        private int Resistencia;
        private int Inteligencia;
        private int Fe;
        private int Humanidad = 0;
        public Personaje(string Nombre, string Sexo, string Fisico, string Cara, string Pelo, string ojo) : base(Nombre, Sexo, Fisico, Cara, Pelo, ojo)
        {
            this.Nombre = Nombre;
            this.Sexo = Sexo;
            this.Fisico = Fisico;
            this.Cara = Cara;
            this.Pelo = Pelo;
            this.ojo = ojo;

        }
        public void Guerrero()
        {
            Clase = "Guerrero";
            Nivel = 4;
            Vitalidad = 11;
            Aprendisaje = 8;
            Aguante = 12;
            Fuerza = 13;
            Destreza = 13;
            Resistencia = 11;
            Inteligencia = 9;
            Fe = 9;
        }
        public void Caballero()
        {
            Clase = "Caballero";
            Nivel = 5;
            Vitalidad = 14;
            Aprendisaje = 10;
            Aguante = 10;
            Fuerza = 11;
            Destreza = 11;
            Resistencia = 10;
            Inteligencia = 9;
            Fe = 11;
        }
        public void Vagabundo()
        {
            Clase = "Vagabundo";
            Nivel = 3;
            Vitalidad = 10;
            Aprendisaje = 11;
            Aguante = 10;
            Fuerza = 10;
            Destreza = 14;
            Resistencia = 12;
            Inteligencia = 11;
            Fe = 8;
        }
        public void Ladron()
        {
            Clase = "Ladron";
            Nivel = 5;
            Vitalidad = 9;
            Aprendisaje = 11;
            Aguante = 9;
            Fuerza = 9;
            Destreza = 15;
            Resistencia = 10;
            Inteligencia = 12;
            Fe = 11;
        }
        public void Vandido()
        {
            Clase = "Vandido";
            Nivel = 4;
            Vitalidad = 12;
            Aprendisaje = 8;
            Aguante = 14;
            Fuerza = 14;
            Destreza = 9;
            Resistencia = 11;
            Inteligencia = 8;
            Fe = 10;
            //aqui te quedaste
        }
        public void Cazador()
        {
            Clase = "Cazador";
            Nivel = 4;
            Vitalidad = 11;
            Aprendisaje = 9;
            Aguante = 11;
            Fuerza = 12;
            Destreza = 14;
            Resistencia = 11;
            Inteligencia = 9;
            Fe = 9;
        }
        public void Hechizero()
        {
            Clase = "Hechizero";
            Nivel = 3;
            Vitalidad = 8;
            Aprendisaje = 15;
            Aguante = 9;
            Fuerza = 9;
            Destreza = 11;
            Resistencia = 8;
            Inteligencia = 15;
            Fe = 8;
        }
        public void Piromantico()
        {
            Clase = "Piromantico";
            Nivel = 1;
            Vitalidad = 10;
            Aprendisaje = 12;
            Aguante = 11;
            Fuerza = 12;
            Destreza = 9;
            Resistencia = 12;
            Inteligencia = 10;
            Fe = 8;
        }
        public void Clerigo()
        {
            Clase = "Clerigo";
            Nivel = 2;
            Vitalidad = 11;
            Aprendisaje = 11;
            Aguante = 9;
            Fuerza = 12;
            Destreza = 8;
            Resistencia = 11;
            Inteligencia = 8;
            Fe = 14;
        }
        public void Marginado()
        {
            Clase = "Marginado";
            Nivel = 6;
            Vitalidad = 11;
            Aprendisaje = 11;
            Aguante = 11;
            Fuerza = 11;
            Destreza = 11;
            Resistencia = 11;
            Inteligencia = 11;
            Fe = 11;
            //listo!!!
        }
        public void MostrarInfo()
        {
            bool b = false;

            while (b == false)
            {

                Console.WriteLine("Q)uiere ver toda la informacion del jugador o solo los A)tributos\n");
                var input = Console.ReadKey();
                switch (input.Key) //Switch on Key enum
                {
                    case ConsoleKey.Q:
                        Console.WriteLine("Nombre:\t{0}\nSexo:\t{1}\nFisico:\t{2}\nCara:\t{3}\nPelo:\t{4}\nojos:\t{5}\nClase:\t{6}\nNivel:\t{7}\nVitalidad:\t{8}\nAprendisaje:\t{9}\nAguante:\t{10}\nFuerza:\t{11}\nDestreza:\t{12}\nResistencia:\t{13}\nInteligencia:\t{14}\nFe:\t{15}\nHumanidad:\t{16}", Nombre, Sexo, Fisico, Cara, Pelo, ojo, Clase, Nivel, Vitalidad, Aprendisaje, Aguante, Fuerza, Destreza, Resistencia, Inteligencia, Fe, Humanidad);
                        b = true;
                        break;
                    case ConsoleKey.A:
                        Console.WriteLine("{5}\nClase:\t{6}\nNivel:\t{7}\nVitalidad:\t{8}\nAprendisaje:\t{9}\nAguante:\t{10}\nFuerza:\t{11}\nDestreza:\t{12}\nResistencia:\t{13}\nInteligencia:\t{14}\nFe:\t{15}\nHumanidad:\t{16}", Clase, Nivel, Vitalidad, Aprendisaje, Aguante, Fuerza, Destreza, Resistencia, Inteligencia, Fe, Humanidad);
                        b = true;
                        break;
                    default:
                        Console.WriteLine("ERROR, ingrese de nuevevo");
                        break;
                }
            }
        }

    }
}
