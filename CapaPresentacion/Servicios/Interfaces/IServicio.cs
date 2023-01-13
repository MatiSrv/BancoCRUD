using DataBanco.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Servicios.Interfaces
{
    public interface IServicio
    {
        List<Cliente> ListClientes();
        List<Cuenta> Cuentas();

        bool BajaCliente(int c);
        bool AltaCli(Cliente c);    
        bool Modificacion(Cliente c);
        bool TieneCuentas(int c);


        bool AltaCta(Cuenta c);
        
        bool BajaCuenta(int c);
    }
}
