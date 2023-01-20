namespace Fundamentos
{
    partial class Form18PruebaClases
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
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.btnPersona = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.ItemHeight = 15;
            this.lstDatos.Location = new System.Drawing.Point(28, 54);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(505, 349);
            this.lstDatos.TabIndex = 0;
            // 
            // btnPersona
            // 
            this.btnPersona.Location = new System.Drawing.Point(556, 84);
            this.btnPersona.Name = "btnPersona";
            this.btnPersona.Size = new System.Drawing.Size(121, 44);
            this.btnPersona.TabIndex = 1;
            this.btnPersona.Text = "Persona";
            this.btnPersona.UseVisualStyleBackColor = true;
            this.btnPersona.Click += new System.EventHandler(this.btnPersona_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDatos.Location = new System.Drawing.Point(28, 26);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(50, 21);
            this.lblDatos.TabIndex = 2;
            this.lblDatos.Text = "Datos";
            // 
            // Form18PruebaClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnPersona);
            this.Controls.Add(this.lstDatos);
            this.Name = "Form18PruebaClases";
            this.Text = "Form18PruebaClases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstDatos;
        private Button btnPersona;
        private Label lblDatos;
    }
}