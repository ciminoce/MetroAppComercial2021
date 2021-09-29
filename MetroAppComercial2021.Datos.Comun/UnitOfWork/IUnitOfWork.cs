namespace MetroAppComercial2021.Datos.Comun.UnitOfWork
{
    public interface IUnitOfWork
    {
        IUnitOfWorkAdapter Create();

    }
}
