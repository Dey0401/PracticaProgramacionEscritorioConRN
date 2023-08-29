using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace libRn
{
    public class clsRn
    {
        //Propiedades y atributos segun lo que necesite leer el txt 
        //Recordar que el txt va en la ruta appPractica1\bin\Debug

        #region Attributes
        private string _strError;
        #endregion

        #region Constructor
        public clsRn()
        {
            _strError = string.Empty;
        }
        #endregion

        #region Properties
        public string Error
        {
            get => _strError;
            set => _strError = value;
        }
        #endregion

        #region Methotd privates
        //Se validan posibles errores
        private bool Validar()
        {
            //    if ()
            //    {
            //        _strError = "Error";
            //        return false;
            //    }
            //    if ()
            //    {
            //        _strError = "Error";
            //        return false;
            //    }
               return true;

            }

            private bool leerArchivo()
            {
                if (!Validar())
                    return false;
                try
                {
                    string strPath = AppDomain.CurrentDomain.BaseDirectory + @"Parcial1.txt";
                    int intCant = 0;
                    string strLinea;
                    string[] vectorLinea;
                    string strCodigo; //atributo propio que toma
                    float fltNota; //atributo propio que toma
                    intCant = File.ReadAllLines(strPath).Length;
                    if (intCant <= 0)
                        return true;
                    StreamReader Archivo = new StreamReader(@strPath); //Crear objeto para leer el archivo
                    while ((strLinea = Archivo.ReadLine()) != null)      //Leer línea * línea el archivo
                    {
                        vectorLinea = strLinea.Split(':');
                        strCodigo = vectorLinea[0];          //Tipo de estudiante (Programa)
                        fltNota = Convert.ToSingle(vectorLinea[1]);  //Promedio mínimo de nota
                        //if (strCodigo == _intTipoEst.ToString() && _fltProm >= fltNota)
                        {
                            //_fltValCredito = Convert.ToSingle(vectorLinea[2]); //Valor crédito
                            //_intCredit = Convert.ToInt16(vectorLinea[3]); //Cantidad Créditos
                            //_fltDesc = Convert.ToSingle(vectorLinea[4]); //Porcentaje de Dscto
                            break;
                        }
                    }
                    Archivo.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    _strError = ex.Message;
                    return false;
                }
            }
            #endregion

            #region Methotd public
            public bool hallarDatos()
            {
                return leerArchivo();
            }
            #endregion
        }
    }

