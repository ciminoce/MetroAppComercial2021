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

    public class NoPermisosServicios:INoPermisosServicios
    {
        private readonly IUnitOfWork _unitOfWork;

        public NoPermisosServicios(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public List<NoPermisoRol> GetLista(int rolId)
        {
            try
            {
                List<NoPermisoRol> lista=new List<NoPermisoRol>();
                using (var context = _unitOfWork.Create())
                {
                    lista = context.repositorios.noPermisosRepositorio.GetLista(rolId);
                    foreach (var noPermiso in lista)
                    {
                        noPermiso.Permiso = context.repositorios.permisosRepositorio.GetPermisoPorId(noPermiso.PermisoId);
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
