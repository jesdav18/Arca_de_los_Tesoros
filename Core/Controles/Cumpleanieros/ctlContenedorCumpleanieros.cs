
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Core.Clases;

namespace Core.Controles.Cumpleanieros
{
    public partial class ctlContenedorCumpleanieros : UserControl
    {
        #region INICIALIZADOR

        public ctlContenedorCumpleanieros()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public string Pro_Dia { get; set; }

        #endregion

        #region FUNCIONES
    
        public void ConstruirControl(PgSqlConnection pConexion)
        {
            splashScreenManager1.ShowWaitForm();
            Pro_Conexion = pConexion;
            Pro_Dia = Utilidades.ObtenerFechaServidor(Pro_Conexion);
            ctlCumpleanierosDia1.ConstruirControl(Pro_Conexion,Pro_Dia);
            ctlProximosCumpleanieros1.ConstruirControl(Pro_Conexion);
            splashScreenManager1.CloseWaitForm();
        }

        #endregion
    }
}
