using Proyecto3_LenguajesData.Data;
using Proyecto3_LenguajesData.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3_LenguajesData.Business
{
    public class EncargadoBusiness
    {
        private EncargadoData encargadoData;

        public EncargadoBusiness(String connectionString)
        {
            encargadoData = new EncargadoData(connectionString);
        }

        public Encargado insertarEncargado(Encargado encargado)
        {
            return encargadoData.insertarEncargado(encargado);
        }

        public int getEncargado(String cedula)
        {
            return encargadoData.getEncargado(cedula);
        }

        public Encargado ActualizarEncargado(Encargado encargado)
        {
            return encargadoData.ActualizarEncargado(encargado);
        }

        public Encargado obtenerEncargado(String cedula)
        {
            return encargadoData.obtenerEncargado(cedula);
        }

        public int ActualizarContrasena(String contrasena, int id)
        {
            return encargadoData.ActualizarContrasena(contrasena, id);
        }

        public int EliminarEncargado(int id)
        {
            return encargadoData.EliminarEncargado(id);
        }
        public LinkedList<Encargado> GetAllEncargados()
        {
            return encargadoData.GetAllEncargados();
        }
    }
}
