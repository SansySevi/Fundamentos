namespace Fundamentos
{
    partial class Form12Metodos
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnDobleValor = new System.Windows.Forms.Button();
            this.btnDobleReferencia = new System.Windows.Forms.Button();
            this.btnObjetoReferencia = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblMouse = new System.Windows.Forms.TextBox();
            this.txtSoloNumeros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoloLetras = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(59, 51);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(51, 15);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número";
            // 
            // btnDobleValor
            // 
            this.btnDobleValor.Location = new System.Drawing.Point(59, 99);
            this.btnDobleValor.Name = "btnDobleValor";
            this.btnDobleValor.Size = new System.Drawing.Size(111, 53);
            this.btnDobleValor.TabIndex = 1;
            this.btnDobleValor.Text = "Doble() Valor";
            this.btnDobleValor.UseVisualStyleBackColor = true;
            this.btnDobleValor.Click += new System.EventHandler(this.btnDobleValor_Click);
            // 
            // btnDobleReferencia
            // 
            this.btnDobleReferencia.Location = new System.Drawing.Point(59, 158);
            this.btnDobleReferencia.Name = "btnDobleReferencia";
            this.btnDobleReferencia.Size = new System.Drawing.Size(111, 64);
            this.btnDobleReferencia.TabIndex = 2;
            this.btnDobleReferencia.Text = "Doble() Referencia";
            this.btnDobleReferencia.UseVisualStyleBackColor = true;
            this.btnDobleReferencia.Click += new System.EventHandler(this.btnDobleReferencia_Click);
            // 
            // btnObjetoReferencia
            // 
            this.btnObjetoReferencia.Location = new System.Drawing.Point(59, 228);
            this.btnObjetoReferencia.Name = "btnObjetoReferencia";
            this.btnObjetoReferencia.Size = new System.Drawing.Size(111, 53);
            this.btnObjetoReferencia.TabIndex = 3;
            this.btnObjetoReferencia.Text = "Objeto Referencia";
            this.btnObjetoReferencia.UseVisualStyleBackColor = true;
            this.btnObjetoReferencia.Click += new System.EventHandler(this.btnObjetoReferencia_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(128, 43);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 23);
            this.txtNumero.TabIndex = 4;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(72, 332);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 21);
            this.lblResultado.TabIndex = 5;
            // 
            // lblMouse
            // 
            this.lblMouse.Location = new System.Drawing.Point(282, 115);
            this.lblMouse.Multiline = true;
            this.lblMouse.Name = "lblMouse";
            this.lblMouse.Size = new System.Drawing.Size(386, 280);
            this.lblMouse.TabIndex = 6;
            this.lblMouse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblMouse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMouse_MouseMove);
            // 
            // txtSoloNumeros
            // 
            this.txtSoloNumeros.Location = new System.Drawing.Point(404, 38);
            this.txtSoloNumeros.Name = "txtSoloNumeros";
            this.txtSoloNumeros.Size = new System.Drawing.Size(175, 23);
            this.txtSoloNumeros.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sólo números";
            // 
            // txtSoloLetras
            // 
            this.txtSoloLetras.Location = new System.Drawing.Point(404, 67);
            this.txtSoloLetras.Name = "txtSoloLetras";
            this.txtSoloLetras.Size = new System.Drawing.Size(175, 23);
            this.txtSoloLetras.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sólo letras";
            // 
            // Form12Metodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoloLetras);
            this.Controls.Add(this.txtSoloNumeros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMouse);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnObjetoReferencia);
            this.Controls.Add(this.btnDobleReferencia);
            this.Controls.Add(this.btnDobleValor);
            this.Controls.Add(this.lblNumero);
            this.Name = "Form12Metodos";
            this.Text = "Form12Metodos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNumero;
        private Button btnDobleValor;
        private Button btnDobleReferencia;
        private Button btnObjetoReferencia;
        private TextBox txtNumero;
        private Label lblResultado;
        private TextBox lblMouse;
        private TextBox txtSoloNumeros;
        private Label label1;
        private TextBox txtSoloLetras;
        private Label label2;
    }
}