using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Gato:Animal
    {
        public Gato(int idAminal, string nombreCientifico, Genero genero, PropiedadesAnimal propiedadesPerro, Reino reino)
        {
            this.idAnimal = idAminal;
            this.nombreCientifico = nombreCientifico;
            this.generoAnimal = genero;
            this.propiedadesAnimal = propiedadesPerro;
            this.reino = reino;

        }
    }
}
