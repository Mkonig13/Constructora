using System;
using System.Collections;

namespace SegundoParcial
{
    public class CProfesional : CEmpleado
    {
        private string titulo;
        private ulong matricula;
        private string consejo;
        private float aumento;

        public CProfesional(uint leg, string nom, string ape, string tit, ulong mat, string cons, float aument) : base(leg, nom, ape)
        {
            this.titulo = tit;
            this.matricula = mat;
            this.consejo = cons;
            this.aumento = aument;
        }

        public override string ToString()
        {
            string datos = "";
            datos += base.ToString();
            datos += ", titulo: " + this.titulo;
            datos += ", matricula: " + this.matricula.ToString();
            datos += ", consejo: " + this.consejo;
            datos += ", sueldo con respectivo aumento: " + this.mostrarSueldo().ToString();
            return datos;
        }

        public float mostrarSueldo()
        {
            return CEmpleado.GetMontoReferencia() * (float)this.aumento; ;
        }

    }
}
