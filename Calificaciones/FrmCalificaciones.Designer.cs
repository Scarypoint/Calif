namespace Calificaciones
{
    partial class FrmCalificaciones
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
            this.dgvcalificaciones = new System.Windows.Forms.DataGridView();
            this.tbcalif = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbalumno = new System.Windows.Forms.ComboBox();
            this.cmbmateria = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcalificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcalificaciones
            // 
            this.dgvcalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcalificaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Alumno,
            this.Materia,
            this.Calificacion});
            this.dgvcalificaciones.Location = new System.Drawing.Point(104, 126);
            this.dgvcalificaciones.Name = "dgvcalificaciones";
            this.dgvcalificaciones.Size = new System.Drawing.Size(341, 150);
            this.dgvcalificaciones.TabIndex = 0;
            // 
            // tbcalif
            // 
            this.tbcalif.Location = new System.Drawing.Point(415, 62);
            this.tbcalif.Name = "tbcalif";
            this.tbcalif.Size = new System.Drawing.Size(100, 20);
            this.tbcalif.TabIndex = 3;
            this.tbcalif.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alumno:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Materia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Calificacion:";
            // 
            // cmbalumno
            // 
            this.cmbalumno.FormattingEnabled = true;
            this.cmbalumno.Location = new System.Drawing.Point(47, 56);
            this.cmbalumno.Name = "cmbalumno";
            this.cmbalumno.Size = new System.Drawing.Size(121, 21);
            this.cmbalumno.TabIndex = 7;
            this.cmbalumno.SelectedIndexChanged += new System.EventHandler(this.cmbalumno_SelectedIndexChanged);
            this.cmbalumno.RightToLeftChanged += new System.EventHandler(this.cmbalumno_RightToLeftChanged);
            // 
            // cmbmateria
            // 
            this.cmbmateria.FormattingEnabled = true;
            this.cmbmateria.Location = new System.Drawing.Point(215, 57);
            this.cmbmateria.Name = "cmbmateria";
            this.cmbmateria.Size = new System.Drawing.Size(121, 21);
            this.cmbmateria.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Asignar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AsignarC);
            // 
            // Alumno
            // 
            this.Alumno.HeaderText = "Alumno";
            this.Alumno.Name = "Alumno";
            // 
            // Materia
            // 
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            // 
            // Calificacion
            // 
            this.Calificacion.HeaderText = "Calificacion";
            this.Calificacion.Name = "Calificacion";
            // 
            // FrmCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbmateria);
            this.Controls.Add(this.cmbalumno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbcalif);
            this.Controls.Add(this.dgvcalificaciones);
            this.Name = "FrmCalificaciones";
            this.Text = "FrmCalificaciones";
            this.Load += new System.EventHandler(this.FrmCalificaciones_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcalificaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcalificaciones;
        private System.Windows.Forms.TextBox tbcalif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbalumno;
        private System.Windows.Forms.ComboBox cmbmateria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calificacion;
    }
}