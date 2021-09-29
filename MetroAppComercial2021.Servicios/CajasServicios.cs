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
    public class CajasServicios:ICajasServicios
    {
        private readonly IUnitOfWork _unitOfWork;

        public CajasServicios(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public List<Caja> GetLista()
        {
            try
            {
                List<Caja> lista;
                using (var context = _unitOfWork.Create())
                {
                    lista = context.repositorios.cajasRepositorio.GetLista();
                }

                return lista;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Existe(Caja caja)
        {
            try
            {
                bool existe = false;
                using (var context = _unitOfWork.Create())
                {
                    existe = context.repositorios.cajasRepositorio.Existe(caja);
                }

                return existe;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Agregar(Caja caja)
        {
            try
            {
                int registrosAfectados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.cajasRepositorio.Agregar(caja);
                    context.SaveChanges();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Editar(Caja caja)
        {
            try
            {
                int registrosAfectados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.cajasRepositorio.Editar(caja);
                    context.SaveChanges();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public bool EstaRelacionado(Caja caja)
        {
            try
            {
                bool estaRelacionado = false;
                using (var context = _unitOfWork.Create())
                {
                    estaRelacionado = context.repositorios.cajasRepositorio.EstaRelacionado(caja);

                }

                return estaRelacionado;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Borrar(Caja caja)
        {
            try
            {
                int registrosAfectados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.cajasRepositorio.Borrar(caja);
                    context.SaveChanges();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int GetCantidad()
        {
            try
            {
                int registrosAfectados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.cajasRepositorio.GetCantidad();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Caja> GetListaPaginada(int registros, int paginaActual)
        {
            try
            {
                List<Caja> lista;
                using (var context = _unitOfWork.Create())
                {
                    lista = context.repositorios.cajasRepositorio.GetListaPaginada(registros, paginaActual);
                }

                return lista;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Caja GetCajaConDetalle(int cajaId)
        {
            try
            {
                Caja caja=null;
                using (var context = _unitOfWork.Create())
                {
                    caja = context.repositorios.cajasRepositorio.GetPorId(cajaId);
                    caja.DetalleCajas = context.repositorios.detalleCajasRepositorio.GetLista(cajaId);
                    foreach (var detalleCaja in caja.DetalleCajas)
                    {
                        detalleCaja.Bombon = context.repositorios.bombonesRepositorio.GetPorId(detalleCaja.BombonId);
                    }
                }

                return caja;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
