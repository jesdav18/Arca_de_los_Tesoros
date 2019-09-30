namespace Core.Controles
{
    partial class ctlPlanificadorActividades
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
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblEncabezado = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
            this.NavegacionPrincipal = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.pageCalendario = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.PageIngresoCita = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picBorrar = new DevExpress.XtraEditors.PictureEdit();
            this.picGuardar = new DevExpress.XtraEditors.PictureEdit();
            this.picIrAtras = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.memoObservaciones = new DevExpress.XtraEditors.MemoEdit();
            this.txtAsunto = new DevExpress.XtraEditors.TextEdit();
            this.txtLugar = new DevExpress.XtraEditors.TextEdit();
            this.glColorEtiqueta = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gvPaises = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lblSubtitulo = new DevExpress.XtraEditors.LabelControl();
            this.dsVistas1 = new Core.DataSets.dsVistas();
            this.dateFechaInicio = new DevExpress.XtraEditors.DateEdit();
            this.dateFechaFin = new DevExpress.XtraEditors.DateEdit();
            this.colid_pais = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_pais = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavegacionPrincipal)).BeginInit();
            this.NavegacionPrincipal.SuspendLayout();
            this.pageCalendario.SuspendLayout();
            this.PageIngresoCita.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBorrar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuardar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIrAtras.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoObservaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAsunto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLugar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glColorEtiqueta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPaises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVistas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaInicio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaFin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaFin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.button1);
            this.pnlEncabezado.Controls.Add(this.lblEncabezado);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(5, 5);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1039, 75);
            this.pnlEncabezado.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(874, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
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
            this.lblEncabezado.Size = new System.Drawing.Size(1039, 75);
            this.lblEncabezado.TabIndex = 9;
            this.lblEncabezado.Text = "Planificador de Actividades";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 10);
            this.panel2.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 29);
            this.panel1.TabIndex = 19;
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month;
            this.schedulerControl1.DataStorage = this.schedulerDataStorage1;
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.OptionsBehavior.TimeRegionValidationInterval = System.TimeSpan.Parse("00:10:00");
            this.schedulerControl1.OptionsCustomization.AllowAppointmentEdit = DevExpress.XtraScheduler.UsedAppointmentType.NonRecurring;
            this.schedulerControl1.OptionsCustomization.AllowDisplayAppointmentDependencyForm = DevExpress.XtraScheduler.AllowDisplayAppointmentDependencyForm.Never;
            this.schedulerControl1.OptionsCustomization.AllowDisplayAppointmentFlyout = false;
            this.schedulerControl1.OptionsCustomization.AllowDisplayAppointmentForm = DevExpress.XtraScheduler.AllowDisplayAppointmentForm.Never;
            this.schedulerControl1.Size = new System.Drawing.Size(1039, 541);
            this.schedulerControl1.Start = new System.DateTime(2019, 9, 23, 0, 0, 0, 0);
            this.schedulerControl1.TabIndex = 20;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.FullWeekView.Enabled = true;
            this.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            this.schedulerControl1.EditAppointmentFormShowing += new DevExpress.XtraScheduler.AppointmentFormEventHandler(this.SchedulerControl1_EditAppointmentFormShowing);
            this.schedulerControl1.DoubleClick += new System.EventHandler(this.SchedulerControl1_DoubleClick);
            // 
            // schedulerDataStorage1
            // 
            // 
            // 
            // 
            this.schedulerDataStorage1.AppointmentDependencies.AutoReload = false;
            // 
            // 
            // 
            this.schedulerDataStorage1.Appointments.DataMember = "dtCalendario";
            // 
            // NavegacionPrincipal
            // 
            this.NavegacionPrincipal.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.NavegacionPrincipal.Controls.Add(this.pageCalendario);
            this.NavegacionPrincipal.Controls.Add(this.PageIngresoCita);
            this.NavegacionPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavegacionPrincipal.Location = new System.Drawing.Point(5, 119);
            this.NavegacionPrincipal.Name = "NavegacionPrincipal";
            this.NavegacionPrincipal.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pageCalendario,
            this.PageIngresoCita});
            this.NavegacionPrincipal.SelectedPage = this.pageCalendario;
            this.NavegacionPrincipal.Size = new System.Drawing.Size(1039, 541);
            this.NavegacionPrincipal.TabIndex = 21;
            this.NavegacionPrincipal.Text = "navigationFrame1";
            this.NavegacionPrincipal.TransitionAnimationProperties.FrameCount = 500;
            this.NavegacionPrincipal.TransitionAnimationProperties.FrameInterval = 500;
            // 
            // pageCalendario
            // 
            this.pageCalendario.Caption = "pageCalendario";
            this.pageCalendario.Controls.Add(this.schedulerControl1);
            this.pageCalendario.Name = "pageCalendario";
            this.pageCalendario.Size = new System.Drawing.Size(1039, 541);
            // 
            // PageIngresoCita
            // 
            this.PageIngresoCita.Caption = "PageIngresoCita";
            this.PageIngresoCita.Controls.Add(this.dateFechaFin);
            this.PageIngresoCita.Controls.Add(this.dateFechaInicio);
            this.PageIngresoCita.Controls.Add(this.labelControl6);
            this.PageIngresoCita.Controls.Add(this.glColorEtiqueta);
            this.PageIngresoCita.Controls.Add(this.txtLugar);
            this.PageIngresoCita.Controls.Add(this.memoObservaciones);
            this.PageIngresoCita.Controls.Add(this.txtAsunto);
            this.PageIngresoCita.Controls.Add(this.labelControl5);
            this.PageIngresoCita.Controls.Add(this.labelControl4);
            this.PageIngresoCita.Controls.Add(this.labelControl3);
            this.PageIngresoCita.Controls.Add(this.labelControl2);
            this.PageIngresoCita.Controls.Add(this.labelControl1);
            this.PageIngresoCita.Controls.Add(this.panel3);
            this.PageIngresoCita.Name = "PageIngresoCita";
            this.PageIngresoCita.Size = new System.Drawing.Size(1039, 541);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblSubtitulo);
            this.panel3.Controls.Add(this.picBorrar);
            this.panel3.Controls.Add(this.picGuardar);
            this.panel3.Controls.Add(this.picIrAtras);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1039, 45);
            this.panel3.TabIndex = 0;
            // 
            // picBorrar
            // 
            this.picBorrar.Dock = System.Windows.Forms.DockStyle.Left;
            this.picBorrar.EditValue = global::Core.Properties.Resources.icon_borrar_negro_64;
            this.picBorrar.Location = new System.Drawing.Point(121, 0);
            this.picBorrar.Name = "picBorrar";
            this.picBorrar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picBorrar.Properties.NullText = "   ";
            this.picBorrar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picBorrar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picBorrar.Size = new System.Drawing.Size(63, 45);
            this.picBorrar.TabIndex = 33;
            this.picBorrar.Click += new System.EventHandler(this.PicBorrar_Click);
            // 
            // picGuardar
            // 
            this.picGuardar.Dock = System.Windows.Forms.DockStyle.Left;
            this.picGuardar.EditValue = global::Core.Properties.Resources.icon_guardar_negro_64;
            this.picGuardar.Location = new System.Drawing.Point(58, 0);
            this.picGuardar.Name = "picGuardar";
            this.picGuardar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picGuardar.Properties.NullText = "   ";
            this.picGuardar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picGuardar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picGuardar.Size = new System.Drawing.Size(63, 45);
            this.picGuardar.TabIndex = 32;
            this.picGuardar.Click += new System.EventHandler(this.PicGuardar_Click);
            // 
            // picIrAtras
            // 
            this.picIrAtras.Dock = System.Windows.Forms.DockStyle.Left;
            this.picIrAtras.EditValue = global::Core.Properties.Resources.icon_atras_64;
            this.picIrAtras.Location = new System.Drawing.Point(0, 0);
            this.picIrAtras.Name = "picIrAtras";
            this.picIrAtras.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picIrAtras.Properties.NullText = "   ";
            this.picIrAtras.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picIrAtras.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picIrAtras.Size = new System.Drawing.Size(58, 45);
            this.picIrAtras.TabIndex = 31;
            this.picIrAtras.Click += new System.EventHandler(this.PicIrAtras_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(100, 119);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(209, 30);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Asunto:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(100, 167);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(209, 30);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Lugar:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(101, 220);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(208, 30);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Hora Inicio:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(101, 272);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(208, 30);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Color Etiqueta:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl5.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(101, 326);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(208, 30);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "Observaciones:";
            // 
            // memoObservaciones
            // 
            this.memoObservaciones.Location = new System.Drawing.Point(315, 339);
            this.memoObservaciones.Name = "memoObservaciones";
            this.memoObservaciones.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoObservaciones.Properties.Appearance.Options.UseFont = true;
            this.memoObservaciones.Size = new System.Drawing.Size(634, 147);
            this.memoObservaciones.TabIndex = 32;
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(315, 111);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsunto.Properties.Appearance.Options.UseFont = true;
            this.txtAsunto.Size = new System.Drawing.Size(634, 38);
            this.txtAsunto.TabIndex = 31;
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(315, 159);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugar.Properties.Appearance.Options.UseFont = true;
            this.txtLugar.Size = new System.Drawing.Size(634, 38);
            this.txtLugar.TabIndex = 33;
            // 
            // glColorEtiqueta
            // 
            this.glColorEtiqueta.EditValue = "";
            this.glColorEtiqueta.Location = new System.Drawing.Point(315, 264);
            this.glColorEtiqueta.Name = "glColorEtiqueta";
            this.glColorEtiqueta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glColorEtiqueta.Properties.Appearance.Options.UseFont = true;
            this.glColorEtiqueta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glColorEtiqueta.Properties.DisplayMember = "nombre_pais";
            this.glColorEtiqueta.Properties.PopupView = this.gvPaises;
            this.glColorEtiqueta.Properties.ValueMember = "id_pais";
            this.glColorEtiqueta.Size = new System.Drawing.Size(260, 38);
            this.glColorEtiqueta.TabIndex = 34;
            // 
            // gvPaises
            // 
            this.gvPaises.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPaises.Appearance.Row.Options.UseFont = true;
            this.gvPaises.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_pais,
            this.colnombre_pais});
            this.gvPaises.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvPaises.Name = "gvPaises";
            this.gvPaises.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvPaises.OptionsView.ShowColumnHeaders = false;
            this.gvPaises.OptionsView.ShowGroupPanel = false;
            this.gvPaises.OptionsView.ShowIndicator = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl6.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(469, 215);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(106, 30);
            this.labelControl6.TabIndex = 36;
            this.labelControl6.Text = "Hora Fin:";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Appearance.Options.UseFont = true;
            this.lblSubtitulo.Appearance.Options.UseTextOptions = true;
            this.lblSubtitulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblSubtitulo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblSubtitulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSubtitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubtitulo.Location = new System.Drawing.Point(184, 0);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(855, 45);
            this.lblSubtitulo.TabIndex = 34;
            this.lblSubtitulo.Text = "Crear cita para el día 29/09/2019";
            // 
            // dsVistas1
            // 
            this.dsVistas1.DataSetName = "dsVistas";
            this.dsVistas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateFechaInicio
            // 
            this.dateFechaInicio.EditValue = null;
            this.dateFechaInicio.EnterMoveNextControl = true;
            this.dateFechaInicio.Location = new System.Drawing.Point(315, 212);
            this.dateFechaInicio.Name = "dateFechaInicio";
            this.dateFechaInicio.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaInicio.Properties.Appearance.Options.UseFont = true;
            this.dateFechaInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFechaInicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFechaInicio.Properties.Mask.EditMask = "t";
            this.dateFechaInicio.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateFechaInicio.Size = new System.Drawing.Size(128, 38);
            this.dateFechaInicio.TabIndex = 37;
            // 
            // dateFechaFin
            // 
            this.dateFechaFin.EditValue = null;
            this.dateFechaFin.EnterMoveNextControl = true;
            this.dateFechaFin.Location = new System.Drawing.Point(572, 212);
            this.dateFechaFin.Name = "dateFechaFin";
            this.dateFechaFin.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaFin.Properties.Appearance.Options.UseFont = true;
            this.dateFechaFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFechaFin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFechaFin.Properties.Mask.EditMask = "t";
            this.dateFechaFin.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateFechaFin.Size = new System.Drawing.Size(128, 38);
            this.dateFechaFin.TabIndex = 38;
            // 
            // colid_pais
            // 
            this.colid_pais.FieldName = "id_pais";
            this.colid_pais.Name = "colid_pais";
            this.colid_pais.OptionsColumn.AllowEdit = false;
            this.colid_pais.OptionsColumn.AllowFocus = false;
            this.colid_pais.Visible = true;
            this.colid_pais.VisibleIndex = 1;
            // 
            // colnombre_pais
            // 
            this.colnombre_pais.FieldName = "nombre_pais";
            this.colnombre_pais.Name = "colnombre_pais";
            this.colnombre_pais.OptionsColumn.AllowEdit = false;
            this.colnombre_pais.OptionsColumn.AllowFocus = false;
            this.colnombre_pais.Visible = true;
            this.colnombre_pais.VisibleIndex = 0;
            // 
            // ctlPlanificadorActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.NavegacionPrincipal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlEncabezado);
            this.Name = "ctlPlanificadorActividades";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1049, 665);
            this.pnlEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavegacionPrincipal)).EndInit();
            this.NavegacionPrincipal.ResumeLayout(false);
            this.pageCalendario.ResumeLayout(false);
            this.PageIngresoCita.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBorrar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuardar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIrAtras.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoObservaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAsunto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLugar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glColorEtiqueta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPaises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVistas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaInicio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaFin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaFin.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private DevExpress.XtraEditors.LabelControl lblEncabezado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraBars.Navigation.NavigationFrame NavegacionPrincipal;
        private DevExpress.XtraBars.Navigation.NavigationPage pageCalendario;
        private DevExpress.XtraBars.Navigation.NavigationPage PageIngresoCita;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.PictureEdit picBorrar;
        private DevExpress.XtraEditors.PictureEdit picGuardar;
        private DevExpress.XtraEditors.PictureEdit picIrAtras;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtLugar;
        private DevExpress.XtraEditors.MemoEdit memoObservaciones;
        private DevExpress.XtraEditors.TextEdit txtAsunto;
        private DevExpress.XtraEditors.GridLookUpEdit glColorEtiqueta;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPaises;
        private DevExpress.XtraGrid.Columns.GridColumn colid_pais;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_pais;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lblSubtitulo;
        private DataSets.dsVistas dsVistas1;
        private DevExpress.XtraEditors.DateEdit dateFechaFin;
        private DevExpress.XtraEditors.DateEdit dateFechaInicio;
    }
}
