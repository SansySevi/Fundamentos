namespace Fundamentos
{
    partial class Form20TemperaturasAnualesClases
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
            this.lstMeses = new System.Windows.Forms.ListBox();
            this.lblMeses = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbYears = new System.Windows.Forms.ComboBox();
            this.btnGenerarTemperaturas = new System.Windows.Forms.Button();
            this.groupBoxDatosMes = new System.Windows.Forms.GroupBox();
            this.txtTemperaturaMedia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTemperaturaMinima = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTemperaturaMaxima = new System.Windows.Forms.TextBox();
            this.lblTemperaturaMaxima = new System.Windows.Forms.Label();
            this.groupBoxDatosAnuales = new System.Windows.Forms.GroupBox();
            this.txtMediaAnual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMinimaAnual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaximaAnual = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxDatosMes.SuspendLayout();
            this.groupBoxDatosAnuales.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMeses
            // 
            this.lstMeses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstMeses.FormattingEnabled = true;
            this.lstMeses.ItemHeight = 21;
            this.lstMeses.Location = new System.Drawing.Point(37, 121);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(220, 277);
            this.lstMeses.TabIndex = 13;
            this.lstMeses.SelectedIndexChanged += new System.EventHandler(this.lstMeses_SelectedIndexChanged);
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMeses.Location = new System.Drawing.Point(37, 97);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(54, 21);
            this.lblMeses.TabIndex = 12;
            this.lblMeses.Text = "Meses";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Años";
            // 
            // cmbYears
            // 
            this.cmbYears.FormattingEnabled = true;
            this.cmbYears.Location = new System.Drawing.Point(37, 54);
            this.cmbYears.Name = "cmbYears";
            this.cmbYears.Size = new System.Drawing.Size(182, 23);
            this.cmbYears.TabIndex = 15;
            this.cmbYears.SelectedIndexChanged += new System.EventHandler(this.cmbYears_SelecctedIndexChanged);
            // 
            // btnGenerarTemperaturas
            // 
            this.btnGenerarTemperaturas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerarTemperaturas.Location = new System.Drawing.Point(401, 32);
            this.btnGenerarTemperaturas.Name = "btnGenerarTemperaturas";
            this.btnGenerarTemperaturas.Size = new System.Drawing.Size(253, 45);
            this.btnGenerarTemperaturas.TabIndex = 16;
            this.btnGenerarTemperaturas.Text = "Generar temperaturas";
            this.btnGenerarTemperaturas.UseVisualStyleBackColor = true;
            this.btnGenerarTemperaturas.Click += new System.EventHandler(this.btnGenerarTemperaturas_Click);
            // 
            // groupBoxDatosMes
            // 
            this.groupBoxDatosMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBoxDatosMes.Controls.Add(this.txtTemperaturaMedia);
            this.groupBoxDatosMes.Controls.Add(this.label3);
            this.groupBoxDatosMes.Controls.Add(this.txtTemperaturaMinima);
            this.groupBoxDatosMes.Controls.Add(this.label2);
            this.groupBoxDatosMes.Controls.Add(this.txtTemperaturaMaxima);
            this.groupBoxDatosMes.Controls.Add(this.lblTemperaturaMaxima);
            this.groupBoxDatosMes.Location = new System.Drawing.Point(301, 121);
            this.groupBoxDatosMes.Name = "groupBoxDatosMes";
            this.groupBoxDatosMes.Size = new System.Drawing.Size(224, 277);
            this.groupBoxDatosMes.TabIndex = 17;
            this.groupBoxDatosMes.TabStop = false;
            this.groupBoxDatosMes.Text = "Datos del Mes";
            this.groupBoxDatosMes.Enter += new System.EventHandler(this.groupBoxDatosMes_Enter);
            // 
            // txtTemperaturaMedia
            // 
            this.txtTemperaturaMedia.Location = new System.Drawing.Point(62, 211);
            this.txtTemperaturaMedia.Name = "txtTemperaturaMedia";
            this.txtTemperaturaMedia.Size = new System.Drawing.Size(102, 23);
            this.txtTemperaturaMedia.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Temperatura media mensual";
            // 
            // txtTemperaturaMinima
            // 
            this.txtTemperaturaMinima.Location = new System.Drawing.Point(62, 140);
            this.txtTemperaturaMinima.Name = "txtTemperaturaMinima";
            this.txtTemperaturaMinima.Size = new System.Drawing.Size(102, 23);
            this.txtTemperaturaMinima.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Temperatura mínima";
            // 
            // txtTemperaturaMaxima
            // 
            this.txtTemperaturaMaxima.Location = new System.Drawing.Point(62, 70);
            this.txtTemperaturaMaxima.Name = "txtTemperaturaMaxima";
            this.txtTemperaturaMaxima.Size = new System.Drawing.Size(100, 23);
            this.txtTemperaturaMaxima.TabIndex = 17;
            // 
            // lblTemperaturaMaxima
            // 
            this.lblTemperaturaMaxima.AutoSize = true;
            this.lblTemperaturaMaxima.Location = new System.Drawing.Point(45, 52);
            this.lblTemperaturaMaxima.Name = "lblTemperaturaMaxima";
            this.lblTemperaturaMaxima.Size = new System.Drawing.Size(119, 15);
            this.lblTemperaturaMaxima.TabIndex = 16;
            this.lblTemperaturaMaxima.Text = "Temperatura máxima";
            // 
            // groupBoxDatosAnuales
            // 
            this.groupBoxDatosAnuales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBoxDatosAnuales.Controls.Add(this.txtMediaAnual);
            this.groupBoxDatosAnuales.Controls.Add(this.label4);
            this.groupBoxDatosAnuales.Controls.Add(this.txtMinimaAnual);
            this.groupBoxDatosAnuales.Controls.Add(this.label5);
            this.groupBoxDatosAnuales.Controls.Add(this.txtMaximaAnual);
            this.groupBoxDatosAnuales.Controls.Add(this.label6);
            this.groupBoxDatosAnuales.Location = new System.Drawing.Point(534, 121);
            this.groupBoxDatosAnuales.Name = "groupBoxDatosAnuales";
            this.groupBoxDatosAnuales.Size = new System.Drawing.Size(224, 277);
            this.groupBoxDatosAnuales.TabIndex = 22;
            this.groupBoxDatosAnuales.TabStop = false;
            this.groupBoxDatosAnuales.Text = "Datos Anuales";
            // 
            // txtMediaAnual
            // 
            this.txtMediaAnual.Location = new System.Drawing.Point(62, 211);
            this.txtMediaAnual.Name = "txtMediaAnual";
            this.txtMediaAnual.Size = new System.Drawing.Size(100, 23);
            this.txtMediaAnual.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Temperatura media anual";
            // 
            // txtMinimaAnual
            // 
            this.txtMinimaAnual.Location = new System.Drawing.Point(62, 140);
            this.txtMinimaAnual.Name = "txtMinimaAnual";
            this.txtMinimaAnual.Size = new System.Drawing.Size(100, 23);
            this.txtMinimaAnual.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Temperatura mínima";
            // 
            // txtMaximaAnual
            // 
            this.txtMaximaAnual.Location = new System.Drawing.Point(62, 70);
            this.txtMaximaAnual.Name = "txtMaximaAnual";
            this.txtMaximaAnual.Size = new System.Drawing.Size(100, 23);
            this.txtMaximaAnual.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Temperatura máxima";
            // 
            // Form20TemperaturasAnualesClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxDatosAnuales);
            this.Controls.Add(this.groupBoxDatosMes);
            this.Controls.Add(this.btnGenerarTemperaturas);
            this.Controls.Add(this.cmbYears);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstMeses);
            this.Controls.Add(this.lblMeses);
            this.Name = "Form20TemperaturasAnualesClases";
            this.Text = "Form20TemperaturasAnualesClases";
            this.groupBoxDatosMes.ResumeLayout(false);
            this.groupBoxDatosMes.PerformLayout();
            this.groupBoxDatosAnuales.ResumeLayout(false);
            this.groupBoxDatosAnuales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstMeses;
        private Label lblMeses;
        private Label label1;
        private ComboBox cmbYears;
        private Button btnGenerarTemperaturas;
        private GroupBox groupBoxDatosMes;
        private TextBox txtTemperaturaMaxima;
        private Label lblTemperaturaMaxima;
        private TextBox txtTemperaturaMedia;
        private Label label3;
        private TextBox txtTemperaturaMinima;
        private Label label2;
        private GroupBox groupBoxDatosAnuales;
        private TextBox txtMediaAnual;
        private Label label4;
        private TextBox txtMinimaAnual;
        private Label label5;
        private TextBox txtMaximaAnual;
        private Label label6;
    }
}