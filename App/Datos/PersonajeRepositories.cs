using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using App.Modelo;

namespace App.Datos
{
    public class PersonajeRepositories
    {
        static List<Personajes> data = new List<Personajes>();
       
        
        public void AddPerson(Personajes p)
        {
            data.Add(p);
        }
        public IEnumerable<Personajes> getPersonaje()
        {
            return data;
        }
        
    }
}