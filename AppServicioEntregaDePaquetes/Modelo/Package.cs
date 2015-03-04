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
        #endregion

        #region"Medotodos Sobreescritos"
        #endregion
    }
}