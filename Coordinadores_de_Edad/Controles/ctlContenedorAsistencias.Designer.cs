namespace Coordinadores_de_Edad.Controles
{
    partial class ctlContenedorAsistencias
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.PageListaAsistencia = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ctlListaAsistencia1 = new Coordinadores_de_Edad.Controles.ctlListaAsistencia();
            this.PageDetalleAsistencia = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ctlDetallesAsistencia1 = new Coordinadores_de_Edad.Controles.ctlDetallesAsistencia();
            this.PageCubrirAusencia = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ctlCubrirAusencias1 = new Coordinadores_de_Edad.Controles.ctlCubrirAusencias();
            this.PageMensaje = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lblEncabezado = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
            this.PageListaAsistencia.SuspendLayout();
            this.PageDetalleAsistencia.SuspendLayout();
            this.PageCubrirAusencia.SuspendLayout();
            this.PageMensaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Controls.Add(this.PageListaAsistencia);
            this.navigationFrame1.Controls.Add(this.PageDetalleAsistencia);
            this.navigationFrame1.Controls.Add(this.PageCubrirAusencia);
            this.navigationFrame1.Controls.Add(this.PageMensaje);
            this.navigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame1.Location = new System.Drawing.Point(5, 5);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.PageListaAsistencia,
            this.PageDetalleAsistencia,
            this.PageCubrirAusencia,
            this.PageMensaje});
            this.navigationFrame1.SelectedPage = this.PageListaAsistencia;
            this.navigationFrame1.Size = new System.Drawing.Size(1098, 652);
            this.navigationFrame1.TabIndex = 0;
            this.navigationFrame1.Text = "navigationFrame1";
            // 
            // PageListaAsistencia
            // 
            this.PageListaAsistencia.Caption = "PageListaAsistencia";
            this.PageListaAsistencia.Controls.Add(this.ctlListaAsistencia1);
            this.PageListaAsistencia.Name = "PageListaAsistencia";
            this.PageListaAsistencia.Size = new System.Drawing.Size(1098, 652);
            // 
            // ctlListaAsistencia1
            // 
            this.ctlListaAsistencia1.BackColor = System.Drawing.Color.White;
            this.ctlListaAsistencia1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlListaAsistencia1.Location = new System.Drawing.Point(0, 0);
            this.ctlListaAsistencia1.Name = "ctlListaAsistencia1";
            this.ctlListaAsistencia1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlListaAsistencia1.Pro_Conexion = null;
            this.ctlListaAsistencia1.Pro_Usuario = null;
            this.ctlListaAsistencia1.Size = new System.Drawing.Size(1098, 652);
            this.ctlListaAsistencia1.TabIndex = 0;
            // 
            // PageDetalleAsistencia
            // 
            this.PageDetalleAsistencia.Caption = "PageDetalleAsistencia";
            this.PageDetalleAsistencia.Controls.Add(this.ctlDetallesAsistencia1);
            this.PageDetalleAsistencia.Name = "PageDetalleAsistencia";
            this.PageDetalleAsistencia.Size = new System.Drawing.Size(1098, 652);
            // 
            // ctlDetallesAsistencia1
            // 
            this.ctlDetallesAsistencia1.BackColor = System.Drawing.Color.White;
            this.ctlDetallesAsistencia1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlDetallesAsistencia1.Location = new System.Drawing.Point(0, 0);
            this.ctlDetallesAsistencia1.Name = "ctlDetallesAsistencia1";
            this.ctlDetallesAsistencia1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlDetallesAsistencia1.Size = new System.Drawing.Size(1098, 652);
            this.ctlDetallesAsistencia1.TabIndex = 0;
            // 
            // PageCubrirAusencia
            // 
            this.PageCubrirAusencia.Caption = "PageCubrirAusencia";
            this.PageCubrirAusencia.Controls.Add(this.ctlCubrirAusencias1);
            this.PageCubrirAusencia.Name = "PageCubrirAusencia";
            this.PageCubrirAusencia.Size = new System.Drawing.Size(1098, 652);
            // 
            // ctlCubrirAusencias1
            // 
            this.ctlCubrirAusencias1.BackColor = System.Drawing.Color.White;
            this.ctlCubrirAusencias1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlCubrirAusencias1.Location = new System.Drawing.Point(0, 0);
            this.ctlCubrirAusencias1.Name = "ctlCubrirAusencias1";
            this.ctlCubrirAusencias1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlCubrirAusencias1.Size = new System.Drawing.Size(1098, 652);
            this.ctlCubrirAusencias1.TabIndex = 0;
            // 
            // PageMensaje
            // 
            this.PageMensaje.Controls.Add(this.lblEncabezado);
            this.PageMensaje.Name = "PageMensaje";
            this.PageMensaje.Size = new System.Drawing.Size(1098, 652);
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.Appearance.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.Appearance.Options.UseFont = true;
            this.lblEncabezado.Appearance.Options.UseTextOptions = true;
            this.lblEncabezado.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblEncabezado.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblEncabezado.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEncabezado.Location = new System.Drawing.Point(0, 0);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(1098, 652);
            this.lblEncabezado.TabIndex = 10;
            this.lblEncabezado.Text = "No hay actividades programadas para este día";
            // 
            // ctlContenedorAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.navigationFrame1);
            this.Name = "ctlContenedorAsistencias";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1108, 662);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
            this.PageListaAsistencia.ResumeLayout(false);
            this.PageDetalleAsistencia.ResumeLayout(false);
            this.PageCubrirAusencia.ResumeLayout(false);
            this.PageMensaje.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage PageListaAsistencia;
        private ctlListaAsistencia ctlListaAsistencia1;
        private DevExpress.XtraBars.Navigation.NavigationPage PageDetalleAsistencia;
        private DevExpress.XtraBars.Navigation.NavigationPage PageCubrirAusencia;
        private ctlDetallesAsistencia ctlDetallesAsistencia1;
        private ctlCubrirAusencias ctlCubrirAusencias1;
        private DevExpress.XtraBars.Navigation.NavigationPage PageMensaje;
        private DevExpress.XtraEditors.LabelControl lblEncabezado;
    }
}
