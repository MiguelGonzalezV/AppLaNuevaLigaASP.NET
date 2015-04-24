using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class Armas:Caracterizacion
    {
        #region "Atributos"
        private string tipoArma;
        #endregion

        #region "Propiedades"
        public string TipoArma
        {
            get { return tipoArma; }
            set { tipoArma = value; }
        }
        #endregion

        #region "Constructores"
        public Armas()
            : base()
        {
            this.tipoArma = "Arco";
        }
        public Armas(string tipoArma)
            : base()
        {
            this.tipoArma = tipoArma;
        }
        #endregion

        #region "Métodos SobreEscritos"
        public override string ToString()
        {
            return base.ToString() +
                "\nTipo de Arma " + this.tipoArma;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Armas o = (Armas)obj;
            bool result = false;
            if (base.Equals(o) && (this.tipoArma == o.tipoArma))
                result = true;
            return result;
        }
        #endregion
    }
}