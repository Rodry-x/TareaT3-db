namespace Sistema_Atencion_Al_Cliente.Formularios.Historial
{
    partial class FormHistorial
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelHistorial = new Panel();
            dgvHistorial = new DataGridView();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Dni = new DataGridViewTextBoxColumn();
            Asunto = new DataGridViewTextBoxColumn();
            FechaRegistro = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panelHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // panelHistorial
            // 
            panelHistorial.Controls.Add(dgvHistorial);
            panelHistorial.Controls.Add(label1);
            panelHistorial.Location = new Point(4, 4);
            panelHistorial.Margin = new Padding(3, 2, 3, 2);
            panelHistorial.Name = "panelHistorial";
            panelHistorial.Size = new Size(332, 465);
            panelHistorial.TabIndex = 0;
            // 
            // dgvHistorial
            // 
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Columns.AddRange(new DataGridViewColumn[] { NombreCompleto, Dni, Asunto, FechaRegistro });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Schoolbook", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHistorial.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHistorial.GridColor = SystemColors.GrayText;
            dgvHistorial.Location = new Point(0, 48);
            dgvHistorial.MultiSelect = false;
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.ReadOnly = true;
            dgvHistorial.RowHeadersVisible = false;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvHistorial.Size = new Size(332, 417);
            dgvHistorial.TabIndex = 1;
            dgvHistorial.CellContentClick += dgvHistorial_CellContentClick;
            // 
            // NombreCompleto
            // 
            NombreCompleto.HeaderText = "Nombre Completo";
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            NombreCompleto.Width = 135;
            // 
            // Dni
            // 
            Dni.HeaderText = "DNI";
            Dni.Name = "Dni";
            Dni.ReadOnly = true;
            Dni.Width = 58;
            // 
            // Asunto
            // 
            Asunto.HeaderText = "Asunto";
            Asunto.Name = "Asunto";
            Asunto.ReadOnly = true;
            Asunto.Width = 78;
            // 
            // FechaRegistro
            // 
            FechaRegistro.HeaderText = "Fecha De Registro";
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.ReadOnly = true;
            FechaRegistro.Width = 132;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(209, 30);
            label1.TabIndex = 0;
            label1.Text = "Historial de Clientes";
            // 
            // FormHistorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 472);
            Controls.Add(panelHistorial);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormHistorial";
            Text = "FormHistorial";
            panelHistorial.ResumeLayout(false);
            panelHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHistorial;
        private Label label1;
        private DataGridView dgvHistorial;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Dni;
        private DataGridViewTextBoxColumn Asunto;
        private DataGridViewTextBoxColumn FechaRegistro;
    }
}