using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class Mutantes:Personajes, IFicha
    {
        #region "Atributos"
        private string genetica;
        private string tipoEspecie;
        private List<Caracterizacion> caracterizacion = new List<Caracterizacion>();
        private List<Personajes> enemigo = new List<Personajes>();
        private static string liga1 = "";
        #endregion

        #region "Propiedades"
        public string Genetica
        {
            get { return genetica; }
            set { genetica = value; }
        }    
        public string TipoEspecie
        {
            get { return tipoEspecie; }
            set { tipoEspecie = value; }
        }
        #endregion

        #region "Constructores"
        public Mutantes()
            : base()
        {
            this.genetica = "Natural";
            this.tipoEspecie = "Animal";
        }
        public Mutantes(string sexo, string complexion, string nombre, string modalidad, string genetica, string tipoEspecie)
            : base(sexo, complexion, nombre, modalidad)
        {
            this.genetica = genetica;
            this.tipoEspecie = tipoEspecie;
        }
        #endregion

        #region "Métodos SobreEscritos"
        public override string ToString()
        {
            return base.ToString() +
                               "\nTipo de Genetica: " + this.genetica+
                               "\nTipo de Especie: "+this.tipoEspecie;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Mutantes o = (Mutantes)obj;
            bool result = false;

            if (base.Equals(o) && (this.genetica == o.genetica)&&
                (this.tipoEspecie == o.tipoEspecie))

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