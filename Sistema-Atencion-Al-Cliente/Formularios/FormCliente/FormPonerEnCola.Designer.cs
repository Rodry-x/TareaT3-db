namespace Sistema_Atencion_Al_Cliente.Formularios
{
    partial class FormPonerEnCola
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
            panelPonerEnCola = new Panel();
            label1 = new Label();
            label2 = new Label();
            txtNombres = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtApellidos = new TextBox();
            label5 = new Label();
            txtDNI = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panelPonerEnCola.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelPonerEnCola
            // 
            panelPonerEnCola.Controls.Add(label1);
            panelPonerEnCola.Controls.Add(pictureBox1);
            panelPonerEnCola.Controls.Add(button1);
            panelPonerEnCola.Controls.Add(txtDNI);
            panelPonerEnCola.Controls.Add(label5);
            panelPonerEnCola.Controls.Add(txtApellidos);
            panelPonerEnCola.Controls.Add(label4);
            panelPonerEnCola.Controls.Add(label3);
            panelPonerEnCola.Controls.Add(txtNombres);
            panelPonerEnCola.Controls.Add(label2);
            panelPonerEnCola.Location = new Point(5, 5);
            panelPonerEnCola.Name = "panelPonerEnCola";
            panelPonerEnCola.Size = new Size(380, 620);
            panelPonerEnCola.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(108, 14);
            label1.Name = "label1";
            label1.Size = new Size(187, 37);
            label1.TabIndex = 1;
            label1.Text = "Poner En Cola";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label2.Location = new Point(17, 76);
            label2.Name = "label2";
            label2.Size = new Size(191, 20);
            label2.TabIndex = 0;
            label2.Text = "Rellenar los datos del cliente";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(159, 112);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(216, 27);
            txtNombres.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label3.Location = new Point(17, 115);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombres:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label4.Location = new Point(17, 155);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Apellidos:";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(159, 155);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(216, 27);
            txtApellidos.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label5.Location = new Point(17, 200);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 5;
            label5.Text = "DNI:";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(159, 197);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(216, 27);
            txtDNI.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(260, 245);
            button1.Name = "button1";
            button1.Size = new Size(115, 38);
            button1.TabIndex = 7;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += guardarDatosDelCliente_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.mujerDeAtencionAlCliente;
            pictureBox1.Location = new Point(38, 301);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(314, 248);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // FormPonerEnCola
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 633);
            Controls.Add(panelPonerEnCola);
            Name = "FormPonerEnCola";
            Text = "FormPonerEnCola";
            panelPonerEnCola.ResumeLayout(false);
            panelPonerEnCola.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPonerEnCola;
        private Label label1;
        private Label label2;
        private TextBox txtDNI;
        private Label label5;
        private TextBox txtApellidos;
        private Label label4;
        private Label label3;
        private TextBox txtNombres;
        private Button button1;
        private PictureBox pictureBox1;
    }
}