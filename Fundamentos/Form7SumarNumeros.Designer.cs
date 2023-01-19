namespace Fundamentos
{
    partial class Form7SumarNumeros
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
            this.lblNumeros = new System.Windows.Forms.Label();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.btnSumarNumeros = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumeros
            // 
            this.lblNumeros.AutoSize = true;
            this.lblNumeros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumeros.Location = new System.Drawing.Point(56, 51);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(149, 21);
            this.lblNumeros.TabIndex = 0;
            this.lblNumeros.Text = "Introduzca números";
            this.lblNumeros.Click += new System.EventHandler(this.lblNumeros_Click);
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(56, 84);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(336, 23);
            this.txtNumeros.TabIndex = 1;
            // 
            // btnSumarNumeros
            // 
            this.btnSumarNumeros.Location = new System.Drawing.Point(115, 123);
            this.btnSumarNumeros.Name = "btnSumarNumeros";
            this.btnSumarNumeros.Size = new System.Drawing.Size(201, 39);
            this.btnSumarNumeros.TabIndex = 2;
            this.btnSumarNumeros.Text = "Sumar Números";
            this.btnSumarNumeros.UseVisualStyleBackColor = true;
            this.btnSumarNumeros.Click += new System.EventHandler(this.btnSumarNumeros_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblResultado.Location = new System.Drawing.Point(56, 206);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(13, 21);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = ".";
            // 
            // Form7SumarNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 261);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnSumarNumeros);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.lblNumeros);
            this.Name = "Form7SumarNumeros";
            this.Text = "Form7SumarNumeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNumeros;
        private TextBox txtNumeros;
        private Button btnSumarNumeros;
        private Label lblResultado;
    }
}