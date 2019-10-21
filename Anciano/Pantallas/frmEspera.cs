using System;
using DevExpress.XtraWaitForm;

namespace Anciano.Pantallas
{
    public partial class frmEspera : WaitForm
    {
        public frmEspera()
        {
            InitializeComponent();
           
        }

        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
        
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
           
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum WaitFormCommand
        {
        }
    }
}