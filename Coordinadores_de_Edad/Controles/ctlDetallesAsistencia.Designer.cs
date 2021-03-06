﻿namespace Coordinadores_de_Edad.Controles
{
    partial class ctlDetallesAsistencia
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlDetallesAsistencia));
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblEncabezado = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlDatosColaborador = new System.Windows.Forms.Panel();
            this.txtFuerzasEspeciales = new DevExpress.XtraEditors.TextEdit();
            this.txtIdentidadColaborador = new DevExpress.XtraEditors.TextEdit();
            this.txtNombreColaborador = new DevExpress.XtraEditors.TextEdit();
            this.picFotoColaborador = new DevExpress.XtraEditors.PictureEdit();
            this.picCaratulaAsistencia = new DevExpress.XtraEditors.PictureEdit();
            this.NavegacionObservaciones = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.page = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.glAula = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bsAulas = new System.Windows.Forms.BindingSource(this.components);
            this.dsVistas1 = new Core.DataSets.dsVistas();
            this.gvAulas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colaula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colarea_atencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_aula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toggleCarnet = new DevExpress.XtraEditors.PictureEdit();
            this.toggleUniforme = new DevExpress.XtraEditors.PictureEdit();
            this.cmdGuardarAsistencia = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.pageInasistencias = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.cmdSeleccionarCubrirAusencia = new DevExpress.XtraEditors.PictureEdit();
            this.memoObservacionesInasistencia = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.radioSinJustificacion = new System.Windows.Forms.RadioButton();
            this.radioOtros = new System.Windows.Forms.RadioButton();
            this.radioEnfermedad = new System.Windows.Forms.RadioButton();
            this.radioPorLabores = new System.Windows.Forms.RadioButton();
            this.radioProblemasFamiliares = new System.Windows.Forms.RadioButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.NavigationPrincipal = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.PageCubrirAusencia = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ctlCubrirAusencias1 = new Coordinadores_de_Edad.Controles.ctlCubrirAusencias();
            this.PageDetalles = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Coordinadores_de_Edad.Pantallas.frmEspera), true, true, typeof(System.Windows.Forms.UserControl));
            this.cmdAtras = new DevExpress.XtraEditors.PictureEdit();
            this.pnlEncabezado.SuspendLayout();
            this.pnlDatosColaborador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuerzasEspeciales.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdentidadColaborador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreColaborador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoColaborador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCaratulaAsistencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavegacionObservaciones)).BeginInit();
            this.NavegacionObservaciones.SuspendLayout();
            this.page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glAula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAulas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVistas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAulas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleCarnet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleUniforme.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdGuardarAsistencia.Properties)).BeginInit();
            this.pageInasistencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdSeleccionarCubrirAusencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoObservacionesInasistencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigationPrincipal)).BeginInit();
            this.NavigationPrincipal.SuspendLayout();
            this.PageCubrirAusencia.SuspendLayout();
            this.PageDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAtras.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.cmdAtras);
            this.pnlEncabezado.Controls.Add(this.lblEncabezado);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1138, 53);
            this.pnlEncabezado.TabIndex = 16;
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.Appearance.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.Appearance.Options.UseFont = true;
            this.lblEncabezado.Appearance.Options.UseTextOptions = true;
            this.lblEncabezado.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblEncabezado.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblEncabezado.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEncabezado.Location = new System.Drawing.Point(0, 0);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(1138, 53);
            this.lblEncabezado.TabIndex = 9;
            this.lblEncabezado.Text = "Ingreso de Asistencia";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1138, 2);
            this.panel2.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1138, 14);
            this.panel4.TabIndex = 20;
            // 
            // pnlDatosColaborador
            // 
            this.pnlDatosColaborador.Controls.Add(this.txtFuerzasEspeciales);
            this.pnlDatosColaborador.Controls.Add(this.txtIdentidadColaborador);
            this.pnlDatosColaborador.Controls.Add(this.txtNombreColaborador);
            this.pnlDatosColaborador.Controls.Add(this.picFotoColaborador);
            this.pnlDatosColaborador.Controls.Add(this.picCaratulaAsistencia);
            this.pnlDatosColaborador.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDatosColaborador.Location = new System.Drawing.Point(0, 69);
            this.pnlDatosColaborador.Name = "pnlDatosColaborador";
            this.pnlDatosColaborador.Size = new System.Drawing.Size(1138, 217);
            this.pnlDatosColaborador.TabIndex = 30;
            // 
            // txtFuerzasEspeciales
            // 
            this.txtFuerzasEspeciales.EditValue = "Equipo";
            this.txtFuerzasEspeciales.Location = new System.Drawing.Point(233, 142);
            this.txtFuerzasEspeciales.Name = "txtFuerzasEspeciales";
            this.txtFuerzasEspeciales.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtFuerzasEspeciales.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuerzasEspeciales.Properties.Appearance.Options.UseBackColor = true;
            this.txtFuerzasEspeciales.Properties.Appearance.Options.UseFont = true;
            this.txtFuerzasEspeciales.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtFuerzasEspeciales.Properties.ReadOnly = true;
            this.txtFuerzasEspeciales.Size = new System.Drawing.Size(611, 42);
            this.txtFuerzasEspeciales.TabIndex = 32;
            // 
            // txtIdentidadColaborador
            // 
            this.txtIdentidadColaborador.EditValue = "#Identidad";
            this.txtIdentidadColaborador.Location = new System.Drawing.Point(233, 82);
            this.txtIdentidadColaborador.Name = "txtIdentidadColaborador";
            this.txtIdentidadColaborador.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtIdentidadColaborador.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentidadColaborador.Properties.Appearance.Options.UseBackColor = true;
            this.txtIdentidadColaborador.Properties.Appearance.Options.UseFont = true;
            this.txtIdentidadColaborador.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtIdentidadColaborador.Properties.ReadOnly = true;
            this.txtIdentidadColaborador.Size = new System.Drawing.Size(552, 42);
            this.txtIdentidadColaborador.TabIndex = 31;
            // 
            // txtNombreColaborador
            // 
            this.txtNombreColaborador.EditValue = "Nombre Colaborador";
            this.txtNombreColaborador.Location = new System.Drawing.Point(233, 23);
            this.txtNombreColaborador.Name = "txtNombreColaborador";
            this.txtNombreColaborador.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtNombreColaborador.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreColaborador.Properties.Appearance.Options.UseBackColor = true;
            this.txtNombreColaborador.Properties.Appearance.Options.UseFont = true;
            this.txtNombreColaborador.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtNombreColaborador.Properties.ReadOnly = true;
            this.txtNombreColaborador.Size = new System.Drawing.Size(584, 42);
            this.txtNombreColaborador.TabIndex = 30;
            // 
            // picFotoColaborador
            // 
            this.picFotoColaborador.EditValue = global::Coordinadores_de_Edad.Resources._62218400_2421805074506489_798898671931359232_n;
            this.picFotoColaborador.Location = new System.Drawing.Point(42, 25);
            this.picFotoColaborador.Name = "picFotoColaborador";
            this.picFotoColaborador.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picFotoColaborador.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picFotoColaborador.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picFotoColaborador.Size = new System.Drawing.Size(149, 159);
            this.picFotoColaborador.TabIndex = 21;
            // 
            // picCaratulaAsistencia
            // 
            this.picCaratulaAsistencia.EditValue = global::Coordinadores_de_Edad.Resources.sad;
            this.picCaratulaAsistencia.Location = new System.Drawing.Point(931, 36);
            this.picCaratulaAsistencia.Name = "picCaratulaAsistencia";
            this.picCaratulaAsistencia.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.False;
            this.picCaratulaAsistencia.Properties.AllowFocused = false;
            this.picCaratulaAsistencia.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.picCaratulaAsistencia.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.picCaratulaAsistencia.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.picCaratulaAsistencia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picCaratulaAsistencia.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picCaratulaAsistencia.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picCaratulaAsistencia.Size = new System.Drawing.Size(140, 132);
            this.picCaratulaAsistencia.TabIndex = 22;
            // 
            // NavegacionObservaciones
            // 
            this.NavegacionObservaciones.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.NavegacionObservaciones.Controls.Add(this.page);
            this.NavegacionObservaciones.Controls.Add(this.pageInasistencias);
            this.NavegacionObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavegacionObservaciones.Location = new System.Drawing.Point(0, 286);
            this.NavegacionObservaciones.Name = "NavegacionObservaciones";
            this.NavegacionObservaciones.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.page,
            this.pageInasistencias});
            this.NavegacionObservaciones.SelectedPage = this.page;
            this.NavegacionObservaciones.Size = new System.Drawing.Size(1138, 365);
            this.NavegacionObservaciones.TabIndex = 31;
            this.NavegacionObservaciones.Text = "navigationFrame1";
            this.NavegacionObservaciones.TransitionAnimationProperties.FrameCount = 500;
            this.NavegacionObservaciones.TransitionAnimationProperties.FrameInterval = 500;
            // 
            // page
            // 
            this.page.Caption = "page";
            this.page.Controls.Add(this.labelControl1);
            this.page.Controls.Add(this.glAula);
            this.page.Controls.Add(this.toggleCarnet);
            this.page.Controls.Add(this.toggleUniforme);
            this.page.Controls.Add(this.cmdGuardarAsistencia);
            this.page.Controls.Add(this.labelControl7);
            this.page.Controls.Add(this.labelControl6);
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(1138, 365);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(747, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 45);
            this.labelControl1.TabIndex = 43;
            this.labelControl1.Text = "Aula";
            // 
            // glAula
            // 
            this.glAula.EditValue = "";
            this.glAula.Location = new System.Drawing.Point(640, 93);
            this.glAula.Name = "glAula";
            this.glAula.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glAula.Properties.Appearance.Options.UseFont = true;
            this.glAula.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glAula.Properties.DataSource = this.bsAulas;
            this.glAula.Properties.DisplayMember = "aula";
            this.glAula.Properties.PopupView = this.gvAulas;
            this.glAula.Properties.ValueMember = "id_aula";
            this.glAula.Size = new System.Drawing.Size(315, 34);
            this.glAula.TabIndex = 42;
            // 
            // bsAulas
            // 
            this.bsAulas.DataMember = "dtAulas";
            this.bsAulas.DataSource = this.dsVistas1;
            // 
            // dsVistas1
            // 
            this.dsVistas1.DataSetName = "dsVistas";
            this.dsVistas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvAulas
            // 
            this.gvAulas.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvAulas.Appearance.Row.Options.UseFont = true;
            this.gvAulas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colaula,
            this.colarea_atencion,
            this.colid_aula});
            this.gvAulas.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvAulas.Name = "gvAulas";
            this.gvAulas.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvAulas.OptionsView.ShowColumnHeaders = false;
            this.gvAulas.OptionsView.ShowGroupPanel = false;
            this.gvAulas.OptionsView.ShowIndicator = false;
            // 
            // colaula
            // 
            this.colaula.Caption = "Aula";
            this.colaula.FieldName = "aula";
            this.colaula.Name = "colaula";
            this.colaula.Visible = true;
            this.colaula.VisibleIndex = 0;
            // 
            // colarea_atencion
            // 
            this.colarea_atencion.Caption = "Area Atención";
            this.colarea_atencion.FieldName = "area_atencion";
            this.colarea_atencion.Name = "colarea_atencion";
            this.colarea_atencion.Visible = true;
            this.colarea_atencion.VisibleIndex = 1;
            // 
            // colid_aula
            // 
            this.colid_aula.FieldName = "id_aula";
            this.colid_aula.Name = "colid_aula";
            // 
            // toggleCarnet
            // 
            this.toggleCarnet.EditValue = global::Coordinadores_de_Edad.Resources.switch_3_;
            this.toggleCarnet.Location = new System.Drawing.Point(420, 67);
            this.toggleCarnet.Name = "toggleCarnet";
            this.toggleCarnet.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.toggleCarnet.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.toggleCarnet.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.toggleCarnet.Size = new System.Drawing.Size(80, 80);
            this.toggleCarnet.TabIndex = 41;
            this.toggleCarnet.Click += new System.EventHandler(this.ToggleCarnet_Click);
            // 
            // toggleUniforme
            // 
            this.toggleUniforme.EditValue = global::Coordinadores_de_Edad.Resources.switch_3_;
            this.toggleUniforme.Location = new System.Drawing.Point(96, 67);
            this.toggleUniforme.Name = "toggleUniforme";
            this.toggleUniforme.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.toggleUniforme.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.toggleUniforme.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.toggleUniforme.Size = new System.Drawing.Size(80, 80);
            this.toggleUniforme.TabIndex = 40;
            this.toggleUniforme.Click += new System.EventHandler(this.ToggleUniforme_Click);
            // 
            // cmdGuardarAsistencia
            // 
            this.cmdGuardarAsistencia.EditValue = global::Coordinadores_de_Edad.Resources.icon_guardar_negro_64;
            this.cmdGuardarAsistencia.Location = new System.Drawing.Point(1024, 86);
            this.cmdGuardarAsistencia.Name = "cmdGuardarAsistencia";
            this.cmdGuardarAsistencia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdGuardarAsistencia.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdGuardarAsistencia.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.cmdGuardarAsistencia.Size = new System.Drawing.Size(64, 61);
            this.cmdGuardarAsistencia.TabIndex = 39;
            this.cmdGuardarAsistencia.Click += new System.EventHandler(this.CmdGuardarAsistencia_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl7.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.Location = new System.Drawing.Point(344, 16);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(284, 45);
            this.labelControl7.TabIndex = 38;
            this.labelControl7.Text = "¿Está portando carnet?";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl6.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(13, 16);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(325, 45);
            this.labelControl6.TabIndex = 37;
            this.labelControl6.Text = "¿Se presentó con uniforme?";
            // 
            // pageInasistencias
            // 
            this.pageInasistencias.Caption = "pageInasistencias";
            this.pageInasistencias.Controls.Add(this.cmdSeleccionarCubrirAusencia);
            this.pageInasistencias.Controls.Add(this.memoObservacionesInasistencia);
            this.pageInasistencias.Controls.Add(this.labelControl5);
            this.pageInasistencias.Controls.Add(this.radioSinJustificacion);
            this.pageInasistencias.Controls.Add(this.radioOtros);
            this.pageInasistencias.Controls.Add(this.radioEnfermedad);
            this.pageInasistencias.Controls.Add(this.radioPorLabores);
            this.pageInasistencias.Controls.Add(this.radioProblemasFamiliares);
            this.pageInasistencias.Controls.Add(this.labelControl4);
            this.pageInasistencias.Name = "pageInasistencias";
            this.pageInasistencias.Size = new System.Drawing.Size(1138, 365);
            // 
            // cmdSeleccionarCubrirAusencia
            // 
            this.cmdSeleccionarCubrirAusencia.EditValue = global::Coordinadores_de_Edad.Resources.icon_cubrir_asistencia;
            this.cmdSeleccionarCubrirAusencia.Location = new System.Drawing.Point(996, 233);
            this.cmdSeleccionarCubrirAusencia.Name = "cmdSeleccionarCubrirAusencia";
            this.cmdSeleccionarCubrirAusencia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdSeleccionarCubrirAusencia.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdSeleccionarCubrirAusencia.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.cmdSeleccionarCubrirAusencia.Size = new System.Drawing.Size(75, 74);
            this.cmdSeleccionarCubrirAusencia.TabIndex = 38;
            this.cmdSeleccionarCubrirAusencia.Click += new System.EventHandler(this.CmdSeleccionarCubrirAusencia_Click);
            // 
            // memoObservacionesInasistencia
            // 
            this.memoObservacionesInasistencia.Location = new System.Drawing.Point(42, 199);
            this.memoObservacionesInasistencia.Name = "memoObservacionesInasistencia";
            this.memoObservacionesInasistencia.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoObservacionesInasistencia.Properties.Appearance.Options.UseFont = true;
            this.memoObservacionesInasistencia.Size = new System.Drawing.Size(913, 108);
            this.memoObservacionesInasistencia.TabIndex = 37;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl5.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(54, 148);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(271, 45);
            this.labelControl5.TabIndex = 36;
            this.labelControl5.Text = "Observaciones:";
            // 
            // radioSinJustificacion
            // 
            this.radioSinJustificacion.AutoSize = true;
            this.radioSinJustificacion.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSinJustificacion.Location = new System.Drawing.Point(854, 80);
            this.radioSinJustificacion.Name = "radioSinJustificacion";
            this.radioSinJustificacion.Size = new System.Drawing.Size(205, 36);
            this.radioSinJustificacion.TabIndex = 35;
            this.radioSinJustificacion.TabStop = true;
            this.radioSinJustificacion.Text = "Sin Justificación";
            this.radioSinJustificacion.UseVisualStyleBackColor = true;
            this.radioSinJustificacion.CheckedChanged += new System.EventHandler(this.RadioProblemasFamiliares_CheckedChanged);
            // 
            // radioOtros
            // 
            this.radioOtros.AutoSize = true;
            this.radioOtros.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOtros.Location = new System.Drawing.Point(723, 80);
            this.radioOtros.Name = "radioOtros";
            this.radioOtros.Size = new System.Drawing.Size(94, 36);
            this.radioOtros.TabIndex = 34;
            this.radioOtros.TabStop = true;
            this.radioOtros.Text = "Otros";
            this.radioOtros.UseVisualStyleBackColor = true;
            this.radioOtros.CheckedChanged += new System.EventHandler(this.RadioProblemasFamiliares_CheckedChanged);
            // 
            // radioEnfermedad
            // 
            this.radioEnfermedad.AutoSize = true;
            this.radioEnfermedad.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEnfermedad.Location = new System.Drawing.Point(521, 80);
            this.radioEnfermedad.Name = "radioEnfermedad";
            this.radioEnfermedad.Size = new System.Drawing.Size(165, 36);
            this.radioEnfermedad.TabIndex = 33;
            this.radioEnfermedad.TabStop = true;
            this.radioEnfermedad.Text = "Enfermedad";
            this.radioEnfermedad.UseVisualStyleBackColor = true;
            this.radioEnfermedad.CheckedChanged += new System.EventHandler(this.RadioProblemasFamiliares_CheckedChanged);
            // 
            // radioPorLabores
            // 
            this.radioPorLabores.AutoSize = true;
            this.radioPorLabores.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPorLabores.Location = new System.Drawing.Point(331, 80);
            this.radioPorLabores.Name = "radioPorLabores";
            this.radioPorLabores.Size = new System.Drawing.Size(159, 36);
            this.radioPorLabores.TabIndex = 32;
            this.radioPorLabores.TabStop = true;
            this.radioPorLabores.Text = "Por Labores";
            this.radioPorLabores.UseVisualStyleBackColor = true;
            this.radioPorLabores.CheckedChanged += new System.EventHandler(this.RadioProblemasFamiliares_CheckedChanged);
            // 
            // radioProblemasFamiliares
            // 
            this.radioProblemasFamiliares.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioProblemasFamiliares.Location = new System.Drawing.Point(54, 63);
            this.radioProblemasFamiliares.Name = "radioProblemasFamiliares";
            this.radioProblemasFamiliares.Size = new System.Drawing.Size(271, 70);
            this.radioProblemasFamiliares.TabIndex = 31;
            this.radioProblemasFamiliares.TabStop = true;
            this.radioProblemasFamiliares.Text = "Problemas Familiares";
            this.radioProblemasFamiliares.UseVisualStyleBackColor = true;
            this.radioProblemasFamiliares.CheckedChanged += new System.EventHandler(this.RadioProblemasFamiliares_CheckedChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(40, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(271, 45);
            this.labelControl4.TabIndex = 30;
            this.labelControl4.Text = "Motivo de Inasistencia:";
            // 
            // NavigationPrincipal
            // 
            this.NavigationPrincipal.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.NavigationPrincipal.Controls.Add(this.PageCubrirAusencia);
            this.NavigationPrincipal.Controls.Add(this.PageDetalles);
            this.NavigationPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationPrincipal.Location = new System.Drawing.Point(5, 5);
            this.NavigationPrincipal.Name = "NavigationPrincipal";
            this.NavigationPrincipal.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.PageCubrirAusencia,
            this.PageDetalles});
            this.NavigationPrincipal.SelectedPage = this.PageDetalles;
            this.NavigationPrincipal.Size = new System.Drawing.Size(1138, 651);
            this.NavigationPrincipal.TabIndex = 32;
            this.NavigationPrincipal.Text = "navigationFrame1";
            this.NavigationPrincipal.TransitionAnimationProperties.FrameCount = 500;
            this.NavigationPrincipal.TransitionAnimationProperties.FrameInterval = 500;
            // 
            // PageCubrirAusencia
            // 
            this.PageCubrirAusencia.Caption = "PageCubrirAusencia";
            this.PageCubrirAusencia.Controls.Add(this.ctlCubrirAusencias1);
            this.PageCubrirAusencia.Name = "PageCubrirAusencia";
            this.PageCubrirAusencia.Size = new System.Drawing.Size(1138, 651);
            // 
            // ctlCubrirAusencias1
            // 
            this.ctlCubrirAusencias1.BackColor = System.Drawing.Color.White;
            this.ctlCubrirAusencias1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlCubrirAusencias1.Location = new System.Drawing.Point(0, 0);
            this.ctlCubrirAusencias1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctlCubrirAusencias1.MinimumSize = new System.Drawing.Size(1078, 791);
            this.ctlCubrirAusencias1.Name = "ctlCubrirAusencias1";
            this.ctlCubrirAusencias1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlCubrirAusencias1.Pro_CubrirConServidor = false;
            this.ctlCubrirAusencias1.Pro_ID_Actividad = 0;
            this.ctlCubrirAusencias1.Pro_ID_AreaAtencion = 0;
            this.ctlCubrirAusencias1.Pro_ID_Colaborar_Actividad = 0;
            this.ctlCubrirAusencias1.Pro_NoNecesitaCubrir = false;
            this.ctlCubrirAusencias1.Pro_Usuario = null;
            this.ctlCubrirAusencias1.Size = new System.Drawing.Size(1138, 791);
            this.ctlCubrirAusencias1.TabIndex = 0;
            // 
            // PageDetalles
            // 
            this.PageDetalles.Caption = "PageDetalles";
            this.PageDetalles.Controls.Add(this.NavegacionObservaciones);
            this.PageDetalles.Controls.Add(this.pnlDatosColaborador);
            this.PageDetalles.Controls.Add(this.panel4);
            this.PageDetalles.Controls.Add(this.panel2);
            this.PageDetalles.Controls.Add(this.pnlEncabezado);
            this.PageDetalles.Name = "PageDetalles";
            this.PageDetalles.Size = new System.Drawing.Size(1138, 651);
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // cmdAtras
            // 
            this.cmdAtras.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdAtras.EditValue = ((object)(resources.GetObject("cmdAtras.EditValue")));
            this.cmdAtras.Location = new System.Drawing.Point(0, 0);
            this.cmdAtras.Name = "cmdAtras";
            this.cmdAtras.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdAtras.Properties.NullText = "   ";
            this.cmdAtras.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdAtras.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdAtras.Size = new System.Drawing.Size(63, 53);
            this.cmdAtras.TabIndex = 32;
            this.cmdAtras.Click += new System.EventHandler(this.CmdAtras_Click);
            // 
            // ctlDetallesAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.NavigationPrincipal);
            this.Name = "ctlDetallesAsistencia";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1148, 661);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlDatosColaborador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtFuerzasEspeciales.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdentidadColaborador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreColaborador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoColaborador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCaratulaAsistencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavegacionObservaciones)).EndInit();
            this.NavegacionObservaciones.ResumeLayout(false);
            this.page.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.glAula.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAulas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVistas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAulas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleCarnet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleUniforme.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdGuardarAsistencia.Properties)).EndInit();
            this.pageInasistencias.ResumeLayout(false);
            this.pageInasistencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdSeleccionarCubrirAusencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoObservacionesInasistencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigationPrincipal)).EndInit();
            this.NavigationPrincipal.ResumeLayout(false);
            this.PageCubrirAusencia.ResumeLayout(false);
            this.PageDetalles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdAtras.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private DevExpress.XtraEditors.LabelControl lblEncabezado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.PictureEdit picFotoColaborador;
        private DevExpress.XtraEditors.PictureEdit picCaratulaAsistencia;
        private System.Windows.Forms.Panel pnlDatosColaborador;
        private DevExpress.XtraBars.Navigation.NavigationFrame NavegacionObservaciones;
        private DevExpress.XtraBars.Navigation.NavigationPage page;
        private DevExpress.XtraBars.Navigation.NavigationPage pageInasistencias;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.RadioButton radioSinJustificacion;
        private System.Windows.Forms.RadioButton radioOtros;
        private System.Windows.Forms.RadioButton radioEnfermedad;
        private System.Windows.Forms.RadioButton radioPorLabores;
        private System.Windows.Forms.RadioButton radioProblemasFamiliares;
        private DevExpress.XtraEditors.PictureEdit cmdSeleccionarCubrirAusencia;
        private DevExpress.XtraEditors.MemoEdit memoObservacionesInasistencia;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.PictureEdit cmdGuardarAsistencia;
        private DevExpress.XtraEditors.TextEdit txtFuerzasEspeciales;
        private DevExpress.XtraEditors.TextEdit txtIdentidadColaborador;
        private DevExpress.XtraEditors.TextEdit txtNombreColaborador;
        private DevExpress.XtraEditors.PictureEdit toggleUniforme;
        private DevExpress.XtraEditors.PictureEdit toggleCarnet;
        private DevExpress.XtraBars.Navigation.NavigationFrame NavigationPrincipal;
        private DevExpress.XtraBars.Navigation.NavigationPage PageCubrirAusencia;
        private DevExpress.XtraBars.Navigation.NavigationPage PageDetalles;
        private ctlCubrirAusencias ctlCubrirAusencias1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GridLookUpEdit glAula;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAulas;
        private Core.DataSets.dsVistas dsVistas1;
        private System.Windows.Forms.BindingSource bsAulas;
        private DevExpress.XtraGrid.Columns.GridColumn colaula;
        private DevExpress.XtraGrid.Columns.GridColumn colarea_atencion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_aula;
        private DevExpress.XtraEditors.PictureEdit cmdAtras;
    }
}
