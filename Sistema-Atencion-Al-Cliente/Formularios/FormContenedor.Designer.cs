namespace Sistema_Atencion_Al_Cliente.Formularios
{
    partial class FormContenedor
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
            panelInmovil = new Panel();
            panelContenedor = new Panel();
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panelInmovil.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelInmovil
            // 
            panelInmovil.Controls.Add(panelContenedor);
            panelInmovil.Controls.Add(panel1);
            panelInmovil.Location = new Point(5, 5);
            panelInmovil.Name = "panelInmovil";
            panelInmovil.Size = new Size(600, 640);
            panelInmovil.TabIndex = 0;
            // 
            // panelContenedor
            // 
            panelContenedor.Location = new Point(209, 10);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(380, 620);
            panelContenedor.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(7, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(196, 629);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(55, 343);
            label3.Name = "label3";
            label3.Size = new Size(90, 28);
            label3.TabIndex = 7;
            label3.Text = "Historial";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(59, 176);
            label1.Name = "label1";
            label1.Size = new Size(76, 28);
            label1.TabIndex = 6;
            label1.Text = "Cliente";
            // 
            // button4
            // 
            button4.Location = new Point(31, 283);
            button4.Name = "button4";
            button4.Size = new Size(133, 43);
            button4.TabIndex = 5;
            button4.Text = "Atender Cliente";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(31, 560);
            button3.Name = "button3";
            button3.Size = new Size(133, 44);
            button3.TabIndex = 4;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += cambiarAlPanelInicio_Click;
            // 
            // button2
            // 
            button2.Location = new Point(31, 385);
            button2.Name = "button2";
            button2.Size = new Size(133, 52);
            button2.TabIndex = 3;
            button2.Text = "Mostrar Historial";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(31, 220);
            button1.Name = "button1";
            button1.Size = new Size(133, 45);
            button1.TabIndex = 2;
            button1.Text = "Poner en cola";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelDeCola_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iconoDeManos;
            pictureBox1.Location = new Point(31, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FormContenedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 653);
            Controls.Add(panelInmovil);
            Name = "FormContenedor";
            Text = "FormAgregarCliente";
            panelInmovil.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInmovil;
        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label3;
        private Label label1;
        private Panel panelContenedor;
    }
}