namespace UI
{
    partial class frmProducto
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
            gbxDatosProducto = new GroupBox();
            txtCantidad = new NumericUpDown();
            txtPrecio = new TextBox();
            lblCantidad = new Label();
            lblPrecio = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtId = new TextBox();
            lblId = new Label();
            lblTitulo = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            gbxDatosProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).BeginInit();
            SuspendLayout();
            // 
            // gbxDatosProducto
            // 
            gbxDatosProducto.Controls.Add(txtCantidad);
            gbxDatosProducto.Controls.Add(txtPrecio);
            gbxDatosProducto.Controls.Add(lblCantidad);
            gbxDatosProducto.Controls.Add(lblPrecio);
            gbxDatosProducto.Controls.Add(txtNombre);
            gbxDatosProducto.Controls.Add(lblNombre);
            gbxDatosProducto.Controls.Add(txtId);
            gbxDatosProducto.Controls.Add(lblId);
            gbxDatosProducto.Location = new Point(12, 37);
            gbxDatosProducto.Name = "gbxDatosProducto";
            gbxDatosProducto.Size = new Size(451, 204);
            gbxDatosProducto.TabIndex = 0;
            gbxDatosProducto.TabStop = false;
            gbxDatosProducto.Text = "Datos del Producto";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(79, 163);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(120, 23);
            txtCantidad.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(79, 120);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 6;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(6, 162);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(67, 17);
            lblCantidad.TabIndex = 5;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(6, 120);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 17);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(79, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(266, 23);
            txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(6, 76);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(62, 17);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // txtId
            // 
            txtId.Location = new Point(79, 33);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(6, 33);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 17);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(123, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(214, 25);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Creacion de Productos";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(363, 247);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 30);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(257, 247);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(476, 288);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(lblTitulo);
            Controls.Add(gbxDatosProducto);
            Name = "frmProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento: Crear Producto";
            gbxDatosProducto.ResumeLayout(false);
            gbxDatosProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxDatosProducto;
        private Label lblTitulo;
        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtId;
        private Label lblId;
        private Label lblPrecio;
        private Label lblCantidad;
        private NumericUpDown txtCantidad;
        private TextBox txtPrecio;
    }
}