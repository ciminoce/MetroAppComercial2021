using MetroAppComercial2021.Datos.Comun.Repositorios;

namespace MetroAppComercial2021.Datos.Comun.UnitOfWork
{
    public interface IUnitOfWorkRepositorios
    {
        IRellenosRepositorio rellenosRepositorio { get; }
        IChocolatesRepositorio chocolatesRepositorio { get; }
        INuecesRepositorio nuecesRepositorio { get; }
        IProvinciasRepositorio provinciasRepositorio { get; }
        ILocalidadesRepositorio localidadesRepositorio { get; }
        IClientesRepositorio clientesRepositorio { get; }
        IProveedoresRepositorio proveedoresRepositorio { get; }
        IBombonesRepositorio bombonesRepositorio { get; }
        ICajasRepositorio cajasRepositorio { get; }
        IDetalleCajasRepositorio detalleCajasRepositorio { get; }
        IEmpleadosRepositorio empleadosRepositorio { get; }
        IRolesRepositorio rolesRepositorio { get; }
        IUsuariosRepositorio usuariosRepositorio { get; }
        IPermisosRepositorio permisosRepositorio { get; }
        IMenusRepositorio menusRepositorio { get; }
        INoPermisosRepositorio noPermisosRepositorio { get; }
        IVentasRepositorio ventasRepositorio { get; }
        IDetalleVentasRepositorio detalleVentasRepositorio { get; }
    }
}
