namespace Core.Controles
{
    partial class ctlCrearUsuario
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
            this.picCerrar = new DevExpress.XtraEditors.PictureEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bsCargos = new System.Windows.Forms.BindingSource(this.components);
            this.dsConfiguracion1 = new Core.DataSets.dsConfiguracion();
            this.NavegacionPrincipal = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.PageCreacionUsuario = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.cmdGuardarUsuario = new DevExpress.XtraEditors.SimpleButton();
            this.cmdReeestablecerContrasenia = new DevExpress.XtraEditors.SimpleButton();
            this.glPerfilUsuario = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gvPaises = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.lblEtiquetaUsuario = new DevExpress.XtraEditors.LabelControl();
            this.pageReestablecerContrasenia = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.cmdReestablecerContrasenia = new DevExpress.XtraEditors.SimpleButton();
            this.txtContraseniaTemporal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_cargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCargos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConfiguracion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavegacionPrincipal)).BeginInit();
            this.NavegacionPrincipal.SuspendLayout();
            this.PageCreacionUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glPerfilUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPaises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            this.pageReestablecerContrasenia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContraseniaTemporal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.lblEncabezado);
            this.pnlEncabezado.Controls.Add(this.picCerrar);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(5, 5);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(706, 58);
            this.pnlEncabezado.TabIndex = 0;
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
            this.lblEncabezado.Size = new System.Drawing.Size(639, 58);
            this.lblEncabezado.TabIndex = 10;
            this.lblEncabezado.Text = "Informacion Usuario";
            // 
            // picCerrar
            // 
            this.picCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.picCerrar.EditValue = global::Core.Properties.Resources.iconCerrar_32;
            this.picCerrar.Location = new System.Drawing.Point(639, 0);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Properties.AllowFocused = false;
            this.picCerrar.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.picCerrar.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.picCerrar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picCerrar.Properties.NullText = " ";
            this.picCerrar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picCerrar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picCerrar.Size = new System.Drawing.Size(67, 58);
            this.picCerrar.TabIndex = 16;
            this.picCerrar.ToolTip = "Guardar Cambios\r\n";
            this.picCerrar.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.picCerrar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.picCerrar.ToolTipTitle = "Arca de los Tesoros";
            this.picCerrar.Click += new System.EventHandler(this.PicCerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(706, 5);
            this.panel2.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(5, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(706, 10);
            this.panel4.TabIndex = 19;
            // 
            // bsCargos
            // 
            this.bsCargos.DataMember = "dtCargos";
            this.bsCargos.DataSource = this.dsConfiguracion1;
            // 
            // dsConfiguracion1
            // 
            this.dsConfiguracion1.DataSetName = "dsConfiguracion";
            this.dsConfiguracion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NavegacionPrincipal
            // 
            this.NavegacionPrincipal.Appearance.BackColor = System.Drawing.Color.White;
            this.NavegacionPrincipal.Appearance.Options.UseBackColor = true;
            this.NavegacionPrincipal.Controls.Add(this.PageCreacionUsuario);
            this.NavegacionPrincipal.Controls.Add(this.pageReestablecerContrasenia);
            this.NavegacionPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavegacionPrincipal.Location = new System.Drawing.Point(5, 78);
            this.NavegacionPrincipal.LookAndFeel.UseDefaultLookAndFeel = false;
            this.NavegacionPrincipal.Name = "NavegacionPrincipal";
            this.NavegacionPrincipal.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.PageCreacionUsuario,
            this.pageReestablecerContrasenia});
            this.NavegacionPrincipal.SelectedPage = this.PageCreacionUsuario;
            this.NavegacionPrincipal.Size = new System.Drawing.Size(706, 292);
            this.NavegacionPrincipal.TabIndex = 20;
            this.NavegacionPrincipal.Text = "navigationFrame1";
            this.NavegacionPrincipal.TransitionAnimationProperties.FrameCount = 500;
            this.NavegacionPrincipal.TransitionAnimationProperties.FrameInterval = 500;
            // 
            // PageCreacionUsuario
            // 
            this.PageCreacionUsuario.Controls.Add(this.cmdGuardarUsuario);
            this.PageCreacionUsuario.Controls.Add(this.cmdReeestablecerContrasenia);
            this.PageCreacionUsuario.Controls.Add(this.glPerfilUsuario);
            this.PageCreacionUsuario.Controls.Add(this.labelControl1);
            this.PageCreacionUsuario.Controls.Add(this.txtUsuario);
            this.PageCreacionUsuario.Controls.Add(this.lblEtiquetaUsuario);
            this.PageCreacionUsuario.LookAndFeel.UseDefaultLookAndFeel = false;
            this.PageCreacionUsuario.Name = "PageCreacionUsuario";
            this.PageCreacionUsuario.Size = new System.Drawing.Size(706, 292);
            // 
            // cmdGuardarUsuario
            // 
            this.cmdGuardarUsuario.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.cmdGuardarUsuario.Appearance.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardarUsuario.Appearance.ForeColor = System.Drawing.Color.White;
            this.cmdGuardarUsuario.Appearance.Options.UseBackColor = true;
            this.cmdGuardarUsuario.Appearance.Options.UseFont = true;
            this.cmdGuardarUsuario.Appearance.Options.UseForeColor = true;
            this.cmdGuardarUsuario.ImageOptions.Image = global::Core.Properties.Resources.icon_guardar_negro_64;
            this.cmdGuardarUsuario.Location = new System.Drawing.Point(300, 183);
            this.cmdGuardarUsuario.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.cmdGuardarUsuario.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdGuardarUsuario.Name = "cmdGuardarUsuario";
            this.cmdGuardarUsuario.Size = new System.Drawing.Size(373, 90);
            this.cmdGuardarUsuario.TabIndex = 53;
            this.cmdGuardarUsuario.Text = "Crear Usuario";
            this.cmdGuardarUsuario.Click += new System.EventHandler(this.CmdGuardarUsuario_Click);
            // 
            // cmdReeestablecerContrasenia
            // 
            this.cmdReeestablecerContrasenia.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReeestablecerContrasenia.Appearance.Options.UseFont = true;
            this.cmdReeestablecerContrasenia.Location = new System.Drawing.Point(300, 214);
            this.cmdReeestablecerContrasenia.Name = "cmdReeestablecerContrasenia";
            this.cmdReeestablecerContrasenia.Size = new System.Drawing.Size(226, 41);
            this.cmdReeestablecerContrasenia.TabIndex = 54;
            this.cmdReeestablecerContrasenia.Text = "Reestablecer Contraseña";
            this.cmdReeestablecerContrasenia.Click += new System.EventHandler(this.CmdReeestablecerContrasenia_Click);
            // 
            // glPerfilUsuario
            // 
            this.glPerfilUsuario.EditValue = "";
            this.glPerfilUsuario.Location = new System.Drawing.Point(300, 91);
            this.glPerfilUsuario.Name = "glPerfilUsuario";
            this.glPerfilUsuario.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glPerfilUsuario.Properties.Appearance.Options.UseFont = true;
            this.glPerfilUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glPerfilUsuario.Properties.DataSource = this.bsCargos;
            this.glPerfilUsuario.Properties.DisplayMember = "descripcion";
            this.glPerfilUsuario.Properties.PopupView = this.gvPaises;
            this.glPerfilUsuario.Properties.ValueMember = "id_cargo";
            this.glPerfilUsuario.Size = new System.Drawing.Size(373, 38);
            this.glPerfilUsuario.TabIndex = 52;
            // 
            // gvPaises
            // 
            this.gvPaises.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPaises.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvPaises.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPaises.Appearance.Row.Options.UseFont = true;
            this.gvPaises.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion,
            this.colid_cargo});
            this.gvPaises.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvPaises.Name = "gvPaises";
            this.gvPaises.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvPaises.OptionsView.ShowColumnHeaders = false;
            this.gvPaises.OptionsView.ShowGroupPanel = false;
            this.gvPaises.OptionsView.ShowIndicator = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(29, 94);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(244, 45);
            this.labelControl1.TabIndex = 51;
            this.labelControl1.Text = "Perfil:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.EnterMoveNextControl = true;
            this.txtUsuario.Location = new System.Drawing.Point(300, 31);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtUsuario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtUsuario.Size = new System.Drawing.Size(373, 38);
            this.txtUsuario.TabIndex = 50;
            // 
            // lblEtiquetaUsuario
            // 
            this.lblEtiquetaUsuario.Appearance.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiquetaUsuario.Appearance.Options.UseFont = true;
            this.lblEtiquetaUsuario.Appearance.Options.UseTextOptions = true;
            this.lblEtiquetaUsuario.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lblEtiquetaUsuario.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblEtiquetaUsuario.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblEtiquetaUsuario.Location = new System.Drawing.Point(29, 34);
            this.lblEtiquetaUsuario.Name = "lblEtiquetaUsuario";
            this.lblEtiquetaUsuario.Size = new System.Drawing.Size(244, 35);
            this.lblEtiquetaUsuario.TabIndex = 49;
            this.lblEtiquetaUsuario.Text = "Usuario Sugerido:";
            // 
            // pageReestablecerContrasenia
            // 
            this.pageReestablecerContrasenia.Caption = "pageReestablecerContrasenia";
            this.pageReestablecerContrasenia.Controls.Add(this.cmdReestablecerContrasenia);
            this.pageReestablecerContrasenia.Controls.Add(this.txtContraseniaTemporal);
            this.pageReestablecerContrasenia.Controls.Add(this.labelControl3);
            this.pageReestablecerContrasenia.Name = "pageReestablecerContrasenia";
            this.pageReestablecerContrasenia.Size = new System.Drawing.Size(706, 292);
            // 
            // cmdReestablecerContrasenia
            // 
            this.cmdReestablecerContrasenia.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.cmdReestablecerContrasenia.Appearance.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReestablecerContrasenia.Appearance.ForeColor = System.Drawing.Color.White;
            this.cmdReestablecerContrasenia.Appearance.Options.UseBackColor = true;
            this.cmdReestablecerContrasenia.Appearance.Options.UseFont = true;
            this.cmdReestablecerContrasenia.Appearance.Options.UseForeColor = true;
            this.cmdReestablecerContrasenia.ImageOptions.Image = global::Core.Properties.Resources.icon_guardar_negro_64;
            this.cmdReestablecerContrasenia.Location = new System.Drawing.Point(79, 150);
            this.cmdReestablecerContrasenia.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.cmdReestablecerContrasenia.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdReestablecerContrasenia.Name = "cmdReestablecerContrasenia";
            this.cmdReestablecerContrasenia.Size = new System.Drawing.Size(471, 90);
            this.cmdReestablecerContrasenia.TabIndex = 54;
            this.cmdReestablecerContrasenia.Text = "Reestablecer Contraseña";
            this.cmdReestablecerContrasenia.Click += new System.EventHandler(this.CmdReestablecerContrasenia_Click);
            // 
            // txtContraseniaTemporal
            // 
            this.txtContraseniaTemporal.EnterMoveNextControl = true;
            this.txtContraseniaTemporal.Location = new System.Drawing.Point(79, 75);
            this.txtContraseniaTemporal.Name = "txtContraseniaTemporal";
            this.txtContraseniaTemporal.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseniaTemporal.Properties.Appearance.Options.UseFont = true;
            this.txtContraseniaTemporal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtContraseniaTemporal.Size = new System.Drawing.Size(471, 38);
            this.txtContraseniaTemporal.TabIndex = 52;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(79, 24);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(305, 45);
            this.labelControl3.TabIndex = 51;
            this.labelControl3.Text = "Contraseña Temporal:";
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Perfil";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.OptionsColumn.AllowFocus = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // colid_cargo
            // 
            this.colid_cargo.Caption = "ID Perfil";
            this.colid_cargo.FieldName = "id_cargo";
            this.colid_cargo.Name = "colid_cargo";
            this.colid_cargo.OptionsColumn.AllowEdit = false;
            this.colid_cargo.OptionsColumn.AllowFocus = false;
            this.colid_cargo.Visible = true;
            this.colid_cargo.VisibleIndex = 1;
            // 
            // ctlCrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.NavegacionPrincipal);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlEncabezado);
            this.Name = "ctlCrearUsuario";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(716, 375);
            this.pnlEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCargos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConfiguracion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavegacionPrincipal)).EndInit();
            this.NavegacionPrincipal.ResumeLayout(false);
            this.PageCreacionUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.glPerfilUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPaises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            this.pageReestablecerContrasenia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtContraseniaTemporal.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private DevExpress.XtraEditors.LabelControl lblEncabezado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.PictureEdit picCerrar;
        private System.Windows.Forms.BindingSource bsCargos;
        private DataSets.dsConfiguracion dsConfiguracion1;
        private DevExpress.XtraBars.Navigation.NavigationFrame NavegacionPrincipal;
        private DevExpress.XtraBars.Navigation.NavigationPage PageCreacionUsuario;
        private DevExpress.XtraEditors.SimpleButton cmdReeestablecerContrasenia;
        private DevExpress.XtraEditors.SimpleButton cmdGuardarUsuario;
        private DevExpress.XtraEditors.GridLookUpEdit glPerfilUsuario;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPaises;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.LabelControl lblEtiquetaUsuario;
        private DevExpress.XtraBars.Navigation.NavigationPage pageReestablecerContrasenia;
        private DevExpress.XtraEditors.TextEdit txtContraseniaTemporal;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton cmdReestablecerContrasenia;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_cargo;
    }
}
