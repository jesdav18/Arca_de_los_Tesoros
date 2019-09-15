namespace Coordinadores_de_Dia.Controles
{
    partial class ctlVistaSolicitudes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlVistaSolicitudes));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblEncabezado = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtBusqueda = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.gcVistaSolicitud = new DevExpress.XtraGrid.GridControl();
            this.dsCoordinador_Dia1 = new Coordinadores_de_Dia.DataSet.dsCoordinador_Dia();
            this.gvVistaSolicitud = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnombre_solicitante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_area_atencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_solicitud = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmotivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion_area_atencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_colaborador_solicita = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tipo_solicitud = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAceptar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdAceptar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colRechazar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdRechazar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.popupIngresoMotivoRechazo = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl1 = new DevExpress.Utils.FlyoutPanelControl();
            this.cmdGuardarRechazo = new DevExpress.XtraEditors.PictureEdit();
            this.memoMotivosRechazo = new DevExpress.XtraEditors.MemoEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlEncabezadoRechazo = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdCerrarPoupRechazo = new DevExpress.XtraEditors.PictureEdit();
            this.pnlEncabezado.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBusqueda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVistaSolicitud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCoordinador_Dia1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVistaSolicitud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdRechazar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupIngresoMotivoRechazo)).BeginInit();
            this.popupIngresoMotivoRechazo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).BeginInit();
            this.flyoutPanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdGuardarRechazo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoMotivosRechazo.Properties)).BeginInit();
            this.pnlEncabezadoRechazo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCerrarPoupRechazo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.lblEncabezado);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(5, 5);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1041, 75);
            this.pnlEncabezado.TabIndex = 17;
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
            this.lblEncabezado.Size = new System.Drawing.Size(1041, 75);
            this.lblEncabezado.TabIndex = 9;
            this.lblEncabezado.Text = "Solicitudes";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1041, 10);
            this.panel2.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtBusqueda);
            this.panel5.Controls.Add(this.pictureEdit1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(5, 90);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(1041, 54);
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
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(5, 5);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.NullText = "   ";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(63, 44);
            this.pictureEdit1.TabIndex = 30;
            // 
            // gcVistaSolicitud
            // 
            this.gcVistaSolicitud.DataMember = "dtSolicitudes";
            this.gcVistaSolicitud.DataSource = this.dsCoordinador_Dia1;
            this.gcVistaSolicitud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcVistaSolicitud.Location = new System.Drawing.Point(5, 144);
            this.gcVistaSolicitud.MainView = this.gvVistaSolicitud;
            this.gcVistaSolicitud.Name = "gcVistaSolicitud";
            this.gcVistaSolicitud.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdAceptar,
            this.cmdRechazar});
            this.gcVistaSolicitud.Size = new System.Drawing.Size(1041, 478);
            this.gcVistaSolicitud.TabIndex = 26;
            this.gcVistaSolicitud.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVistaSolicitud});
            // 
            // dsCoordinador_Dia1
            // 
            this.dsCoordinador_Dia1.DataSetName = "dsCoordinador_Dia";
            this.dsCoordinador_Dia1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvVistaSolicitud
            // 
            this.gvVistaSolicitud.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvVistaSolicitud.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvVistaSolicitud.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvVistaSolicitud.Appearance.Row.Options.UseFont = true;
            this.gvVistaSolicitud.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnombre_solicitante,
            this.colid_area_atencion,
            this.coltipo_solicitud,
            this.colmotivo,
            this.coldescripcion_area_atencion,
            this.colid_colaborador_solicita,
            this.colid_tipo_solicitud,
            this.colAceptar,
            this.colRechazar});
            this.gvVistaSolicitud.GridControl = this.gcVistaSolicitud;
            this.gvVistaSolicitud.Name = "gvVistaSolicitud";
            this.gvVistaSolicitud.OptionsView.ShowGroupPanel = false;
            this.gvVistaSolicitud.OptionsView.ShowIndicator = false;
            // 
            // colnombre_solicitante
            // 
            this.colnombre_solicitante.Caption = "Solicitante";
            this.colnombre_solicitante.FieldName = "nombre_solicitante";
            this.colnombre_solicitante.MinWidth = 25;
            this.colnombre_solicitante.Name = "colnombre_solicitante";
            this.colnombre_solicitante.Visible = true;
            this.colnombre_solicitante.VisibleIndex = 0;
            this.colnombre_solicitante.Width = 94;
            // 
            // colid_area_atencion
            // 
            this.colid_area_atencion.FieldName = "id_area_atencion";
            this.colid_area_atencion.MinWidth = 25;
            this.colid_area_atencion.Name = "colid_area_atencion";
            this.colid_area_atencion.Width = 94;
            // 
            // coltipo_solicitud
            // 
            this.coltipo_solicitud.Caption = "Tipo de Solicitud";
            this.coltipo_solicitud.FieldName = "tipo_solicitud";
            this.coltipo_solicitud.MinWidth = 25;
            this.coltipo_solicitud.Name = "coltipo_solicitud";
            this.coltipo_solicitud.Visible = true;
            this.coltipo_solicitud.VisibleIndex = 2;
            this.coltipo_solicitud.Width = 94;
            // 
            // colmotivo
            // 
            this.colmotivo.Caption = "Observaciones";
            this.colmotivo.FieldName = "motivo";
            this.colmotivo.MinWidth = 25;
            this.colmotivo.Name = "colmotivo";
            this.colmotivo.Visible = true;
            this.colmotivo.VisibleIndex = 3;
            this.colmotivo.Width = 94;
            // 
            // coldescripcion_area_atencion
            // 
            this.coldescripcion_area_atencion.Caption = "Equipo";
            this.coldescripcion_area_atencion.FieldName = "descripcion_area_atencion";
            this.coldescripcion_area_atencion.MinWidth = 25;
            this.coldescripcion_area_atencion.Name = "coldescripcion_area_atencion";
            this.coldescripcion_area_atencion.Visible = true;
            this.coldescripcion_area_atencion.VisibleIndex = 1;
            this.coldescripcion_area_atencion.Width = 94;
            // 
            // colid_colaborador_solicita
            // 
            this.colid_colaborador_solicita.FieldName = "id_colaborador_solicita";
            this.colid_colaborador_solicita.MinWidth = 25;
            this.colid_colaborador_solicita.Name = "colid_colaborador_solicita";
            this.colid_colaborador_solicita.Width = 94;
            // 
            // colid_tipo_solicitud
            // 
            this.colid_tipo_solicitud.FieldName = "id_tipo_solicitud";
            this.colid_tipo_solicitud.MinWidth = 25;
            this.colid_tipo_solicitud.Name = "colid_tipo_solicitud";
            this.colid_tipo_solicitud.Width = 94;
            // 
            // colAceptar
            // 
            this.colAceptar.AppearanceCell.Options.UseTextOptions = true;
            this.colAceptar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAceptar.AppearanceHeader.Options.UseTextOptions = true;
            this.colAceptar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAceptar.Caption = "Aceptar";
            this.colAceptar.ColumnEdit = this.cmdAceptar;
            this.colAceptar.MaxWidth = 105;
            this.colAceptar.MinWidth = 105;
            this.colAceptar.Name = "colAceptar";
            this.colAceptar.Visible = true;
            this.colAceptar.VisibleIndex = 4;
            this.colAceptar.Width = 105;
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.AutoHeight = false;
            editorButtonImageOptions3.Image = global::Coordinadores_de_Dia.Properties.Resources.icon_check_32;
            this.cmdAceptar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdAceptar.Click += new System.EventHandler(this.CmdAceptar_Click);
            // 
            // colRechazar
            // 
            this.colRechazar.AppearanceCell.Options.UseTextOptions = true;
            this.colRechazar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRechazar.AppearanceHeader.Options.UseTextOptions = true;
            this.colRechazar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRechazar.Caption = "Rechazar";
            this.colRechazar.ColumnEdit = this.cmdRechazar;
            this.colRechazar.MaxWidth = 100;
            this.colRechazar.MinWidth = 100;
            this.colRechazar.Name = "colRechazar";
            this.colRechazar.Visible = true;
            this.colRechazar.VisibleIndex = 5;
            this.colRechazar.Width = 100;
            // 
            // cmdRechazar
            // 
            this.cmdRechazar.AutoHeight = false;
            editorButtonImageOptions4.Image = global::Coordinadores_de_Dia.Properties.Resources.iconMaloRojo_24;
            this.cmdRechazar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdRechazar.Name = "cmdRechazar";
            this.cmdRechazar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdRechazar.Click += new System.EventHandler(this.CmdRechazar_Click);
            // 
            // popupIngresoMotivoRechazo
            // 
            this.popupIngresoMotivoRechazo.Appearance.BackColor = System.Drawing.Color.White;
            this.popupIngresoMotivoRechazo.Appearance.Options.UseBackColor = true;
            this.popupIngresoMotivoRechazo.Controls.Add(this.flyoutPanelControl1);
            this.popupIngresoMotivoRechazo.Location = new System.Drawing.Point(73, 150);
            this.popupIngresoMotivoRechazo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.popupIngresoMotivoRechazo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.popupIngresoMotivoRechazo.Name = "popupIngresoMotivoRechazo";
            this.popupIngresoMotivoRechazo.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Center;
            this.popupIngresoMotivoRechazo.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade;
            this.popupIngresoMotivoRechazo.OptionsBeakPanel.BackColor = System.Drawing.Color.White;
            this.popupIngresoMotivoRechazo.OwnerControl = this;
            this.popupIngresoMotivoRechazo.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.popupIngresoMotivoRechazo.Size = new System.Drawing.Size(809, 476);
            this.popupIngresoMotivoRechazo.TabIndex = 27;
            // 
            // flyoutPanelControl1
            // 
            this.flyoutPanelControl1.Controls.Add(this.cmdGuardarRechazo);
            this.flyoutPanelControl1.Controls.Add(this.memoMotivosRechazo);
            this.flyoutPanelControl1.Controls.Add(this.panel3);
            this.flyoutPanelControl1.Controls.Add(this.pnlEncabezadoRechazo);
            this.flyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl1.FlyoutPanel = this.popupIngresoMotivoRechazo;
            this.flyoutPanelControl1.Location = new System.Drawing.Point(5, 0);
            this.flyoutPanelControl1.Name = "flyoutPanelControl1";
            this.flyoutPanelControl1.Size = new System.Drawing.Size(799, 476);
            this.flyoutPanelControl1.TabIndex = 0;
            // 
            // cmdGuardarRechazo
            // 
            this.cmdGuardarRechazo.EditValue = global::Coordinadores_de_Dia.Properties.Resources.icon_guardar_negro_64;
            this.cmdGuardarRechazo.Location = new System.Drawing.Point(647, 373);
            this.cmdGuardarRechazo.Name = "cmdGuardarRechazo";
            this.cmdGuardarRechazo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdGuardarRechazo.Properties.NullText = "   ";
            this.cmdGuardarRechazo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdGuardarRechazo.Size = new System.Drawing.Size(93, 86);
            this.cmdGuardarRechazo.TabIndex = 32;
            this.cmdGuardarRechazo.Click += new System.EventHandler(this.CmdGuardarRechazo_Click);
            // 
            // memoMotivosRechazo
            // 
            this.memoMotivosRechazo.Location = new System.Drawing.Point(57, 120);
            this.memoMotivosRechazo.Name = "memoMotivosRechazo";
            this.memoMotivosRechazo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoMotivosRechazo.Properties.Appearance.Options.UseFont = true;
            this.memoMotivosRechazo.Size = new System.Drawing.Size(683, 232);
            this.memoMotivosRechazo.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(793, 10);
            this.panel3.TabIndex = 19;
            // 
            // pnlEncabezadoRechazo
            // 
            this.pnlEncabezadoRechazo.Controls.Add(this.labelControl1);
            this.pnlEncabezadoRechazo.Controls.Add(this.cmdCerrarPoupRechazo);
            this.pnlEncabezadoRechazo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezadoRechazo.Location = new System.Drawing.Point(3, 3);
            this.pnlEncabezadoRechazo.Name = "pnlEncabezadoRechazo";
            this.pnlEncabezadoRechazo.Size = new System.Drawing.Size(793, 75);
            this.pnlEncabezadoRechazo.TabIndex = 18;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(723, 75);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Ingrese motivo de rechazo";
            // 
            // cmdCerrarPoupRechazo
            // 
            this.cmdCerrarPoupRechazo.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdCerrarPoupRechazo.EditValue = global::Coordinadores_de_Dia.Properties.Resources.iconCerrar_32;
            this.cmdCerrarPoupRechazo.Location = new System.Drawing.Point(723, 0);
            this.cmdCerrarPoupRechazo.Name = "cmdCerrarPoupRechazo";
            this.cmdCerrarPoupRechazo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdCerrarPoupRechazo.Properties.NullText = "   ";
            this.cmdCerrarPoupRechazo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdCerrarPoupRechazo.Size = new System.Drawing.Size(70, 75);
            this.cmdCerrarPoupRechazo.TabIndex = 31;
            this.cmdCerrarPoupRechazo.Click += new System.EventHandler(this.CmdCerrarPoupRechazo_Click);
            // 
            // ctlVistaSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.popupIngresoMotivoRechazo);
            this.Controls.Add(this.gcVistaSolicitud);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlEncabezado);
            this.Name = "ctlVistaSolicitudes";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1051, 627);
            this.pnlEncabezado.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBusqueda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVistaSolicitud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCoordinador_Dia1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVistaSolicitud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdRechazar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupIngresoMotivoRechazo)).EndInit();
            this.popupIngresoMotivoRechazo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).EndInit();
            this.flyoutPanelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdGuardarRechazo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoMotivosRechazo.Properties)).EndInit();
            this.pnlEncabezadoRechazo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdCerrarPoupRechazo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private DevExpress.XtraEditors.LabelControl lblEncabezado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.TextEdit txtBusqueda;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraGrid.GridControl gcVistaSolicitud;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVistaSolicitud;
        private DataSet.dsCoordinador_Dia dsCoordinador_Dia1;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_solicitante;
        private DevExpress.XtraGrid.Columns.GridColumn colid_area_atencion;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_solicitud;
        private DevExpress.XtraGrid.Columns.GridColumn colmotivo;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion_area_atencion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_colaborador_solicita;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tipo_solicitud;
        private DevExpress.XtraGrid.Columns.GridColumn colAceptar;
        private DevExpress.XtraGrid.Columns.GridColumn colRechazar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdAceptar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdRechazar;
        private DevExpress.Utils.FlyoutPanel popupIngresoMotivoRechazo;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlEncabezadoRechazo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit memoMotivosRechazo;
        private DevExpress.XtraEditors.PictureEdit cmdCerrarPoupRechazo;
        private DevExpress.XtraEditors.PictureEdit cmdGuardarRechazo;
    }
}
