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
    public class UsuariosServicios:IUsuariosServicios
    {
        private readonly IUnitOfWork _unitOfWork;

        public UsuariosServicios(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Usuario GetUsuario(int empleadoId, string password)
        {
            try
            {
                Usuario usuario = null;
                using (var context = _unitOfWork.Create())
                {
                    usuario = context.repositorios.usuariosRepositorio.GetUsuario(empleadoId,password);
                    if (usuario!=null)
                    {
                        usuario.Empleado = context.repositorios.empleadosRepositorio.GetPorId(usuario.EmpleadoId);
                        usuario.Rol = context.repositorios.rolesRepositorio.GetPorId(usuario.RolId);
                        usuario.Rol.NoPermisosRoles =
                            context.repositorios.noPermisosRepositorio.GetLista(usuario.RolId);
                        foreach (var noPermiso in usuario.Rol.NoPermisosRoles)
                        {
                            noPermiso.Permiso =
                                context.repositorios.permisosRepositorio.GetPermisoPorId(noPermiso.PermisoId);
                        }
                    }

                }

                return usuario;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Usuario> GetLista()
        {
            try
            {
                List<Usuario> lista;
                using (var context = _unitOfWork.Create())
                {
                    lista = context.repositorios.usuariosRepositorio.GetLista();
                    foreach (var usuario in lista)
                    {
                        usuario.Empleado = context.repositorios.empleadosRepositorio.GetPorId(usuario.EmpleadoId);
                        usuario.Rol = context.repositorios.rolesRepositorio.GetPorId(usuario.RolId);
                    }
                }

                return lista;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Existe(Usuario usuario)
        {
            try
            {
                bool existe = false;
                using (var context = _unitOfWork.Create())
                {
                    existe = context.repositorios.usuariosRepositorio.Existe(usuario);
                }

                return existe;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Agregar(Usuario usuario)
        {
            try
            {
                int registrosAfectados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.usuariosRepositorio.Agregar(usuario);
                    context.SaveChanges();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Editar(Usuario usuario)
        {
            try
            {
                int registrosAfectados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.usuariosRepositorio.Editar(usuario);
                    context.SaveChanges();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public int Borrar(Usuario usuario)
        {
            try
            {
                int registrosAfectados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.usuariosRepositorio.Borrar(usuario);
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
