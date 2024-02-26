using System;
using System.Collections;

namespace SegundoParcial
{
    public class CEmpresa
    {
        private ArrayList listaEmpleados;
        private ArrayList listaObras;

        public CEmpresa()
        {
            this.listaObras = new ArrayList();
            this.listaEmpleados = new ArrayList();
        }

        // buscar obrero en las obras
        public CObrero buscarObrero(uint leg)
        {
            foreach (CObra obra in this.listaObras)
            {
                CObrero aux = obra.buscarObrero(leg);
                if (aux != null)
                {
                    return aux;
                }
            }
            return null;
        }
        // registrar obrero en empresa
        public bool registrarObrero(uint leg, string nom, string ape, EExp exp)
        {
            CObrero aux = this.buscarObrero(leg);
            if (aux == null)
            {
                this.listaEmpleados.Add(new CObrero(leg, nom, ape, exp));
                return true;
            }
            return false;
        }
        // buscar profesional en las obra
        public CProfesional buscarProfesional(uint leg)
        {
            foreach (CObra obra in this.listaObras)
            {
                CProfesional aux = obra.buscarProfesional(leg);
                if (aux != null)
                {
                    return aux;
                }
            }
            return null;
        }
        // buscar profesional en todos los empleados
        public CProfesional buscarProfesionalEnEmpleados(uint leg)
        {
            foreach (CEmpleado emp in this.listaEmpleados)
            {
                if (emp.GetLegajo() == leg)
                {
                    return (CProfesional)emp;
                }
            }
            return null;
        }
        // buscar obrero en todos los empleados
        public CObrero buscarObreroEnEmpleados(uint leg)
        {
            foreach (CEmpleado emp in this.listaEmpleados)
            {
                if (emp.GetLegajo() == leg)
                {
                    return (CObrero)emp;
                }
            }
            return null;
        }
        // registrar profesional en empleados
        public bool registrarProfesional(uint leg, string nom, string ape, string tit, ulong mat, string cons, float aument)
        {
            CProfesional aux = this.buscarProfesional(leg);
            if (aux == null)
            {
                this.listaEmpleados.Add(new CProfesional(leg, nom, ape, tit, mat, cons, aument));
                return true;
            }
            return false;
        }
        // listar todos los empleados
        public string listarEmpleados()
        {
            string datos = "";
            foreach (CEmpleado emp in this.listaEmpleados)
            {
                datos += emp.ToString() + "\n";
            }
            return datos;
        }
        // buscar obra
        public CObra buscarObra(string cod)
        {
            foreach (CObra obra in this.listaObras)
            {
                if (cod == obra.GetCodigo())
                {
                    return obra;
                }
            }
            return null;
        }
        // registrar obra
        public bool registrarObra(string cod, string dire, uint leg)
        {
            CProfesional aux = null;
            foreach (CEmpleado emp in this.listaEmpleados)
            {
                if (emp.GetLegajo() == leg)
                {
                    aux = (CProfesional)emp;
                }
            }
            if (aux == null)
            {
                return false;
            }
            if (this.buscarObra(cod) == null)
            {
                this.listaObras.Add(new CObra(cod, dire, aux));
                return true;
            }
            return false;
        }
        // modificar profesional
        public bool modificarProfesional(string cod, uint leg)
        {
            CObra aux = this.buscarObra(cod);
            if (aux != null)
            {
                CProfesional auxprof = this.buscarProfesionalEnEmpleados(leg);
                if (auxprof != null) 
                {
                    aux.SetProfesional(auxprof);
                    return true;
                }
            }
            return false;
        }
        // asignar obrero a obra
        public bool asignarObrero(string cod, uint leg)
        {
            CObrero obrero = this.buscarObreroEnEmpleados(leg);
            foreach (CObra obra in this.listaObras)
            {
                if (obra.GetCodigo() == cod)
                {
                    obra.asignarObrero(obrero);
                    return true;
                }
            }
            return false;
        }
        // listar datos de empleados en una obra
        public string listarEmpleadosObra(string cod)
        {
            CObra aux = this.buscarObra(cod);
            if (aux != null)
            {
                string datos = aux.listarEmpleados();
                return datos;
            }
            return "No se encontro la obra indicada";
        }
        // eliminar profesional que no este en obra
        public bool eliminarProfesional(uint leg)
        {
            CProfesional prof = this.buscarProfesionalEnEmpleados(leg);
            if (this.buscarProfesional(leg) == null)
            {
                this.listaEmpleados.Remove(prof);
                return true;
            }
            return false;
        }
        // asignar monto de referencia
        public void asignarMontoReferencia(float monto)
        {
            CEmpleado.SetMontoReferencia(monto);
        }
    }
}
