namespace Anciano.Controles
{
    partial class ctlContenedorPrincipalAnciano
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
            this.ctlEncabezado1 = new Core.Controles.ctlEncabezado();
            this.pnlEncabezadoCoordinadoresEdad = new System.Windows.Forms.Panel();
            this.pnlCerrarSesion = new System.Windows.Forms.Panel();
            this.cmdCerrarSesion = new DevExpress.XtraEditors.PictureEdit();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.cmdBusqueda = new DevExpress.XtraEditors.PictureEdit();
            this.pnlAgregarFicha = new System.Windows.Forms.Panel();
            this.cmdCrearFichaIngreso = new DevExpress.XtraEditors.PictureEdit();
            this.pnlOrganizador = new System.Windows.Forms.Panel();
            this.cmdOrganizador = new DevExpress.XtraEditors.PictureEdit();
            this.pnlCumpleanios = new System.Windows.Forms.Panel();
            this.fusibleCumpleanios = new Core.Controles.ctlFusible();
            this.cmdCumpleanieros = new DevExpress.XtraEditors.PictureEdit();
            this.pnlSolicitudes = new System.Windows.Forms.Panel();
            this.fusibleSolicitudes = new Core.Controles.ctlFusible();
            this.cmdSolicitudes = new DevExpress.XtraEditors.PictureEdit();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NavegacionPrincipal = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.PageCumpleanieros = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ctlContenedorCumpleanieros1 = new Core.Controles.Cumpleanieros.ctlContenedorCumpleanieros();
            this.PageInicial = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pictureEdit6 = new DevExpress.XtraEditors.PictureEdit();
            this.PageOrganizador = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ctlPlanificadorActividades1 = new Core.Controles.ctlPlanificadorActividades();
            this.pageMiEquipo = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ctlMiEquipo1 = new Core.Controles.ctlMiEquipo();
            this.pageBusqueda = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ctlBusquedaFichasIngreso1 = new Core.Controles.ctlBusquedaFichasIngreso();
            this.PageSolicitudes = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ctlVistaFichaIngreso1 = new Core.Controles.ctlVistaFichaIngreso();
            this.ctlVistaSolicitudes1 = new Core.Controles.ctlVistaSolicitudes();
            this.PageCrearFichaIngreso = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ctlIngresoFicha1 = new Core.Controles.ctlIngresoFicha();
            this.bgObtenerFusibles = new System.ComponentModel.BackgroundWorker();
            this.tmrFusibles = new System.Windows.Forms.Timer(this.components);
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Anciano.Pantallas.frmEspera), true, true, typeof(System.Windows.Forms.UserControl));
            this.pnlEncabezado.SuspendLayout();
            this.pnlEncabezadoCoordinadoresEdad.SuspendLayout();
            this.pnlCerrarSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCerrarSesion.Properties)).BeginInit();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdBusqueda.Properties)).BeginInit();
            this.pnlAgregarFicha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCrearFichaIngreso.Properties)).BeginInit();
            this.pnlOrganizador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdOrganizador.Properties)).BeginInit();
            this.pnlCumpleanios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCumpleanieros.Properties)).BeginInit();
            this.pnlSolicitudes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdSolicitudes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavegacionPrincipal)).BeginInit();
            this.NavegacionPrincipal.SuspendLayout();
            this.PageCumpleanieros.SuspendLayout();
            this.PageInicial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).BeginInit();
            this.PageOrganizador.SuspendLayout();
            this.pageMiEquipo.SuspendLayout();
            this.pageBusqueda.SuspendLayout();
            this.PageSolicitudes.SuspendLayout();
            this.PageCrearFichaIngreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.ctlEncabezado1);
            this.pnlEncabezado.Controls.Add(this.pnlEncabezadoCoordinadoresEdad);
            this.pnlEncabezado.Controls.Add(this.panel4);
            this.pnlEncabezado.Controls.Add(this.panel3);
            this.pnlEncabezado.Controls.Add(this.panel1);
            this.pnlEncabezado.Controls.Add(this.panel2);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(5, 5);
            this.pnlEncabezado.MaximumSize = new System.Drawing.Size(0, 130);
            this.pnlEncabezado.MinimumSize = new System.Drawing.Size(0, 130);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1125, 130);
            this.pnlEncabezado.TabIndex = 6;
            // 
            // ctlEncabezado1
            // 
            this.ctlEncabezado1.BackColor = System.Drawing.Color.White;
            this.ctlEncabezado1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlEncabezado1.Location = new System.Drawing.Point(867, 3);
            this.ctlEncabezado1.MaximumSize = new System.Drawing.Size(0, 123);
            this.ctlEncabezado1.MinimumSize = new System.Drawing.Size(0, 123);
            this.ctlEncabezado1.Name = "ctlEncabezado1";
            this.ctlEncabezado1.Padding = new System.Windows.Forms.Padding(10);
            this.ctlEncabezado1.Size = new System.Drawing.Size(255, 123);
            this.ctlEncabezado1.TabIndex = 10;
            // 
            // pnlEncabezadoCoordinadoresEdad
            // 
            this.pnlEncabezadoCoordinadoresEdad.Controls.Add(this.pnlCerrarSesion);
            this.pnlEncabezadoCoordinadoresEdad.Controls.Add(this.pnlBusqueda);
            this.pnlEncabezadoCoordinadoresEdad.Controls.Add(this.pnlAgregarFicha);
            this.pnlEncabezadoCoordinadoresEdad.Controls.Add(this.pnlOrganizador);
            this.pnlEncabezadoCoordinadoresEdad.Controls.Add(this.pnlCumpleanios);
            this.pnlEncabezadoCoordinadoresEdad.Controls.Add(this.pnlSolicitudes);
            this.pnlEncabezadoCoordinadoresEdad.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEncabezadoCoordinadoresEdad.Location = new System.Drawing.Point(3, 3);
            this.pnlEncabezadoCoordinadoresEdad.Name = "pnlEncabezadoCoordinadoresEdad";
            this.pnlEncabezadoCoordinadoresEdad.Size = new System.Drawing.Size(864, 124);
            this.pnlEncabezadoCoordinadoresEdad.TabIndex = 2;
            // 
            // pnlCerrarSesion
            // 
            this.pnlCerrarSesion.Controls.Add(this.cmdCerrarSesion);
            this.pnlCerrarSesion.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCerrarSesion.Location = new System.Drawing.Point(715, 0);
            this.pnlCerrarSesion.Name = "pnlCerrarSesion";
            this.pnlCerrarSesion.Padding = new System.Windows.Forms.Padding(5);
            this.pnlCerrarSesion.Size = new System.Drawing.Size(143, 124);
            this.pnlCerrarSesion.TabIndex = 8;
            this.pnlCerrarSesion.Click += new System.EventHandler(this.PnlCerrarSesion_Click);
            // 
            // cmdCerrarSesion
            // 
            this.cmdCerrarSesion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdCerrarSesion.EditValue = global::Anciano.Properties.Resources.icon_cerrar_sesion_64;
            this.cmdCerrarSesion.Location = new System.Drawing.Point(5, 5);
            this.cmdCerrarSesion.Name = "cmdCerrarSesion";
            this.cmdCerrarSesion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdCerrarSesion.Properties.NullText = "   ";
            this.cmdCerrarSesion.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdCerrarSesion.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdCerrarSesion.Size = new System.Drawing.Size(133, 114);
            this.cmdCerrarSesion.TabIndex = 1;
            this.cmdCerrarSesion.ToolTip = "Cerrar Sesión\r\n";
            this.cmdCerrarSesion.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.cmdCerrarSesion.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cmdCerrarSesion.ToolTipTitle = "Arca de los Tesoros";
            this.cmdCerrarSesion.Click += new System.EventHandler(this.PnlCerrarSesion_Click);
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.cmdBusqueda);
            this.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBusqueda.Location = new System.Drawing.Point(572, 0);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Padding = new System.Windows.Forms.Padding(5);
            this.pnlBusqueda.Size = new System.Drawing.Size(143, 124);
            this.pnlBusqueda.TabIndex = 7;
            this.pnlBusqueda.Click += new System.EventHandler(this.PnlBusqueda_Click);
            // 
            // cmdBusqueda
            // 
            this.cmdBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdBusqueda.EditValue = global::Anciano.Properties.Resources.iconBusqueda;
            this.cmdBusqueda.Location = new System.Drawing.Point(5, 5);
            this.cmdBusqueda.Name = "cmdBusqueda";
            this.cmdBusqueda.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdBusqueda.Properties.NullText = "   ";
            this.cmdBusqueda.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdBusqueda.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdBusqueda.Size = new System.Drawing.Size(133, 114);
            this.cmdBusqueda.TabIndex = 1;
            this.cmdBusqueda.ToolTip = "Búsqueda";
            this.cmdBusqueda.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.cmdBusqueda.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cmdBusqueda.ToolTipTitle = "Arca de los Tesoros";
            this.cmdBusqueda.Click += new System.EventHandler(this.PnlBusqueda_Click);
            // 
            // pnlAgregarFicha
            // 
            this.pnlAgregarFicha.Controls.Add(this.cmdCrearFichaIngreso);
            this.pnlAgregarFicha.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAgregarFicha.Location = new System.Drawing.Point(429, 0);
            this.pnlAgregarFicha.Name = "pnlAgregarFicha";
            this.pnlAgregarFicha.Padding = new System.Windows.Forms.Padding(5);
            this.pnlAgregarFicha.Size = new System.Drawing.Size(143, 124);
            this.pnlAgregarFicha.TabIndex = 6;
            this.pnlAgregarFicha.Click += new System.EventHandler(this.PnlAgregarFicha_Click);
            // 
            // cmdCrearFichaIngreso
            // 
            this.cmdCrearFichaIngreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdCrearFichaIngreso.EditValue = global::Anciano.Properties.Resources.icon_nuevo_usuario_negro_64;
            this.cmdCrearFichaIngreso.Location = new System.Drawing.Point(5, 5);
            this.cmdCrearFichaIngreso.Name = "cmdCrearFichaIngreso";
            this.cmdCrearFichaIngreso.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdCrearFichaIngreso.Properties.NullText = "   ";
            this.cmdCrearFichaIngreso.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdCrearFichaIngreso.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdCrearFichaIngreso.Size = new System.Drawing.Size(133, 114);
            this.cmdCrearFichaIngreso.TabIndex = 2;
            this.cmdCrearFichaIngreso.ToolTip = "Cerrar Sesión\r\n";
            this.cmdCrearFichaIngreso.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.cmdCrearFichaIngreso.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cmdCrearFichaIngreso.ToolTipTitle = "Arca de los Tesoros";
            this.cmdCrearFichaIngreso.Click += new System.EventHandler(this.PnlAgregarFicha_Click);
            // 
            // pnlOrganizador
            // 
            this.pnlOrganizador.Controls.Add(this.cmdOrganizador);
            this.pnlOrganizador.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOrganizador.Location = new System.Drawing.Point(286, 0);
            this.pnlOrganizador.Name = "pnlOrganizador";
            this.pnlOrganizador.Padding = new System.Windows.Forms.Padding(5);
            this.pnlOrganizador.Size = new System.Drawing.Size(143, 124);
            this.pnlOrganizador.TabIndex = 2;
            this.pnlOrganizador.Click += new System.EventHandler(this.PnlOrganizador_Click);
            // 
            // cmdOrganizador
            // 
            this.cmdOrganizador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdOrganizador.EditValue = global::Anciano.Properties.Resources.icon_calendario_64;
            this.cmdOrganizador.Location = new System.Drawing.Point(5, 5);
            this.cmdOrganizador.Name = "cmdOrganizador";
            this.cmdOrganizador.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdOrganizador.Properties.NullText = "   ";
            this.cmdOrganizador.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdOrganizador.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdOrganizador.Size = new System.Drawing.Size(133, 114);
            this.cmdOrganizador.TabIndex = 2;
            this.cmdOrganizador.ToolTip = "Organizador";
            this.cmdOrganizador.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.cmdOrganizador.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cmdOrganizador.ToolTipTitle = "Arca de los Tesoros";
            this.cmdOrganizador.Click += new System.EventHandler(this.PnlOrganizador_Click);
            // 
            // pnlCumpleanios
            // 
            this.pnlCumpleanios.Controls.Add(this.fusibleCumpleanios);
            this.pnlCumpleanios.Controls.Add(this.cmdCumpleanieros);
            this.pnlCumpleanios.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCumpleanios.Location = new System.Drawing.Point(143, 0);
            this.pnlCumpleanios.Name = "pnlCumpleanios";
            this.pnlCumpleanios.Padding = new System.Windows.Forms.Padding(5);
            this.pnlCumpleanios.Size = new System.Drawing.Size(143, 124);
            this.pnlCumpleanios.TabIndex = 1;
            this.pnlCumpleanios.Click += new System.EventHandler(this.PnlCumpleanios_Click);
            // 
            // fusibleCumpleanios
            // 
            this.fusibleCumpleanios.BackColor = System.Drawing.Color.Transparent;
            this.fusibleCumpleanios.Location = new System.Drawing.Point(57, 46);
            this.fusibleCumpleanios.MaximumSize = new System.Drawing.Size(62, 57);
            this.fusibleCumpleanios.MinimumSize = new System.Drawing.Size(62, 57);
            this.fusibleCumpleanios.Name = "fusibleCumpleanios";
            this.fusibleCumpleanios.Pro_EsSecundario = false;
            this.fusibleCumpleanios.Pro_TipoColor = Core.Controles.ctlFusible.FUSIBLE_COLOR.DEFAULT;
            this.fusibleCumpleanios.Pro_Valor = 99;
            this.fusibleCumpleanios.Size = new System.Drawing.Size(62, 57);
            this.fusibleCumpleanios.TabIndex = 7;
            this.fusibleCumpleanios.OnClicFusible += new System.EventHandler(this.PnlCumpleanios_Click);
            // 
            // cmdCumpleanieros
            // 
            this.cmdCumpleanieros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdCumpleanieros.EditValue = global::Anciano.Properties.Resources.icon_Cumpleanieros;
            this.cmdCumpleanieros.Location = new System.Drawing.Point(5, 5);
            this.cmdCumpleanieros.Name = "cmdCumpleanieros";
            this.cmdCumpleanieros.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdCumpleanieros.Properties.NullText = "   ";
            this.cmdCumpleanieros.Properties.PictureAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCumpleanieros.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdCumpleanieros.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdCumpleanieros.Size = new System.Drawing.Size(133, 114);
            this.cmdCumpleanieros.TabIndex = 2;
            this.cmdCumpleanieros.ToolTip = "Cumpleañeros";
            this.cmdCumpleanieros.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.cmdCumpleanieros.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cmdCumpleanieros.ToolTipTitle = "Arca de los Tesoros";
            this.cmdCumpleanieros.Click += new System.EventHandler(this.PnlCumpleanios_Click);
            // 
            // pnlSolicitudes
            // 
            this.pnlSolicitudes.Controls.Add(this.fusibleSolicitudes);
            this.pnlSolicitudes.Controls.Add(this.cmdSolicitudes);
            this.pnlSolicitudes.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSolicitudes.Location = new System.Drawing.Point(0, 0);
            this.pnlSolicitudes.Name = "pnlSolicitudes";
            this.pnlSolicitudes.Padding = new System.Windows.Forms.Padding(5);
            this.pnlSolicitudes.Size = new System.Drawing.Size(143, 124);
            this.pnlSolicitudes.TabIndex = 0;
            this.pnlSolicitudes.Click += new System.EventHandler(this.PnlSolicitudes_Click);
            // 
            // fusibleSolicitudes
            // 
            this.fusibleSolicitudes.BackColor = System.Drawing.Color.Transparent;
            this.fusibleSolicitudes.Location = new System.Drawing.Point(51, 46);
            this.fusibleSolicitudes.MaximumSize = new System.Drawing.Size(62, 57);
            this.fusibleSolicitudes.MinimumSize = new System.Drawing.Size(62, 57);
            this.fusibleSolicitudes.Name = "fusibleSolicitudes";
            this.fusibleSolicitudes.Pro_EsSecundario = false;
            this.fusibleSolicitudes.Pro_TipoColor = Core.Controles.ctlFusible.FUSIBLE_COLOR.DEFAULT;
            this.fusibleSolicitudes.Pro_Valor = 99;
            this.fusibleSolicitudes.Size = new System.Drawing.Size(62, 57);
            this.fusibleSolicitudes.TabIndex = 8;
            this.fusibleSolicitudes.OnClicFusible += new System.EventHandler(this.PnlSolicitudes_Click);
            // 
            // cmdSolicitudes
            // 
            this.cmdSolicitudes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdSolicitudes.EditValue = global::Anciano.Properties.Resources.icon_Solicitudes;
            this.cmdSolicitudes.Location = new System.Drawing.Point(5, 5);
            this.cmdSolicitudes.Name = "cmdSolicitudes";
            this.cmdSolicitudes.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdSolicitudes.Properties.NullText = "   ";
            this.cmdSolicitudes.Properties.PictureAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSolicitudes.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdSolicitudes.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdSolicitudes.Size = new System.Drawing.Size(133, 114);
            this.cmdSolicitudes.TabIndex = 2;
            this.cmdSolicitudes.ToolTip = "Solicitudes";
            this.cmdSolicitudes.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.cmdSolicitudes.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cmdSolicitudes.ToolTipTitle = "Arca de los Tesoros";
            this.cmdSolicitudes.Click += new System.EventHandler(this.PnlSolicitudes_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1122, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 124);
            this.panel4.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 124);
            this.panel3.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 3);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1125, 3);
            this.panel2.TabIndex = 6;
            // 
            // NavegacionPrincipal
            // 
            this.NavegacionPrincipal.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.NavegacionPrincipal.Controls.Add(this.PageCumpleanieros);
            this.NavegacionPrincipal.Controls.Add(this.PageInicial);
            this.NavegacionPrincipal.Controls.Add(this.PageOrganizador);
            this.NavegacionPrincipal.Controls.Add(this.pageMiEquipo);
            this.NavegacionPrincipal.Controls.Add(this.pageBusqueda);
            this.NavegacionPrincipal.Controls.Add(this.PageSolicitudes);
            this.NavegacionPrincipal.Controls.Add(this.PageCrearFichaIngreso);
            this.NavegacionPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavegacionPrincipal.Location = new System.Drawing.Point(5, 135);
            this.NavegacionPrincipal.Name = "NavegacionPrincipal";
            this.NavegacionPrincipal.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.PageInicial,
            this.PageCumpleanieros,
            this.PageOrganizador,
            this.pageMiEquipo,
            this.pageBusqueda,
            this.PageSolicitudes,
            this.PageCrearFichaIngreso});
            this.NavegacionPrincipal.SelectedPage = this.PageInicial;
            this.NavegacionPrincipal.Size = new System.Drawing.Size(1125, 584);
            this.NavegacionPrincipal.TabIndex = 7;
            this.NavegacionPrincipal.Text = "navigationFrame1";
            this.NavegacionPrincipal.TransitionAnimationProperties.FrameCount = 500;
            this.NavegacionPrincipal.TransitionAnimationProperties.FrameInterval = 500;
            // 
            // PageCumpleanieros
            // 
            this.PageCumpleanieros.Caption = "PageCumpleanieros";
            this.PageCumpleanieros.Controls.Add(this.ctlContenedorCumpleanieros1);
            this.PageCumpleanieros.Name = "PageCumpleanieros";
            this.PageCumpleanieros.Size = new System.Drawing.Size(1125, 584);
            // 
            // ctlContenedorCumpleanieros1
            // 
            this.ctlContenedorCumpleanieros1.BackColor = System.Drawing.Color.White;
            this.ctlContenedorCumpleanieros1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlContenedorCumpleanieros1.Location = new System.Drawing.Point(0, 0);
            this.ctlContenedorCumpleanieros1.Name = "ctlContenedorCumpleanieros1";
            this.ctlContenedorCumpleanieros1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlContenedorCumpleanieros1.Pro_Conexion = null;
            this.ctlContenedorCumpleanieros1.Pro_Dia = null;
            this.ctlContenedorCumpleanieros1.Size = new System.Drawing.Size(1125, 584);
            this.ctlContenedorCumpleanieros1.TabIndex = 0;
            // 
            // PageInicial
            // 
            this.PageInicial.Caption = "PageInicial";
            this.PageInicial.Controls.Add(this.pictureEdit6);
            this.PageInicial.Name = "PageInicial";
            this.PageInicial.Size = new System.Drawing.Size(1125, 584);
            // 
            // pictureEdit6
            // 
            this.pictureEdit6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit6.EditValue = global::Anciano.Properties.Resources._62218400_2421805074506489_798898671931359232_n;
            this.pictureEdit6.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit6.Name = "pictureEdit6";
            this.pictureEdit6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit6.Properties.NullText = "   ";
            this.pictureEdit6.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit6.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit6.Size = new System.Drawing.Size(1125, 584);
            this.pictureEdit6.TabIndex = 2;
            // 
            // PageOrganizador
            // 
            this.PageOrganizador.Caption = "PageOrganizador";
            this.PageOrganizador.Controls.Add(this.ctlPlanificadorActividades1);
            this.PageOrganizador.Name = "PageOrganizador";
            this.PageOrganizador.Size = new System.Drawing.Size(1125, 584);
            // 
            // ctlPlanificadorActividades1
            // 
            this.ctlPlanificadorActividades1.BackColor = System.Drawing.Color.White;
            this.ctlPlanificadorActividades1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlPlanificadorActividades1.Location = new System.Drawing.Point(0, 0);
            this.ctlPlanificadorActividades1.Name = "ctlPlanificadorActividades1";
            this.ctlPlanificadorActividades1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlPlanificadorActividades1.Pro_Conexion = null;
            this.ctlPlanificadorActividades1.Pro_Usuario = null;
            this.ctlPlanificadorActividades1.ProFechaSeleccionada = new System.DateTime(((long)(0)));
            this.ctlPlanificadorActividades1.Size = new System.Drawing.Size(1125, 584);
            this.ctlPlanificadorActividades1.TabIndex = 0;
            // 
            // pageMiEquipo
            // 
            this.pageMiEquipo.Caption = "pageMiEquipo";
            this.pageMiEquipo.Controls.Add(this.ctlMiEquipo1);
            this.pageMiEquipo.Name = "pageMiEquipo";
            this.pageMiEquipo.Size = new System.Drawing.Size(1125, 584);
            // 
            // ctlMiEquipo1
            // 
            this.ctlMiEquipo1.BackColor = System.Drawing.Color.White;
            this.ctlMiEquipo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlMiEquipo1.Location = new System.Drawing.Point(0, 0);
            this.ctlMiEquipo1.Name = "ctlMiEquipo1";
            this.ctlMiEquipo1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlMiEquipo1.Pro_Conexion = null;
            this.ctlMiEquipo1.Pro_Usuario = null;
            this.ctlMiEquipo1.Size = new System.Drawing.Size(1125, 584);
            this.ctlMiEquipo1.TabIndex = 0;
            // 
            // pageBusqueda
            // 
            this.pageBusqueda.Caption = "pageBusqueda";
            this.pageBusqueda.Controls.Add(this.ctlBusquedaFichasIngreso1);
            this.pageBusqueda.Name = "pageBusqueda";
            this.pageBusqueda.Size = new System.Drawing.Size(1125, 584);
            // 
            // ctlBusquedaFichasIngreso1
            // 
            this.ctlBusquedaFichasIngreso1.BackColor = System.Drawing.Color.White;
            this.ctlBusquedaFichasIngreso1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlBusquedaFichasIngreso1.Location = new System.Drawing.Point(0, 0);
            this.ctlBusquedaFichasIngreso1.Name = "ctlBusquedaFichasIngreso1";
            this.ctlBusquedaFichasIngreso1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlBusquedaFichasIngreso1.Pro_Conexion = null;
            this.ctlBusquedaFichasIngreso1.Pro_Usuario = null;
            this.ctlBusquedaFichasIngreso1.Size = new System.Drawing.Size(1125, 584);
            this.ctlBusquedaFichasIngreso1.TabIndex = 0;
            // 
            // PageSolicitudes
            // 
            this.PageSolicitudes.Caption = "PageSolicitudes";
            this.PageSolicitudes.Controls.Add(this.ctlVistaFichaIngreso1);
            this.PageSolicitudes.Controls.Add(this.ctlVistaSolicitudes1);
            this.PageSolicitudes.Name = "PageSolicitudes";
            this.PageSolicitudes.Size = new System.Drawing.Size(1125, 584);
            // 
            // ctlVistaFichaIngreso1
            // 
            this.ctlVistaFichaIngreso1.BackColor = System.Drawing.Color.White;
            this.ctlVistaFichaIngreso1.Location = new System.Drawing.Point(437, 69);
            this.ctlVistaFichaIngreso1.Name = "ctlVistaFichaIngreso1";
            this.ctlVistaFichaIngreso1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlVistaFichaIngreso1.Pro_Conexion = null;
            this.ctlVistaFichaIngreso1.Pro_Credenciales = null;
            this.ctlVistaFichaIngreso1.Pro_EsCargaDatos = false;
            this.ctlVistaFichaIngreso1.Pro_ID_Colaborador = 0;
            this.ctlVistaFichaIngreso1.Pro_ModoEdicion = false;
            this.ctlVistaFichaIngreso1.Pro_Usuario = null;
            this.ctlVistaFichaIngreso1.Pro_UsuarioColaborador = null;
            this.ctlVistaFichaIngreso1.Size = new System.Drawing.Size(8, 144);
            this.ctlVistaFichaIngreso1.TabIndex = 1;
            // 
            // ctlVistaSolicitudes1
            // 
            this.ctlVistaSolicitudes1.BackColor = System.Drawing.Color.White;
            this.ctlVistaSolicitudes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlVistaSolicitudes1.Location = new System.Drawing.Point(0, 0);
            this.ctlVistaSolicitudes1.Name = "ctlVistaSolicitudes1";
            this.ctlVistaSolicitudes1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlVistaSolicitudes1.Pro_Conexion = null;
            this.ctlVistaSolicitudes1.Pro_Usuario = null;
            this.ctlVistaSolicitudes1.Size = new System.Drawing.Size(1125, 584);
            this.ctlVistaSolicitudes1.TabIndex = 0;
            // 
            // PageCrearFichaIngreso
            // 
            this.PageCrearFichaIngreso.Caption = "PageCrearFichaIngreso";
            this.PageCrearFichaIngreso.Controls.Add(this.ctlIngresoFicha1);
            this.PageCrearFichaIngreso.Name = "PageCrearFichaIngreso";
            this.PageCrearFichaIngreso.Size = new System.Drawing.Size(1125, 584);
            // 
            // ctlIngresoFicha1
            // 
            this.ctlIngresoFicha1.BackColor = System.Drawing.Color.White;
            this.ctlIngresoFicha1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlIngresoFicha1.Location = new System.Drawing.Point(0, 0);
            this.ctlIngresoFicha1.MinimumSize = new System.Drawing.Size(1166, 751);
            this.ctlIngresoFicha1.Name = "ctlIngresoFicha1";
            this.ctlIngresoFicha1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlIngresoFicha1.Pro_Credenciales = null;
            this.ctlIngresoFicha1.Pro_EstaCreandoFicha = false;
            this.ctlIngresoFicha1.Size = new System.Drawing.Size(1166, 751);
            this.ctlIngresoFicha1.TabIndex = 0;
            // 
            // bgObtenerFusibles
            // 
            this.bgObtenerFusibles.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgObtenerFusibles_DoWork);
            this.bgObtenerFusibles.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgObtenerFusibles_RunWorkerCompleted);
            // 
            // tmrFusibles
            // 
            this.tmrFusibles.Interval = 3000;
            this.tmrFusibles.Tick += new System.EventHandler(this.TmrFusibles_Tick);
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // ctlContenedorPrincipalAnciano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.NavegacionPrincipal);
            this.Controls.Add(this.pnlEncabezado);
            this.Name = "ctlContenedorPrincipalAnciano";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1135, 724);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezadoCoordinadoresEdad.ResumeLayout(false);
            this.pnlCerrarSesion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdCerrarSesion.Properties)).EndInit();
            this.pnlBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdBusqueda.Properties)).EndInit();
            this.pnlAgregarFicha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdCrearFichaIngreso.Properties)).EndInit();
            this.pnlOrganizador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdOrganizador.Properties)).EndInit();
            this.pnlCumpleanios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdCumpleanieros.Properties)).EndInit();
            this.pnlSolicitudes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdSolicitudes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavegacionPrincipal)).EndInit();
            this.NavegacionPrincipal.ResumeLayout(false);
            this.PageCumpleanieros.ResumeLayout(false);
            this.PageInicial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).EndInit();
            this.PageOrganizador.ResumeLayout(false);
            this.pageMiEquipo.ResumeLayout(false);
            this.pageBusqueda.ResumeLayout(false);
            this.PageSolicitudes.ResumeLayout(false);
            this.PageCrearFichaIngreso.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Panel pnlEncabezadoCoordinadoresEdad;
        private System.Windows.Forms.Panel pnlAgregarFicha;
        private System.Windows.Forms.Panel pnlOrganizador;
        private System.Windows.Forms.Panel pnlCumpleanios;
        private System.Windows.Forms.Panel pnlSolicitudes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.PictureEdit cmdSolicitudes;
        private DevExpress.XtraEditors.PictureEdit cmdCumpleanieros;
        private DevExpress.XtraEditors.PictureEdit cmdOrganizador;
        private DevExpress.XtraEditors.PictureEdit cmdCrearFichaIngreso;
        private Core.Controles.ctlEncabezado ctlEncabezado1;
        private System.Windows.Forms.Panel pnlBusqueda;
        private DevExpress.XtraEditors.PictureEdit cmdBusqueda;
        private System.Windows.Forms.Panel pnlCerrarSesion;
        private DevExpress.XtraEditors.PictureEdit cmdCerrarSesion;
        private Core.Controles.ctlFusible fusibleSolicitudes;
        private Core.Controles.ctlFusible fusibleCumpleanios;
        private DevExpress.XtraBars.Navigation.NavigationFrame NavegacionPrincipal;
        private DevExpress.XtraBars.Navigation.NavigationPage PageCumpleanieros;
        private Core.Controles.Cumpleanieros.ctlContenedorCumpleanieros ctlContenedorCumpleanieros1;
        private DevExpress.XtraBars.Navigation.NavigationPage PageInicial;
        private DevExpress.XtraEditors.PictureEdit pictureEdit6;
        private DevExpress.XtraBars.Navigation.NavigationPage PageOrganizador;
        private Core.Controles.ctlPlanificadorActividades ctlPlanificadorActividades1;
        private DevExpress.XtraBars.Navigation.NavigationPage pageMiEquipo;
        private Core.Controles.ctlMiEquipo ctlMiEquipo1;
        private DevExpress.XtraBars.Navigation.NavigationPage pageBusqueda;
        private Core.Controles.ctlBusquedaFichasIngreso ctlBusquedaFichasIngreso1;
        private DevExpress.XtraBars.Navigation.NavigationPage PageSolicitudes;
        private Core.Controles.ctlVistaFichaIngreso ctlVistaFichaIngreso1;
        private Core.Controles.ctlVistaSolicitudes ctlVistaSolicitudes1;
        private DevExpress.XtraBars.Navigation.NavigationPage PageCrearFichaIngreso;
        private Core.Controles.ctlIngresoFicha ctlIngresoFicha1;
        private System.ComponentModel.BackgroundWorker bgObtenerFusibles;
        private System.Windows.Forms.Timer tmrFusibles;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}
