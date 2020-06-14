using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Daiko_DESKTOP
{
    public partial class Form1 : Form
    {
        int maximoPaginas;
        int totalRegistros;
        int registrosPorPagina = 25;
        int paginaActual = 1;
        int offset;
        string parametrosSelect;

        string mod1,mod2,mod3;
        string tab1,tab2,tab3;
        string cr1,cr2,cr3;


        public Form1()
        {
            InitializeComponent();
            OcultarSubmenus();
            OcultarPanel();
            CargarInfoEmpresa();
            panelDashboard.Visible = true;
            label2.Text = "DASHBOARD";

            datagrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Regular);
            datagrid.DefaultCellStyle.Font = new Font("Arial", 13, FontStyle.Regular);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnAdjust_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnMaximize.Visible = true;
            btnAdjust.Visible = false;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnMaximize.Visible = false;
            btnAdjust.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSidebarMenu_Click(object sender, EventArgs e)
        {
            //encoje y agranda el menu lateral al hacer click
            if (sidebar_wrapper.Width == 309)
            {
                sidebar_wrapper.Width = 120;
                sidebar.Width = 74;
                separatorSidebar.Width = 58;
                OcultarSubmenus();

            }
            else
            {
                sidebar_wrapper.Width = 309;
                sidebar.Width = 268;
                separatorSidebar.Width = 252;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OcultarPanel();
            labelPanel.Text = "DASHBOARD";
            label2.Text = "DASHBOARD";

            panelDashboard.Visible = true;
            panelDashboard.BringToFront();
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            //mostrar submenu almacen
            if (sidebar_wrapper.Width != 120)
            {
                if (submenuAlmacen.Visible)
                {
                    submenuAlmacen.Visible = false;
                    menuAlmacen.Height = 48;
                }

                else
                {
                    submenuAlmacen.Visible = true;
                    menuAlmacen.Height = 230;
                }
            }
        }

        private void btnAlmacenAlmacenes_Click(object sender, EventArgs e)
        {
            //se modifica el formulario y se carga la tabla con los valores de la tabla almacenes
            OcultarPanel();
            labelPanel.Text = "ALMACEN";
            labelSubMenu.Text = "ALMACENES";

            panelTablas.Visible = true;
            panelTablas.BringToFront();

            PersonalizarTabla(255, 255, 128, 255, 255, 200);

            parametrosSelect = "id_almacen as Id, nombre as Almacen, responsable as Responsable, telefono as Telefono,direccion as Direccion";
            mod1 = "Almacen";
            tab1 = "almacenes";

            CargarDatosTabla(mod1, tab1, parametrosSelect, offset, registrosPorPagina, "ASC", 1);
        }

        private void btnAlmacenCatalogo_Click(object sender, EventArgs e)
        {
            //se modifica el formulario y se carga la tabla con los valores de la tabla catalogo
            OcultarPanel();
            labelPanel.Text = "ALMACEN";
            labelSubMenu.Text = "CATALOGO";

            panelTablas.Visible = true;
            panelTablas.BringToFront();

            PersonalizarTabla(255, 255, 128, 255, 255, 200);
            mod1 = "almacen";
            tab1 = "catalogo";
            cr1 = "id_catalogo";
            mod2 = "almacen";
            tab2 = "familias";
            cr2 = "id_familia";
            mod3 = "almacen";
            tab3 = "marcas";
            cr3 = "id_marca";

            parametrosSelect = "id_producto as Id,Catalogo.nombre as Producto,Familias.codigo_familia as Familia,Marcas.nombre as Marca,stock as Stock";

            CargarDatosTabla(mod1, tab1, cr1, mod2, tab2, cr2, mod3, tab3, cr3, parametrosSelect, offset, registrosPorPagina, "ASC", 1);
        }

        private void btnAlmacenFamilias_Click(object sender, EventArgs e)
        {
            //se modifica el formulario y se carga la tabla con los valores de la tabla familias
            OcultarPanel();
            labelPanel.Text = "ALMACEN";
            labelSubMenu.Text = "FAMILIAS";
            panelTablas.Visible = true;
            panelTablas.BringToFront();

            PersonalizarTabla(255, 255, 128, 255, 255, 200);

            parametrosSelect = "id_familia as Id, codigo_familia as Familia,nombre_estado as Estado";
            mod1 = "almacen";
            tab1 = "familias";
            cr1 = "id_estado";
            mod2 = "general";
            tab2 = "estados";
            cr2 = "id_estado";

            CargarDatosTabla(mod1, tab1, cr1, mod2, tab2, cr2, parametrosSelect, offset, registrosPorPagina, "ASC", 1);
        }

        private void btnAlmacenMarcas_Click(object sender, EventArgs e)
        {
            //se modifica el formulario y se carga la tabla con los valores de la tabla marcas
            OcultarPanel();
            labelPanel.Text = "ALMACEN";
            labelSubMenu.Text = "MARCAS";
            panelTablas.Visible = true;
            panelTablas.BringToFront();

            PersonalizarTabla(255, 255, 128, 255, 255, 200);

            parametrosSelect = "id_marca as Id, nombre as Marca";
            mod1 = "almacen";
            tab1 = "marcas";

            CargarDatosTabla(mod1, tab1, parametrosSelect, offset, registrosPorPagina, "ASC", 1);
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            if (sidebar_wrapper.Width != 120)
            {
                if (submenuCompras.Visible)
                {
                    submenuCompras.Visible = false;
                    menuCompras.Height = 48;
                }

                else
                {
                    submenuCompras.Visible = true;
                    menuCompras.Height = 170;
                }

            }
        }

        private void btnComprasGastos_Click(object sender, EventArgs e)
        {
            OcultarPanel();
            labelPanel.Text = "COMPRAS";
            labelSubMenu.Text = "GASTOS";
            panelTablas.Visible = true;
            panelTablas.BringToFront();

            PersonalizarTabla(128, 255, 255, 200, 255, 255);
        }

        private void btnComprasPedidos_Click(object sender, EventArgs e)
        {
            OcultarPanel();
            labelPanel.Text = "COMPRAS";
            labelSubMenu.Text = "PEDIDOS";
            panelTablas.Visible = true;
            panelTablas.BringToFront();
        }

        private void btnComprasProveedores_Click(object sender, EventArgs e)
        {
            OcultarPanel();
            labelPanel.Text = "COMPRAS";
            labelSubMenu.Text = "PROVEEDORES";
            panelTablas.Visible = true;
            panelTablas.BringToFront();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            if (sidebar_wrapper.Width != 120)
            {
                if (submenuVentas.Visible)
                {
                    submenuVentas.Visible = false;
                    menuVentas.Height = 48;
                }

                else
                {
                    submenuVentas.Visible = true;
                    menuVentas.Height = 200;
                }
            }
        }

        private void btnVentasClientes_Click(object sender, EventArgs e)
        {
            OcultarPanel();
            labelPanel.Text = "VENTAS";
            labelSubMenu.Text = "CLIENTES";
            panelTablas.Visible = true;
            panelTablas.BringToFront();
        }

        private void btnVentasFacturas_Click(object sender, EventArgs e)
        {
            OcultarPanel();
            labelPanel.Text = "VENTAS";
            labelSubMenu.Text = "FACTURAS";
            panelTablas.Visible = true;
            panelTablas.BringToFront();
        }

        private void btnVentasPedidos_Click(object sender, EventArgs e)
        {
            OcultarPanel();
            labelPanel.Text = "VENTAS";
            labelSubMenu.Text = "PEDIDOS";
            panelTablas.Visible = true;
            panelTablas.BringToFront();
        }

        private void btnVentasPresupuestos_Click(object sender, EventArgs e)
        {
            OcultarPanel();
            labelPanel.Text = "VENTAS";
            labelSubMenu.Text = "PRESUPUESTOS";
            panelTablas.Visible = true;
            panelTablas.BringToFront();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            //muestra el panel de configuracion por delante del resto
            OcultarPanel();
            labelPanel.Text = "CONFIGURACION";
            panelConfiguracion.Dock = DockStyle.Fill;
            panelConfiguracion.Visible = true;
        }

        private void btnConfiguracionEmpresa_Click(object sender, EventArgs e)
        {
            FormEmpresa formConfiguracionEmpresa = new FormEmpresa();
            formConfiguracionEmpresa.ShowDialog();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //trae los siguientes registros de la tabla
            paginaActual++;
            offset += registrosPorPagina;

            CargarDatosTabla(labelPanel.Text, labelSubMenu.Text, parametrosSelect, offset, registrosPorPagina, "ASC", 1);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            //trae los anteriores registros de la tabla
            paginaActual--;
            offset -= registrosPorPagina;

            CargarDatosTabla(labelPanel.Text, labelSubMenu.Text, parametrosSelect, offset, registrosPorPagina, "ASC", 1);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //se oscurece los elementos que quedan en el back y se comprueba el texto del submenu seleccionado.
            //se abre el formulario pertinente en modo crear y sin pasarle ningun objeto
            //al cerrar dicho formulario se cargara nuevamente la tabla con los valores actualizados
            OscurecerPaneles();

            switch (labelSubMenu.Text.ToLower())
            {
                case "almacenes":

                    FormAlmacenes formAlmacen = new FormAlmacenes("crear", null);
                    formAlmacen.ShowDialog();

                    parametrosSelect = "id_almacen as Id, nombre as Almacen, responsable as Responsable, telefono as Telefono,direccion as Direccion";

                    CargarDatosTabla("Almacen", "Almacenes", parametrosSelect, offset, registrosPorPagina, "ASC", 1);

                    break;
                case "catalogo":
                    FormProductos formProductos = new FormProductos("crear", null);
                    formProductos.ShowDialog();

                    parametrosSelect = "id_producto as Id,Catalogo.nombre as Producto,Familias.codigo_familia as Familia,Marcas.nombre as Marca,stock as Stock";

                    CargarDatosTabla("Almacen", "catalogo", "id_catalogo", "Almacen", "familias", "id_familia", "Almacen", "marcas", "id_marca", parametrosSelect, offset, registrosPorPagina, "ASC", 1);
                    break;
                case "familias":

                    FormFamilias formFamilias = new FormFamilias("crear", null);
                    formFamilias.ShowDialog();

                    parametrosSelect = "id_familia as Id, codigo_familia as Familia,nombre_estado as Estado";

                    CargarDatosTabla("Almacen", "familias", "id_estado", "General", "estados", "id_estado", parametrosSelect, offset, registrosPorPagina, "ASC", 1);
                    break;
                case "marcas":

                    FormMarcas formMarcas = new FormMarcas("crear", null);
                    formMarcas.ShowDialog();


                    parametrosSelect = "id_marca as Id, nombre as Marca";

                    CargarDatosTabla("Almacen", "Marcas", parametrosSelect, offset, registrosPorPagina, "ASC", 1);
                    break;
            }

            AclararPaneles();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //se comprueba que haya seleccionada al menos una fila de la tabla y se obtiene el id de dicha fila.
            //se abre el formulario pertinente en modo editar y pasandole un objeto con los datos del elemento seleccionado gracias al id
            //al cerrar dicho formulario se cargara nuevamente la tabla con los valores actualizados
            if (datagrid.SelectedRows.Count > 0)
            {
                int id;
                Daiko_BLL.Daiko_BLL oDaikoBLL = new Daiko_BLL.Daiko_BLL();

                OscurecerPaneles();

                switch (labelSubMenu.Text.ToLower())
                {
                    case "almacenes":
                        id = (int)datagrid.SelectedRows[0].Cells[0].Value;

                        FormAlmacenes formAlmacen = new FormAlmacenes("editar", oDaikoBLL.ObtenerDatos(labelPanel.Text, labelSubMenu.Text, "*", "id_almacen", id));
                        formAlmacen.ShowDialog(this);

                        //PersonalizarTabla(255, 255, 128, 255, 255, 200);

                        parametrosSelect = "id_almacen as Id, nombre as Almacen, responsable as Responsable, telefono as Telefono,direccion as Direccion";

                        CargarDatosTabla("Almacen", "Almacenes", parametrosSelect, offset, registrosPorPagina, "ASC", 1);

                        break;

                    case "familias":
                        id = (int)datagrid.SelectedRows[0].Cells[0].Value;

                        FormFamilias formFamilia = new FormFamilias("editar", oDaikoBLL.ObtenerDatos(labelPanel.Text, labelSubMenu.Text, "*", "id_familia", id));
                        formFamilia.ShowDialog();

                        parametrosSelect = "id_familia as Id, codigo_familia as Familia,nombre_estado as Estado";

                        CargarDatosTabla("Almacen", "familias", "id_estado", "General", "estados", "id_estado", parametrosSelect, offset, registrosPorPagina, "ASC", 1);
                        break;

                    case "marcas":
                        id = (int)datagrid.SelectedRows[0].Cells[0].Value;

                        FormMarcas formMarcas = new FormMarcas("editar", oDaikoBLL.ObtenerDatos(labelPanel.Text, labelSubMenu.Text, "*", "id_marca", id));
                        formMarcas.ShowDialog();

                        parametrosSelect = "id_marca as Id, nombre as Marca";

                        CargarDatosTabla("Almacen", "marcas", parametrosSelect, offset, registrosPorPagina, "ASC", 1);
                        break;

                    case "catalogo":
                        id = (int)datagrid.SelectedRows[0].Cells[0].Value;
                        Daiko_UC.Models.Producto p = (Daiko_UC.Models.Producto)oDaikoBLL.ObtenerDatos(labelPanel.Text, labelSubMenu.Text, "*", "id_producto", id);
                        FormProductos formProductos = new FormProductos("editar", p);
                        formProductos.ShowDialog();

                        parametrosSelect = "id_producto as Id,Catalogo.nombre as Producto,Familias.codigo_familia as Familia,Marcas.nombre as Marca,stock as Stock";

                        CargarDatosTabla("Almacen", "catalogo", "id_catalogo", "Almacen", "familias", "id_familia", "Almacen", "marcas", "id_marca", parametrosSelect, offset, registrosPorPagina, "ASC", 1);

                        break;

                    default:
                        break;
                }
                AclararPaneles();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //se comprueba que haya seleccionada al menos una fila de la tabla y se obtiene el id de dicha fila.
            //se abre el formulario pertinente en modo eliminar y pasandole un objeto con los datos del elemento seleccionado gracias al id
            //al cerrar dicho formulario se cargara nuevamente la tabla con los valores actualizados
            if (datagrid.SelectedRows.Count > 0)
            {
                int id;
                Daiko_BLL.Daiko_BLL oDaikoBLL = new Daiko_BLL.Daiko_BLL();

                OscurecerPaneles();

                switch (labelSubMenu.Text.ToLower())
                {
                    case "almacenes":
                        id = (int)datagrid.SelectedRows[0].Cells[0].Value;

                        FormAlmacenes formNuevoAlmacen = new FormAlmacenes("eliminar", oDaikoBLL.ObtenerDatos(labelPanel.Text, labelSubMenu.Text, "*", "id_almacen", id));
                        formNuevoAlmacen.ShowDialog();

                        parametrosSelect = "id_almacen as Id, nombre as Almacen, responsable as Responsable, telefono as Telefono,direccion as Direccion";

                        CargarDatosTabla("Almacen", "Almacenes", parametrosSelect, offset, registrosPorPagina, "ASC", 1);
                        break;

                    case "familias":
                        id = (int)datagrid.SelectedRows[0].Cells[0].Value;

                        FormFamilias formFamilia = new FormFamilias("eliminar", oDaikoBLL.ObtenerDatos(labelPanel.Text, labelSubMenu.Text, "*", "id_familia", id));
                        formFamilia.ShowDialog();

                        parametrosSelect = "id_familia as Id, codigo_familia as Familia,nombre_estado as Estado";

                        CargarDatosTabla("Almacen", "familias", "id_estado", "General", "estados", "id_estado", parametrosSelect, offset, registrosPorPagina, "ASC", 1);
                        break;

                    case "marcas":
                        id = (int)datagrid.SelectedRows[0].Cells[0].Value;

                        FormMarcas formMarcas = new FormMarcas("eliminar", oDaikoBLL.ObtenerDatos(labelPanel.Text, labelSubMenu.Text, "*", "id_marca", id));
                        formMarcas.ShowDialog();

                        parametrosSelect = "id_marca as Id, nombre as Marca";

                        CargarDatosTabla("Almacen", "marcas", parametrosSelect, offset, registrosPorPagina, "ASC", 1);
                        break;

                    case "catalogo":

                        id = (int)datagrid.SelectedRows[0].Cells[0].Value;
                        Daiko_UC.Models.Producto p = (Daiko_UC.Models.Producto)oDaikoBLL.ObtenerDatos(labelPanel.Text, labelSubMenu.Text, "*", "id_producto", id);
                        FormProductos formProductos = new FormProductos("eliminar", p);
                        formProductos.ShowDialog();

                        parametrosSelect = "id_producto as Id,Catalogo.nombre as Producto,Familias.codigo_familia as Familia,Marcas.nombre as Marca,stock as Stock";

                        CargarDatosTabla("Almacen", "catalogo", "id_catalogo", "Almacen", "familias", "id_familia", "Almacen", "marcas", "id_marca", parametrosSelect, offset, registrosPorPagina, "ASC", 1);

                        break;

                    default:
                        break;
                }
                AclararPaneles();
            }
        }

        private void top_wrapper_DoubleClick(object sender, EventArgs e)
        {
            //hace grande o tamaño normal al hacer doble click en el marco de la ventana
            if (top_wrapper.Width == 1400)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }


        private void OcultarSubmenus()
        {
            menuDashboard.Height = 48;
            menuAlmacen.Height = 48;
            menuCompras.Height = 48;
            menuVentas.Height = 48;
            menuConfiguracion.Height = 48;
        }

        private void OcultarPanel()
        {
            panelConfiguracion.Visible = false;
            panelDashboard.Visible = false;
            panelTablas.Visible = false;
        }

        private void OscurecerPaneles()
        {
            panelPrincipal.BackColor = Color.Gainsboro;
            panelConfiguracion.BackColor = Color.Gainsboro;
            panelDashboard.BackColor = Color.Gainsboro;
            panelTablas.BackColor = Color.Gainsboro;

            datagrid.BackgroundColor = Color.Gainsboro;
        }

        private void AclararPaneles()
        {
            panelPrincipal.BackColor = Color.AliceBlue;
            panelConfiguracion.BackColor = Color.AliceBlue;
            panelDashboard.BackColor = Color.AliceBlue;
            panelTablas.BackColor = Color.AliceBlue;

            datagrid.BackgroundColor = Color.AliceBlue;
        }

        private void CargarInfoEmpresa()
        {
            //COMPROBAR SI HAY EMPRESA
            //SI HAY CARGAR LOGO Y NOMBRE
            //SI NO DEJAR EN BLANCO
            Daiko_BLL.Daiko_BLL oDaikoBLL = new Daiko_BLL.Daiko_BLL();

            if (oDaikoBLL.ExisteEmpresa())
            {
                Daiko_UC.Models.Empresa empresa = oDaikoBLL.ObtenerDatosEmpresa();
                labelNombreEmpresa.Text = empresa.Nombre_comercial;

                if (empresa.Logo.Length > 1)
                {
                    imgLogo.Image = ByteArrayToImagen(empresa.Logo);
                }
            }
        }

        private Image ByteArrayToImagen(byte[] logoBytes)
        {
            MemoryStream ms = new MemoryStream(logoBytes);
            Bitmap logo = new Bitmap(ms);
            return logo;
        }

        private void tempLines_Tick(object sender, EventArgs e)
        {
            tempLines.Stop();
            this.lines.Series["chartLines"].Points.AddXY("Lunes", 10);
            this.lines.Series["chartLines"].Points.AddXY("Martes", 20);
            this.lines.Series["chartLines"].Points.AddXY("Miercoles", 30);
            this.lines.Series["chartLines"].Points.AddXY("Jueves", 40);
            this.lines.Series["chartLines"].Points.AddXY("Viernes", 50);
            this.lines.Series["chartLines"].Points.AddXY("Sabado", 20);
            this.lines.Series["chartLines"].Points.AddXY("Domingo", 10);
        }

        private void tempDonut_Tick(object sender, EventArgs e)
        {
            tempDonut.Stop();
            this.donut.Series["chartDonut"].Points.AddXY("1", 20);
            this.donut.Series["chartDonut"].Points.AddXY("2", 10);
            this.donut.Series["chartDonut"].Points.AddXY("3", 30);
            this.donut.Series["chartDonut"].Points.AddXY("4", 25);
            this.donut.Series["chartDonut"].Points.AddXY("5", 25);
        }

        private void tempColumns_Tick(object sender, EventArgs e)
        {
            tempColumns.Stop();
            this.columns.Series["chartColumns"].Points.AddXY("Lunes", 10);
            this.columns.Series["chartColumns"].Points.AddXY("Martes", 20);
            this.columns.Series["chartColumns"].Points.AddXY("Miercoles", 30);
            this.columns.Series["chartColumns"].Points.AddXY("Jueves", 40);
            this.columns.Series["chartColumns"].Points.AddXY("Viernes", 50);
            this.columns.Series["chartColumns"].Points.AddXY("Sabado", 20);
            this.columns.Series["chartColumns"].Points.AddXY("Domingo", 10);
        }


        /*TABLA*/
        private void CargarDatosTabla(string modulo, string tabla, string parametrosSelect)
        {
            //se obtienen todos los campos de la tabla especificada 
            Daiko_BLL.Daiko_BLL oDaikoBLL = new Daiko_BLL.Daiko_BLL();

            datagrid.DataSource = oDaikoBLL.ConsultaTotal(modulo, tabla, parametrosSelect);

            datagrid.Columns[0].Width = 50;

            totalRegistros = oDaikoBLL.NumRegistros(modulo, tabla);

            int ultimoRegistroPagina = totalRegistros;

            btnSiguiente.Enabled = ultimoRegistroPagina == totalRegistros ? false : true;
            btnAnterior.Enabled = offset > 1 ? true : false;

            labelInfoTabla.Text = string.Format("Mostrando registros del {0} al {1} de un total de {2} registros", offset + 1, ultimoRegistroPagina, totalRegistros);
            txtPagina.Text = paginaActual.ToString();
        }

        private void CargarDatosTabla(string modulo1, string tabla1, string campoRelacionado1, string modulo2, string tabla2, string campoRelacionado2, string parametrosSelect)
        {
            Daiko_BLL.Daiko_BLL oDaikoBLL = new Daiko_BLL.Daiko_BLL();

            datagrid.DataSource = oDaikoBLL.ConsultaTotalJoin(modulo1, tabla1, campoRelacionado1, modulo2, tabla2, campoRelacionado2, parametrosSelect);

            datagrid.Columns[0].Width = 50;

            totalRegistros = oDaikoBLL.NumRegistros(modulo1, tabla1);

            int ultimoRegistroPagina = totalRegistros;

            btnSiguiente.Enabled = ultimoRegistroPagina == totalRegistros ? false : true;
            btnAnterior.Enabled = offset > 1 ? true : false;

            labelInfoTabla.Text = string.Format("Mostrando registros del {0} al {1} de un total de {2} registros", offset + 1, ultimoRegistroPagina, totalRegistros);
            txtPagina.Text = paginaActual.ToString();
        }

        private void CargarDatosTabla(string modulo1, string tabla1, string campoRelacionado1, string modulo2, string tabla2, string campoRelacionado2,
            string modulo3, string tabla3, string campoRelacionado3, string parametrosSelect)
        {
            Daiko_BLL.Daiko_BLL oDaikoBLL = new Daiko_BLL.Daiko_BLL();

            datagrid.DataSource = oDaikoBLL.ConsultaTotal(modulo1, tabla1, campoRelacionado1, modulo2, tabla2, campoRelacionado2, modulo3, tabla3, campoRelacionado3,parametrosSelect);

            datagrid.Columns[0].Width = 50;

            totalRegistros = oDaikoBLL.NumRegistros(modulo1, tabla1);

            int ultimoRegistroPagina = totalRegistros;

            btnSiguiente.Enabled = ultimoRegistroPagina == totalRegistros ? false : true;
            btnAnterior.Enabled = offset > 1 ? true : false;

            labelInfoTabla.Text = string.Format("Mostrando registros del {0} al {1} de un total de {2} registros", offset + 1, ultimoRegistroPagina, totalRegistros);
            txtPagina.Text = paginaActual.ToString();
        }

        private void CargarDatosTabla(string modulo, string tabla, string parametrosSelect, int offset, int registrosPorPagina, string criterioOrdenacion, int posicionColumnaPK)
        {
            //se obtiene el resultado paginado de una consulta
            Daiko_BLL.Daiko_BLL oDaikoBLL = new Daiko_BLL.Daiko_BLL();

            datagrid.DataSource = oDaikoBLL.ConsultaPaginada(modulo, tabla, parametrosSelect, offset, registrosPorPagina, criterioOrdenacion, posicionColumnaPK);

            datagrid.Columns[0].Width = 50;

            totalRegistros = oDaikoBLL.NumRegistros(modulo, tabla);

            int ultimoRegistroPagina = offset + registrosPorPagina > totalRegistros ? totalRegistros : offset + registrosPorPagina;

            btnSiguiente.Enabled = ultimoRegistroPagina == totalRegistros ? false : true;
            btnAnterior.Enabled = offset > 1 ? true : false;

            labelInfoTabla.Text = string.Format("Mostrando registros del {0} al {1} de un total de {2} registros", offset + 1, ultimoRegistroPagina, totalRegistros);
            txtPagina.Text = paginaActual.ToString();
        }

        private void CargarDatosTabla(string modulo1, string tabla1, string campoRelacionado1, string modulo2, string tabla2, string campoRelacionado2, string parametrosSelect, int offset, int registrosPorPagina, string criterioOrdenacion, int posicionColumnaPK)
        {
            //se obtiene el resultado paginado de una consulta con una join entre dos tablas
            Daiko_BLL.Daiko_BLL oDaikoBLL = new Daiko_BLL.Daiko_BLL();

            datagrid.DataSource = oDaikoBLL.ConsultaPaginadaJoin(modulo1, tabla1, campoRelacionado1, modulo2, tabla2, campoRelacionado2, parametrosSelect, offset, registrosPorPagina, criterioOrdenacion, posicionColumnaPK);

            datagrid.Columns[0].Width = 50;

            totalRegistros = oDaikoBLL.NumRegistros(modulo1, tabla1);

            int ultimoRegistroPagina = totalRegistros;

            btnSiguiente.Enabled = ultimoRegistroPagina == totalRegistros ? false : true;
            btnAnterior.Enabled = offset > 1 ? true : false;

            labelInfoTabla.Text = string.Format("Mostrando registros del {0} al {1} de un total de {2} registros", offset + 1, ultimoRegistroPagina, totalRegistros);
            txtPagina.Text = paginaActual.ToString();
        }

        private void CargarDatosTabla(string modulo1, string tabla1, string campoRelacionado1, string modulo2, string tabla2, string campoRelacionado2,
            string modulo3, string tabla3, string campoRelacionado3, string parametrosSelect,
            int offset, int registrosPorPagina, string criterioOrdenacion, int posicionColumnaPK)
        {
            //se obtienen todos los campos de la tablas especificada s
            Daiko_BLL.Daiko_BLL oDaikoBLL = new Daiko_BLL.Daiko_BLL();

            datagrid.DataSource = oDaikoBLL.ConsultaTotalJoin(modulo1, tabla1, campoRelacionado1, modulo2, tabla2, campoRelacionado2, modulo3, tabla3, campoRelacionado3, parametrosSelect, offset, registrosPorPagina, criterioOrdenacion, posicionColumnaPK);

            datagrid.Columns[0].Width = 50;

            totalRegistros = oDaikoBLL.NumRegistros(modulo1, tabla1);

            int ultimoRegistroPagina = totalRegistros;

            btnSiguiente.Enabled = ultimoRegistroPagina == totalRegistros ? false : true;
            btnAnterior.Enabled = offset > 1 ? true : false;

            labelInfoTabla.Text = string.Format("Mostrando registros del {0} al {1} de un total de {2} registros", offset + 1, ultimoRegistroPagina, totalRegistros);
            txtPagina.Text = paginaActual.ToString();
        }

        private void PersonalizarTabla(int redPrincipal, int greenPrincipal, int bluePrincipal, int redSecundario, int greenSecundario, int blueSecundario)
        {
            datagrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(redPrincipal, greenPrincipal, bluePrincipal);
            btnSiguiente.Textcolor = Color.FromArgb(redPrincipal, greenPrincipal, bluePrincipal);
            btnAnterior.Textcolor = Color.FromArgb(redPrincipal, greenPrincipal, bluePrincipal);
            datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(redSecundario, greenSecundario, blueSecundario);
        }

        private void datagrid_DoubleClick(object sender, EventArgs e)
        {
            btnModificar_Click(sender,e);
        }

        private void comboBoxRegistrosPagina_SelectedIndexChanged(object sender, EventArgs e)
        {
            //permite seleccionar cuantos registros se desean ver por pagina
            switch (comboBoxRegistrosPagina.SelectedIndex)
            {
                case 0:
                    registrosPorPagina = 25;
                    if (labelPanel.Text.ToLower() == "almacen")
                    {
                        switch (labelSubMenu.Text.ToLower())
                        {
                            case "almacenes":
                                CargarDatosTabla(mod1, tab1, parametrosSelect, offset, registrosPorPagina, "ASC", 1);
                                break;
                            case "catalogo":
                                CargarDatosTabla(mod1, tab1, cr1, mod2, tab2, cr2, mod3, tab3, cr3, parametrosSelect, offset, registrosPorPagina, "ASC", 1);
                                break;
                            case "familias":
                                CargarDatosTabla(mod1, tab1, cr1, mod2, tab2, cr2, parametrosSelect, offset, registrosPorPagina, "ASC", 1);
                                break;
                            case "marcas":
                                CargarDatosTabla(mod1, tab1, parametrosSelect, offset, registrosPorPagina, "ASC", 1);
                                break;
                        }
                    }
                    break;
                case 1:
                    registrosPorPagina = 50;
                    if (labelPanel.Text.ToLower() == "almacen")
                    {
                        switch (labelSubMenu.Text.ToLower())
                        {
                            case "almacenes":
                                CargarDatosTabla(mod1, tab1, parametrosSelect, offset, registrosPorPagina, "ASC", 1);
                                break;
                            case "catalogo":
                                CargarDatosTabla(mod1, tab1, cr1, mod2, tab2, cr2, mod3, tab3, cr3, parametrosSelect, offset, registrosPorPagina, "ASC", 1);
                                break;
                            case "familias":
                                CargarDatosTabla(mod1, tab1, cr1, mod2, tab2, cr2, parametrosSelect, offset, registrosPorPagina, "ASC", 1);
                                break;
                            case "marcas":
                                CargarDatosTabla(mod1, tab1, parametrosSelect, offset, registrosPorPagina, "ASC", 1);
                                break;
                        }
                    }
                    break;
                case 2:
                    registrosPorPagina = 100;
                    if (labelPanel.Text.ToLower() == "almacen")
                    {
                        switch (labelSubMenu.Text.ToLower())
                        {
                            case "almacenes":
                                CargarDatosTabla(mod1, tab1, parametrosSelect, offset, registrosPorPagina, "ASC", 1);
                                break;
                            case "catalogo":
                                CargarDatosTabla(mod1, tab1, cr1, mod2, tab2, cr2, mod3, tab3, cr3, parametrosSelect, offset, registrosPorPagina, "ASC", 1);
                                break;
                            case "familias":
                                CargarDatosTabla(mod1, tab1, cr1, mod2, tab2, cr2, parametrosSelect, offset, registrosPorPagina, "ASC", 1);
                                break;
                            case "marcas":
                                CargarDatosTabla(mod1, tab1, parametrosSelect, offset, registrosPorPagina, "ASC", 1);
                                break;
                        }
                    }
                    break;
                case 3:
                    if (labelPanel.Text.ToLower() == "almacen")
                    {
                        switch (labelSubMenu.Text.ToLower())
                        {
                            case "almacenes":
                                CargarDatosTabla(mod1, tab1, parametrosSelect);
                                break;
                            case "catalogo":
                                CargarDatosTabla(mod1, tab1, cr1, mod2, tab2, cr2, mod3, tab3, cr3, parametrosSelect);
                                break;
                            case "familias":
                                CargarDatosTabla(mod1, tab1, cr1, mod2, tab2, cr2, parametrosSelect);
                                break;
                            case "marcas":
                                CargarDatosTabla(mod1, tab1, parametrosSelect);
                                break;
                        }
                    }
                    break;
                    CargarDatosTabla(labelPanel.Text, labelSubMenu.Text, parametrosSelect);
                    break;
            }
        }
    }
}
