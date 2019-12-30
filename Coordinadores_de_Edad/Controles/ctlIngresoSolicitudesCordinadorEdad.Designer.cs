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
            this.pnlEncabezado = new System.Windows.Forms.Panel();
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
            this.cmdOrganizadorActividades = new DevExpress.XtraEditors.PictureEdit();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaSolicitud.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaSolicitud.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacionesSolicitud.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdGuardarSolicitud.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConfiguracion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoSolicitud.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoSolicitud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdOrganizadorActividades.Properties)).BeginInit();
            this.pnlCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.lblEncabezado);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(5, 5);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1449, 75);
            this.pnlEncabezado.TabIndex = 11;
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
            this.lblEncabezado.Size = new System.Drawing.Size(1449, 75);
            this.lblEncabezado.TabIndex = 9;
            this.lblEncabezado.Text = "Ingreso de Solicitudes";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1449, 10);
            this.panel2.TabIndex = 12;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(77, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(218, 45);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Tipo de Solicitud";
            // 
            // dateFechaSolicitud
            // 
            this.dateFechaSolicitud.EditValue = null;
            this.dateFechaSolicitud.Location = new System.Drawing.Point(77, 189);
            this.dateFechaSolicitud.Name = "dateFechaSolicitud";
            this.dateFechaSolicitud.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaSolicitud.Properties.Appearance.Options.UseFont = true;
            this.dateFechaSolicitud.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFechaSolicitud.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFechaSolicitud.Size = new System.Drawing.Size(320, 38);
            this.dateFechaSolicitud.TabIndex = 22;
            // 
            // txtObservacionesSolicitud
            // 
            this.txtObservacionesSolicitud.Location = new System.Drawing.Point(77, 299);
            this.txtObservacionesSolicitud.MaximumSize = new System.Drawing.Size(646, 181);
            this.txtObservacionesSolicitud.Name = "txtObservacionesSolicitud";
            this.txtObservacionesSolicitud.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacionesSolicitud.Properties.Appearance.Options.UseFont = true;
            this.txtObservacionesSolicitud.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacionesSolicitud.Size = new System.Drawing.Size(595, 181);
            this.txtObservacionesSolicitud.TabIndex = 28;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(77, 138);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(246, 45);
            this.labelControl1.TabIndex = 30;
            this.labelControl1.Text = "Solicitar para el día";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(77, 248);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(197, 45);
            this.labelControl3.TabIndex = 31;
            this.labelControl3.Text = "Observaciones";
            // 
            // cmdGuardarSolicitud
            // 
            this.cmdGuardarSolicitud.EditValue = global::Coordinadores_de_Edad.Resources.icon_guardar_negro_64;
            this.cmdGuardarSolicitud.Location = new System.Drawing.Point(578, 547);
            this.cmdGuardarSolicitud.Name = "cmdGuardarSolicitud";
            this.cmdGuardarSolicitud.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdGuardarSolicitud.Properties.NullText = "   ";
            this.cmdGuardarSolicitud.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdGuardarSolicitud.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.cmdGuardarSolicitud.Size = new System.Drawing.Size(94, 96);
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
            this.glTipoSolicitud.Location = new System.Drawing.Point(77, 82);
            this.glTipoSolicitud.Name = "glTipoSolicitud";
            this.glTipoSolicitud.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glTipoSolicitud.Properties.Appearance.Options.UseFont = true;
            this.glTipoSolicitud.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glTipoSolicitud.Properties.DataSource = this.bsTipoSolicitud;
            this.glTipoSolicitud.Properties.DisplayMember = "descripcion";
            this.glTipoSolicitud.Properties.PopupView = this.gridLookUpEdit1View;
            this.glTipoSolicitud.Properties.ValueMember = "id_tipo_solicitud";
            this.glTipoSolicitud.Size = new System.Drawing.Size(454, 38);
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
            // cmdOrganizadorActividades
            // 
            this.cmdOrganizadorActividades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdOrganizadorActividades.EditValue = global::Coordinadores_de_Edad.Resources.img_solicitud;
            this.cmdOrganizadorActividades.Location = new System.Drawing.Point(5, 90);
            this.cmdOrganizadorActividades.Name = "cmdOrganizadorActividades";
            this.cmdOrganizadorActividades.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdOrganizadorActividades.Properties.NullText = "   ";
            this.cmdOrganizadorActividades.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdOrganizadorActividades.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdOrganizadorActividades.Size = new System.Drawing.Size(707, 720);
            this.cmdOrganizadorActividades.TabIndex = 33;
            this.cmdOrganizadorActividades.ToolTip = "Organizador de Actividades\r\n";
            this.cmdOrganizadorActividades.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.cmdOrganizadorActividades.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cmdOrganizadorActividades.ToolTipTitle = "Arca de los Tesoros";
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
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCentral.Location = new System.Drawing.Point(712, 90);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(742, 720);
            this.pnlCentral.TabIndex = 34;
            // 
            // ctlIngresoSolicitudesCordinadorEdad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmdOrganizadorActividades);
            this.Controls.Add(this.pnlCentral);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlEncabezado);
            this.MinimumSize = new System.Drawing.Size(1030, 815);
            this.Name = "ctlIngresoSolicitudesCordinadorEdad";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1459, 815);
            this.pnlEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaSolicitud.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaSolicitud.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacionesSolicitud.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdGuardarSolicitud.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConfiguracion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoSolicitud.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoSolicitud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdOrganizadorActividades.Properties)).EndInit();
            this.pnlCentral.ResumeLayout(false);
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
        private DevExpress.XtraEditors.PictureEdit cmdOrganizadorActividades;
        private System.Windows.Forms.Panel pnlCentral;
    }
}
