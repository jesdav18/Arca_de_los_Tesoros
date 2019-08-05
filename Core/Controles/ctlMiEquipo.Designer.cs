namespace Core.Controles
{
    partial class ctlMiEquipo
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcMiEquipo = new DevExpress.XtraGrid.GridControl();
            this.dsVistas1 = new Core.DataSets.dsVistas();
            this.gvMiEquipo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_colaborador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario_colaborador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_colaborador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVerFicha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdVerFicha = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colnumero_identidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Core.Pantallas.frmEspera), true, true, typeof(System.Windows.Forms.UserControl));
            this.NavigationMiEquipo = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.PageMiEquipo = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblEncabezado = new DevExpress.XtraEditors.LabelControl();
            this.PageFichaIngreso = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBusqueda = new DevExpress.XtraEditors.TextEdit();
            this.cmdGuardarSolicitud = new DevExpress.XtraEditors.PictureEdit();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ctlVistaFichaIngreso1 = new Core.Controles.ctlVistaFichaIngreso();
            ((System.ComponentModel.ISupportInitialize)(this.gcMiEquipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVistas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMiEquipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerFicha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigationMiEquipo)).BeginInit();
            this.NavigationMiEquipo.SuspendLayout();
            this.PageMiEquipo.SuspendLayout();
            this.pnlEncabezado.SuspendLayout();
            this.PageFichaIngreso.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBusqueda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdGuardarSolicitud.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcMiEquipo
            // 
            this.gcMiEquipo.DataMember = "dtMiEquipo";
            this.gcMiEquipo.DataSource = this.dsVistas1;
            this.gcMiEquipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMiEquipo.Location = new System.Drawing.Point(0, 157);
            this.gcMiEquipo.MainView = this.gvMiEquipo;
            this.gcMiEquipo.Name = "gcMiEquipo";
            this.gcMiEquipo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdVerFicha});
            this.gcMiEquipo.Size = new System.Drawing.Size(1136, 543);
            this.gcMiEquipo.TabIndex = 15;
            this.gcMiEquipo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMiEquipo});
            // 
            // dsVistas1
            // 
            this.dsVistas1.DataSetName = "dsVistas";
            this.dsVistas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvMiEquipo
            // 
            this.gvMiEquipo.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMiEquipo.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvMiEquipo.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMiEquipo.Appearance.Row.Options.UseFont = true;
            this.gvMiEquipo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_colaborador,
            this.colusuario_colaborador,
            this.colnombre_colaborador,
            this.colVerFicha,
            this.colnumero_identidad});
            this.gvMiEquipo.GridControl = this.gcMiEquipo;
            this.gvMiEquipo.Name = "gvMiEquipo";
            this.gvMiEquipo.OptionsView.ShowGroupPanel = false;
            this.gvMiEquipo.OptionsView.ShowIndicator = false;
            // 
            // colid_colaborador
            // 
            this.colid_colaborador.Caption = "ID COLABORADOR";
            this.colid_colaborador.FieldName = "id_colaborador";
            this.colid_colaborador.MinWidth = 25;
            this.colid_colaborador.Name = "colid_colaborador";
            this.colid_colaborador.Width = 94;
            // 
            // colusuario_colaborador
            // 
            this.colusuario_colaborador.Caption = "USUARIO";
            this.colusuario_colaborador.FieldName = "usuario_colaborador";
            this.colusuario_colaborador.MinWidth = 25;
            this.colusuario_colaborador.Name = "colusuario_colaborador";
            this.colusuario_colaborador.Width = 94;
            // 
            // colnombre_colaborador
            // 
            this.colnombre_colaborador.Caption = "Nombre";
            this.colnombre_colaborador.FieldName = "nombre_colaborador";
            this.colnombre_colaborador.MinWidth = 25;
            this.colnombre_colaborador.Name = "colnombre_colaborador";
            this.colnombre_colaborador.OptionsColumn.AllowEdit = false;
            this.colnombre_colaborador.OptionsColumn.AllowFocus = false;
            this.colnombre_colaborador.Visible = true;
            this.colnombre_colaborador.VisibleIndex = 1;
            this.colnombre_colaborador.Width = 94;
            // 
            // colVerFicha
            // 
            this.colVerFicha.AppearanceHeader.Options.UseTextOptions = true;
            this.colVerFicha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVerFicha.Caption = "Ver Ficha";
            this.colVerFicha.ColumnEdit = this.cmdVerFicha;
            this.colVerFicha.MaxWidth = 130;
            this.colVerFicha.MinWidth = 130;
            this.colVerFicha.Name = "colVerFicha";
            this.colVerFicha.Visible = true;
            this.colVerFicha.VisibleIndex = 2;
            this.colVerFicha.Width = 130;
            // 
            // cmdVerFicha
            // 
            this.cmdVerFicha.AutoHeight = false;
            editorButtonImageOptions2.Image = global::Core.Properties.Resources.icon_visualizar_24;
            this.cmdVerFicha.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdVerFicha.Name = "cmdVerFicha";
            this.cmdVerFicha.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdVerFicha.Click += new System.EventHandler(this.CmdVerFicha_Click);
            // 
            // colnumero_identidad
            // 
            this.colnumero_identidad.Caption = "N° Identidad";
            this.colnumero_identidad.FieldName = "numero_identidad";
            this.colnumero_identidad.MaxWidth = 250;
            this.colnumero_identidad.MinWidth = 250;
            this.colnumero_identidad.Name = "colnumero_identidad";
            this.colnumero_identidad.OptionsColumn.AllowEdit = false;
            this.colnumero_identidad.OptionsColumn.AllowFocus = false;
            this.colnumero_identidad.OptionsColumn.ReadOnly = true;
            this.colnumero_identidad.Visible = true;
            this.colnumero_identidad.VisibleIndex = 0;
            this.colnumero_identidad.Width = 250;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // NavigationMiEquipo
            // 
            this.NavigationMiEquipo.Controls.Add(this.PageMiEquipo);
            this.NavigationMiEquipo.Controls.Add(this.PageFichaIngreso);
            this.NavigationMiEquipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationMiEquipo.Location = new System.Drawing.Point(5, 5);
            this.NavigationMiEquipo.Name = "NavigationMiEquipo";
            this.NavigationMiEquipo.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.PageMiEquipo,
            this.PageFichaIngreso});
            this.NavigationMiEquipo.SelectedPage = this.PageMiEquipo;
            this.NavigationMiEquipo.Size = new System.Drawing.Size(1136, 700);
            this.NavigationMiEquipo.TabIndex = 18;
            // 
            // PageMiEquipo
            // 
            this.PageMiEquipo.Caption = "PageMiEquipo";
            this.PageMiEquipo.Controls.Add(this.panel4);
            this.PageMiEquipo.Controls.Add(this.gcMiEquipo);
            this.PageMiEquipo.Controls.Add(this.panel1);
            this.PageMiEquipo.Controls.Add(this.panel3);
            this.PageMiEquipo.Controls.Add(this.panel2);
            this.PageMiEquipo.Controls.Add(this.pnlEncabezado);
            this.PageMiEquipo.Name = "PageMiEquipo";
            this.PageMiEquipo.Size = new System.Drawing.Size(1136, 700);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1136, 18);
            this.panel3.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1136, 10);
            this.panel2.TabIndex = 14;
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.lblEncabezado);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1136, 75);
            this.pnlEncabezado.TabIndex = 13;
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
            this.lblEncabezado.Size = new System.Drawing.Size(1136, 75);
            this.lblEncabezado.TabIndex = 9;
            this.lblEncabezado.Text = "Nombre de Equipo";
            // 
            // PageFichaIngreso
            // 
            this.PageFichaIngreso.Controls.Add(this.ctlVistaFichaIngreso1);
            this.PageFichaIngreso.Name = "PageFichaIngreso";
            this.PageFichaIngreso.Size = new System.Drawing.Size(1136, 700);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBusqueda);
            this.panel1.Controls.Add(this.cmdGuardarSolicitud);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 103);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1136, 54);
            this.panel1.TabIndex = 18;
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
            // cmdGuardarSolicitud
            // 
            this.cmdGuardarSolicitud.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdGuardarSolicitud.EditValue = global::Core.Properties.Resources.iconFiltro_64;
            this.cmdGuardarSolicitud.Location = new System.Drawing.Point(5, 5);
            this.cmdGuardarSolicitud.Name = "cmdGuardarSolicitud";
            this.cmdGuardarSolicitud.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdGuardarSolicitud.Properties.NullText = "   ";
            this.cmdGuardarSolicitud.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdGuardarSolicitud.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdGuardarSolicitud.Size = new System.Drawing.Size(63, 44);
            this.cmdGuardarSolicitud.TabIndex = 30;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 157);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1136, 27);
            this.panel4.TabIndex = 19;
            // 
            // ctlVistaFichaIngreso1
            // 
            this.ctlVistaFichaIngreso1.BackColor = System.Drawing.Color.White;
            this.ctlVistaFichaIngreso1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlVistaFichaIngreso1.Location = new System.Drawing.Point(0, 0);
            this.ctlVistaFichaIngreso1.Name = "ctlVistaFichaIngreso1";
            this.ctlVistaFichaIngreso1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlVistaFichaIngreso1.Pro_Conexion = null;
            this.ctlVistaFichaIngreso1.Pro_ID_Colaborador = 0;
            this.ctlVistaFichaIngreso1.Size = new System.Drawing.Size(1136, 700);
            this.ctlVistaFichaIngreso1.TabIndex = 0;
            // 
            // ctlMiEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.NavigationMiEquipo);
            this.Name = "ctlMiEquipo";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1146, 710);
            ((System.ComponentModel.ISupportInitialize)(this.gcMiEquipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVistas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMiEquipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerFicha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigationMiEquipo)).EndInit();
            this.NavigationMiEquipo.ResumeLayout(false);
            this.PageMiEquipo.ResumeLayout(false);
            this.pnlEncabezado.ResumeLayout(false);
            this.PageFichaIngreso.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBusqueda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdGuardarSolicitud.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gcMiEquipo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMiEquipo;
        private DataSets.dsVistas dsVistas1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_colaborador;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario_colaborador;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_colaborador;
        private DevExpress.XtraGrid.Columns.GridColumn colVerFicha;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdVerFicha;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_identidad;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraBars.Navigation.NavigationFrame NavigationMiEquipo;
        private DevExpress.XtraBars.Navigation.NavigationPage PageMiEquipo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlEncabezado;
        private DevExpress.XtraEditors.LabelControl lblEncabezado;
        private DevExpress.XtraBars.Navigation.NavigationPage PageFichaIngreso;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtBusqueda;
        private DevExpress.XtraEditors.PictureEdit cmdGuardarSolicitud;
        private ctlVistaFichaIngreso ctlVistaFichaIngreso1;
    }
}
