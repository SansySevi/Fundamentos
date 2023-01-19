namespace Fundamentos
{
    partial class Form10ColeccionNumeros
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
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.lblNumeros = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.lblSuma = new System.Windows.Forms.Label();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.txtPares = new System.Windows.Forms.TextBox();
            this.lblPares = new System.Windows.Forms.Label();
            this.txtImpares = new System.Windows.Forms.TextBox();
            this.lblImpares = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.ItemHeight = 15;
            this.lstNumeros.Location = new System.Drawing.Point(43, 68);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(255, 244);
            this.lstNumeros.TabIndex = 0;
            // 
            // lblNumeros
            // 
            this.lblNumeros.AutoSize = true;
            this.lblNumeros.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumeros.Location = new System.Drawing.Point(43, 35);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(69, 20);
            this.lblNumeros.TabIndex = 1;
            this.lblNumeros.Text = "Números";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(354, 68);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(128, 43);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(354, 126);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(128, 42);
            this.btnMostrarDatos.TabIndex = 3;
            this.btnMostrarDatos.Text = "Mostrar Datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(380, 201);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(37, 15);
            this.lblSuma.TabIndex = 4;
            this.lblSuma.Text = "Suma";
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(423, 193);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(43, 23);
            this.txtSuma.TabIndex = 5;
            // 
            // txtPares
            // 
            this.txtPares.Location = new System.Drawing.Point(423, 222);
            this.txtPares.Name = "txtPares";
            this.txtPares.Size = new System.Drawing.Size(43, 23);
            this.txtPares.TabIndex = 7;
            // 
            // lblPares
            // 
            this.lblPares.AutoSize = true;
            this.lblPares.Location = new System.Drawing.Point(380, 230);
            this.lblPares.Name = "lblPares";
            this.lblPares.Size = new System.Drawing.Size(35, 15);
            this.lblPares.TabIndex = 6;
            this.lblPares.Text = "Pares";
            // 
            // txtImpares
            // 
            this.txtImpares.Location = new System.Drawing.Point(423, 255);
            this.txtImpares.Name = "txtImpares";
            this.txtImpares.Size = new System.Drawing.Size(43, 23);
            this.txtImpares.TabIndex = 9;
            // 
            // lblImpares
            // 
            this.lblImpares.AutoSize = true;
            this.lblImpares.Location = new System.Drawing.Point(368, 263);
            this.lblImpares.Name = "lblImpares";
            this.lblImpares.Size = new System.Drawing.Size(49, 15);
            this.lblImpares.TabIndex = 8;
            this.lblImpares.Text = "Impares";
            // 
            // Form10ColeccionNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 376);
            this.Controls.Add(this.txtImpares);
            this.Controls.Add(this.lblImpares);
            this.Controls.Add(this.txtPares);
            this.Controls.Add(this.lblPares);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblNumeros);
            this.Controls.Add(this.lstNumeros);
            this.Name = "Form10ColeccionNumeros";
            this.Text = "Form10ColeccionNumeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstNumeros;
        private Label lblNumeros;
        private Button btnGenerar;
        private Button btnMostrarDatos;
        private Label lblSuma;
        private TextBox txtSuma;
        private TextBox txtPares;
        private Label lblPares;
        private TextBox txtImpares;
        private Label lblImpares;
    }
}