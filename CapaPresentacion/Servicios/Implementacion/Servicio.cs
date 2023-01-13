﻿using CapaPresentacion.Servicios.Interfaces;
using DataBanco.Datos.Interfaces;
using DataBanco.Dominio;
using DataBanco.Datos.Implementacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Servicios.Implementacion
{
    public class Servicio : IServicio
    {
        private ICliente cli;
        private ICuentas ctas;
        public Servicio()
        {
            cli = new CRUDcliente();
            ctas = new CRUDcuentas();
        }

        public bool AltaCli(Cliente c)
        {
            return cli.Alta(c);
        }     
        public bool BajaCliente(int c)
        {
            return cli.Baja(c);
        }
        public List<Cuenta> Cuentas()
        {
            return ctas.Cargar_Cuentas();
        }
        public List<Cliente> ListClientes()
        {
            return cli.Cargar_Clientes();
        }
        public bool Modificacion(Cliente c)
        {
            return cli.Modificacion(c);
        }

        

        public bool TieneCuentas(int c)
        {
            return cli.TieneCuentas(c);
        }


        
        public bool AltaCta(Cuenta c)
        {
            return ctas.Alta(c);
        }

        public bool BajaCuenta(int c)
        {
            return ctas.Baja(c);
        }
    }
}
