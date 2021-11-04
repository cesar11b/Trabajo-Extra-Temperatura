
namespace Transformacion_de_grados
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbPasarde = new System.Windows.Forms.GroupBox();
            this.rbKelvin = new System.Windows.Forms.RadioButton();
            this.rbFahrenheit = new System.Windows.Forms.RadioButton();
            this.rbCelcius = new System.Windows.Forms.RadioButton();
            this.gbA = new System.Windows.Forms.GroupBox();
            this.rbKelvinSal = new System.Windows.Forms.RadioButton();
            this.rbFahrenheitSal = new System.Windows.Forms.RadioButton();
            this.rbCelciusSal = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.txtingdat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbhistorial = new System.Windows.Forms.RichTextBox();
            this.gbPasarde.SuspendLayout();
            this.gbA.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPasarde
            // 
            this.gbPasarde.Controls.Add(this.rbKelvin);
            this.gbPasarde.Controls.Add(this.rbFahrenheit);
            this.gbPasarde.Controls.Add(this.rbCelcius);
            this.gbPasarde.Location = new System.Drawing.Point(12, 31);
            this.gbPasarde.Name = "gbPasarde";
            this.gbPasarde.Size = new System.Drawing.Size(200, 100);
            this.gbPasarde.TabIndex = 0;
            this.gbPasarde.TabStop = false;
            this.gbPasarde.Text = "Pasar de:";
            // 
            // rbKelvin
            // 
            this.rbKelvin.AutoSize = true;
            this.rbKelvin.Location = new System.Drawing.Point(7, 68);
            this.rbKelvin.Name = "rbKelvin";
            this.rbKelvin.Size = new System.Drawing.Size(54, 17);
            this.rbKelvin.TabIndex = 2;
            this.rbKelvin.TabStop = true;
            this.rbKelvin.Text = "Kelvin";
            this.rbKelvin.UseVisualStyleBackColor = true;
            // 
            // rbFahrenheit
            // 
            this.rbFahrenheit.AutoSize = true;
            this.rbFahrenheit.Location = new System.Drawing.Point(7, 44);
            this.rbFahrenheit.Name = "rbFahrenheit";
            this.rbFahrenheit.Size = new System.Drawing.Size(75, 17);
            this.rbFahrenheit.TabIndex = 1;
            this.rbFahrenheit.TabStop = true;
            this.rbFahrenheit.Text = "Fahrenheit";
            this.rbFahrenheit.UseVisualStyleBackColor = true;
            // 
            // rbCelcius
            // 
            this.rbCelcius.AutoSize = true;
            this.rbCelcius.Location = new System.Drawing.Point(7, 20);
            this.rbCelcius.Name = "rbCelcius";
            this.rbCelcius.Size = new System.Drawing.Size(59, 17);
            this.rbCelcius.TabIndex = 0;
            this.rbCelcius.TabStop = true;
            this.rbCelcius.Text = "Celcius";
            this.rbCelcius.UseVisualStyleBackColor = true;
            this.rbCelcius.CheckedChanged += new System.EventHandler(this.rbCelcius_CheckedChanged);
            // 
            // gbA
            // 
            this.gbA.Controls.Add(this.rbKelvinSal);
            this.gbA.Controls.Add(this.rbFahrenheitSal);
            this.gbA.Controls.Add(this.rbCelciusSal);
            this.gbA.Location = new System.Drawing.Point(237, 31);
            this.gbA.Name = "gbA";
            this.gbA.Size = new System.Drawing.Size(200, 100);
            this.gbA.TabIndex = 1;
            this.gbA.TabStop = false;
            this.gbA.Text = "A:";
            // 
            // rbKelvinSal
            // 
            this.rbKelvinSal.AutoSize = true;
            this.rbKelvinSal.Location = new System.Drawing.Point(7, 68);
            this.rbKelvinSal.Name = "rbKelvinSal";
            this.rbKelvinSal.Size = new System.Drawing.Size(54, 17);
            this.rbKelvinSal.TabIndex = 2;
            this.rbKelvinSal.TabStop = true;
            this.rbKelvinSal.Text = "Kelvin";
            this.rbKelvinSal.UseVisualStyleBackColor = true;
            // 
            // rbFahrenheitSal
            // 
            this.rbFahrenheitSal.AutoSize = true;
            this.rbFahrenheitSal.Location = new System.Drawing.Point(7, 44);
            this.rbFahrenheitSal.Name = "rbFahrenheitSal";
            this.rbFahrenheitSal.Size = new System.Drawing.Size(75, 17);
            this.rbFahrenheitSal.TabIndex = 1;
            this.rbFahrenheitSal.TabStop = true;
            this.rbFahrenheitSal.Text = "Fahrenheit";
            this.rbFahrenheitSal.UseVisualStyleBackColor = true;
            // 
            // rbCelciusSal
            // 
            this.rbCelciusSal.AutoSize = true;
            this.rbCelciusSal.Location = new System.Drawing.Point(7, 20);
            this.rbCelciusSal.Name = "rbCelciusSal";
            this.rbCelciusSal.Size = new System.Drawing.Size(59, 17);
            this.rbCelciusSal.TabIndex = 0;
            this.rbCelciusSal.TabStop = true;
            this.rbCelciusSal.Text = "Celcius";
            this.rbCelciusSal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Que transformacion va a hacer?";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(19, 262);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 3;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // txtingdat
            // 
            this.txtingdat.Location = new System.Drawing.Point(203, 153);
            this.txtingdat.Name = "txtingdat";
            this.txtingdat.Size = new System.Drawing.Size(100, 20);
            this.txtingdat.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese unidades a transformar:";
            // 
            // rtbhistorial
            // 
            this.rtbhistorial.Location = new System.Drawing.Point(203, 200);
            this.rtbhistorial.Name = "rtbhistorial";
            this.rtbhistorial.Size = new System.Drawing.Size(300, 189);
            this.rtbhistorial.TabIndex = 6;
            this.rtbhistorial.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.rtbhistorial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtingdat);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbA);
            this.Controls.Add(this.gbPasarde);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPasarde.ResumeLayout(false);
            this.gbPasarde.PerformLayout();
            this.gbA.ResumeLayout(false);
            this.gbA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPasarde;
        private System.Windows.Forms.RadioButton rbKelvin;
        private System.Windows.Forms.RadioButton rbFahrenheit;
        private System.Windows.Forms.RadioButton rbCelcius;
        private System.Windows.Forms.GroupBox gbA;
        private System.Windows.Forms.RadioButton rbKelvinSal;
        private System.Windows.Forms.RadioButton rbFahrenheitSal;
        private System.Windows.Forms.RadioButton rbCelciusSal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.TextBox txtingdat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbhistorial;
    }
}

