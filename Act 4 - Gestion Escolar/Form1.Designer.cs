namespace Act_4___Gestion_Escolar
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartReporte = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewReporte = new System.Windows.Forms.DataGridView();
            this.lblNota = new System.Windows.Forms.Label();
            this.lblGrado = new System.Windows.Forms.Label();
            this.lblNomAlumno = new System.Windows.Forms.Label();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.txtNombreEstudiante = new System.Windows.Forms.TextBox();
            this.nudGrado = new System.Windows.Forms.NumericUpDown();
            this.nudNota = new System.Windows.Forms.NumericUpDown();
            this.chkAsistencia = new System.Windows.Forms.CheckBox();
            this.lstEstudiantes = new System.Windows.Forms.ListBox();
            this.btnRegistrarAsistencia = new System.Windows.Forms.Button();
            this.btnRegistrarNotas = new System.Windows.Forms.Button();
            this.btnAgregarEstudiante = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota)).BeginInit();
            this.SuspendLayout();
            // 
            // chartReporte
            // 
            chartArea4.Name = "ChartArea1";
            this.chartReporte.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartReporte.Legends.Add(legend4);
            this.chartReporte.Location = new System.Drawing.Point(629, 12);
            this.chartReporte.Name = "chartReporte";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartReporte.Series.Add(series4);
            this.chartReporte.Size = new System.Drawing.Size(338, 311);
            this.chartReporte.TabIndex = 14;
            this.chartReporte.Text = "chart1";
            // 
            // dataGridViewReporte
            // 
            this.dataGridViewReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReporte.Location = new System.Drawing.Point(172, 337);
            this.dataGridViewReporte.Name = "dataGridViewReporte";
            this.dataGridViewReporte.RowHeadersWidth = 51;
            this.dataGridViewReporte.RowTemplate.Height = 24;
            this.dataGridViewReporte.Size = new System.Drawing.Size(551, 150);
            this.dataGridViewReporte.TabIndex = 24;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(169, 159);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(106, 16);
            this.lblNota.TabIndex = 27;
            this.lblNota.Text = "Nota del Alumno";
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Location = new System.Drawing.Point(169, 72);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(115, 16);
            this.lblGrado.TabIndex = 26;
            this.lblGrado.Text = "Grado del Alumno";
            // 
            // lblNomAlumno
            // 
            this.lblNomAlumno.AutoSize = true;
            this.lblNomAlumno.Location = new System.Drawing.Point(169, 28);
            this.lblNomAlumno.Name = "lblNomAlumno";
            this.lblNomAlumno.Size = new System.Drawing.Size(126, 16);
            this.lblNomAlumno.TabIndex = 25;
            this.lblNomAlumno.Text = "Nombre del Alumno";
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(21, 409);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(142, 38);
            this.btnGenerarReporte.TabIndex = 23;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // txtNombreEstudiante
            // 
            this.txtNombreEstudiante.Location = new System.Drawing.Point(172, 47);
            this.txtNombreEstudiante.Name = "txtNombreEstudiante";
            this.txtNombreEstudiante.Size = new System.Drawing.Size(120, 22);
            this.txtNombreEstudiante.TabIndex = 22;
            // 
            // nudGrado
            // 
            this.nudGrado.Location = new System.Drawing.Point(172, 91);
            this.nudGrado.Name = "nudGrado";
            this.nudGrado.Size = new System.Drawing.Size(120, 22);
            this.nudGrado.TabIndex = 21;
            // 
            // nudNota
            // 
            this.nudNota.Location = new System.Drawing.Point(172, 185);
            this.nudNota.Name = "nudNota";
            this.nudNota.Size = new System.Drawing.Size(120, 22);
            this.nudNota.TabIndex = 20;
            // 
            // chkAsistencia
            // 
            this.chkAsistencia.AutoSize = true;
            this.chkAsistencia.Location = new System.Drawing.Point(172, 303);
            this.chkAsistencia.Name = "chkAsistencia";
            this.chkAsistencia.Size = new System.Drawing.Size(91, 20);
            this.chkAsistencia.TabIndex = 19;
            this.chkAsistencia.Text = "Asistencia";
            this.chkAsistencia.UseVisualStyleBackColor = true;
            // 
            // lstEstudiantes
            // 
            this.lstEstudiantes.FormattingEnabled = true;
            this.lstEstudiantes.ItemHeight = 16;
            this.lstEstudiantes.Location = new System.Drawing.Point(310, 28);
            this.lstEstudiantes.Name = "lstEstudiantes";
            this.lstEstudiantes.Size = new System.Drawing.Size(253, 260);
            this.lstEstudiantes.TabIndex = 18;
            // 
            // btnRegistrarAsistencia
            // 
            this.btnRegistrarAsistencia.Location = new System.Drawing.Point(21, 303);
            this.btnRegistrarAsistencia.Name = "btnRegistrarAsistencia";
            this.btnRegistrarAsistencia.Size = new System.Drawing.Size(142, 38);
            this.btnRegistrarAsistencia.TabIndex = 17;
            this.btnRegistrarAsistencia.Text = "Registrar Asistencia";
            this.btnRegistrarAsistencia.UseVisualStyleBackColor = true;
            this.btnRegistrarAsistencia.Click += new System.EventHandler(this.btnRegistrarAsistencia_Click);
            // 
            // btnRegistrarNotas
            // 
            this.btnRegistrarNotas.Location = new System.Drawing.Point(21, 159);
            this.btnRegistrarNotas.Name = "btnRegistrarNotas";
            this.btnRegistrarNotas.Size = new System.Drawing.Size(142, 38);
            this.btnRegistrarNotas.TabIndex = 16;
            this.btnRegistrarNotas.Text = "Registrar nota";
            this.btnRegistrarNotas.UseVisualStyleBackColor = true;
            this.btnRegistrarNotas.Click += new System.EventHandler(this.btnRegistrarNotas_Click);
            // 
            // btnAgregarEstudiante
            // 
            this.btnAgregarEstudiante.Location = new System.Drawing.Point(21, 28);
            this.btnAgregarEstudiante.Name = "btnAgregarEstudiante";
            this.btnAgregarEstudiante.Size = new System.Drawing.Size(142, 38);
            this.btnAgregarEstudiante.TabIndex = 15;
            this.btnAgregarEstudiante.Text = "Agregar Estudiante";
            this.btnAgregarEstudiante.UseVisualStyleBackColor = true;
            this.btnAgregarEstudiante.Click += new System.EventHandler(this.btnAgregarEstudiante_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 543);
            this.Controls.Add(this.dataGridViewReporte);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.lblGrado);
            this.Controls.Add(this.lblNomAlumno);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.txtNombreEstudiante);
            this.Controls.Add(this.nudGrado);
            this.Controls.Add(this.nudNota);
            this.Controls.Add(this.chkAsistencia);
            this.Controls.Add(this.lstEstudiantes);
            this.Controls.Add(this.btnRegistrarAsistencia);
            this.Controls.Add(this.btnRegistrarNotas);
            this.Controls.Add(this.btnAgregarEstudiante);
            this.Controls.Add(this.chartReporte);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartReporte;
        private System.Windows.Forms.DataGridView dataGridViewReporte;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.Label lblNomAlumno;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.TextBox txtNombreEstudiante;
        private System.Windows.Forms.NumericUpDown nudGrado;
        private System.Windows.Forms.NumericUpDown nudNota;
        private System.Windows.Forms.CheckBox chkAsistencia;
        private System.Windows.Forms.ListBox lstEstudiantes;
        private System.Windows.Forms.Button btnRegistrarAsistencia;
        private System.Windows.Forms.Button btnRegistrarNotas;
        private System.Windows.Forms.Button btnAgregarEstudiante;
    }
}

