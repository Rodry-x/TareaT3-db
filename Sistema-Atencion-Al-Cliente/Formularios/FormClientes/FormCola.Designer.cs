namespace Sistema_Atencion_Al_Cliente.Formularios.FormClientes
{
    partial class FormCola
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
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtDNI = new TextBox();
            txtApellidos = new TextBox();
            txtNombres = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label6 = new Label();
            txtAsunto = new TextBox();
            panelPonerEnCola.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelPonerEnCola
            // 
            panelPonerEnCola.Controls.Add(txtAsunto);
            panelPonerEnCola.Controls.Add(label6);
            panelPonerEnCola.Controls.Add(pictureBox1);
            panelPonerEnCola.Controls.Add(label5);
            panelPonerEnCola.Controls.Add(label4);
            panelPonerEnCola.Controls.Add(label3);
            panelPonerEnCola.Controls.Add(label2);
            panelPonerEnCola.Controls.Add(txtDNI);
            panelPonerEnCola.Controls.Add(txtApellidos);
            panelPonerEnCola.Controls.Add(txtNombres);
            panelPonerEnCola.Controls.Add(button1);
            panelPonerEnCola.Controls.Add(label1);
            panelPonerEnCola.Location = new Point(5, 5);
            panelPonerEnCola.Name = "panelPonerEnCola";
            panelPonerEnCola.Size = new Size(380, 620);
            panelPonerEnCola.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.mujerDeAtencionAlCliente;
            pictureBox1.Location = new Point(27, 342);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(331, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 205);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 8;
            label5.Text = "DNI:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 154);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 7;
            label4.Text = "Apellidos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 109);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 6;
            label3.Text = "Nombres:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(7, 63);
            label2.Name = "label2";
            label2.Size = new Size(232, 23);
            label2.TabIndex = 5;
            label2.Text = "Ingresar los datos del cliente:";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(153, 200);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(186, 27);
            txtDNI.TabIndex = 4;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(153, 154);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(186, 27);
            txtApellidos.TabIndex = 3;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(153, 109);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(186, 27);
            txtNombres.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(210, 294);
            button1.Name = "button1";
            button1.Size = new Size(129, 38);
            button1.TabIndex = 1;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += guardarDatosDelCliente_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(7, 13);
            label1.Name = "label1";
            label1.Size = new Size(207, 37);
            label1.TabIndex = 0;
            label1.Text = "Agregar Cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 252);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 10;
            label6.Text = "Asunto:";
            // 
            // txtAsunto
            // 
            txtAsunto.Location = new Point(153, 245);
            txtAsunto.Name = "txtAsunto";
            txtAsunto.Size = new Size(186, 27);
            txtAsunto.TabIndex = 11;
            // 
            // FormCola
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 630);
            Controls.Add(panelPonerEnCola);
            Name = "FormCola";
            Text = "FormCola";
            panelPonerEnCola.ResumeLayout(false);
            panelPonerEnCola.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPonerEnCola;
        private Button button1;
        private Label label1;
        private TextBox txtDNI;
        private TextBox txtApellidos;
        private TextBox txtNombres;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox txtAsunto;
        private Label label6;
    }
}