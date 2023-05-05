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
            this.cbFiltro = new System.Windows.Forms.CheckBox();
            this.reset = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaArticulos)).BeginInit();
            this.gbxDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
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
            this.gbxDetalles.Location = new System.Drawing.Point(765, 57);
            this.gbxDetalles.Name = "gbxDetalles";
            this.gbxDetalles.Size = new System.Drawing.Size(453, 443);
            this.gbxDetalles.TabIndex = 3;
            this.gbxDetalles.TabStop = false;
            this.gbxDetalles.Text = "Detalles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "/";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(234, 386);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(89, 13);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "cantidad de fotos";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(207, 386);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(57, 13);
            this.lblImagen.TabIndex = 8;
            this.lblImagen.Text = "foto actual";
            // 
            // flechitaIzq
            // 
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
            this.flechitaD.Image = global::TPWinForms.Properties.Resources.flechita1;
            this.flechitaD.Location = new System.Drawing.Point(377, 202);
            this.flechitaD.Name = "flechitaD";
            this.flechitaD.Size = new System.Drawing.Size(57, 105);
            this.flechitaD.TabIndex = 6;
            this.flechitaD.UseVisualStyleBackColor = true;
            this.flechitaD.Click += new System.EventHandler(this.flechitaD_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(186, 409);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAlter
            // 
            this.btnAlter.Location = new System.Drawing.Point(296, 409);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(75, 23);
            this.btnAlter.TabIndex = 4;
            this.btnAlter.Text = "Modificar";
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(71, 409);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pbxImagen
            // 
            this.pbxImagen.Location = new System.Drawing.Point(71, 133);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(300, 244);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 2;
            this.pbxImagen.TabStop = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(187, 104);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(196, 71);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
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
            this.reset.Location = new System.Drawing.Point(250, 517);
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
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(250, 559);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(156, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar Articulo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1230, 601);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.gbxDetalles);
            this.Controls.Add(this.grillaArticulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormApp";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaArticulos)).EndInit();
            this.gbxDetalles.ResumeLayout(false);
            this.gbxDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox cbFiltro;
        public System.Windows.Forms.DataGridView grillaArticulos;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Button flechitaD;
        private System.Windows.Forms.Button flechitaIzq;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnAgregar;
    }
}

