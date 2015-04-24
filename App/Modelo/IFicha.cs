using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Modelo
{
    interface IFicha
    {
        void Add(Caracterizacion carz1);
        void Enemigo(Personajes prn);
        string Liga(string liga);
    }
}
