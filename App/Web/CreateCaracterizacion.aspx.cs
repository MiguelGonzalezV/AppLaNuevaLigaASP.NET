using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using App.Modelo;
using App.Datos;

namespace App.Web
{
    public partial class CreateCaracterizacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void buttonSendCaract_Click(object sender, EventArgs e)
        {
            string tipoPoder = DropDownListPoder.SelectedItem.Value;
            Poderes carac1 = new Poderes(tipoPoder);

            string tipoHabilidad = DropDownListHabilidad.SelectedItem.Value;
            Habilidades carac2 = new Habilidades(tipoHabilidad);

            string tipoArma = DropDownListArma.SelectedItem.Value;
            Armas carac3 = new Armas(tipoArma);

            string tipoPersonalidad = DropDownListPersonalidad.SelectedItem.Value;
            Personalidad carac4 = new Personalidad(tipoPersonalidad);

            string tipoDebilidad = DropDownListDebilidad.SelectedItem.Value;
            Debilidades carac5 = new Debilidades(tipoDebilidad);

            CaracterizacionRepositories pp = new CaracterizacionRepositories();
            pp.Poderes(carac1);
            pp.Habilidades(carac2);
            pp.Armas(carac3);
            pp.Personalidad(carac4);
            pp.Debilidades(carac5);
            Server.Transfer("CreatePersonajes.aspx");
        }
    }
}