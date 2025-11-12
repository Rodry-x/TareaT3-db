namespace Sistema_Atencion_Al_Cliente.Formularios.Grabaciones
{
    partial class FormExplicacionDelCodigo
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
            panelExplicacionDelCodigo = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelExplicacionDelCodigo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelExplicacionDelCodigo
            // 
            panelExplicacionDelCodigo.Controls.Add(pictureBox1);
            panelExplicacionDelCodigo.Controls.Add(button4);
            panelExplicacionDelCodigo.Controls.Add(button3);
            panelExplicacionDelCodigo.Controls.Add(button2);
            panelExplicacionDelCodigo.Controls.Add(button1);
            panelExplicacionDelCodigo.Controls.Add(label4);
            panelExplicacionDelCodigo.Controls.Add(label3);
            panelExplicacionDelCodigo.Controls.Add(label2);
            panelExplicacionDelCodigo.Controls.Add(label1);
            panelExplicacionDelCodigo.Location = new Point(5, 5);
            panelExplicacionDelCodigo.Name = "panelExplicacionDelCodigo";
            panelExplicacionDelCodigo.Size = new Size(600, 640);
            panelExplicacionDelCodigo.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(27, 568);
            button4.Name = "button4";
            button4.Size = new Size(139, 53);
            button4.TabIndex = 7;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += cambiarAlPanelContenedor_Click;
            // 
            // button3
            // 
            button3.Location = new Point(264, 254);
            button3.Name = "button3";
            button3.Size = new Size(266, 47);
            button3.TabIndex = 6;
            button3.Text = "Explicación";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(264, 185);
            button2.Name = "button2";
            button2.Size = new Size(266, 47);
            button2.TabIndex = 5;
            button2.Text = "Explicación";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(264, 117);
            button1.Name = "button1";
            button1.Size = new Size(266, 47);
            button1.TabIndex = 4;
            button1.Text = "Explicación";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            label4.Location = new Point(64, 263);
            label4.Name = "label4";
            label4.Size = new Size(164, 25);
            label4.TabIndex = 3;
            label4.Text = "Historial Completo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            label3.Location = new Point(64, 194);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 2;
            label3.Text = "Atender Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            label2.Location = new Point(64, 126);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 1;
            label2.Text = "Cola de Espera";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(126, 27);
            label1.Name = "label1";
            label1.Size = new Size(363, 46);
            label1.TabIndex = 0;
            label1.Text = "Explicacion del Codigo";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imagenExplicacion;
            pictureBox1.Location = new Point(200, 328);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 269);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // FormExplicacionDelCodigo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 653);
            Controls.Add(panelExplicacionDelCodigo);
            Name = "FormExplicacionDelCodigo";
            Text = "FormExplicacionDelCodigo";
            panelExplicacionDelCodigo.ResumeLayout(false);
            panelExplicacionDelCodigo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelExplicacionDelCodigo;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
    }
}