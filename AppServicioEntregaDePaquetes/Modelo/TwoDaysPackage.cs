using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppServicioEntregaDePaquetes.Modelo
{
    public class TwoDaysPackage : Package
    {
        #region "Atributos"
        private double cuotaFija;        
        #endregion

        #region "Propiedades"
        public double CuotaFija
        {
            get { return cuotaFija; }
            set { cuotaFija = value; }
        }
        #endregion

        #region "Constructores"
        
        public TwoDaysPackage() : base ()
        {

            this.cuotaFija = 0.0;
        }
         public TwoDaysPackage (string codigo, string nombre, string direccion, string ciudad, string departamento, string codigoPostalRemitente,string codigoPostalDestinatario, double peso, double costoPorGr, double valorTotal, double cuotaFija)
            : base(codigo, nombre, direccion, ciudad, departamento, codigoPostalRemitente, codigoPostalDestinatario, peso, costoPorGr, valorTotal)
        {
            this.cuotaFija = cuotaFija;
        }
        #endregion




    }
}