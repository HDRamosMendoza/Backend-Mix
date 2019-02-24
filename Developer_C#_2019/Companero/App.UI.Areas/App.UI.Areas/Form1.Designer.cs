namespace App.UI.Areas
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
            this.rdoCuadrado = new System.Windows.Forms.RadioButton();
            this.rdoTriangulo = new System.Windows.Forms.RadioButton();
            this.rdoCirculo = new System.Windows.Forms.RadioButton();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdoCuadrado
            // 
            this.rdoCuadrado.AutoSize = true;
            this.rdoCuadrado.Location = new System.Drawing.Point(24, 53);
            this.rdoCuadrado.Name = "rdoCuadrado";
            this.rdoCuadrado.Size = new System.Drawing.Size(71, 17);
            this.rdoCuadrado.TabIndex = 1;
            this.rdoCuadrado.TabStop = true;
            this.rdoCuadrado.Text = "Cuadrado";
            this.rdoCuadrado.UseVisualStyleBackColor = true;
            this.rdoCuadrado.CheckedChanged += new System.EventHandler(this.rdoCuadrado_CheckedChanged);
            // 
            // rdoTriangulo
            // 
            this.rdoTriangulo.AutoSize = true;
            this.rdoTriangulo.Location = new System.Drawing.Point(24, 76);
            this.rdoTriangulo.Name = "rdoTriangulo";
            this.rdoTriangulo.Size = new System.Drawing.Size(69, 17);
            this.rdoTriangulo.TabIndex = 2;
            this.rdoTriangulo.TabStop = true;
            this.rdoTriangulo.Text = "Triangulo";
            this.rdoTriangulo.UseVisualStyleBackColor = true;
            this.rdoTriangulo.CheckedChanged += new System.EventHandler(this.rdoTriangulo_CheckedChanged);
            // 
            // rdoCirculo
            // 
            this.rdoCirculo.AutoSize = true;
            this.rdoCirculo.Location = new System.Drawing.Point(24, 99);
            this.rdoCirculo.Name = "rdoCirculo";
            this.rdoCirculo.Size = new System.Drawing.Size(57, 17);
            this.rdoCirculo.TabIndex = 3;
            this.rdoCirculo.TabStop = true;
            this.rdoCirculo.Text = "Circulo";
            this.rdoCirculo.UseVisualStyleBackColor = true;
            this.rdoCirculo.CheckedChanged += new System.EventHandler(this.rdoCirculo_CheckedChanged);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(79, 145);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(79, 171);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 20);
            this.txtY.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(79, 216);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(76, 258);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(0, 13);
            this.lblArea.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Area:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 323);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.rdoCirculo);
            this.Controls.Add(this.rdoTriangulo);
            this.Controls.Add(this.rdoCuadrado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdoCuadrado;
        private System.Windows.Forms.RadioButton rdoTriangulo;
        private System.Windows.Forms.RadioButton rdoCirculo;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label label3;
    }
}

