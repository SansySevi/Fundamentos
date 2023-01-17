namespace Fundamentos
{
    partial class Form5Char
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
            this.lblLetras = new System.Windows.Forms.Label();
            this.txtLetras = new System.Windows.Forms.TextBox();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSimbolos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPuntuacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRecorrerAscii = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLetras
            // 
            this.lblLetras.AutoSize = true;
            this.lblLetras.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLetras.Location = new System.Drawing.Point(49, 53);
            this.lblLetras.Name = "lblLetras";
            this.lblLetras.Size = new System.Drawing.Size(62, 25);
            this.lblLetras.TabIndex = 0;
            this.lblLetras.Text = "Letras";
            this.lblLetras.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtLetras
            // 
            this.txtLetras.Location = new System.Drawing.Point(49, 81);
            this.txtLetras.Multiline = true;
            this.txtLetras.Name = "txtLetras";
            this.txtLetras.Size = new System.Drawing.Size(243, 100);
            this.txtLetras.TabIndex = 1;
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(368, 81);
            this.txtNumeros.Multiline = true;
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(248, 100);
            this.txtNumeros.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(368, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Números";
            // 
            // txtSimbolos
            // 
            this.txtSimbolos.Location = new System.Drawing.Point(49, 247);
            this.txtSimbolos.Multiline = true;
            this.txtSimbolos.Name = "txtSimbolos";
            this.txtSimbolos.Size = new System.Drawing.Size(243, 100);
            this.txtSimbolos.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(49, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Símbolos";
            // 
            // txtPuntuacion
            // 
            this.txtPuntuacion.Location = new System.Drawing.Point(368, 247);
            this.txtPuntuacion.Multiline = true;
            this.txtPuntuacion.Name = "txtPuntuacion";
            this.txtPuntuacion.Size = new System.Drawing.Size(248, 100);
            this.txtPuntuacion.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(368, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Puntuación";
            // 
            // btnRecorrerAscii
            // 
            this.btnRecorrerAscii.Location = new System.Drawing.Point(217, 384);
            this.btnRecorrerAscii.Name = "btnRecorrerAscii";
            this.btnRecorrerAscii.Size = new System.Drawing.Size(259, 44);
            this.btnRecorrerAscii.TabIndex = 8;
            this.btnRecorrerAscii.Text = "Recorrer ASCII";
            this.btnRecorrerAscii.UseVisualStyleBackColor = true;
            this.btnRecorrerAscii.Click += new System.EventHandler(this.btnRecorrerAscii_Click);
            // 
            // Form5Char
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.btnRecorrerAscii);
            this.Controls.Add(this.txtPuntuacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSimbolos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLetras);
            this.Controls.Add(this.lblLetras);
            this.Name = "Form5Char";
            this.Text = "Form5Char";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblLetras;
        private TextBox txtLetras;
        private TextBox txtNumeros;
        private Label label1;
        private TextBox txtSimbolos;
        private Label label2;
        private TextBox txtPuntuacion;
        private Label label3;
        private Button btnRecorrerAscii;
    }
}