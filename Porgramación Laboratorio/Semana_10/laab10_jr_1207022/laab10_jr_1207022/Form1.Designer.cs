namespace laab10_jr_1207022
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.imputModelo = new System.Windows.Forms.NumericUpDown();
            this.inputPrecio = new System.Windows.Forms.NumericUpDown();
            this.ImputMarca = new System.Windows.Forms.TextBox();
            this.BotonCargarDatos = new System.Windows.Forms.Button();
            this.InputDescripcion = new System.Windows.Forms.RichTextBox();
            this.labeldescripcion = new System.Windows.Forms.Label();
            this.ImputPrecio = new System.Windows.Forms.Label();
            this.InputModelo = new System.Windows.Forms.Label();
            this.imputCarros = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.outputDescripcion = new System.Windows.Forms.Label();
            this.outputPrecio = new System.Windows.Forms.Label();
            this.OutputModelo = new System.Windows.Forms.Label();
            this.outputMarca = new System.Windows.Forms.Label();
            this.outputPrecioFinal = new System.Windows.Forms.Label();
            this.botonCalcularPrecio = new System.Windows.Forms.Button();
            this.inputIVA = new System.Windows.Forms.NumericUpDown();
            this.labeliva = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imputModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPrecio)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputIVA)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, -2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 452);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.imputModelo);
            this.tabPage1.Controls.Add(this.inputPrecio);
            this.tabPage1.Controls.Add(this.ImputMarca);
            this.tabPage1.Controls.Add(this.BotonCargarDatos);
            this.tabPage1.Controls.Add(this.InputDescripcion);
            this.tabPage1.Controls.Add(this.labeldescripcion);
            this.tabPage1.Controls.Add(this.ImputPrecio);
            this.tabPage1.Controls.Add(this.InputModelo);
            this.tabPage1.Controls.Add(this.imputCarros);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(792, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "IngresarDatos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // imputModelo
            // 
            this.imputModelo.Location = new System.Drawing.Point(77, 134);
            this.imputModelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imputModelo.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.imputModelo.Minimum = new decimal(new int[] {
            2007,
            0,
            0,
            0});
            this.imputModelo.Name = "imputModelo";
            this.imputModelo.Size = new System.Drawing.Size(685, 22);
            this.imputModelo.TabIndex = 10;
            this.imputModelo.Value = new decimal(new int[] {
            2007,
            0,
            0,
            0});
            this.imputModelo.ValueChanged += new System.EventHandler(this.imputModelo_ValueChanged);
            // 
            // inputPrecio
            // 
            this.inputPrecio.DecimalPlaces = 2;
            this.inputPrecio.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.inputPrecio.Location = new System.Drawing.Point(79, 176);
            this.inputPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputPrecio.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.inputPrecio.Name = "inputPrecio";
            this.inputPrecio.Size = new System.Drawing.Size(684, 22);
            this.inputPrecio.TabIndex = 9;
            this.inputPrecio.ValueChanged += new System.EventHandler(this.inputPrecio_ValueChanged);
            // 
            // ImputMarca
            // 
            this.ImputMarca.Location = new System.Drawing.Point(69, 59);
            this.ImputMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImputMarca.Name = "ImputMarca";
            this.ImputMarca.Size = new System.Drawing.Size(693, 22);
            this.ImputMarca.TabIndex = 7;
            // 
            // BotonCargarDatos
            // 
            this.BotonCargarDatos.Location = new System.Drawing.Point(85, 345);
            this.BotonCargarDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotonCargarDatos.Name = "BotonCargarDatos";
            this.BotonCargarDatos.Size = new System.Drawing.Size(677, 58);
            this.BotonCargarDatos.TabIndex = 6;
            this.BotonCargarDatos.Text = "CargarDatos";
            this.BotonCargarDatos.UseVisualStyleBackColor = true;
            this.BotonCargarDatos.Click += new System.EventHandler(this.BotonCargarDatos_Click);
            // 
            // InputDescripcion
            // 
            this.InputDescripcion.Location = new System.Drawing.Point(121, 230);
            this.InputDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputDescripcion.Name = "InputDescripcion";
            this.InputDescripcion.Size = new System.Drawing.Size(641, 70);
            this.InputDescripcion.TabIndex = 5;
            this.InputDescripcion.Text = "";
            // 
            // labeldescripcion
            // 
            this.labeldescripcion.AutoSize = true;
            this.labeldescripcion.Location = new System.Drawing.Point(36, 250);
            this.labeldescripcion.Name = "labeldescripcion";
            this.labeldescripcion.Size = new System.Drawing.Size(79, 16);
            this.labeldescripcion.TabIndex = 4;
            this.labeldescripcion.Text = "Descripcion";
            // 
            // ImputPrecio
            // 
            this.ImputPrecio.AutoSize = true;
            this.ImputPrecio.Location = new System.Drawing.Point(19, 176);
            this.ImputPrecio.Name = "ImputPrecio";
            this.ImputPrecio.Size = new System.Drawing.Size(46, 16);
            this.ImputPrecio.TabIndex = 3;
            this.ImputPrecio.Text = "Precio";
            // 
            // InputModelo
            // 
            this.InputModelo.AutoSize = true;
            this.InputModelo.Location = new System.Drawing.Point(19, 142);
            this.InputModelo.Name = "InputModelo";
            this.InputModelo.Size = new System.Drawing.Size(53, 16);
            this.InputModelo.TabIndex = 2;
            this.InputModelo.Text = "Modelo";
            // 
            // imputCarros
            // 
            this.imputCarros.Location = new System.Drawing.Point(19, 2);
            this.imputCarros.Name = "imputCarros";
            this.imputCarros.Size = new System.Drawing.Size(53, 20);
            this.imputCarros.TabIndex = 0;
            this.imputCarros.Text = "Carros";
            this.imputCarros.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.outputDescripcion);
            this.tabPage2.Controls.Add(this.outputPrecio);
            this.tabPage2.Controls.Add(this.OutputModelo);
            this.tabPage2.Controls.Add(this.outputMarca);
            this.tabPage2.Controls.Add(this.outputPrecioFinal);
            this.tabPage2.Controls.Add(this.botonCalcularPrecio);
            this.tabPage2.Controls.Add(this.inputIVA);
            this.tabPage2.Controls.Add(this.labeliva);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(792, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MostrarDatos";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // outputDescripcion
            // 
            this.outputDescripcion.AutoSize = true;
            this.outputDescripcion.Location = new System.Drawing.Point(175, 204);
            this.outputDescripcion.Name = "outputDescripcion";
            this.outputDescripcion.Size = new System.Drawing.Size(79, 16);
            this.outputDescripcion.TabIndex = 12;
            this.outputDescripcion.Text = "Descripcion";
            // 
            // outputPrecio
            // 
            this.outputPrecio.AutoSize = true;
            this.outputPrecio.Location = new System.Drawing.Point(175, 169);
            this.outputPrecio.Name = "outputPrecio";
            this.outputPrecio.Size = new System.Drawing.Size(45, 16);
            this.outputPrecio.TabIndex = 11;
            this.outputPrecio.Text = "precio";
            // 
            // OutputModelo
            // 
            this.OutputModelo.AutoSize = true;
            this.OutputModelo.Location = new System.Drawing.Point(175, 134);
            this.OutputModelo.Name = "OutputModelo";
            this.OutputModelo.Size = new System.Drawing.Size(53, 16);
            this.OutputModelo.TabIndex = 10;
            this.OutputModelo.Text = "Modelo";
            // 
            // outputMarca
            // 
            this.outputMarca.AutoSize = true;
            this.outputMarca.Location = new System.Drawing.Point(175, 103);
            this.outputMarca.Name = "outputMarca";
            this.outputMarca.Size = new System.Drawing.Size(45, 16);
            this.outputMarca.TabIndex = 9;
            this.outputMarca.Text = "Marca";
            this.outputMarca.Click += new System.EventHandler(this.outputMarca_Click);
            // 
            // outputPrecioFinal
            // 
            this.outputPrecioFinal.AutoSize = true;
            this.outputPrecioFinal.Location = new System.Drawing.Point(40, 367);
            this.outputPrecioFinal.Name = "outputPrecioFinal";
            this.outputPrecioFinal.Size = new System.Drawing.Size(78, 16);
            this.outputPrecioFinal.TabIndex = 8;
            this.outputPrecioFinal.Text = "Precio Final";
            // 
            // botonCalcularPrecio
            // 
            this.botonCalcularPrecio.Location = new System.Drawing.Point(116, 300);
            this.botonCalcularPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonCalcularPrecio.Name = "botonCalcularPrecio";
            this.botonCalcularPrecio.Size = new System.Drawing.Size(139, 52);
            this.botonCalcularPrecio.TabIndex = 7;
            this.botonCalcularPrecio.Text = "Calcular Precio Final";
            this.botonCalcularPrecio.UseVisualStyleBackColor = true;
            this.botonCalcularPrecio.Click += new System.EventHandler(this.button3_Click);
            // 
            // inputIVA
            // 
            this.inputIVA.DecimalPlaces = 2;
            this.inputIVA.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.inputIVA.Location = new System.Drawing.Point(116, 250);
            this.inputIVA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputIVA.Name = "inputIVA";
            this.inputIVA.Size = new System.Drawing.Size(679, 22);
            this.inputIVA.TabIndex = 11;
            this.inputIVA.ValueChanged += new System.EventHandler(this.OutputIVA_ValueChanged);
            // 
            // labeliva
            // 
            this.labeliva.AutoSize = true;
            this.labeliva.Location = new System.Drawing.Point(51, 252);
            this.labeliva.Name = "labeliva";
            this.labeliva.Size = new System.Drawing.Size(28, 16);
            this.labeliva.TabIndex = 5;
            this.labeliva.Text = "IVA";
            this.labeliva.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Descripcion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "precio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Modelo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Marca";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(792, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Refrescar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Carros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imputModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPrecio)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputIVA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label imputCarros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown inputPrecio;
        private System.Windows.Forms.TextBox ImputMarca;
        private System.Windows.Forms.Button BotonCargarDatos;
        private System.Windows.Forms.Label ImputPrecio;
        private System.Windows.Forms.Label InputModelo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labeliva;
        private System.Windows.Forms.Label outputPrecioFinal;
        private System.Windows.Forms.Button botonCalcularPrecio;
        private System.Windows.Forms.NumericUpDown inputIVA;
        private System.Windows.Forms.Label outputDescripcion;
        private System.Windows.Forms.Label outputPrecio;
        private System.Windows.Forms.Label OutputModelo;
        private System.Windows.Forms.Label outputMarca;
        private System.Windows.Forms.NumericUpDown imputModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeldescripcion;
        private System.Windows.Forms.RichTextBox InputDescripcion;
    }
}

