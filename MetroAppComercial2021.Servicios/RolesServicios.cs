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
    public class RolesServicios:IRolesServicios
    {
        private readonly IUnitOfWork _unitOfWork;

        public RolesServicios(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public List<Rol> GetLista()
        {
            try
            {
                List<Rol> lista;
                using (var context = _unitOfWork.Create())
                {
                    lista = context.repositorios.rolesRepositorio.GetLista();
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
