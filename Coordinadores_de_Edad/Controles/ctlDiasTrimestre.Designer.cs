namespace Coordinadores_de_Edad.Controles
{
    partial class ctlDiasTrimestre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlDiasTrimestre));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.picAtras = new DevExpress.XtraEditors.PictureEdit();
            this.lblTituloEncabezado = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TileDias = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAtras.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1075, 10);
            this.panel2.TabIndex = 14;
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.lblTituloEncabezado);
            this.pnlEncabezado.Controls.Add(this.picAtras);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(5, 5);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1075, 75);
            this.pnlEncabezado.TabIndex = 13;
            // 
            // picAtras
            // 
            this.picAtras.Dock = System.Windows.Forms.DockStyle.Left;
            this.picAtras.EditValue = ((object)(resources.GetObject("picAtras.EditValue")));
            this.picAtras.Location = new System.Drawing.Point(0, 0);
            this.picAtras.Name = "picAtras";
            this.picAtras.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picAtras.Properties.NullText = "   ";
            this.picAtras.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picAtras.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picAtras.Size = new System.Drawing.Size(80, 75);
            this.picAtras.TabIndex = 19;
            this.picAtras.Click += new System.EventHandler(this.PicAtras_Click);
            // 
            // lblTituloEncabezado
            // 
            this.lblTituloEncabezado.Appearance.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEncabezado.Appearance.Options.UseFont = true;
            this.lblTituloEncabezado.Appearance.Options.UseTextOptions = true;
            this.lblTituloEncabezado.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTituloEncabezado.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblTituloEncabezado.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTituloEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTituloEncabezado.Location = new System.Drawing.Point(80, 0);
            this.lblTituloEncabezado.Name = "lblTituloEncabezado";
            this.lblTituloEncabezado.Size = new System.Drawing.Size(995, 75);
            this.lblTituloEncabezado.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 84);
            this.panel1.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 614);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1075, 115);
            this.panel3.TabIndex = 16;
            // 
            // TileDias
            // 
            this.TileDias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TileDias.Location = new System.Drawing.Point(5, 174);
            this.TileDias.Name = "TileDias";
            this.TileDias.Size = new System.Drawing.Size(1075, 440);
            this.TileDias.TabIndex = 17;
            // 
            // ctlDiasTrimestre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TileDias);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlEncabezado);
            this.Name = "ctlDiasTrimestre";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1085, 734);
            this.pnlEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAtras.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlEncabezado;
        private DevExpress.XtraEditors.LabelControl lblTituloEncabezado;
        private DevExpress.XtraEditors.PictureEdit picAtras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel TileDias;
    }
}
