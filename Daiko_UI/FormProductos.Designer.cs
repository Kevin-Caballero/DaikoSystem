namespace Daiko_DESKTOP
{
    partial class FormProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            this.top_wrapper = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.labelPanel = new System.Windows.Forms.Label();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAceptar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBoxDatosAlmacen = new System.Windows.Forms.GroupBox();
            this.lblNombreLogo = new System.Windows.Forms.Label();
            this.comboBoxAlmacen = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.txtUrlLogo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnBuscarLogo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtDescripcion = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DatepickerBaja = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label3 = new System.Windows.Forms.Label();
            this.DatepickerAlta = new Bunifu.Framework.UI.BunifuDatepicker();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFamilia = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelAvisoNombreComercial = new System.Windows.Forms.Label();
            this.labelAvisoRazonSocial = new System.Windows.Forms.Label();
            this.txtCodigoInterno = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNombreProducto = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPVP = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtIVA = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPrecioSinIVA = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecioMayorista = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtStock = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label23 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtStockMin = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPedidoMin = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label19 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.top_wrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.groupBoxDatosAlmacen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.top_wrapper.Size = new System.Drawing.Size(1047, 51);
            this.top_wrapper.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1005, 12);
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
            this.labelPanel.Size = new System.Drawing.Size(116, 22);
            this.labelPanel.TabIndex = 1;
            this.labelPanel.Text = "PRODUCTO";
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
            this.btnCancelar.Location = new System.Drawing.Point(541, 798);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Normalcolor = System.Drawing.Color.Red;
            this.btnCancelar.OnHovercolor = System.Drawing.Color.Firebrick;
            this.btnCancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancelar.selected = false;
            this.btnCancelar.Size = new System.Drawing.Size(138, 48);
            this.btnCancelar.TabIndex = 37;
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
            this.btnAceptar.Location = new System.Drawing.Point(361, 798);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Normalcolor = System.Drawing.Color.LimeGreen;
            this.btnAceptar.OnHovercolor = System.Drawing.Color.ForestGreen;
            this.btnAceptar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAceptar.selected = false;
            this.btnAceptar.Size = new System.Drawing.Size(138, 48);
            this.btnAceptar.TabIndex = 36;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAceptar.Textcolor = System.Drawing.Color.White;
            this.btnAceptar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupBoxDatosAlmacen
            // 
            this.groupBoxDatosAlmacen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxDatosAlmacen.Controls.Add(this.lblNombreLogo);
            this.groupBoxDatosAlmacen.Controls.Add(this.comboBoxAlmacen);
            this.groupBoxDatosAlmacen.Controls.Add(this.label24);
            this.groupBoxDatosAlmacen.Controls.Add(this.label25);
            this.groupBoxDatosAlmacen.Controls.Add(this.label5);
            this.groupBoxDatosAlmacen.Controls.Add(this.pictureBoxLogo);
            this.groupBoxDatosAlmacen.Controls.Add(this.txtUrlLogo);
            this.groupBoxDatosAlmacen.Controls.Add(this.btnBuscarLogo);
            this.groupBoxDatosAlmacen.Controls.Add(this.txtDescripcion);
            this.groupBoxDatosAlmacen.Controls.Add(this.label10);
            this.groupBoxDatosAlmacen.Controls.Add(this.label4);
            this.groupBoxDatosAlmacen.Controls.Add(this.DatepickerBaja);
            this.groupBoxDatosAlmacen.Controls.Add(this.label3);
            this.groupBoxDatosAlmacen.Controls.Add(this.DatepickerAlta);
            this.groupBoxDatosAlmacen.Controls.Add(this.comboBoxMarca);
            this.groupBoxDatosAlmacen.Controls.Add(this.label1);
            this.groupBoxDatosAlmacen.Controls.Add(this.label2);
            this.groupBoxDatosAlmacen.Controls.Add(this.comboBoxFamilia);
            this.groupBoxDatosAlmacen.Controls.Add(this.label11);
            this.groupBoxDatosAlmacen.Controls.Add(this.label12);
            this.groupBoxDatosAlmacen.Controls.Add(this.labelAvisoNombreComercial);
            this.groupBoxDatosAlmacen.Controls.Add(this.labelAvisoRazonSocial);
            this.groupBoxDatosAlmacen.Controls.Add(this.txtCodigoInterno);
            this.groupBoxDatosAlmacen.Controls.Add(this.txtNombreProducto);
            this.groupBoxDatosAlmacen.Controls.Add(this.label7);
            this.groupBoxDatosAlmacen.Controls.Add(this.label6);
            this.groupBoxDatosAlmacen.Location = new System.Drawing.Point(33, 60);
            this.groupBoxDatosAlmacen.Name = "groupBoxDatosAlmacen";
            this.groupBoxDatosAlmacen.Size = new System.Drawing.Size(981, 427);
            this.groupBoxDatosAlmacen.TabIndex = 38;
            this.groupBoxDatosAlmacen.TabStop = false;
            this.groupBoxDatosAlmacen.Text = "Datos Producto";
            this.groupBoxDatosAlmacen.Enter += new System.EventHandler(this.groupBoxDatosAlmacen_Enter);
            // 
            // lblNombreLogo
            // 
            this.lblNombreLogo.AutoSize = true;
            this.lblNombreLogo.Location = new System.Drawing.Point(706, 268);
            this.lblNombreLogo.MaximumSize = new System.Drawing.Size(146, 13);
            this.lblNombreLogo.Name = "lblNombreLogo";
            this.lblNombreLogo.Size = new System.Drawing.Size(0, 13);
            this.lblNombreLogo.TabIndex = 38;
            // 
            // comboBoxAlmacen
            // 
            this.comboBoxAlmacen.DropDownHeight = 120;
            this.comboBoxAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAlmacen.FormattingEnabled = true;
            this.comboBoxAlmacen.IntegralHeight = false;
            this.comboBoxAlmacen.ItemHeight = 20;
            this.comboBoxAlmacen.Items.AddRange(new object[] {
            "F.I.F.O",
            "L.I.F.O",
            "Prom. ponderado"});
            this.comboBoxAlmacen.Location = new System.Drawing.Point(468, 149);
            this.comboBoxAlmacen.Name = "comboBoxAlmacen";
            this.comboBoxAlmacen.Size = new System.Drawing.Size(150, 28);
            this.comboBoxAlmacen.TabIndex = 37;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Red;
            this.label24.Location = new System.Drawing.Point(466, 182);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(0, 12);
            this.label24.TabIndex = 36;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(465, 131);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(48, 13);
            this.label25.TabIndex = 35;
            this.label25.Text = "Almacen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(706, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Imagen";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(709, 51);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(234, 214);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // txtUrlLogo
            // 
            this.txtUrlLogo.BackColor = System.Drawing.Color.White;
            this.txtUrlLogo.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtUrlLogo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUrlLogo.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.txtUrlLogo.BorderThickness = 2;
            this.txtUrlLogo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUrlLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrlLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUrlLogo.isPassword = false;
            this.txtUrlLogo.Location = new System.Drawing.Point(753, 317);
            this.txtUrlLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUrlLogo.Name = "txtUrlLogo";
            this.txtUrlLogo.Size = new System.Drawing.Size(190, 47);
            this.txtUrlLogo.TabIndex = 10;
            this.txtUrlLogo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnBuscarLogo
            // 
            this.btnBuscarLogo.Activecolor = System.Drawing.Color.MediumPurple;
            this.btnBuscarLogo.AutoSize = true;
            this.btnBuscarLogo.BackColor = System.Drawing.Color.MediumPurple;
            this.btnBuscarLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarLogo.BorderRadius = 0;
            this.btnBuscarLogo.ButtonText = "";
            this.btnBuscarLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarLogo.DisabledColor = System.Drawing.Color.Gray;
            this.btnBuscarLogo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBuscarLogo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBuscarLogo.Iconimage")));
            this.btnBuscarLogo.Iconimage_right = null;
            this.btnBuscarLogo.Iconimage_right_Selected = null;
            this.btnBuscarLogo.Iconimage_Selected = null;
            this.btnBuscarLogo.IconMarginLeft = 0;
            this.btnBuscarLogo.IconMarginRight = 0;
            this.btnBuscarLogo.IconRightVisible = true;
            this.btnBuscarLogo.IconRightZoom = 0D;
            this.btnBuscarLogo.IconVisible = true;
            this.btnBuscarLogo.IconZoom = 30D;
            this.btnBuscarLogo.IsTab = false;
            this.btnBuscarLogo.Location = new System.Drawing.Point(709, 317);
            this.btnBuscarLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarLogo.Name = "btnBuscarLogo";
            this.btnBuscarLogo.Normalcolor = System.Drawing.Color.MediumPurple;
            this.btnBuscarLogo.OnHovercolor = System.Drawing.Color.BlueViolet;
            this.btnBuscarLogo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBuscarLogo.selected = false;
            this.btnBuscarLogo.Size = new System.Drawing.Size(44, 47);
            this.btnBuscarLogo.TabIndex = 0;
            this.btnBuscarLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarLogo.Textcolor = System.Drawing.Color.White;
            this.btnBuscarLogo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarLogo.Click += new System.EventHandler(this.btnBuscarLogo_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtDescripcion.Location = new System.Drawing.Point(40, 317);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(578, 72);
            this.txtDescripcion.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Descipcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Fecha baja";
            // 
            // DatepickerBaja
            // 
            this.DatepickerBaja.BackColor = System.Drawing.Color.SteelBlue;
            this.DatepickerBaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DatepickerBaja.BorderRadius = 0;
            this.DatepickerBaja.ForeColor = System.Drawing.Color.White;
            this.DatepickerBaja.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DatepickerBaja.FormatCustom = null;
            this.DatepickerBaja.Location = new System.Drawing.Point(369, 229);
            this.DatepickerBaja.Name = "DatepickerBaja";
            this.DatepickerBaja.Size = new System.Drawing.Size(249, 36);
            this.DatepickerBaja.TabIndex = 30;
            this.DatepickerBaja.Value = new System.DateTime(2020, 4, 27, 14, 25, 11, 62);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Fecha alta";
            // 
            // DatepickerAlta
            // 
            this.DatepickerAlta.BackColor = System.Drawing.Color.SteelBlue;
            this.DatepickerAlta.BorderRadius = 0;
            this.DatepickerAlta.ForeColor = System.Drawing.Color.White;
            this.DatepickerAlta.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DatepickerAlta.FormatCustom = null;
            this.DatepickerAlta.Location = new System.Drawing.Point(40, 229);
            this.DatepickerAlta.Name = "DatepickerAlta";
            this.DatepickerAlta.Size = new System.Drawing.Size(249, 36);
            this.DatepickerAlta.TabIndex = 28;
            this.DatepickerAlta.Value = new System.DateTime(2020, 4, 27, 14, 25, 11, 62);
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.DropDownHeight = 120;
            this.comboBoxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.IntegralHeight = false;
            this.comboBoxMarca.ItemHeight = 20;
            this.comboBoxMarca.Items.AddRange(new object[] {
            "F.I.F.O",
            "L.I.F.O",
            "Prom. ponderado"});
            this.comboBoxMarca.Location = new System.Drawing.Point(256, 149);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(150, 28);
            this.comboBoxMarca.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(254, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Marca";
            // 
            // comboBoxFamilia
            // 
            this.comboBoxFamilia.DropDownHeight = 120;
            this.comboBoxFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFamilia.FormattingEnabled = true;
            this.comboBoxFamilia.IntegralHeight = false;
            this.comboBoxFamilia.ItemHeight = 20;
            this.comboBoxFamilia.Items.AddRange(new object[] {
            "F.I.F.O",
            "L.I.F.O",
            "Prom. ponderado"});
            this.comboBoxFamilia.Location = new System.Drawing.Point(40, 149);
            this.comboBoxFamilia.Name = "comboBoxFamilia";
            this.comboBoxFamilia.Size = new System.Drawing.Size(150, 28);
            this.comboBoxFamilia.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(38, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 12);
            this.label11.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Familia";
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
            // txtCodigoInterno
            // 
            this.txtCodigoInterno.BackColor = System.Drawing.Color.White;
            this.txtCodigoInterno.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtCodigoInterno.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigoInterno.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.txtCodigoInterno.BorderThickness = 2;
            this.txtCodigoInterno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoInterno.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCodigoInterno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigoInterno.isPassword = false;
            this.txtCodigoInterno.Location = new System.Drawing.Point(369, 51);
            this.txtCodigoInterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoInterno.Name = "txtCodigoInterno";
            this.txtCodigoInterno.Size = new System.Drawing.Size(251, 44);
            this.txtCodigoInterno.TabIndex = 4;
            this.txtCodigoInterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BackColor = System.Drawing.Color.White;
            this.txtNombreProducto.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtNombreProducto.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombreProducto.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.txtNombreProducto.BorderThickness = 2;
            this.txtNombreProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombreProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombreProducto.isPassword = false;
            this.txtNombreProducto.Location = new System.Drawing.Point(38, 51);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(251, 44);
            this.txtNombreProducto.TabIndex = 3;
            this.txtNombreProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nombre producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Codigo interno";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPVP);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtIVA);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtPrecioSinIVA);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPrecioMayorista);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(33, 528);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(981, 109);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Precios";
            // 
            // txtPVP
            // 
            this.txtPVP.BackColor = System.Drawing.Color.White;
            this.txtPVP.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtPVP.BorderColorIdle = System.Drawing.Color.CornflowerBlue;
            this.txtPVP.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.txtPVP.BorderThickness = 2;
            this.txtPVP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPVP.Enabled = false;
            this.txtPVP.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPVP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPVP.isPassword = false;
            this.txtPVP.Location = new System.Drawing.Point(768, 42);
            this.txtPVP.Margin = new System.Windows.Forms.Padding(4);
            this.txtPVP.Name = "txtPVP";
            this.txtPVP.Size = new System.Drawing.Size(175, 39);
            this.txtPVP.TabIndex = 19;
            this.txtPVP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(765, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "PVP";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(515, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 12);
            this.label15.TabIndex = 17;
            // 
            // txtIVA
            // 
            this.txtIVA.BackColor = System.Drawing.Color.White;
            this.txtIVA.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtIVA.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIVA.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.txtIVA.BorderThickness = 2;
            this.txtIVA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIVA.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIVA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIVA.isPassword = false;
            this.txtIVA.Location = new System.Drawing.Point(515, 42);
            this.txtIVA.Margin = new System.Windows.Forms.Padding(4);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(175, 39);
            this.txtIVA.TabIndex = 16;
            this.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIVA.OnValueChanged += new System.EventHandler(this.txtIVA_OnValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(512, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "IVA";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(266, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 12);
            this.label13.TabIndex = 14;
            // 
            // txtPrecioSinIVA
            // 
            this.txtPrecioSinIVA.BackColor = System.Drawing.Color.White;
            this.txtPrecioSinIVA.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtPrecioSinIVA.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecioSinIVA.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.txtPrecioSinIVA.BorderThickness = 2;
            this.txtPrecioSinIVA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecioSinIVA.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrecioSinIVA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecioSinIVA.isPassword = false;
            this.txtPrecioSinIVA.Location = new System.Drawing.Point(266, 42);
            this.txtPrecioSinIVA.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioSinIVA.Name = "txtPrecioSinIVA";
            this.txtPrecioSinIVA.Size = new System.Drawing.Size(175, 39);
            this.txtPrecioSinIVA.TabIndex = 13;
            this.txtPrecioSinIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrecioSinIVA.OnValueChanged += new System.EventHandler(this.txtPrecioSinIVA_OnValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(263, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Precio sin IVA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(21, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 12);
            this.label8.TabIndex = 11;
            // 
            // txtPrecioMayorista
            // 
            this.txtPrecioMayorista.BackColor = System.Drawing.Color.White;
            this.txtPrecioMayorista.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtPrecioMayorista.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecioMayorista.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.txtPrecioMayorista.BorderThickness = 2;
            this.txtPrecioMayorista.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecioMayorista.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrecioMayorista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecioMayorista.isPassword = false;
            this.txtPrecioMayorista.Location = new System.Drawing.Point(21, 42);
            this.txtPrecioMayorista.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioMayorista.Name = "txtPrecioMayorista";
            this.txtPrecioMayorista.Size = new System.Drawing.Size(175, 39);
            this.txtPrecioMayorista.TabIndex = 10;
            this.txtPrecioMayorista.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Precio mayorista";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.txtStock);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.txtStockMin);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtPedidoMin);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Location = new System.Drawing.Point(33, 664);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(981, 105);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(517, 83);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 12);
            this.label22.TabIndex = 20;
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.White;
            this.txtStock.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtStock.BorderColorIdle = System.Drawing.Color.CornflowerBlue;
            this.txtStock.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.txtStock.BorderThickness = 2;
            this.txtStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStock.Enabled = false;
            this.txtStock.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStock.isPassword = false;
            this.txtStock.Location = new System.Drawing.Point(517, 39);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(175, 39);
            this.txtStock.TabIndex = 19;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(514, 22);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 13);
            this.label23.TabIndex = 18;
            this.label23.Text = "Stock";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(268, 83);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 12);
            this.label20.TabIndex = 17;
            // 
            // txtStockMin
            // 
            this.txtStockMin.BackColor = System.Drawing.Color.White;
            this.txtStockMin.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtStockMin.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStockMin.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.txtStockMin.BorderThickness = 2;
            this.txtStockMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStockMin.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStockMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStockMin.isPassword = false;
            this.txtStockMin.Location = new System.Drawing.Point(268, 39);
            this.txtStockMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtStockMin.Name = "txtStockMin";
            this.txtStockMin.Size = new System.Drawing.Size(175, 39);
            this.txtStockMin.TabIndex = 16;
            this.txtStockMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(265, 22);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(70, 13);
            this.label21.TabIndex = 15;
            this.label21.Text = "Stock minimo";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(21, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 12);
            this.label18.TabIndex = 14;
            // 
            // txtPedidoMin
            // 
            this.txtPedidoMin.BackColor = System.Drawing.Color.White;
            this.txtPedidoMin.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtPedidoMin.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPedidoMin.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.txtPedidoMin.BorderThickness = 2;
            this.txtPedidoMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPedidoMin.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPedidoMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPedidoMin.isPassword = false;
            this.txtPedidoMin.Location = new System.Drawing.Point(21, 39);
            this.txtPedidoMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtPedidoMin.Name = "txtPedidoMin";
            this.txtPedidoMin.Size = new System.Drawing.Size(175, 39);
            this.txtPedidoMin.TabIndex = 13;
            this.txtPedidoMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "Pedido minimo";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.top_wrapper;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1047, 870);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxDatosAlmacen);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.top_wrapper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProductos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            this.top_wrapper.ResumeLayout(false);
            this.top_wrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.groupBoxDatosAlmacen.ResumeLayout(false);
            this.groupBoxDatosAlmacen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCodigoInterno;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNombreProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuDatepicker DatepickerAlta;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFamilia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDatepicker DatepickerBaja;
        private System.Windows.Forms.Label label3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtDescripcion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUrlLogo;
        private Bunifu.Framework.UI.BunifuFlatButton btnBuscarLogo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPVP;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtIVA;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPrecioSinIVA;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPrecioMayorista;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label18;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPedidoMin;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStock;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label20;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStockMin;
        private System.Windows.Forms.Label label21;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.ComboBox comboBoxAlmacen;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblNombreLogo;
    }
}