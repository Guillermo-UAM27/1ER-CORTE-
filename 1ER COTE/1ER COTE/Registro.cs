using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ER_COTE
{
    internal class Registro
    {
        private Persona[] personas = new Persona[30];
        private int indice = 0;

       
        public bool AgregarPersona(Persona persona)
        {
            if (indice < 30)
            {
                personas[indice] = persona;
                indice++;
                return true;
            }
            else
            {
                return false;
            }
        }

        
        public Persona[] ObtenerPersonas()
        {
            Persona[] personasRegistradas = new Persona[indice];
            for (int i = 0; i < indice; i++)
            {
                personasRegistradas[i] = personas[i];
            }
            return personasRegistradas;
        }
    }
}
