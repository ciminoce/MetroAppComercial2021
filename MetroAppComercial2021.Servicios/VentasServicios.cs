﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Datos.Comun.Repositorios;
using MetroAppComercial2021.Datos.Comun.UnitOfWork;
using MetroAppComercial2021.Entidades.Entidades;
using MetroAppComercial2021.Servicios.Facades;

namespace MetroAppComercial2021.Servicios
{
    public class VentasServicios:IVentasServicios
    {
        private readonly IUnitOfWork _unitOfWork;

        public VentasServicios(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Venta> GetListaPaginada(int registros, int paginaActual)
        {
            try
            {
                List<Venta> lista;
                using (var context = _unitOfWork.Create())
                {
                    lista = context.repositorios.ventasRepositorio.GetListaPaginada(registros, paginaActual);
                    foreach (var venta in lista)
                    {
                        venta.Cliente = context.repositorios.clientesRepositorio.GetPorId(venta.ClienteId);
                    }
                }

                return lista;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Venta> GetLista()
        {
            throw new NotImplementedException();
        }

        public List<Venta> GetLista(int clienteId, int registros, int paginaActual)
        {
            try
            {
                List<Venta> lista;
                using (var context = _unitOfWork.Create())
                {
                    lista = context.repositorios.ventasRepositorio.GetLista(clienteId,registros, paginaActual);
                    foreach (var venta in lista)
                    {
                        venta.Cliente = context.repositorios.clientesRepositorio.GetPorId(venta.ClienteId);
                    }
                }

                return lista;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Venta> GetLista(DateTime fechaVenta, int registros, int paginaActual)
        {
            try
            {
                List<Venta> lista;
                using (var context = _unitOfWork.Create())
                {
                    lista = context.repositorios.ventasRepositorio.GetLista(fechaVenta, registros, paginaActual);
                    foreach (var venta in lista)
                    {
                        venta.Cliente = context.repositorios.clientesRepositorio.GetPorId(venta.ClienteId);
                    }
                }

                return lista;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Venta GetVentaPorId(int ventaId)
        {
            throw new NotImplementedException();
        }

        public void Agregar(Venta venta)
        {
            throw new NotImplementedException();
        }

        public int GetCantidad()
        {
            try
            {
                int registrosAfectados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.ventasRepositorio.GetCantidad();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public int GetCantidad(int clienteId)
        {
            try
            {
                int registrosAfectados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.ventasRepositorio.GetCantidad(clienteId);
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int GetCantidad(DateTime fechaBusqueda)
        {
            try
            {
                int registrosAfectados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosAfectados = context.repositorios.ventasRepositorio.GetCantidad(fechaBusqueda);
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
