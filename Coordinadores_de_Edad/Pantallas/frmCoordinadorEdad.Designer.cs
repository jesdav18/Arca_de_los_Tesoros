﻿namespace Coordinadores_de_Edad.Pantallas
{
    partial class frmCoordinadorEdad
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
            this.ctlContenedorPrincipalCoordinadorEdad1 = new Coordinadores_de_Edad.Controles.ctlContenedorPrincipalCoordinadorEdad();
            this.SuspendLayout();
            // 
            // ctlContenedorPrincipalCoordinadorEdad1
            // 
            this.ctlContenedorPrincipalCoordinadorEdad1.BackColor = System.Drawing.Color.White;
            this.ctlContenedorPrincipalCoordinadorEdad1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlContenedorPrincipalCoordinadorEdad1.Location = new System.Drawing.Point(0, 0);
            this.ctlContenedorPrincipalCoordinadorEdad1.Name = "ctlContenedorPrincipalCoordinadorEdad1";
            this.ctlContenedorPrincipalCoordinadorEdad1.Padding = new System.Windows.Forms.Padding(5);
            this.ctlContenedorPrincipalCoordinadorEdad1.Size = new System.Drawing.Size(1134, 583);
            this.ctlContenedorPrincipalCoordinadorEdad1.TabIndex = 0;
            // 
            // frmCoordinadorEdad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1134, 583);
            this.Controls.Add(this.ctlContenedorPrincipalCoordinadorEdad1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCoordinadorEdad";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.ctlContenedorPrincipalCoordinadorEdad ctlContenedorPrincipalCoordinadorEdad1;
    }
}