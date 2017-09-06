using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Animal
    {
        protected int idAnimal { get; set; }
        protected String nombreCientifico { get; set; }
        protected Genero generoAnimal { get; set; }
        protected PropiedadesAnimal propiedadesAnimal{get;set; }
        protected Reino reino { get; set; }

        public override string ToString()
        {
            return
                "Id: " + idAnimal + Environment.NewLine +
                "Nombre Cinentifico: " + nombreCientifico + Environment.NewLine +
                "Genero: " + generoAnimal + Environment.NewLine +
                "============================================================="
                 + Environment.NewLine +
                 "% Agua: " + this.propiedadesAnimal.porcertajeAgua + Environment.NewLine +
                 "% Grasa: " + this.propiedadesAnimal.porcertajeGrasa + Environment.NewLine +
                 "Reino: " + this.reino ;
        }
    }
}
