namespace Biblioteca
{
    partial class CrearUsuario
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textUsuario = new TextBox();
            textNombre = new TextBox();
            textContraseña = new TextBox();
            comboRol = new ComboBox();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(121, 85, 72);
            label1.Location = new Point(68, 142);
            label1.Name = "label1";
            label1.Size = new Size(90, 26);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(121, 85, 72);
            label2.Location = new Point(68, 90);
            label2.Name = "label2";
            label2.Size = new Size(90, 26);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Britannic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(121, 85, 72);
            label3.Location = new Point(68, 240);
            label3.Name = "label3";
            label3.Size = new Size(127, 26);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Britannic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(121, 85, 72);
            label4.Location = new Point(68, 192);
            label4.Name = "label4";
            label4.Size = new Size(45, 26);
            label4.TabIndex = 3;
            label4.Text = "Rol";
            label4.Click += label4_Click;
            // 
            // textUsuario
            // 
            textUsuario.BackColor = Color.FromArgb(248, 244, 227);
            textUsuario.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textUsuario.Location = new Point(164, 92);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(410, 29);
            textUsuario.TabIndex = 4;
            textUsuario.TextChanged += textUsuario_TextChanged;
            // 
            // textNombre
            // 
            textNombre.BackColor = Color.FromArgb(248, 244, 227);
            textNombre.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNombre.Location = new Point(164, 144);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(410, 29);
            textNombre.TabIndex = 5;
            textNombre.TextChanged += textNombre_TextChanged;
            // 
            // textContraseña
            // 
            textContraseña.BackColor = Color.FromArgb(248, 244, 227);
            textContraseña.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textContraseña.Location = new Point(201, 239);
            textContraseña.Name = "textContraseña";
            textContraseña.Size = new Size(373, 29);
            textContraseña.TabIndex = 6;
            textContraseña.TextChanged += textContraseña_TextChanged;
            // 
            // comboRol
            // 
            comboRol.BackColor = Color.FromArgb(248, 244, 227);
            comboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRol.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboRol.ForeColor = Color.SaddleBrown;
            comboRol.FormattingEnabled = true;
            comboRol.Location = new Point(164, 190);
            comboRol.Name = "comboRol";
            comboRol.Size = new Size(410, 30);
            comboRol.TabIndex = 7;
            comboRol.SelectedIndexChanged += comboRol_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(25, 11, 5);
            label5.Location = new Point(236, 22);
            label5.Name = "label5";
            label5.Size = new Size(267, 44);
            label5.TabIndex = 8;
            label5.Text = "Crear Usuario";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(25, 11, 5);
            button1.Font = new Font("Britannic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(307, 328);
            button1.Name = "button1";
            button1.Size = new Size(155, 44);
            button1.TabIndex = 9;
            button1.Text = "Crear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CrearUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 218, 185);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(comboRol);
            Controls.Add(textContraseña);
            Controls.Add(textNombre);
            Controls.Add(textUsuario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CrearUsuario";
            Text = "CrearUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textUsuario;
        private TextBox textNombre;
        private TextBox textContraseña;
        private ComboBox comboRol;
        private Label label5;
        private Button button1;
    }
}