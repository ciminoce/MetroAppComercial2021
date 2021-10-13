using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Datos.Comun.UnitOfWork;
using MetroAppComercial2021.Entidades.Entidades;
using MetroAppComercial2021.Servicios.Facades;

namespace MetroAppComercial2021.Servicios
{
    public class EmpleadosServicios:IEmpleadosServicios
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmpleadosServicios(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public List<Empleado> GetLista()
        {
            try
            {
                List<Empleado> lista;
                using (var context = _unitOfWork.Create())
                {
                    lista = context.repositorios.empleadosRepositorio.GetLista();
                    foreach (var empleado in lista)
                    {
                        empleado.Provincia = context.repositorios.provinciasRepositorio.GetPorId(empleado.ProvinciaId);
                        empleado.Localidad = context.repositorios.localidadesRepositorio.GetPorId(empleado.LocalidadId);
                    }
                }

                return lista;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Existe(Empleado empleado)
        {
            //try
            //{
            //    bool existe = false;
            //    using (var context = _unitOfWork.Create())
            //    {
            //        existe = context.repositorios.empleadosRepositorio.Existe(empleado);
            //    }

            //    return existe;

            //}
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.Message);
            //}
            return true;
        }

        public int Agregar(Empleado empleado)
        {
            try
            {
                int registrosAfectados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.empleadosRepositorio.Agregar(empleado);
                    context.SaveChanges();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Editar(Empleado empleado)
        {
            try
            {
                int registrosAfectados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.empleadosRepositorio.Editar(empleado);
                    context.SaveChanges();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public bool EstaRelacionado(Empleado empleado)
        {
            //try
            //{
            //    bool estaRelacionado = false;
            //    using (var context = _unitOfWork.Create())
            //    {
            //        estaRelacionado = context.repositorios.empleadosRepositorio.EstaRelacionado(empleado);

            //    }

            //    return estaRelacionado;
            //}
            //catch (Exception e)
            //{
            //    throw new Exception(e.Message);
            //}
            return true;
        }

        public int Borrar(Empleado empleado)
        {
            try
            {
                int registrosAfectados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.empleadosRepositorio.Borrar(empleado);
                    context.SaveChanges();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
