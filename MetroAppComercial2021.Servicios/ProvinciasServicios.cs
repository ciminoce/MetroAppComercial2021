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
    public class ProvinciasServicios:IProvinciasServicios
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProvinciasServicios(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public List<Provincia> GetLista()
        {
            try
            {
                List<Provincia> lista = new List<Provincia>();
                using (var context = _unitOfWork.Create())
                {
                    lista = context.repositorios.provinciasRepositorio.GetLista();
                }

                return lista;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public int Agregar(Provincia provincia)
        {
            try
            {
                int registrosAfectados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.provinciasRepositorio.Agregar(provincia);
                    context.SaveChanges();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Provincia provincia)
        {
            try
            {
                bool estaRelacionado = false;
                using (var context = _unitOfWork.Create())
                {
                    estaRelacionado = context.repositorios.provinciasRepositorio.EstaRelacionado(provincia);
                }

                return estaRelacionado;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Provincia provincia)
        {
            try
            {
                bool existe = false;
                using (var context = _unitOfWork.Create())
                {
                    existe = context.repositorios.provinciasRepositorio.Existe(provincia);
                }

                return existe;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Borrar(Provincia provincia)
        {
            try
            {
                int registrosAfectados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.provinciasRepositorio.Borrar(provincia);
                    context.SaveChanges();

                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Editar(Provincia provincia)
        {
            try
            {
                int registrosAfectados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.provinciasRepositorio.Editar(provincia);
                    context.SaveChanges();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Provincia GetPorId(int id)
        {
            try
            {
                Provincia tipo = null;
                using (var context = _unitOfWork.Create())
                {
                    tipo = context.repositorios.provinciasRepositorio.GetPorId(id);
                }

                return tipo;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
