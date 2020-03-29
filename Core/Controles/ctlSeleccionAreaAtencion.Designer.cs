namespace Core.Controles
{
    partial class ctlSeleccionAreaAtencion
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.dsVistas1 = new Core.DataSets.dsVistas();
            this.gcAreasAtencion = new DevExpress.XtraGrid.GridControl();
            this.gvAreasAtencion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_area_atencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdVerFicha = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVistas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAreasAtencion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAreasAtencion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerFicha)).BeginInit();
            this.SuspendLayout();
            // 
            // dsVistas1
            // 
            this.dsVistas1.DataSetName = "dsVistas";
            this.dsVistas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gcAreasAtencion
            // 
            this.gcAreasAtencion.DataMember = "dtAreasAtencion";
            this.gcAreasAtencion.DataSource = this.dsVistas1;
            this.gcAreasAtencion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAreasAtencion.Location = new System.Drawing.Point(0, 0);
            this.gcAreasAtencion.MainView = this.gvAreasAtencion;
            this.gcAreasAtencion.Name = "gcAreasAtencion";
            this.gcAreasAtencion.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdVerFicha});
            this.gcAreasAtencion.Size = new System.Drawing.Size(590, 334);
            this.gcAreasAtencion.TabIndex = 16;
            this.gcAreasAtencion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAreasAtencion});
            // 
            // gvAreasAtencion
            // 
            this.gvAreasAtencion.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvAreasAtencion.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvAreasAtencion.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvAreasAtencion.Appearance.Row.Options.UseFont = true;
            this.gvAreasAtencion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_area_atencion,
            this.coldescripcion});
            this.gvAreasAtencion.GridControl = this.gcAreasAtencion;
            this.gvAreasAtencion.Name = "gvAreasAtencion";
            this.gvAreasAtencion.OptionsView.ShowColumnHeaders = false;
            this.gvAreasAtencion.OptionsView.ShowDetailButtons = false;
            this.gvAreasAtencion.OptionsView.ShowGroupPanel = false;
            this.gvAreasAtencion.OptionsView.ShowIndicator = false;
            this.gvAreasAtencion.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GvAreasAtencion_RowClick);
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
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.MinWidth = 25;
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.OptionsColumn.AllowFocus = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            this.coldescripcion.Width = 94;
            // 
            // cmdVerFicha
            // 
            this.cmdVerFicha.AutoHeight = false;
            editorButtonImageOptions1.Image = global::Core.Properties.Resources.icon_visualizar_24;
            this.cmdVerFicha.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdVerFicha.Name = "cmdVerFicha";
            this.cmdVerFicha.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // ctlSeleccionAreaAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gcAreasAtencion);
            this.Name = "ctlSeleccionAreaAtencion";
            this.Size = new System.Drawing.Size(590, 334);
            ((System.ComponentModel.ISupportInitialize)(this.dsVistas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAreasAtencion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAreasAtencion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerFicha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSets.dsVistas dsVistas1;
        private DevExpress.XtraGrid.GridControl gcAreasAtencion;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAreasAtencion;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdVerFicha;
        private DevExpress.XtraGrid.Columns.GridColumn colid_area_atencion;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
    }
}
