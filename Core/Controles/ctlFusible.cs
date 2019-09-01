using System;
using System.Drawing;
using System.Windows.Forms;

namespace Core.Controles
{
    public partial class ctlFusible : UserControl
    {
        #region INICIALIZADOR
        public ctlFusible()
        {
            InitializeComponent();

            picImagenCircular.Parent = this;
            lblValor.Parent = picImagenCircular;
        }
        #endregion

        #region ENUMERACIONES

        public enum FUSIBLE_COLOR
        {
            DEFAULT = 0,
            ROJO = 1,
            NARANJA = 2
        }

        #endregion

        #region PROPIEDADES

        public int Pro_Valor
        {
            get
            {
                try
                {
                    return Convert.ToInt32(lblValor.Text);
                }
                catch (Exception)
                {
                    return 0;
                }
            }

            set
            {
                lblValor.Text = value.ToString();

                if (value > 0)
                {
                    if (!tmrParpadeo.Enabled)
                    {
                        tmrParpadeo.Start();
                    }

                    if (Pro_EsSecundario)
                    {
                        picImagenCircular.Visible = true;
                        lblValor.Visible = true;
                    }
                }
                else
                {
                    if (Pro_EsSecundario)
                    {
                        picImagenCircular.Visible = false;
                        lblValor.Visible = false;
                    }

                    if (tmrParpadeo.Enabled)
                    {
                        tmrParpadeo.Stop();
                    }
                }
            }
        }

        public bool Pro_EsSecundario
        {
            get;
            set;
        }

        public bool Pro_EncenderFusible
        {
            get;
            private set;
        }

        public FUSIBLE_COLOR Pro_TipoColor
        {
            get;
            set;
        }

        #region VARIABLES GLOBALES

        bool v_parpadeo_rojo;
        bool v_parpadeo_naranja;

        #endregion

        #endregion

        #region EVENTOS

        public event EventHandler OnClicFusible;

        #endregion

        #region FUNCIONES

        public void ConstruirControl(int pConteo,
                                     bool p_EncenderFusible = true,
                                     bool pEsSecundario = false)
        {
            Pro_EsSecundario = pEsSecundario;
            Pro_EncenderFusible = p_EncenderFusible;
            Pro_Valor = pConteo;
         
        }

        #endregion

        #region EVENTOS CONTROLES

        private void tmrParpadeo_Tick(object sender, EventArgs e)
        {
            try
            {
                picImagenCircular.Image = Properties.Resources.icon_fusible_blanco_64;
                lblValor.BackColor = Color.White;
                lblValor.ForeColor = Color.Black;
                lblValor.Visible = true;

                if (Pro_Valor != 0 && Pro_EncenderFusible)
                {
                    if ((int)Pro_TipoColor == 0)
                    {
                        switch (Pro_TipoColor)
                        {
                            case FUSIBLE_COLOR.ROJO:

                                picImagenCircular.Image = Properties.Resources.icon_fusible_rojo_64;
                                lblValor.BackColor = Color.FromArgb(209, 12, 12);
                                lblValor.ForeColor = Color.White;

                                break;

                            case FUSIBLE_COLOR.DEFAULT:

                                picImagenCircular.Image = Properties.Resources.icon_fusible_blanco_64;
                                lblValor.BackColor = Color.Transparent;
                                lblValor.ForeColor = Color.Black;

                                break;
                        }                
                    }

                    if (v_parpadeo_rojo)
                    {
                        v_parpadeo_rojo = false;
                        picImagenCircular.Image = Properties.Resources.icon_fusible_blanco_64;
                        lblValor.BackColor = Color.Transparent;
                        lblValor.ForeColor = Color.Black;
                    }
                    else
                    {
                        picImagenCircular.Image = Properties.Resources.icon_fusible_rojo_64;
                        lblValor.BackColor = Color.FromArgb(209, 12, 12);
                        lblValor.ForeColor = Color.Transparent;
                        v_parpadeo_rojo = true;
                    }
                }
                else
                {
                    v_parpadeo_rojo = false;
                    picImagenCircular.Image = Properties.Resources.icon_fusible_blanco_64;
                    lblValor.BackColor = Color.Transparent;
                    lblValor.ForeColor = Color.Black;
                }
            }
            catch (Exception)
            {

            }
        }

        private void lblValor_Click(object sender, EventArgs e)
        {
            OnClicFusible?.Invoke(sender, e);
        }

        private void picImagenCircular_Click(object sender, EventArgs e)
        {
            OnClicFusible?.Invoke(sender, e);
        }

        #endregion

       
    }
}
