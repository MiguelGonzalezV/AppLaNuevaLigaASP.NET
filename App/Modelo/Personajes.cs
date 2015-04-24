using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public abstract class Personajes
    {
        #region "Atributos"
        protected string sexo;
        protected string complexion;
        protected string nombre;
        protected string modalidad;
        #endregion

        #region "Propiedades"
        protected string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        protected string Complexion
        {
            get { return complexion; }
            set { complexion = value; }
        }
        protected string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        protected string Modalidad
        {
            get { return modalidad; }
            set { modalidad = value; }

        }
        #endregion

        #region "Constructores"
        public Personajes()
        {
            this.sexo = "Masculino";
            this.complexion = "Alto Robusto";
            this.nombre = "Iron Man";
            this.modalidad = "Villano";
        }
        public Personajes(string sexo, string complexion, string nombre, string modalidad)
        {
            this.sexo = sexo;
            this.complexion = complexion;
            this.nombre = nombre;
            this.modalidad = modalidad;
        }
        #endregion

        #region "Métodos SobreEscritos"
        public override string ToString()
        {
            return "\nCode: " + this.sexo +
                   "\nWight: " + this.complexion +
                   "\nNombre: " + this.nombre +
                   "\nModalidad: " + this.modalidad;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Personajes o = (Personajes)obj;
            bool result = false;

            if ((this.sexo == o.sexo) &&
                (this.complexion == o.complexion)&&
                (this.nombre == o.nombre)&&
                (this.modalidad == o.modalidad))
                result = true;
            return result;
        }
        #endregion

        #region "Abstractos"
        public abstract string imprimirEnemigo();
        public abstract string imprimirCaracterizaciones();
        #endregion
    }
}
