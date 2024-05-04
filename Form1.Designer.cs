namespace Desafios
{
    partial class txtInteres
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
            this.txtMontoInicial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTasaInteres = new System.Windows.Forms.TextBox();
            this.txtInversion = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblInteresesTotales = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCuotaMensual = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMontoInicial
            // 
            this.txtMontoInicial.Location = new System.Drawing.Point(213, 63);
            this.txtMontoInicial.Margin = new System.Windows.Forms.Padding(2);
            this.txtMontoInicial.Name = "txtMontoInicial";
            this.txtMontoInicial.Size = new System.Drawing.Size(137, 20);
            this.txtMontoInicial.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calculadora De Prestamo";
            // 
            // txtTasaInteres
            // 
            this.txtTasaInteres.Location = new System.Drawing.Point(213, 129);
            this.txtTasaInteres.Margin = new System.Windows.Forms.Padding(2);
            this.txtTasaInteres.Name = "txtTasaInteres";
            this.txtTasaInteres.Size = new System.Drawing.Size(137, 20);
            this.txtTasaInteres.TabIndex = 2;
            // 
            // txtInversion
            // 
            this.txtInversion.Location = new System.Drawing.Point(213, 201);
            this.txtInversion.Margin = new System.Windows.Forms.Padding(2);
            this.txtInversion.Name = "txtInversion";
            this.txtInversion.Size = new System.Drawing.Size(137, 20);
            this.txtInversion.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(246, 276);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 19);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblInteresesTotales
            // 
            this.lblInteresesTotales.AutoSize = true;
            this.lblInteresesTotales.Location = new System.Drawing.Point(415, 159);
            this.lblInteresesTotales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInteresesTotales.Name = "lblInteresesTotales";
            this.lblInteresesTotales.Size = new System.Drawing.Size(0, 13);
            this.lblInteresesTotales.TabIndex = 6;
            this.lblInteresesTotales.Click += new System.EventHandler(this.lblCapitalFinal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Monto Inicial Del Prestamo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tasa De Intereses";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Plazo Del Prestamo";
            // 
            // lblCuotaMensual
            // 
            this.lblCuotaMensual.AutoSize = true;
            this.lblCuotaMensual.Location = new System.Drawing.Point(415, 108);
            this.lblCuotaMensual.Name = "lblCuotaMensual";
            this.lblCuotaMensual.Size = new System.Drawing.Size(0, 13);
            this.lblCuotaMensual.TabIndex = 11;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Location = new System.Drawing.Point(415, 204);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(0, 13);
            this.lblTotalPagar.TabIndex = 12;
            // 
            // txtInteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.lblCuotaMensual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblInteresesTotales);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtInversion);
            this.Controls.Add(this.txtTasaInteres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMontoInicial);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "txtInteres";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMontoInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTasaInteres;
        private System.Windows.Forms.TextBox txtInversion;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblInteresesTotales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCuotaMensual;
        private System.Windows.Forms.Label lblTotalPagar;
    }
}

