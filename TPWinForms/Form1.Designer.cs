namespace TPWinForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbxDetalles = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.flechitaIzq = new System.Windows.Forms.Button();
            this.flechitaD = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAlter = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblFiltroPro = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cbxCampo = new System.Windows.Forms.ComboBox();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.txtFiltrarA = new System.Windows.Forms.TextBox();
            this.btnBuscarFiltro = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panelSubMenuAgregar = new System.Windows.Forms.Panel();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.brnMaximize = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grillaArticulos = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gbxDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            this.panelSubMenuAgregar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaArticulos)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDetalles
            // 
            this.gbxDetalles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxDetalles.Controls.Add(this.label2);
            this.gbxDetalles.Controls.Add(this.lblCantidad);
            this.gbxDetalles.Controls.Add(this.lblImagen);
            this.gbxDetalles.Controls.Add(this.flechitaIzq);
            this.gbxDetalles.Controls.Add(this.flechitaD);
            this.gbxDetalles.Controls.Add(this.btnDelete);
            this.gbxDetalles.Controls.Add(this.btnAlter);
            this.gbxDetalles.Controls.Add(this.btnCerrar);
            this.gbxDetalles.Controls.Add(this.pbxImagen);
            this.gbxDetalles.Controls.Add(this.lblDescripcion);
            this.gbxDetalles.Controls.Add(this.lblNombre);
            this.gbxDetalles.Location = new System.Drawing.Point(939, 145);
            this.gbxDetalles.Name = "gbxDetalles";
            this.gbxDetalles.Size = new System.Drawing.Size(411, 443);
            this.gbxDetalles.TabIndex = 3;
            this.gbxDetalles.TabStop = false;
            this.gbxDetalles.Text = "Detalles";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "/";
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(205, 379);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(89, 13);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "cantidad de fotos";
            // 
            // lblImagen
            // 
            this.lblImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(178, 379);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(57, 13);
            this.lblImagen.TabIndex = 8;
            this.lblImagen.Text = "foto actual";
            // 
            // flechitaIzq
            // 
            this.flechitaIzq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flechitaIzq.Image = global::TPWinForms.Properties.Resources.flechitaIzq;
            this.flechitaIzq.Location = new System.Drawing.Point(8, 202);
            this.flechitaIzq.Name = "flechitaIzq";
            this.flechitaIzq.Size = new System.Drawing.Size(57, 105);
            this.flechitaIzq.TabIndex = 7;
            this.flechitaIzq.UseVisualStyleBackColor = true;
            this.flechitaIzq.Click += new System.EventHandler(this.flechitaIzq_Click);
            // 
            // flechitaD
            // 
            this.flechitaD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flechitaD.Image = global::TPWinForms.Properties.Resources.flechita1;
            this.flechitaD.Location = new System.Drawing.Point(348, 202);
            this.flechitaD.Name = "flechitaD";
            this.flechitaD.Size = new System.Drawing.Size(57, 105);
            this.flechitaD.TabIndex = 6;
            this.flechitaD.UseVisualStyleBackColor = true;
            this.flechitaD.Click += new System.EventHandler(this.flechitaD_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Location = new System.Drawing.Point(157, 402);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAlter
            // 
            this.btnAlter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlter.Location = new System.Drawing.Point(267, 402);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(75, 23);
            this.btnAlter.TabIndex = 4;
            this.btnAlter.Text = "Modificar";
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCerrar.Location = new System.Drawing.Point(42, 402);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pbxImagen
            // 
            this.pbxImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxImagen.Location = new System.Drawing.Point(71, 133);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(271, 241);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 2;
            this.pbxImagen.TabStop = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(169, 102);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(178, 69);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // reset
            // 
            this.reset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reset.Location = new System.Drawing.Point(466, 564);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(156, 23);
            this.reset.TabIndex = 6;
            this.reset.Text = "Actualizar Lista";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.BackColor = System.Drawing.SystemColors.Window;
            this.txtFiltro.Location = new System.Drawing.Point(183, 45);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(150, 20);
            this.txtFiltro.TabIndex = 7;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFiltro.Location = new System.Drawing.Point(41, 45);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(136, 17);
            this.lblFiltro.TabIndex = 8;
            this.lblFiltro.Text = "Busqueda rápida:";
            // 
            // lblCampo
            // 
            this.lblCampo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCampo.AutoSize = true;
            this.lblCampo.ForeColor = System.Drawing.Color.White;
            this.lblCampo.Location = new System.Drawing.Point(3, 6);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(43, 13);
            this.lblCampo.TabIndex = 10;
            this.lblCampo.Text = "Campo:";
            // 
            // lblFiltroPro
            // 
            this.lblFiltroPro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFiltroPro.AutoSize = true;
            this.lblFiltroPro.ForeColor = System.Drawing.Color.White;
            this.lblFiltroPro.Location = new System.Drawing.Point(68, 60);
            this.lblFiltroPro.Name = "lblFiltroPro";
            this.lblFiltroPro.Size = new System.Drawing.Size(32, 13);
            this.lblFiltroPro.TabIndex = 11;
            this.lblFiltroPro.Text = "Filtro:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.ForeColor = System.Drawing.Color.White;
            this.lblCriterio.Location = new System.Drawing.Point(4, 27);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(42, 13);
            this.lblCriterio.TabIndex = 12;
            this.lblCriterio.Text = "Criterio:";
            // 
            // cbxCampo
            // 
            this.cbxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCampo.FormattingEnabled = true;
            this.cbxCampo.Location = new System.Drawing.Point(59, 3);
            this.cbxCampo.Name = "cbxCampo";
            this.cbxCampo.Size = new System.Drawing.Size(121, 21);
            this.cbxCampo.TabIndex = 13;
            this.cbxCampo.SelectedIndexChanged += new System.EventHandler(this.cbxCampo_SelectedIndexChanged);
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Location = new System.Drawing.Point(59, 24);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(121, 21);
            this.cbxCriterio.TabIndex = 14;
            // 
            // txtFiltrarA
            // 
            this.txtFiltrarA.Location = new System.Drawing.Point(0, 76);
            this.txtFiltrarA.Name = "txtFiltrarA";
            this.txtFiltrarA.Size = new System.Drawing.Size(180, 20);
            this.txtFiltrarA.TabIndex = 15;
            // 
            // btnBuscarFiltro
            // 
            this.btnBuscarFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.btnBuscarFiltro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBuscarFiltro.FlatAppearance.BorderSize = 0;
            this.btnBuscarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFiltro.ForeColor = System.Drawing.Color.White;
            this.btnBuscarFiltro.Location = new System.Drawing.Point(0, 113);
            this.btnBuscarFiltro.Name = "btnBuscarFiltro";
            this.btnBuscarFiltro.Size = new System.Drawing.Size(180, 28);
            this.btnBuscarFiltro.TabIndex = 16;
            this.btnBuscarFiltro.Text = "Buscar";
            this.btnBuscarFiltro.UseVisualStyleBackColor = false;
            this.btnBuscarFiltro.Click += new System.EventHandler(this.btnBuscarFiltro_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.panelSubMenu);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.panelSubMenuAgregar);
            this.panel1.Controls.Add(this.btnAboutUs);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 669);
            this.panel1.TabIndex = 17;
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.panelSubMenu.Controls.Add(this.btnBuscarFiltro);
            this.panelSubMenu.Controls.Add(this.lblCampo);
            this.panelSubMenu.Controls.Add(this.txtFiltrarA);
            this.panelSubMenu.Controls.Add(this.lblFiltroPro);
            this.panelSubMenu.Controls.Add(this.cbxCampo);
            this.panelSubMenu.Controls.Add(this.cbxCriterio);
            this.panelSubMenu.Controls.Add(this.lblCriterio);
            this.panelSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenu.Location = new System.Drawing.Point(0, 342);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(180, 141);
            this.panelSubMenu.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Gainsboro;
            this.button4.Image = global::TPWinForms.Properties.Resources.icons8_search_25px;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 282);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(180, 60);
            this.button4.TabIndex = 7;
            this.button4.Text = "  Buscar Articulo";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panelSubMenuAgregar
            // 
            this.panelSubMenuAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.panelSubMenuAgregar.Controls.Add(this.btnAgregarCategoria);
            this.panelSubMenuAgregar.Controls.Add(this.btnAgregarMarca);
            this.panelSubMenuAgregar.Controls.Add(this.btnAgregarArticulo);
            this.panelSubMenuAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuAgregar.Location = new System.Drawing.Point(0, 160);
            this.panelSubMenuAgregar.Name = "panelSubMenuAgregar";
            this.panelSubMenuAgregar.Size = new System.Drawing.Size(180, 122);
            this.panelSubMenuAgregar.TabIndex = 5;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarCategoria.FlatAppearance.BorderSize = 0;
            this.btnAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCategoria.ForeColor = System.Drawing.Color.LightGray;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(0, 80);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAgregarCategoria.Size = new System.Drawing.Size(180, 40);
            this.btnAgregarCategoria.TabIndex = 6;
            this.btnAgregarCategoria.Text = "Categoria";
            this.btnAgregarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarMarca.FlatAppearance.BorderSize = 0;
            this.btnAgregarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMarca.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAgregarMarca.Location = new System.Drawing.Point(0, 40);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAgregarMarca.Size = new System.Drawing.Size(180, 40);
            this.btnAgregarMarca.TabIndex = 1;
            this.btnAgregarMarca.Text = "Marca";
            this.btnAgregarMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarArticulo.FlatAppearance.BorderSize = 0;
            this.btnAgregarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarArticulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAgregarArticulo.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAgregarArticulo.Size = new System.Drawing.Size(180, 40);
            this.btnAgregarArticulo.TabIndex = 0;
            this.btnAgregarArticulo.Text = "Articulo";
            this.btnAgregarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAboutUs.FlatAppearance.BorderSize = 0;
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAboutUs.Image = global::TPWinForms.Properties.Resources.icons8_help_25px;
            this.btnAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutUs.Location = new System.Drawing.Point(0, 609);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAboutUs.Size = new System.Drawing.Size(180, 60);
            this.btnAboutUs.TabIndex = 2;
            this.btnAboutUs.Text = "About Us";
            this.btnAboutUs.UseVisualStyleBackColor = true;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAgregar.Image = global::TPWinForms.Properties.Resources.icons8_Plus_25px_1;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(0, 100);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnAgregar.Size = new System.Drawing.Size(180, 60);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "  Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 100);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 97);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnMinimize);
            this.panel3.Controls.Add(this.brnMaximize);
            this.panel3.Controls.Add(this.lblFiltro);
            this.panel3.Controls.Add(this.txtFiltro);
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(180, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1189, 100);
            this.panel3.TabIndex = 18;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1156, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(1090, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 10;
            this.btnMinimize.Text = "O";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // brnMaximize
            // 
            this.brnMaximize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.brnMaximize.FlatAppearance.BorderSize = 0;
            this.brnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnMaximize.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnMaximize.ForeColor = System.Drawing.Color.White;
            this.brnMaximize.Location = new System.Drawing.Point(1123, 0);
            this.brnMaximize.Name = "brnMaximize";
            this.brnMaximize.Size = new System.Drawing.Size(30, 30);
            this.brnMaximize.TabIndex = 9;
            this.brnMaximize.Text = "O";
            this.brnMaximize.UseVisualStyleBackColor = true;
            this.brnMaximize.Click += new System.EventHandler(this.brnMaximize_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(498, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(167, 29);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "ARTICULOS";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grillaArticulos
            // 
            this.grillaArticulos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grillaArticulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grillaArticulos.BackgroundColor = System.Drawing.Color.DimGray;
            this.grillaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaArticulos.Location = new System.Drawing.Point(212, 105);
            this.grillaArticulos.Name = "grillaArticulos";
            this.grillaArticulos.ReadOnly = true;
            this.grillaArticulos.Size = new System.Drawing.Size(733, 443);
            this.grillaArticulos.TabIndex = 0;
            this.grillaArticulos.UseWaitCursor = true;
            this.grillaArticulos.SelectionChanged += new System.EventHandler(this.grillaArticulos_SelectionChanged);
            this.grillaArticulos.Enter += new System.EventHandler(this.grillaArticulos_Enter);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.reset);
            this.panel4.Controls.Add(this.grillaArticulos);
            this.panel4.Location = new System.Drawing.Point(-17, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1420, 624);
            this.panel4.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1369, 669);
            this.Controls.Add(this.gbxDetalles);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormApp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxDetalles.ResumeLayout(false);
            this.gbxDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelSubMenu.ResumeLayout(false);
            this.panelSubMenu.PerformLayout();
            this.panelSubMenuAgregar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaArticulos)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxDetalles;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Button flechitaD;
        private System.Windows.Forms.Button flechitaIzq;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblFiltroPro;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cbxCampo;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.TextBox txtFiltrarA;
        private System.Windows.Forms.Button btnBuscarFiltro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button brnMaximize;
        public System.Windows.Forms.DataGridView grillaArticulos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelSubMenuAgregar;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

