namespace Core.Controles
{
    partial class ctlEncabezado
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
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new DevExpress.XtraEditors.LabelControl();
            this.lblCargoUsuario = new DevExpress.XtraEditors.LabelControl();
            this.pnlUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.Controls.Add(this.lblNombreUsuario);
            this.pnlUsuario.Controls.Add(this.lblCargoUsuario);
            this.pnlUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUsuario.Location = new System.Drawing.Point(10, 10);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Padding = new System.Windows.Forms.Padding(5);
            this.pnlUsuario.Size = new System.Drawing.Size(0, 103);
            this.pnlUsuario.TabIndex = 0;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Appearance.Options.UseFont = true;
            this.lblNombreUsuario.Appearance.Options.UseTextOptions = true;
            this.lblNombreUsuario.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblNombreUsuario.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblNombreUsuario.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblNombreUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreUsuario.Location = new System.Drawing.Point(5, 5);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(0, 41);
            this.lblNombreUsuario.TabIndex = 4;
            this.lblNombreUsuario.Text = "Diego Ramirez";
            // 
            // lblCargoUsuario
            // 
            this.lblCargoUsuario.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargoUsuario.Appearance.Options.UseFont = true;
            this.lblCargoUsuario.Appearance.Options.UseTextOptions = true;
            this.lblCargoUsuario.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblCargoUsuario.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblCargoUsuario.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCargoUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCargoUsuario.Location = new System.Drawing.Point(5, 46);
            this.lblCargoUsuario.Name = "lblCargoUsuario";
            this.lblCargoUsuario.Size = new System.Drawing.Size(0, 52);
            this.lblCargoUsuario.TabIndex = 3;
            this.lblCargoUsuario.Text = "Coordinador de Edad";
            // 
            // ctlEncabezado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlUsuario);
            this.MaximumSize = new System.Drawing.Size(0, 123);
            this.MinimumSize = new System.Drawing.Size(0, 123);
            this.Name = "ctlEncabezado";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(0, 123);
            this.pnlUsuario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUsuario;
        private DevExpress.XtraEditors.LabelControl lblNombreUsuario;
        private DevExpress.XtraEditors.LabelControl lblCargoUsuario;
    }
}
