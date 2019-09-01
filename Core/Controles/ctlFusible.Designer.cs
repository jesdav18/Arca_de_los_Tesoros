namespace Core.Controles
{
    partial class ctlFusible
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
            this.lblValor = new DevExpress.XtraEditors.LabelControl();
            this.tmrParpadeo = new System.Windows.Forms.Timer();
            this.picImagenCircular = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenCircular.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Appearance.Options.UseBackColor = true;
            this.lblValor.Appearance.Options.UseFont = true;
            this.lblValor.Appearance.Options.UseTextOptions = true;
            this.lblValor.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblValor.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblValor.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblValor.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblValor.Location = new System.Drawing.Point(14, 14);
            this.lblValor.MaximumSize = new System.Drawing.Size(32, 24);
            this.lblValor.MinimumSize = new System.Drawing.Size(32, 24);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(32, 24);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "99";
            this.lblValor.Click += new System.EventHandler(this.lblValor_Click);
            // 
            // tmrParpadeo
            // 
            this.tmrParpadeo.Interval = 1000;
            this.tmrParpadeo.Tick += new System.EventHandler(this.tmrParpadeo_Tick);
            // 
            // picImagenCircular
            // 
            this.picImagenCircular.EditValue = global::Core.Properties.Resources.icon_fusible_blanco_64;
            this.picImagenCircular.Location = new System.Drawing.Point(1, 0);
            this.picImagenCircular.MaximumSize = new System.Drawing.Size(60, 53);
            this.picImagenCircular.MinimumSize = new System.Drawing.Size(60, 53);
            this.picImagenCircular.Name = "picImagenCircular";
            this.picImagenCircular.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picImagenCircular.Properties.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.picImagenCircular.Properties.Appearance.Options.UseBackColor = true;
            this.picImagenCircular.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picImagenCircular.Properties.NullText = "|";
            this.picImagenCircular.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picImagenCircular.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picImagenCircular.Size = new System.Drawing.Size(60, 53);
            this.picImagenCircular.TabIndex = 2;
            this.picImagenCircular.Click += new System.EventHandler(this.picImagenCircular_Click);
            // 
            // ctlFusible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.picImagenCircular);
            this.MaximumSize = new System.Drawing.Size(62, 57);
            this.MinimumSize = new System.Drawing.Size(62, 57);
            this.Name = "ctlFusible";
            this.Size = new System.Drawing.Size(62, 57);
            ((System.ComponentModel.ISupportInitialize)(this.picImagenCircular.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PictureEdit picImagenCircular;
        private System.Windows.Forms.Timer tmrParpadeo;
        public DevExpress.XtraEditors.LabelControl lblValor;
    }
}
