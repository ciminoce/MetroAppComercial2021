using System;

namespace MetroAppComercial2021.Datos.Comun.UnitOfWork
{
    public interface IUnitOfWorkAdapter:IDisposable
    {
        IUnitOfWorkRepositorios repositorios { get; set; }
        void SaveChanges();

    }
}
