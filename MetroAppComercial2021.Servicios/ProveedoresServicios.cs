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
    public class ProveedoresServicios:IProveedoresServicios
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProveedoresServicios(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public List<Proveedor> GetLista()
        {
            try
            {
                List<Proveedor> lista;
                using (var context = _unitOfWork.Create())
                {
                    lista = context.repositorios.proveedoresRepositorio.GetLista();
                    foreach (var proveedor in lista)
                    {
                        proveedor.Provincia = context.repositorios.provinciasRepositorio.GetPorId(proveedor.ProvinciaId);
                        proveedor.Localidad = context.repositorios.localidadesRepositorio.GetPorId(proveedor.LocalidadId);
                    }
                }

                return lista;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Existe(Proveedor proveedor)
        {
            try
            {
                bool existe = false;
                using (var context = _unitOfWork.Create())
                {
                    existe = context.repositorios.proveedoresRepositorio.Existe(proveedor);
                }

                return existe;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Agregar(Proveedor proveedor)
        {
            try
            {
                int registrosAfectados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.proveedoresRepositorio.Agregar(proveedor);
                    context.SaveChanges();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Editar(Proveedor proveedor)
        {
            try
            {
                int registrosAfectados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.proveedoresRepositorio.Editar(proveedor);
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
