using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppServicioEntregaDePaquetes.Modelo
{
    public class Package
    {
        #region "Atributos"
        private string codigo;       
        private string nombreRemitente;
        private string nombreDestinatario;        
        private string direccionRemitente;
        private string direccionDestinatario;        
        private string ciudadRemitente;
        private string ciudadDestinatario;        
        private string departamentoRemitente;
        private string departamentoDestinatario;        
        private string codigoPostalRemitente;        
        private string codigoPostalDestinatario;
        private double peso;          
        private double costoPorGr;
        private double valorTotal;        
        #endregion

        #region "Propiedades"
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string NombreRemitente
        {
            get { return nombreRemitente; }
            set { nombreRemitente = value; }
        }

        public string NombreDestinatario
        {
            get { return nombreDestinatario; }
            set { nombreDestinatario = value; }
        }

        public string DireccionRemitente
        {
            get { return direccionRemitente; }
            set { direccionRemitente = value; }
        }

        public string DireccionDestinatario
        {
            get { return direccionDestinatario; }
            set { direccionDestinatario = value; }
        }

        public string CiudadRemitente
        {
            get { return ciudadRemitente; }
            set { ciudadRemitente = value; }
        }

        public string CiudadDestinatario
        {
            get { return ciudadDestinatario; }
            set { ciudadDestinatario = value; }
        }

        public string DepartamentoRemitente
        {
            get { return departamentoRemitente; }
            set { departamentoRemitente = value; }
        }

        public string DepartamentoDestinatario
        {
            get { return departamentoDestinatario; }
            set { departamentoDestinatario = value; }
        }

        public string CodigoPostalRemitente
        {
            get { return codigoPostalRemitente; }
            set { codigoPostalRemitente = value; }
        }

        public string CodigoPostalDestinatario
        {
            get { return codigoPostalDestinatario; }
            set { codigoPostalDestinatario = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }      

        public double CostoPorGr
        {
            get { return costoPorGr; }
            set { costoPorGr = value; }
        }

        public double ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }
        #endregion

        #region "Constructores"
        public Package() { 
        ///<summary>
        ///Contructor de clase Package
        ///</summary>
        ///
            this.codigo = "1.234.567.890";
            this.nombreRemitente = "Nombre De La Persona que Remite";
            this.nombreDestinatario = "Nombre de la Persona que Recibe";
            this.direccionRemitente = "Direccion del Remitente";
            this.direccionDestinatario = "Direccion de la Persona que recibe";
            this.ciudadRemitente = "Ciudad de donde se Envía";
            this.ciudadDestinatario = "Ciudad hacia donde se envía";
            this.departamentoRemitente = "Departamento Remitente";
            this.departamentoDestinatario = "Departamento donde se Recibe";
            this.codigoPostalRemitente = "Código postal Remitente";
            this.codigoPostalDestinatario = "Código Postal Destinatario";
            this.peso = 0.0;
            this.costoPorGr = 0.0;
            this.valorTotal = 0.0;
            
        }
        ///<summary>
        ///Contructor de inicialización de Personas
        ///</summary>
        ///
        public Package(string codigo, string nombre, string direccion, string ciudad, string departamento, string codigoPostalRemitente,string codigoPostalDestinatario, double peso, double costoPorGr, double valorTotal) {
            this.codigo = codigo;
            this.nombreRemitente = nombre;
            this.direccionRemitente = direccion;
            this.ciudadRemitente = ciudad;
            this.departamentoRemitente = departamento;
            this.codigoPostalRemitente = codigoPostalRemitente;
            this.codigoPostalDestinatario = codigoPostalDestinatario;
            this.peso = peso;
            this.costoPorGr = costoPorGr;
            this.valorTotal = valorTotal;
           
        }
        #endregion

        #region"Medotodos Sobreescritos"

        public override string ToString()
        {
            return "Codigo:  " + this.codigo + "\n" +
                     "Nombre: " + this.nombreRemitente + "\n" +
                     "Direccion Destino: " + this.direccionRemitente + "\n" +
                     "Ciudad Destino: " + this.ciudadRemitente + "\n" +
                     "Departamento: " + this.departamentoRemitente + "\n" +
                     "Codigo Postal del Remitente: " + this.codigoPostalRemitente + "\n" +
                     "Codigo Postal del Destinanatio: " + this.codigoPostalDestinatario + "\n" +
                     "Peso: " + this.peso + "Kg" + "\n" +
                     "Costo por Kg: $" + this.costoPorGr + "\n" +
                     "Valor Total del Envio: $" + this.valorTotal;
                     }

        public override bool Equals(object obj)
        {
            Package p = (Package)obj;
            bool result = false;
            if ((this.codigo == p.codigo) &&
                (this.nombreRemitente == p.nombreRemitente) &&
                (this.direccionRemitente == p.direccionRemitente) &&
                (this.ciudadRemitente == p.ciudadRemitente) &&
                (this.departamentoRemitente == p.departamentoRemitente) &&
                (this.codigoPostalRemitente == p.codigoPostalRemitente) &&
                (this.codigoPostalDestinatario == p.codigoPostalDestinatario))
                result = true;

                return result;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        #endregion

        #region"Metodos"
        public void calculateCost()
        {
            this.valorTotal = this.peso * this.costoPorGr;
        }

        #endregion
    }
}