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

        public static void CargarDatosComboBombones(ref MetroComboBox combo)
        {
            IUnitOfWork _unitOfWork = new UnitOfWorkSql();
            List<Bombon> lista = new BombonesServicios(_unitOfWork).GetLista();
            Bombon defaultBombon = new Bombon()
            {
                Id = 0,
                NombreProducto = "<Seleccione Bombón>"
            };
            lista.Insert(0, defaultBombon);
            combo.DataSource = lista;
            combo.DisplayMember = "NombreProducto";
            combo.ValueMember = "Id";
            combo.SelectedIndex = 0;
        }

        public static void CargarDatosComboEmpleados(ref MetroComboBox combo)
        {
            IUnitOfWork _unitOfWork = new UnitOfWorkSql();
            List<Empleado> lista = new EmpleadosServicios(_unitOfWork).GetLista();
            Empleado defaultEmpleado = new Empleado()
            {
                Id = 0,
                Apellido = "<Seleccione",
                Nombres="Empleado>"
            };
            lista.Insert(0, defaultEmpleado);
            combo.DataSource = lista;
            combo.DisplayMember = "ApeNombre";
            combo.ValueMember = "Id";
            combo.SelectedIndex = 0;

        }

        public static void CargarDatosComboRoles(ref MetroComboBox combo)
        {
            IUnitOfWork _unitOfWork = new UnitOfWorkSql();
            List<Rol> lista = new RolesServicios(_unitOfWork).GetLista();
            Rol defaultRol = new Rol()
            {
                RolId = 0,
                NombreRol = "<Seleccione Rol>"
                
            };
            lista.Insert(0, defaultRol);
            combo.DataSource = lista;
            combo.DisplayMember = "NombreRol";
            combo.ValueMember = "RolId";
            combo.SelectedIndex = 0;
        }

        public static void CargarDatosComboClientes(ref MetroComboBox combo)
        {
            IUnitOfWork _unitOfWork = new UnitOfWorkSql();
            List<Cliente> lista = new ClientesServicios(_unitOfWork).GetLista();
            Cliente defaultCliente = new Cliente()
            {
                Id = 0,
                Apellido = "<Seleccione ",
                Nombres = "Cliente>"

            };
            lista.Insert(0, defaultCliente);
            combo.DataSource = lista;
            combo.DisplayMember = "ApeNombre";
            combo.ValueMember = "Id";
            combo.SelectedIndex = 0;
        }

        public static void CargarDatosComboCajas(ref MetroComboBox combo)
        {
            IUnitOfWork _unitOfWork = new UnitOfWorkSql();
            List<Caja> lista = new CajasServicios(_unitOfWork).GetLista();
            Caja defaultCaja = new Caja()
            {
                Id = 0,
                NombreProducto = "<Seleccione Caja>",
            };
            lista.Insert(0, defaultCaja);
            combo.DataSource = lista;
            combo.DisplayMember = "NombreProducto";
            combo.ValueMember = "Id";
            combo.SelectedIndex = 0;
        }
    }
}
