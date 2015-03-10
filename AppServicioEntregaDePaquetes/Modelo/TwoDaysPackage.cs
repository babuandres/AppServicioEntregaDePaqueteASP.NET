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

        #region "Metodos Sobreescritos"

         public override string ToString()
         {
             return "Cuota Fija de Envio: $" + this.cuotaFija;
         }

         public override bool Equals(object obj)
         {
             TwoDaysPackage p2 = (TwoDaysPackage)obj;
             bool result = false;
             if (this.cuotaFija == p2.cuotaFija)
                 result = true;
             return result;
         }

         public override int GetHashCode()
         {
             return this.ToString().GetHashCode();
         }
        #endregion

        #region "Metodos"
         public void calculateCost()
         {
             this.ValorTotal = this.Peso * this.CostoPorGr + this.cuotaFija;
         }
        #endregion





    }
}