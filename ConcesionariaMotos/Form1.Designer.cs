namespace ConcesionariaMotos
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
            this.btnCalcularCosto = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbVidaUtil = new System.Windows.Forms.TextBox();
            this.tbTasaDepre = new System.Windows.Forms.TextBox();
            this.tbValorFab = new System.Windows.Forms.TextBox();
            this.nupAnioAcutal = new System.Windows.Forms.NumericUpDown();
            this.nupModelo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupAnioAcutal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupModelo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcularCosto
            // 
            this.btnCalcularCosto.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCalcularCosto.Location = new System.Drawing.Point(12, 218);
            this.btnCalcularCosto.Name = "btnCalcularCosto";
            this.btnCalcularCosto.Size = new System.Drawing.Size(95, 54);
            this.btnCalcularCosto.TabIndex = 0;
            this.btnCalcularCosto.Text = "Calcular costo";
            this.btnCalcularCosto.UseVisualStyleBackColor = true;
            this.btnCalcularCosto.Click += new System.EventHandler(this.btnCalcularCosto_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(135, 218);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(95, 54);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(115, 36);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(100, 20);
            this.tbMarca.TabIndex = 2;
            // 
            // tbVidaUtil
            // 
            this.tbVidaUtil.Location = new System.Drawing.Point(405, 74);
            this.tbVidaUtil.Name = "tbVidaUtil";
            this.tbVidaUtil.Size = new System.Drawing.Size(100, 20);
            this.tbVidaUtil.TabIndex = 3;
            // 
            // tbTasaDepre
            // 
            this.tbTasaDepre.Location = new System.Drawing.Point(405, 35);
            this.tbTasaDepre.Name = "tbTasaDepre";
            this.tbTasaDepre.Size = new System.Drawing.Size(100, 20);
            this.tbTasaDepre.TabIndex = 4;
            // 
            // tbValorFab
            // 
            this.tbValorFab.Location = new System.Drawing.Point(115, 152);
            this.tbValorFab.Name = "tbValorFab";
            this.tbValorFab.Size = new System.Drawing.Size(100, 20);
            this.tbValorFab.TabIndex = 5;
            // 
            // nupAnioAcutal
            // 
            this.nupAnioAcutal.Location = new System.Drawing.Point(115, 110);
            this.nupAnioAcutal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupAnioAcutal.Minimum = new decimal(new int[] {
            1886,
            0,
            0,
            0});
            this.nupAnioAcutal.Name = "nupAnioAcutal";
            this.nupAnioAcutal.Size = new System.Drawing.Size(66, 20);
            this.nupAnioAcutal.TabIndex = 8;
            this.nupAnioAcutal.Value = new decimal(new int[] {
            1886,
            0,
            0,
            0});
            // 
            // nupModelo
            // 
            this.nupModelo.Location = new System.Drawing.Point(115, 76);
            this.nupModelo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupModelo.Minimum = new decimal(new int[] {
            1886,
            0,
            0,
            0});
            this.nupModelo.Name = "nupModelo";
            this.nupModelo.Size = new System.Drawing.Size(66, 20);
            this.nupModelo.TabIndex = 9;
            this.nupModelo.Value = new decimal(new int[] {
            1886,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Modelo(año)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Año actual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Valor de fabricacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tasa de depreciación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Vida Útil(años)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 296);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nupModelo);
            this.Controls.Add(this.nupAnioAcutal);
            this.Controls.Add(this.tbValorFab);
            this.Controls.Add(this.tbTasaDepre);
            this.Controls.Add(this.tbVidaUtil);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCalcularCosto);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nupAnioAcutal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupModelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox tbVidaUtil;
        private System.Windows.Forms.TextBox tbTasaDepre;
        private System.Windows.Forms.TextBox tbValorFab;
        private System.Windows.Forms.NumericUpDown nupAnioAcutal;
        private System.Windows.Forms.NumericUpDown nupModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnCalcularCosto;
        public System.Windows.Forms.Button btnCerrar;
    }
}

