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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlPlanificadorActividades));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.cmdColor = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblEncabezado = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
            this.NavegacionPrincipal = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.pageCalendario = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.PageIngresoCita = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.timeHoraFin = new DevExpress.XtraEditors.TimeEdit();
            this.timeHoraInicio = new DevExpress.XtraEditors.TimeEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.glColorEtiqueta = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bsColores = new System.Windows.Forms.BindingSource(this.components);
            this.dsVistas1 = new Core.DataSets.dsVistas();
            this.gvColor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_color = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colargb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colboton_color = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtLugar = new DevExpress.XtraEditors.TextEdit();
            this.memoObservaciones = new DevExpress.XtraEditors.MemoEdit();
            this.txtAsunto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSubtitulo = new DevExpress.XtraEditors.LabelControl();
            this.picBorrar = new DevExpress.XtraEditors.PictureEdit();
            this.picGuardar = new DevExpress.XtraEditors.PictureEdit();
            this.picIrAtras = new DevExpress.XtraEditors.PictureEdit();
            this.PageVistaCitas = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gcMaestrosDisponibles = new DevExpress.XtraGrid.GridControl();
            this.gvActivdades = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_cita_actividad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_inicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_fin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collugar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.memoLugar = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colid_color_etiqueta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colasunto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.memoAsunto = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.memoObservacion = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtBusqueda = new DevExpress.XtraEditors.TextEdit();
            this.cmdGuardarSolicitud = new DevExpress.XtraEditors.PictureEdit();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ltlTituloCitas = new DevExpress.XtraEditors.LabelControl();
            this.cmdAgregarCita = new DevExpress.XtraEditors.PictureEdit();
            this.cmdIrAtrasCitas = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdColor)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavegacionPrincipal)).BeginInit();
            this.NavegacionPrincipal.SuspendLayout();
            this.pageCalendario.SuspendLayout();
            this.PageIngresoCita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeHoraFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeHoraInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glColorEtiqueta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsColores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVistas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLugar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoObservaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAsunto.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBorrar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuardar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIrAtras.Properties)).BeginInit();
            this.PageVistaCitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMaestrosDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvActivdades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoLugar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoAsunto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoObservacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEliminar)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBusqueda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdGuardarSolicitud.Properties)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAgregarCita.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdIrAtrasCitas.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdColor
            // 
            this.cmdColor.AutoHeight = false;
            this.cmdColor.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.cmdColor.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.cmdColor.Name = "cmdColor";
            this.cmdColor.NullText = " ";
            this.cmdColor.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.lblEncabezado);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(5, 5);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1039, 43);
            this.pnlEncabezado.TabIndex = 17;
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
            this.lblEncabezado.Size = new System.Drawing.Size(1039, 43);
            this.lblEncabezado.TabIndex = 9;
            this.lblEncabezado.Text = "Planificador de Actividades";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 2);
            this.panel2.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 50);
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
            this.schedulerControl1.Size = new System.Drawing.Size(1039, 581);
            this.schedulerControl1.Start = new System.DateTime(2019, 9, 16, 0, 0, 0, 0);
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
            this.NavegacionPrincipal.Controls.Add(this.PageVistaCitas);
            this.NavegacionPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavegacionPrincipal.Location = new System.Drawing.Point(5, 79);
            this.NavegacionPrincipal.Name = "NavegacionPrincipal";
            this.NavegacionPrincipal.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pageCalendario,
            this.PageIngresoCita,
            this.PageVistaCitas});
            this.NavegacionPrincipal.SelectedPage = this.pageCalendario;
            this.NavegacionPrincipal.Size = new System.Drawing.Size(1039, 581);
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
            this.pageCalendario.Size = new System.Drawing.Size(1039, 581);
            // 
            // PageIngresoCita
            // 
            this.PageIngresoCita.Caption = "PageIngresoCita";
            this.PageIngresoCita.Controls.Add(this.timeHoraFin);
            this.PageIngresoCita.Controls.Add(this.timeHoraInicio);
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
            this.PageIngresoCita.Size = new System.Drawing.Size(1039, 581);
            // 
            // timeHoraFin
            // 
            this.timeHoraFin.EditValue = new System.DateTime(2019, 12, 17, 0, 0, 0, 0);
            this.timeHoraFin.EnterMoveNextControl = true;
            this.timeHoraFin.Location = new System.Drawing.Point(601, 212);
            this.timeHoraFin.Name = "timeHoraFin";
            this.timeHoraFin.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeHoraFin.Properties.Appearance.Options.UseFont = true;
            this.timeHoraFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeHoraFin.Properties.DisplayFormat.FormatString = "hh:mm tt";
            this.timeHoraFin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.timeHoraFin.Properties.EditFormat.FormatString = "Time";
            this.timeHoraFin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.timeHoraFin.Size = new System.Drawing.Size(162, 38);
            this.timeHoraFin.TabIndex = 35;
            // 
            // timeHoraInicio
            // 
            this.timeHoraInicio.EditValue = new System.DateTime(2019, 12, 17, 0, 0, 0, 0);
            this.timeHoraInicio.EnterMoveNextControl = true;
            this.timeHoraInicio.Location = new System.Drawing.Point(315, 212);
            this.timeHoraInicio.Name = "timeHoraInicio";
            this.timeHoraInicio.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeHoraInicio.Properties.Appearance.Options.UseFont = true;
            this.timeHoraInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeHoraInicio.Properties.DisplayFormat.FormatString = "hh:mm tt";
            this.timeHoraInicio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.timeHoraInicio.Properties.EditFormat.FormatString = "Time";
            this.timeHoraInicio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.timeHoraInicio.Size = new System.Drawing.Size(162, 38);
            this.timeHoraInicio.TabIndex = 34;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl6.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(498, 215);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(106, 30);
            this.labelControl6.TabIndex = 36;
            this.labelControl6.Text = "Hora Fin:";
            // 
            // glColorEtiqueta
            // 
            this.glColorEtiqueta.EditValue = "";
            this.glColorEtiqueta.EnterMoveNextControl = true;
            this.glColorEtiqueta.Location = new System.Drawing.Point(315, 264);
            this.glColorEtiqueta.Name = "glColorEtiqueta";
            this.glColorEtiqueta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glColorEtiqueta.Properties.Appearance.Options.UseFont = true;
            this.glColorEtiqueta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glColorEtiqueta.Properties.DataSource = this.bsColores;
            this.glColorEtiqueta.Properties.DisplayMember = "descripcion";
            this.glColorEtiqueta.Properties.PopupView = this.gvColor;
            this.glColorEtiqueta.Properties.ValueMember = "id_color";
            this.glColorEtiqueta.Size = new System.Drawing.Size(260, 38);
            this.glColorEtiqueta.TabIndex = 36;
            this.glColorEtiqueta.EditValueChanged += new System.EventHandler(this.GlColorEtiqueta_EditValueChanged);
            // 
            // bsColores
            // 
            this.bsColores.DataMember = "dtColores";
            this.bsColores.DataSource = this.dsVistas1;
            // 
            // dsVistas1
            // 
            this.dsVistas1.DataSetName = "dsVistas";
            this.dsVistas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvColor
            // 
            this.gvColor.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvColor.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvColor.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvColor.Appearance.Row.Options.UseFont = true;
            this.gvColor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_color,
            this.coldescripcion,
            this.colargb,
            this.colboton_color});
            this.gvColor.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvColor.Name = "gvColor";
            this.gvColor.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvColor.OptionsView.ShowColumnHeaders = false;
            this.gvColor.OptionsView.ShowGroupPanel = false;
            this.gvColor.OptionsView.ShowIndicator = false;
            this.gvColor.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.GvColor_RowCellStyle);
            // 
            // colid_color
            // 
            this.colid_color.Caption = "ID Color";
            this.colid_color.FieldName = "id_color";
            this.colid_color.Name = "colid_color";
            this.colid_color.OptionsColumn.AllowEdit = false;
            this.colid_color.OptionsColumn.AllowFocus = false;
            this.colid_color.OptionsColumn.ReadOnly = true;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripción";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.OptionsColumn.AllowFocus = false;
            this.coldescripcion.OptionsColumn.ReadOnly = true;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // colargb
            // 
            this.colargb.Caption = "ARGB";
            this.colargb.FieldName = "argb";
            this.colargb.Name = "colargb";
            this.colargb.OptionsColumn.AllowEdit = false;
            this.colargb.OptionsColumn.AllowFocus = false;
            this.colargb.OptionsColumn.ReadOnly = true;
            // 
            // colboton_color
            // 
            this.colboton_color.Caption = "Color";
            this.colboton_color.FieldName = "boton_color";
            this.colboton_color.Name = "colboton_color";
            this.colboton_color.Visible = true;
            this.colboton_color.VisibleIndex = 1;
            // 
            // txtLugar
            // 
            this.txtLugar.EnterMoveNextControl = true;
            this.txtLugar.Location = new System.Drawing.Point(315, 159);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugar.Properties.Appearance.Options.UseFont = true;
            this.txtLugar.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLugar.Size = new System.Drawing.Size(634, 38);
            this.txtLugar.TabIndex = 33;
            // 
            // memoObservaciones
            // 
            this.memoObservaciones.EnterMoveNextControl = true;
            this.memoObservaciones.Location = new System.Drawing.Point(315, 339);
            this.memoObservaciones.Name = "memoObservaciones";
            this.memoObservaciones.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoObservaciones.Properties.Appearance.Options.UseFont = true;
            this.memoObservaciones.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.memoObservaciones.Size = new System.Drawing.Size(634, 147);
            this.memoObservaciones.TabIndex = 37;
            // 
            // txtAsunto
            // 
            this.txtAsunto.EnterMoveNextControl = true;
            this.txtAsunto.Location = new System.Drawing.Point(315, 111);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsunto.Properties.Appearance.Options.UseFont = true;
            this.txtAsunto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAsunto.Size = new System.Drawing.Size(634, 38);
            this.txtAsunto.TabIndex = 31;
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
            this.picBorrar.ToolTip = "Descartar Cita";
            this.picBorrar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.picBorrar.ToolTipTitle = "Arca de los Tesoros";
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
            this.picGuardar.ToolTip = "Guardar Cita";
            this.picGuardar.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.picGuardar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.picGuardar.ToolTipTitle = "Arca de los Tesoros";
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
            // PageVistaCitas
            // 
            this.PageVistaCitas.Caption = "PageVistaCitas";
            this.PageVistaCitas.Controls.Add(this.gcMaestrosDisponibles);
            this.PageVistaCitas.Controls.Add(this.panel7);
            this.PageVistaCitas.Controls.Add(this.panel5);
            this.PageVistaCitas.Controls.Add(this.panel6);
            this.PageVistaCitas.Controls.Add(this.panel4);
            this.PageVistaCitas.Name = "PageVistaCitas";
            this.PageVistaCitas.Size = new System.Drawing.Size(1039, 581);
            // 
            // gcMaestrosDisponibles
            // 
            this.gcMaestrosDisponibles.DataMember = "dtCita_Actividad";
            this.gcMaestrosDisponibles.DataSource = this.dsVistas1;
            this.gcMaestrosDisponibles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMaestrosDisponibles.Location = new System.Drawing.Point(0, 119);
            this.gcMaestrosDisponibles.MainView = this.gvActivdades;
            this.gcMaestrosDisponibles.Name = "gcMaestrosDisponibles";
            this.gcMaestrosDisponibles.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.memoLugar,
            this.memoAsunto,
            this.memoObservacion,
            this.cmdEliminar});
            this.gcMaestrosDisponibles.Size = new System.Drawing.Size(1039, 462);
            this.gcMaestrosDisponibles.TabIndex = 23;
            this.gcMaestrosDisponibles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvActivdades});
            // 
            // gvActivdades
            // 
            this.gvActivdades.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvActivdades.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvActivdades.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvActivdades.Appearance.Row.Options.UseFont = true;
            this.gvActivdades.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_cita_actividad,
            this.colhora_inicio,
            this.colhora_fin,
            this.colfecha,
            this.collugar,
            this.colid_color_etiqueta,
            this.colasunto,
            this.colusuario,
            this.colobservaciones,
            this.gridColumn1});
            this.gvActivdades.GridControl = this.gcMaestrosDisponibles;
            this.gvActivdades.Name = "gvActivdades";
            this.gvActivdades.OptionsView.ShowGroupPanel = false;
            this.gvActivdades.OptionsView.ShowIndicator = false;
            // 
            // colid_cita_actividad
            // 
            this.colid_cita_actividad.Caption = "ID Cita";
            this.colid_cita_actividad.FieldName = "id_cita_actividad";
            this.colid_cita_actividad.MinWidth = 25;
            this.colid_cita_actividad.Name = "colid_cita_actividad";
            this.colid_cita_actividad.OptionsColumn.AllowEdit = false;
            this.colid_cita_actividad.OptionsColumn.AllowFocus = false;
            this.colid_cita_actividad.OptionsColumn.ReadOnly = true;
            this.colid_cita_actividad.Width = 94;
            // 
            // colhora_inicio
            // 
            this.colhora_inicio.AppearanceCell.Options.UseTextOptions = true;
            this.colhora_inicio.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhora_inicio.AppearanceHeader.Options.UseTextOptions = true;
            this.colhora_inicio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhora_inicio.Caption = "Hora Inicio";
            this.colhora_inicio.DisplayFormat.FormatString = "hh:mm";
            this.colhora_inicio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colhora_inicio.FieldName = "hora_inicio";
            this.colhora_inicio.MaxWidth = 110;
            this.colhora_inicio.MinWidth = 110;
            this.colhora_inicio.Name = "colhora_inicio";
            this.colhora_inicio.OptionsColumn.AllowEdit = false;
            this.colhora_inicio.OptionsColumn.AllowFocus = false;
            this.colhora_inicio.OptionsColumn.ReadOnly = true;
            this.colhora_inicio.Visible = true;
            this.colhora_inicio.VisibleIndex = 1;
            this.colhora_inicio.Width = 110;
            // 
            // colhora_fin
            // 
            this.colhora_fin.AppearanceCell.Options.UseTextOptions = true;
            this.colhora_fin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhora_fin.AppearanceHeader.Options.UseTextOptions = true;
            this.colhora_fin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhora_fin.Caption = "Hora Fín";
            this.colhora_fin.DisplayFormat.FormatString = "hh:mm";
            this.colhora_fin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colhora_fin.FieldName = "hora_fin";
            this.colhora_fin.MaxWidth = 98;
            this.colhora_fin.MinWidth = 98;
            this.colhora_fin.Name = "colhora_fin";
            this.colhora_fin.OptionsColumn.AllowEdit = false;
            this.colhora_fin.OptionsColumn.AllowFocus = false;
            this.colhora_fin.OptionsColumn.ReadOnly = true;
            this.colhora_fin.Visible = true;
            this.colhora_fin.VisibleIndex = 2;
            this.colhora_fin.Width = 98;
            // 
            // colfecha
            // 
            this.colfecha.AppearanceCell.Options.UseTextOptions = true;
            this.colfecha.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colfecha.AppearanceHeader.Options.UseTextOptions = true;
            this.colfecha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.MaxWidth = 111;
            this.colfecha.MinWidth = 111;
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.OptionsColumn.AllowFocus = false;
            this.colfecha.OptionsColumn.ReadOnly = true;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 0;
            this.colfecha.Width = 111;
            // 
            // collugar
            // 
            this.collugar.Caption = "Lugar";
            this.collugar.ColumnEdit = this.memoLugar;
            this.collugar.FieldName = "lugar";
            this.collugar.MinWidth = 25;
            this.collugar.Name = "collugar";
            this.collugar.OptionsColumn.AllowEdit = false;
            this.collugar.OptionsColumn.AllowFocus = false;
            this.collugar.OptionsColumn.ReadOnly = true;
            this.collugar.Visible = true;
            this.collugar.VisibleIndex = 3;
            this.collugar.Width = 213;
            // 
            // memoLugar
            // 
            this.memoLugar.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoLugar.Appearance.Options.UseFont = true;
            this.memoLugar.Name = "memoLugar";
            // 
            // colid_color_etiqueta
            // 
            this.colid_color_etiqueta.Caption = "Color";
            this.colid_color_etiqueta.FieldName = "id_color_etiqueta";
            this.colid_color_etiqueta.MinWidth = 25;
            this.colid_color_etiqueta.Name = "colid_color_etiqueta";
            this.colid_color_etiqueta.OptionsColumn.AllowEdit = false;
            this.colid_color_etiqueta.OptionsColumn.AllowFocus = false;
            this.colid_color_etiqueta.OptionsColumn.ReadOnly = true;
            this.colid_color_etiqueta.Width = 94;
            // 
            // colasunto
            // 
            this.colasunto.Caption = "Asunto";
            this.colasunto.ColumnEdit = this.memoAsunto;
            this.colasunto.FieldName = "asunto";
            this.colasunto.MinWidth = 25;
            this.colasunto.Name = "colasunto";
            this.colasunto.OptionsColumn.AllowEdit = false;
            this.colasunto.OptionsColumn.AllowFocus = false;
            this.colasunto.OptionsColumn.ReadOnly = true;
            this.colasunto.Visible = true;
            this.colasunto.VisibleIndex = 4;
            this.colasunto.Width = 213;
            // 
            // memoAsunto
            // 
            this.memoAsunto.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoAsunto.Appearance.Options.UseFont = true;
            this.memoAsunto.Name = "memoAsunto";
            // 
            // colusuario
            // 
            this.colusuario.Caption = "Usuario";
            this.colusuario.FieldName = "usuario";
            this.colusuario.MinWidth = 25;
            this.colusuario.Name = "colusuario";
            this.colusuario.OptionsColumn.AllowEdit = false;
            this.colusuario.OptionsColumn.AllowFocus = false;
            this.colusuario.OptionsColumn.ReadOnly = true;
            this.colusuario.Width = 94;
            // 
            // colobservaciones
            // 
            this.colobservaciones.Caption = "Observaciones";
            this.colobservaciones.ColumnEdit = this.memoObservacion;
            this.colobservaciones.FieldName = "observaciones";
            this.colobservaciones.MinWidth = 25;
            this.colobservaciones.Name = "colobservaciones";
            this.colobservaciones.OptionsColumn.AllowEdit = false;
            this.colobservaciones.OptionsColumn.AllowFocus = false;
            this.colobservaciones.OptionsColumn.ReadOnly = true;
            this.colobservaciones.Visible = true;
            this.colobservaciones.VisibleIndex = 5;
            this.colobservaciones.Width = 203;
            // 
            // memoObservacion
            // 
            this.memoObservacion.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoObservacion.Appearance.Options.UseFont = true;
            this.memoObservacion.Name = "memoObservacion";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Eliminar";
            this.gridColumn1.ColumnEdit = this.cmdEliminar;
            this.gridColumn1.MaxWidth = 90;
            this.gridColumn1.MinWidth = 90;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            this.gridColumn1.Width = 90;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdEliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdEliminar.Click += new System.EventHandler(this.CmdEliminar_Click);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 109);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1039, 10);
            this.panel7.TabIndex = 27;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtBusqueda);
            this.panel5.Controls.Add(this.cmdGuardarSolicitud);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 55);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(1039, 54);
            this.panel5.TabIndex = 25;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtBusqueda.Location = new System.Drawing.Point(68, 5);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Properties.Appearance.Options.UseFont = true;
            this.txtBusqueda.Properties.AutoHeight = false;
            this.txtBusqueda.Size = new System.Drawing.Size(643, 44);
            this.txtBusqueda.TabIndex = 31;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // cmdGuardarSolicitud
            // 
            this.cmdGuardarSolicitud.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdGuardarSolicitud.EditValue = ((object)(resources.GetObject("cmdGuardarSolicitud.EditValue")));
            this.cmdGuardarSolicitud.Location = new System.Drawing.Point(5, 5);
            this.cmdGuardarSolicitud.Name = "cmdGuardarSolicitud";
            this.cmdGuardarSolicitud.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdGuardarSolicitud.Properties.NullText = "   ";
            this.cmdGuardarSolicitud.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdGuardarSolicitud.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdGuardarSolicitud.Size = new System.Drawing.Size(63, 44);
            this.cmdGuardarSolicitud.TabIndex = 30;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 45);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1039, 10);
            this.panel6.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ltlTituloCitas);
            this.panel4.Controls.Add(this.cmdAgregarCita);
            this.panel4.Controls.Add(this.cmdIrAtrasCitas);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1039, 45);
            this.panel4.TabIndex = 24;
            // 
            // ltlTituloCitas
            // 
            this.ltlTituloCitas.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltlTituloCitas.Appearance.Options.UseFont = true;
            this.ltlTituloCitas.Appearance.Options.UseTextOptions = true;
            this.ltlTituloCitas.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ltlTituloCitas.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ltlTituloCitas.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.ltlTituloCitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltlTituloCitas.Location = new System.Drawing.Point(121, 0);
            this.ltlTituloCitas.Name = "ltlTituloCitas";
            this.ltlTituloCitas.Size = new System.Drawing.Size(918, 45);
            this.ltlTituloCitas.TabIndex = 34;
            this.ltlTituloCitas.Text = "Citas programadas para el día";
            // 
            // cmdAgregarCita
            // 
            this.cmdAgregarCita.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdAgregarCita.EditValue = global::Core.Properties.Resources.icon_mas_64;
            this.cmdAgregarCita.Location = new System.Drawing.Point(58, 0);
            this.cmdAgregarCita.Name = "cmdAgregarCita";
            this.cmdAgregarCita.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdAgregarCita.Properties.NullText = "   ";
            this.cmdAgregarCita.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdAgregarCita.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdAgregarCita.Size = new System.Drawing.Size(63, 45);
            this.cmdAgregarCita.TabIndex = 32;
            this.cmdAgregarCita.ToolTip = "Agregar Cita";
            this.cmdAgregarCita.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.cmdAgregarCita.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cmdAgregarCita.ToolTipTitle = "Arca de los Tesoros";
            this.cmdAgregarCita.Click += new System.EventHandler(this.CmdAgregarCita_Click);
            // 
            // cmdIrAtrasCitas
            // 
            this.cmdIrAtrasCitas.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdIrAtrasCitas.EditValue = global::Core.Properties.Resources.icon_atras_64;
            this.cmdIrAtrasCitas.Location = new System.Drawing.Point(0, 0);
            this.cmdIrAtrasCitas.Name = "cmdIrAtrasCitas";
            this.cmdIrAtrasCitas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdIrAtrasCitas.Properties.NullText = "   ";
            this.cmdIrAtrasCitas.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdIrAtrasCitas.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdIrAtrasCitas.Size = new System.Drawing.Size(58, 45);
            this.cmdIrAtrasCitas.TabIndex = 31;
            this.cmdIrAtrasCitas.Click += new System.EventHandler(this.CmdIrAtrasCitas_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.cmdColor)).EndInit();
            this.pnlEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavegacionPrincipal)).EndInit();
            this.NavegacionPrincipal.ResumeLayout(false);
            this.pageCalendario.ResumeLayout(false);
            this.PageIngresoCita.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timeHoraFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeHoraInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glColorEtiqueta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsColores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVistas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLugar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoObservaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAsunto.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBorrar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuardar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIrAtras.Properties)).EndInit();
            this.PageVistaCitas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMaestrosDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvActivdades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoLugar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoAsunto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoObservacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEliminar)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBusqueda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdGuardarSolicitud.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdAgregarCita.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdIrAtrasCitas.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private DevExpress.XtraEditors.LabelControl lblEncabezado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
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
        private DevExpress.XtraGrid.Views.Grid.GridView gvColor;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lblSubtitulo;
        private DataSets.dsVistas dsVistas1;
        private System.Windows.Forms.BindingSource bsColores;
        private DevExpress.XtraGrid.Columns.GridColumn colid_color;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colargb;
        private DevExpress.XtraGrid.Columns.GridColumn colboton_color;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdColor;
        private DevExpress.XtraEditors.TimeEdit timeHoraFin;
        private DevExpress.XtraEditors.TimeEdit timeHoraInicio;
        private DevExpress.XtraBars.Navigation.NavigationPage PageVistaCitas;
        private DevExpress.XtraGrid.GridControl gcMaestrosDisponibles;
        private DevExpress.XtraGrid.Views.Grid.GridView gvActivdades;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.LabelControl ltlTituloCitas;
        private DevExpress.XtraEditors.PictureEdit cmdAgregarCita;
        private DevExpress.XtraEditors.PictureEdit cmdIrAtrasCitas;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.TextEdit txtBusqueda;
        private DevExpress.XtraEditors.PictureEdit cmdGuardarSolicitud;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraGrid.Columns.GridColumn colid_cita_actividad;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_inicio;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_fin;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn collugar;
        private DevExpress.XtraGrid.Columns.GridColumn colid_color_etiqueta;
        private DevExpress.XtraGrid.Columns.GridColumn colasunto;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
        private DevExpress.XtraGrid.Columns.GridColumn colobservaciones;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit memoLugar;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit memoAsunto;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit memoObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdEliminar;
    }
}
