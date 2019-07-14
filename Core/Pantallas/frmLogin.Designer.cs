namespace Core.Pantallas
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctlLogin1 = new Core.Controles.ctlLogin();
            this.SuspendLayout();
            // 
            // ctlLogin1
            // 
            this.ctlLogin1.BackColor = System.Drawing.Color.White;
            this.ctlLogin1.Location = new System.Drawing.Point(201, 54);
            this.ctlLogin1.MaximumSize = new System.Drawing.Size(595, 660);
            this.ctlLogin1.MinimumSize = new System.Drawing.Size(595, 660);
            this.ctlLogin1.Name = "ctlLogin1";
            this.ctlLogin1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctlLogin1.Pro_Conexion = null;
            this.ctlLogin1.Size = new System.Drawing.Size(595, 660);
            this.ctlLogin1.TabIndex = 0;
            // 
            // frmLogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 813);
            this.Controls.Add(this.ctlLogin1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.ctlLogin ctlLogin1;
    }
}