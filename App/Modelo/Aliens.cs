using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class Aliens : Personajes, IFicha
    {
        #region "Atributos"
        private string planetaOrigen;
        private List<Caracterizacion> caracterizacion = new List<Caracterizacion>();
        private List<Personajes> enemigo = new List<Personajes>();
        #endregion

        #region "Propiedades"
        public string PlanetaOrigen
        {
            get { return planetaOrigen; }
            set { planetaOrigen = value; }
        }
        #endregion

        #region "Constructores"
        public Aliens()
            : base()
        {
            this.planetaOrigen = "Martes";
        }
        public Aliens(string sexo, string complexion, string nombre, string modalidad, string planetaOrigen)
            : base(sexo, complexion, nombre, modalidad)
        {
            this.planetaOrigen = planetaOrigen;

        }
        #endregion

        #region "Métodos SobreEscritos"
        public override string ToString()
        {
            return base.ToString()+
                               "\nPlaneta de Origen: " + this.planetaOrigen;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Aliens o = (Aliens)obj;
            bool result = false;

            if (base.Equals(o) && (this.planetaOrigen == o.planetaOrigen))

                result = true;

            return result;
        }
        #endregion

        #region "Métodos de la Interface"
        public void Add(Caracterizacion carz1)
        {
            caracterizacion.Add(carz1);
        }
        public void Enemigo(Personajes persn)
        {
            enemigo.Add(persn);
        }
        public string Liga(string liga)
        {
            return "\nLiga = " + liga;
        }
        #endregion

        #region "Metodos Heredados"
        public override string imprimirEnemigo()
        {
            string result = "";
            foreach (Personajes persn in enemigo)
                result += "\n" + persn;
            return "\nEnemigo= " + result;
        }
        public override string imprimirCaracterizaciones()
        {
            string result = "";
            foreach (Caracterizacion carc in caracterizacion)
                result += "\n" + carc;
            return "\nCaracterización= " + result;
        }
        #endregion



    }
}