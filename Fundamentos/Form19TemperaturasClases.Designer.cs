namespace Fundamentos
{
    partial class Form19TemperaturasClases
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
            this.txtTemperaturaMedia = new System.Windows.Forms.TextBox();
            this.lblMediaAnual = new System.Windows.Forms.Label();
            this.txtTemperaturaMinima = new System.Windows.Forms.TextBox();
            this.lblTemperaturaMinima = new System.Windows.Forms.Label();
            this.txtTemperaturaMaxima = new System.Windows.Forms.TextBox();
            this.lblTemperaturaMaxima = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lstMeses = new System.Windows.Forms.ListBox();
            this.lblMeses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTemperaturaMedia
            // 
            this.txtTemperaturaMedia.Location = new System.Drawing.Point(345, 325);
            this.txtTemperaturaMedia.Name = "txtTemperaturaMedia";
            this.txtTemperaturaMedia.Size = new System.Drawing.Size(87, 23);
            this.txtTemperaturaMedia.TabIndex = 19;
            // 
            // lblMediaAnual
            // 
            this.lblMediaAnual.AutoSize = true;
            this.lblMediaAnual.Location = new System.Drawing.Point(328, 307);
            this.lblMediaAnual.Name = "lblMediaAnual";
            this.lblMediaAnual.Size = new System.Drawing.Size(72, 15);
            this.lblMediaAnual.TabIndex = 18;
            this.lblMediaAnual.Text = "Media anual";
            // 
            // txtTemperaturaMinima
            // 
            this.txtTemperaturaMinima.Location = new System.Drawing.Point(345, 257);
            this.txtTemperaturaMinima.Name = "txtTemperaturaMinima";
            this.txtTemperaturaMinima.Size = new System.Drawing.Size(87, 23);
            this.txtTemperaturaMinima.TabIndex = 17;
            // 
            // lblTemperaturaMinima
            // 
            this.lblTemperaturaMinima.AutoSize = true;
            this.lblTemperaturaMinima.Location = new System.Drawing.Point(328, 239);
            this.lblTemperaturaMinima.Name = "lblTemperaturaMinima";
            this.lblTemperaturaMinima.Size = new System.Drawing.Size(117, 15);
            this.lblTemperaturaMinima.TabIndex = 16;
            this.lblTemperaturaMinima.Text = "Temperatura minima";
            // 
            // txtTemperaturaMaxima
            // 
            this.txtTemperaturaMaxima.Location = new System.Drawing.Point(345, 181);
            this.txtTemperaturaMaxima.Name = "txtTemperaturaMaxima";
            this.txtTemperaturaMaxima.Size = new System.Drawing.Size(87, 23);
            this.txtTemperaturaMaxima.TabIndex = 15;
            // 
            // lblTemperaturaMaxima
            // 
            this.lblTemperaturaMaxima.AutoSize = true;
            this.lblTemperaturaMaxima.Location = new System.Drawing.Point(328, 163);
            this.lblTemperaturaMaxima.Name = "lblTemperaturaMaxima";
            this.lblTemperaturaMaxima.Size = new System.Drawing.Size(119, 15);
            this.lblTemperaturaMaxima.TabIndex = 14;
            this.lblTemperaturaMaxima.Text = "Temperatura máxima";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(328, 81);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(135, 42);
            this.btnGenerar.TabIndex = 12;
            this.btnGenerar.Text = "Generar meses";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lstMeses
            // 
            this.lstMeses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstMeses.FormattingEnabled = true;
            this.lstMeses.ItemHeight = 21;
            this.lstMeses.Location = new System.Drawing.Point(34, 69);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(220, 319);
            this.lstMeses.TabIndex = 11;
            this.lstMeses.SelectedIndexChanged += new System.EventHandler(this.lstMeses_SelectedIndexChanged);
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMeses.Location = new System.Drawing.Point(34, 32);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(54, 21);
            this.lblMeses.TabIndex = 10;
            this.lblMeses.Text = "Meses";
            // 
            // Form19TemperaturasClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.txtTemperaturaMedia);
            this.Controls.Add(this.lblMediaAnual);
            this.Controls.Add(this.txtTemperaturaMinima);
            this.Controls.Add(this.lblTemperaturaMinima);
            this.Controls.Add(this.txtTemperaturaMaxima);
            this.Controls.Add(this.lblTemperaturaMaxima);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lstMeses);
            this.Controls.Add(this.lblMeses);
            this.Name = "Form19TemperaturasClases";
            this.Text = "Form19TemperaturasClases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTemperaturaMedia;
        private Label lblMediaAnual;
        private TextBox txtTemperaturaMinima;
        private Label lblTemperaturaMinima;
        private TextBox txtTemperaturaMaxima;
        private Label lblTemperaturaMaxima;
        private Button btnGenerar;
        private ListBox lstMeses;
        private Label lblMeses;
    }
}