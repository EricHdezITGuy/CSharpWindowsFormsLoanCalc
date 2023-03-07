namespace CalculadoraPrestamosWindowsForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calcularPrestamo = new System.Windows.Forms.Button();
            this.generarRecibo = new System.Windows.Forms.Button();
            this.reiniciarCalculadora = new System.Windows.Forms.Button();
            this.salirCalculadora = new System.Windows.Forms.Button();
            this.montoPrestamoText = new System.Windows.Forms.Label();
            this.cantidadAniosText = new System.Windows.Forms.Label();
            this.opcionPrestamoText = new System.Windows.Forms.Label();
            this.pagoMensualText = new System.Windows.Forms.Label();
            this.costoTotalText = new System.Windows.Forms.Label();
            this.montoPrestamoBox = new System.Windows.Forms.TextBox();
            this.cantidadAniosBox = new System.Windows.Forms.TextBox();
            this.Header = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pagoMensualBox = new System.Windows.Forms.Label();
            this.costoTotalBox = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tipoClienteText = new System.Windows.Forms.Label();
            this.tipoClienteBox = new System.Windows.Forms.ComboBox();
            this.opcionPrestamoBox = new System.Windows.Forms.ComboBox();
            this.descuentoBox = new System.Windows.Forms.Label();
            this.descuentoText = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calcularPrestamo
            // 
            this.calcularPrestamo.BackColor = System.Drawing.Color.DarkCyan;
            this.calcularPrestamo.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calcularPrestamo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.calcularPrestamo.Location = new System.Drawing.Point(25, 730);
            this.calcularPrestamo.Name = "calcularPrestamo";
            this.calcularPrestamo.Size = new System.Drawing.Size(300, 63);
            this.calcularPrestamo.TabIndex = 0;
            this.calcularPrestamo.Text = "Calcular Préstamo";
            this.calcularPrestamo.UseVisualStyleBackColor = false;
            this.calcularPrestamo.Click += new System.EventHandler(this.calcularPrestamo_Click);
            // 
            // generarRecibo
            // 
            this.generarRecibo.BackColor = System.Drawing.Color.DarkCyan;
            this.generarRecibo.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.generarRecibo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.generarRecibo.Location = new System.Drawing.Point(347, 730);
            this.generarRecibo.Name = "generarRecibo";
            this.generarRecibo.Size = new System.Drawing.Size(300, 63);
            this.generarRecibo.TabIndex = 1;
            this.generarRecibo.Text = "Generar Recibo";
            this.generarRecibo.UseVisualStyleBackColor = false;
            // 
            // reiniciarCalculadora
            // 
            this.reiniciarCalculadora.BackColor = System.Drawing.Color.DarkCyan;
            this.reiniciarCalculadora.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reiniciarCalculadora.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.reiniciarCalculadora.Location = new System.Drawing.Point(667, 730);
            this.reiniciarCalculadora.Name = "reiniciarCalculadora";
            this.reiniciarCalculadora.Size = new System.Drawing.Size(300, 63);
            this.reiniciarCalculadora.TabIndex = 2;
            this.reiniciarCalculadora.Text = "Reiniciar Calculadora";
            this.reiniciarCalculadora.UseVisualStyleBackColor = false;
            this.reiniciarCalculadora.Click += new System.EventHandler(this.reiniciarCalculadora_Click);
            // 
            // salirCalculadora
            // 
            this.salirCalculadora.BackColor = System.Drawing.Color.DarkCyan;
            this.salirCalculadora.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salirCalculadora.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.salirCalculadora.Location = new System.Drawing.Point(988, 730);
            this.salirCalculadora.Name = "salirCalculadora";
            this.salirCalculadora.Size = new System.Drawing.Size(300, 63);
            this.salirCalculadora.TabIndex = 3;
            this.salirCalculadora.Text = "Salir";
            this.salirCalculadora.UseVisualStyleBackColor = false;
            this.salirCalculadora.Click += new System.EventHandler(this.button4_Click);
            // 
            // montoPrestamoText
            // 
            this.montoPrestamoText.AutoSize = true;
            this.montoPrestamoText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.montoPrestamoText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.montoPrestamoText.Location = new System.Drawing.Point(25, 327);
            this.montoPrestamoText.Name = "montoPrestamoText";
            this.montoPrestamoText.Size = new System.Drawing.Size(461, 41);
            this.montoPrestamoText.TabIndex = 4;
            this.montoPrestamoText.Text = "Ingresar el monto del préstamo";
            this.montoPrestamoText.Click += new System.EventHandler(this.label1_Click);
            // 
            // cantidadAniosText
            // 
            this.cantidadAniosText.AutoSize = true;
            this.cantidadAniosText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cantidadAniosText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cantidadAniosText.Location = new System.Drawing.Point(25, 403);
            this.cantidadAniosText.Name = "cantidadAniosText";
            this.cantidadAniosText.Size = new System.Drawing.Size(402, 41);
            this.cantidadAniosText.TabIndex = 5;
            this.cantidadAniosText.Text = "Ingrese la cantidad de años";
            // 
            // opcionPrestamoText
            // 
            this.opcionPrestamoText.AutoSize = true;
            this.opcionPrestamoText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.opcionPrestamoText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.opcionPrestamoText.Location = new System.Drawing.Point(25, 196);
            this.opcionPrestamoText.Name = "opcionPrestamoText";
            this.opcionPrestamoText.Size = new System.Drawing.Size(486, 41);
            this.opcionPrestamoText.TabIndex = 6;
            this.opcionPrestamoText.Text = "Seleccione la opción de préstamo";
            // 
            // pagoMensualText
            // 
            this.pagoMensualText.AutoSize = true;
            this.pagoMensualText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pagoMensualText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pagoMensualText.Location = new System.Drawing.Point(25, 473);
            this.pagoMensualText.Name = "pagoMensualText";
            this.pagoMensualText.Size = new System.Drawing.Size(213, 41);
            this.pagoMensualText.TabIndex = 7;
            this.pagoMensualText.Text = "Pago mensual";
            // 
            // costoTotalText
            // 
            this.costoTotalText.AutoSize = true;
            this.costoTotalText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.costoTotalText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.costoTotalText.Location = new System.Drawing.Point(25, 543);
            this.costoTotalText.Name = "costoTotalText";
            this.costoTotalText.Size = new System.Drawing.Size(163, 41);
            this.costoTotalText.TabIndex = 8;
            this.costoTotalText.Text = "Pago total";
            // 
            // montoPrestamoBox
            // 
            this.montoPrestamoBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.montoPrestamoBox.Location = new System.Drawing.Point(524, 341);
            this.montoPrestamoBox.Name = "montoPrestamoBox";
            this.montoPrestamoBox.Size = new System.Drawing.Size(147, 38);
            this.montoPrestamoBox.TabIndex = 9;
            this.montoPrestamoBox.TextChanged += new System.EventHandler(this.montoPrestamo_TextChanged);
            // 
            // cantidadAniosBox
            // 
            this.cantidadAniosBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cantidadAniosBox.Location = new System.Drawing.Point(524, 406);
            this.cantidadAniosBox.Name = "cantidadAniosBox";
            this.cantidadAniosBox.Size = new System.Drawing.Size(147, 38);
            this.cantidadAniosBox.TabIndex = 10;
            this.cantidadAniosBox.TextChanged += new System.EventHandler(this.cantidadAniosBox_TextChanged);
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Header.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Header.Location = new System.Drawing.Point(7, 21);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1063, 81);
            this.Header.TabIndex = 14;
            this.Header.Text = "Calculadora Financiera de Préstamos";
            this.Header.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Header);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.groupBox1.Location = new System.Drawing.Point(124, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1076, 117);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // pagoMensualBox
            // 
            this.pagoMensualBox.BackColor = System.Drawing.Color.White;
            this.pagoMensualBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pagoMensualBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pagoMensualBox.Location = new System.Drawing.Point(524, 476);
            this.pagoMensualBox.Name = "pagoMensualBox";
            this.pagoMensualBox.Size = new System.Drawing.Size(147, 38);
            this.pagoMensualBox.TabIndex = 16;
            this.pagoMensualBox.Click += new System.EventHandler(this.pagoMensualBox_Click);
            // 
            // costoTotalBox
            // 
            this.costoTotalBox.BackColor = System.Drawing.Color.White;
            this.costoTotalBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costoTotalBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.costoTotalBox.Location = new System.Drawing.Point(524, 550);
            this.costoTotalBox.Name = "costoTotalBox";
            this.costoTotalBox.Size = new System.Drawing.Size(147, 33);
            this.costoTotalBox.TabIndex = 17;
            this.costoTotalBox.Click += new System.EventHandler(this.costoTotalBox_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(720, 272);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(561, 378);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // tipoClienteText
            // 
            this.tipoClienteText.AutoSize = true;
            this.tipoClienteText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tipoClienteText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tipoClienteText.Location = new System.Drawing.Point(25, 259);
            this.tipoClienteText.Name = "tipoClienteText";
            this.tipoClienteText.Size = new System.Drawing.Size(337, 41);
            this.tipoClienteText.TabIndex = 19;
            this.tipoClienteText.Text = "Escoger tipo de cliente";
            this.tipoClienteText.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tipoClienteBox
            // 
            this.tipoClienteBox.BackColor = System.Drawing.Color.White;
            this.tipoClienteBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tipoClienteBox.FormattingEnabled = true;
            this.tipoClienteBox.Items.AddRange(new object[] {
            "A1",
            "A2",
            "B",
            "C"});
            this.tipoClienteBox.Location = new System.Drawing.Point(524, 272);
            this.tipoClienteBox.Name = "tipoClienteBox";
            this.tipoClienteBox.Size = new System.Drawing.Size(147, 39);
            this.tipoClienteBox.TabIndex = 20;
            this.tipoClienteBox.SelectedIndexChanged += new System.EventHandler(this.tipoClienteMenu_SelectedIndexChanged);
            // 
            // opcionPrestamoBox
            // 
            this.opcionPrestamoBox.BackColor = System.Drawing.Color.White;
            this.opcionPrestamoBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.opcionPrestamoBox.FormattingEnabled = true;
            this.opcionPrestamoBox.Items.AddRange(new object[] {
            "Personal Regular - Tasa de interés: 15%",
            "Personal Rápido - Tasa de interés: 18%",
            "Reparación y ampliación de vivienda - Tasa de interés: 12%",
            "Compra de Lote - Tasa de interés: 12%",
            "Compra de Vehículo Nuevo - Tasa de interés: 18%"});
            this.opcionPrestamoBox.Location = new System.Drawing.Point(524, 198);
            this.opcionPrestamoBox.Name = "opcionPrestamoBox";
            this.opcionPrestamoBox.Size = new System.Drawing.Size(757, 39);
            this.opcionPrestamoBox.TabIndex = 21;
            this.opcionPrestamoBox.SelectedIndexChanged += new System.EventHandler(this.opcionPrestamoBox_SelectedIndexChanged);
            // 
            // descuentoBox
            // 
            this.descuentoBox.BackColor = System.Drawing.Color.White;
            this.descuentoBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.descuentoBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.descuentoBox.Location = new System.Drawing.Point(524, 617);
            this.descuentoBox.Name = "descuentoBox";
            this.descuentoBox.Size = new System.Drawing.Size(147, 33);
            this.descuentoBox.TabIndex = 23;
            this.descuentoBox.Click += new System.EventHandler(this.descuentoBox_Click);
            // 
            // descuentoText
            // 
            this.descuentoText.AutoSize = true;
            this.descuentoText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.descuentoText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.descuentoText.Location = new System.Drawing.Point(25, 610);
            this.descuentoText.Name = "descuentoText";
            this.descuentoText.Size = new System.Drawing.Size(308, 41);
            this.descuentoText.TabIndex = 22;
            this.descuentoText.Text = "Descuento (si aplica)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1312, 841);
            this.Controls.Add(this.descuentoBox);
            this.Controls.Add(this.descuentoText);
            this.Controls.Add(this.opcionPrestamoBox);
            this.Controls.Add(this.tipoClienteBox);
            this.Controls.Add(this.tipoClienteText);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.costoTotalBox);
            this.Controls.Add(this.pagoMensualBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cantidadAniosBox);
            this.Controls.Add(this.montoPrestamoBox);
            this.Controls.Add(this.costoTotalText);
            this.Controls.Add(this.pagoMensualText);
            this.Controls.Add(this.opcionPrestamoText);
            this.Controls.Add(this.cantidadAniosText);
            this.Controls.Add(this.montoPrestamoText);
            this.Controls.Add(this.salirCalculadora);
            this.Controls.Add(this.reiniciarCalculadora);
            this.Controls.Add(this.generarRecibo);
            this.Controls.Add(this.calcularPrestamo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button calcularPrestamo;
        private Button generarRecibo;
        private Button reiniciarCalculadora;
        private Button salirCalculadora;
        private Label montoPrestamoText;
        private Label cantidadAniosText;
        private Label opcionPrestamoText;
        private Label pagoMensualText;
        private Label costoTotalText;
        private TextBox montoPrestamoBox;
        private TextBox cantidadAniosBox;
        private Label Header;
        private GroupBox groupBox1;
        private Label pagoMensualBox;
        private Label costoTotalBox;
        private RichTextBox richTextBox1;
        private Label tipoClienteText;
        private ComboBox tipoClienteBox;
        private ComboBox opcionPrestamoBox;
        private Label descuentoBox;
        private Label descuentoText;
    }
}