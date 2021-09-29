using System.Collections.Generic;
using MetroAppComercial2021.Datos.Comun.UnitOfWork;
using MetroAppComercial2021.Datos.Sql.UnitOfWork;
using MetroAppComercial2021.Entidades.Entidades;
using MetroAppComercial2021.Servicios;
using MetroFramework.Controls;

namespace MetroAppComercial2021.Windows.Helpers
{
    public static class HelperCombo
    {
        public static void CargarDatosComboProvincias(ref MetroComboBox combo)
        {
            IUnitOfWork _unitOfWork = new UnitOfWorkSql();
            List<Provincia> lista = new ProvinciasServicios(_unitOfWork).GetLista();
            Provincia defaultProvincia = new Provincia()
            {
                ProvinciaId = 0,
                NombreProvincia = "<Seleccione Provincia>"
            };
            lista.Insert(0, defaultProvincia);
            combo.DataSource = lista;
            combo.DisplayMember = "NombreProvincia";
            combo.ValueMember = "ProvinciaId";
            combo.SelectedIndex = 0;
        }

        public static void CargarDatosComboLocalidades(ref MetroComboBox combo, int provinciaId)
        {
            IUnitOfWork _unitOfWork = new UnitOfWorkSql();
            List<Localidad> lista = new LocalidadesServicios(_unitOfWork).GetLista(provinciaId);
            Localidad defaultLocalidad = new Localidad()
            {
                LocalidadId = 0,
                NombreLocalidad = "<Seleccione Localidad>"
            };
            lista.Insert(0, defaultLocalidad);
            combo.DataSource = lista;
            combo.DisplayMember = "NombreLocalidad";
            combo.ValueMember = "LocalidadId";
            combo.SelectedIndex = 0;

        }

        public static void CargarDatosComboChocolates(ref MetroComboBox combo)
        {
            IUnitOfWork _unitOfWork = new UnitOfWorkSql();
            List<TipoChocolate> lista = new ChocolatesServicios(_unitOfWork).GetLista();
            TipoChocolate defaultChocolate = new TipoChocolate()
            {
                TipoChocolateId = 0,
                Descripcion = "<Seleccione Chocolate>"
            };
            lista.Insert(0, defaultChocolate);
            combo.DataSource = lista;
            combo.DisplayMember = "Descripcion";
            combo.ValueMember = "TipoChocolateId";
            combo.SelectedIndex = 0;
        }

        public static void CargarDatosComboNueces(ref MetroComboBox combo)
        {
            IUnitOfWork _unitOfWork = new UnitOfWorkSql();
            List<TipoNuez> lista = new NuecesServicios(_unitOfWork).GetLista();
            TipoNuez defaultNuez = new TipoNuez()
            {
                TipoNuezId = 0,
                Descripcion = "<Seleccione Nuez>"
            };
            lista.Insert(0, defaultNuez);
            combo.DataSource = lista;
            combo.DisplayMember = "Descripcion";
            combo.ValueMember = "TipoNuezId";
            combo.SelectedIndex = 0;
        }

        public static void CargarDatosComboRellenos(ref MetroComboBox combo)
        {
            IUnitOfWork _unitOfWork = new UnitOfWorkSql();
            List<TipoRelleno> lista = new RellenosServicios(_unitOfWork).GetLista();
            TipoRelleno defaultRelleno = new TipoRelleno()
            {
                TipoRellenoId = 0,
                Descripcion = "<Seleccione Relleno>"
            };
            lista.Insert(0, defaultRelleno);
            combo.DataSource = lista;
            combo.DisplayMember = "Descripcion";
            combo.ValueMember = "TipoRellenoId";
            combo.SelectedIndex = 0;
        }
    }
}
