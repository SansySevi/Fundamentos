namespace Fundamentos
{
    partial class Form4DateTime
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
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.txtFechaActual = new System.Windows.Forms.TextBox();
            this.chkFormato = new System.Windows.Forms.CheckBox();
            this.gpbIncermentarFecha = new System.Windows.Forms.GroupBox();
            this.btnIncrementar = new System.Windows.Forms.Button();
            this.txtIncremento = new System.Windows.Forms.TextBox();
            this.lblIncremento = new System.Windows.Forms.Label();
            this.rdbAnyos = new System.Windows.Forms.RadioButton();
            this.rdbMeses = new System.Windows.Forms.RadioButton();
            this.rdbDias = new System.Windows.Forms.RadioButton();
            this.lblNuevaFecha = new System.Windows.Forms.Label();
            this.txtNuevaFecha = new System.Windows.Forms.TextBox();
            this.gpbIncermentarFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaActual.Location = new System.Drawing.Point(26, 38);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(117, 25);
            this.lblFechaActual.TabIndex = 0;
            this.lblFechaActual.Text = "Fecha actual";
            // 
            // txtFechaActual
            // 
            this.txtFechaActual.Location = new System.Drawing.Point(35, 66);
            this.txtFechaActual.Name = "txtFechaActual";
            this.txtFechaActual.Size = new System.Drawing.Size(165, 23);
            this.txtFechaActual.TabIndex = 1;
            // 
            // chkFormato
            // 
            this.chkFormato.AutoSize = true;
            this.chkFormato.Location = new System.Drawing.Point(35, 95);
            this.chkFormato.Name = "chkFormato";
            this.chkFormato.Size = new System.Drawing.Size(153, 19);
            this.chkFormato.TabIndex = 2;
            this.chkFormato.Text = "Cambiar Formato Fecha";
            this.chkFormato.UseVisualStyleBackColor = true;
            this.chkFormato.CheckedChanged += new System.EventHandler(this.chkFormato_CheckedChanged);
            // 
            // gpbIncermentarFecha
            // 
            this.gpbIncermentarFecha.Controls.Add(this.btnIncrementar);
            this.gpbIncermentarFecha.Controls.Add(this.txtIncremento);
            this.gpbIncermentarFecha.Controls.Add(this.lblIncremento);
            this.gpbIncermentarFecha.Controls.Add(this.rdbAnyos);
            this.gpbIncermentarFecha.Controls.Add(this.rdbMeses);
            this.gpbIncermentarFecha.Controls.Add(this.rdbDias);
            this.gpbIncermentarFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpbIncermentarFecha.Location = new System.Drawing.Point(35, 147);
            this.gpbIncermentarFecha.Name = "gpbIncermentarFecha";
            this.gpbIncermentarFecha.Size = new System.Drawing.Size(395, 183);
            this.gpbIncermentarFecha.TabIndex = 3;
            this.gpbIncermentarFecha.TabStop = false;
            this.gpbIncermentarFecha.Text = "Incrementar Fecha";
            // 
            // btnIncrementar
            // 
            this.btnIncrementar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIncrementar.Location = new System.Drawing.Point(160, 81);
            this.btnIncrementar.Name = "btnIncrementar";
            this.btnIncrementar.Size = new System.Drawing.Size(163, 30);
            this.btnIncrementar.TabIndex = 5;
            this.btnIncrementar.Text = "Incrementar";
            this.btnIncrementar.UseVisualStyleBackColor = true;
            this.btnIncrementar.Click += new System.EventHandler(this.btnIncrementar_Click);
            // 
            // txtIncremento
            // 
            this.txtIncremento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIncremento.Location = new System.Drawing.Point(235, 37);
            this.txtIncremento.Name = "txtIncremento";
            this.txtIncremento.Size = new System.Drawing.Size(88, 25);
            this.txtIncremento.TabIndex = 4;
            // 
            // lblIncremento
            // 
            this.lblIncremento.AutoSize = true;
            this.lblIncremento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIncremento.Location = new System.Drawing.Point(145, 42);
            this.lblIncremento.Name = "lblIncremento";
            this.lblIncremento.Size = new System.Drawing.Size(84, 20);
            this.lblIncremento.TabIndex = 3;
            this.lblIncremento.Text = "Incremento";
            // 
            // rdbAnyos
            // 
            this.rdbAnyos.AutoSize = true;
            this.rdbAnyos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbAnyos.Location = new System.Drawing.Point(21, 128);
            this.rdbAnyos.Name = "rdbAnyos";
            this.rdbAnyos.Size = new System.Drawing.Size(55, 21);
            this.rdbAnyos.TabIndex = 2;
            this.rdbAnyos.TabStop = true;
            this.rdbAnyos.Text = "Años";
            this.rdbAnyos.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            this.rdbMeses.AutoSize = true;
            this.rdbMeses.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbMeses.Location = new System.Drawing.Point(21, 87);
            this.rdbMeses.Name = "rdbMeses";
            this.rdbMeses.Size = new System.Drawing.Size(64, 21);
            this.rdbMeses.TabIndex = 1;
            this.rdbMeses.TabStop = true;
            this.rdbMeses.Text = "Meses";
            this.rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbDias
            // 
            this.rdbDias.AutoSize = true;
            this.rdbDias.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbDias.Location = new System.Drawing.Point(21, 42);
            this.rdbDias.Name = "rdbDias";
            this.rdbDias.Size = new System.Drawing.Size(51, 21);
            this.rdbDias.TabIndex = 0;
            this.rdbDias.TabStop = true;
            this.rdbDias.Text = "Dias";
            this.rdbDias.UseVisualStyleBackColor = true;
            this.rdbDias.CheckedChanged += new System.EventHandler(this.rdbDias_CheckedChanged);
            // 
            // lblNuevaFecha
            // 
            this.lblNuevaFecha.AutoSize = true;
            this.lblNuevaFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNuevaFecha.Location = new System.Drawing.Point(43, 350);
            this.lblNuevaFecha.Name = "lblNuevaFecha";
            this.lblNuevaFecha.Size = new System.Drawing.Size(96, 21);
            this.lblNuevaFecha.TabIndex = 4;
            this.lblNuevaFecha.Text = "Nueva fecha";
            // 
            // txtNuevaFecha
            // 
            this.txtNuevaFecha.Location = new System.Drawing.Point(52, 375);
            this.txtNuevaFecha.Name = "txtNuevaFecha";
            this.txtNuevaFecha.Size = new System.Drawing.Size(378, 23);
            this.txtNuevaFecha.TabIndex = 5;
            // 
            // Form4DateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 450);
            this.Controls.Add(this.txtNuevaFecha);
            this.Controls.Add(this.lblNuevaFecha);
            this.Controls.Add(this.gpbIncermentarFecha);
            this.Controls.Add(this.chkFormato);
            this.Controls.Add(this.txtFechaActual);
            this.Controls.Add(this.lblFechaActual);
            this.Name = "Form4DateTime";
            this.Text = "Form4DateTime";
            this.gpbIncermentarFecha.ResumeLayout(false);
            this.gpbIncermentarFecha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFechaActual;
        private TextBox txtFechaActual;
        private CheckBox chkFormato;
        private GroupBox gpbIncermentarFecha;
        private TextBox txtIncremento;
        private Label lblIncremento;
        private RadioButton rdbAnyos;
        private RadioButton rdbMeses;
        private RadioButton rdbDias;
        private Button btnIncrementar;
        private Label lblNuevaFecha;
        private TextBox txtNuevaFecha;
    }
}