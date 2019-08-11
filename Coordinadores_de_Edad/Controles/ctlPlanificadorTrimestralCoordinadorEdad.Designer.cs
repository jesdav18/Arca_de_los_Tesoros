namespace Coordinadores_de_Edad.Controles
{
    partial class ctlPlanificadorTrimestralCoordinadorEdad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlPlanificadorTrimestralCoordinadorEdad));
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblEncabezado = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmdTercerTrimestre = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCuartoTrimestre = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmdPrimerTrimestre = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSegundoTrimestre = new DevExpress.XtraEditors.SimpleButton();
            this.NavigationPrincipal = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.PageTrimestres = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pageDias = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pageSeleccionMaestros = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pageSeleccionAyuda = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.PageIngresoActividades = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pnlDesplazamiento = new System.Windows.Forms.Panel();
            this.picAtras = new DevExpress.XtraEditors.PictureEdit();
            this.picSiguiente = new DevExpress.XtraEditors.PictureEdit();
            this.ctlDiasTrimestre1 = new Coordinadores_de_Edad.Controles.ctlDiasTrimestre();
            this.ctlSeleccionMaestros_Ayudas1 = new Coordinadores_de_Edad.Controles.ctlSeleccionMaestros_Ayudas();
            this.ctlSeleccionAyuda1 = new Coordinadores_de_Edad.Controles.ctlSeleccionAyuda();
            this.ctlngresoActividad1 = new Coordinadores_de_Edad.Controles.ctlngresoActividad();
            this.pnlEncabezado.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavigationPrincipal)).BeginInit();
            this.NavigationPrincipal.SuspendLayout();
            this.PageTrimestres.SuspendLayout();
            this.pageDias.SuspendLayout();
            this.pageSeleccionMaestros.SuspendLayout();
            this.pageSeleccionAyuda.SuspendLayout();
            this.PageIngresoActividades.SuspendLayout();
            this.pnlDesplazamiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAtras.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSiguiente.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.lblEncabezado);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1330, 75);
            this.pnlEncabezado.TabIndex = 12;
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
            this.lblEncabezado.Size = new System.Drawing.Size(1330, 75);
            this.lblEncabezado.TabIndex = 9;
            this.lblEncabezado.Text = "Planificador Trimestral";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1330, 10);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1330, 670);
            this.panel1.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(200, 91);
            this.panel3.MaximumSize = new System.Drawing.Size(889, 486);
            this.panel3.MinimumSize = new System.Drawing.Size(889, 486);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(889, 486);
            this.panel3.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cmdTercerTrimestre);
            this.panel5.Controls.Add(this.cmdCuartoTrimestre);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 269);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(889, 217);
            this.panel5.TabIndex = 8;
            // 
            // cmdTercerTrimestre
            // 
            this.cmdTercerTrimestre.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTercerTrimestre.Appearance.Options.UseFont = true;
            this.cmdTercerTrimestre.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdTercerTrimestre.Location = new System.Drawing.Point(0, 0);
            this.cmdTercerTrimestre.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(196)))));
            this.cmdTercerTrimestre.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.cmdTercerTrimestre.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdTercerTrimestre.Name = "cmdTercerTrimestre";
            this.cmdTercerTrimestre.Size = new System.Drawing.Size(428, 217);
            this.cmdTercerTrimestre.TabIndex = 5;
            this.cmdTercerTrimestre.Text = "Tercer Trimestre";
            this.cmdTercerTrimestre.Click += new System.EventHandler(this.CmdTercerTrimestre_Click);
            // 
            // cmdCuartoTrimestre
            // 
            this.cmdCuartoTrimestre.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCuartoTrimestre.Appearance.Options.UseFont = true;
            this.cmdCuartoTrimestre.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdCuartoTrimestre.Location = new System.Drawing.Point(461, 0);
            this.cmdCuartoTrimestre.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(196)))));
            this.cmdCuartoTrimestre.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.cmdCuartoTrimestre.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdCuartoTrimestre.Name = "cmdCuartoTrimestre";
            this.cmdCuartoTrimestre.Size = new System.Drawing.Size(428, 217);
            this.cmdCuartoTrimestre.TabIndex = 6;
            this.cmdCuartoTrimestre.Text = "Cuarto Trimestre";
            this.cmdCuartoTrimestre.Click += new System.EventHandler(this.CmdCuartoTrimestre_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmdPrimerTrimestre);
            this.panel4.Controls.Add(this.cmdSegundoTrimestre);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(889, 213);
            this.panel4.TabIndex = 7;
            // 
            // cmdPrimerTrimestre
            // 
            this.cmdPrimerTrimestre.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPrimerTrimestre.Appearance.Options.UseFont = true;
            this.cmdPrimerTrimestre.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdPrimerTrimestre.Location = new System.Drawing.Point(0, 0);
            this.cmdPrimerTrimestre.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(196)))));
            this.cmdPrimerTrimestre.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(196)))));
            this.cmdPrimerTrimestre.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.cmdPrimerTrimestre.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdPrimerTrimestre.Name = "cmdPrimerTrimestre";
            this.cmdPrimerTrimestre.Size = new System.Drawing.Size(428, 213);
            this.cmdPrimerTrimestre.TabIndex = 0;
            this.cmdPrimerTrimestre.Text = "Primer Trimestre";
            this.cmdPrimerTrimestre.Click += new System.EventHandler(this.CmdPrimerTrimestre_Click);
            // 
            // cmdSegundoTrimestre
            // 
            this.cmdSegundoTrimestre.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSegundoTrimestre.Appearance.Options.UseFont = true;
            this.cmdSegundoTrimestre.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdSegundoTrimestre.Location = new System.Drawing.Point(461, 0);
            this.cmdSegundoTrimestre.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(196)))));
            this.cmdSegundoTrimestre.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.cmdSegundoTrimestre.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdSegundoTrimestre.Name = "cmdSegundoTrimestre";
            this.cmdSegundoTrimestre.Size = new System.Drawing.Size(428, 213);
            this.cmdSegundoTrimestre.TabIndex = 4;
            this.cmdSegundoTrimestre.Text = "Segundo Trimestre";
            this.cmdSegundoTrimestre.Click += new System.EventHandler(this.CmdSegundoTrimestre_Click);
            // 
            // NavigationPrincipal
            // 
            this.NavigationPrincipal.Controls.Add(this.PageTrimestres);
            this.NavigationPrincipal.Controls.Add(this.pageDias);
            this.NavigationPrincipal.Controls.Add(this.pageSeleccionMaestros);
            this.NavigationPrincipal.Controls.Add(this.pageSeleccionAyuda);
            this.NavigationPrincipal.Controls.Add(this.PageIngresoActividades);
            this.NavigationPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationPrincipal.Location = new System.Drawing.Point(5, 5);
            this.NavigationPrincipal.Name = "NavigationPrincipal";
            this.NavigationPrincipal.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.PageTrimestres,
            this.pageDias,
            this.pageSeleccionMaestros,
            this.pageSeleccionAyuda,
            this.PageIngresoActividades});
            this.NavigationPrincipal.SelectedPage = this.PageTrimestres;
            this.NavigationPrincipal.Size = new System.Drawing.Size(1330, 755);
            this.NavigationPrincipal.TabIndex = 15;
            this.NavigationPrincipal.Text = "navigationFrame1";
            this.NavigationPrincipal.TransitionAnimationProperties.FrameCount = 300;
            this.NavigationPrincipal.TransitionAnimationProperties.FrameInterval = 300;
            this.NavigationPrincipal.SelectedPageChanged += new DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(this.NavigationPrincipal_SelectedPageChanged);
            // 
            // PageTrimestres
            // 
            this.PageTrimestres.Caption = "PageTrimestres";
            this.PageTrimestres.Controls.Add(this.panel1);
            this.PageTrimestres.Controls.Add(this.panel2);
            this.PageTrimestres.Controls.Add(this.pnlEncabezado);
            this.PageTrimestres.Name = "PageTrimestres";
            this.PageTrimestres.Size = new System.Drawing.Size(1330, 755);
            // 
            // pageDias
            // 
            this.pageDias.Caption = "pageDias";
            this.pageDias.Controls.Add(this.ctlDiasTrimestre1);
            this.pageDias.Name = "pageDias";
            this.pageDias.Size = new System.Drawing.Size(1330, 755);
            // 
            // pageSeleccionMaestros
            // 
            this.pageSeleccionMaestros.Caption = "pageSeleccionMaestros";
            this.pageSeleccionMaestros.Controls.Add(this.ctlSeleccionMaestros_Ayudas1);
            this.pageSeleccionMaestros.Name = "pageSeleccionMaestros";
            this.pageSeleccionMaestros.Size = new System.Drawing.Size(1330, 755);
            // 
            // pageSeleccionAyuda
            // 
            this.pageSeleccionAyuda.Caption = "pageSeleccionAyuda";
            this.pageSeleccionAyuda.Controls.Add(this.ctlSeleccionAyuda1);
            this.pageSeleccionAyuda.Name = "pageSeleccionAyuda";
            this.pageSeleccionAyuda.Size = new System.Drawing.Size(1330, 755);
            // 
            // PageIngresoActividades
            // 
            this.PageIngresoActividades.Caption = "PageIngresoActividades";
            this.PageIngresoActividades.Controls.Add(this.ctlngresoActividad1);
            this.PageIngresoActividades.Name = "PageIngresoActividades";
            this.PageIngresoActividades.Size = new System.Drawing.Size(1330, 755);
            // 
            // pnlDesplazamiento
            // 
            this.pnlDesplazamiento.Controls.Add(this.picAtras);
            this.pnlDesplazamiento.Controls.Add(this.picSiguiente);
            this.pnlDesplazamiento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDesplazamiento.Location = new System.Drawing.Point(5, 760);
            this.pnlDesplazamiento.Name = "pnlDesplazamiento";
            this.pnlDesplazamiento.Size = new System.Drawing.Size(1330, 67);
            this.pnlDesplazamiento.TabIndex = 25;
            // 
            // picAtras
            // 
            this.picAtras.Dock = System.Windows.Forms.DockStyle.Left;
            this.picAtras.EditValue = ((object)(resources.GetObject("picAtras.EditValue")));
            this.picAtras.Location = new System.Drawing.Point(0, 0);
            this.picAtras.Name = "picAtras";
            this.picAtras.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picAtras.Properties.NullText = "   ";
            this.picAtras.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picAtras.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picAtras.Size = new System.Drawing.Size(80, 67);
            this.picAtras.TabIndex = 18;
            this.picAtras.Click += new System.EventHandler(this.PicAtras_Click);
            // 
            // picSiguiente
            // 
            this.picSiguiente.Dock = System.Windows.Forms.DockStyle.Right;
            this.picSiguiente.EditValue = ((object)(resources.GetObject("picSiguiente.EditValue")));
            this.picSiguiente.Location = new System.Drawing.Point(1250, 0);
            this.picSiguiente.Name = "picSiguiente";
            this.picSiguiente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picSiguiente.Properties.NullText = "   ";
            this.picSiguiente.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picSiguiente.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picSiguiente.Size = new System.Drawing.Size(80, 67);
            this.picSiguiente.TabIndex = 17;
            this.picSiguiente.Click += new System.EventHandler(this.PicSiguiente_Click);
            // 
            // ctlDiasTrimestre1
            // 
            this.ctlDiasTrimestre1.BackColor = System.Drawing.Color.White;
            this.ctlDiasTrimestre1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlDiasTrimestre1.Location = new System.Drawing.Point(0, 0);
            this.ctlDiasTrimestre1.Name = "ctlDiasTrimestre1";
            this.ctlDiasTrimestre1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlDiasTrimestre1.Pro_Anio = null;
            this.ctlDiasTrimestre1.Pro_Conexion = null;
            this.ctlDiasTrimestre1.Pro_NumeroTrimestre = 0;
            this.ctlDiasTrimestre1.Pro_Usuario = null;
            this.ctlDiasTrimestre1.Size = new System.Drawing.Size(1330, 755);
            this.ctlDiasTrimestre1.TabIndex = 0;
            // 
            // ctlSeleccionMaestros_Ayudas1
            // 
            this.ctlSeleccionMaestros_Ayudas1.BackColor = System.Drawing.Color.White;
            this.ctlSeleccionMaestros_Ayudas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlSeleccionMaestros_Ayudas1.Location = new System.Drawing.Point(0, 0);
            this.ctlSeleccionMaestros_Ayudas1.Name = "ctlSeleccionMaestros_Ayudas1";
            this.ctlSeleccionMaestros_Ayudas1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlSeleccionMaestros_Ayudas1.Pro_Conexion = null;
            this.ctlSeleccionMaestros_Ayudas1.Pro_Fecha = null;
            this.ctlSeleccionMaestros_Ayudas1.Pro_ID_AreaAtencion = 0;
            this.ctlSeleccionMaestros_Ayudas1.Pro_MostrarEncabezado = true;
            this.ctlSeleccionMaestros_Ayudas1.Pro_Usuario = null;
            this.ctlSeleccionMaestros_Ayudas1.Size = new System.Drawing.Size(1330, 755);
            this.ctlSeleccionMaestros_Ayudas1.TabIndex = 0;
            // 
            // ctlSeleccionAyuda1
            // 
            this.ctlSeleccionAyuda1.BackColor = System.Drawing.Color.White;
            this.ctlSeleccionAyuda1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlSeleccionAyuda1.Location = new System.Drawing.Point(0, 0);
            this.ctlSeleccionAyuda1.Name = "ctlSeleccionAyuda1";
            this.ctlSeleccionAyuda1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlSeleccionAyuda1.Pro_Conexion = null;
            this.ctlSeleccionAyuda1.Pro_Fecha = null;
            this.ctlSeleccionAyuda1.Pro_ID_AreaAtencion = 0;
            this.ctlSeleccionAyuda1.Pro_MostrarEncabezado = true;
            this.ctlSeleccionAyuda1.Pro_Usuario = null;
            this.ctlSeleccionAyuda1.Size = new System.Drawing.Size(1330, 755);
            this.ctlSeleccionAyuda1.TabIndex = 0;
            // 
            // ctlngresoActividad1
            // 
            this.ctlngresoActividad1.BackColor = System.Drawing.Color.White;
            this.ctlngresoActividad1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlngresoActividad1.Location = new System.Drawing.Point(0, 0);
            this.ctlngresoActividad1.Name = "ctlngresoActividad1";
            this.ctlngresoActividad1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlngresoActividad1.Size = new System.Drawing.Size(1330, 755);
            this.ctlngresoActividad1.TabIndex = 0;
            // 
            // ctlPlanificadorTrimestralCoordinadorEdad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.NavigationPrincipal);
            this.Controls.Add(this.pnlDesplazamiento);
            this.Name = "ctlPlanificadorTrimestralCoordinadorEdad";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1340, 832);
            this.pnlEncabezado.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NavigationPrincipal)).EndInit();
            this.NavigationPrincipal.ResumeLayout(false);
            this.PageTrimestres.ResumeLayout(false);
            this.pageDias.ResumeLayout(false);
            this.pageSeleccionMaestros.ResumeLayout(false);
            this.pageSeleccionAyuda.ResumeLayout(false);
            this.PageIngresoActividades.ResumeLayout(false);
            this.pnlDesplazamiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAtras.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSiguiente.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlEncabezado;
        private DevExpress.XtraEditors.LabelControl lblEncabezado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton cmdCuartoTrimestre;
        private DevExpress.XtraEditors.SimpleButton cmdTercerTrimestre;
        private DevExpress.XtraEditors.SimpleButton cmdSegundoTrimestre;
        private DevExpress.XtraEditors.SimpleButton cmdPrimerTrimestre;
        private DevExpress.XtraBars.Navigation.NavigationFrame NavigationPrincipal;
        private DevExpress.XtraBars.Navigation.NavigationPage PageTrimestres;
        private DevExpress.XtraBars.Navigation.NavigationPage pageDias;
        private ctlDiasTrimestre ctlDiasTrimestre1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraBars.Navigation.NavigationPage pageSeleccionMaestros;
        private ctlSeleccionMaestros_Ayudas ctlSeleccionMaestros_Ayudas1;
        private DevExpress.XtraBars.Navigation.NavigationPage pageSeleccionAyuda;
        private ctlSeleccionAyuda ctlSeleccionAyuda1;
        private DevExpress.XtraBars.Navigation.NavigationPage PageIngresoActividades;
        private System.Windows.Forms.Panel pnlDesplazamiento;
        private DevExpress.XtraEditors.PictureEdit picAtras;
        private DevExpress.XtraEditors.PictureEdit picSiguiente;
        private ctlngresoActividad ctlngresoActividad1;
    }
}
