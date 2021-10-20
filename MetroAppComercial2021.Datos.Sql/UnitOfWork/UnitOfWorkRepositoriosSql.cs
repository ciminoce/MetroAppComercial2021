using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Datos.Comun.Repositorios;
using MetroAppComercial2021.Datos.Comun.UnitOfWork;
using MetroAppComercial2021.Datos.Sql.Repositorios;

namespace MetroAppComercial2021.Datos.Sql.UnitOfWork
{
    public class UnitOfWorkRepositoriosSql:IUnitOfWorkRepositorios
    {

        public UnitOfWorkRepositoriosSql(SqlConnection context, SqlTransaction transaction)
        {
            rellenosRepositorio = new RellenosRepositorio(context, transaction);
            chocolatesRepositorio = new ChocolatesRepositorio(context, transaction);
            nuecesRepositorio = new NuecesRepositorio(context, transaction);
            provinciasRepositorio = new ProvinciasRepositorio(context, transaction);
            localidadesRepositorio = new LocalidadesRepositorio(context, transaction);
            clientesRepositorio = new ClientesRepositorio(context, transaction);
            proveedoresRepositorio = new ProveedoresRepositorio(context, transaction);
            bombonesRepositorio = new BombonesRepositorio(context, transaction);
            cajasRepositorio = new CajasRepositorio(context, transaction);
            detalleCajasRepositorio = new DetalleCajasRepositorio(context, transaction);
            empleadosRepositorio = new EmpleadosRepositorio(context, transaction);
            rolesRepositorio = new RolesRepositorio(context, transaction);
            usuariosRepositorio = new UsuariosRepositorio(context, transaction);
            menusRepositorio = new MenusRepositorio(context, transaction);
            permisosRepositorio = new PermisosRepositorio(context, transaction);
            noPermisosRepositorio = new NoPermisosRepositorio(context, transaction);
            ventasRepositorio = new VentasRepositorio(context, transaction);
        }

        public IRellenosRepositorio rellenosRepositorio { get; }
        public IChocolatesRepositorio chocolatesRepositorio { get; }
        public INuecesRepositorio nuecesRepositorio { get; }
        public IProvinciasRepositorio provinciasRepositorio { get; }
        public ILocalidadesRepositorio localidadesRepositorio { get; }
        public IClientesRepositorio clientesRepositorio { get; }
        public IProveedoresRepositorio proveedoresRepositorio { get; }
        public IBombonesRepositorio bombonesRepositorio { get; }
        public ICajasRepositorio cajasRepositorio { get; }
        public IDetalleCajasRepositorio detalleCajasRepositorio { get; }
        public IEmpleadosRepositorio empleadosRepositorio { get; }
        public IRolesRepositorio rolesRepositorio { get; }
        public IUsuariosRepositorio usuariosRepositorio { get; }
        public IPermisosRepositorio permisosRepositorio { get; }
        public IMenusRepositorio menusRepositorio { get; }
        public INoPermisosRepositorio noPermisosRepositorio { get; }
        public IVentasRepositorio ventasRepositorio { get; }
    }
}
