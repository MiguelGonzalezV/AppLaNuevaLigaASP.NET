using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using App.Modelo;
namespace App.Datos
{
    public class CaracterizacionRepositories
    {
        static List<Poderes> data2 = new List<Poderes>();
        public void Poderes(Poderes p)
        {
            data2.Add(p);

        }
        public IEnumerable<Poderes> getPoderes()
        {
            return data2;
        }
        static List<Habilidades> data3 = new List<Habilidades>();
        public void Habilidades(Habilidades p)
        {
            data3.Add(p);

        }
        public IEnumerable<Habilidades> getHabilidades()
        {
            return data3;
        }
        static List<Armas> data4 = new List<Armas>();
        public void Armas(Armas p)
        {
            data4.Add(p);

        }
        public IEnumerable<Armas> getArmas()
        {
            return data4;
        }
        static List<Personalidad> data5 = new List<Personalidad>();
        public void Personalidad(Personalidad p)
        {
            data5.Add(p);

        }
        public IEnumerable<Personalidad> getPersonalidad()
        {
            return data5;
        }
        static List<Debilidades> data6 = new List<Debilidades>();
        public void Debilidades(Debilidades p)
        {
            data6.Add(p);

        }
        public IEnumerable<Debilidades> getDebilidades()
        {
            return data6;
        }
    }
}