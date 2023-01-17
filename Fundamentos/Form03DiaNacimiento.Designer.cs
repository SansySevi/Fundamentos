namespace Fundamentos
{
    partial class Form03DiaNacimiento
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
            this.lblMes = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAnyo = new System.Windows.Forms.TextBox();
            this.btnCalcularDia = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(48, 108);
            this.lblMes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(47, 25);
            this.lblMes.TabIndex = 0;
            this.lblMes.Text = "Mes";
            this.lblMes.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(49, 48);
            this.lblDia.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(40, 25);
            this.lblDia.TabIndex = 1;
            this.lblDia.Text = "Día";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(49, 171);
            this.lblAnio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(46, 25);
            this.lblAnio.TabIndex = 2;
            this.lblAnio.Text = "Año";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(110, 40);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(100, 33);
            this.txtDia.TabIndex = 3;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(110, 100);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(100, 33);
            this.txtMes.TabIndex = 4;
            // 
            // txtAnyo
            // 
            this.txtAnyo.Location = new System.Drawing.Point(110, 163);
            this.txtAnyo.Name = "txtAnyo";
            this.txtAnyo.Size = new System.Drawing.Size(100, 33);
            this.txtAnyo.TabIndex = 5;
            // 
            // btnCalcularDia
            // 
            this.btnCalcularDia.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcularDia.Location = new System.Drawing.Point(289, 59);
            this.btnCalcularDia.Name = "btnCalcularDia";
            this.btnCalcularDia.Size = new System.Drawing.Size(127, 123);
            this.btnCalcularDia.TabIndex = 6;
            this.btnCalcularDia.Text = "Calcular día";
            this.btnCalcularDia.UseVisualStyleBackColor = true;
            this.btnCalcularDia.Click += new System.EventHandler(this.btnCalcularDia_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(49, 256);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 25);
            this.lblResultado.TabIndex = 7;
            // 
            // Form03DiaNacimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 387);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcularDia);
            this.Controls.Add(this.txtAnyo);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblMes);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form03DiaNacimiento";
            this.Text = "Form03DiaNacimiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMes;
        private Label lblDia;
        private Label lblAnio;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtAnyo;
        private Button btnCalcularDia;
        private Label lblResultado;
    }
}