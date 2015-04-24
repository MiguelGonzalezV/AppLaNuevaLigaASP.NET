using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class SuperHumanos : Personajes, IFicha
    {
        #region "Atributos"
        private string traje;
        private static List<Caracterizacion> caracterizacion = new List<Caracterizacion>();
        private static List<Personajes> enemigo = new List<Personajes>();
        private static string liga1="";
        #endregion

        #region "Propiedades"
        public string Traje
        {
            get { return traje; }
            set { traje = value; }
        }
        #endregion

        #region "Constructores"
        public SuperHumanos()
            : base()
        {
            this.traje = "robotico";
        }
        public SuperHumanos(string sexo, string complexion, string nombre, string modalidad, string traje)
            : base(sexo, complexion, nombre, modalidad)
        {
            this.traje = traje;
        }
        #endregion

        #region "Métodos SobreEscritos"
        public override string ToString()
        {
            return base.ToString() +
                               "\nTipo de traje: " + this.traje;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            SuperHumanos o = (SuperHumanos)obj;
            bool result = false;

            if (base.Equals(o) && (this.traje == o.traje))

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
                result += "\n" + persn.Nombre.ToString();
            return "\nEnemigo= " + result;
        }
        public override string imprimirCaracterizaciones()
        {
            string result = "";
            foreach (Poderes carc in caracterizacion)
                result += "\n" + carc.ToString();
            return "\nCaracterización= " + result;
        }
        public override string liga()
        {
            return "Liga: "+liga1.ToString();
        }
        #endregion
    }
}