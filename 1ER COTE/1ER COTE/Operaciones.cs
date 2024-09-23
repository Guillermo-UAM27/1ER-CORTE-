using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ER_COTE
{
    internal class Operaciones
    {
        
        public int CalcularEdad(Persona persona)
        {
            int edad = DateTime.Now.Year - persona.FechaNacimiento.Year;
            if (DateTime.Now.DayOfYear < persona.FechaNacimiento.DayOfYear)
            {
                edad--;
            }
            return edad;
        }
        
        public bool EsMayorDeEdad(Persona persona)
        {
            return CalcularEdad(persona) >= 18;
        }
    }
}
