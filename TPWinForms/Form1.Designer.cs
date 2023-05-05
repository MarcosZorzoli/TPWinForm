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
            this.grillaArticulos = new System.Windows.Forms.DataGridView();
            this.gbxDetalles = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAlter = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarArticuloToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombreToolStripMenuItem2A = new System.Windows.Forms.ToolStripMenuItem();
            this.porMarcaToolStripMenuItem2B = new System.Windows.Forms.ToolStripMenuItem();
            this.porCódigoToolStripMenuItem2C = new System.Windows.Forms.ToolStripMenuItem();
            this.porCategoríaToolStripMenuItem2D = new System.Windows.Forms.ToolStripMenuItem();
            this.cbFiltro = new System.Windows.Forms.CheckBox();
            this.reset = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaArticulos)).BeginInit();
            this.gbxDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grillaArticulos
            // 
            this.grillaArticulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grillaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaArticulos.Location = new System.Drawing.Point(12, 57);
            this.grillaArticulos.MultiSelect = false;
            this.grillaArticulos.Name = "grillaArticulos";
            this.grillaArticulos.Size = new System.Drawing.Size(733, 443);
            this.grillaArticulos.TabIndex = 0;
            this.grillaArticulos.UseWaitCursor = true;
            this.grillaArticulos.SelectionChanged += new System.EventHandler(this.grillaArticulos_SelectionChanged);
            this.grillaArticulos.Enter += new System.EventHandler(this.grillaArticulos_Enter);
            // 
            // gbxDetalles
            // 
            this.gbxDetalles.Controls.Add(this.btnDelete);
            this.gbxDetalles.Controls.Add(this.btnAlter);
            this.gbxDetalles.Controls.Add(this.btnCerrar);
            this.gbxDetalles.Controls.Add(this.pbxImagen);
            this.gbxDetalles.Controls.Add(this.lblDescripcion);
            this.gbxDetalles.Controls.Add(this.lblNombre);
            this.gbxDetalles.Location = new System.Drawing.Point(784, 57);
            this.gbxDetalles.Name = "gbxDetalles";
            this.gbxDetalles.Size = new System.Drawing.Size(398, 443);
            this.gbxDetalles.TabIndex = 3;
            this.gbxDetalles.TabStop = false;
            this.gbxDetalles.Text = "Detalles";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(160, 401);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAlter
            // 
            this.btnAlter.Location = new System.Drawing.Point(270, 401);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(75, 23);
            this.btnAlter.TabIndex = 4;
            this.btnAlter.Text = "Modificar";
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(45, 401);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pbxImagen
            // 
            this.pbxImagen.Location = new System.Drawing.Point(35, 137);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(344, 244);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 2;
            this.pbxImagen.TabStop = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(163, 104);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(163, 71);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarArticuloToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1230, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarArticuloToolStripMenuItem
            // 
            this.agregarArticuloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarArticuloToolStripMenuItem1,
            this.buscarToolStripMenuItem2});
            this.agregarArticuloToolStripMenuItem.Name = "agregarArticuloToolStripMenuItem";
            this.agregarArticuloToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.agregarArticuloToolStripMenuItem.Text = "Articulos";
            // 
            // agregarArticuloToolStripMenuItem1
            // 
            this.agregarArticuloToolStripMenuItem1.Name = "agregarArticuloToolStripMenuItem1";
            this.agregarArticuloToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.agregarArticuloToolStripMenuItem1.Text = "Agregar Articulo";
            this.agregarArticuloToolStripMenuItem1.Click += new System.EventHandler(this.agregarArticuloToolStripMenuItem1_Click);
            // 
            // buscarToolStripMenuItem2
            // 
            this.buscarToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porNombreToolStripMenuItem2A,
            this.porMarcaToolStripMenuItem2B,
            this.porCódigoToolStripMenuItem2C,
            this.porCategoríaToolStripMenuItem2D});
            this.buscarToolStripMenuItem2.Name = "buscarToolStripMenuItem2";
            this.buscarToolStripMenuItem2.Size = new System.Drawing.Size(161, 22);
            this.buscarToolStripMenuItem2.Text = "Buscar";
            // 
            // porNombreToolStripMenuItem2A
            // 
            this.porNombreToolStripMenuItem2A.Name = "porNombreToolStripMenuItem2A";
            this.porNombreToolStripMenuItem2A.Size = new System.Drawing.Size(144, 22);
            this.porNombreToolStripMenuItem2A.Text = "Por nombre";
            this.porNombreToolStripMenuItem2A.Click += new System.EventHandler(this.porNombreToolStripMenuItem2A_Click);
            // 
            // porMarcaToolStripMenuItem2B
            // 
            this.porMarcaToolStripMenuItem2B.Name = "porMarcaToolStripMenuItem2B";
            this.porMarcaToolStripMenuItem2B.Size = new System.Drawing.Size(144, 22);
            this.porMarcaToolStripMenuItem2B.Text = "Por marca";
            this.porMarcaToolStripMenuItem2B.Click += new System.EventHandler(this.porMarcaToolStripMenuItem2B_Click);
            // 
            // porCódigoToolStripMenuItem2C
            // 
            this.porCódigoToolStripMenuItem2C.Name = "porCódigoToolStripMenuItem2C";
            this.porCódigoToolStripMenuItem2C.Size = new System.Drawing.Size(144, 22);
            this.porCódigoToolStripMenuItem2C.Text = "Por código";
            this.porCódigoToolStripMenuItem2C.Click += new System.EventHandler(this.porCódigoToolStripMenuItem2C_Click);
            // 
            // porCategoríaToolStripMenuItem2D
            // 
            this.porCategoríaToolStripMenuItem2D.Name = "porCategoríaToolStripMenuItem2D";
            this.porCategoríaToolStripMenuItem2D.Size = new System.Drawing.Size(144, 22);
            this.porCategoríaToolStripMenuItem2D.Text = "Por categoría";
            this.porCategoríaToolStripMenuItem2D.Click += new System.EventHandler(this.porCategoríaToolStripMenuItem2D_Click);
            // 
            // cbFiltro
            // 
            this.cbFiltro.AutoSize = true;
            this.cbFiltro.Checked = true;
            this.cbFiltro.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFiltro.Location = new System.Drawing.Point(654, 27);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(91, 17);
            this.cbFiltro.TabIndex = 5;
            this.cbFiltro.Text = "Filtro aplicado";
            this.cbFiltro.UseVisualStyleBackColor = true;
            this.cbFiltro.Visible = false;
            this.cbFiltro.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(267, 519);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(156, 23);
            this.reset.TabIndex = 6;
            this.reset.Text = "Actualizar Lista";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(52, 28);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(194, 20);
            this.txtFiltro.TabIndex = 7;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(12, 33);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(32, 13);
            this.lblFiltro.TabIndex = 8;
            this.lblFiltro.Text = "Filtro:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1230, 601);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.gbxDetalles);
            this.Controls.Add(this.grillaArticulos);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormApp";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaArticulos)).EndInit();
            this.gbxDetalles.ResumeLayout(false);
            this.gbxDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxDetalles;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarArticuloToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem porNombreToolStripMenuItem2A;
        private System.Windows.Forms.ToolStripMenuItem porMarcaToolStripMenuItem2B;
        private System.Windows.Forms.ToolStripMenuItem porCódigoToolStripMenuItem2C;
        private System.Windows.Forms.ToolStripMenuItem porCategoríaToolStripMenuItem2D;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox cbFiltro;
        public System.Windows.Forms.DataGridView grillaArticulos;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblFiltro;
    }
}

