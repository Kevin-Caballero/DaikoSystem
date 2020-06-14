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
    public partial class FormEmpresa : Form
    {
        string nombreArchivo;
        string urlArchivo;
        byte[] logoBytes = Array.Empty<byte>();

        public FormEmpresa()
        {
            InitializeComponent();
            if (ExisteEmpresa())
            {
                btnNuevo.Enabled = false;
                btnModificar.Enabled = true;
                top_wrapper.BackColor = Color.DarkOrange;
            }
            else
            {
                btnNuevo.Enabled = true;
                btnModificar.Enabled = false;
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            Daiko_BLL.Daiko_BLL oDaikoBLL = new Daiko_BLL.Daiko_BLL();

            if (ValidarEmpresa())
            {
                if (txtUrlLogo.Text.Trim() != "")
                    logoBytes = ImagenToByteArray(urlArchivo);

                if (IsModoCrear())
                {
                    Daiko_UC.Models.Empresa nuevaEmpresa = new Daiko_UC.Models.Empresa(txtRazonSocial.Text, txtNombreComercial.Text, txtCif.Text, txtCodigoPostal.Text, txtDireccionFiscal.Text, txtTelefono.Text, txtFax.Text, logoBytes);

                    if (oDaikoBLL.InsertarEmpresa(nuevaEmpresa) == 1)
                    {
                        MessageBox.Show("Empresa añadida con exito");
                        LimpiarFormConfiguracionEmpresa();
                        SetModoEditar();
                        pictureBoxLogo.Image = Image.FromFile("..\\..\\..\\Resources\\Icons\\TU_LOGO.png");
                        SetEnabledFormulario(false);
                    }
                    else MessageBox.Show("Se ha producido un error al insertar la empresa");
                }
                else if (IsModoEditar())
                {
                    Daiko_UC.Models.Empresa empresaActualizada = new Daiko_UC.Models.Empresa(txtRazonSocial.Text, txtNombreComercial.Text, txtCif.Text, txtDireccionFiscal.Text, txtCodigoPostal.Text, txtTelefono.Text, txtFax.Text, logoBytes);

                    if (oDaikoBLL.ActualizarEmpresa(empresaActualizada) == 1)
                    {
                        MessageBox.Show("Empresa actualizada con exito");
                        LimpiarFormConfiguracionEmpresa();
                        pictureBoxLogo.Image = Image.FromFile("..\\..\\..\\Resources\\Icons\\TU_LOGO.png");
                        SetEnabledFormulario(false);
                    }
                    else MessageBox.Show("Se ha producido un error al actualizar la empresa");
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            SetEnabledFormulario(true);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            SetEnabledFormulario(true);

            Daiko_BLL.Daiko_BLL oDaikoBLL = new Daiko_BLL.Daiko_BLL();
            Daiko_UC.Models.Empresa empresa = oDaikoBLL.ObtenerDatosEmpresa();
            CargarEmpresaFormulario(empresa);

            if (empresa.Logo.Length>1)
            {
                pictureBoxLogo.Image = ByteArrayToImagen(empresa.Logo);
            }

        }

        private void btnBuscarLogo_Click(object sender, EventArgs e)
        {
            //abrir ventana de seleccion de archivo
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagenes|*.jpg;*.png";
            ofd.Title = "Seleccione su logo";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                urlArchivo = ofd.FileName;
                nombreArchivo = ofd.SafeFileName;

                //cargar datos en el formulario
                lblNombreLogo.Text = nombreArchivo;
                txtUrlLogo.Text = urlArchivo;
                pictureBoxLogo.Load(urlArchivo);
            }
        }

        private bool IsModoCrear()
        {
            return btnNuevo.Enabled && !btnModificar.Enabled ? true : false;
        }

        private bool IsModoEditar()
        {
            return !btnNuevo.Enabled && btnModificar.Enabled ? true : false;
        }

        private void SetModoCrear()
        {
            btnNuevo.Enabled = true;
            btnModificar.Enabled = false;
        }

        private void SetModoEditar()
        {
            btnNuevo.Enabled = false;
            btnModificar.Enabled = true;
        }

        private void LimpiarFormConfiguracionEmpresa()
        {
            txtRazonSocial.Text = "";
            txtNombreComercial.Text = "";
            txtCif.Text = "";
            txtCodigoPostal.Text = "";
            txtDireccionFiscal.Text = "";
            txtTelefono.Text = "";
            txtFax.Text = "";
            txtUrlLogo.Text = "";
            lblNombreLogo.Text = "";


            txtRazonSocial.BorderColorIdle = Color.FromArgb(64, 64, 64);
            txtNombreComercial.BorderColorIdle = Color.FromArgb(64, 64, 64);
            txtCif.BorderColorIdle = Color.FromArgb(64, 64, 64);
            txtCodigoPostal.BorderColorIdle = Color.FromArgb(64, 64, 64);
            txtDireccionFiscal.BorderColorIdle = Color.FromArgb(64, 64, 64);
            txtTelefono.BorderColorIdle = Color.FromArgb(64, 64, 64);
            txtFax.BorderColorIdle = Color.FromArgb(64, 64, 64);
            //txtUrlLogo.BorderColorIdle = Color.FromArgb(64, 64, 64);

            labelAvisoRazonSocial.Text = "";
            labelAvisoNombreComercial.Text = "";
            labelAvisoCIF.Text = "";
            labelAvisoCodigoPostal.Text = "";
            labelAvisoDireccionFiscal.Text = "";
            labelAvisoTelefono.Text = "";
            labelAvisoFax.Text = "";
            //labelAvisoNombreComercial.Text = "";
        }

        private void SetEnabledFormulario(bool value)
        {
            groupBoxDatosEmpresa.Enabled = value;
            foreach (Control item in groupBoxDatosEmpresa.Controls)
            {
                item.Enabled = value;
            }

            groupBoxContacto.Enabled = value;
            foreach (Control item in groupBoxContacto.Controls)
            {
                item.Enabled = value;
            }

            groupBoxLogo.Enabled = value;
            btnBuscarLogo.Enabled = value;
            txtUrlLogo.Enabled = value;
            pictureBoxLogo.Enabled = value;

            btnAceptar.Enabled = value;
            btnCancelar.Enabled = value;
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

        private void CargarEmpresaFormulario(Daiko_UC.Models.Empresa empresa)
        {
            txtRazonSocial.Text = empresa.Razon_social;
            txtNombreComercial.Text = empresa.Nombre_comercial;
            txtCif.Text = empresa.Cif;
            txtCodigoPostal.Text = empresa.Codigo_postal;
            txtDireccionFiscal.Text = empresa.Direccion_fiscal;
            txtTelefono.Text = empresa.Telefono;
            txtFax.Text = empresa.Fax;
        }

        private bool ValidarEmpresa()
        {
            if (ValidarRazonSocial() && ValidarNombreComercial() && ValidarCIF() && ValidarCodigoPostal() && ValidarDireccionFiscal() && ValidarTelefono() && ValidarFax())
            {
                return true;
            }
            return false;
        }

        private bool ValidarRazonSocial()
        {
            if (txtRazonSocial.Text.Trim() == "" || txtRazonSocial.Text.Length > 50)
            {
                txtRazonSocial.BorderColorIdle = Color.Red;
                labelAvisoRazonSocial.Text = "Campo obligatorio / Long. inferior 50";
                return false;
            }
            txtRazonSocial.BorderColorIdle = Color.FromArgb(64, 64, 64);
            labelAvisoRazonSocial.Text = "";
            return true;
        }
        private void txtRazonSocial_OnValueChanged(object sender, EventArgs e)
        {
            ValidarRazonSocial();
        }

        private bool ValidarNombreComercial()
        {
            if (txtNombreComercial.Text.Trim() == "" || txtNombreComercial.Text.Length > 50)
            {
                txtNombreComercial.BorderColorIdle = Color.Red;
                labelAvisoNombreComercial.Text = "Campo obligatorio / Long. inferior 50";
                return false;
            }
            txtNombreComercial.BorderColorIdle = Color.FromArgb(64, 64, 64);
            labelAvisoNombreComercial.Text = "";
            return true;
        }
        private void txtNombreComercial_OnValueChanged(object sender, EventArgs e)
        {
            ValidarNombreComercial();
        }

        private bool ValidarCIF()
        {
            char[] letrasCodigo = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'N', 'P', 'Q', 'R', 'S', 'U', 'V', 'W' };
            char[] cif = txtCif.Text.ToUpper().ToCharArray();

            // System.IO.File.WriteAllText("..\\..\\log\\TRC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), txtCif.Text.ToUpper());

            if (txtCif.Text.Trim() == "")
            {
                txtCif.BorderColorIdle = Color.Red;
                labelAvisoCIF.Text = "Campo obligatorio";
                return false;
            }

            for (int i = 0; i < letrasCodigo.Length; i++)
            {
                if (cif[0] == letrasCodigo[i])
                {
                    for (int j = 1; j < cif.Length; j++)
                    {
                        if (!Char.IsNumber(cif[j]))
                        {
                            txtCif.BorderColorIdle = Color.Red;
                            labelAvisoCIF.Text = "La letra debe ir seguida unicamente por numeros";
                            return false;
                        }
                    }
                    if (txtCif.Text.Length == 9)
                    {
                        txtCif.BorderColorIdle = Color.FromArgb(64, 64, 64);
                        labelAvisoCIF.Text = "";
                        return true;
                    }
                    txtCif.BorderColorIdle = Color.Red;
                    labelAvisoCIF.Text = "Longitud erronea";
                    return false;
                }
            }
            txtCif.BorderColorIdle = Color.Red;
            labelAvisoCIF.Text = "El primer caracter no es valido";
            return false;
        }
        private void txtCif_OnValueChanged(object sender, EventArgs e)
        {
            ValidarCIF();
        }

        private bool ValidarCodigoPostal()
        {
            char[] cP = txtCodigoPostal.Text.ToCharArray();

            for (int i = 0; i < cP.Length; i++)
            {
                if (!Char.IsNumber(cP[i]))
                {
                    txtCodigoPostal.BorderColorIdle = Color.Red;
                    labelAvisoCodigoPostal.Text = "Solo caracteres numericos";
                    return false;
                }
            }

            if (cP.Length != 5)
            {
                txtCodigoPostal.BorderColorIdle = Color.Red;
                labelAvisoCodigoPostal.Text = "Longitud erronea";
                return false;
            }

            txtCodigoPostal.BorderColorIdle = Color.FromArgb(64, 64, 64);
            labelAvisoCodigoPostal.Text = "";
            return true;
        }
        private void txtCodigoPostal_OnValueChanged(object sender, EventArgs e)
        {
            ValidarCodigoPostal();
        }

        private bool ValidarDireccionFiscal()
        {
            if (txtDireccionFiscal.Text.Trim() == "" || txtDireccionFiscal.Text.Length > 50)
            {
                txtDireccionFiscal.BorderColorIdle = Color.Red;
                labelAvisoDireccionFiscal.Text = "Campo obligatorio / Long. inferior 50";
                return false;
            }
            txtDireccionFiscal.BorderColorIdle = Color.FromArgb(64, 64, 64);
            labelAvisoDireccionFiscal.Text = "";
            return true;
        }
        private void txtDireccionFiscal_OnValueChanged(object sender, EventArgs e)
        {
            ValidarDireccionFiscal();
        }

        private bool ValidarTelefono()
        {
            char[] telefono = txtTelefono.Text.ToCharArray();

            for (int i = 0; i < telefono.Length; i++)
            {
                if (!Char.IsNumber(telefono[i]))
                {
                    txtTelefono.BorderColorIdle = Color.Red;
                    labelAvisoTelefono.Text = "Solo caracteres numericos";
                    return false;
                }
            }

            if (telefono.Length != 9)
            {
                txtTelefono.BorderColorIdle = Color.Red;
                labelAvisoTelefono.Text = "Longitud erronea";
                return false;
            }

            txtTelefono.BorderColorIdle = Color.FromArgb(64, 64, 64);
            labelAvisoTelefono.Text = "";
            return true;
        }
        private void txtTelefono_OnValueChanged(object sender, EventArgs e)
        {
            ValidarTelefono();
        }

        private bool ValidarFax()
        {
            if (txtFax.Text.Trim().Length != 0 && txtFax.Text.Trim().Length != 9)
            {
                txtFax.BorderColorIdle = Color.Red;
                labelAvisoFax.Text = "Solo caracteres numericos / Long. 9";
                return false;
            }

            txtFax.BorderColorIdle = Color.FromArgb(64, 64, 64);
            labelAvisoFax.Text = "";
            return true;
        }
        private void txtFax_OnValueChanged(object sender, EventArgs e)
        {
            ValidarFax();
        }


        private bool ExisteEmpresa()
        {
            Daiko_BLL.Daiko_BLL oDaikoBLL = new Daiko_BLL.Daiko_BLL();
            return oDaikoBLL.ExisteEmpresa();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void groupBoxLogo_Enter(object sender, EventArgs e)
        {

        }

    }
}
