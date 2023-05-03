namespace TPWinForms
{
    partial class Busqueda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Busqueda));
            this.labelBusqueda1 = new System.Windows.Forms.Label();
            this.labelBusqueda2 = new System.Windows.Forms.Label();
            this.labelBusqueda3 = new System.Windows.Forms.Label();
            this.labelBusqueda4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBusqueda1
            // 
            this.labelBusqueda1.AutoSize = true;
            this.labelBusqueda1.Location = new System.Drawing.Point(24, 26);
            this.labelBusqueda1.Name = "labelBusqueda1";
            this.labelBusqueda1.Size = new System.Drawing.Size(47, 13);
            this.labelBusqueda1.TabIndex = 0;
            this.labelBusqueda1.Text = "Nombre:";
            this.labelBusqueda1.Visible = false;
            // 
            // labelBusqueda2
            // 
            this.labelBusqueda2.AutoSize = true;
            this.labelBusqueda2.Location = new System.Drawing.Point(31, 26);
            this.labelBusqueda2.Name = "labelBusqueda2";
            this.labelBusqueda2.Size = new System.Drawing.Size(40, 13);
            this.labelBusqueda2.TabIndex = 1;
            this.labelBusqueda2.Text = "Marca:";
            this.labelBusqueda2.Visible = false;
            // 
            // labelBusqueda3
            // 
            this.labelBusqueda3.AutoSize = true;
            this.labelBusqueda3.Location = new System.Drawing.Point(28, 26);
            this.labelBusqueda3.Name = "labelBusqueda3";
            this.labelBusqueda3.Size = new System.Drawing.Size(43, 13);
            this.labelBusqueda3.TabIndex = 2;
            this.labelBusqueda3.Text = "Código:";
            this.labelBusqueda3.Visible = false;
            // 
            // labelBusqueda4
            // 
            this.labelBusqueda4.AutoSize = true;
            this.labelBusqueda4.Location = new System.Drawing.Point(12, 26);
            this.labelBusqueda4.Name = "labelBusqueda4";
            this.labelBusqueda4.Size = new System.Drawing.Size(57, 13);
            this.labelBusqueda4.TabIndex = 3;
            this.labelBusqueda4.Text = "Categoría:";
            this.labelBusqueda4.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(88, 64);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnBuscar.Enter += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 113);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelBusqueda4);
            this.Controls.Add(this.labelBusqueda3);
            this.Controls.Add(this.labelBusqueda2);
            this.Controls.Add(this.labelBusqueda1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(256, 152);
            this.MinimumSize = new System.Drawing.Size(256, 152);
            this.Name = "Busqueda";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBusqueda1;
        private System.Windows.Forms.Label labelBusqueda2;
        private System.Windows.Forms.Label labelBusqueda3;
        private System.Windows.Forms.Label labelBusqueda4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscar;
    }
}