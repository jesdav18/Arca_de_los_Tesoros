namespace Core.Controles
{
    partial class ctlBienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlBienvenida));
            this.pnlBordeDerecho = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBienvenido = new DevExpress.XtraEditors.LabelControl();
            this.lblVersion = new DevExpress.XtraEditors.LabelControl();
            this.lblUltimaActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.picLogoInstitucion = new DevExpress.XtraEditors.PictureEdit();
            this.lblNombrePrograma = new DevExpress.XtraEditors.LabelControl();
            this.lblModulo = new DevExpress.XtraEditors.LabelControl();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tmrBienvenida = new System.Windows.Forms.Timer(this.components);
            this.bgCrearConexion = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInstitucion.Properties)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBordeDerecho
            // 
            this.pnlBordeDerecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.pnlBordeDerecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBordeDerecho.Location = new System.Drawing.Point(656, 5);
            this.pnlBordeDerecho.Name = "pnlBordeDerecho";
            this.pnlBordeDerecho.Size = new System.Drawing.Size(2, 482);
            this.pnlBordeDerecho.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 482);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(7, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 3);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(7, 484);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(649, 3);
            this.panel3.TabIndex = 6;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.Appearance.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Appearance.Options.UseFont = true;
            this.lblBienvenido.Appearance.Options.UseTextOptions = true;
            this.lblBienvenido.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBienvenido.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblBienvenido.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblBienvenido.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBienvenido.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblBienvenido.Location = new System.Drawing.Point(7, 256);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(649, 74);
            this.lblBienvenido.TabIndex = 7;
            this.lblBienvenido.Text = "¡BIENVENIDO!";
            // 
            // lblVersion
            // 
            this.lblVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Appearance.Options.UseFont = true;
            this.lblVersion.Appearance.Options.UseTextOptions = true;
            this.lblVersion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblVersion.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblVersion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblVersion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblVersion.Location = new System.Drawing.Point(0, 27);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(629, 27);
            this.lblVersion.TabIndex = 9;
            this.lblVersion.Text = "VERSION";
            // 
            // lblUltimaActualizacion
            // 
            this.lblUltimaActualizacion.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimaActualizacion.Appearance.Options.UseFont = true;
            this.lblUltimaActualizacion.Appearance.Options.UseTextOptions = true;
            this.lblUltimaActualizacion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblUltimaActualizacion.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblUltimaActualizacion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblUltimaActualizacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUltimaActualizacion.Location = new System.Drawing.Point(0, 0);
            this.lblUltimaActualizacion.Name = "lblUltimaActualizacion";
            this.lblUltimaActualizacion.Size = new System.Drawing.Size(629, 27);
            this.lblUltimaActualizacion.TabIndex = 8;
            this.lblUltimaActualizacion.Text = "FECHA ÚLTIMA ACTUALIZACIÓN";
            // 
            // picLogoInstitucion
            // 
            this.picLogoInstitucion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogoInstitucion.EditValue = ((object)(resources.GetObject("picLogoInstitucion.EditValue")));
            this.picLogoInstitucion.Location = new System.Drawing.Point(206, 87);
            this.picLogoInstitucion.Name = "picLogoInstitucion";
            this.picLogoInstitucion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picLogoInstitucion.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picLogoInstitucion.Size = new System.Drawing.Size(255, 163);
            this.picLogoInstitucion.TabIndex = 10;
            // 
            // lblNombrePrograma
            // 
            this.lblNombrePrograma.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePrograma.Appearance.Options.UseFont = true;
            this.lblNombrePrograma.Appearance.Options.UseTextOptions = true;
            this.lblNombrePrograma.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblNombrePrograma.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblNombrePrograma.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblNombrePrograma.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNombrePrograma.Location = new System.Drawing.Point(7, 330);
            this.lblNombrePrograma.Name = "lblNombrePrograma";
            this.lblNombrePrograma.Size = new System.Drawing.Size(649, 52);
            this.lblNombrePrograma.TabIndex = 11;
            this.lblNombrePrograma.Text = "ARCA DE LOS TESOROS";
            // 
            // lblModulo
            // 
            this.lblModulo.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulo.Appearance.Options.UseFont = true;
            this.lblModulo.Appearance.Options.UseTextOptions = true;
            this.lblModulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblModulo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblModulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblModulo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblModulo.Location = new System.Drawing.Point(7, 382);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(649, 51);
            this.lblModulo.TabIndex = 12;
            this.lblModulo.Text = "NOMBRE DE MÓDULO";
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.BarAnimationElementThickness = 2;
            this.progressPanel1.Caption = " ";
            this.progressPanel1.Description = " ";
            this.progressPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressPanel1.Location = new System.Drawing.Point(7, 433);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.ShowCaption = false;
            this.progressPanel1.ShowDescription = false;
            this.progressPanel1.Size = new System.Drawing.Size(649, 51);
            this.progressPanel1.TabIndex = 13;
            this.progressPanel1.Text = "progressPanel1";
            this.progressPanel1.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblVersion);
            this.panel4.Controls.Add(this.lblUltimaActualizacion);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(7, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(649, 57);
            this.panel4.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(629, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(20, 57);
            this.panel5.TabIndex = 0;
            // 
            // tmrBienvenida
            // 
            this.tmrBienvenida.Interval = 2000;
            this.tmrBienvenida.Tick += new System.EventHandler(this.TmrBienvenida_Tick);
            // 
            // bgCrearConexion
            // 
            this.bgCrearConexion.WorkerSupportsCancellation = true;
            this.bgCrearConexion.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgCrearConexion_DoWork);
            this.bgCrearConexion.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgCrearConexion_RunWorkerCompleted);
            // 
            // ctlBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.lblNombrePrograma);
            this.Controls.Add(this.lblModulo);
            this.Controls.Add(this.picLogoInstitucion);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.progressPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlBordeDerecho);
            this.Controls.Add(this.panel1);
            this.Name = "ctlBienvenida";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(663, 492);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInstitucion.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBordeDerecho;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl lblBienvenido;
        private DevExpress.XtraEditors.LabelControl lblVersion;
        private DevExpress.XtraEditors.LabelControl lblUltimaActualizacion;
        private DevExpress.XtraEditors.PictureEdit picLogoInstitucion;
        private DevExpress.XtraEditors.LabelControl lblNombrePrograma;
        private DevExpress.XtraEditors.LabelControl lblModulo;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Timer tmrBienvenida;
        private System.ComponentModel.BackgroundWorker bgCrearConexion;
    }
}
