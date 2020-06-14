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
    public partial class FormProductos : Form
    {
        private string modo;
        private Daiko_UC.Models.Producto oProducto;

        string nombreArchivo;
        string urlArchivo;
        byte[] logoBytes = Array.Empty<byte>();

        public FormProductos(string modo, object oProducto)
        {
            InitializeComponent();
            this.modo = modo;
            this.oProducto = (Daiko_UC.Models.Producto)oProducto;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            try
            {
                //se crea un objeto de la clase Daiko_BLL para realizar consultas y enlazar a controles
                Daiko_BLL.Daiko_BLL oDaikoBLL = new Daiko_BLL.Daiko_BLL();

                comboBoxAlmacen.DataSource = oDaikoBLL.ConsultaTotal("Almacen", "Almacenes", "nombre");
                comboBoxAlmacen.DisplayMember = "nombre";
                comboBoxFamilia.DataSource = oDaikoBLL.ConsultaTotal("Almacen", "Familias", "codigo_familia");
                comboBoxFamilia.DisplayMember = "codigo_familia";
                comboBoxMarca.DataSource = oDaikoBLL.ConsultaTotal("Almacen", "Marcas", "nombre");
                comboBoxMarca.DisplayMember = "nombre";

                //si el modo en el que se ha accedido al formulario es a traves del boton nuevo
                if (modo == "crear")
                {
                    labelPanel.Text = "Nuevo producto";
                }
                //si el modo en el que se ha accedido al formulario es a traves del boton nuevo
                else if (modo == "editar")
                {
                    top_wrapper.BackColor = Color.DarkOrange;

                    labelPanel.Text = "Editar producto";

                    if (oProducto.Imagen.Length > 1)
                    {
                        pictureBoxLogo.Image = ByteArrayToImagen(oProducto.Imagen);
                    }

                    //cargando datos en formulario
                    txtNombreProducto.Text = oProducto.Nombre;
                    txtCodigoInterno.Text = oProducto.Codigo_interno;
                    comboBoxFamilia.SelectedIndex = oProducto.Id_familia - 1;
                    comboBoxMarca.SelectedIndex = oProducto.Id_marca - 1;
                    comboBoxAlmacen.SelectedIndex = oProducto.Id_almacen - 1;
                    DatepickerAlta.Value = oProducto.Fecha_alta;
                    DatepickerBaja.Value = oProducto.Fecha_baja;
                    txtDescripcion.Text = oProducto.Descripcion;
                    txtPrecioMayorista.Text = oProducto.Precio_mayorista.ToString();
                    txtPrecioSinIVA.Text = oProducto.Precio_sin_iva.ToString();
                    txtIVA.Text = oProducto.Iva.ToString();
                    txtPedidoMin.Text = oProducto.Pedido_minimo.ToString();
                    txtStockMin.Text = oProducto.Stock_minimo.ToString();
                }
                else if (modo == "eliminar")
                {
                    top_wrapper.BackColor = Color.Red;
                    labelPanel.Text = "Eliminar producto";

                    txtNombreProducto.Text = oProducto.Nombre;
                    txtCodigoInterno.Text = oProducto.Codigo_interno;
                    comboBoxFamilia.SelectedIndex = oProducto.Id_familia - 1;
                    comboBoxMarca.SelectedIndex = oProducto.Id_marca - 1;
                    comboBoxAlmacen.SelectedIndex = oProducto.Id_almacen - 1;
                    DatepickerAlta.Value = oProducto.Fecha_alta;
                    DatepickerBaja.Value = oProducto.Fecha_baja;
                    txtDescripcion.Text = oProducto.Descripcion;
                    txtPrecioMayorista.Text = oProducto.Precio_mayorista.ToString();
                    txtPrecioSinIVA.Text = oProducto.Precio_sin_iva.ToString();
                    txtIVA.Text = oProducto.Iva.ToString();
                    txtPedidoMin.Text = oProducto.Pedido_minimo.ToString();
                    txtStockMin.Text = oProducto.Stock_minimo.ToString();
                }
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText("..\\..\\log\\EXC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Daiko_BLL.Daiko_BLL oDaikoBLL = new Daiko_BLL.Daiko_BLL();

            if (modo == "crear" && ValidarProducto())
            {
                //si no esta vacio se carga la imagen
                if (txtUrlLogo.Text.Trim() != "")
                    logoBytes = ImagenToByteArray(urlArchivo);

                //crear objeto almacen y se pasa a la capa de business logic para insert
                int id_almacen = comboBoxAlmacen.SelectedIndex + 1;
                string codigo_interno = txtCodigoInterno.Text;
                string nombre = txtNombreProducto.Text;
                int id_familia = comboBoxFamilia.SelectedIndex + 1;
                int id_marca = comboBoxMarca.SelectedIndex + 1;
                DateTime fecha_alta = DatepickerAlta.Value;
                DateTime fecha_baja = DatepickerBaja.Value;
                string descripcion = txtDescripcion.Text;
                decimal precio_sin_iva = decimal.Parse(txtPrecioSinIVA.Text);
                int iva = int.Parse(txtIVA.Text);
                decimal precio_mayorista = decimal.Parse(txtPrecioMayorista.Text);
                int stock_minimo = int.Parse(txtStockMin.Text);
                int stock = 0;
                int pedido_minimo = int.Parse(txtPedidoMin.Text);


                Daiko_UC.Models.Producto nuevoProducto = new Daiko_UC.Models.Producto(id_almacen, codigo_interno, nombre, id_familia, id_marca, fecha_alta, fecha_baja, descripcion, precio_sin_iva, iva, precio_mayorista, stock_minimo, stock, pedido_minimo, logoBytes);

                // si se inserta correctamente mensaje OK
                if (oDaikoBLL.InsertarProducto(nuevoProducto) == 1)
                {
                    MessageBox.Show("Producto añadido con exito");
                    this.Close();
                }
                else MessageBox.Show("Se ha producido un error al insertar el producto");
            }
            else if (modo == "editar" && ValidarProducto())
            {
                //crear objeto almacen y pasarlo a capas para insert
                int id_almacen = comboBoxAlmacen.SelectedIndex + 1;
                string codigo_interno = txtCodigoInterno.Text;
                string nombre = txtNombreProducto.Text;
                int id_familia = comboBoxFamilia.SelectedIndex + 1;
                int id_marca = comboBoxMarca.SelectedIndex + 1;
                DateTime fecha_alta = DatepickerAlta.Value;
                DateTime fecha_baja = DatepickerBaja.Value;
                string descripcion = txtDescripcion.Text;
                decimal precio_sin_iva = decimal.Parse(txtPrecioSinIVA.Text);
                int iva = int.Parse(txtIVA.Text);
                decimal precio_mayorista = decimal.Parse(txtPrecioMayorista.Text);
                int stock_minimo = int.Parse(txtStockMin.Text);
                int stock = 0;
                int pedido_minimo = int.Parse(txtPedidoMin.Text);

                Daiko_UC.Models.Producto productoActualizado = new Daiko_UC.Models.Producto(id_almacen, codigo_interno, nombre, id_familia, id_marca, fecha_alta, fecha_baja, descripcion, precio_sin_iva, iva, precio_mayorista, stock_minimo, stock, pedido_minimo, logoBytes, oProducto.Id_producto);


                
                if (oDaikoBLL.ActualizarProducto(productoActualizado) == 1)
                {
                    MessageBox.Show("Producto actualizada con exito");
                    this.Close();
                }
                else MessageBox.Show("Se ha producido un error al actualizar la producto");
            }
            else if (modo == "eliminar")
            {

                DialogResult respuesta = MessageBox.Show("¿Desea eliminar este registro?", "Precaucion", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    if (oDaikoBLL.Eliminar("Almacen", "catalogo", "id_producto", oProducto.Id_producto) == 1)
                    {
                        MessageBox.Show("Producto eliminado con exito");
                        this.Close();
                    }
                    else MessageBox.Show("Se ha producido un error al eliminar el Producto");
                }
                else
                {
                    this.Close();
                }
            }
        }

        private bool ValidarProducto()
        {
            //TODO: aplicar validacion de formulario
            return true;
        }

        private void txtIVA_OnValueChanged(object sender, EventArgs e)
        {
            //si se introduce precio sin iva pero no iva: PVP = precio sin iva
            if (txtPrecioSinIVA.Text != "" && txtIVA.Text == "")
                txtPVP.Text = txtPrecioSinIVA.Text;
            //si falta precio sin iva y/o falta el iva: PVP = 0
            else if (txtPrecioSinIVA.Text == "" && txtIVA.Text != "" || txtPrecioSinIVA.Text == "" && txtIVA.Text == "")
                txtPVP.Text = "0";
            //si no se calcula en base a los campos
            else
                txtPVP.Text = ((float.Parse(txtPrecioSinIVA.Text) * int.Parse(txtIVA.Text) / 100) + float.Parse(txtPrecioSinIVA.Text)).ToString();
        }

        private void txtPrecioSinIVA_OnValueChanged(object sender, EventArgs e)
        {
            //si se introduce precio sin iva pero no iva: PVP = precio sin iva
            if (txtPrecioSinIVA.Text != "" && txtIVA.Text == "")
                txtPVP.Text = txtPrecioSinIVA.Text;
            //si falta precio sin iva y/o falta el iva: PVP = 0
            else if (txtPrecioSinIVA.Text == "" && txtIVA.Text != "" || txtPrecioSinIVA.Text == "" && txtIVA.Text == "")
                txtPVP.Text = "0";
            //si no se calcula en base a los campos
            else
                txtPVP.Text = ((float.Parse(txtPrecioSinIVA.Text) * int.Parse(txtIVA.Text) / 100) + float.Parse(txtPrecioSinIVA.Text)).ToString();

        }

        private void btnBuscarLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagenes|*.jpg;*.png";
            ofd.Title = "Seleccione su logo";

            //si suben foto y la fot se carga se muestran los datos de la foto
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                urlArchivo = ofd.FileName;
                nombreArchivo = ofd.SafeFileName;

                lblNombreLogo.Text = nombreArchivo;
                txtUrlLogo.Text = urlArchivo;
                pictureBoxLogo.Load(urlArchivo);
            }
        }

        private Image ByteArrayToImagen(byte[] logoBytes)
        {
            MemoryStream ms = new MemoryStream(logoBytes);
            Bitmap logo = new Bitmap(ms);
            return logo;
        }

        private byte[] ImagenToByteArray(string urlArchivo)
        {
            Image logo = Image.FromFile(urlArchivo);
            var ms = new MemoryStream();
            logo.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            var logoBytes = ms.ToArray();
            return logoBytes;
        }

        private void groupBoxDatosAlmacen_Enter(object sender, EventArgs e)
        {

        }
    }
}
