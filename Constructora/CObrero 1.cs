using System;
using System.Collections;

namespace SegundoParcial
{
    public class CObrero : CEmpleado
    {
        private EExp experiencia;

        public CObrero(uint leg, string nom, string ape, EExp exp) : base(leg, nom, ape)
        {
            this.experiencia = exp;
        }

        public override string ToString()
        {
            string datos = "";
            datos += base.ToString();
            datos += ", experiencia: " + this.experiencia;
            datos += ", haber mensual: " + this.mostrarSueldo().ToString();
            return datos;
        }

        public float mostrarSueldo()
        {
            if (this.experiencia == EExp.Oficial) return CEmpleado.GetMontoReferencia();
            else if (this.experiencia == EExp.Mediooficial) return CEmpleado.GetMontoReferencia() * (float)0.65;
            else return CEmpleado.GetMontoReferencia() * (float)0.25;
        }
    }
}
