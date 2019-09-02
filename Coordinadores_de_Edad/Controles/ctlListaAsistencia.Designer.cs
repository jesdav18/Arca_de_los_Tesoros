namespace Coordinadores_de_Edad.Controles
{
    partial class ctlListaAsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlListaAsistencia));
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblEncabezado = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.PageListaAsistencia = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gcMaestrosDisponibles = new DevExpress.XtraGrid.GridControl();
            this.dsCoordinadoresEdad1 = new Coordinadores_de_Edad.DataSet.dsCoordinadoresEdad();
            this.gvListaAsistencia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_colaborador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_identidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdAsistio = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colclasificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinasistencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdNoAsistio = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtBusqueda = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
            this.PageListaAsistencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMaestrosDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCoordinadoresEdad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListaAsistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAsistio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdNoAsistio)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBusqueda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.lblEncabezado);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(5, 5);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1112, 75);
            this.pnlEncabezado.TabIndex = 16;
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
            this.lblEncabezado.Size = new System.Drawing.Size(1112, 75);
            this.lblEncabezado.TabIndex = 9;
            this.lblEncabezado.Text = "Lista de Asistencia";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1112, 10);
            this.panel2.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(5, 90);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1112, 14);
            this.panel4.TabIndex = 20;
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Controls.Add(this.PageListaAsistencia);
            this.navigationFrame1.Controls.Add(this.navigationPage2);
            this.navigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame1.Location = new System.Drawing.Point(5, 104);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.PageListaAsistencia,
            this.navigationPage2});
            this.navigationFrame1.SelectedPage = this.PageListaAsistencia;
            this.navigationFrame1.Size = new System.Drawing.Size(1112, 549);
            this.navigationFrame1.TabIndex = 25;
            this.navigationFrame1.Text = "navigationFrame1";
            // 
            // PageListaAsistencia
            // 
            this.PageListaAsistencia.Caption = "PageListaAsistencia";
            this.PageListaAsistencia.Controls.Add(this.gcMaestrosDisponibles);
            this.PageListaAsistencia.Controls.Add(this.panel1);
            this.PageListaAsistencia.Controls.Add(this.panel5);
            this.PageListaAsistencia.Name = "PageListaAsistencia";
            this.PageListaAsistencia.Size = new System.Drawing.Size(1112, 549);
            // 
            // gcMaestrosDisponibles
            // 
            this.gcMaestrosDisponibles.DataMember = "dtListaAsistencia";
            this.gcMaestrosDisponibles.DataSource = this.dsCoordinadoresEdad1;
            this.gcMaestrosDisponibles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMaestrosDisponibles.Location = new System.Drawing.Point(0, 80);
            this.gcMaestrosDisponibles.MainView = this.gvListaAsistencia;
            this.gcMaestrosDisponibles.Name = "gcMaestrosDisponibles";
            this.gcMaestrosDisponibles.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdAsistio,
            this.cmdNoAsistio});
            this.gcMaestrosDisponibles.Size = new System.Drawing.Size(1112, 469);
            this.gcMaestrosDisponibles.TabIndex = 26;
            this.gcMaestrosDisponibles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListaAsistencia});
            // 
            // dsCoordinadoresEdad1
            // 
            this.dsCoordinadoresEdad1.DataSetName = "dsCoordinadoresEdad";
            this.dsCoordinadoresEdad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvListaAsistencia
            // 
            this.gvListaAsistencia.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvListaAsistencia.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvListaAsistencia.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvListaAsistencia.Appearance.Row.Options.UseFont = true;
            this.gvListaAsistencia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_colaborador,
            this.colnombre,
            this.colnumero_identidad,
            this.colseleccionar,
            this.colclasificacion,
            this.colinasistencia});
            this.gvListaAsistencia.GridControl = this.gcMaestrosDisponibles;
            this.gvListaAsistencia.Name = "gvListaAsistencia";
            this.gvListaAsistencia.OptionsView.ShowGroupPanel = false;
            this.gvListaAsistencia.OptionsView.ShowIndicator = false;
            // 
            // colid_colaborador
            // 
            this.colid_colaborador.FieldName = "id_colaborador";
            this.colid_colaborador.MinWidth = 25;
            this.colid_colaborador.Name = "colid_colaborador";
            this.colid_colaborador.Width = 94;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.MinWidth = 25;
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 428;
            // 
            // colnumero_identidad
            // 
            this.colnumero_identidad.Caption = "Identidad";
            this.colnumero_identidad.FieldName = "numero_identidad";
            this.colnumero_identidad.MinWidth = 25;
            this.colnumero_identidad.Name = "colnumero_identidad";
            this.colnumero_identidad.Visible = true;
            this.colnumero_identidad.VisibleIndex = 0;
            this.colnumero_identidad.Width = 200;
            // 
            // colseleccionar
            // 
            this.colseleccionar.AppearanceHeader.Options.UseTextOptions = true;
            this.colseleccionar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colseleccionar.Caption = "Asistió";
            this.colseleccionar.ColumnEdit = this.cmdAsistio;
            this.colseleccionar.FieldName = "seleccionar";
            this.colseleccionar.MaxWidth = 130;
            this.colseleccionar.MinWidth = 130;
            this.colseleccionar.Name = "colseleccionar";
            this.colseleccionar.Visible = true;
            this.colseleccionar.VisibleIndex = 3;
            this.colseleccionar.Width = 130;
            // 
            // cmdAsistio
            // 
            this.cmdAsistio.AutoHeight = false;
            editorButtonImageOptions3.Image = global::Coordinadores_de_Edad.Resources.iconCheck_24;
            this.cmdAsistio.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdAsistio.Name = "cmdAsistio";
            this.cmdAsistio.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdAsistio.Click += new System.EventHandler(this.CmdAsistio_Click);
            // 
            // colclasificacion
            // 
            this.colclasificacion.Caption = "Cargo";
            this.colclasificacion.FieldName = "clasificacion";
            this.colclasificacion.MinWidth = 25;
            this.colclasificacion.Name = "colclasificacion";
            this.colclasificacion.Visible = true;
            this.colclasificacion.VisibleIndex = 2;
            this.colclasificacion.Width = 240;
            // 
            // colinasistencia
            // 
            this.colinasistencia.AppearanceHeader.Options.UseTextOptions = true;
            this.colinasistencia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colinasistencia.Caption = "No Asistió";
            this.colinasistencia.ColumnEdit = this.cmdNoAsistio;
            this.colinasistencia.FieldName = "inasistencia";
            this.colinasistencia.MaxWidth = 120;
            this.colinasistencia.MinWidth = 120;
            this.colinasistencia.Name = "colinasistencia";
            this.colinasistencia.Visible = true;
            this.colinasistencia.VisibleIndex = 4;
            this.colinasistencia.Width = 120;
            // 
            // cmdNoAsistio
            // 
            this.cmdNoAsistio.AutoHeight = false;
            editorButtonImageOptions4.Image = global::Coordinadores_de_Edad.Resources.iconMalo_24;
            this.cmdNoAsistio.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdNoAsistio.Name = "cmdNoAsistio";
            this.cmdNoAsistio.NullText = " ";
            this.cmdNoAsistio.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdNoAsistio.Click += new System.EventHandler(this.CmdNoAsistio_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 26);
            this.panel1.TabIndex = 25;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtBusqueda);
            this.panel5.Controls.Add(this.pictureEdit1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(1112, 54);
            this.panel5.TabIndex = 24;
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
            // navigationPage2
            // 
            this.navigationPage2.Caption = "navigationPage2";
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(1112, 549);
            // 
            // ctlListaAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.navigationFrame1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlEncabezado);
            this.Name = "ctlListaAsistencia";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1122, 658);
            this.pnlEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
            this.PageListaAsistencia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMaestrosDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCoordinadoresEdad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListaAsistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAsistio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdNoAsistio)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBusqueda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private DevExpress.XtraEditors.LabelControl lblEncabezado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage PageListaAsistencia;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.TextEdit txtBusqueda;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gcMaestrosDisponibles;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListaAsistencia;
        private DataSet.dsCoordinadoresEdad dsCoordinadoresEdad1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_colaborador;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_identidad;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionar;
        private DevExpress.XtraGrid.Columns.GridColumn colclasificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colinasistencia;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdAsistio;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdNoAsistio;
    }
}
