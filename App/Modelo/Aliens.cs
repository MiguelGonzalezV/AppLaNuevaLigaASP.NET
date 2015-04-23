using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class Aliens : Personajes, IFicha
    {
        private string planeta;

        public string Planeta
        {
            get { return planeta; }
            set { planeta = value; }
        }
        public Aliens()
            : base()
        {

        }
        public Aliens(string sexo, string complexion, string nombre, string planeta)
            : base(sexo, complexion, nombre)
        {
            this.planeta = planeta;

        }
        public override string ToString()
        {
            return base.ToString()+
                               "\nPlaneta de Origen: " + this.planeta;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Aliens o = (Aliens)obj;
            bool result = false;

            if (base.Equals(o) && (this.planeta == o.planeta))

                result = true;

            return result;
        }

    }
}