using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class Personalidad:Caracterizacion
    {
        #region "Atributos"
        private string tipoPersonalidad;
        #endregion

        #region "Propiedades"
        public string TipoPersonalidad
        {
            get { return tipoPersonalidad; }
            set { tipoPersonalidad = value; }
        }
        #endregion

        #region "Constructores"
        public Personalidad()
            : base()
        {
            this.tipoPersonalidad = "Cómico";
        }
        public Personalidad(string tipoPersonalidad)
            : base()
        {
            this.tipoPersonalidad = tipoPersonalidad;
        }
        #endregion

        #region "Métodos SobreEscritos"
        public override string ToString()
        {
            return base.ToString() +
                "\nTipo de Personalidad " + this.tipoPersonalidad;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Personalidad o = (Personalidad)obj;
            bool result = false;
            if (base.Equals(o) && (this.tipoPersonalidad == o.tipoPersonalidad))
                result = true;
            return result;
        }
        #endregion
    }
}