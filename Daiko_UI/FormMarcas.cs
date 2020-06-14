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
    public partial class FormMarcas : Form
    {
        private string modo;
        private Daiko_UC.Models.Marca oMarca;
        public FormMarcas(string modo, object oMarca)
        {
            InitializeComponent();
            this.modo = modo;
            this.oMarca = (Daiko_UC.Models.Marca)oMarca;
        }

        private void FormMarcas_Load(object sender, EventArgs e)
        {
            try
            {
                Daiko_BLL.Daiko_BLL oDaikoBLL = new Daiko_BLL.Daiko_BLL();

                if (modo == "crear")
                {
                    labelPanel.Text = "Nueva marca";
                }
                else if (modo == "editar")
                {
                    top_wrapper.BackColor = Color.DarkOrange;

                    labelPanel.Text = "Editar marca";
                    txtMarca.Text = oMarca.Nombre;
                }
                else if (modo == "eliminar")
                {
                    top_wrapper.BackColor = Color.Red;

                    labelPanel.Text = "Eliminar marca";
                    txtMarca.Text = oMarca.Nombre;
                }
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText("..\\..\\log\\EXC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Daiko_BLL.Daiko_BLL oDaikoBLL = new Daiko_BLL.Daiko_BLL();

            if (modo == "crear" && ValidarMarca())
            {
                //crear objeto almacen y pasarlo a capas para insert
                Daiko_UC.Models.Marca nuevaMarca = new Daiko_UC.Models.Marca(txtMarca.Text);
                if (oDaikoBLL.InsertaMarca(nuevaMarca) == 1)
                {
                    MessageBox.Show("Marca añadida con exito");
                    this.Close();
                }
                else MessageBox.Show("Se ha producido un error al insertar la marca");
            }
            else if (modo == "editar" && ValidarMarca())
            {
                //traer datos del almacen y realizar update
                Daiko_UC.Models.Marca marcaActualizada = new Daiko_UC.Models.Marca(txtMarca.Text,oMarca.Id_marca);

                if (oDaikoBLL.ActualizarMarca(marcaActualizada) == 1)
                {
                    MessageBox.Show("Marca actualizada con exito");
                    this.Close();
                }
                else MessageBox.Show("Se ha producido un error al actualizar la marca");
            }
            else if (modo == "eliminar")
            {
                //preguntar si quiere eliminar ese almacen y realizar delete
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar este registro?", "Precaucion", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    if (oDaikoBLL.Eliminar("Almacen", "marcas", "id_marca", oMarca.Id_marca) == 1)
                    {
                        MessageBox.Show("Familia eliminada con exito");
                        this.Close();
                    }
                    else MessageBox.Show("Se ha producido un error al eliminar la familia");
                }
                else
                {
                    this.Close();
                }
            }
        }

        private bool ValidarMarca()
        {
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
