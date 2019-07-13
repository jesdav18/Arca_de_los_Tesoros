namespace Core.Controles
{
    partial class ctlLogin
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
            this.pnlBordeSuperior = new System.Windows.Forms.Panel();
            this.pnlBordeIzquierdo = new System.Windows.Forms.Panel();
            this.pnlBordeDerecho = new System.Windows.Forms.Panel();
            this.pnlBordeInferior = new System.Windows.Forms.Panel();
            this.pnlSeparador = new System.Windows.Forms.Panel();
            this.lblEtiquetaUsuario = new DevExpress.XtraEditors.LabelControl();
            this.lblEtiquetaContrasenia = new DevExpress.XtraEditors.LabelControl();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.txtContrasenia = new DevExpress.XtraEditors.TextEdit();
            this.cmdAcceder = new DevExpress.XtraEditors.SimpleButton();
            this.picLogoInstitucion = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasenia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInstitucion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBordeSuperior
            // 
            this.pnlBordeSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.pnlBordeSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBordeSuperior.Location = new System.Drawing.Point(5, 5);
            this.pnlBordeSuperior.Name = "pnlBordeSuperior";
            this.pnlBordeSuperior.Size = new System.Drawing.Size(670, 2);
            this.pnlBordeSuperior.TabIndex = 0;
            // 
            // pnlBordeIzquierdo
            // 
            this.pnlBordeIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.pnlBordeIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBordeIzquierdo.Location = new System.Drawing.Point(5, 7);
            this.pnlBordeIzquierdo.Name = "pnlBordeIzquierdo";
            this.pnlBordeIzquierdo.Size = new System.Drawing.Size(2, 648);
            this.pnlBordeIzquierdo.TabIndex = 1;
            // 
            // pnlBordeDerecho
            // 
            this.pnlBordeDerecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.pnlBordeDerecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBordeDerecho.Location = new System.Drawing.Point(673, 7);
            this.pnlBordeDerecho.Name = "pnlBordeDerecho";
            this.pnlBordeDerecho.Size = new System.Drawing.Size(2, 648);
            this.pnlBordeDerecho.TabIndex = 2;
            // 
            // pnlBordeInferior
            // 
            this.pnlBordeInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.pnlBordeInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBordeInferior.Location = new System.Drawing.Point(7, 653);
            this.pnlBordeInferior.Name = "pnlBordeInferior";
            this.pnlBordeInferior.Size = new System.Drawing.Size(666, 2);
            this.pnlBordeInferior.TabIndex = 3;
            // 
            // pnlSeparador
            // 
            this.pnlSeparador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSeparador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.pnlSeparador.Location = new System.Drawing.Point(59, 231);
            this.pnlSeparador.Name = "pnlSeparador";
            this.pnlSeparador.Size = new System.Drawing.Size(555, 10);
            this.pnlSeparador.TabIndex = 5;
            // 
            // lblEtiquetaUsuario
            // 
            this.lblEtiquetaUsuario.Appearance.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiquetaUsuario.Appearance.Options.UseFont = true;
            this.lblEtiquetaUsuario.Location = new System.Drawing.Point(182, 280);
            this.lblEtiquetaUsuario.Name = "lblEtiquetaUsuario";
            this.lblEtiquetaUsuario.Size = new System.Drawing.Size(97, 37);
            this.lblEtiquetaUsuario.TabIndex = 6;
            this.lblEtiquetaUsuario.Text = "Usuario:";
            // 
            // lblEtiquetaContrasenia
            // 
            this.lblEtiquetaContrasenia.Appearance.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiquetaContrasenia.Appearance.Options.UseFont = true;
            this.lblEtiquetaContrasenia.Location = new System.Drawing.Point(182, 394);
            this.lblEtiquetaContrasenia.Name = "lblEtiquetaContrasenia";
            this.lblEtiquetaContrasenia.Size = new System.Drawing.Size(140, 37);
            this.lblEtiquetaContrasenia.TabIndex = 7;
            this.lblEtiquetaContrasenia.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(182, 323);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtUsuario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtUsuario.Size = new System.Drawing.Size(323, 44);
            this.txtUsuario.TabIndex = 8;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(182, 437);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenia.Properties.Appearance.Options.UseFont = true;
            this.txtContrasenia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtContrasenia.Properties.PasswordChar = '*';
            this.txtContrasenia.Size = new System.Drawing.Size(323, 44);
            this.txtContrasenia.TabIndex = 9;
            // 
            // cmdAcceder
            // 
            this.cmdAcceder.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.cmdAcceder.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAcceder.Appearance.ForeColor = System.Drawing.Color.White;
            this.cmdAcceder.Appearance.Options.UseBackColor = true;
            this.cmdAcceder.Appearance.Options.UseFont = true;
            this.cmdAcceder.Appearance.Options.UseForeColor = true;
            this.cmdAcceder.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(190)))));
            this.cmdAcceder.AppearanceHovered.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAcceder.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.cmdAcceder.AppearanceHovered.Options.UseBackColor = true;
            this.cmdAcceder.AppearanceHovered.Options.UseFont = true;
            this.cmdAcceder.AppearanceHovered.Options.UseForeColor = true;
            this.cmdAcceder.Location = new System.Drawing.Point(182, 515);
            this.cmdAcceder.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.cmdAcceder.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdAcceder.Name = "cmdAcceder";
            this.cmdAcceder.Size = new System.Drawing.Size(328, 66);
            this.cmdAcceder.TabIndex = 10;
            this.cmdAcceder.Text = "Acceder";
            // 
            // picLogoInstitucion
            // 
            this.picLogoInstitucion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogoInstitucion.EditValue = global::Core.Properties.Resources.imgEbenezer;
            this.picLogoInstitucion.Location = new System.Drawing.Point(226, 13);
            this.picLogoInstitucion.Name = "picLogoInstitucion";
            this.picLogoInstitucion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picLogoInstitucion.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picLogoInstitucion.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picLogoInstitucion.Size = new System.Drawing.Size(238, 212);
            this.picLogoInstitucion.TabIndex = 4;
            // 
            // ctlLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmdAcceder);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblEtiquetaContrasenia);
            this.Controls.Add(this.lblEtiquetaUsuario);
            this.Controls.Add(this.pnlSeparador);
            this.Controls.Add(this.picLogoInstitucion);
            this.Controls.Add(this.pnlBordeInferior);
            this.Controls.Add(this.pnlBordeDerecho);
            this.Controls.Add(this.pnlBordeIzquierdo);
            this.Controls.Add(this.pnlBordeSuperior);
            this.MaximumSize = new System.Drawing.Size(680, 660);
            this.MinimumSize = new System.Drawing.Size(680, 660);
            this.Name = "ctlLogin";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(680, 660);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasenia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInstitucion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBordeSuperior;
        private System.Windows.Forms.Panel pnlBordeIzquierdo;
        private System.Windows.Forms.Panel pnlBordeDerecho;
        private System.Windows.Forms.Panel pnlBordeInferior;
        private DevExpress.XtraEditors.PictureEdit picLogoInstitucion;
        private System.Windows.Forms.Panel pnlSeparador;
        private DevExpress.XtraEditors.LabelControl lblEtiquetaUsuario;
        private DevExpress.XtraEditors.LabelControl lblEtiquetaContrasenia;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.TextEdit txtContrasenia;
        private DevExpress.XtraEditors.SimpleButton cmdAcceder;
    }
}
