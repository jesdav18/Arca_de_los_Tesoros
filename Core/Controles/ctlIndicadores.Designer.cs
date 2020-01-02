namespace Core.Controles
{
    partial class ctlIndicadores
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlIndicadores));
            this.gvActividad = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_actividad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsVistas1 = new Core.DataSets.dsVistas();
            this.gvEquipos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_area_atencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkAsistio = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.chkUsaCarnet = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.chkUsaUniforme = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gvDetalleAsistencia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnombre_colaborador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_colaborador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusa_carnet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusa_uniforme = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colasistio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblEncabezado = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ctlAsistenciaEquipos1 = new Core.Controles.ctlAsistenciaEquipos();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateDesde = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateHasta = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.picCargar = new DevExpress.XtraEditors.PictureEdit();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gvActividad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVistas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAsistio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkUsaCarnet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkUsaUniforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalleAsistencia)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCargar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gvActividad
            // 
            this.gvActividad.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvActividad.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvActividad.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvActividad.Appearance.Row.Options.UseFont = true;
            this.gvActividad.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colfecha,
            this.colid_actividad});
            this.gvActividad.GridControl = this.gridControl1;
            this.gvActividad.Name = "gvActividad";
            this.gvActividad.OptionsDetail.ShowDetailTabs = false;
            this.gvActividad.OptionsView.ShowGroupPanel = false;
            this.gvActividad.OptionsView.ShowIndicator = false;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha Actividad";
            this.colfecha.FieldName = "fecha";
            this.colfecha.MinWidth = 25;
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.OptionsColumn.AllowFocus = false;
            this.colfecha.OptionsColumn.ReadOnly = true;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 0;
            this.colfecha.Width = 94;
            // 
            // colid_actividad
            // 
            this.colid_actividad.Caption = "ID Actividad";
            this.colid_actividad.FieldName = "id_actividad";
            this.colid_actividad.MinWidth = 25;
            this.colid_actividad.Name = "colid_actividad";
            this.colid_actividad.OptionsColumn.AllowEdit = false;
            this.colid_actividad.OptionsColumn.AllowFocus = false;
            this.colid_actividad.OptionsColumn.ReadOnly = true;
            this.colid_actividad.Width = 94;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "dtAreasAtencion";
            this.gridControl1.DataSource = this.dsVistas1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gvActividad;
            gridLevelNode2.LevelTemplate = this.gvDetalleAsistencia;
            gridLevelNode2.RelationName = "FK_dtActividad_dtDetalleAsistencias";
            gridLevelNode1.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            gridLevelNode1.RelationName = "FK_dtAreasAtencion_dtActividad";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(5, 362);
            this.gridControl1.MainView = this.gvEquipos;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chkAsistio,
            this.chkUsaCarnet,
            this.chkUsaUniforme});
            this.gridControl1.Size = new System.Drawing.Size(995, 449);
            this.gridControl1.TabIndex = 16;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEquipos,
            this.gvDetalleAsistencia,
            this.gvActividad});
            // 
            // dsVistas1
            // 
            this.dsVistas1.DataSetName = "dsVistas";
            this.dsVistas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvEquipos
            // 
            this.gvEquipos.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvEquipos.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvEquipos.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvEquipos.Appearance.Row.Options.UseFont = true;
            this.gvEquipos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_area_atencion,
            this.coldescripcion});
            this.gvEquipos.GridControl = this.gridControl1;
            this.gvEquipos.Name = "gvEquipos";
            this.gvEquipos.OptionsDetail.ShowDetailTabs = false;
            this.gvEquipos.OptionsView.ShowGroupPanel = false;
            this.gvEquipos.OptionsView.ShowIndicator = false;
            // 
            // colid_area_atencion
            // 
            this.colid_area_atencion.Caption = "ID Area Atención";
            this.colid_area_atencion.FieldName = "id_area_atencion";
            this.colid_area_atencion.MinWidth = 25;
            this.colid_area_atencion.Name = "colid_area_atencion";
            this.colid_area_atencion.OptionsColumn.AllowEdit = false;
            this.colid_area_atencion.OptionsColumn.AllowFocus = false;
            this.colid_area_atencion.OptionsColumn.ReadOnly = true;
            this.colid_area_atencion.Width = 94;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Equipo";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.MinWidth = 25;
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.OptionsColumn.AllowFocus = false;
            this.coldescripcion.OptionsColumn.ReadOnly = true;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            this.coldescripcion.Width = 94;
            // 
            // chkAsistio
            // 
            this.chkAsistio.AutoHeight = false;
            this.chkAsistio.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom;
            this.chkAsistio.ImageOptions.ImageChecked = ((System.Drawing.Image)(resources.GetObject("chkAsistio.ImageOptions.ImageChecked")));
            this.chkAsistio.ImageOptions.ImageUnchecked = ((System.Drawing.Image)(resources.GetObject("chkAsistio.ImageOptions.ImageUnchecked")));
            this.chkAsistio.Name = "chkAsistio";
            // 
            // chkUsaCarnet
            // 
            this.chkUsaCarnet.AutoHeight = false;
            this.chkUsaCarnet.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom;
            this.chkUsaCarnet.ImageOptions.ImageChecked = ((System.Drawing.Image)(resources.GetObject("chkUsaCarnet.ImageOptions.ImageChecked")));
            this.chkUsaCarnet.ImageOptions.ImageUnchecked = ((System.Drawing.Image)(resources.GetObject("chkUsaCarnet.ImageOptions.ImageUnchecked")));
            this.chkUsaCarnet.Name = "chkUsaCarnet";
            // 
            // chkUsaUniforme
            // 
            this.chkUsaUniforme.AutoHeight = false;
            this.chkUsaUniforme.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom;
            this.chkUsaUniforme.ImageOptions.ImageChecked = ((System.Drawing.Image)(resources.GetObject("chkUsaUniforme.ImageOptions.ImageChecked")));
            this.chkUsaUniforme.ImageOptions.ImageUnchecked = ((System.Drawing.Image)(resources.GetObject("chkUsaUniforme.ImageOptions.ImageUnchecked")));
            this.chkUsaUniforme.Name = "chkUsaUniforme";
            // 
            // gvDetalleAsistencia
            // 
            this.gvDetalleAsistencia.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDetalleAsistencia.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDetalleAsistencia.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDetalleAsistencia.Appearance.Row.Options.UseFont = true;
            this.gvDetalleAsistencia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnombre_colaborador,
            this.colid_colaborador,
            this.colusa_carnet,
            this.colusa_uniforme,
            this.colasistio});
            this.gvDetalleAsistencia.GridControl = this.gridControl1;
            this.gvDetalleAsistencia.Name = "gvDetalleAsistencia";
            this.gvDetalleAsistencia.OptionsDetail.ShowDetailTabs = false;
            this.gvDetalleAsistencia.OptionsView.ShowGroupPanel = false;
            this.gvDetalleAsistencia.OptionsView.ShowIndicator = false;
            // 
            // colnombre_colaborador
            // 
            this.colnombre_colaborador.Caption = "Nombre Colaborador";
            this.colnombre_colaborador.FieldName = "nombre_colaborador";
            this.colnombre_colaborador.MinWidth = 25;
            this.colnombre_colaborador.Name = "colnombre_colaborador";
            this.colnombre_colaborador.OptionsColumn.AllowEdit = false;
            this.colnombre_colaborador.OptionsColumn.AllowFocus = false;
            this.colnombre_colaborador.OptionsColumn.ReadOnly = true;
            this.colnombre_colaborador.Visible = true;
            this.colnombre_colaborador.VisibleIndex = 0;
            this.colnombre_colaborador.Width = 94;
            // 
            // colid_colaborador
            // 
            this.colid_colaborador.Caption = "ID Colaborador";
            this.colid_colaborador.FieldName = "id_colaborador";
            this.colid_colaborador.MinWidth = 25;
            this.colid_colaborador.Name = "colid_colaborador";
            this.colid_colaborador.OptionsColumn.AllowEdit = false;
            this.colid_colaborador.OptionsColumn.AllowFocus = false;
            this.colid_colaborador.OptionsColumn.ReadOnly = true;
            this.colid_colaborador.Width = 94;
            // 
            // colusa_carnet
            // 
            this.colusa_carnet.AppearanceCell.Options.UseTextOptions = true;
            this.colusa_carnet.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colusa_carnet.AppearanceHeader.Options.UseTextOptions = true;
            this.colusa_carnet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colusa_carnet.Caption = "Uso Carnet";
            this.colusa_carnet.ColumnEdit = this.chkUsaCarnet;
            this.colusa_carnet.FieldName = "usa_carnet";
            this.colusa_carnet.MaxWidth = 150;
            this.colusa_carnet.MinWidth = 150;
            this.colusa_carnet.Name = "colusa_carnet";
            this.colusa_carnet.OptionsColumn.AllowEdit = false;
            this.colusa_carnet.OptionsColumn.AllowFocus = false;
            this.colusa_carnet.OptionsColumn.ReadOnly = true;
            this.colusa_carnet.Visible = true;
            this.colusa_carnet.VisibleIndex = 2;
            this.colusa_carnet.Width = 150;
            // 
            // colusa_uniforme
            // 
            this.colusa_uniforme.AppearanceCell.Options.UseTextOptions = true;
            this.colusa_uniforme.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colusa_uniforme.AppearanceHeader.Options.UseTextOptions = true;
            this.colusa_uniforme.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colusa_uniforme.Caption = "Usa Uniforme";
            this.colusa_uniforme.ColumnEdit = this.chkUsaUniforme;
            this.colusa_uniforme.FieldName = "usa_uniforme";
            this.colusa_uniforme.MaxWidth = 160;
            this.colusa_uniforme.MinWidth = 160;
            this.colusa_uniforme.Name = "colusa_uniforme";
            this.colusa_uniforme.OptionsColumn.AllowEdit = false;
            this.colusa_uniforme.OptionsColumn.AllowFocus = false;
            this.colusa_uniforme.OptionsColumn.ReadOnly = true;
            this.colusa_uniforme.Visible = true;
            this.colusa_uniforme.VisibleIndex = 3;
            this.colusa_uniforme.Width = 160;
            // 
            // colasistio
            // 
            this.colasistio.AppearanceCell.Options.UseTextOptions = true;
            this.colasistio.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colasistio.AppearanceHeader.Options.UseTextOptions = true;
            this.colasistio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colasistio.Caption = "Asistió";
            this.colasistio.ColumnEdit = this.chkAsistio;
            this.colasistio.FieldName = "asistio";
            this.colasistio.MaxWidth = 110;
            this.colasistio.MinWidth = 110;
            this.colasistio.Name = "colasistio";
            this.colasistio.OptionsColumn.AllowEdit = false;
            this.colasistio.OptionsColumn.AllowFocus = false;
            this.colasistio.OptionsColumn.ReadOnly = true;
            this.colasistio.Visible = true;
            this.colasistio.VisibleIndex = 1;
            this.colasistio.Width = 110;
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.lblEncabezado);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(5, 5);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(995, 55);
            this.pnlEncabezado.TabIndex = 11;
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.Appearance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.Appearance.Options.UseFont = true;
            this.lblEncabezado.Appearance.Options.UseTextOptions = true;
            this.lblEncabezado.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblEncabezado.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblEncabezado.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEncabezado.Location = new System.Drawing.Point(0, 0);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(995, 55);
            this.lblEncabezado.TabIndex = 9;
            this.lblEncabezado.Text = "Indicadores de Actividades";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(995, 5);
            this.panel2.TabIndex = 12;
            // 
            // ctlAsistenciaEquipos1
            // 
            this.ctlAsistenciaEquipos1.BackColor = System.Drawing.Color.White;
            this.ctlAsistenciaEquipos1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlAsistenciaEquipos1.Location = new System.Drawing.Point(5, 163);
            this.ctlAsistenciaEquipos1.Name = "ctlAsistenciaEquipos1";
            this.ctlAsistenciaEquipos1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlAsistenciaEquipos1.Pro_Conexion = null;
            this.ctlAsistenciaEquipos1.Size = new System.Drawing.Size(995, 189);
            this.ctlAsistenciaEquipos1.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 17);
            this.panel1.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(5, 352);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(995, 10);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.picCargar);
            this.panel4.Controls.Add(this.dateHasta);
            this.panel4.Controls.Add(this.labelControl1);
            this.panel4.Controls.Add(this.dateDesde);
            this.panel4.Controls.Add(this.labelControl2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(5, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(995, 71);
            this.panel4.TabIndex = 17;
            // 
            // dateDesde
            // 
            this.dateDesde.EditValue = null;
            this.dateDesde.EnterMoveNextControl = true;
            this.dateDesde.Location = new System.Drawing.Point(106, 19);
            this.dateDesde.Name = "dateDesde";
            this.dateDesde.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDesde.Properties.Appearance.Options.UseFont = true;
            this.dateDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDesde.Size = new System.Drawing.Size(267, 38);
            this.dateDesde.TabIndex = 36;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(27, 22);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 31);
            this.labelControl2.TabIndex = 27;
            this.labelControl2.Text = "Desde:";
            // 
            // dateHasta
            // 
            this.dateHasta.EditValue = null;
            this.dateHasta.EnterMoveNextControl = true;
            this.dateHasta.Location = new System.Drawing.Point(485, 19);
            this.dateHasta.Name = "dateHasta";
            this.dateHasta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateHasta.Properties.Appearance.Options.UseFont = true;
            this.dateHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateHasta.Size = new System.Drawing.Size(267, 38);
            this.dateHasta.TabIndex = 38;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(406, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 31);
            this.labelControl1.TabIndex = 37;
            this.labelControl1.Text = "Hasta:";
            // 
            // picCargar
            // 
            this.picCargar.EditValue = global::Core.Properties.Resources.iconBusqueda;
            this.picCargar.Location = new System.Drawing.Point(788, 6);
            this.picCargar.Name = "picCargar";
            this.picCargar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picCargar.Properties.NullText = "   ";
            this.picCargar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picCargar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picCargar.Size = new System.Drawing.Size(64, 51);
            this.picCargar.TabIndex = 39;
            this.picCargar.Click += new System.EventHandler(this.PicCargar_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(5, 153);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(995, 10);
            this.panel5.TabIndex = 18;
            // 
            // ctlIndicadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ctlAsistenciaEquipos1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlEncabezado);
            this.Name = "ctlIndicadores";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1005, 816);
            ((System.ComponentModel.ISupportInitialize)(this.gvActividad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVistas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAsistio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkUsaCarnet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkUsaUniforme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalleAsistencia)).EndInit();
            this.pnlEncabezado.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCargar.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private DevExpress.XtraEditors.LabelControl lblEncabezado;
        private System.Windows.Forms.Panel panel2;
        private ctlAsistenciaEquipos ctlAsistenciaEquipos1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private DataSets.dsVistas dsVistas1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvActividad;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDetalleAsistencia;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEquipos;
        private DevExpress.XtraGrid.Columns.GridColumn colid_area_atencion;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colid_actividad;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_colaborador;
        private DevExpress.XtraGrid.Columns.GridColumn colid_colaborador;
        private DevExpress.XtraGrid.Columns.GridColumn colusa_carnet;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkUsaCarnet;
        private DevExpress.XtraGrid.Columns.GridColumn colusa_uniforme;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkUsaUniforme;
        private DevExpress.XtraGrid.Columns.GridColumn colasistio;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkAsistio;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.DateEdit dateDesde;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dateHasta;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit picCargar;
        private System.Windows.Forms.Panel panel5;
    }
}
