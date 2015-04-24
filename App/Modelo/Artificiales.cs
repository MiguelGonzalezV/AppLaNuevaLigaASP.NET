using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class Artificiales: Personajes,IFicha
    {
        #region "Atributos"
        private string tipoArtificial;
        private List<Caracterizacion> caracterizacion = new List<Caracterizacion>();
        private List<Personajes> enemigo = new List<Personajes>();
        private static string liga1 = "";
        #endregion

        #region "Propiedades"
        public string TipoArtificial
        {
            get { return tipoArtificial; }
            set { tipoArtificial = value; }
        }
        #endregion

        #region "Constructores"
        public Artificiales()
            : base()
        {
            this.tipoArtificial = "All Artificial";
        }
        public Artificiales(string sexo, string complexion, string nombre, string modalidad, string tipoArtificial)
            : base(sexo, complexion, nombre, modalidad)
        {
            this.tipoArtificial = tipoArtificial;
        }
        #endregion

        #region "Métodos SobreEscritos"
        public override string ToString()
        {
            return base.ToString() +
                                "\nTipo Artificial: " + this.tipoArtificial;
            
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Artificiales o = (Artificiales)obj;
            bool result = false;

            if (base.Equals(o) && (this.tipoArtificial == o.tipoArtificial))
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
        public void Liga(string liga)
        {
            liga1 = liga;
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
        public override string liga()
        {
            return "Liga: "+liga1.ToString();
        }
        #endregion

    }
}