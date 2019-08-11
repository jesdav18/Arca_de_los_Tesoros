﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coordinadores_de_Edad.Controles
{
    public partial class ctlngresoActividad : UserControl
    {
        public ctlngresoActividad()
        {
            InitializeComponent();
        }

        public event EventHandler OnGuardarPlanificacion;
        private void CmdGuardarPlanificacion_Click(object sender, EventArgs e)
        {
            OnGuardarPlanificacion?.Invoke(sender, e);
        }
    }
}
