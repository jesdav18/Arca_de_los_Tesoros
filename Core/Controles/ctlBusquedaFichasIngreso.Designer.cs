﻿namespace Core.Controles
{
    partial class ctlBusquedaFichasIngreso
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
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblEncabezado = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NavigationBusqueda = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.PageBusqueda = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.picBusqueda = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtBusqueda = new DevExpress.XtraEditors.TextEdit();
            this.PageVistaFichasIngreso = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gcVistasFichaIngreso = new DevExpress.XtraGrid.GridControl();
            this.dsVistas1 = new Core.DataSets.dsVistas();
            this.gvVistasFichaIngreso = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_colaborador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_colaborador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_identidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcelular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBusqueda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdVerFicha = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdIrAtras = new DevExpress.XtraEditors.PictureEdit();
            this.NavegacionPrincipal = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.PageBusquedas = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.PageFichaIngreso = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ctlVistaFichaIngreso1 = new Core.Controles.ctlVistaFichaIngreso();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavigationBusqueda)).BeginInit();
            this.NavigationBusqueda.SuspendLayout();
            this.PageBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBusqueda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBusqueda.Properties)).BeginInit();
            this.PageVistaFichasIngreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcVistasFichaIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVistas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVistasFichaIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerFicha)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdIrAtras.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavegacionPrincipal)).BeginInit();
            this.NavegacionPrincipal.SuspendLayout();
            this.PageBusquedas.SuspendLayout();
            this.PageFichaIngreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.lblEncabezado);
            this.pnlEncabezado.Controls.Add(this.panel2);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(988, 75);
            this.pnlEncabezado.TabIndex = 18;
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
            this.lblEncabezado.Size = new System.Drawing.Size(988, 75);
            this.lblEncabezado.TabIndex = 9;
            this.lblEncabezado.Text = "Consulta Fichas de Ingreso";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.panel2.Location = new System.Drawing.Point(50, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 10);
            this.panel2.TabIndex = 19;
            // 
            // NavigationBusqueda
            // 
            this.NavigationBusqueda.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.NavigationBusqueda.Controls.Add(this.PageBusqueda);
            this.NavigationBusqueda.Controls.Add(this.PageVistaFichasIngreso);
            this.NavigationBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationBusqueda.Location = new System.Drawing.Point(0, 0);
            this.NavigationBusqueda.Name = "NavigationBusqueda";
            this.NavigationBusqueda.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.PageBusqueda,
            this.PageVistaFichasIngreso});
            this.NavigationBusqueda.SelectedPage = this.PageBusqueda;
            this.NavigationBusqueda.Size = new System.Drawing.Size(988, 772);
            this.NavigationBusqueda.TabIndex = 20;
            this.NavigationBusqueda.TransitionAnimationProperties.FrameCount = 500;
            this.NavigationBusqueda.TransitionAnimationProperties.FrameInterval = 500;
            // 
            // PageBusqueda
            // 
            this.PageBusqueda.Controls.Add(this.picBusqueda);
            this.PageBusqueda.Controls.Add(this.labelControl2);
            this.PageBusqueda.Controls.Add(this.txtBusqueda);
            this.PageBusqueda.Name = "PageBusqueda";
            this.PageBusqueda.Size = new System.Drawing.Size(988, 772);
            // 
            // picBusqueda
            // 
            this.picBusqueda.EditValue = global::Core.Properties.Resources.iconBusqueda;
            this.picBusqueda.Location = new System.Drawing.Point(745, 205);
            this.picBusqueda.Name = "picBusqueda";
            this.picBusqueda.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picBusqueda.Properties.NullText = "   ";
            this.picBusqueda.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picBusqueda.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picBusqueda.Size = new System.Drawing.Size(80, 82);
            this.picBusqueda.TabIndex = 18;
            this.picBusqueda.ToolTip = "Siguiente Página (F2)\r\n";
            this.picBusqueda.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.picBusqueda.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.picBusqueda.ToolTipTitle = "Arca de los Tesoros";
            this.picBusqueda.Click += new System.EventHandler(this.PicBusqueda_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(117, 132);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(251, 45);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "Filtro de Consulta:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.EnterMoveNextControl = true;
            this.txtBusqueda.Location = new System.Drawing.Point(117, 206);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Properties.Appearance.Options.UseFont = true;
            this.txtBusqueda.Properties.AutoHeight = false;
            this.txtBusqueda.Size = new System.Drawing.Size(600, 81);
            this.txtBusqueda.TabIndex = 14;
            // 
            // PageVistaFichasIngreso
            // 
            this.PageVistaFichasIngreso.Caption = "PageVistaFichasIngreso";
            this.PageVistaFichasIngreso.Controls.Add(this.gcVistasFichaIngreso);
            this.PageVistaFichasIngreso.Controls.Add(this.panel1);
            this.PageVistaFichasIngreso.Name = "PageVistaFichasIngreso";
            this.PageVistaFichasIngreso.Size = new System.Drawing.Size(988, 772);
            // 
            // gcVistasFichaIngreso
            // 
            this.gcVistasFichaIngreso.DataMember = "dtVistasFichaIngreso";
            this.gcVistasFichaIngreso.DataSource = this.dsVistas1;
            this.gcVistasFichaIngreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcVistasFichaIngreso.Location = new System.Drawing.Point(0, 78);
            this.gcVistasFichaIngreso.MainView = this.gvVistasFichaIngreso;
            this.gcVistasFichaIngreso.Name = "gcVistasFichaIngreso";
            this.gcVistasFichaIngreso.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdVerFicha});
            this.gcVistasFichaIngreso.Size = new System.Drawing.Size(988, 694);
            this.gcVistasFichaIngreso.TabIndex = 1;
            this.gcVistasFichaIngreso.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVistasFichaIngreso});
            // 
            // dsVistas1
            // 
            this.dsVistas1.DataSetName = "dsVistas";
            this.dsVistas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvVistasFichaIngreso
            // 
            this.gvVistasFichaIngreso.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvVistasFichaIngreso.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvVistasFichaIngreso.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvVistasFichaIngreso.Appearance.Row.Options.UseFont = true;
            this.gvVistasFichaIngreso.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_colaborador,
            this.colnombre_colaborador,
            this.colnumero_identidad,
            this.colcelular,
            this.colBusqueda});
            this.gvVistasFichaIngreso.GridControl = this.gcVistasFichaIngreso;
            this.gvVistasFichaIngreso.Name = "gvVistasFichaIngreso";
            this.gvVistasFichaIngreso.OptionsView.ShowGroupPanel = false;
            this.gvVistasFichaIngreso.OptionsView.ShowIndicator = false;
            // 
            // colid_colaborador
            // 
            this.colid_colaborador.FieldName = "id_colaborador";
            this.colid_colaborador.MinWidth = 25;
            this.colid_colaborador.Name = "colid_colaborador";
            this.colid_colaborador.Width = 94;
            // 
            // colnombre_colaborador
            // 
            this.colnombre_colaborador.Caption = "Nombre Completo";
            this.colnombre_colaborador.FieldName = "nombre_colaborador";
            this.colnombre_colaborador.MinWidth = 25;
            this.colnombre_colaborador.Name = "colnombre_colaborador";
            this.colnombre_colaborador.Visible = true;
            this.colnombre_colaborador.VisibleIndex = 0;
            this.colnombre_colaborador.Width = 421;
            // 
            // colnumero_identidad
            // 
            this.colnumero_identidad.Caption = "N° Identidad";
            this.colnumero_identidad.FieldName = "numero_identidad";
            this.colnumero_identidad.MinWidth = 25;
            this.colnumero_identidad.Name = "colnumero_identidad";
            this.colnumero_identidad.Visible = true;
            this.colnumero_identidad.VisibleIndex = 1;
            this.colnumero_identidad.Width = 218;
            // 
            // colcelular
            // 
            this.colcelular.Caption = "Celular";
            this.colcelular.FieldName = "celular";
            this.colcelular.MinWidth = 25;
            this.colcelular.Name = "colcelular";
            this.colcelular.Visible = true;
            this.colcelular.VisibleIndex = 2;
            this.colcelular.Width = 273;
            // 
            // colBusqueda
            // 
            this.colBusqueda.Caption = " ";
            this.colBusqueda.ColumnEdit = this.cmdVerFicha;
            this.colBusqueda.MinWidth = 25;
            this.colBusqueda.Name = "colBusqueda";
            this.colBusqueda.Visible = true;
            this.colBusqueda.VisibleIndex = 3;
            this.colBusqueda.Width = 71;
            // 
            // cmdVerFicha
            // 
            this.cmdVerFicha.AutoHeight = false;
            editorButtonImageOptions2.Image = global::Core.Properties.Resources.iconBusqueda_32;
            this.cmdVerFicha.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdVerFicha.Name = "cmdVerFicha";
            this.cmdVerFicha.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdVerFicha.Click += new System.EventHandler(this.CmdVerFicha_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdIrAtras);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 78);
            this.panel1.TabIndex = 0;
            // 
            // cmdIrAtras
            // 
            this.cmdIrAtras.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdIrAtras.EditValue = global::Core.Properties.Resources.icon_atras_64;
            this.cmdIrAtras.Location = new System.Drawing.Point(0, 0);
            this.cmdIrAtras.Name = "cmdIrAtras";
            this.cmdIrAtras.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdIrAtras.Properties.NullText = "   ";
            this.cmdIrAtras.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdIrAtras.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdIrAtras.Size = new System.Drawing.Size(80, 78);
            this.cmdIrAtras.TabIndex = 19;
            this.cmdIrAtras.ToolTip = "Siguiente Página (F2)\r\n";
            this.cmdIrAtras.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.cmdIrAtras.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cmdIrAtras.ToolTipTitle = "Arca de los Tesoros";
            this.cmdIrAtras.Click += new System.EventHandler(this.CmdIrAtras_Click);
            // 
            // NavegacionPrincipal
            // 
            this.NavegacionPrincipal.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.NavegacionPrincipal.Controls.Add(this.PageBusquedas);
            this.NavegacionPrincipal.Controls.Add(this.PageFichaIngreso);
            this.NavegacionPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavegacionPrincipal.Location = new System.Drawing.Point(5, 5);
            this.NavegacionPrincipal.Name = "NavegacionPrincipal";
            this.NavegacionPrincipal.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.PageBusquedas,
            this.PageFichaIngreso});
            this.NavegacionPrincipal.SelectedPage = this.PageFichaIngreso;
            this.NavegacionPrincipal.Size = new System.Drawing.Size(988, 772);
            this.NavegacionPrincipal.TabIndex = 21;
            this.NavegacionPrincipal.Text = "navigationFrame1";
            // 
            // PageBusquedas
            // 
            this.PageBusquedas.Controls.Add(this.panel3);
            this.PageBusquedas.Controls.Add(this.pnlEncabezado);
            this.PageBusquedas.Controls.Add(this.NavigationBusqueda);
            this.PageBusquedas.Name = "PageBusquedas";
            this.PageBusquedas.Size = new System.Drawing.Size(988, 772);
            // 
            // PageFichaIngreso
            // 
            this.PageFichaIngreso.Controls.Add(this.ctlVistaFichaIngreso1);
            this.PageFichaIngreso.Name = "PageFichaIngreso";
            this.PageFichaIngreso.Size = new System.Drawing.Size(988, 772);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(988, 10);
            this.panel3.TabIndex = 21;
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
            this.ctlVistaFichaIngreso1.Size = new System.Drawing.Size(988, 772);
            this.ctlVistaFichaIngreso1.TabIndex = 0;
            // 
            // ctlBusquedaFichasIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.NavegacionPrincipal);
            this.Name = "ctlBusquedaFichasIngreso";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(998, 782);
            this.pnlEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NavigationBusqueda)).EndInit();
            this.NavigationBusqueda.ResumeLayout(false);
            this.PageBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBusqueda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBusqueda.Properties)).EndInit();
            this.PageVistaFichasIngreso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcVistasFichaIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVistas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVistasFichaIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerFicha)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdIrAtras.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavegacionPrincipal)).EndInit();
            this.NavegacionPrincipal.ResumeLayout(false);
            this.PageBusquedas.ResumeLayout(false);
            this.PageFichaIngreso.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private DevExpress.XtraEditors.LabelControl lblEncabezado;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraBars.Navigation.NavigationFrame NavigationBusqueda;
        private DevExpress.XtraBars.Navigation.NavigationPage PageBusqueda;
        private DevExpress.XtraBars.Navigation.NavigationPage PageVistaFichasIngreso;
        private DevExpress.XtraEditors.TextEdit txtBusqueda;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PictureEdit picBusqueda;
        private DevExpress.XtraGrid.GridControl gcVistasFichaIngreso;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVistasFichaIngreso;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PictureEdit cmdIrAtras;
        private DataSets.dsVistas dsVistas1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_colaborador;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_colaborador;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_identidad;
        private DevExpress.XtraGrid.Columns.GridColumn colcelular;
        private DevExpress.XtraGrid.Columns.GridColumn colBusqueda;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdVerFicha;
        private DevExpress.XtraBars.Navigation.NavigationFrame NavegacionPrincipal;
        private DevExpress.XtraBars.Navigation.NavigationPage PageBusquedas;
        private DevExpress.XtraBars.Navigation.NavigationPage PageFichaIngreso;
        private System.Windows.Forms.Panel panel3;
        private ctlVistaFichaIngreso ctlVistaFichaIngreso1;
    }
}
