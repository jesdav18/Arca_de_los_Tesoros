namespace Core.Controles.Cumpleanieros
{
    partial class ctlContenedorCumpleanieros
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
            this.ctlCumpleanierosDia1 = new Core.Controles.Cumpleanieros.ctlCumpleanierosDia();
            this.ctlProximosCumpleanieros1 = new Core.Controles.Cumpleanieros.ctlProximosCumpleanieros();
            this.SuspendLayout();
            // 
            // ctlCumpleanierosDia1
            // 
            this.ctlCumpleanierosDia1.BackColor = System.Drawing.Color.White;
            this.ctlCumpleanierosDia1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlCumpleanierosDia1.Location = new System.Drawing.Point(5, 5);
            this.ctlCumpleanierosDia1.Name = "ctlCumpleanierosDia1";
            this.ctlCumpleanierosDia1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlCumpleanierosDia1.Pro_Conexion = null;
            this.ctlCumpleanierosDia1.Size = new System.Drawing.Size(993, 357);
            this.ctlCumpleanierosDia1.TabIndex = 0;
            // 
            // ctlProximosCumpleanieros1
            // 
            this.ctlProximosCumpleanieros1.BackColor = System.Drawing.Color.White;
            this.ctlProximosCumpleanieros1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlProximosCumpleanieros1.Location = new System.Drawing.Point(5, 362);
            this.ctlProximosCumpleanieros1.Name = "ctlProximosCumpleanieros1";
            this.ctlProximosCumpleanieros1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlProximosCumpleanieros1.Pro_Conexion = null;
            this.ctlProximosCumpleanieros1.Size = new System.Drawing.Size(993, 306);
            this.ctlProximosCumpleanieros1.TabIndex = 1;
            // 
            // ctlContenedorCumpleanieros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctlProximosCumpleanieros1);
            this.Controls.Add(this.ctlCumpleanierosDia1);
            this.Name = "ctlContenedorCumpleanieros";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1003, 673);
            this.ResumeLayout(false);

        }

        #endregion

        private ctlCumpleanierosDia ctlCumpleanierosDia1;
        private ctlProximosCumpleanieros ctlProximosCumpleanieros1;
    }
}
