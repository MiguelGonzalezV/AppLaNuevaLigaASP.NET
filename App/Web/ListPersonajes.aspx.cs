using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using App.Datos;
using App.Modelo;

namespace App.Web
{
    public partial class ListPersonajes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = "";
            PersonajeRepositories per = new PersonajeRepositories();
            foreach (Personajes p in per.getPersonaje())
                result += p.ToString().Replace("\n", "</br>") + p.imprimirEnemigo().Replace("\n", "</br>") + p.imprimirCaracterizaciones().Replace("\n", "</br>") + p.liga().Replace("\n", "</br>");
            Label1.Text = result;
        }
    }
}