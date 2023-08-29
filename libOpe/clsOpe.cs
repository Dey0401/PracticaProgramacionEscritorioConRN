using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libRn;

namespace libOpe
{
    public class clsOpe
    {
        #region Attributes
        private string _strError;
        #endregion

        #region Constructor
        public clsOpe()
        {
            _strError = string.Empty;
        }
        //Constructor con sobre carga inicializando las variables con los valores que recibe
        public clsOpe(string strError)
        {
           
            _strError = strError;
        }
        #endregion

        #region Properties
        public string Error
        {
            get { return _strError; }
        }
        #endregion

        #region Metoths
        public bool ProcesoRequerido()
        {
            float subTot = 0;
            clsRn oRn = new clsRn();
            try
            {
                //Enviar info a clase 
                //oRn.tipoEstudiante = _intTipoEst;
                //oRn.Promedio = _fltProm;
                //Invocacion del metodo y tto del error
                if (!oRn.hallarDatos())
                {
                    _strError = oRn.Error;
                    return false;
                }
                //Recuperar información
                //_fltValCredito = oRn.valorCredito;
                //_intCredit = oRn.numCreditos;
                //subTot = _intCredit * _fltValCredito;
                //_fltValDescuento = subTot * oRn.Descuento / 100;
            }
            catch (Exception ex)
            {
                _strError = ex.Message;
                return false;
            }
            finally
            {
                oRn = null; //No es obligatorio pero lo vuelve mas rapido
            }
            if (true)
            {
                //_fltValPago = (_fltValCredito * _intCredit) - _fltValDescuento;
                return true;
            }
            else
            {
                _strError = "Errores";
                return false;
            }
        }
        #endregion

    }
}
