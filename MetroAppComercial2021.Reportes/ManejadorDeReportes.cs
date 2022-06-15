using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.CrystalReports.Engine;
using MetroAppComercial2021.Entidades.Entidades;
using MetroAppComercial2021.Reportes.Bombones;
using MetroAppComercial2021.Reportes.GestoresDeDatos;
using MetroAppComercial2021.Reportes.Reportes.Ciudades;
using MetroAppComercial2021.Reportes.Reportes.Provincias;
using MetroAppComercial2021.Reportes.Reportes.Ventas;

namespace MetroAppComercial2021.Reportes
{
    public static class ManejadorDeReportes
    {
        public static crProvincias GetReporteProvincias(List<Provincia> lista)
        {
            AppComercialDataSet ds = GestorDatosProvincias.GetDataSet(lista);
            crProvincias rpt = new crProvincias();
            rpt.SetDataSource(ds);
            return rpt;
        }

        public static crCiudades GetReporteCiudades(List<Localidad> lista)
        {
            AppComercialDataSet ds = GestorDatosCiudades.GetDataSet(lista);
            crCiudades rpt = new crCiudades();
            rpt.SetDataSource(ds);
            return rpt;
        } 
        public static crFactura GetFacturaImpresa(Venta venta)
        {
            AppComercialDataSet ds = GestorDatosVentas.GetDataSet(venta);
            crFactura rpt = new crFactura();
            rpt.SetDataSource(ds);
            return rpt;
        } 
        public static crListaPrecioBombones GetListaPrecioBombones(List<Bombon> lista)
        {
            AppComercialDataSet ds = GestorDatosBombones.GetDatosListaBombones(lista);
            crListaPrecioBombones rpt = new crListaPrecioBombones();
            rpt.SetDataSource(ds);
            return rpt;
        }

        public static ReportClass GetListaPreciosBombonesAgrupadosPorChocolate(List<Bombon> lista)
        {
            AppComercialDataSet ds = GestorDatosBombones.GetDatosListaBombones(lista);
            crListaPreciosBombonesAgrupadoPorChocolate rpt = new crListaPreciosBombonesAgrupadoPorChocolate();
            rpt.SetDataSource(ds);
            return rpt;
        }
    }
}
