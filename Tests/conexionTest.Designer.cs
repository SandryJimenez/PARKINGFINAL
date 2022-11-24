namespace Tests
{
    partial class conexionTest
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
            this.btnconexion = new System.Windows.Forms.Button();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.btnvalores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnconexion
            // 
            this.btnconexion.Location = new System.Drawing.Point(53, 127);
            this.btnconexion.Name = "btnconexion";
            this.btnconexion.Size = new System.Drawing.Size(131, 54);
            this.btnconexion.TabIndex = 0;
            this.btnconexion.Text = "conexion";
            this.btnconexion.UseVisualStyleBackColor = true;
            this.btnconexion.Click += new System.EventHandler(this.btnconexion_Click);
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(317, 127);
            this.txtbox.Multiline = true;
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(197, 80);
            this.txtbox.TabIndex = 1;
            // 
            // btnvalores
            // 
            this.btnvalores.Location = new System.Drawing.Point(78, 44);
            this.btnvalores.Name = "btnvalores";
            this.btnvalores.Size = new System.Drawing.Size(75, 23);
            this.btnvalores.TabIndex = 2;
            this.btnvalores.Text = "Valores";
            this.btnvalores.UseVisualStyleBackColor = true;
            this.btnvalores.Click += new System.EventHandler(this.btnvalores_Click);
            // 
            // conexionTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 301);
            this.Controls.Add(this.btnvalores);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.btnconexion);
            this.Name = "conexionTest";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconexion;
        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.Button btnvalores;
    }
}

