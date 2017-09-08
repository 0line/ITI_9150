using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Tarea
{
    class SerVivo:SeresVivos
    {
        public SerVivo()
        {

        }
        public SerVivo(int idAminal, string nombreCientifico, Genero genero, PropiedadesSerVivo propiedadesSerVivo, Reino reino)
        {
            this.idSerVivo = idAminal;
            this.nombreCientifico = nombreCientifico;
            this.generoSerVivo = genero;
            this.propiedadesSerVivo = propiedadesSerVivo;
            this.reino = reino;

        }
        public SerVivo(int idAminal, string nombreCientifico, Genero genero,  Reino reino)
        {
            this.idSerVivo = idAminal;
            this.nombreCientifico = nombreCientifico;
            this.generoSerVivo = genero;
            this.reino = reino;

        }

    }
}
