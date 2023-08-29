using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libOpe;

namespace appParcial1
{
    public partial class frmParcial1 : Form 
    {
        public frmParcial1()
        {
            InitializeComponent();
        }

        #region Methots propios
        private void Mensaje(string texto)
        {
            this.MensajError.Text = texto;
        }

        private void Limpiar()
        {

            //this.comboBoxTipoEst.SelectedIndex = 0;
            //foreach (Control c in this.Controls)
            //{
            //    if (c is TextBox)
            //    {
            //        c.Text = string.Empty;
            //    }
            //}
            //this.groupBoxResults.Visible = false;
            //this.comboBoxTipoEst.Focus();
        }
        #endregion

        #region Eventos del objeto
        private void ButtonTerminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonProcesar_Click(object sender, EventArgs e)
        {
            float float1;
            int int1, int2;

            try
            {
                Mensaje("");
                //Captura de datos

                tipoE = this.comboBoxTipoEst.SelectedIndex;
                if (tipoE <= 0)
                {
                    Mensaje("Tipo de estudiante no válido");
                    this.comboBoxTipoEst.Focus();
                    return;
                }
                int1 = Convert.ToInt32(this.textInt1.Text);
                int2 = Convert.ToInt32(this.textInt2.Text);
               

                //Se crea el objeto
                clsOpe oP = new clsOpe();
                //Enviar informaciòn al objeto
                oP.tipoEstudiante = tipoE;
                oP.Promedio = pNota;
                //Invocar el metodo y tratamiento de error
                if (!oP.hallarPago())
                {
                    Mensaje(oP.Error);
                    oP = null;
                    return;
                }
                //Recuperar inforación
                this.textBoxNumCred.Text = oP.numCreditos.ToString();
                this.txtVrCred.Text = oP.ValorCred.ToString();
                this.txtDscto.Text = oP.Descuento.ToString();
                this.txtVrPagar.Text = oP.valorPago.ToString();
                this.groupBoxResults.Visible = true;
                oP = null;
            }
            catch (Exception ex)
            {
                Mensaje(ex.Message);
            }
        }
        #endregion
    }
}
