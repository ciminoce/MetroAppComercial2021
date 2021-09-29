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
    public class RellenosServicios:IRellenosServicios
    {
        private readonly IUnitOfWork _unitOfWork;

        public RellenosServicios(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public List<TipoRelleno> GetLista()
        {
            try
            {
                List<TipoRelleno> rellenos = new List<TipoRelleno>();
                using (var context = _unitOfWork.Create())
                {
                    rellenos = context.repositorios.rellenosRepositorio.GetLista();

                }

                return rellenos;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Agregar(TipoRelleno tipoRelleno)
        {
            try
            {
                int registrosAgregados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosAgregados = context.repositorios.rellenosRepositorio.Agregar(tipoRelleno);
                    context.SaveChanges();
                }

                return registrosAgregados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(TipoRelleno tipoRelleno)
        {
            try
            {
                using (var context = _unitOfWork.Create())
                {
                    return context.repositorios.rellenosRepositorio.EstaRelacionado(tipoRelleno);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(TipoRelleno tipoRelleno)
        {
            try
            {
                using (var context = _unitOfWork.Create())
                {
                    return context.repositorios.rellenosRepositorio.Existe(tipoRelleno);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Borrar(TipoRelleno tipoRelleno)
        {
            try
            {
                int registrosBorrados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosBorrados = context.repositorios.rellenosRepositorio.Borrar(tipoRelleno);
                    context.SaveChanges();
                }

                return registrosBorrados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Editar(TipoRelleno tipoRelleno)
        {
            try
            {
                int registrosEditados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosEditados = context.repositorios.rellenosRepositorio.Editar(tipoRelleno);
                    context.SaveChanges();
                }

                return registrosEditados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public TipoRelleno GetPorId(int id)
        {
            try
            {
                using (var context = _unitOfWork.Create())
                {
                    return context.repositorios.rellenosRepositorio.GetPorId(id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
