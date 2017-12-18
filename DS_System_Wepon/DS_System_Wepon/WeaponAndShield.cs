using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_System_Wepon
{
    public class WeaponAndShield
    {
        //Tipo de ataque
        protected string TipoDeAtaque;
        //tipos de daños
        protected int AjusteDeHedhizos;
        protected int Dañfisico;
        protected int DañFuego;
        protected int DañMagico;
        protected int DañRayo;
        protected int DañCritico;
        //efecto secundarios
        protected int EfEmorragia;
        protected int EfVeneno;
        protected int EfDivino;
        protected int EfOscuro;
        //Reduccion de daño
        protected double Redfisico;
        protected double RedFuego;
        protected double RedMagico;
        protected double RedRayo;
        protected int estabilidad;
        //requisitos generales
        protected int durabilidad;
        protected double peso;
    }
}
