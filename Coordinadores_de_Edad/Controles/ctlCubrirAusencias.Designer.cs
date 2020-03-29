using Core.Controles;

namespace Coordinadores_de_Edad.Controles
{
    partial class ctlCubrirAusencias
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
            this.lblEncabezado = new DevExpress.XtraEditors.LabelControl();
            this.picAtras = new DevExpress.XtraEditors.PictureEdit();
            this.panel4 = new System.Windows.Forms.Panel();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cmdGuardar = new DevExpress.XtraEditors.PictureEdit();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.picNoEsNecesarioCubrir = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picReemplazar = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ctlSeleccionMaestros_Ayudas1 = new Core.Controles.ctlSeleccionMaestros_Ayudas();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAtras.Properties)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdGuardar.Properties)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNoEsNecesarioCubrir.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReemplazar.Properties)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 2);
            this.panel2.TabIndex = 16;
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.lblEncabezado);
            this.pnlEncabezado.Controls.Add(this.picAtras);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(5, 5);
            this.pnlEncabezado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1067, 45);
            this.pnlEncabezado.TabIndex = 15;
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.Appearance.Options.UseFont = true;
            this.lblEncabezado.Appearance.Options.UseTextOptions = true;
            this.lblEncabezado.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblEncabezado.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblEncabezado.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEncabezado.Location = new System.Drawing.Point(49, 0);
            this.lblEncabezado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(1018, 45);
            this.lblEncabezado.TabIndex = 9;
            this.lblEncabezado.Text = "Selección para Cubrir Ausencia";
            // 
            // picAtras
            // 
            this.picAtras.Dock = System.Windows.Forms.DockStyle.Left;
            this.picAtras.EditValue = global::Coordinadores_de_Edad.Resources.icon_atras_64;
            this.picAtras.Location = new System.Drawing.Point(0, 0);
            this.picAtras.Name = "picAtras";
            this.picAtras.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.False;
            this.picAtras.Properties.AllowFocused = false;
            this.picAtras.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.picAtras.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.picAtras.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.picAtras.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picAtras.Properties.NullText = "   ";
            this.picAtras.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picAtras.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picAtras.Size = new System.Drawing.Size(49, 45);
            this.picAtras.TabIndex = 35;
            this.picAtras.Click += new System.EventHandler(this.PicAtras_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(5, 52);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1067, 4);
            this.panel4.TabIndex = 19;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.panel9);
            this.xtraScrollableControl1.Controls.Add(this.panel5);
            this.xtraScrollableControl1.Controls.Add(this.panel1);
            this.xtraScrollableControl1.Controls.Add(this.ctlSeleccionMaestros_Ayudas1);
            this.xtraScrollableControl1.Controls.Add(this.panel6);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(5, 56);
            this.xtraScrollableControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(1067, 823);
            this.xtraScrollableControl1.TabIndex = 20;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cmdGuardar);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 513);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1067, 65);
            this.panel9.TabIndex = 27;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdGuardar.EditValue = global::Coordinadores_de_Edad.Resources.icon_guardar_negro_64;
            this.cmdGuardar.Location = new System.Drawing.Point(712, 11);
            this.cmdGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Properties.AllowFocused = false;
            this.cmdGuardar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdGuardar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cmdGuardar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.cmdGuardar.Size = new System.Drawing.Size(51, 54);
            this.cmdGuardar.TabIndex = 42;
            this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardar_Click);
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(712, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(355, 11);
            this.panel11.TabIndex = 44;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(712, 65);
            this.panel10.TabIndex = 43;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.picNoEsNecesarioCubrir);
            this.panel5.Controls.Add(this.labelControl2);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 467);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1067, 46);
            this.panel5.TabIndex = 26;
            // 
            // picNoEsNecesarioCubrir
            // 
            this.picNoEsNecesarioCubrir.Dock = System.Windows.Forms.DockStyle.Left;
            this.picNoEsNecesarioCubrir.EditValue = global::Coordinadores_de_Edad.Resources.iconUncheck_32;
            this.picNoEsNecesarioCubrir.Location = new System.Drawing.Point(712, 5);
            this.picNoEsNecesarioCubrir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picNoEsNecesarioCubrir.Name = "picNoEsNecesarioCubrir";
            this.picNoEsNecesarioCubrir.Properties.AllowFocused = false;
            this.picNoEsNecesarioCubrir.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picNoEsNecesarioCubrir.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picNoEsNecesarioCubrir.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picNoEsNecesarioCubrir.Size = new System.Drawing.Size(44, 41);
            this.picNoEsNecesarioCubrir.TabIndex = 43;
            this.picNoEsNecesarioCubrir.Click += new System.EventHandler(this.PicNoEsNecesarioCubrir_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelControl2.Location = new System.Drawing.Point(0, 5);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(712, 41);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "No es necesario cubrir ausencia";
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1067, 5);
            this.panel8.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picReemplazar);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 422);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 45);
            this.panel1.TabIndex = 25;
            // 
            // picReemplazar
            // 
            this.picReemplazar.Dock = System.Windows.Forms.DockStyle.Left;
            this.picReemplazar.EditValue = global::Coordinadores_de_Edad.Resources.iconUncheck_32;
            this.picReemplazar.Location = new System.Drawing.Point(712, 5);
            this.picReemplazar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picReemplazar.Name = "picReemplazar";
            this.picReemplazar.Properties.AllowFocused = false;
            this.picReemplazar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picReemplazar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picReemplazar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picReemplazar.Size = new System.Drawing.Size(44, 40);
            this.picReemplazar.TabIndex = 42;
            this.picReemplazar.Click += new System.EventHandler(this.PicReemplazar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelControl1.Location = new System.Drawing.Point(0, 5);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(712, 40);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Reemplazar con servidor de otro equipo en la iglesia";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1067, 5);
            this.panel3.TabIndex = 0;
            // 
            // ctlSeleccionMaestros_Ayudas1
            // 
            this.ctlSeleccionMaestros_Ayudas1.BackColor = System.Drawing.Color.White;
            this.ctlSeleccionMaestros_Ayudas1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlSeleccionMaestros_Ayudas1.Location = new System.Drawing.Point(0, 0);
            this.ctlSeleccionMaestros_Ayudas1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctlSeleccionMaestros_Ayudas1.Name = "ctlSeleccionMaestros_Ayudas1";
            this.ctlSeleccionMaestros_Ayudas1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlSeleccionMaestros_Ayudas1.Pro_Conexion = null;
            this.ctlSeleccionMaestros_Ayudas1.Pro_Fecha = null;
            this.ctlSeleccionMaestros_Ayudas1.Pro_FechaActividad = new System.DateTime(((long)(0)));
            this.ctlSeleccionMaestros_Ayudas1.Pro_ID_Actividad = 0;
            this.ctlSeleccionMaestros_Ayudas1.Pro_ID_AreaAtencion = 0;
            this.ctlSeleccionMaestros_Ayudas1.Pro_MostrarEncabezadoPrincipal = false;
            this.ctlSeleccionMaestros_Ayudas1.Pro_Usuario = null;
            this.ctlSeleccionMaestros_Ayudas1.Size = new System.Drawing.Size(1067, 422);
            this.ctlSeleccionMaestros_Ayudas1.TabIndex = 24;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 752);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1067, 71);
            this.panel6.TabIndex = 22;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(1055, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(12, 71);
            this.panel7.TabIndex = 41;
            // 
            // ctlCubrirAusencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.xtraScrollableControl1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlEncabezado);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1077, 791);
            this.Name = "ctlCubrirAusencias";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1077, 884);
            this.pnlEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAtras.Properties)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdGuardar.Properties)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picNoEsNecesarioCubrir.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picReemplazar.Properties)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlEncabezado;
        private DevExpress.XtraEditors.LabelControl lblEncabezado;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private ctlSeleccionMaestros_Ayudas ctlSeleccionMaestros_Ayudas1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit picNoEsNecesarioCubrir;
        private DevExpress.XtraEditors.PictureEdit picReemplazar;
        private System.Windows.Forms.Panel panel9;
        private DevExpress.XtraEditors.PictureEdit cmdGuardar;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        public DevExpress.XtraEditors.PictureEdit picAtras;
    }
}
