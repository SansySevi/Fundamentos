namespace Fundamentos
{
    partial class Form17TemperaturasAnuales
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
            this.lblMeses = new System.Windows.Forms.Label();
            this.lstMeses = new System.Windows.Forms.ListBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.lblTemperaturaMaxima = new System.Windows.Forms.Label();
            this.txtTemperaturaMaxima = new System.Windows.Forms.TextBox();
            this.txtTemperaturaMinima = new System.Windows.Forms.TextBox();
            this.lblTemperaturaMinima = new System.Windows.Forms.Label();
            this.txtTemperaturaMedia = new System.Windows.Forms.TextBox();
            this.lblMediaAnual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMeses.Location = new System.Drawing.Point(43, 22);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(54, 21);
            this.lblMeses.TabIndex = 0;
            this.lblMeses.Text = "Meses";
            // 
            // lstMeses
            // 
            this.lstMeses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstMeses.FormattingEnabled = true;
            this.lstMeses.ItemHeight = 21;
            this.lstMeses.Location = new System.Drawing.Point(43, 59);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(220, 319);
            this.lstMeses.TabIndex = 1;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(337, 59);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(135, 42);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar meses";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(337, 107);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(135, 42);
            this.btnMostrarDatos.TabIndex = 3;
            this.btnMostrarDatos.Text = "Mostrar Datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // lblTemperaturaMaxima
            // 
            this.lblTemperaturaMaxima.AutoSize = true;
            this.lblTemperaturaMaxima.Location = new System.Drawing.Point(337, 194);
            this.lblTemperaturaMaxima.Name = "lblTemperaturaMaxima";
            this.lblTemperaturaMaxima.Size = new System.Drawing.Size(119, 15);
            this.lblTemperaturaMaxima.TabIndex = 4;
            this.lblTemperaturaMaxima.Text = "Temperatura máxima";
            // 
            // txtTemperaturaMaxima
            // 
            this.txtTemperaturaMaxima.Location = new System.Drawing.Point(354, 212);
            this.txtTemperaturaMaxima.Name = "txtTemperaturaMaxima";
            this.txtTemperaturaMaxima.Size = new System.Drawing.Size(87, 23);
            this.txtTemperaturaMaxima.TabIndex = 5;
            // 
            // txtTemperaturaMinima
            // 
            this.txtTemperaturaMinima.Location = new System.Drawing.Point(354, 288);
            this.txtTemperaturaMinima.Name = "txtTemperaturaMinima";
            this.txtTemperaturaMinima.Size = new System.Drawing.Size(87, 23);
            this.txtTemperaturaMinima.TabIndex = 7;
            // 
            // lblTemperaturaMinima
            // 
            this.lblTemperaturaMinima.AutoSize = true;
            this.lblTemperaturaMinima.Location = new System.Drawing.Point(337, 270);
            this.lblTemperaturaMinima.Name = "lblTemperaturaMinima";
            this.lblTemperaturaMinima.Size = new System.Drawing.Size(117, 15);
            this.lblTemperaturaMinima.TabIndex = 6;
            this.lblTemperaturaMinima.Text = "Temperatura minima";
            this.lblTemperaturaMinima.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTemperaturaMedia
            // 
            this.txtTemperaturaMedia.Location = new System.Drawing.Point(354, 356);
            this.txtTemperaturaMedia.Name = "txtTemperaturaMedia";
            this.txtTemperaturaMedia.Size = new System.Drawing.Size(87, 23);
            this.txtTemperaturaMedia.TabIndex = 9;
            // 
            // lblMediaAnual
            // 
            this.lblMediaAnual.AutoSize = true;
            this.lblMediaAnual.Location = new System.Drawing.Point(337, 338);
            this.lblMediaAnual.Name = "lblMediaAnual";
            this.lblMediaAnual.Size = new System.Drawing.Size(72, 15);
            this.lblMediaAnual.TabIndex = 8;
            this.lblMediaAnual.Text = "Media anual";
            // 
            // Form17TemperaturasAnuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.txtTemperaturaMedia);
            this.Controls.Add(this.lblMediaAnual);
            this.Controls.Add(this.txtTemperaturaMinima);
            this.Controls.Add(this.lblTemperaturaMinima);
            this.Controls.Add(this.txtTemperaturaMaxima);
            this.Controls.Add(this.lblTemperaturaMaxima);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lstMeses);
            this.Controls.Add(this.lblMeses);
            this.Name = "Form17TemperaturasAnuales";
            this.Text = "Form17TemperaturasAnuales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMeses;
        private ListBox lstMeses;
        private Button btnGenerar;
        private Button btnMostrarDatos;
        private Label lblTemperaturaMaxima;
        private TextBox txtTemperaturaMaxima;
        private TextBox txtTemperaturaMinima;
        private Label lblTemperaturaMinima;
        private TextBox txtTemperaturaMedia;
        private Label lblMediaAnual;
    }
}