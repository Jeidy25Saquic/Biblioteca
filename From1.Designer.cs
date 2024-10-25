namespace Biblioteca
{
    partial class From1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(From1));
            label2 = new Label();
            label3 = new Label();
            textIngresarUsuario = new TextBox();
            textIngresarContraseña = new TextBox();
            Ingresar = new Button();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(386, 62);
            label2.Name = "label2";
            label2.Size = new Size(157, 137);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.Font = new Font("Arial Rounded MT Bold", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(25, 11, 5);
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(284, 9);
            label3.Name = "label3";
            label3.Size = new Size(366, 63);
            label3.TabIndex = 2;
            label3.Text = "Biblioteca";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label3_Click;
            // 
            // textIngresarUsuario
            // 
            textIngresarUsuario.BackColor = Color.FromArgb(248, 244, 227);
            textIngresarUsuario.Location = new Point(346, 202);
            textIngresarUsuario.Name = "textIngresarUsuario";
            textIngresarUsuario.Size = new Size(229, 27);
            textIngresarUsuario.TabIndex = 3;
            textIngresarUsuario.Text = "Usuario";
            textIngresarUsuario.TextChanged += textIngresarUsuario_TextChanged;
            // 
            // textIngresarContraseña
            // 
            textIngresarContraseña.BackColor = Color.FromArgb(248, 244, 227);
            textIngresarContraseña.Location = new Point(346, 235);
            textIngresarContraseña.Name = "textIngresarContraseña";
            textIngresarContraseña.Size = new Size(229, 27);
            textIngresarContraseña.TabIndex = 4;
            textIngresarContraseña.Text = "Contraseña";
            textIngresarContraseña.TextChanged += textIngresarContraseña_TextChanged;
            // 
            // Ingresar
            // 
            Ingresar.BackColor = Color.FromArgb(25, 11, 5);
            Ingresar.ForeColor = Color.WhiteSmoke;
            Ingresar.Location = new Point(386, 303);
            Ingresar.Name = "Ingresar";
            Ingresar.Size = new Size(139, 54);
            Ingresar.TabIndex = 5;
            Ingresar.Text = "Ingresar";
            Ingresar.UseVisualStyleBackColor = false;
            Ingresar.Click += Ingresar_Click;
            // 
            // label1
            // 
            label1.FlatStyle = FlatStyle.Flat;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(0, 235);
            label1.Name = "label1";
            label1.Size = new Size(282, 195);
            label1.TabIndex = 6;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.FromArgb(128, 64, 64);
            linkLabel1.Location = new Point(722, 385);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(113, 19);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Crear Usuario";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 218, 185);
            ClientSize = new Size(900, 428);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(Ingresar);
            Controls.Add(textIngresarContraseña);
            Controls.Add(textIngresarUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Name = "Login";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox textIngresarUsuario;
        private TextBox textIngresarContraseña;
        private Button Ingresar;
        private Label label1;
        private LinkLabel linkLabel1;
    }
}
