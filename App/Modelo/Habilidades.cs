using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class Habilidades:Caracterizacion
    {
        #region "Atributos"
        private string tipoHabilidad;
        #endregion

        #region "Propiedades"
        public string TipoHabilidad
        {
            get { return tipoHabilidad; }
            set { tipoHabilidad = value; }
        }
        #endregion

        #region "Constructores"
        public Habilidades()
            : base()
        {
            this.tipoHabilidad = "Vuelo";
        }
        public Habilidades(string tipoHabilidad)
            : base()
        {
            this.tipoHabilidad = tipoHabilidad;
        }
        #endregion

        #region "Métodos SobreEscritos"
        public override string ToString()
        {
            return base.ToString() +
                "\nTipo de Habilidad " + this.tipoHabilidad;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Habilidades o = (Habilidades)obj;
            bool result = false;
            if (base.Equals(o) && (this.tipoHabilidad == o.tipoHabilidad))
                result = true;
            return result;
        }
        #endregion

    }
}