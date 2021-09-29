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
    public class BombonesServicios:IBombonesServicios
    {
        private readonly IUnitOfWork _unitOfWork;

        public BombonesServicios(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public List<Bombon> GetLista()
        {
            try
            {
                List<Bombon> lista;
                using (var context = _unitOfWork.Create())
                {
                    lista = context.repositorios.bombonesRepositorio.GetLista();
                    foreach (var bombon in lista)
                    {
                        bombon.TipoChocolate = context.repositorios.chocolatesRepositorio.GetPorId(bombon.ChocolateId);
                        bombon.TipoNuez = context.repositorios.nuecesRepositorio.GetPorId(bombon.NuezId);
                        bombon.TipoRelleno = context.repositorios.rellenosRepositorio.GetPorId(bombon.RellenoId);
                    }
                }

                return lista;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Existe(Bombon bombon)
        {
            try
            {
                bool existe = false;
                using (var context = _unitOfWork.Create())
                {
                    existe = context.repositorios.bombonesRepositorio.Existe(bombon);
                }

                return existe;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Agregar(Bombon bombon)
        {
            try
            {
                int registrosAfectados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.bombonesRepositorio.Agregar(bombon);
                    context.SaveChanges();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Editar(Bombon bombon)
        {
            try
            {
                int registrosAfectados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.bombonesRepositorio.Editar(bombon);
                    context.SaveChanges();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public bool EstaRelacionado(Bombon bombon)
        {
            try
            {
                bool estaRelacionado = false;
                using (var context = _unitOfWork.Create())
                {
                    estaRelacionado = context.repositorios.bombonesRepositorio.EstaRelacionado(bombon);

                }

                return estaRelacionado;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Borrar(Bombon bombon)
        {
            try
            {
                int registrosAfectados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.bombonesRepositorio.Borrar(bombon);
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
                    registrosAfectados = context.repositorios.bombonesRepositorio.GetCantidad();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Bombon> GetListaPaginada(int registros, int paginaActual)
        {
            try
            {
                List<Bombon> lista;
                using (var context = _unitOfWork.Create())
                {
                    lista = context.repositorios.bombonesRepositorio.GetListaPaginada(registros,paginaActual);
                    foreach (var bombon in lista)
                    {
                        bombon.TipoChocolate = context.repositorios.chocolatesRepositorio.GetPorId(bombon.ChocolateId);
                        bombon.TipoNuez = context.repositorios.nuecesRepositorio.GetPorId(bombon.NuezId);
                        bombon.TipoRelleno = context.repositorios.rellenosRepositorio.GetPorId(bombon.RellenoId);
                    }
                }

                return lista;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
