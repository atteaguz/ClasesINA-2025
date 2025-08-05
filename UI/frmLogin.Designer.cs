namespace UI
{
    partial class frmLogin
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
            grbLogin = new GroupBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            tbContraseña = new TextBox();
            tbUsuario = new TextBox();
            lblContraseña = new Label();
            lblUsuario = new Label();
            grbLogin.SuspendLayout();
            SuspendLayout();
            // 
            // grbLogin
            // 
            grbLogin.Controls.Add(label1);
            grbLogin.Controls.Add(btnCancelar);
            grbLogin.Controls.Add(btnAceptar);
            grbLogin.Controls.Add(tbContraseña);
            grbLogin.Controls.Add(tbUsuario);
            grbLogin.Controls.Add(lblContraseña);
            grbLogin.Controls.Add(lblUsuario);
            grbLogin.Location = new Point(12, 12);
            grbLogin.Name = "grbLogin";
            grbLogin.Size = new Size(442, 182);
            grbLogin.TabIndex = 0;
            grbLogin.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(162, 19);
            label1.Name = "label1";
            label1.Size = new Size(105, 17);
            label1.TabIndex = 6;
            label1.Text = "Inicio de Sesion";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(269, 153);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(111, 153);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // tbContraseña
            // 
            tbContraseña.Location = new Point(93, 92);
            tbContraseña.Name = "tbContraseña";
            tbContraseña.Size = new Size(174, 23);
            tbContraseña.TabIndex = 3;
            // 
            // tbUsuario
            // 
            tbUsuario.Location = new Point(93, 48);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Size = new Size(174, 23);
            tbUsuario.TabIndex = 2;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContraseña.Location = new Point(6, 93);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(81, 17);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(6, 49);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 17);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario:";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(466, 206);
            Controls.Add(grbLogin);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesion";
            grbLogin.ResumeLayout(false);
            grbLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbLogin;
        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox tbContraseña;
        private TextBox tbUsuario;
        private Label lblContraseña;
        private Label lblUsuario;
        private Label label1;
    }
}