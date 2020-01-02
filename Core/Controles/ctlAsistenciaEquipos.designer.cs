namespace Core.Controles
{
    partial class ctlAsistenciaEquipos
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            this.dsVistas1 = new Core.DataSets.dsVistas();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.dsVistas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            this.SuspendLayout();
            // 
            // dsVistas1
            // 
            this.dsVistas1.DataSetName = "dsVistas";
            this.dsVistas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chartControl1
            // 
            this.chartControl1.DataSource = this.dsVistas1.dtMiEquipo;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Interlaced = true;
            xyDiagram1.AxisY.MinorCount = 4;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(5, 5);
            this.chartControl1.Name = "chartControl1";
            series1.ArgumentDataMember = "dtAsistenciasEquipos.descripcion";
            series1.DataSource = this.dsVistas1;
            series1.Name = "Asistencias";
            series1.Tag = "";
            series1.ValueDataMembersSerializable = "dtAsistenciasEquipos.asistencias";
            series2.ArgumentDataMember = "dtAsistenciasEquipos.descripcion";
            series2.DataSource = this.dsVistas1;
            series2.Name = "Inasistencias";
            series2.ValueDataMembersSerializable = "dtAsistenciasEquipos.inasistencias";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chartControl1.SeriesTemplate.SeriesColorizer = null;
            this.chartControl1.Size = new System.Drawing.Size(959, 381);
            this.chartControl1.TabIndex = 16;
            // 
            // ctlAsistenciaEquipos
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.chartControl1);
            this.Name = "ctlAsistenciaEquipos";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(969, 391);
            ((System.ComponentModel.ISupportInitialize)(this.dsVistas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chrTraficoClientes;      
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblTituloDashboard;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DataSets.dsVistas dsVistas1;
    }
}
