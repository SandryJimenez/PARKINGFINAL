namespace Test
{
    partial class Pruebaconexion
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
            this.btnconexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnconexion
            // 
            this.btnconexion.Location = new System.Drawing.Point(210, 39);
            this.btnconexion.Name = "btnconexion";
            this.btnconexion.Size = new System.Drawing.Size(120, 53);
            this.btnconexion.TabIndex = 0;
            this.btnconexion.Text = "Conectar";
            this.btnconexion.UseVisualStyleBackColor = true;
            this.btnconexion.Click += new System.EventHandler(this.btnconexion_Click);
            // 
            // Pruebaconexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 381);
            this.Controls.Add(this.btnconexion);
            this.Name = "Pruebaconexion";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnconexion;
    }
}