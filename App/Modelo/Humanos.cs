using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class Humanos : Personajes, IFicha
    {
        #region "Atributos"
        private string identificacion;
        private List<Caracterizacion> caracterizacion = new List<Caracterizacion>();
        private List<Personajes> enemigo = new List<Personajes>();
        private static string liga1 = "";
        #endregion

        #region "Propiedades"
        public string Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }
        #endregion

        #region "Constructores"
        public Humanos()
            : base()
        {
            this.identificacion = "XXX";
        }
        public Humanos(string sexo, string complexion, string nombre, string modalidad, string identificacion)
            : base(sexo, complexion, nombre, modalidad)
        {
            this.identificacion = identificacion;
        }
        #endregion

        #region "Métodos SobreEscritos"
        public override string ToString()
        {
            return base.ToString() +
                               "\nIdentificación: " + this.identificacion;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Humanos o = (Humanos)obj;
            bool result = false;

            if (base.Equals(o) && (this.identificacion == o.identificacion))

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