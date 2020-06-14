namespace Daiko_DESKTOP
{
    partial class FormEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpresa));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.top_wrapper = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.labelPanel = new System.Windows.Forms.Label();
            this.btnNuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnModificar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.groupBoxDatosEmpresa = new System.Windows.Forms.GroupBox();
            this.labelAvisoDireccionFiscal = new System.Windows.Forms.Label();
            this.labelAvisoCodigoPostal = new System.Windows.Forms.Label();
            this.labelAvisoCIF = new System.Windows.Forms.Label();
            this.labelAvisoNombreComercial = new System.Windows.Forms.Label();
            this.labelAvisoRazonSocial = new System.Windows.Forms.Label();
            this.txtDireccionFiscal = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtCodigoPostal = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtCif = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNombreComercial = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtRazonSocial = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxContacto = new System.Windows.Forms.GroupBox();
            this.labelAvisoFax = new System.Windows.Forms.Label();
            this.labelAvisoTelefono = new System.Windows.Forms.Label();
            this.txtFax = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtTelefono = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.groupBoxLogo = new System.Windows.Forms.GroupBox();
            this.lblNombreLogo = new System.Windows.Forms.Label();
            this.txtUrlLogo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnBuscarLogo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAceptar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.top_wrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.groupBoxDatosEmpresa.SuspendLayout();
            this.groupBoxContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.groupBoxLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.top_wrapper;
            this.bunifuDragControl1.Vertical = true;
            // 
            // top_wrapper
            // 
            this.top_wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.top_wrapper.Controls.Add(this.btnClose);
            this.top_wrapper.Controls.Add(this.labelPanel);
            this.top_wrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_wrapper.Location = new System.Drawing.Point(0, 0);
            this.top_wrapper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.top_wrapper.Name = "top_wrapper";
            this.top_wrapper.Size = new System.Drawing.Size(701, 51);
            this.top_wrapper.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(658, 12);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 31);
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
            this.labelPanel.Size = new System.Drawing.Size(227, 22);
            this.labelPanel.TabIndex = 1;
            this.labelPanel.Text = "CONFIGURAR EMPRESA";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Activecolor = System.Drawing.Color.DarkBlue;
            this.btnNuevo.BackColor = System.Drawing.Color.MediumBlue;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.BorderRadius = 0;
            this.btnNuevo.ButtonText = "Nuevo";
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.DisabledColor = System.Drawing.Color.CornflowerBlue;
            this.btnNuevo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNuevo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Iconimage")));
            this.btnNuevo.Iconimage_right = null;
            this.btnNuevo.Iconimage_right_Selected = null;
            this.btnNuevo.Iconimage_Selected = null;
            this.btnNuevo.IconMarginLeft = 0;
            this.btnNuevo.IconMarginRight = 0;
            this.btnNuevo.IconRightVisible = true;
            this.btnNuevo.IconRightZoom = 0D;
            this.btnNuevo.IconVisible = true;
            this.btnNuevo.IconZoom = 50D;
            this.btnNuevo.IsTab = false;
            this.btnNuevo.Location = new System.Drawing.Point(16, 63);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Normalcolor = System.Drawing.Color.MediumBlue;
            this.btnNuevo.OnHovercolor = System.Drawing.Color.DarkBlue;
            this.btnNuevo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevo.selected = false;
            this.btnNuevo.Size = new System.Drawing.Size(138, 47);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevo.Textcolor = System.Drawing.Color.White;
            this.btnNuevo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Activecolor = System.Drawing.Color.DarkOrange;
            this.btnModificar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.BorderRadius = 0;
            this.btnModificar.ButtonText = "Modificar";
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.DisabledColor = System.Drawing.Color.BurlyWood;
            this.btnModificar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnModificar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnModificar.Iconimage")));
            this.btnModificar.Iconimage_right = null;
            this.btnModificar.Iconimage_right_Selected = null;
            this.btnModificar.Iconimage_Selected = null;
            this.btnModificar.IconMarginLeft = 0;
            this.btnModificar.IconMarginRight = 0;
            this.btnModificar.IconRightVisible = true;
            this.btnModificar.IconRightZoom = 0D;
            this.btnModificar.IconVisible = true;
            this.btnModificar.IconZoom = 50D;
            this.btnModificar.IsTab = false;
            this.btnModificar.Location = new System.Drawing.Point(160, 63);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Normalcolor = System.Drawing.Color.DarkOrange;
            this.btnModificar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.btnModificar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnModificar.selected = false;
            this.btnModificar.Size = new System.Drawing.Size(138, 47);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModificar.Textcolor = System.Drawing.Color.White;
            this.btnModificar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(18, 111);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(665, 41);
            this.bunifuSeparator1.TabIndex = 24;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // groupBoxDatosEmpresa
            // 
            this.groupBoxDatosEmpresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxDatosEmpresa.Controls.Add(this.labelAvisoDireccionFiscal);
            this.groupBoxDatosEmpresa.Controls.Add(this.labelAvisoCodigoPostal);
            this.groupBoxDatosEmpresa.Controls.Add(this.labelAvisoCIF);
            this.groupBoxDatosEmpresa.Controls.Add(this.labelAvisoNombreComercial);
            this.groupBoxDatosEmpresa.Controls.Add(this.labelAvisoRazonSocial);
            this.groupBoxDatosEmpresa.Controls.Add(this.txtDireccionFiscal);
            this.groupBoxDatosEmpresa.Controls.Add(this.txtCodigoPostal);
            this.groupBoxDatosEmpresa.Controls.Add(this.txtCif);
            this.groupBoxDatosEmpresa.Controls.Add(this.txtNombreComercial);
            this.groupBoxDatosEmpresa.Controls.Add(this.txtRazonSocial);
            this.groupBoxDatosEmpresa.Controls.Add(this.label7);
            this.groupBoxDatosEmpresa.Controls.Add(this.label6);
            this.groupBoxDatosEmpresa.Controls.Add(this.label5);
            this.groupBoxDatosEmpresa.Controls.Add(this.label4);
            this.groupBoxDatosEmpresa.Controls.Add(this.label3);
            this.groupBoxDatosEmpresa.Enabled = false;
            this.groupBoxDatosEmpresa.Location = new System.Drawing.Point(18, 151);
            this.groupBoxDatosEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDatosEmpresa.Name = "groupBoxDatosEmpresa";
            this.groupBoxDatosEmpresa.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDatosEmpresa.Size = new System.Drawing.Size(665, 252);
            this.groupBoxDatosEmpresa.TabIndex = 25;
            this.groupBoxDatosEmpresa.TabStop = false;
            this.groupBoxDatosEmpresa.Text = "Datos Empresa";
            // 
            // labelAvisoDireccionFiscal
            // 
            this.labelAvisoDireccionFiscal.AutoSize = true;
            this.labelAvisoDireccionFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvisoDireccionFiscal.ForeColor = System.Drawing.Color.Red;
            this.labelAvisoDireccionFiscal.Location = new System.Drawing.Point(446, 219);
            this.labelAvisoDireccionFiscal.Name = "labelAvisoDireccionFiscal";
            this.labelAvisoDireccionFiscal.Size = new System.Drawing.Size(0, 12);
            this.labelAvisoDireccionFiscal.TabIndex = 12;
            // 
            // labelAvisoCodigoPostal
            // 
            this.labelAvisoCodigoPostal.AutoSize = true;
            this.labelAvisoCodigoPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvisoCodigoPostal.ForeColor = System.Drawing.Color.Red;
            this.labelAvisoCodigoPostal.Location = new System.Drawing.Point(257, 219);
            this.labelAvisoCodigoPostal.Name = "labelAvisoCodigoPostal";
            this.labelAvisoCodigoPostal.Size = new System.Drawing.Size(0, 12);
            this.labelAvisoCodigoPostal.TabIndex = 11;
            // 
            // labelAvisoCIF
            // 
            this.labelAvisoCIF.AutoSize = true;
            this.labelAvisoCIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvisoCIF.ForeColor = System.Drawing.Color.Red;
            this.labelAvisoCIF.Location = new System.Drawing.Point(38, 219);
            this.labelAvisoCIF.Name = "labelAvisoCIF";
            this.labelAvisoCIF.Size = new System.Drawing.Size(0, 12);
            this.labelAvisoCIF.TabIndex = 10;
            // 
            // labelAvisoNombreComercial
            // 
            this.labelAvisoNombreComercial.AutoSize = true;
            this.labelAvisoNombreComercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvisoNombreComercial.ForeColor = System.Drawing.Color.Red;
            this.labelAvisoNombreComercial.Location = new System.Drawing.Point(369, 106);
            this.labelAvisoNombreComercial.Name = "labelAvisoNombreComercial";
            this.labelAvisoNombreComercial.Size = new System.Drawing.Size(0, 12);
            this.labelAvisoNombreComercial.TabIndex = 9;
            // 
            // labelAvisoRazonSocial
            // 
            this.labelAvisoRazonSocial.AutoSize = true;
            this.labelAvisoRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvisoRazonSocial.ForeColor = System.Drawing.Color.Red;
            this.labelAvisoRazonSocial.Location = new System.Drawing.Point(38, 106);
            this.labelAvisoRazonSocial.Name = "labelAvisoRazonSocial";
            this.labelAvisoRazonSocial.Size = new System.Drawing.Size(0, 12);
            this.labelAvisoRazonSocial.TabIndex = 8;
            // 
            // txtDireccionFiscal
            // 
            this.txtDireccionFiscal.BackColor = System.Drawing.Color.White;
            this.txtDireccionFiscal.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtDireccionFiscal.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDireccionFiscal.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.txtDireccionFiscal.BorderThickness = 2;
            this.txtDireccionFiscal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccionFiscal.Enabled = false;
            this.txtDireccionFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionFiscal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDireccionFiscal.isPassword = false;
            this.txtDireccionFiscal.Location = new System.Drawing.Point(447, 170);
            this.txtDireccionFiscal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDireccionFiscal.Name = "txtDireccionFiscal";
            this.txtDireccionFiscal.Size = new System.Drawing.Size(173, 44);
            this.txtDireccionFiscal.TabIndex = 7;
            this.txtDireccionFiscal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDireccionFiscal.OnValueChanged += new System.EventHandler(this.txtDireccionFiscal_OnValueChanged);
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.BackColor = System.Drawing.Color.White;
            this.txtCodigoPostal.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtCodigoPostal.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigoPostal.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.txtCodigoPostal.BorderThickness = 2;
            this.txtCodigoPostal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoPostal.Enabled = false;
            this.txtCodigoPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPostal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigoPostal.isPassword = false;
            this.txtCodigoPostal.Location = new System.Drawing.Point(259, 170);
            this.txtCodigoPostal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(141, 44);
            this.txtCodigoPostal.TabIndex = 6;
            this.txtCodigoPostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigoPostal.OnValueChanged += new System.EventHandler(this.txtCodigoPostal_OnValueChanged);
            // 
            // txtCif
            // 
            this.txtCif.BackColor = System.Drawing.Color.White;
            this.txtCif.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtCif.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCif.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.txtCif.BorderThickness = 2;
            this.txtCif.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCif.Enabled = false;
            this.txtCif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCif.isPassword = false;
            this.txtCif.Location = new System.Drawing.Point(38, 170);
            this.txtCif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCif.Name = "txtCif";
            this.txtCif.Size = new System.Drawing.Size(173, 44);
            this.txtCif.TabIndex = 5;
            this.txtCif.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCif.OnValueChanged += new System.EventHandler(this.txtCif_OnValueChanged);
            // 
            // txtNombreComercial
            // 
            this.txtNombreComercial.BackColor = System.Drawing.Color.White;
            this.txtNombreComercial.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtNombreComercial.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombreComercial.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.txtNombreComercial.BorderThickness = 2;
            this.txtNombreComercial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreComercial.Enabled = false;
            this.txtNombreComercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreComercial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombreComercial.isPassword = false;
            this.txtNombreComercial.Location = new System.Drawing.Point(369, 60);
            this.txtNombreComercial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreComercial.Name = "txtNombreComercial";
            this.txtNombreComercial.Size = new System.Drawing.Size(250, 44);
            this.txtNombreComercial.TabIndex = 4;
            this.txtNombreComercial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreComercial.OnValueChanged += new System.EventHandler(this.txtNombreComercial_OnValueChanged);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.Color.White;
            this.txtRazonSocial.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtRazonSocial.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRazonSocial.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.txtRazonSocial.BorderThickness = 2;
            this.txtRazonSocial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRazonSocial.Enabled = false;
            this.txtRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRazonSocial.isPassword = false;
            this.txtRazonSocial.Location = new System.Drawing.Point(38, 60);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(235, 44);
            this.txtRazonSocial.TabIndex = 3;
            this.txtRazonSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRazonSocial.OnValueChanged += new System.EventHandler(this.txtRazonSocial_OnValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Razon social";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nombre comercial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Codigo postal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Direccion fiscal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "CIF";
            // 
            // groupBoxContacto
            // 
            this.groupBoxContacto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxContacto.Controls.Add(this.labelAvisoFax);
            this.groupBoxContacto.Controls.Add(this.labelAvisoTelefono);
            this.groupBoxContacto.Controls.Add(this.txtFax);
            this.groupBoxContacto.Controls.Add(this.txtTelefono);
            this.groupBoxContacto.Controls.Add(this.label2);
            this.groupBoxContacto.Controls.Add(this.label1);
            this.groupBoxContacto.Enabled = false;
            this.groupBoxContacto.Location = new System.Drawing.Point(18, 437);
            this.groupBoxContacto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxContacto.Name = "groupBoxContacto";
            this.groupBoxContacto.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxContacto.Size = new System.Drawing.Size(665, 125);
            this.groupBoxContacto.TabIndex = 26;
            this.groupBoxContacto.TabStop = false;
            this.groupBoxContacto.Text = "Contacto";
            // 
            // labelAvisoFax
            // 
            this.labelAvisoFax.AutoSize = true;
            this.labelAvisoFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvisoFax.ForeColor = System.Drawing.Color.Red;
            this.labelAvisoFax.Location = new System.Drawing.Point(369, 97);
            this.labelAvisoFax.Name = "labelAvisoFax";
            this.labelAvisoFax.Size = new System.Drawing.Size(0, 12);
            this.labelAvisoFax.TabIndex = 13;
            // 
            // labelAvisoTelefono
            // 
            this.labelAvisoTelefono.AutoSize = true;
            this.labelAvisoTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvisoTelefono.ForeColor = System.Drawing.Color.Red;
            this.labelAvisoTelefono.Location = new System.Drawing.Point(34, 97);
            this.labelAvisoTelefono.Name = "labelAvisoTelefono";
            this.labelAvisoTelefono.Size = new System.Drawing.Size(0, 12);
            this.labelAvisoTelefono.TabIndex = 10;
            // 
            // txtFax
            // 
            this.txtFax.BackColor = System.Drawing.Color.White;
            this.txtFax.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtFax.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFax.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.txtFax.BorderThickness = 2;
            this.txtFax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFax.Enabled = false;
            this.txtFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFax.isPassword = false;
            this.txtFax.Location = new System.Drawing.Point(369, 46);
            this.txtFax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(250, 44);
            this.txtFax.TabIndex = 9;
            this.txtFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFax.OnValueChanged += new System.EventHandler(this.txtFax_OnValueChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtTelefono.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefono.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.txtTelefono.BorderThickness = 2;
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefono.isPassword = false;
            this.txtTelefono.Location = new System.Drawing.Point(36, 46);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(237, 44);
            this.txtTelefono.TabIndex = 8;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefono.OnValueChanged += new System.EventHandler(this.txtTelefono_OnValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fax";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telefono";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Enabled = false;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(437, 28);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(183, 118);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // groupBoxLogo
            // 
            this.groupBoxLogo.Controls.Add(this.lblNombreLogo);
            this.groupBoxLogo.Controls.Add(this.txtUrlLogo);
            this.groupBoxLogo.Controls.Add(this.pictureBoxLogo);
            this.groupBoxLogo.Controls.Add(this.btnBuscarLogo);
            this.groupBoxLogo.Enabled = false;
            this.groupBoxLogo.Location = new System.Drawing.Point(18, 597);
            this.groupBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxLogo.Name = "groupBoxLogo";
            this.groupBoxLogo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxLogo.Size = new System.Drawing.Size(665, 184);
            this.groupBoxLogo.TabIndex = 27;
            this.groupBoxLogo.TabStop = false;
            this.groupBoxLogo.Text = "Logo";
            this.groupBoxLogo.Enter += new System.EventHandler(this.groupBoxLogo_Enter);
            // 
            // lblNombreLogo
            // 
            this.lblNombreLogo.AutoSize = true;
            this.lblNombreLogo.Location = new System.Drawing.Point(472, 150);
            this.lblNombreLogo.MaximumSize = new System.Drawing.Size(146, 13);
            this.lblNombreLogo.Name = "lblNombreLogo";
            this.lblNombreLogo.Size = new System.Drawing.Size(0, 13);
            this.lblNombreLogo.TabIndex = 11;
            // 
            // txtUrlLogo
            // 
            this.txtUrlLogo.BackColor = System.Drawing.Color.White;
            this.txtUrlLogo.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtUrlLogo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUrlLogo.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.txtUrlLogo.BorderThickness = 2;
            this.txtUrlLogo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUrlLogo.Enabled = false;
            this.txtUrlLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrlLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUrlLogo.isPassword = false;
            this.txtUrlLogo.Location = new System.Drawing.Point(90, 106);
            this.txtUrlLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUrlLogo.Name = "txtUrlLogo";
            this.txtUrlLogo.Size = new System.Drawing.Size(310, 44);
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
            this.btnBuscarLogo.Enabled = false;
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
            this.btnBuscarLogo.Location = new System.Drawing.Point(36, 104);
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
            this.btnCancelar.Enabled = false;
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
            this.btnCancelar.Location = new System.Drawing.Point(367, 827);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Normalcolor = System.Drawing.Color.Red;
            this.btnCancelar.OnHovercolor = System.Drawing.Color.Firebrick;
            this.btnCancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancelar.selected = false;
            this.btnCancelar.Size = new System.Drawing.Size(138, 47);
            this.btnCancelar.TabIndex = 23;
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
            this.btnAceptar.Enabled = false;
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
            this.btnAceptar.Location = new System.Drawing.Point(187, 827);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Normalcolor = System.Drawing.Color.LimeGreen;
            this.btnAceptar.OnHovercolor = System.Drawing.Color.ForestGreen;
            this.btnAceptar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAceptar.selected = false;
            this.btnAceptar.Size = new System.Drawing.Size(138, 47);
            this.btnAceptar.TabIndex = 22;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAceptar.Textcolor = System.Drawing.Color.White;
            this.btnAceptar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // FormEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(701, 904);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.groupBoxDatosEmpresa);
            this.Controls.Add(this.groupBoxContacto);
            this.Controls.Add(this.groupBoxLogo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.top_wrapper);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConfiguracionEmpresa";
            this.top_wrapper.ResumeLayout(false);
            this.top_wrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.groupBoxDatosEmpresa.ResumeLayout(false);
            this.groupBoxDatosEmpresa.PerformLayout();
            this.groupBoxContacto.ResumeLayout(false);
            this.groupBoxContacto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.groupBoxLogo.ResumeLayout(false);
            this.groupBoxLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevo;
        private Bunifu.Framework.UI.BunifuFlatButton btnModificar;
        private System.Windows.Forms.Panel top_wrapper;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label labelPanel;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.GroupBox groupBoxDatosEmpresa;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDireccionFiscal;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCodigoPostal;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCif;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNombreComercial;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtRazonSocial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxContacto;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFax;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.GroupBox groupBoxLogo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUrlLogo;
        private Bunifu.Framework.UI.BunifuFlatButton btnBuscarLogo;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelar;
        private Bunifu.Framework.UI.BunifuFlatButton btnAceptar;
        private System.Windows.Forms.Label lblNombreLogo;
        private System.Windows.Forms.Label labelAvisoRazonSocial;
        private System.Windows.Forms.Label labelAvisoNombreComercial;
        private System.Windows.Forms.Label labelAvisoCIF;
        private System.Windows.Forms.Label labelAvisoCodigoPostal;
        private System.Windows.Forms.Label labelAvisoDireccionFiscal;
        private System.Windows.Forms.Label labelAvisoTelefono;
        private System.Windows.Forms.Label labelAvisoFax;
    }
}