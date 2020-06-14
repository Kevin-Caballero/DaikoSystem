using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daiko_DESKTOP
{
    public partial class FormAlmacenes : Form
    {
        string modo;
        Daiko_UC.Models.Almacen oAlmacen;

        public FormAlmacenes(string modo,object oAlmacen)
        {
            InitializeComponent();
            this.modo = modo;
            this.oAlmacen = (Daiko_UC.Models.Almacen)oAlmacen;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAlmacenes_Load(object sender, EventArgs e)
        {
            try
            {
                Daiko_BLL.Daiko_BLL oDaikoBLL = new Daiko_BLL.Daiko_BLL();
                comboBoxPais.DataSource = oDaikoBLL.ConsultaTotal("General", "Paises", "nombre"); // enlazar el control al resultado de una consulta 

                comboBoxPais.DisplayMember = "nombre";

                if (modo == "crear") { 
                    labelPanel.Text = "Nuevo almacen"; 
                }
                else if (modo == "editar")
                {
                    top_wrapper.BackColor = Color.DarkOrange;

                    labelPanel.Text = "Editar almacen";

                    //llenar los campos del formulario con los datos del objeto recibido al crearse el formulario
                    txtNombreAlmacen.Text = oAlmacen.Nombre;
                    txtResponsable.Text = oAlmacen.Responsable;
                    txtTelefono.Text = oAlmacen.Telefono;
                    txtDireccion.Text = oAlmacen.Direccion;
                    txtProvincia.Text = oAlmacen.Provincia;
                    txtLocalidad.Text = oAlmacen.Localidad;
                    txtCodigoPostal.Text = oAlmacen.Codigo_postal;
                    txtNota.Text = oAlmacen.Nota;
                    comboBoxGestionInventario.Text = oAlmacen.Gestion_inventario;
                    comboBoxPais.SelectedIndex = oAlmacen.Id_pais - 1;
                }
                else if (modo == "eliminar") 
                {
                    top_wrapper.BackColor = Color.Red;

                    labelPanel.Text = "Eliminar almacen";

                    //llenar los campos del formulario con los datos del objeto recibido al crearse el formulario
                    txtNombreAlmacen.Text = oAlmacen.Nombre;
                    txtResponsable.Text = oAlmacen.Responsable;
                    txtTelefono.Text = oAlmacen.Telefono;
                    txtDireccion.Text = oAlmacen.Direccion;
                    txtProvincia.Text = oAlmacen.Provincia;
                    txtLocalidad.Text = oAlmacen.Localidad;
                    txtCodigoPostal.Text = oAlmacen.Codigo_postal;
                    txtNota.Text = oAlmacen.Nota;
                    comboBoxGestionInventario.Text = oAlmacen.Gestion_inventario;
                    comboBoxPais.SelectedIndex = oAlmacen.Id_pais - 1;

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

            if (modo == "crear" && ValidarAlmacen())
            {
                //crear objeto almacen y pasarlo a capas para insert
                Daiko_UC.Models.Almacen nuevoAlmacen = new Daiko_UC.Models.Almacen(txtNombreAlmacen.Text,txtTelefono.Text,txtDireccion.Text,txtCodigoPostal.Text,comboBoxPais.SelectedIndex+1,txtProvincia.Text,txtLocalidad.Text,comboBoxGestionInventario.SelectedItem.ToString(),txtResponsable.Text,txtNota.Text);
                if (oDaikoBLL.InsertarAlmacen(nuevoAlmacen)==1)
                {
                    MessageBox.Show("Almacen añadido con exito");
                    this.Close();
                }
                else MessageBox.Show("Se ha producido un error al insertar el almacen");
            }
            else if (modo == "editar" && ValidarAlmacen())
            {
                //traer datos del almacen y realizar update
                Daiko_UC.Models.Almacen almacenActualizado = new Daiko_UC.Models.Almacen(txtNombreAlmacen.Text, txtTelefono.Text, txtDireccion.Text, txtCodigoPostal.Text, comboBoxPais.SelectedIndex + 1, txtProvincia.Text, txtLocalidad.Text, comboBoxGestionInventario.SelectedItem.ToString(), txtResponsable.Text, txtNota.Text,oAlmacen.Id_almacen);

                if (oDaikoBLL.ActualizarAlmacen(almacenActualizado) == 1)
                {
                    MessageBox.Show("Almacen actualizado con exito");
                    this.Close();
                }
                else MessageBox.Show("Se ha producido un error al actualizar el almacen");
            }
            else if(modo == "eliminar")
            {
                //preguntar si quiere eliminar ese almacen y realizar delete
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar este registro?", "Precaucion", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    if(oDaikoBLL.Eliminar("Almacen","almacenes","id_almacen",oAlmacen.Id_almacen) == 1)
                    {
                        MessageBox.Show("Almacen eliminado con exito");
                        this.Close();
                    }
                    else MessageBox.Show("Se ha producido un error al eliminar el almacen");
                }
                else
                {
                    this.Close();
                }
            }
        }

        private bool ValidarAlmacen()
        {
            //TODO: para futuras versiones validar formulario
            return true;
        }
    }
}
