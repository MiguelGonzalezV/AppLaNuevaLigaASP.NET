using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public abstract class Caracterizacion
    {
        #region "Constructores"
        public Caracterizacion()
        {
          
        }
        #endregion

        #region "Métodos SobreEscritos"
        public override string ToString()
        {
            return "";
        }
        public override bool Equals(object obj)
        {
            return Equals(obj);
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        #endregion
    }
}