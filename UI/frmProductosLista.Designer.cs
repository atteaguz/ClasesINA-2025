namespace UI
{
    partial class frmProductosLista
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
            btnNuevo = new Button();
            label1 = new Label();
            gbxLista = new GroupBox();
            txtBusqueda = new TextBox();
            lstvLista = new ListView();
            colId = new ColumnHeader();
            colNombre = new ColumnHeader();
            colPrecio = new ColumnHeader();
            gbxLista.SuspendLayout();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(12, 43);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(120, 40);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(244, 9);
            label1.Name = "label1";
            label1.Size = new Size(273, 25);
            label1.TabIndex = 1;
            label1.Text = "Mantenimiento de Productos";
            // 
            // gbxLista
            // 
            gbxLista.Controls.Add(txtBusqueda);
            gbxLista.Controls.Add(lstvLista);
            gbxLista.Location = new Point(12, 89);
            gbxLista.Name = "gbxLista";
            gbxLista.Size = new Size(638, 396);
            gbxLista.TabIndex = 2;
            gbxLista.TabStop = false;
            gbxLista.Text = "Lista de Productos";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(6, 22);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PlaceholderText = "Buscar Productos";
            txtBusqueda.Size = new Size(452, 23);
            txtBusqueda.TabIndex = 3;
            // 
            // lstvLista
            // 
            lstvLista.BackColor = SystemColors.Window;
            lstvLista.Columns.AddRange(new ColumnHeader[] { colId, colNombre, colPrecio });
            lstvLista.FullRowSelect = true;
            lstvLista.GridLines = true;
            lstvLista.Location = new Point(6, 51);
            lstvLista.MultiSelect = false;
            lstvLista.Name = "lstvLista";
            lstvLista.Size = new Size(607, 339);
            lstvLista.TabIndex = 0;
            lstvLista.UseCompatibleStateImageBehavior = false;
            lstvLista.View = View.Details;
            lstvLista.SelectedIndexChanged += lstvLista_SelectedIndexChanged;
            // 
            // colId
            // 
            colId.Text = "Id";
            colId.Width = 100;
            // 
            // colNombre
            // 
            colNombre.Text = "Nombre";
            colNombre.Width = 350;
            // 
            // colPrecio
            // 
            colPrecio.Text = "Precio";
            colPrecio.Width = 150;
            // 
            // frmProductosLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(668, 497);
            Controls.Add(gbxLista);
            Controls.Add(label1);
            Controls.Add(btnNuevo);
            Name = "frmProductosLista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento Productos";
            gbxLista.ResumeLayout(false);
            gbxLista.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevo;
        private Label label1;
        private GroupBox gbxLista;
        private ListView lstvLista;
        private TextBox txtBusqueda;
        private ColumnHeader colId;
        private ColumnHeader colNombre;
        private ColumnHeader colPrecio;
    }
}