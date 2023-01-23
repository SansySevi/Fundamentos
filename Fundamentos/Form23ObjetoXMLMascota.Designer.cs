namespace Fundamentos
{
    partial class Form23ObjetoXMLMascota
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnLeerDato = new System.Windows.Forms.Button();
            this.btnGuardarDato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(40, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(191, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Raza";
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(40, 129);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(191, 23);
            this.txtRaza.TabIndex = 2;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEdad.Location = new System.Drawing.Point(40, 176);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(43, 20);
            this.lblEdad.TabIndex = 5;
            this.lblEdad.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(40, 204);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(191, 23);
            this.txtEdad.TabIndex = 4;
            // 
            // btnLeerDato
            // 
            this.btnLeerDato.Location = new System.Drawing.Point(360, 62);
            this.btnLeerDato.Name = "btnLeerDato";
            this.btnLeerDato.Size = new System.Drawing.Size(137, 41);
            this.btnLeerDato.TabIndex = 6;
            this.btnLeerDato.Text = "Leer Dato";
            this.btnLeerDato.UseVisualStyleBackColor = true;
            this.btnLeerDato.Click += new System.EventHandler(this.btnLeerDato_Click);
            // 
            // btnGuardarDato
            // 
            this.btnGuardarDato.Location = new System.Drawing.Point(360, 125);
            this.btnGuardarDato.Name = "btnGuardarDato";
            this.btnGuardarDato.Size = new System.Drawing.Size(137, 41);
            this.btnGuardarDato.TabIndex = 7;
            this.btnGuardarDato.Text = "Guardar Dato";
            this.btnGuardarDato.UseVisualStyleBackColor = true;
            this.btnGuardarDato.Click += new System.EventHandler(this.btnGuardarDato_Click);
            // 
            // Form23ObjetoXMLMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 267);
            this.Controls.Add(this.btnGuardarDato);
            this.Controls.Add(this.btnLeerDato);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form23ObjetoXMLMascota";
            this.Text = "Form23ObjetoXMLMascota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private TextBox txtRaza;
        private Label lblEdad;
        private TextBox txtEdad;
        private Button btnLeerDato;
        private Button btnGuardarDato;
    }
}