using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Clases
{
    public class Usuario
    {
        #region PROPIEDADES

        public int Pro_ID_Colaborador { get; set; }
        public string Pro_NombreColaborador { get; set; }
        public string Pro_Usuario { get; set; }
        public int Pro_ID_RolUsuario { get; set; }
        public string Pro_DescripcionRolUsuario { get; set; }
        public string Pro_DescripcionCargo { get; set; }
        public int Pro_ID_Cargo { get; set; }
        public string Pro_NombreEquipo { get; set; }
        public int Pro_ID_AreaAtencion { get; set; }


        #endregion
    }
}
