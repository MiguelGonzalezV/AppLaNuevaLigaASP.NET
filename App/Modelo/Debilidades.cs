using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class Debilidades: Caracterizacion
    {
        #region "Atributos"
        private string tipoDebilidad;
        #endregion

        #region "Propiedades"
        public string TipoDebilidad
        {
            get { return tipoDebilidad; }
            set { tipoDebilidad = value; }
        }
        #endregion

        #region "Constructores"
        public Debilidades()
            : base()
        {
            this.tipoDebilidad = "Kriptonita";
        }
        public Debilidades(string tipoDebilidad)
            : base()
        {
            this.tipoDebilidad = tipoDebilidad;
        }
        #endregion

        #region "Métodos SobreEscritos"
        public override string ToString()
        {
            return base.ToString() +
                "\nTipo de Debilidad " + this.tipoDebilidad;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Debilidades o = (Debilidades)obj;
            bool result = false;
            if (base.Equals(o) && (this.tipoDebilidad == o.tipoDebilidad))
                result = true;
            return result;
        }
        #endregion

    }
}