using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Tarea
{
    class SeresVivos
    {
        protected int idSerVivo { get; set; }
        protected String nombreCientifico { get; set; }
        protected Genero generoSerVivo { get; set; }
        protected PropiedadesSerVivo propiedadesSerVivo { get; set; }
        protected Reino reino { get; set; }

        public override string ToString()
        {
            return
                "Id: " + idSerVivo + Environment.NewLine +
                "Nombre Cinentifico: " + nombreCientifico + Environment.NewLine +
                "Genero: " + generoSerVivo + Environment.NewLine +
                "============================================================="
                 + Environment.NewLine +
                 "% Agua: " + this.propiedadesSerVivo.porcertajeAgua + Environment.NewLine +
                 "% Grasa: " + this.propiedadesSerVivo.porcertajeGrasa + Environment.NewLine +
                 "Reino: " + this.reino;
        }
    }
}
