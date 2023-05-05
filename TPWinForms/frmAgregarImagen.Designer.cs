namespace TPWinForms
{
    partial class frmAgregarImagen
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
            this.gvImagenes = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnVista = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvImagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // gvImagenes
            // 
            this.gvImagenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvImagenes.Location = new System.Drawing.Point(39, 83);
            this.gvImagenes.Name = "gvImagenes";
            this.gvImagenes.Size = new System.Drawing.Size(372, 243);
            this.gvImagenes.TabIndex = 49;
            this.gvImagenes.SelectionChanged += new System.EventHandler(this.gvImagenes_SelectionChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(173, 344);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnVista
            // 
            this.btnVista.Location = new System.Drawing.Point(465, 38);
            this.btnVista.Name = "btnVista";
            this.btnVista.Size = new System.Drawing.Size(105, 23);
            this.btnVista.TabIndex = 47;
            this.btnVista.Text = "Vista Previa";
            this.btnVista.UseVisualStyleBackColor = true;
            this.btnVista.Click += new System.EventHandler(this.btnVista_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(173, 389);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 46;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(551, 344);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(122, 23);
            this.btnAceptar.TabIndex = 45;
            this.btnAceptar.Text = "Guardar Imagen";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(173, 40);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(238, 20);
            this.tbUrl.TabIndex = 43;
            // 
            // pbxImagen
            // 
            this.pbxImagen.Location = new System.Drawing.Point(465, 83);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(296, 243);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 44;
            this.pbxImagen.TabStop = false;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(55, 43);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(81, 13);
            this.lblDireccion.TabIndex = 50;
            this.lblDireccion.Text = "Pegar URL aca";
            // 
            // frmAgregarImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.gvImagenes);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnVista);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.tbUrl);
            this.Name = "frmAgregarImagen";
            this.Text = "frmAgregarImagen";
            this.Load += new System.EventHandler(this.frmAgregarImagen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvImagenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvImagenes;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnVista;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label lblDireccion;
    }
}