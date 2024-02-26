using System;
using System.Collections;

namespace SegundoParcial
{
    public class CEmpleado
    {
        private uint legajo;
        private string nombre;
        private string apellido;
        private static float montoReferencia;

        public CEmpleado(uint leg, string nom, string ape)
        {
            this.legajo = leg;
            this.nombre = nom;
            this.apellido = ape;
        }

        public uint GetLegajo() { return this.legajo; }

        public static void SetMontoReferencia(float monto)
        {
            CEmpleado.montoReferencia = monto;

        }
        public static float GetMontoReferencia()
        {
            return CEmpleado.montoReferencia;
        }

        public override string ToString()
        {
            string datos = "";
            datos += "Legajo: " + this.legajo.ToString();
            datos += ", nombre: " + this.nombre;
            datos += ", apellido: " + this.apellido;
            return datos;
        }
    }
}