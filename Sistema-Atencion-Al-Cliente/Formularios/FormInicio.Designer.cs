namespace Sistema_Atencion_Al_Cliente.Formularios
{
    partial class FormInicio
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
            panelPrincipal = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(button1);
            panelPrincipal.Controls.Add(pictureBox1);
            panelPrincipal.Controls.Add(label2);
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Location = new Point(5, 5);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(600, 640);
            panelPrincipal.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(191, 513);
            button1.Name = "button1";
            button1.Size = new Size(198, 70);
            button1.TabIndex = 3;
            button1.Text = "Comenzar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelInmovil_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imagenMujerSonrriendo;
            pictureBox1.Location = new Point(74, 177);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(447, 301);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            label2.Location = new Point(20, 86);
            label2.Name = "label2";
            label2.Size = new Size(564, 69);
            label2.TabIndex = 1;
            label2.Text = "Proyecto que ayuda a agilizar la atencion al cliente, ordenado y listado por orden de llegada";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(63, 17);
            label1.Name = "label1";
            label1.Size = new Size(485, 46);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Atención al Cliente";
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 653);
            Controls.Add(panelPrincipal);
            Name = "FormInicio";
            Text = "FormContenedor";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
    }
}