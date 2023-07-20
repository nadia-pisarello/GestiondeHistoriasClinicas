namespace Clinica_v1
{
    partial class InformacionPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformacionPaciente));
            this.infoDataGridView = new System.Windows.Forms.DataGridView();
            this.panel_Global = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.historia_Dgv = new System.Windows.Forms.DataGridView();
            this.turno_Dgv = new System.Windows.Forms.DataGridView();
            this.historiaLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExcel = new System.Windows.Forms.Button();
            this.datosLabel = new System.Windows.Forms.Label();
            this.label_Turno = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infoDataGridView)).BeginInit();
            this.panel_Global.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historia_Dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turno_Dgv)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoDataGridView
            // 
            this.infoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoDataGridView.Location = new System.Drawing.Point(16, 163);
            this.infoDataGridView.Name = "infoDataGridView";
            this.infoDataGridView.RowHeadersWidth = 62;
            this.infoDataGridView.RowTemplate.Height = 28;
            this.infoDataGridView.Size = new System.Drawing.Size(1407, 129);
            this.infoDataGridView.TabIndex = 0;
            // 
            // panel_Global
            // 
            this.panel_Global.Controls.Add(this.panel1);
            this.panel_Global.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Global.Location = new System.Drawing.Point(0, 0);
            this.panel_Global.Name = "panel_Global";
            this.panel_Global.Size = new System.Drawing.Size(1440, 898);
            this.panel_Global.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.historia_Dgv);
            this.panel1.Controls.Add(this.turno_Dgv);
            this.panel1.Controls.Add(this.historiaLabel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.datosLabel);
            this.panel1.Controls.Add(this.infoDataGridView);
            this.panel1.Controls.Add(this.label_Turno);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1440, 898);
            this.panel1.TabIndex = 6;
            // 
            // historia_Dgv
            // 
            this.historia_Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historia_Dgv.Location = new System.Drawing.Point(16, 354);
            this.historia_Dgv.Name = "historia_Dgv";
            this.historia_Dgv.RowHeadersWidth = 62;
            this.historia_Dgv.RowTemplate.Height = 28;
            this.historia_Dgv.Size = new System.Drawing.Size(1407, 202);
            this.historia_Dgv.TabIndex = 3;
            // 
            // turno_Dgv
            // 
            this.turno_Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.turno_Dgv.Location = new System.Drawing.Point(16, 606);
            this.turno_Dgv.Name = "turno_Dgv";
            this.turno_Dgv.RowHeadersWidth = 62;
            this.turno_Dgv.RowTemplate.Height = 28;
            this.turno_Dgv.Size = new System.Drawing.Size(1407, 157);
            this.turno_Dgv.TabIndex = 4;
            // 
            // historiaLabel
            // 
            this.historiaLabel.AutoSize = true;
            this.historiaLabel.BackColor = System.Drawing.Color.DimGray;
            this.historiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historiaLabel.ForeColor = System.Drawing.Color.White;
            this.historiaLabel.Location = new System.Drawing.Point(14, 314);
            this.historiaLabel.Name = "historiaLabel";
            this.historiaLabel.Size = new System.Drawing.Size(157, 25);
            this.historiaLabel.TabIndex = 2;
            this.historiaLabel.Text = "Historia Clínica";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.btnExcel);
            this.panel3.Location = new System.Drawing.Point(0, 798);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1450, 100);
            this.panel3.TabIndex = 6;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(600, 29);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(248, 49);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.Text = "Exportar";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // datosLabel
            // 
            this.datosLabel.AutoSize = true;
            this.datosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datosLabel.ForeColor = System.Drawing.Color.White;
            this.datosLabel.Location = new System.Drawing.Point(16, 131);
            this.datosLabel.Name = "datosLabel";
            this.datosLabel.Size = new System.Drawing.Size(158, 25);
            this.datosLabel.TabIndex = 1;
            this.datosLabel.Text = "Datos Paciente";
            // 
            // label_Turno
            // 
            this.label_Turno.AutoSize = true;
            this.label_Turno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Turno.ForeColor = System.Drawing.Color.White;
            this.label_Turno.Location = new System.Drawing.Point(16, 572);
            this.label_Turno.Name = "label_Turno";
            this.label_Turno.Size = new System.Drawing.Size(69, 25);
            this.label_Turno.TabIndex = 3;
            this.label_Turno.Text = "Turno";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-10, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1450, 95);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(586, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informe del Paciente";
            // 
            // InformacionPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 898);
            this.Controls.Add(this.panel_Global);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InformacionPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información Paciente";
            ((System.ComponentModel.ISupportInitialize)(this.infoDataGridView)).EndInit();
            this.panel_Global.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historia_Dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turno_Dgv)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView infoDataGridView;
        private System.Windows.Forms.Panel panel_Global;
        private System.Windows.Forms.DataGridView historia_Dgv;
        private System.Windows.Forms.Label historiaLabel;
        private System.Windows.Forms.Label datosLabel;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridView turno_Dgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Turno;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}