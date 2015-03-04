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
        private string nombre;        
        private string direccion;        
        private string ciudad;        
        private string departamento;        
        private string codigoPostalRemitente;        
        private string codigoPostalDestinatario;        
        #endregion

        #region "Propiedades"
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
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
        #endregion

        #region "Constructores"
        public Package() { 
        ///<summary>
        ///Contructor de clase Package
        ///</summary>
        ///
            this.codigo = "1.234.567.890";
            this.nombre = "Nombre De La Persona";
            this.direccion = "Direccion del Destinatario";
            this.ciudad = "Ciudad Destino";
            this.departamento = "Despartamento Destino";
            this.codigoPostalRemitente = "Código postal Remitente";
            this.codigoPostalDestinatario = "Código Postal Destinatario";
        }
        ///<summary>
        ///Contructor de inicialización de Personas
        ///</summary>
        ///
        public Package(string codigo, string nombre, string direccion, string ciudad, string departamento, string codigoPostalRemitente,string codigoPostalDestinatario) {
            this.codigo = codigo;
            this.nombre = nombre;
            this.direccion = direccion;
            this.ciudad = ciudad;
            this.departamento = departamento;
            this.codigoPostalRemitente = codigoPostalRemitente;
            this.codigoPostalDestinatario = codigoPostalDestinatario;
        
        }
        #endregion

        #region"Medotodos Sobreescritos"

        public override string ToString()
        {
            return "Codigo:  " + this.codigo + "\n" +
                     "Nombre: " + this.nombre + "\n" +
                     "Direccion Destino: " + this.direccion + "\n" +
                     "Ciudad Destino: " + this.ciudad + "\n" +
                     "Departamento: " + this.departamento + "\n" +
                     "Codigo Postal del Remitente" + this.codigoPostalRemitente + "\n" +
                     "Codigo Postal del Destinanatio" + this.codigoPostalDestinatario;
        }

        public override bool Equals(object obj)
        {
            Package p = (Package)obj;
            bool result = false;
            if ((this.codigo == p.codigo) &&
                (this.nombre == p.nombre) &&
                (this.direccion == p.direccion) &&
                (this.ciudad == p.ciudad) &&
                (this.departamento == p.departamento) &&
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
    }
}