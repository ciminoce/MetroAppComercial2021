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
    public class PermisosServicios:IPermisosServicios
    {
        private readonly IUnitOfWork _unitOfWork;

        public PermisosServicios(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Permiso> GetLista()
        {
            try
            {
                List<Permiso> lista;
                using (var context = _unitOfWork.Create())
                {
                    lista = context.repositorios.permisosRepositorio.GetLista();
                    foreach (var permiso in lista)
                    {
                        permiso.Menu = context.repositorios.menusRepositorio.GetMenuPorId(permiso.MenuId);
                    }
                }

                return lista;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public Permiso GetPermisoPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
