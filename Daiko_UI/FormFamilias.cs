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
    public partial class FormFamilias : Form
    {
        string modo;
        Daiko_UC.Models.Familia oFamilia;
        public FormFamilias(string modo, object oFamilia)
        {
            InitializeComponent();
            this.modo = modo;
            this.oFamilia = (Daiko_UC.Models.Familia)oFamilia;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormFamilias_Load(object sender, EventArgs e)
        {
            try
            {
                Daiko_BLL.Daiko_BLL oDaikoBLL = new Daiko_BLL.Daiko_BLL();
                comboBoxEstado.DataSource = oDaikoBLL.ConsultaTotal("General", "estados", "nombre_estado");

                comboBoxEstado.DisplayMember = "nombre_estado";

                if (modo == "crear")
                {
                    labelPanel.Text = "Nueva familia";
                }
                else if (modo == "editar")
                {
                    top_wrapper.BackColor = Color.DarkOrange;

                    labelPanel.Text = "Editar familia";

                    txtFamilia.Text = oFamilia.Nombre_familia;
                    comboBoxEstado.SelectedIndex = oFamilia.Id_estado-1;
                }
                else if (modo == "eliminar")
                {
                    top_wrapper.BackColor = Color.Red;

                    labelPanel.Text = "Eliminar familia";

                    txtFamilia.Text = oFamilia.Nombre_familia;
                    comboBoxEstado.SelectedIndex = oFamilia.Id_estado - 1;
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

            if (modo == "crear" && ValidarFamilia())
            {
                //crear objeto almacen y pasarlo a capas para insert
                Daiko_UC.Models.Familia nuevaFamilia = new Daiko_UC.Models.Familia(txtFamilia.Text,comboBoxEstado.SelectedIndex+1);
                if(oDaikoBLL.InsertarFamilia(nuevaFamilia) == 1)
                {
                    MessageBox.Show("Familia añadida con exito");
                    this.Close();
                }
                else MessageBox.Show("Se ha producido un error al insertar la familia");
            }
            else if (modo == "editar" && ValidarFamilia())
            {
                //traer datos del almacen y realizar update
                Daiko_UC.Models.Familia familiaActualizada = new Daiko_UC.Models.Familia(txtFamilia.Text, comboBoxEstado.SelectedIndex + 1,oFamilia.Id_familia);

                if (oDaikoBLL.ActualizarFamilia(familiaActualizada) == 1)
                {
                    MessageBox.Show("Familia actualizada con exito");
                    this.Close();
                }
                else MessageBox.Show("Se ha producido un error al actualizar la familia");
            }
            else if (modo == "eliminar")
            {
                //preguntar si quiere eliminar ese almacen y realizar delete
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar este registro?", "Precaucion", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    if (oDaikoBLL.Eliminar("Almacen", "familias", "id_familia", oFamilia.Id_familia) == 1)
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

        private bool ValidarFamilia()
        {
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
