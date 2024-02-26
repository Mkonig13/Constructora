    using System;
using System.Collections;

namespace SegundoParcial
{
    public class CObra
    {
        private string codigo;
        private string direccion;
        private CProfesional profesional;
        private ArrayList listaObrerosObra;

        public CObra(string cod, string dire, CProfesional prof)
        {
            this.codigo = cod;
            this.direccion = dire;
            this.profesional = prof;
            this.listaObrerosObra = new ArrayList();
        }

        public string GetCodigo() { return this.codigo; }
        public void SetProfesional(CProfesional prof) { this.profesional = prof; }

        // buscar obrero en obra
        public CObrero buscarObrero(uint leg)
        {
            foreach (CObrero obrero in this.listaObrerosObra)
            {
                if (leg == obrero.GetLegajo())
                {
                    return obrero;
                }
            }
            return null;
        }
        // buscar profesional en obra
        public CProfesional buscarProfesional(uint leg)
        {
            if (leg == profesional.GetLegajo())
            {
                return this.profesional;
            }
            return null;
        }
        // asignar obrero a obra
        public void asignarObrero(CObrero obrero)
        {
            this.listaObrerosObra.Add(obrero);
        }
        // listar empleados de la obra
        public string listarEmpleados()
        {
            string datos = "";
            datos += this.profesional.ToString() +"\n";

            foreach (CObrero obrero in this.listaObrerosObra)
            {
                datos += obrero.ToString() + "\n";
            }
            return datos;
        }
    }
}
