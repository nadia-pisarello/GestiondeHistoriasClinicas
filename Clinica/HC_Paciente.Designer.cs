namespace Clinica_v1
{
    partial class HC_Paciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HC_Paciente));
            this.fechaDTP = new System.Windows.Forms.DateTimePicker();
            this.sintomas = new System.Windows.Forms.Label();
            this.diagnostico = new System.Windows.Forms.Label();
            this.estudiosLabel = new System.Windows.Forms.Label();
            this.sintomasBox = new System.Windows.Forms.TextBox();
            this.diagnosticoBox = new System.Windows.Forms.TextBox();
            this.estudiosBox = new System.Windows.Forms.TextBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.motivoBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.medicacionBox = new System.Windows.Forms.TextBox();
            this.medicacionLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fechaDTP
            // 
            this.fechaDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDTP.Location = new System.Drawing.Point(812, 158);
            this.fechaDTP.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.fechaDTP.Name = "fechaDTP";
            this.fechaDTP.Size = new System.Drawing.Size(386, 30);
            this.fechaDTP.TabIndex = 0;
            // 
            // sintomas
            // 
            this.sintomas.AutoSize = true;
            this.sintomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sintomas.ForeColor = System.Drawing.Color.White;
            this.sintomas.Location = new System.Drawing.Point(615, 378);
            this.sintomas.Name = "sintomas";
            this.sintomas.Size = new System.Drawing.Size(102, 25);
            this.sintomas.TabIndex = 1;
            this.sintomas.Text = "Sintomas";
            // 
            // diagnostico
            // 
            this.diagnostico.AutoSize = true;
            this.diagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnostico.ForeColor = System.Drawing.Color.White;
            this.diagnostico.Location = new System.Drawing.Point(20, 382);
            this.diagnostico.Name = "diagnostico";
            this.diagnostico.Size = new System.Drawing.Size(125, 25);
            this.diagnostico.TabIndex = 2;
            this.diagnostico.Text = "Diagnóstico";
            // 
            // estudiosLabel
            // 
            this.estudiosLabel.AutoSize = true;
            this.estudiosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estudiosLabel.ForeColor = System.Drawing.Color.White;
            this.estudiosLabel.Location = new System.Drawing.Point(14, 562);
            this.estudiosLabel.Name = "estudiosLabel";
            this.estudiosLabel.Size = new System.Drawing.Size(95, 25);
            this.estudiosLabel.TabIndex = 3;
            this.estudiosLabel.Text = "Estudios";
            // 
            // sintomasBox
            // 
            this.sintomasBox.Location = new System.Drawing.Point(618, 414);
            this.sintomasBox.Multiline = true;
            this.sintomasBox.Name = "sintomasBox";
            this.sintomasBox.Size = new System.Drawing.Size(589, 89);
            this.sintomasBox.TabIndex = 4;
            // 
            // diagnosticoBox
            // 
            this.diagnosticoBox.Location = new System.Drawing.Point(16, 414);
            this.diagnosticoBox.Multiline = true;
            this.diagnosticoBox.Name = "diagnosticoBox";
            this.diagnosticoBox.Size = new System.Drawing.Size(590, 89);
            this.diagnosticoBox.TabIndex = 5;
            // 
            // estudiosBox
            // 
            this.estudiosBox.Location = new System.Drawing.Point(16, 594);
            this.estudiosBox.Multiline = true;
            this.estudiosBox.Name = "estudiosBox";
            this.estudiosBox.Size = new System.Drawing.Size(584, 89);
            this.estudiosBox.TabIndex = 6;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(534, 802);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(154, 42);
            this.btn_Aceptar.TabIndex = 7;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // motivoBox
            // 
            this.motivoBox.Location = new System.Drawing.Point(16, 245);
            this.motivoBox.Multiline = true;
            this.motivoBox.Name = "motivoBox";
            this.motivoBox.Size = new System.Drawing.Size(1190, 89);
            this.motivoBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Motivo de la consulta";
            // 
            // medicacionBox
            // 
            this.medicacionBox.Location = new System.Drawing.Point(612, 594);
            this.medicacionBox.Multiline = true;
            this.medicacionBox.Name = "medicacionBox";
            this.medicacionBox.Size = new System.Drawing.Size(595, 89);
            this.medicacionBox.TabIndex = 11;
            // 
            // medicacionLabel
            // 
            this.medicacionLabel.AutoSize = true;
            this.medicacionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicacionLabel.ForeColor = System.Drawing.Color.White;
            this.medicacionLabel.Location = new System.Drawing.Point(609, 562);
            this.medicacionLabel.Name = "medicacionLabel";
            this.medicacionLabel.Size = new System.Drawing.Size(122, 25);
            this.medicacionLabel.TabIndex = 10;
            this.medicacionLabel.Text = "Medicación";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Location = new System.Drawing.Point(-6, 766);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 120);
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(494, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 33);
            this.label2.TabIndex = 13;
            this.label2.Text = "Formulario Clinico";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-3, -2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1234, 118);
            this.panel2.TabIndex = 13;
            // 
            // HC_Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1226, 882);
            this.Controls.Add(this.medicacionBox);
            this.Controls.Add(this.medicacionLabel);
            this.Controls.Add(this.motivoBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.estudiosBox);
            this.Controls.Add(this.diagnosticoBox);
            this.Controls.Add(this.sintomasBox);
            this.Controls.Add(this.estudiosLabel);
            this.Controls.Add(this.diagnostico);
            this.Controls.Add(this.sintomas);
            this.Controls.Add(this.fechaDTP);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HC_Paciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historia Clínica";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fechaDTP;
        private System.Windows.Forms.Label sintomas;
        private System.Windows.Forms.Label diagnostico;
        private System.Windows.Forms.Label estudiosLabel;
        private System.Windows.Forms.TextBox sintomasBox;
        private System.Windows.Forms.TextBox diagnosticoBox;
        private System.Windows.Forms.TextBox estudiosBox;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.TextBox motivoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox medicacionBox;
        private System.Windows.Forms.Label medicacionLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}