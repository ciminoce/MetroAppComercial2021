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
    public class ClientesServicios:IClientesServicios
    {
        private readonly IUnitOfWork _unitOfWork;

        public ClientesServicios(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public List<Cliente> GetLista()
        {
            try
            {
                List<Cliente> lista;
                using (var context = _unitOfWork.Create())
                {
                    lista = context.repositorios.clientesRepositorio.GetLista();
                    foreach (var cliente in lista)
                    {
                        cliente.Provincia = context.repositorios.provinciasRepositorio.GetPorId(cliente.ProvinciaId);
                        cliente.Localidad = context.repositorios.localidadesRepositorio.GetPorId(cliente.LocalidadId);
                    }
                }

                return lista;

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Existe(Cliente cliente)
        {
            try
            {
                bool existe = false;
                using (var context = _unitOfWork.Create())
                {
                    existe = context.repositorios.clientesRepositorio.Existe(cliente);
                }

                return existe;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Agregar(Cliente cliente)
        {
            try
            {
                int registrosAfectados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.clientesRepositorio.Agregar(cliente);
                    context.SaveChanges();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Editar(Cliente cliente)
        {
            try
            {
                int registrosAfectados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.clientesRepositorio.Editar(cliente);
                    context.SaveChanges();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public bool EstaRelacionado(Cliente cliente)
        {
            try
            {
                bool estaRelacionado =false;
                using (var context = _unitOfWork.Create())
                {
                    estaRelacionado = context.repositorios.clientesRepositorio.EstaRelacionado(cliente);
                    
                }

                return estaRelacionado;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Borrar(Cliente cliente)
        {
            try
            {
                int registrosAfectados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.clientesRepositorio.Borrar(cliente);
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
