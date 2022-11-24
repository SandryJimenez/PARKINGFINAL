namespace Presentacion
{
    partial class FrmAlquiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlquiler));
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.fechallegada = new System.Windows.Forms.DateTimePicker();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.horasalida = new System.Windows.Forms.DateTimePicker();
            this.datevalorhora = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.fechasalida = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcodfactura = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datevalorhora)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(128, 17);
            this.txtcedula.Margin = new System.Windows.Forms.Padding(2);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(129, 20);
            this.txtcedula.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(52, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cedula:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.White;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscar.Location = new System.Drawing.Point(328, 123);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(76, 56);
            this.BtnBuscar.TabIndex = 13;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(59, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Placa:";
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(129, 45);
            this.txtplaca.Margin = new System.Windows.Forms.Padding(2);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(129, 20);
            this.txtplaca.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(52, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Marca:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(4, 161);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "Fecha Llegada:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "Fecha Salida:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 16);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 19);
            this.label11.TabIndex = 29;
            this.label11.Text = "Valor Hora:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(51, 133);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 19);
            this.label12.TabIndex = 31;
            this.label12.Text = "Total:";
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(117, 119);
            this.txttotal.Margin = new System.Windows.Forms.Padding(2);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(135, 46);
            this.txttotal.TabIndex = 32;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(533, 263);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(129, 40);
            this.BtnGuardar.TabIndex = 33;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(52, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "Modelo:";
            // 
            // txtColor
            // 
            this.txtColor.Enabled = false;
            this.txtColor.Location = new System.Drawing.Point(129, 129);
            this.txtColor.Margin = new System.Windows.Forms.Padding(2);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(129, 20);
            this.txtColor.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(61, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = "Color:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 23);
            this.label6.TabIndex = 38;
            this.label6.Text = "Buscar Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtcedula);
            this.groupBox1.Controls.Add(this.txtColor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtplaca);
            this.groupBox1.Controls.Add(this.txtmodelo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fechallegada);
            this.groupBox1.Controls.Add(this.txtmarca);
            this.groupBox1.Location = new System.Drawing.Point(23, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 240);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // txtmodelo
            // 
            this.txtmodelo.Enabled = false;
            this.txtmodelo.Location = new System.Drawing.Point(129, 97);
            this.txtmodelo.Margin = new System.Windows.Forms.Padding(2);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(129, 20);
            this.txtmodelo.TabIndex = 35;
            // 
            // fechallegada
            // 
            this.fechallegada.Location = new System.Drawing.Point(127, 160);
            this.fechallegada.Margin = new System.Windows.Forms.Padding(2);
            this.fechallegada.Name = "fechallegada";
            this.fechallegada.Size = new System.Drawing.Size(145, 20);
            this.fechallegada.TabIndex = 21;
            this.fechallegada.Value = new System.DateTime(2022, 10, 30, 7, 30, 0, 0);
            // 
            // txtmarca
            // 
            this.txtmarca.Enabled = false;
            this.txtmarca.Location = new System.Drawing.Point(129, 73);
            this.txtmarca.Margin = new System.Windows.Forms.Padding(2);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(129, 20);
            this.txtmarca.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(514, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(148, 23);
            this.label17.TabIndex = 40;
            this.label17.Text = "Valor A Pagar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.horasalida);
            this.groupBox2.Controls.Add(this.datevalorhora);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txttotal);
            this.groupBox2.Controls.Add(this.fechasalida);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(435, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 197);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            // 
            // horasalida
            // 
            this.horasalida.Location = new System.Drawing.Point(117, 85);
            this.horasalida.Name = "horasalida";
            this.horasalida.Size = new System.Drawing.Size(135, 20);
            this.horasalida.TabIndex = 39;
            this.horasalida.Value = new System.DateTime(2022, 10, 30, 0, 0, 0, 0);
            // 
            // datevalorhora
            // 
            this.datevalorhora.Location = new System.Drawing.Point(118, 20);
            this.datevalorhora.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.datevalorhora.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.datevalorhora.Name = "datevalorhora";
            this.datevalorhora.Size = new System.Drawing.Size(135, 20);
            this.datevalorhora.TabIndex = 33;
            this.datevalorhora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.datevalorhora.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(11, 87);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 19);
            this.label9.TabIndex = 38;
            this.label9.Text = "Hora Salida:";
            // 
            // fechasalida
            // 
            this.fechasalida.Location = new System.Drawing.Point(118, 49);
            this.fechasalida.Margin = new System.Windows.Forms.Padding(2);
            this.fechasalida.Name = "fechasalida";
            this.fechasalida.Size = new System.Drawing.Size(135, 20);
            this.fechasalida.TabIndex = 22;
            this.fechasalida.Value = new System.DateTime(2022, 10, 30, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(39, 69);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 19);
            this.label10.TabIndex = 39;
            this.label10.Text = "Codigo Factura";
            // 
            // txtcodfactura
            // 
            this.txtcodfactura.Enabled = false;
            this.txtcodfactura.Location = new System.Drawing.Point(163, 70);
            this.txtcodfactura.Margin = new System.Windows.Forms.Padding(2);
            this.txtcodfactura.Name = "txtcodfactura";
            this.txtcodfactura.Size = new System.Drawing.Size(129, 20);
            this.txtcodfactura.TabIndex = 38;
            // 
            // FrmAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 356);
            this.Controls.Add(this.txtcodfactura);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnBuscar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAlquiler";
            this.Text = "FrmAlquiler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datevalorhora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown datevalorhora;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker fechallegada;
        private System.Windows.Forms.DateTimePicker fechasalida;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.DateTimePicker horasalida;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtcodfactura;
    }
}