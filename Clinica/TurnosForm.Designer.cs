namespace Clinica_v1
{
    partial class TurnosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TurnosForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.motivoBox = new System.Windows.Forms.TextBox();
            this.motivo_Label = new System.Windows.Forms.Label();
            this.hora_Label = new System.Windows.Forms.Label();
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.fecha_Label = new System.Windows.Forms.Label();
            this.dtp_Hora = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btn_Guardar);
            this.panel1.Controls.Add(this.motivoBox);
            this.panel1.Controls.Add(this.motivo_Label);
            this.panel1.Controls.Add(this.hora_Label);
            this.panel1.Controls.Add(this.dtp_Fecha);
            this.panel1.Controls.Add(this.fecha_Label);
            this.panel1.Controls.Add(this.dtp_Hora);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 495);
            this.panel1.TabIndex = 0;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Location = new System.Drawing.Point(261, 431);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(159, 38);
            this.btn_Guardar.TabIndex = 8;
            this.btn_Guardar.Text = "GUARDAR";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // motivoBox
            // 
            this.motivoBox.Location = new System.Drawing.Point(27, 255);
            this.motivoBox.Multiline = true;
            this.motivoBox.Name = "motivoBox";
            this.motivoBox.Size = new System.Drawing.Size(625, 122);
            this.motivoBox.TabIndex = 7;
            // 
            // motivo_Label
            // 
            this.motivo_Label.AutoSize = true;
            this.motivo_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motivo_Label.ForeColor = System.Drawing.Color.White;
            this.motivo_Label.Location = new System.Drawing.Point(22, 209);
            this.motivo_Label.Name = "motivo_Label";
            this.motivo_Label.Size = new System.Drawing.Size(83, 25);
            this.motivo_Label.TabIndex = 6;
            this.motivo_Label.Text = "Motivo:";
            // 
            // hora_Label
            // 
            this.hora_Label.AutoSize = true;
            this.hora_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora_Label.ForeColor = System.Drawing.Color.White;
            this.hora_Label.Location = new System.Drawing.Point(22, 152);
            this.hora_Label.Name = "hora_Label";
            this.hora_Label.Size = new System.Drawing.Size(65, 25);
            this.hora_Label.TabIndex = 5;
            this.hora_Label.Text = "Hora:";
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.Location = new System.Drawing.Point(129, 77);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(523, 26);
            this.dtp_Fecha.TabIndex = 4;
            // 
            // fecha_Label
            // 
            this.fecha_Label.AutoSize = true;
            this.fecha_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_Label.ForeColor = System.Drawing.Color.White;
            this.fecha_Label.Location = new System.Drawing.Point(22, 82);
            this.fecha_Label.Name = "fecha_Label";
            this.fecha_Label.Size = new System.Drawing.Size(79, 25);
            this.fecha_Label.TabIndex = 3;
            this.fecha_Label.Text = "Fecha:";
            // 
            // dtp_Hora
            // 
            this.dtp_Hora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_Hora.Location = new System.Drawing.Point(129, 148);
            this.dtp_Hora.Name = "dtp_Hora";
            this.dtp_Hora.ShowUpDown = true;
            this.dtp_Hora.Size = new System.Drawing.Size(523, 26);
            this.dtp_Hora.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Location = new System.Drawing.Point(0, 405);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(682, 91);
            this.panel2.TabIndex = 9;
            // 
            // TurnosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 495);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TurnosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turno";
            this.Load += new System.EventHandler(this.TurnosForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtp_Hora;
        private System.Windows.Forms.Label fecha_Label;
        private System.Windows.Forms.Label hora_Label;
        private System.Windows.Forms.DateTimePicker dtp_Fecha;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.TextBox motivoBox;
        private System.Windows.Forms.Label motivo_Label;
        private System.Windows.Forms.Panel panel2;
    }
}