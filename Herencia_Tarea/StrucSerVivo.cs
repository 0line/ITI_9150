﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Tarea
{
    public struct PropiedadesSerVivo
    {
        private float PorcentajeGrasa;

        public float porcertajeGrasa
        {
            get
            {
                return this.PorcentajeGrasa;

            }
            set
            {
                if (value > -1 && value <= 100)
                {
                    this.PorcentajeGrasa = value;
                }
            }
        }

        private float PorcentajeAgua;

        public float porcertajeAgua
        {
            get
            {
                return this.PorcentajeAgua;

            }
            set
            {
                if (value > -1 && value <= 100)
                {
                    this.PorcentajeAgua = value;
                }
            }
        }
    }
}
