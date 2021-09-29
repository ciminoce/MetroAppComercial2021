using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroAppComercial2021.Datos.Comun.Repositorios
{
    public interface IRepositorio<Tentity> where Tentity : class
    {
        List<Tentity> GetLista();
        Tentity GetPorId(int id);
        int Agregar(Tentity obj);
        int Borrar(Tentity obj);
        int Editar(Tentity obj);
    }
}
