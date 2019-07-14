using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Devart.Data.PostgreSql;

namespace Core.Pantallas
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin(PgSqlConnection pConexion)
        {
            InitializeComponent();
            ctlLogin1.ConstruirControl(pConexion);
            ctlLogin1.OnUsuarioLogueado += ctlLogin1_OnUsuarioLogueado;
        }


        public event EventHandler OnUsuarioLogueado;

        private void ctlLogin1_OnUsuarioLogueado(object sender, EventArgs e)
        {
            OnUsuarioLogueado?.Invoke(sender, e);
        }

        private void FrmLogin_Shown(object sender, EventArgs e)
        {
            ctlLogin1.Left = (this.ClientSize.Width - ctlLogin1.Width) / 2;
            ctlLogin1.Top = (this.ClientSize.Height - ctlLogin1.Height) / 2;
        }
    }
}