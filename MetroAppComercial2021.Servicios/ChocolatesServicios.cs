using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Datos.Comun.UnitOfWork;
using MetroAppComercial2021.Entidades.Entidades;
using MetroAppComercial2021.Servicios.Facades;

namespace MetroAppComercial2021.Servicios
{
    public class ChocolatesServicios:IChocolatesServicios
    {
        private readonly IUnitOfWork _unitOfWork;

        public ChocolatesServicios(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public List<TipoChocolate> GetLista()
        {
            try
            {
                List<TipoChocolate> lista = new List<TipoChocolate>();
                using (var context = _unitOfWork.Create())
                {
                    lista = context.repositorios.chocolatesRepositorio.GetLista();
                }

                return lista;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public int Agregar(TipoChocolate tipoChocolate)
        {
            try
            {
                int registrosAfectados = 0;
                using (var context=_unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.chocolatesRepositorio.Agregar(tipoChocolate);
                    context.SaveChanges();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(TipoChocolate tipoChocolate)
        {
            try
            {
                bool estaRelacionado = false;
                using (var context=_unitOfWork.Create())
                {
                    estaRelacionado = context.repositorios.chocolatesRepositorio.EstaRelacionado(tipoChocolate);
                }

                return estaRelacionado;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(TipoChocolate tipoChocolate)
        {
            try
            {
                bool existe = false;
                using (var context=_unitOfWork.Create())
                {
                    existe = context.repositorios.chocolatesRepositorio.Existe(tipoChocolate);
                }

                return existe;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Borrar(TipoChocolate tipoChocolate)
        {
            try
            {
                int registrosAfectados = 0;
                using (var context=_unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.chocolatesRepositorio.Borrar(tipoChocolate);
                    context.SaveChanges();
                    
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Editar(TipoChocolate tipoChocolate)
        {
            try
            {
                int registrosAfectados = 0;
                using (var context=_unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.chocolatesRepositorio.Editar(tipoChocolate);
                    context.SaveChanges();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public TipoChocolate GetPorId(int id)
        {
            try
            {
                TipoChocolate tipo = null;
                using (var context=_unitOfWork.Create())
                {
                    tipo = context.repositorios.chocolatesRepositorio.GetPorId(id);
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
