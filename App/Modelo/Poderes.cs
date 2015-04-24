using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class Poderes:Caracterizacion
    {
        #region "Atributos"
        private string tipoPoder;
        #endregion

        #region "Propiedades"
        public string TipoPoder
        {
            get { return tipoPoder; }
            set { tipoPoder = value; }
        }
        #endregion

        #region "Constructores"
        public Poderes()
            : base()
        {
            this.tipoPoder = "Fuego";
        }
        public Poderes(string tipoPoder)
            : base()
        {
            this.tipoPoder = tipoPoder;
        }
        #endregion

        #region "Métodos SobreEscritos"
        public override string ToString()
        {
            return base.ToString() +
                "\nTipo de Poder " + this.tipoPoder;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Poderes o = (Poderes)obj;
            bool result = false;
            if (base.Equals(o) && (this.tipoPoder == o.tipoPoder))
                result = true;
            return result;
        }
        #endregion

    }
}