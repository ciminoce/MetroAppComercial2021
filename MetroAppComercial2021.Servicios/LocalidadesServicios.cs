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
    public class LocalidadesServicios:ILocalidadesServicios
    {
        private readonly IUnitOfWork _unitOfWork;

        public LocalidadesServicios(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public List<Localidad> GetLista()
        {
            try
            {
                List<Localidad> lista = new List<Localidad>();
                using (var context = _unitOfWork.Create())
                {
                    lista = context.repositorios.localidadesRepositorio.GetLista();
                    lista.ForEach(l=>l.Provincia=context.repositorios.provinciasRepositorio.GetPorId(l.ProvinciaId));
                }

                return lista;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public List<Localidad> GetLista(int provinciaId)
        {
            try
            {
                List<Localidad> localidades;
                using (var context = _unitOfWork.Create())
                {
                    localidades = context.repositorios.localidadesRepositorio.GetLista(provinciaId);
                    var provincia = context.repositorios.provinciasRepositorio.GetPorId(provinciaId);
                    localidades.ForEach(l=>l.Provincia=provincia);
                }

                return localidades;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public int Agregar(Localidad provincia)
        {
            try
            {
                int registrosAfectados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.localidadesRepositorio.Agregar(provincia);
                    context.SaveChanges();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Localidad provincia)
        {
            try
            {
                bool estaRelacionado = false;
                using (var context = _unitOfWork.Create())
                {
                    estaRelacionado = context.repositorios.localidadesRepositorio.EstaRelacionado(provincia);
                }

                return estaRelacionado;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Localidad provincia)
        {
            try
            {
                bool existe = false;
                using (var context = _unitOfWork.Create())
                {
                    existe = context.repositorios.localidadesRepositorio.Existe(provincia);
                }

                return existe;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Borrar(Localidad provincia)
        {
            try
            {
                int registrosAfectados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.localidadesRepositorio.Borrar(provincia);
                    context.SaveChanges();

                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Editar(Localidad provincia)
        {
            try
            {
                int registrosAfectados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.localidadesRepositorio.Editar(provincia);
                    context.SaveChanges();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Localidad GetPorId(int id)
        {
            try
            {
                Localidad localidad = null;
                using (var context = _unitOfWork.Create())
                {
                    localidad = context.repositorios.localidadesRepositorio.GetPorId(id);
                    localidad.Provincia = context.repositorios.provinciasRepositorio.GetPorId(localidad.ProvinciaId);
                }

                return localidad;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
