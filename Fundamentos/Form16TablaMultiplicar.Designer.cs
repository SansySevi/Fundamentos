namespace Fundamentos
{
    partial class Form16TablaMultiplicar
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnMostrarTabla = new System.Windows.Forms.Button();
            this.groupBoxTabla = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxTabla.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumero.Location = new System.Drawing.Point(50, 60);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(68, 21);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número";
            this.lblNumero.Click += new System.EventHandler(this.lblNumero_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(50, 93);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(127, 29);
            this.txtNumero.TabIndex = 1;
            // 
            // btnMostrarTabla
            // 
            this.btnMostrarTabla.Location = new System.Drawing.Point(50, 176);
            this.btnMostrarTabla.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarTabla.Name = "btnMostrarTabla";
            this.btnMostrarTabla.Size = new System.Drawing.Size(184, 70);
            this.btnMostrarTabla.TabIndex = 2;
            this.btnMostrarTabla.Text = "Mostrar tabla";
            this.btnMostrarTabla.UseVisualStyleBackColor = true;
            this.btnMostrarTabla.Click += new System.EventHandler(this.btnMostrarTabla_Click);
            // 
            // groupBoxTabla
            // 
            this.groupBoxTabla.Controls.Add(this.textBox5);
            this.groupBoxTabla.Controls.Add(this.textBox4);
            this.groupBoxTabla.Controls.Add(this.textBox3);
            this.groupBoxTabla.Controls.Add(this.textBox2);
            this.groupBoxTabla.Controls.Add(this.textBox1);
            this.groupBoxTabla.Location = new System.Drawing.Point(302, 44);
            this.groupBoxTabla.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxTabla.Name = "groupBoxTabla";
            this.groupBoxTabla.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxTabla.Size = new System.Drawing.Size(228, 338);
            this.groupBoxTabla.TabIndex = 3;
            this.groupBoxTabla.TabStop = false;
            this.groupBoxTabla.Text = "Tabla Multiplicar";
            this.groupBoxTabla.Enter += new System.EventHandler(this.groupBoxTabla_Enter);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(50, 49);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(134, 29);
            this.textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(50, 103);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(134, 29);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(50, 154);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(134, 29);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(50, 215);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 29);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 272);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 29);
            this.textBox1.TabIndex = 0;
            // 
            // Form16TablaMultiplicar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 411);
            this.Controls.Add(this.groupBoxTabla);
            this.Controls.Add(this.btnMostrarTabla);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form16TablaMultiplicar";
            this.Text = "Form16TablaMultiplicar";
            this.groupBoxTabla.ResumeLayout(false);
            this.groupBoxTabla.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNumero;
        private TextBox txtNumero;
        private Button btnMostrarTabla;
        private GroupBox groupBoxTabla;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}