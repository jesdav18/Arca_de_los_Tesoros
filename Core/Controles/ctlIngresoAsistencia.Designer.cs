namespace Core.Controles
{
    partial class ctlIngresoAsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlIngresoAsistencia));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblEncabezado = new DevExpress.XtraEditors.LabelControl();
            this.picAtras = new DevExpress.XtraEditors.PictureEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picColaborador = new DevExpress.XtraEditors.PictureEdit();
            this.lblFechaNacimiento = new DevExpress.XtraEditors.LabelControl();
            this.lblNumeroIdentidad = new DevExpress.XtraEditors.LabelControl();
            this.lblNombreColaborador = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAtras.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColaborador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1096, 10);
            this.panel2.TabIndex = 15;
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.picAtras);
            this.pnlEncabezado.Controls.Add(this.lblEncabezado);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(5, 5);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1096, 75);
            this.pnlEncabezado.TabIndex = 14;
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
            this.lblEncabezado.Size = new System.Drawing.Size(1096, 75);
            this.lblEncabezado.TabIndex = 9;
            this.lblEncabezado.Text = "Seleccion Maestros Día para  X";
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
            this.picAtras.Size = new System.Drawing.Size(58, 75);
            this.picAtras.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 21);
            this.panel1.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblFechaNacimiento);
            this.panel3.Controls.Add(this.lblNumeroIdentidad);
            this.panel3.Controls.Add(this.lblNombreColaborador);
            this.panel3.Controls.Add(this.picColaborador);
            this.panel3.Controls.Add(this.pictureEdit1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(5, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1096, 185);
            this.panel3.TabIndex = 17;
            // 
            // picColaborador
            // 
            this.picColaborador.Dock = System.Windows.Forms.DockStyle.Left;
            this.picColaborador.EditValue = global::Core.Properties.Resources.icon_no_foto_512;
            this.picColaborador.Location = new System.Drawing.Point(0, 0);
            this.picColaborador.Name = "picColaborador";
            this.picColaborador.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picColaborador.Properties.NullText = " ";
            this.picColaborador.Properties.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.picColaborador.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picColaborador.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picColaborador.Size = new System.Drawing.Size(267, 185);
            this.picColaborador.TabIndex = 23;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Appearance.Options.UseFont = true;
            this.lblFechaNacimiento.Appearance.Options.UseTextOptions = true;
            this.lblFechaNacimiento.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lblFechaNacimiento.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblFechaNacimiento.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblFechaNacimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(267, 73);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(562, 33);
            this.lblFechaNacimiento.TabIndex = 22;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblNumeroIdentidad
            // 
            this.lblNumeroIdentidad.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroIdentidad.Appearance.Options.UseFont = true;
            this.lblNumeroIdentidad.Appearance.Options.UseTextOptions = true;
            this.lblNumeroIdentidad.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lblNumeroIdentidad.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblNumeroIdentidad.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblNumeroIdentidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNumeroIdentidad.Location = new System.Drawing.Point(267, 40);
            this.lblNumeroIdentidad.Name = "lblNumeroIdentidad";
            this.lblNumeroIdentidad.Size = new System.Drawing.Size(562, 33);
            this.lblNumeroIdentidad.TabIndex = 21;
            this.lblNumeroIdentidad.Text = "Número de Identidad";
            // 
            // lblNombreColaborador
            // 
            this.lblNombreColaborador.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreColaborador.Appearance.Options.UseFont = true;
            this.lblNombreColaborador.Appearance.Options.UseTextOptions = true;
            this.lblNombreColaborador.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lblNombreColaborador.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.lblNombreColaborador.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblNombreColaborador.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblNombreColaborador.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombreColaborador.Location = new System.Drawing.Point(267, 0);
            this.lblNombreColaborador.Name = "lblNombreColaborador";
            this.lblNombreColaborador.Size = new System.Drawing.Size(562, 40);
            this.lblNombreColaborador.TabIndex = 20;
            this.lblNombreColaborador.Text = "Nombre de Colaborador";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureEdit1.EditValue = global::Core.Properties.Resources.icon_no_foto_512;
            this.pictureEdit1.Location = new System.Drawing.Point(829, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.NullText = " ";
            this.pictureEdit1.Properties.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(267, 185);
            this.pictureEdit1.TabIndex = 24;
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Controls.Add(this.navigationPage1);
            this.navigationFrame1.Controls.Add(this.navigationPage2);
            this.navigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame1.Location = new System.Drawing.Point(5, 296);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navigationFrame1.SelectedPage = this.navigationPage2;
            this.navigationFrame1.Size = new System.Drawing.Size(1096, 307);
            this.navigationFrame1.TabIndex = 18;
            this.navigationFrame1.Text = "navigationFrame1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(1096, 307);
            // 
            // navigationPage2
            // 
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(1096, 307);
            // 
            // ctlIngresoAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.navigationFrame1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlEncabezado);
            this.Name = "ctlIngresoAsistencia";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1106, 608);
            this.pnlEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAtras.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picColaborador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit picAtras;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlEncabezado;
        private DevExpress.XtraEditors.LabelControl lblEncabezado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl lblFechaNacimiento;
        private DevExpress.XtraEditors.LabelControl lblNumeroIdentidad;
        private DevExpress.XtraEditors.LabelControl lblNombreColaborador;
        private DevExpress.XtraEditors.PictureEdit picColaborador;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
    }
}
