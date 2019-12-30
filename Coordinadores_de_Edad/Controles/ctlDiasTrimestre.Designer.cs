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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTituloEncabezado = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TileDias = new System.Windows.Forms.FlowLayoutPanel();
            this.toggleOrdinarias = new DevExpress.XtraEditors.ToggleSwitch();
            this.cmCrearActividadHoy = new DevExpress.XtraEditors.PictureEdit();
            this.pnlEncabezado.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleOrdinarias.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmCrearActividadHoy.Properties)).BeginInit();
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
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(5, 5);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1075, 75);
            this.pnlEncabezado.TabIndex = 13;
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
            this.lblTituloEncabezado.Location = new System.Drawing.Point(0, 0);
            this.lblTituloEncabezado.Name = "lblTituloEncabezado";
            this.lblTituloEncabezado.Size = new System.Drawing.Size(1075, 75);
            this.lblTituloEncabezado.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toggleOrdinarias);
            this.panel1.Controls.Add(this.cmCrearActividadHoy);
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
            // toggleOrdinarias
            // 
            this.toggleOrdinarias.Dock = System.Windows.Forms.DockStyle.Left;
            this.toggleOrdinarias.Location = new System.Drawing.Point(0, 0);
            this.toggleOrdinarias.Name = "toggleOrdinarias";
            this.toggleOrdinarias.Properties.AllowFocused = false;
            this.toggleOrdinarias.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleOrdinarias.Properties.Appearance.Options.UseFont = true;
            this.toggleOrdinarias.Properties.Appearance.Options.UseTextOptions = true;
            this.toggleOrdinarias.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.toggleOrdinarias.Properties.OffText = "Ordinarias";
            this.toggleOrdinarias.Properties.OnText = "Extraordinarias";
            this.toggleOrdinarias.Size = new System.Drawing.Size(362, 84);
            this.toggleOrdinarias.TabIndex = 22;
            this.toggleOrdinarias.ToolTip = "Ver Actividades Extraordinarias";
            this.toggleOrdinarias.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.toggleOrdinarias.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.toggleOrdinarias.Toggled += new System.EventHandler(this.ToggleOrdinarias_Toggled);
            // 
            // cmCrearActividadHoy
            // 
            this.cmCrearActividadHoy.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmCrearActividadHoy.EditValue = global::Coordinadores_de_Edad.Resources.icon_hoy;
            this.cmCrearActividadHoy.Location = new System.Drawing.Point(1027, 0);
            this.cmCrearActividadHoy.Name = "cmCrearActividadHoy";
            this.cmCrearActividadHoy.Properties.AllowFocused = false;
            this.cmCrearActividadHoy.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.cmCrearActividadHoy.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.cmCrearActividadHoy.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmCrearActividadHoy.Properties.NullText = " ";
            this.cmCrearActividadHoy.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmCrearActividadHoy.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.cmCrearActividadHoy.Size = new System.Drawing.Size(48, 84);
            this.cmCrearActividadHoy.TabIndex = 21;
            this.cmCrearActividadHoy.ToolTip = "Crear Actividad para hoy";
            this.cmCrearActividadHoy.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.cmCrearActividadHoy.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cmCrearActividadHoy.ToolTipTitle = "Arca de los Tesoros";
            this.cmCrearActividadHoy.Click += new System.EventHandler(this.CmCrearActividadHoy_Click);
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
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toggleOrdinarias.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmCrearActividadHoy.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlEncabezado;
        private DevExpress.XtraEditors.LabelControl lblTituloEncabezado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel TileDias;
        private DevExpress.XtraEditors.PictureEdit cmCrearActividadHoy;
        private DevExpress.XtraEditors.ToggleSwitch toggleOrdinarias;
    }
}
