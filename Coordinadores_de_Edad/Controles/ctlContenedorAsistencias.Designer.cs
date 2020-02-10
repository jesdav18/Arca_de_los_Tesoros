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
            this.NavegacionAsistencias = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.PageListaAsistencia = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ctlListaAsistencia1 = new Coordinadores_de_Edad.Controles.ctlListaAsistencia();
            this.PageDetalleAsistencia = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ctlDetallesAsistencia1 = new Coordinadores_de_Edad.Controles.ctlDetallesAsistencia();
            this.PageMensaje = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdVerHistorico = new DevExpress.XtraEditors.PictureEdit();
            this.lblEncabezado = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.NavegacionAsistencias)).BeginInit();
            this.NavegacionAsistencias.SuspendLayout();
            this.PageListaAsistencia.SuspendLayout();
            this.PageDetalleAsistencia.SuspendLayout();
            this.PageMensaje.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerHistorico.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // NavegacionAsistencias
            // 
            this.NavegacionAsistencias.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.NavegacionAsistencias.Controls.Add(this.PageListaAsistencia);
            this.NavegacionAsistencias.Controls.Add(this.PageDetalleAsistencia);
            this.NavegacionAsistencias.Controls.Add(this.PageMensaje);
            this.NavegacionAsistencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavegacionAsistencias.Location = new System.Drawing.Point(5, 5);
            this.NavegacionAsistencias.Name = "NavegacionAsistencias";
            this.NavegacionAsistencias.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.PageListaAsistencia,
            this.PageDetalleAsistencia,
            this.PageMensaje});
            this.NavegacionAsistencias.SelectedPage = this.PageListaAsistencia;
            this.NavegacionAsistencias.Size = new System.Drawing.Size(1098, 852);
            this.NavegacionAsistencias.TabIndex = 0;
            this.NavegacionAsistencias.Text = "navigationFrame1";
            // 
            // PageListaAsistencia
            // 
            this.PageListaAsistencia.Caption = "PageListaAsistencia";
            this.PageListaAsistencia.Controls.Add(this.ctlListaAsistencia1);
            this.PageListaAsistencia.Name = "PageListaAsistencia";
            this.PageListaAsistencia.Size = new System.Drawing.Size(1098, 852);
            // 
            // ctlListaAsistencia1
            // 
            this.ctlListaAsistencia1.BackColor = System.Drawing.Color.White;
            this.ctlListaAsistencia1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlListaAsistencia1.Location = new System.Drawing.Point(0, 0);
            this.ctlListaAsistencia1.MinimumSize = new System.Drawing.Size(1078, 791);
            this.ctlListaAsistencia1.Name = "ctlListaAsistencia1";
            this.ctlListaAsistencia1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlListaAsistencia1.Pro_Conexion = null;
            this.ctlListaAsistencia1.Pro_ID_Actividad = 0;
            this.ctlListaAsistencia1.Pro_ID_AreaAtencion = 0;
            this.ctlListaAsistencia1.Pro_Usuario = null;
            this.ctlListaAsistencia1.Size = new System.Drawing.Size(1098, 852);
            this.ctlListaAsistencia1.TabIndex = 0;
            // 
            // PageDetalleAsistencia
            // 
            this.PageDetalleAsistencia.Caption = "PageDetalleAsistencia";
            this.PageDetalleAsistencia.Controls.Add(this.ctlDetallesAsistencia1);
            this.PageDetalleAsistencia.Name = "PageDetalleAsistencia";
            this.PageDetalleAsistencia.Size = new System.Drawing.Size(1098, 852);
            // 
            // ctlDetallesAsistencia1
            // 
            this.ctlDetallesAsistencia1.BackColor = System.Drawing.Color.White;
            this.ctlDetallesAsistencia1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlDetallesAsistencia1.Location = new System.Drawing.Point(0, 0);
            this.ctlDetallesAsistencia1.Name = "ctlDetallesAsistencia1";
            this.ctlDetallesAsistencia1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlDetallesAsistencia1.Pro_Carnet = false;
            this.ctlDetallesAsistencia1.Pro_Conexion = null;
            this.ctlDetallesAsistencia1.Pro_Credenciales = null;
            this.ctlDetallesAsistencia1.Pro_ID_Actividad = 0;
            this.ctlDetallesAsistencia1.Pro_ID_AreaAtencion = 0;
            this.ctlDetallesAsistencia1.Pro_ID_Colaborador = 0;
            this.ctlDetallesAsistencia1.Pro_Presente = false;
            this.ctlDetallesAsistencia1.Pro_Uniforme = false;
            this.ctlDetallesAsistencia1.Pro_Usuario = null;
            this.ctlDetallesAsistencia1.Size = new System.Drawing.Size(1098, 852);
            this.ctlDetallesAsistencia1.TabIndex = 0;
            // 
            // PageMensaje
            // 
            this.PageMensaje.Caption = "PageMensaje";
            this.PageMensaje.Controls.Add(this.panel1);
            this.PageMensaje.Controls.Add(this.lblEncabezado);
            this.PageMensaje.Name = "PageMensaje";
            this.PageMensaje.Size = new System.Drawing.Size(1098, 852);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdVerHistorico);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 56);
            this.panel1.TabIndex = 11;
            // 
            // cmdVerHistorico
            // 
            this.cmdVerHistorico.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdVerHistorico.EditValue = global::Coordinadores_de_Edad.Resources.iconBusqueda;
            this.cmdVerHistorico.Location = new System.Drawing.Point(1049, 0);
            this.cmdVerHistorico.Name = "cmdVerHistorico";
            this.cmdVerHistorico.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdVerHistorico.Properties.NullText = "   ";
            this.cmdVerHistorico.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdVerHistorico.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdVerHistorico.Size = new System.Drawing.Size(49, 56);
            this.cmdVerHistorico.TabIndex = 34;
            this.cmdVerHistorico.ToolTip = "Buscar en historial de asistencias";
            this.cmdVerHistorico.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.cmdVerHistorico.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cmdVerHistorico.ToolTipTitle = "Arca de los Tesoros";
            this.cmdVerHistorico.Click += new System.EventHandler(this.CmdVerHistorico_Click);
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
            this.lblEncabezado.Size = new System.Drawing.Size(1098, 852);
            this.lblEncabezado.TabIndex = 10;
            this.lblEncabezado.Text = "No hay actividades programadas para este día";
            // 
            // ctlContenedorAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.NavegacionAsistencias);
            this.Name = "ctlContenedorAsistencias";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1108, 862);
            ((System.ComponentModel.ISupportInitialize)(this.NavegacionAsistencias)).EndInit();
            this.NavegacionAsistencias.ResumeLayout(false);
            this.PageListaAsistencia.ResumeLayout(false);
            this.PageDetalleAsistencia.ResumeLayout(false);
            this.PageMensaje.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerHistorico.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationFrame NavegacionAsistencias;
        private DevExpress.XtraBars.Navigation.NavigationPage PageListaAsistencia;
        private ctlListaAsistencia ctlListaAsistencia1;
        private DevExpress.XtraBars.Navigation.NavigationPage PageDetalleAsistencia;
        private ctlDetallesAsistencia ctlDetallesAsistencia1;
        private DevExpress.XtraBars.Navigation.NavigationPage PageMensaje;
        private DevExpress.XtraEditors.LabelControl lblEncabezado;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PictureEdit cmdVerHistorico;
    }
}
