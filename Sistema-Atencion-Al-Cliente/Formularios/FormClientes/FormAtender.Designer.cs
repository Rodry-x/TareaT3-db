namespace Sistema_Atencion_Al_Cliente.Formularios.FormClientes
{
    partial class FormAtender
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
            panelAtender = new Panel();
            button1 = new Button();
            txtDNI = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            lblResultado = new Label();
            panelAtender.SuspendLayout();
            SuspendLayout();
            // 
            // panelAtender
            // 
            panelAtender.Controls.Add(lblResultado);
            panelAtender.Controls.Add(label3);
            panelAtender.Controls.Add(button1);
            panelAtender.Controls.Add(txtDNI);
            panelAtender.Controls.Add(label2);
            panelAtender.Controls.Add(label1);
            panelAtender.Location = new Point(5, 5);
            panelAtender.Name = "panelAtender";
            panelAtender.Size = new Size(380, 620);
            panelAtender.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(257, 123);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BuscarDNI_Click;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(111, 72);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(240, 27);
            txtDNI.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label2.Location = new Point(17, 75);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 1;
            label2.Text = "DNI:";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 174);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 4;
            label3.Text = "RESULTADOS :";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(127, 175);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(18, 20);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "...";
            // 
            // FormAtender
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 633);
            Controls.Add(panelAtender);
            Name = "FormAtender";
            Text = "FormAtender";
            panelAtender.ResumeLayout(false);
            panelAtender.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAtender;
        private Label label2;
        private Label label1;
        private TextBox txtDNI;
        private Button button1;
        private Label label3;
        private Label lblResultado;
    }
}