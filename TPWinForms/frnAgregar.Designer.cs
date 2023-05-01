namespace TPWinForms
{
    partial class frnAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frnAgregar));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.numID = new System.Windows.Forms.NumericUpDown();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.numCategoria = new System.Windows.Forms.NumericUpDown();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(49, 350);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(242, 350);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 1;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(46, 88);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 13);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "ID :";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(46, 117);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 13);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Codigo :";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(46, 148);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre :";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(46, 176);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(69, 13);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "Descripcion :";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(46, 208);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(43, 13);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca :";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(46, 241);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(72, 13);
            this.lblCategoria.TabIndex = 7;
            this.lblCategoria.Text = "ID Categoria :";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(46, 274);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(43, 13);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio :";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(46, 305);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(0, 13);
            this.lblImagen.TabIndex = 9;
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(141, 200);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(176, 21);
            this.cbMarca.TabIndex = 10;
            // 
            // numID
            // 
            this.numID.Location = new System.Drawing.Point(141, 86);
            this.numID.Name = "numID";
            this.numID.Size = new System.Drawing.Size(63, 20);
            this.numID.TabIndex = 11;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(141, 117);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(63, 20);
            this.tbCodigo.TabIndex = 12;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(141, 148);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(176, 20);
            this.tbNombre.TabIndex = 13;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(141, 173);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(176, 20);
            this.tbDescripcion.TabIndex = 14;
            // 
            // numCategoria
            // 
            this.numCategoria.Location = new System.Drawing.Point(141, 234);
            this.numCategoria.Name = "numCategoria";
            this.numCategoria.Size = new System.Drawing.Size(63, 20);
            this.numCategoria.TabIndex = 15;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(141, 274);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(147, 20);
            this.tbPrecio.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "NUEVO ARTICULO";
            // 
            // frnAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.numCategoria);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.numID);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frnAgregar";
            this.Text = "frnAgregar";
            this.Load += new System.EventHandler(this.frnAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.NumericUpDown numID;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.NumericUpDown numCategoria;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label label1;
    }
}