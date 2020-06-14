namespace Daiko_DESKTOP
{
    partial class FormAlmacenes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlmacenes));
            this.top_wrapper = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.labelPanel = new System.Windows.Forms.Label();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAceptar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBoxDatosAlmacen = new System.Windows.Forms.GroupBox();
            this.labelAvisoNombreComercial = new System.Windows.Forms.Label();
            this.labelAvisoRazonSocial = new System.Windows.Forms.Label();
            this.txtResponsable = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNombreAlmacen = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelAvisoCIF = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAvisoCodigoPostal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigoPostal = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocalidad = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDireccion = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProvincia = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.comboBoxPais = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefono = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtNota = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxGestionInventario = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.top_wrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.groupBoxDatosAlmacen.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_wrapper
            // 
            this.top_wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.top_wrapper.Controls.Add(this.btnClose);
            this.top_wrapper.Controls.Add(this.labelPanel);
            this.top_wrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_wrapper.Location = new System.Drawing.Point(0, 0);
            this.top_wrapper.Name = "top_wrapper";
            this.top_wrapper.Size = new System.Drawing.Size(701, 51);
            this.top_wrapper.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(659, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelPanel
            // 
            this.labelPanel.AutoSize = true;
            this.labelPanel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPanel.ForeColor = System.Drawing.Color.White;
            this.labelPanel.Location = new System.Drawing.Point(12, 14);
            this.labelPanel.Name = "labelPanel";
            this.labelPanel.Size = new System.Drawing.Size(105, 22);
            this.labelPanel.TabIndex = 1;
            this.labelPanel.Text = "ALMACEN";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Activecolor = System.Drawing.Color.Red;
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.BorderRadius = 0;
            this.btnCancelar.ButtonText = "Cancelar";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancelar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Iconimage")));
            this.btnCancelar.Iconimage_right = null;
            this.btnCancelar.Iconimage_right_Selected = null;
            this.btnCancelar.Iconimage_Selected = null;
            this.btnCancelar.IconMarginLeft = 0;
            this.btnCancelar.IconMarginRight = 0;
            this.btnCancelar.IconRightVisible = true;
            this.btnCancelar.IconRightZoom = 0D;
            this.btnCancelar.IconVisible = true;
            this.btnCancelar.IconZoom = 50D;
            this.btnCancelar.IsTab = false;
            this.btnCancelar.Location = new System.Drawing.Point(370, 814);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Normalcolor = System.Drawing.Color.Red;
            this.btnCancelar.OnHovercolor = System.Drawing.Color.Firebrick;
            this.btnCancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancelar.selected = false;
            this.btnCancelar.Size = new System.Drawing.Size(138, 48);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.Textcolor = System.Drawing.Color.White;
            this.btnCancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Activecolor = System.Drawing.Color.LimeGreen;
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptar.BorderRadius = 0;
            this.btnAceptar.ButtonText = "Aceptar";
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.DisabledColor = System.Drawing.Color.Gray;
            this.btnAceptar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAceptar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Iconimage")));
            this.btnAceptar.Iconimage_right = null;
            this.btnAceptar.Iconimage_right_Selected = null;
            this.btnAceptar.Iconimage_Selected = null;
            this.btnAceptar.IconMarginLeft = 0;
            this.btnAceptar.IconMarginRight = 0;
            this.btnAceptar.IconRightVisible = true;
            this.btnAceptar.IconRightZoom = 0D;
            this.btnAceptar.IconVisible = true;
            this.btnAceptar.IconZoom = 50D;
            this.btnAceptar.IsTab = false;
            this.btnAceptar.Location = new System.Drawing.Point(190, 814);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Normalcolor = System.Drawing.Color.LimeGreen;
            this.btnAceptar.OnHovercolor = System.Drawing.Color.ForestGreen;
            this.btnAceptar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAceptar.selected = false;
            this.btnAceptar.Size = new System.Drawing.Size(138, 48);
            this.btnAceptar.TabIndex = 24;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAceptar.Textcolor = System.Drawing.Color.White;
            this.btnAceptar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupBoxDatosAlmacen
            // 
            this.groupBoxDatosAlmacen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxDatosAlmacen.Controls.Add(this.labelAvisoNombreComercial);
            this.groupBoxDatosAlmacen.Controls.Add(this.labelAvisoRazonSocial);
            this.groupBoxDatosAlmacen.Controls.Add(this.txtResponsable);
            this.groupBoxDatosAlmacen.Controls.Add(this.txtNombreAlmacen);
            this.groupBoxDatosAlmacen.Controls.Add(this.label7);
            this.groupBoxDatosAlmacen.Controls.Add(this.label6);
            this.groupBoxDatosAlmacen.Location = new System.Drawing.Point(16, 84);
            this.groupBoxDatosAlmacen.Name = "groupBoxDatosAlmacen";
            this.groupBoxDatosAlmacen.Size = new System.Drawing.Size(665, 120);
            this.groupBoxDatosAlmacen.TabIndex = 26;
            this.groupBoxDatosAlmacen.TabStop = false;
            this.groupBoxDatosAlmacen.Text = "Datos Almacen";
            // 
            // labelAvisoNombreComercial
            // 
            this.labelAvisoNombreComercial.AutoSize = true;
            this.labelAvisoNombreComercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvisoNombreComercial.ForeColor = System.Drawing.Color.Red;
            this.labelAvisoNombreComercial.Location = new System.Drawing.Point(369, 97);
            this.labelAvisoNombreComercial.Name = "labelAvisoNombreComercial";
            this.labelAvisoNombreComercial.Size = new System.Drawing.Size(0, 12);
            this.labelAvisoNombreComercial.TabIndex = 9;
            // 
            // labelAvisoRazonSocial
            // 
            this.labelAvisoRazonSocial.AutoSize = true;
            this.labelAvisoRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvisoRazonSocial.ForeColor = System.Drawing.Color.Red;
            this.labelAvisoRazonSocial.Location = new System.Drawing.Point(38, 97);
            this.labelAvisoRazonSocial.Name = "labelAvisoRazonSocial";
            this.labelAvisoRazonSocial.Size = new System.Drawing.Size(0, 12);
            this.labelAvisoRazonSocial.TabIndex = 8;
            // 
            // txtResponsable
            // 
            this.txtResponsable.BackColor = System.Drawing.Color.White;
            this.txtResponsable.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtResponsable.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtResponsable.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.txtResponsable.BorderThickness = 2;
            this.txtResponsable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResponsable.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtResponsable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtResponsable.isPassword = false;
            this.txtResponsable.Location = new System.Drawing.Point(369, 51);
            this.txtResponsable.Margin = new System.Windows.Forms.Padding(4);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(251, 44);
            this.txtResponsable.TabIndex = 4;
            this.txtResponsable.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNombreAlmacen
            // 
            this.txtNombreAlmacen.BackColor = System.Drawing.Color.White;
            this.txtNombreAlmacen.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtNombreAlmacen.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombreAlmacen.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.txtNombreAlmacen.BorderThickness = 2;
            this.txtNombreAlmacen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreAlmacen.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombreAlmacen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombreAlmacen.isPassword = false;
            this.txtNombreAlmacen.Location = new System.Drawing.Point(38, 51);
            this.txtNombreAlmacen.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreAlmacen.Name = "txtNombreAlmacen";
            this.txtNombreAlmacen.Size = new System.Drawing.Size(235, 44);
            this.txtNombreAlmacen.TabIndex = 3;
            this.txtNombreAlmacen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nombre almacen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Responsable";
            // 
            // labelAvisoCIF
            // 
            this.labelAvisoCIF.AutoSize = true;
            this.labelAvisoCIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvisoCIF.ForeColor = System.Drawing.Color.Red;
            this.labelAvisoCIF.Location = new System.Drawing.Point(253, 119);
            this.labelAvisoCIF.Name = "labelAvisoCIF";
            this.labelAvisoCIF.Size = new System.Drawing.Size(0, 12);
            this.labelAvisoCIF.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pais";
            // 
            // labelAvisoCodigoPostal
            // 
            this.labelAvisoCodigoPostal.AutoSize = true;
            this.labelAvisoCodigoPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvisoCodigoPostal.ForeColor = System.Drawing.Color.Red;
            this.labelAvisoCodigoPostal.Location = new System.Drawing.Point(585, 294);
            this.labelAvisoCodigoPostal.Name = "labelAvisoCodigoPostal";
            this.labelAvisoCodigoPostal.Size = new System.Drawing.Size(0, 12);
            this.labelAvisoCodigoPostal.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Codigo postal";
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.BackColor = System.Drawing.Color.White;
            this.txtCodigoPostal.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtCodigoPostal.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigoPostal.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.txtCodigoPostal.BorderThickness = 2;
            this.txtCodigoPostal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoPostal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCodigoPostal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigoPostal.isPassword = false;
            this.txtCodigoPostal.Location = new System.Drawing.Point(479, 135);
            this.txtCodigoPostal.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(141, 44);
            this.txtCodigoPostal.TabIndex = 6;
            this.txtCodigoPostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Localidad";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.BackColor = System.Drawing.Color.White;
            this.txtLocalidad.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtLocalidad.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLocalidad.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.txtLocalidad.BorderThickness = 2;
            this.txtLocalidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocalidad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLocalidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLocalidad.isPassword = false;
            this.txtLocalidad.Location = new System.Drawing.Point(253, 135);
            this.txtLocalidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(186, 44);
            this.txtLocalidad.TabIndex = 16;
            this.txtLocalidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtProvincia);
            this.groupBox1.Controls.Add(this.comboBoxPais);
            this.groupBox1.Controls.Add(this.txtLocalidad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodigoPostal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelAvisoCodigoPostal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelAvisoCIF);
            this.groupBox1.Location = new System.Drawing.Point(16, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 214);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ubicacion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtDireccion.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDireccion.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.txtDireccion.BorderThickness = 2;
            this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDireccion.isPassword = false;
            this.txtDireccion.Location = new System.Drawing.Point(369, 43);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(251, 44);
            this.txtDireccion.TabIndex = 20;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Direccion";
            // 
            // txtProvincia
            // 
            this.txtProvincia.BackColor = System.Drawing.Color.White;
            this.txtProvincia.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtProvincia.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProvincia.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.txtProvincia.BorderThickness = 2;
            this.txtProvincia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProvincia.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProvincia.isPassword = false;
            this.txtProvincia.Location = new System.Drawing.Point(38, 135);
            this.txtProvincia.Margin = new System.Windows.Forms.Padding(4);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(186, 44);
            this.txtProvincia.TabIndex = 18;
            this.txtProvincia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // comboBoxPais
            // 
            this.comboBoxPais.DropDownHeight = 120;
            this.comboBoxPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPais.FormattingEnabled = true;
            this.comboBoxPais.IntegralHeight = false;
            this.comboBoxPais.ItemHeight = 20;
            this.comboBoxPais.Location = new System.Drawing.Point(38, 59);
            this.comboBoxPais.Name = "comboBoxPais";
            this.comboBoxPais.Size = new System.Drawing.Size(235, 28);
            this.comboBoxPais.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Provincia";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.top_wrapper;
            this.bunifuDragControl1.Vertical = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtTelefono);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(18, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 133);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contacto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(16, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 12);
            this.label8.TabIndex = 15;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtTelefono.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefono.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.txtTelefono.BorderThickness = 2;
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefono.isPassword = false;
            this.txtTelefono.Location = new System.Drawing.Point(36, 49);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(235, 44);
            this.txtTelefono.TabIndex = 14;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Telefono";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtNota);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(18, 625);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(663, 155);
            this.groupBox5.TabIndex = 35;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Informacion adicional";
            // 
            // txtNota
            // 
            this.txtNota.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtNota.Location = new System.Drawing.Point(36, 60);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNota.Size = new System.Drawing.Size(582, 72);
            this.txtNota.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Nota";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxGestionInventario);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(350, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 133);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inventario";
            // 
            // comboBoxGestionInventario
            // 
            this.comboBoxGestionInventario.DropDownHeight = 120;
            this.comboBoxGestionInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGestionInventario.FormattingEnabled = true;
            this.comboBoxGestionInventario.IntegralHeight = false;
            this.comboBoxGestionInventario.ItemHeight = 20;
            this.comboBoxGestionInventario.Items.AddRange(new object[] {
            "F.I.F.O",
            "L.I.F.O",
            "Prom. ponderado"});
            this.comboBoxGestionInventario.Location = new System.Drawing.Point(35, 65);
            this.comboBoxGestionInventario.Name = "comboBoxGestionInventario";
            this.comboBoxGestionInventario.Size = new System.Drawing.Size(249, 28);
            this.comboBoxGestionInventario.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(33, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 12);
            this.label11.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Gestion inventario";
            // 
            // FormAlmacenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(701, 904);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxDatosAlmacen);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.top_wrapper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAlmacenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNuevoAlmacen";
            this.Load += new System.EventHandler(this.FormAlmacenes_Load);
            this.top_wrapper.ResumeLayout(false);
            this.top_wrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.groupBoxDatosAlmacen.ResumeLayout(false);
            this.groupBoxDatosAlmacen.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_wrapper;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label labelPanel;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelar;
        private Bunifu.Framework.UI.BunifuFlatButton btnAceptar;
        private System.Windows.Forms.GroupBox groupBoxDatosAlmacen;
        private System.Windows.Forms.Label labelAvisoNombreComercial;
        private System.Windows.Forms.Label labelAvisoRazonSocial;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtResponsable;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNombreAlmacen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelAvisoCIF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAvisoCodigoPostal;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCodigoPostal;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtLocalidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPais;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtProvincia;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTelefono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label10;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtNota;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxGestionInventario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}