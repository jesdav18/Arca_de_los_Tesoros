namespace Coordinadores_de_Edad.Controles
{
    partial class ctlIngresoSolicitudesCordinadorEdad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlIngresoSolicitudesCordinadorEdad));
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.cmdAgregarSolicitud = new DevExpress.XtraEditors.PictureEdit();
            this.lblEncabezado = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateFechaSolicitud = new DevExpress.XtraEditors.DateEdit();
            this.txtObservacionesSolicitud = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmdGuardarSolicitud = new DevExpress.XtraEditors.PictureEdit();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Coordinadores_de_Edad.Pantallas.frmEspera), true, true, typeof(System.Windows.Forms.UserControl));
            this.dsConfiguracion1 = new Core.DataSets.dsConfiguracion();
            this.glTipoSolicitud = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bsTipoSolicitud = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tipo_solicitud = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.popupIngresarSolicitudes = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl1 = new DevExpress.Utils.FlyoutPanelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picCerrarPopup = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsVistas1 = new Core.DataSets.dsVistas();
            this.gvSolicitudes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_area_atencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_ejecucion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_solicitud = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_solicitud = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservaciones_rechazo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAgregarSolicitud.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaSolicitud.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaSolicitud.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacionesSolicitud.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdGuardarSolicitud.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConfiguracion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoSolicitud.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoSolicitud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.pnlCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupIngresarSolicitudes)).BeginInit();
            this.popupIngresarSolicitudes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).BeginInit();
            this.flyoutPanelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrarPopup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVistas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.cmdAgregarSolicitud);
            this.pnlEncabezado.Controls.Add(this.popupIngresarSolicitudes);
            this.pnlEncabezado.Controls.Add(this.lblEncabezado);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(5, 5);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1399, 53);
            this.pnlEncabezado.TabIndex = 11;
            // 
            // cmdAgregarSolicitud
            // 
            this.cmdAgregarSolicitud.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdAgregarSolicitud.EditValue = global::Coordinadores_de_Edad.Resources.icon_mas_64;
            this.cmdAgregarSolicitud.Location = new System.Drawing.Point(1348, 0);
            this.cmdAgregarSolicitud.Name = "cmdAgregarSolicitud";
            this.cmdAgregarSolicitud.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdAgregarSolicitud.Properties.NullText = "   ";
            this.cmdAgregarSolicitud.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdAgregarSolicitud.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.cmdAgregarSolicitud.Size = new System.Drawing.Size(51, 53);
            this.cmdAgregarSolicitud.TabIndex = 30;
            this.cmdAgregarSolicitud.Click += new System.EventHandler(this.CmdAgregarSolicitud_Click);
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
            this.lblEncabezado.Size = new System.Drawing.Size(1399, 53);
            this.lblEncabezado.TabIndex = 9;
            this.lblEncabezado.Text = "Mis Solicitudes";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1399, 2);
            this.panel2.TabIndex = 12;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(14, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(218, 45);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Tipo de Solicitud";
            // 
            // dateFechaSolicitud
            // 
            this.dateFechaSolicitud.EditValue = null;
            this.dateFechaSolicitud.Location = new System.Drawing.Point(14, 162);
            this.dateFechaSolicitud.Name = "dateFechaSolicitud";
            this.dateFechaSolicitud.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaSolicitud.Properties.Appearance.Options.UseFont = true;
            this.dateFechaSolicitud.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFechaSolicitud.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFechaSolicitud.Size = new System.Drawing.Size(320, 36);
            this.dateFechaSolicitud.TabIndex = 22;
            // 
            // txtObservacionesSolicitud
            // 
            this.txtObservacionesSolicitud.Location = new System.Drawing.Point(14, 262);
            this.txtObservacionesSolicitud.MaximumSize = new System.Drawing.Size(646, 181);
            this.txtObservacionesSolicitud.Name = "txtObservacionesSolicitud";
            this.txtObservacionesSolicitud.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacionesSolicitud.Properties.Appearance.Options.UseFont = true;
            this.txtObservacionesSolicitud.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacionesSolicitud.Size = new System.Drawing.Size(595, 181);
            this.txtObservacionesSolicitud.TabIndex = 28;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(14, 111);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(246, 45);
            this.labelControl1.TabIndex = 30;
            this.labelControl1.Text = "Solicitar para el día";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(14, 211);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(197, 45);
            this.labelControl3.TabIndex = 31;
            this.labelControl3.Text = "Observaciones";
            // 
            // cmdGuardarSolicitud
            // 
            this.cmdGuardarSolicitud.EditValue = global::Coordinadores_de_Edad.Resources.icon_guardar_negro_64;
            this.cmdGuardarSolicitud.Location = new System.Drawing.Point(549, 461);
            this.cmdGuardarSolicitud.Name = "cmdGuardarSolicitud";
            this.cmdGuardarSolicitud.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdGuardarSolicitud.Properties.NullText = "   ";
            this.cmdGuardarSolicitud.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdGuardarSolicitud.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.cmdGuardarSolicitud.Size = new System.Drawing.Size(57, 56);
            this.cmdGuardarSolicitud.TabIndex = 29;
            this.cmdGuardarSolicitud.Click += new System.EventHandler(this.CmdGuardarSolicitud_Click);
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // dsConfiguracion1
            // 
            this.dsConfiguracion1.DataSetName = "dsConfiguracion";
            this.dsConfiguracion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // glTipoSolicitud
            // 
            this.glTipoSolicitud.EditValue = "";
            this.glTipoSolicitud.Location = new System.Drawing.Point(14, 66);
            this.glTipoSolicitud.Name = "glTipoSolicitud";
            this.glTipoSolicitud.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glTipoSolicitud.Properties.Appearance.Options.UseFont = true;
            this.glTipoSolicitud.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glTipoSolicitud.Properties.DataSource = this.bsTipoSolicitud;
            this.glTipoSolicitud.Properties.DisplayMember = "descripcion";
            this.glTipoSolicitud.Properties.PopupView = this.gridLookUpEdit1View;
            this.glTipoSolicitud.Properties.ValueMember = "id_tipo_solicitud";
            this.glTipoSolicitud.Size = new System.Drawing.Size(595, 36);
            this.glTipoSolicitud.TabIndex = 32;
            // 
            // bsTipoSolicitud
            // 
            this.bsTipoSolicitud.DataMember = "dtTiposSolicitud";
            this.bsTipoSolicitud.DataSource = this.dsConfiguracion1;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit1View.Appearance.Row.Options.UseFont = true;
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion,
            this.colid_tipo_solicitud});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowColumnHeaders = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.gridLookUpEdit1View.OptionsView.ShowIndicator = false;
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.OptionsColumn.AllowFocus = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // colid_tipo_solicitud
            // 
            this.colid_tipo_solicitud.FieldName = "id_tipo_solicitud";
            this.colid_tipo_solicitud.Name = "colid_tipo_solicitud";
            // 
            // pnlCentral
            // 
            this.pnlCentral.Controls.Add(this.labelControl2);
            this.pnlCentral.Controls.Add(this.glTipoSolicitud);
            this.pnlCentral.Controls.Add(this.cmdGuardarSolicitud);
            this.pnlCentral.Controls.Add(this.labelControl3);
            this.pnlCentral.Controls.Add(this.txtObservacionesSolicitud);
            this.pnlCentral.Controls.Add(this.labelControl1);
            this.pnlCentral.Controls.Add(this.dateFechaSolicitud);
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Location = new System.Drawing.Point(3, 52);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(621, 540);
            this.pnlCentral.TabIndex = 34;
            // 
            // popupIngresarSolicitudes
            // 
            this.popupIngresarSolicitudes.Appearance.BackColor = System.Drawing.Color.White;
            this.popupIngresarSolicitudes.Appearance.Options.UseBackColor = true;
            this.popupIngresarSolicitudes.Controls.Add(this.flyoutPanelControl1);
            this.popupIngresarSolicitudes.Location = new System.Drawing.Point(345, 17);
            this.popupIngresarSolicitudes.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.popupIngresarSolicitudes.LookAndFeel.UseDefaultLookAndFeel = false;
            this.popupIngresarSolicitudes.Name = "popupIngresarSolicitudes";
            this.popupIngresarSolicitudes.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Center;
            this.popupIngresarSolicitudes.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade;
            this.popupIngresarSolicitudes.OptionsBeakPanel.BackColor = System.Drawing.Color.White;
            this.popupIngresarSolicitudes.OwnerControl = this;
            this.popupIngresarSolicitudes.Size = new System.Drawing.Size(627, 595);
            this.popupIngresarSolicitudes.TabIndex = 35;
            this.popupIngresarSolicitudes.Hidden += new DevExpress.Utils.FlyoutPanelEventHandler(this.PopupIngresarSolicitudes_Hidden);
            // 
            // flyoutPanelControl1
            // 
            this.flyoutPanelControl1.Controls.Add(this.pnlCentral);
            this.flyoutPanelControl1.Controls.Add(this.panel3);
            this.flyoutPanelControl1.Controls.Add(this.panel1);
            this.flyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl1.FlyoutPanel = this.popupIngresarSolicitudes;
            this.flyoutPanelControl1.Location = new System.Drawing.Point(0, 0);
            this.flyoutPanelControl1.Name = "flyoutPanelControl1";
            this.flyoutPanelControl1.Size = new System.Drawing.Size(627, 595);
            this.flyoutPanelControl1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(621, 2);
            this.panel3.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picCerrarPopup);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 47);
            this.panel1.TabIndex = 35;
            // 
            // picCerrarPopup
            // 
            this.picCerrarPopup.Dock = System.Windows.Forms.DockStyle.Right;
            this.picCerrarPopup.EditValue = ((object)(resources.GetObject("picCerrarPopup.EditValue")));
            this.picCerrarPopup.Location = new System.Drawing.Point(576, 0);
            this.picCerrarPopup.Name = "picCerrarPopup";
            this.picCerrarPopup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picCerrarPopup.Properties.NullText = "   ";
            this.picCerrarPopup.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picCerrarPopup.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picCerrarPopup.Size = new System.Drawing.Size(45, 47);
            this.picCerrarPopup.TabIndex = 30;
            this.picCerrarPopup.Click += new System.EventHandler(this.PicCerrarPopup_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl4.Location = new System.Drawing.Point(0, 0);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(621, 47);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Ingreso de Solicitudes";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "dtMisSolicitudes";
            this.gridControl1.DataSource = this.dsVistas1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(5, 60);
            this.gridControl1.MainView = this.gvSolicitudes;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1,
            this.repositoryItemMemoEdit2});
            this.gridControl1.Size = new System.Drawing.Size(1399, 750);
            this.gridControl1.TabIndex = 36;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSolicitudes});
            // 
            // dsVistas1
            // 
            this.dsVistas1.DataSetName = "dsVistas";
            this.dsVistas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvSolicitudes
            // 
            this.gvSolicitudes.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvSolicitudes.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvSolicitudes.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvSolicitudes.Appearance.Row.Options.UseFont = true;
            this.gvSolicitudes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_area_atencion,
            this.colfecha_ejecucion,
            this.coltipo_solicitud,
            this.colobservaciones,
            this.colfecha_solicitud,
            this.colestado,
            this.colobservaciones_rechazo});
            this.gvSolicitudes.GridControl = this.gridControl1;
            this.gvSolicitudes.Name = "gvSolicitudes";
            this.gvSolicitudes.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvSolicitudes.OptionsView.ShowGroupPanel = false;
            this.gvSolicitudes.OptionsView.ShowIndicator = false;
            // 
            // colid_area_atencion
            // 
            this.colid_area_atencion.FieldName = "id_area_atencion";
            this.colid_area_atencion.MinWidth = 25;
            this.colid_area_atencion.Name = "colid_area_atencion";
            this.colid_area_atencion.OptionsColumn.AllowEdit = false;
            this.colid_area_atencion.OptionsColumn.AllowFocus = false;
            this.colid_area_atencion.OptionsColumn.ReadOnly = true;
            this.colid_area_atencion.Width = 94;
            // 
            // colfecha_ejecucion
            // 
            this.colfecha_ejecucion.Caption = "Solicitada para la fecha";
            this.colfecha_ejecucion.DisplayFormat.FormatString = "d";
            this.colfecha_ejecucion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_ejecucion.FieldName = "fecha_ejecucion";
            this.colfecha_ejecucion.MinWidth = 25;
            this.colfecha_ejecucion.Name = "colfecha_ejecucion";
            this.colfecha_ejecucion.OptionsColumn.AllowEdit = false;
            this.colfecha_ejecucion.OptionsColumn.AllowFocus = false;
            this.colfecha_ejecucion.OptionsColumn.ReadOnly = true;
            this.colfecha_ejecucion.Visible = true;
            this.colfecha_ejecucion.VisibleIndex = 1;
            this.colfecha_ejecucion.Width = 94;
            // 
            // coltipo_solicitud
            // 
            this.coltipo_solicitud.Caption = "Tipo de Solicitud";
            this.coltipo_solicitud.FieldName = "tipo_solicitud";
            this.coltipo_solicitud.MinWidth = 25;
            this.coltipo_solicitud.Name = "coltipo_solicitud";
            this.coltipo_solicitud.OptionsColumn.AllowEdit = false;
            this.coltipo_solicitud.OptionsColumn.AllowFocus = false;
            this.coltipo_solicitud.OptionsColumn.ReadOnly = true;
            this.coltipo_solicitud.Visible = true;
            this.coltipo_solicitud.VisibleIndex = 2;
            this.coltipo_solicitud.Width = 94;
            // 
            // colobservaciones
            // 
            this.colobservaciones.Caption = "Observaciones";
            this.colobservaciones.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colobservaciones.FieldName = "observaciones";
            this.colobservaciones.MinWidth = 25;
            this.colobservaciones.Name = "colobservaciones";
            this.colobservaciones.OptionsColumn.AllowEdit = false;
            this.colobservaciones.OptionsColumn.AllowFocus = false;
            this.colobservaciones.OptionsColumn.ReadOnly = true;
            this.colobservaciones.Visible = true;
            this.colobservaciones.VisibleIndex = 3;
            this.colobservaciones.Width = 94;
            // 
            // colfecha_solicitud
            // 
            this.colfecha_solicitud.Caption = "Fecha de Solicitud";
            this.colfecha_solicitud.DisplayFormat.FormatString = "d";
            this.colfecha_solicitud.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_solicitud.FieldName = "fecha_solicitud";
            this.colfecha_solicitud.MinWidth = 25;
            this.colfecha_solicitud.Name = "colfecha_solicitud";
            this.colfecha_solicitud.OptionsColumn.AllowEdit = false;
            this.colfecha_solicitud.OptionsColumn.AllowFocus = false;
            this.colfecha_solicitud.OptionsColumn.ReadOnly = true;
            this.colfecha_solicitud.Visible = true;
            this.colfecha_solicitud.VisibleIndex = 0;
            this.colfecha_solicitud.Width = 94;
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado";
            this.colestado.FieldName = "estado";
            this.colestado.MinWidth = 25;
            this.colestado.Name = "colestado";
            this.colestado.OptionsColumn.AllowEdit = false;
            this.colestado.OptionsColumn.AllowFocus = false;
            this.colestado.OptionsColumn.ReadOnly = true;
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 4;
            this.colestado.Width = 94;
            // 
            // colobservaciones_rechazo
            // 
            this.colobservaciones_rechazo.Caption = "Observaciones por rechazo";
            this.colobservaciones_rechazo.ColumnEdit = this.repositoryItemMemoEdit2;
            this.colobservaciones_rechazo.FieldName = "observaciones_rechazo";
            this.colobservaciones_rechazo.MinWidth = 25;
            this.colobservaciones_rechazo.Name = "colobservaciones_rechazo";
            this.colobservaciones_rechazo.OptionsColumn.AllowEdit = false;
            this.colobservaciones_rechazo.OptionsColumn.AllowFocus = false;
            this.colobservaciones_rechazo.OptionsColumn.ReadOnly = true;
            this.colobservaciones_rechazo.Visible = true;
            this.colobservaciones_rechazo.VisibleIndex = 5;
            this.colobservaciones_rechazo.Width = 94;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repositoryItemMemoEdit1.Appearance.Options.UseFont = true;
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // repositoryItemMemoEdit2
            // 
            this.repositoryItemMemoEdit2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repositoryItemMemoEdit2.Appearance.Options.UseFont = true;
            this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
            // 
            // ctlIngresoSolicitudesCordinadorEdad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlEncabezado);
            this.MinimumSize = new System.Drawing.Size(1030, 815);
            this.Name = "ctlIngresoSolicitudesCordinadorEdad";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1409, 815);
            this.pnlEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdAgregarSolicitud.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaSolicitud.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaSolicitud.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacionesSolicitud.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdGuardarSolicitud.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConfiguracion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoSolicitud.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoSolicitud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.pnlCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupIngresarSolicitudes)).EndInit();
            this.popupIngresarSolicitudes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).EndInit();
            this.flyoutPanelControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCerrarPopup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVistas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private DevExpress.XtraEditors.LabelControl lblEncabezado;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dateFechaSolicitud;
        private DevExpress.XtraEditors.MemoEdit txtObservacionesSolicitud;
        private DevExpress.XtraEditors.PictureEdit cmdGuardarSolicitud;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private Core.DataSets.dsConfiguracion dsConfiguracion1;
        private DevExpress.XtraEditors.GridLookUpEdit glTipoSolicitud;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.BindingSource bsTipoSolicitud;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tipo_solicitud;
        private System.Windows.Forms.Panel pnlCentral;
        private DevExpress.Utils.FlyoutPanel popupIngresarSolicitudes;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PictureEdit picCerrarPopup;
        private DevExpress.XtraEditors.PictureEdit cmdAgregarSolicitud;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSolicitudes;
        private Core.DataSets.dsVistas dsVistas1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_area_atencion;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_solicitud;
        private DevExpress.XtraGrid.Columns.GridColumn colobservaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_solicitud;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_ejecucion;
        private DevExpress.XtraGrid.Columns.GridColumn colobservaciones_rechazo;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
    }
}
