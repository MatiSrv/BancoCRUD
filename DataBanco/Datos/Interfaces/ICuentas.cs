using DataBanco.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBanco.Datos.Interfaces
{
    public interface ICuentas
    {
        bool Alta(Cuenta c);
        bool Baja(int c);
        

        List<Cuenta> Cargar_Cuentas();
    }
}
