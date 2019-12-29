namespace Core.Controles_Configuracion
{
    partial class ctlPonerModoEdicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlPonerModoEdicion));
            this.cmdEditNombreColaborador = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditNombreColaborador.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdEditNombreColaborador
            // 
            this.cmdEditNombreColaborador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdEditNombreColaborador.EditValue = ((object)(resources.GetObject("cmdEditNombreColaborador.EditValue")));
            this.cmdEditNombreColaborador.Location = new System.Drawing.Point(0, 0);
            this.cmdEditNombreColaborador.MaximumSize = new System.Drawing.Size(32, 26);
            this.cmdEditNombreColaborador.MinimumSize = new System.Drawing.Size(32, 26);
            this.cmdEditNombreColaborador.Name = "cmdEditNombreColaborador";
            this.cmdEditNombreColaborador.Properties.AllowFocused = false;
            this.cmdEditNombreColaborador.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.cmdEditNombreColaborador.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.cmdEditNombreColaborador.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdEditNombreColaborador.Properties.NullText = " ";
            this.cmdEditNombreColaborador.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdEditNombreColaborador.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmdEditNombreColaborador.Size = new System.Drawing.Size(32, 26);
            this.cmdEditNombreColaborador.TabIndex = 50;
            this.cmdEditNombreColaborador.ToolTip = "Guardar Cambios\r\n";
            this.cmdEditNombreColaborador.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.cmdEditNombreColaborador.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cmdEditNombreColaborador.ToolTipTitle = "Arca de los Tesoros";
            this.cmdEditNombreColaborador.Click += new System.EventHandler(this.CmdEditNombreColaborador_Click);
            // 
            // ctlPonerModoEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmdEditNombreColaborador);
            this.Name = "ctlPonerModoEdicion";
            this.Size = new System.Drawing.Size(32, 26);
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditNombreColaborador.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit cmdEditNombreColaborador;
    }
}
