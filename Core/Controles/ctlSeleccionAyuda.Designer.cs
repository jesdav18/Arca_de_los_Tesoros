namespace Core.Controles
{
    partial class ctlSeleccionAyuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlSeleccionAyuda));
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.NavigationEncabezado = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.PageEncabezadoApilado = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lblTituloApilado = new DevExpress.XtraEditors.LabelControl();
            this.picTituloApilado = new DevExpress.XtraEditors.PictureEdit();
            this.PageEncabezadoOriginal = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lblEncabezado = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBusqueda = new DevExpress.XtraEditors.TextEdit();
            this.cmdGuardarSolicitud = new DevExpress.XtraEditors.PictureEdit();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gcMaestrosDisponibles = new DevExpress.XtraGrid.GridControl();
            this.dsCoordinadoresEdad1 = new Core.DataSet.dsCoordinadoresEdad();
            this.gvMestrosDisponibles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_colaborador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_identidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colesta_en_lista = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkEstaEnLista = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colseleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavigationEncabezado)).BeginInit();
            this.NavigationEncabezado.SuspendLayout();
            this.PageEncabezadoApilado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTituloApilado.Properties)).BeginInit();
            this.PageEncabezadoOriginal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBusqueda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdGuardarSolicitud.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMaestrosDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCoordinadoresEdad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMestrosDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstaEnLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSeleccionar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.NavigationEncabezado);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(5, 5);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(875, 53);
            this.pnlEncabezado.TabIndex = 13;
            // 
            // NavigationEncabezado
            // 
            this.NavigationEncabezado.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.NavigationEncabezado.Controls.Add(this.PageEncabezadoApilado);
            this.NavigationEncabezado.Controls.Add(this.PageEncabezadoOriginal);
            this.NavigationEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationEncabezado.Location = new System.Drawing.Point(0, 0);
            this.NavigationEncabezado.Name = "NavigationEncabezado";
            this.NavigationEncabezado.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.PageEncabezadoOriginal,
            this.PageEncabezadoApilado});
            this.NavigationEncabezado.SelectedPage = this.PageEncabezadoOriginal;
            this.NavigationEncabezado.Size = new System.Drawing.Size(875, 53);
            this.NavigationEncabezado.TabIndex = 0;
            this.NavigationEncabezado.TransitionAnimationProperties.FrameCount = 500;
            this.NavigationEncabezado.TransitionAnimationProperties.FrameInterval = 500;
            // 
            // PageEncabezadoApilado
            // 
            this.PageEncabezadoApilado.Caption = "PageEncabezadoApilado";
            this.PageEncabezadoApilado.Controls.Add(this.lblTituloApilado);
            this.PageEncabezadoApilado.Controls.Add(this.picTituloApilado);
            this.PageEncabezadoApilado.Name = "PageEncabezadoApilado";
            this.PageEncabezadoApilado.Size = new System.Drawing.Size(875, 53);
            // 
            // lblTituloApilado
            // 
            this.lblTituloApilado.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.lblTituloApilado.Appearance.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloApilado.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblTituloApilado.Appearance.Options.UseBackColor = true;
            this.lblTituloApilado.Appearance.Options.UseFont = true;
            this.lblTituloApilado.Appearance.Options.UseForeColor = true;
            this.lblTituloApilado.Appearance.Options.UseTextOptions = true;
            this.lblTituloApilado.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTituloApilado.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblTituloApilado.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTituloApilado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTituloApilado.Location = new System.Drawing.Point(49, 0);
            this.lblTituloApilado.Name = "lblTituloApilado";
            this.lblTituloApilado.Size = new System.Drawing.Size(826, 53);
            this.lblTituloApilado.TabIndex = 10;
            this.lblTituloApilado.Text = "Buscar en listado de Ayudas";
            this.lblTituloApilado.Click += new System.EventHandler(this.PicTituloApilado_Click);
            // 
            // picTituloApilado
            // 
            this.picTituloApilado.Dock = System.Windows.Forms.DockStyle.Left;
            this.picTituloApilado.EditValue = global::Core.Properties.Resources.iconBusqueda_32;
            this.picTituloApilado.Location = new System.Drawing.Point(0, 0);
            this.picTituloApilado.Name = "picTituloApilado";
            this.picTituloApilado.Properties.AllowFocused = false;
            this.picTituloApilado.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.picTituloApilado.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.picTituloApilado.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.picTituloApilado.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picTituloApilado.Properties.NullText = "   ";
            this.picTituloApilado.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picTituloApilado.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picTituloApilado.Size = new System.Drawing.Size(49, 53);
            this.picTituloApilado.TabIndex = 31;
            this.picTituloApilado.Click += new System.EventHandler(this.PicTituloApilado_Click);
            // 
            // PageEncabezadoOriginal
            // 
            this.PageEncabezadoOriginal.Caption = "PageEncabezadoOriginal";
            this.PageEncabezadoOriginal.Controls.Add(this.lblEncabezado);
            this.PageEncabezadoOriginal.Controls.Add(this.panel2);
            this.PageEncabezadoOriginal.Name = "PageEncabezadoOriginal";
            this.PageEncabezadoOriginal.Size = new System.Drawing.Size(875, 53);
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
            this.lblEncabezado.Size = new System.Drawing.Size(875, 51);
            this.lblEncabezado.TabIndex = 9;
            this.lblEncabezado.Text = "Seleccion Ayudas día X";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 2);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(5, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(875, 30);
            this.panel3.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBusqueda);
            this.panel1.Controls.Add(this.cmdGuardarSolicitud);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 88);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(875, 54);
            this.panel1.TabIndex = 22;
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
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(5, 142);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(875, 26);
            this.panel4.TabIndex = 23;
            // 
            // gcMaestrosDisponibles
            // 
            this.gcMaestrosDisponibles.DataMember = "dtAyudasDisponibles";
            this.gcMaestrosDisponibles.DataSource = this.dsCoordinadoresEdad1;
            this.gcMaestrosDisponibles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMaestrosDisponibles.Location = new System.Drawing.Point(5, 168);
            this.gcMaestrosDisponibles.MainView = this.gvMestrosDisponibles;
            this.gcMaestrosDisponibles.Name = "gcMaestrosDisponibles";
            this.gcMaestrosDisponibles.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chkEstaEnLista,
            this.chkSeleccionar});
            this.gcMaestrosDisponibles.Size = new System.Drawing.Size(875, 457);
            this.gcMaestrosDisponibles.TabIndex = 24;
            this.gcMaestrosDisponibles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMestrosDisponibles});
            // 
            // dsCoordinadoresEdad1
            // 
            this.dsCoordinadoresEdad1.DataSetName = "dsCoordinadoresEdad";
            this.dsCoordinadoresEdad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvMestrosDisponibles
            // 
            this.gvMestrosDisponibles.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMestrosDisponibles.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvMestrosDisponibles.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMestrosDisponibles.Appearance.Row.Options.UseFont = true;
            this.gvMestrosDisponibles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_colaborador,
            this.colnombre,
            this.colnumero_identidad,
            this.colesta_en_lista,
            this.colseleccionar});
            this.gvMestrosDisponibles.GridControl = this.gcMaestrosDisponibles;
            this.gvMestrosDisponibles.Name = "gvMestrosDisponibles";
            this.gvMestrosDisponibles.OptionsView.ShowGroupPanel = false;
            this.gvMestrosDisponibles.OptionsView.ShowIndicator = false;
            // 
            // colid_colaborador
            // 
            this.colid_colaborador.AppearanceHeader.Options.UseTextOptions = true;
            this.colid_colaborador.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
            this.colnombre.Width = 94;
            // 
            // colnumero_identidad
            // 
            this.colnumero_identidad.Caption = "Identidad";
            this.colnumero_identidad.FieldName = "numero_identidad";
            this.colnumero_identidad.MinWidth = 25;
            this.colnumero_identidad.Name = "colnumero_identidad";
            this.colnumero_identidad.Visible = true;
            this.colnumero_identidad.VisibleIndex = 0;
            this.colnumero_identidad.Width = 94;
            // 
            // colesta_en_lista
            // 
            this.colesta_en_lista.AppearanceHeader.Options.UseTextOptions = true;
            this.colesta_en_lista.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colesta_en_lista.Caption = "Esta en Lista";
            this.colesta_en_lista.ColumnEdit = this.chkEstaEnLista;
            this.colesta_en_lista.FieldName = "esta_en_lista";
            this.colesta_en_lista.MaxWidth = 150;
            this.colesta_en_lista.MinWidth = 150;
            this.colesta_en_lista.Name = "colesta_en_lista";
            this.colesta_en_lista.OptionsColumn.AllowEdit = false;
            this.colesta_en_lista.OptionsColumn.AllowFocus = false;
            this.colesta_en_lista.OptionsColumn.ReadOnly = true;
            this.colesta_en_lista.Visible = true;
            this.colesta_en_lista.VisibleIndex = 2;
            this.colesta_en_lista.Width = 150;
            // 
            // chkEstaEnLista
            // 
            this.chkEstaEnLista.AutoHeight = false;
            this.chkEstaEnLista.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom;
            this.chkEstaEnLista.ImageOptions.ImageChecked = ((System.Drawing.Image)(resources.GetObject("chkEstaEnLista.ImageOptions.ImageChecked")));
            this.chkEstaEnLista.ImageOptions.ImageUnchecked = ((System.Drawing.Image)(resources.GetObject("chkEstaEnLista.ImageOptions.ImageUnchecked")));
            this.chkEstaEnLista.Name = "chkEstaEnLista";
            // 
            // colseleccionar
            // 
            this.colseleccionar.Caption = "Seleccionar";
            this.colseleccionar.ColumnEdit = this.chkSeleccionar;
            this.colseleccionar.FieldName = "seleccionar";
            this.colseleccionar.MaxWidth = 130;
            this.colseleccionar.MinWidth = 130;
            this.colseleccionar.Name = "colseleccionar";
            this.colseleccionar.Visible = true;
            this.colseleccionar.VisibleIndex = 3;
            this.colseleccionar.Width = 130;
            // 
            // chkSeleccionar
            // 
            this.chkSeleccionar.AutoHeight = false;
            this.chkSeleccionar.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom;
            this.chkSeleccionar.ImageOptions.ImageChecked = global::Core.Properties.Resources.iconCheckVerde_24;
            this.chkSeleccionar.ImageOptions.ImageUnchecked = global::Core.Properties.Resources.iconMaloRojo_24;
            this.chkSeleccionar.Name = "chkSeleccionar";
            this.chkSeleccionar.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.ChkSeleccionar_EditValueChanging);
            // 
            // ctlSeleccionAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gcMaestrosDisponibles);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlEncabezado);
            this.Name = "ctlSeleccionAyuda";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(885, 630);
            this.pnlEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NavigationEncabezado)).EndInit();
            this.NavigationEncabezado.ResumeLayout(false);
            this.PageEncabezadoApilado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTituloApilado.Properties)).EndInit();
            this.PageEncabezadoOriginal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBusqueda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdGuardarSolicitud.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMaestrosDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCoordinadoresEdad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMestrosDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstaEnLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSeleccionar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private DevExpress.XtraEditors.LabelControl lblEncabezado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtBusqueda;
        private DevExpress.XtraEditors.PictureEdit cmdGuardarSolicitud;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraGrid.GridControl gcMaestrosDisponibles;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMestrosDisponibles;
        private DevExpress.XtraGrid.Columns.GridColumn colid_colaborador;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_identidad;
        private DataSet.dsCoordinadoresEdad dsCoordinadoresEdad1;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionar;
        private DevExpress.XtraBars.Navigation.NavigationFrame NavigationEncabezado;
        private DevExpress.XtraBars.Navigation.NavigationPage PageEncabezadoApilado;
        private DevExpress.XtraEditors.LabelControl lblTituloApilado;
        private DevExpress.XtraBars.Navigation.NavigationPage PageEncabezadoOriginal;
        private DevExpress.XtraEditors.PictureEdit picTituloApilado;
        private DevExpress.XtraGrid.Columns.GridColumn colesta_en_lista;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkEstaEnLista;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkSeleccionar;
    }
}
