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
            panelHistorial = new Panel();
            label2 = new Label();
            label1 = new Label();
            panelHistorial.SuspendLayout();
            SuspendLayout();
            // 
            // panelHistorial
            // 
            panelHistorial.Controls.Add(label2);
            panelHistorial.Controls.Add(label1);
            panelHistorial.Location = new Point(5, 5);
            panelHistorial.Name = "panelHistorial";
            panelHistorial.Size = new Size(380, 620);
            panelHistorial.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 75);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(17, 20);
            label1.Name = "label1";
            label1.Size = new Size(261, 37);
            label1.TabIndex = 0;
            label1.Text = "Historial de Clientes";
            // 
            // FormHistorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 630);
            Controls.Add(panelHistorial);
            Name = "FormHistorial";
            Text = "FormHistorial";
            panelHistorial.ResumeLayout(false);
            panelHistorial.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHistorial;
        private Label label1;
        private Label label2;
    }
}