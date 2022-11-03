namespace WindowsPresentacion
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
            this.gridPacientes = new System.Windows.Forms.DataGridView();
            this.lstMedicos = new System.Windows.Forms.ListBox();
            this.btnListarMedicosGrid = new System.Windows.Forms.Button();
            this.lstHabitaciones = new System.Windows.Forms.ListBox();
            this.gridMedicos = new System.Windows.Forms.DataGridView();
            this.btnListarPacientesGrid = new System.Windows.Forms.Button();
            this.btnListarMedicosClinicos = new System.Windows.Forms.Button();
            this.btnListarHabitaciones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPacientes
            // 
            this.gridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPacientes.Location = new System.Drawing.Point(318, 151);
            this.gridPacientes.Name = "gridPacientes";
            this.gridPacientes.RowHeadersWidth = 51;
            this.gridPacientes.RowTemplate.Height = 24;
            this.gridPacientes.Size = new System.Drawing.Size(438, 133);
            this.gridPacientes.TabIndex = 0;
            // 
            // lstMedicos
            // 
            this.lstMedicos.FormattingEnabled = true;
            this.lstMedicos.ItemHeight = 16;
            this.lstMedicos.Location = new System.Drawing.Point(319, 305);
            this.lstMedicos.Name = "lstMedicos";
            this.lstMedicos.Size = new System.Drawing.Size(438, 52);
            this.lstMedicos.TabIndex = 1;
            // 
            // btnListarMedicosGrid
            // 
            this.btnListarMedicosGrid.Location = new System.Drawing.Point(55, 48);
            this.btnListarMedicosGrid.Name = "btnListarMedicosGrid";
            this.btnListarMedicosGrid.Size = new System.Drawing.Size(174, 77);
            this.btnListarMedicosGrid.TabIndex = 3;
            this.btnListarMedicosGrid.Text = "Listar Todos los Medicos";
            this.btnListarMedicosGrid.UseVisualStyleBackColor = true;
            this.btnListarMedicosGrid.Click += new System.EventHandler(this.btnListarMedicosGrid_Click);
            // 
            // lstHabitaciones
            // 
            this.lstHabitaciones.FormattingEnabled = true;
            this.lstHabitaciones.ItemHeight = 16;
            this.lstHabitaciones.Location = new System.Drawing.Point(319, 380);
            this.lstHabitaciones.Name = "lstHabitaciones";
            this.lstHabitaciones.Size = new System.Drawing.Size(437, 52);
            this.lstHabitaciones.TabIndex = 2;
            // 
            // gridMedicos
            // 
            this.gridMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMedicos.Location = new System.Drawing.Point(318, 12);
            this.gridMedicos.Name = "gridMedicos";
            this.gridMedicos.RowHeadersWidth = 51;
            this.gridMedicos.RowTemplate.Height = 24;
            this.gridMedicos.Size = new System.Drawing.Size(438, 133);
            this.gridMedicos.TabIndex = 0;
            // 
            // btnListarPacientesGrid
            // 
            this.btnListarPacientesGrid.Location = new System.Drawing.Point(55, 181);
            this.btnListarPacientesGrid.Name = "btnListarPacientesGrid";
            this.btnListarPacientesGrid.Size = new System.Drawing.Size(174, 77);
            this.btnListarPacientesGrid.TabIndex = 3;
            this.btnListarPacientesGrid.Text = "Listar Todos los Pacientes";
            this.btnListarPacientesGrid.UseVisualStyleBackColor = true;
            this.btnListarPacientesGrid.Click += new System.EventHandler(this.btnListarPacientesGrid_Click);
            // 
            // btnListarMedicosClinicos
            // 
            this.btnListarMedicosClinicos.Location = new System.Drawing.Point(55, 321);
            this.btnListarMedicosClinicos.Name = "btnListarMedicosClinicos";
            this.btnListarMedicosClinicos.Size = new System.Drawing.Size(174, 36);
            this.btnListarMedicosClinicos.TabIndex = 3;
            this.btnListarMedicosClinicos.Text = "Listar Medicos Clinicos";
            this.btnListarMedicosClinicos.UseVisualStyleBackColor = true;
            this.btnListarMedicosClinicos.Click += new System.EventHandler(this.btnListarMedicosClinicos_Click);
            // 
            // btnListarHabitaciones
            // 
            this.btnListarHabitaciones.Location = new System.Drawing.Point(55, 386);
            this.btnListarHabitaciones.Name = "btnListarHabitaciones";
            this.btnListarHabitaciones.Size = new System.Drawing.Size(174, 46);
            this.btnListarHabitaciones.TabIndex = 3;
            this.btnListarHabitaciones.Text = "Listar Habitaciones";
            this.btnListarHabitaciones.UseVisualStyleBackColor = true;
            this.btnListarHabitaciones.Click += new System.EventHandler(this.btnListarHabitaciones_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListarHabitaciones);
            this.Controls.Add(this.btnListarMedicosClinicos);
            this.Controls.Add(this.btnListarPacientesGrid);
            this.Controls.Add(this.btnListarMedicosGrid);
            this.Controls.Add(this.lstHabitaciones);
            this.Controls.Add(this.lstMedicos);
            this.Controls.Add(this.gridMedicos);
            this.Controls.Add(this.gridPacientes);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPacientes;
        private System.Windows.Forms.ListBox lstMedicos;
        private System.Windows.Forms.Button btnListarMedicosGrid;
        private System.Windows.Forms.ListBox lstHabitaciones;
        private System.Windows.Forms.DataGridView gridMedicos;
        private System.Windows.Forms.Button btnListarPacientesGrid;
        private System.Windows.Forms.Button btnListarMedicosClinicos;
        private System.Windows.Forms.Button btnListarHabitaciones;
    }
}

