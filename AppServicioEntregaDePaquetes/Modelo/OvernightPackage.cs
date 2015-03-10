using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppServicioEntregaDePaquetes.Modelo
{
    public class OvernightPackage : Package
    {
        #region "Atributos"
        private double costoEntregaNocturna;        
        #endregion

        #region "Propiedades"

        public double CostoEntregaNocturna
        {
            get { return costoEntregaNocturna; }
            set { costoEntregaNocturna = value; }
        }       
        
        #endregion

        #region "Constructores"

        public OvernightPackage()
            : base()
        {
            this.costoEntregaNocturna = 0.0;
        }

        public OvernightPackage(string codigo, string nombre, string direccion, string ciudad, string departamento, string codigoPostalRemitente,string codigoPostalDestinatario, double peso, double costoPorGr, double valorTotal, double costoEntregaNocturna)
            : base(codigo, nombre, direccion, ciudad, departamento, codigoPostalRemitente, codigoPostalDestinatario, peso, costoPorGr, valorTotal)
        {
            this.costoEntregaNocturna = this.costoEntregaNocturna;
        }        
        #endregion


        #region "Metodos Sobreescritos"

        public override string ToString()
        {
            return "Costo por envio nocturno: $" + this.costoEntregaNocturna;
        }

        public override bool Equals(object obj)
        {
            OvernightPackage p3 = (OvernightPackage)obj;
            bool result = false;
            if (this.costoEntregaNocturna == p3.costoEntregaNocturna)
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
            this.ValorTotal = this.Peso * this.CostoPorGr + this.costoEntregaNocturna;
        }

        #endregion


    }
}