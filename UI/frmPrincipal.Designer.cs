namespace UI
{
    partial class frmPrincipal
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
            mnuPrincipal = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            abrirArchivoToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            gurdarComoToolStripMenuItem = new ToolStripMenuItem();
            importarArchivoToolStripMenuItem = new ToolStripMenuItem();
            exportarArchivoToolStripMenuItem = new ToolStripMenuItem();
            mantenimientoToolStripMenuItem = new ToolStripMenuItem();
            procesosToolStripMenuItem = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            crearReporteToolStripMenuItem = new ToolStripMenuItem();
            verReportesToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            salirDelSistemaToolStripMenuItem = new ToolStripMenuItem();
            mnuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // mnuPrincipal
            // 
            mnuPrincipal.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, mantenimientoToolStripMenuItem, procesosToolStripMenuItem, consultasToolStripMenuItem, reportesToolStripMenuItem, salirToolStripMenuItem });
            mnuPrincipal.Location = new Point(0, 0);
            mnuPrincipal.Name = "mnuPrincipal";
            mnuPrincipal.Size = new Size(796, 24);
            mnuPrincipal.TabIndex = 1;
            mnuPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirArchivoToolStripMenuItem, guardarToolStripMenuItem, gurdarComoToolStripMenuItem, importarArchivoToolStripMenuItem, exportarArchivoToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirArchivoToolStripMenuItem
            // 
            abrirArchivoToolStripMenuItem.Name = "abrirArchivoToolStripMenuItem";
            abrirArchivoToolStripMenuItem.Size = new Size(162, 22);
            abrirArchivoToolStripMenuItem.Text = "Abrir archivo";
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(162, 22);
            guardarToolStripMenuItem.Text = "Guardar";
            // 
            // gurdarComoToolStripMenuItem
            // 
            gurdarComoToolStripMenuItem.Name = "gurdarComoToolStripMenuItem";
            gurdarComoToolStripMenuItem.Size = new Size(162, 22);
            gurdarComoToolStripMenuItem.Text = "Gurdar como...";
            // 
            // importarArchivoToolStripMenuItem
            // 
            importarArchivoToolStripMenuItem.Name = "importarArchivoToolStripMenuItem";
            importarArchivoToolStripMenuItem.Size = new Size(162, 22);
            importarArchivoToolStripMenuItem.Text = "Importar archivo";
            // 
            // exportarArchivoToolStripMenuItem
            // 
            exportarArchivoToolStripMenuItem.Name = "exportarArchivoToolStripMenuItem";
            exportarArchivoToolStripMenuItem.Size = new Size(162, 22);
            exportarArchivoToolStripMenuItem.Text = "Exportar archivo";
            // 
            // mantenimientoToolStripMenuItem
            // 
            mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            mantenimientoToolStripMenuItem.Size = new Size(101, 20);
            mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // procesosToolStripMenuItem
            // 
            procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            procesosToolStripMenuItem.Size = new Size(66, 20);
            procesosToolStripMenuItem.Text = "Procesos";
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(71, 20);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearReporteToolStripMenuItem, verReportesToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(65, 20);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // crearReporteToolStripMenuItem
            // 
            crearReporteToolStripMenuItem.Name = "crearReporteToolStripMenuItem";
            crearReporteToolStripMenuItem.Size = new Size(143, 22);
            crearReporteToolStripMenuItem.Text = "Crear reporte";
            // 
            // verReportesToolStripMenuItem
            // 
            verReportesToolStripMenuItem.Name = "verReportesToolStripMenuItem";
            verReportesToolStripMenuItem.Size = new Size(143, 22);
            verReportesToolStripMenuItem.Text = "Ver reportes";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirDelSistemaToolStripMenuItem });
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            salirDelSistemaToolStripMenuItem.Size = new Size(158, 22);
            salirDelSistemaToolStripMenuItem.Text = "Salir del sistema";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(796, 392);
            Controls.Add(mnuPrincipal);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            IsMdiContainer = true;
            MainMenuStrip = mnuPrincipal;
            Name = "frmPrincipal";
            Text = "Sistema de Clase INA";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            mnuPrincipal.ResumeLayout(false);
            mnuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuPrincipal;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem mantenimientoToolStripMenuItem;
        private ToolStripMenuItem procesosToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private ToolStripMenuItem abrirArchivoToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem gurdarComoToolStripMenuItem;
        private ToolStripMenuItem importarArchivoToolStripMenuItem;
        private ToolStripMenuItem exportarArchivoToolStripMenuItem;
        private ToolStripMenuItem crearReporteToolStripMenuItem;
        private ToolStripMenuItem verReportesToolStripMenuItem;
    }
}
