namespace Core.Controles
{
    partial class ctlItemDiaTrabajo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDia = new DevExpress.XtraEditors.LabelControl();
            this.lblFecha = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 4);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 4);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 109);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(220, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 109);
            this.panel4.TabIndex = 3;
            // 
            // lblDia
            // 
            this.lblDia.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Appearance.Options.UseFont = true;
            this.lblDia.Appearance.Options.UseTextOptions = true;
            this.lblDia.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblDia.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblDia.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDia.Location = new System.Drawing.Point(4, 43);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(216, 70);
            this.lblDia.TabIndex = 10;
            this.lblDia.Text = "Domingo";
            this.lblDia.Click += new System.EventHandler(this.LblFecha_Click);
            this.lblDia.MouseLeave += new System.EventHandler(this.LblDia_MouseLeave);
            this.lblDia.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblFecha_MouseMove);
            // 
            // lblFecha
            // 
            this.lblFecha.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Appearance.Options.UseFont = true;
            this.lblFecha.Appearance.Options.UseTextOptions = true;
            this.lblFecha.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblFecha.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblFecha.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblFecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFecha.Location = new System.Drawing.Point(4, 4);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(216, 39);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "25-07-2019";
            this.lblFecha.Click += new System.EventHandler(this.LblFecha_Click);
            this.lblFecha.MouseLeave += new System.EventHandler(this.LblDia_MouseLeave);
            this.lblFecha.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblFecha_MouseMove);
            // 
            // ctlItemDiaTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ctlItemDiaTrabajo";
            this.Size = new System.Drawing.Size(224, 117);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.LabelControl lblDia;
        private DevExpress.XtraEditors.LabelControl lblFecha;
    }
}
