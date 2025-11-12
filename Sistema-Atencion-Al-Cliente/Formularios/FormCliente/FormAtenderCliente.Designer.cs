namespace Sistema_Atencion_Al_Cliente.Formularios.Cliente
{
    partial class FormAtenderCliente
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
            panelAtenderCliente = new Panel();
            label1 = new Label();
            label2 = new Label();
            panelAtenderCliente.SuspendLayout();
            SuspendLayout();
            // 
            // panelAtenderCliente
            // 
            panelAtenderCliente.Controls.Add(label2);
            panelAtenderCliente.Controls.Add(label1);
            panelAtenderCliente.Location = new Point(5, 5);
            panelAtenderCliente.Name = "panelAtenderCliente";
            panelAtenderCliente.Size = new Size(380, 620);
            panelAtenderCliente.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(17, 16);
            label1.Name = "label1";
            label1.Size = new Size(206, 37);
            label1.TabIndex = 0;
            label1.Text = "Atender Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label2.Location = new Point(25, 71);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 1;
            label2.Text = "label";
            // 
            // FormAtenderCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 633);
            Controls.Add(panelAtenderCliente);
            Name = "FormAtenderCliente";
            Text = "FormAtenderCliente";
            panelAtenderCliente.ResumeLayout(false);
            panelAtenderCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAtenderCliente;
        private Label label2;
        private Label label1;
    }
}