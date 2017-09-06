using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Planta:Animal
    {
        public Planta(int idAminal, string nombreCientifico, Genero genero,  Reino reino)
        {
            this.idAnimal = idAminal;
            this.nombreCientifico = nombreCientifico;
            this.generoAnimal = genero;
            this.reino = reino;

        }
    }
}
