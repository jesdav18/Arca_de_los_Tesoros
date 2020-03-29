namespace Core.Controles.Cumpleanieros
{
    partial class ctlCumpleanierosDia
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
            this.tileCumpleanierosDia = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblEncabezado = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlEncabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // tileCumpleanierosDia
            // 
            this.tileCumpleanierosDia.AutoScroll = true;
            this.tileCumpleanierosDia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileCumpleanierosDia.Location = new System.Drawing.Point(5, 122);
            this.tileCumpleanierosDia.Name = "tileCumpleanierosDia";
            this.tileCumpleanierosDia.Size = new System.Drawing.Size(981, 444);
            this.tileCumpleanierosDia.TabIndex = 0;
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.lblEncabezado);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(5, 5);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(981, 75);
            this.pnlEncabezado.TabIndex = 17;
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
            this.lblEncabezado.Size = new System.Drawing.Size(981, 75);
            this.lblEncabezado.TabIndex = 9;
            this.lblEncabezado.Text = "Cumpleañeros del Día";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(981, 10);
            this.panel2.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 32);
            this.panel1.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 566);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(981, 34);
            this.panel3.TabIndex = 20;
            // 
            // ctlCumpleanierosDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tileCumpleanierosDia);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlEncabezado);
            this.Name = "ctlCumpleanierosDia";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(991, 605);
            this.pnlEncabezado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlEncabezado;
        private DevExpress.XtraEditors.LabelControl lblEncabezado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.FlowLayoutPanel tileCumpleanierosDia;
    }
}
