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
    public class NuecesServicios:INuecesServicios
    {
        private readonly IUnitOfWork _unitOfWork;

        public NuecesServicios(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public List<TipoNuez> GetLista()
        {
            try
            {
                List<TipoNuez> lista = new List<TipoNuez>();
                using (var context = _unitOfWork.Create())
                {
                    lista = context.repositorios.nuecesRepositorio.GetLista();
                }

                return lista;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public int Agregar(TipoNuez tipoNuez)
        {
            try
            {
                int registrosAfectados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.nuecesRepositorio.Agregar(tipoNuez);
                    context.SaveChanges();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(TipoNuez tipoNuez)
        {
            try
            {
                bool estaRelacionado = false;
                using (var context = _unitOfWork.Create())
                {
                    estaRelacionado = context.repositorios.nuecesRepositorio.EstaRelacionado(tipoNuez);
                }

                return estaRelacionado;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(TipoNuez tipoNuez)
        {
            try
            {
                bool existe = false;
                using (var context = _unitOfWork.Create())
                {
                    existe = context.repositorios.nuecesRepositorio.Existe(tipoNuez);
                }

                return existe;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Borrar(TipoNuez tipoNuez)
        {
            try
            {
                int registrosAfectados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.nuecesRepositorio.Borrar(tipoNuez);
                    context.SaveChanges();

                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Editar(TipoNuez tipoNuez)
        {
            try
            {
                int registrosAfectados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.nuecesRepositorio.Editar(tipoNuez);
                    context.SaveChanges();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public TipoNuez GetPorId(int id)
        {
            try
            {
                TipoNuez tipo = null;
                using (var context = _unitOfWork.Create())
                {
                    tipo = context.repositorios.nuecesRepositorio.GetPorId(id);
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
