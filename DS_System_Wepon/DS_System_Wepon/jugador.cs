using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_System_Wepon
{
    public class jugador
    {
        //caracteristica del personaje
        protected string Nombre;
        protected string Sexo;
        protected string Fisico;
        protected string Cara;
        protected string Pelo;
        protected string ojo;

        public jugador(string Nombre, string Sexo, string Fisico, string Cara, string Pelo,string ojo)
        {
            this.Nombre = Nombre;
            this.Sexo = Sexo;
            this.Fisico = Fisico;
            this.Cara = Cara;
            this.Pelo = Pelo;
            this.ojo = ojo;
        }
    }
}
