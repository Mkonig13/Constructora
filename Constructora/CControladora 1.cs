using System;
using System.Collections;

namespace SegundoParcial
{
    public class CControladora
    {
        public static void Main()
        {
            CEmpresa empresa = new CEmpresa();
            char opcion;
            do
            {
                char.TryParse(CInterfaz.DarOpcion().ToUpper(), out opcion);
                switch (opcion)
                {
                    case 'A':
                        float montoRef = float.Parse(CInterfaz.PedirDato("Monto de referencia"));
                        float matricula = float.Parse(CInterfaz.PedirDato("canon de profesionales en obras"));
                        empresa.asignarMontoReferencia(montoRef);
                        CInterfaz.MostrarInfo("Monto de referencia: " + montoRef.ToString() + "\ncanon de profesionales en obras: " + matricula.ToString());
                        break;

                    case 'B':
                        string ape = CInterfaz.PedirDato("Apellido del empleado");
                        string nom = CInterfaz.PedirDato("Nombre del empleado");
                        uint leg = uint.Parse(CInterfaz.PedirDato("Legajo del empleado"));

                        string emp = (CInterfaz.PedirDato("Obrero [A] - Profesional [B]"));
                        if (emp.ToUpper() == "A")
                        {
                            string P = (CInterfaz.PedirDato("Oficial [A] - Medio-Oficial [B] - Aprendiz [C]"));
                            EExp pos;
                            if (P.ToUpper() == "A") pos = EExp.Oficial;
                            else if (P.ToUpper() == "B") pos = EExp.Mediooficial;
                            else pos = EExp.Aprendiz;

                            if (empresa.registrarObrero(leg, nom, ape, pos))
                            {
                                CInterfaz.MostrarInfo("Obrero registrado con éxito");
                            }
                            else
                            {
                                CInterfaz.MostrarInfo("El obrero no fue registrado. Vuelva a intentarlo");
                            }
                        }
                        else
                        {
                            string tit = CInterfaz.PedirDato("Titulo del profesional");
                            ulong mat = ulong.Parse(CInterfaz.PedirDato("Matricula del profesional"));
                            string cons = CInterfaz.PedirDato("Consejo del profesional");
                            float aumento = float.Parse(CInterfaz.PedirDato("Procentaje propio y particular negosiado, EJEMPLO: [1,5 = 50%]"));

                            if (empresa.registrarProfesional(leg, nom, ape, tit, mat, cons, aumento))
                            {
                                CInterfaz.MostrarInfo("Empleado registrado con éxito");
                            }
                            else
                            {
                                CInterfaz.MostrarInfo("El empleado no fue registrado. Vuelva a intentarlo");
                            }
                        }
                        break;

                    case 'C':
                        CInterfaz.MostrarInfo(empresa.listarEmpleados());
                        break;

                    case 'D':
                        string codobra = CInterfaz.PedirDato("Código de obra");
                        string direobra = CInterfaz.PedirDato("Direccion de obra");
                        uint legprof = uint.Parse(CInterfaz.PedirDato("Legajo del profesional a designar"));

                        if (empresa.registrarObra(codobra, direobra, legprof))
                        {
                            CInterfaz.MostrarInfo("Obra registrada con éxito");
                        }
                        else
                        {
                            CInterfaz.MostrarInfo("No se pudo registrar la obra");
                        }
                        break;

                    case 'E':
                        string codobra2 = CInterfaz.PedirDato("Código de obra a modificar");
                        uint legprof2 = uint.Parse(CInterfaz.PedirDato("Legajo de profesional a asignar"));

                        if (empresa.modificarProfesional(codobra2, legprof2))
                        {
                            CInterfaz.MostrarInfo("Profesional cambiado con exito");
                        }
                        else
                        {
                            CInterfaz.MostrarInfo("No se pudo cambiar el profesional");
                        }
                        break;

                    case 'F':
                        string codobra3 = CInterfaz.PedirDato("Código de obra a asignar");
                        uint legob = uint.Parse(CInterfaz.PedirDato("Legajo de obrero a asignar"));

                        if (empresa.asignarObrero(codobra3, legob))
                        {
                            CInterfaz.MostrarInfo("Obrero asignado con exito");
                        }
                        else
                        {
                            CInterfaz.MostrarInfo("No se pudo asignar el obrero");
                        }
                        break;

                    case 'H':
                        string codobra4 = CInterfaz.PedirDato("Código de obra a listar");
                        CInterfaz.MostrarInfo(empresa.listarEmpleadosObra(codobra4));
                        break;

                    case 'I':
                        uint legprof3 = uint.Parse(CInterfaz.PedirDato("Ingrese el legajo del profesional a eliminar"));

                        if (empresa.eliminarProfesional(legprof3))
                        {
                            CInterfaz.MostrarInfo("El profesional fue eliminado con éxito");
                        }
                        else
                        {
                            CInterfaz.MostrarInfo("No se pudo eliminar al profesional");
                        }
                        break;

                    case 'S':
                        break;

                    default:
                        CInterfaz.MostrarInfo("Opción inválida");
                        break;
                }
            } while (opcion != 'S');
        }
    }
}
