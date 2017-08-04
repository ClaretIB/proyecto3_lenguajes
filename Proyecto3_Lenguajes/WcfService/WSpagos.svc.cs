﻿using Proyecto3_LenguajesData.Business;
using Proyecto3_LenguajesData.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Configuration;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class WSpagos : IWSpgos
    {
        public Pago pagoMatricula(string usuario, string Contrasena)
        {
            EncargadoBusiness encargadoBusiness = new EncargadoBusiness(WebConfigurationManager.ConnectionStrings["ProyectoLenguajes"].ConnectionString);
            Encargado encardado = new Encargado();
            encardado= encargadoBusiness.obtenerEncargado(usuario);
            if (usuario ==encardado.Cedula && Contrasena == encardado.Contrasena)
            {
               return new Pago() { nombre = encardado.Nombre+" "+encardado.Apellidos, monto = 1000, mensaje ="1" };
            }
            else
            {
                return new Pago() {mensaje = "usuario incorrecto" };
            }
        }
    }
}
