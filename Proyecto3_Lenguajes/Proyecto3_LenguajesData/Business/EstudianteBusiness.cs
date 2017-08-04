using Proyecto3_LenguajesData.Data;
using Proyecto3_LenguajesData.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3_LenguajesData.Business
{
   public class EstudianteBusiness
    {
        private EstudianteData estudianteData;
        public EstudianteBusiness(String connectionString)
        {
            this.estudianteData = new EstudianteData(connectionString);
        }
        public Estudiante InsertarEstudiante(Estudiante estudiante)
        {
            return estudianteData.InsertarEstudiante(estudiante);
        }

        public int EliminarEstudiante(int id)
        {
            return estudianteData.EliminarEstudiante(id);
        }

        public Estudiante GetEstudiante(String cedula)
        {
            return estudianteData.GetEstudiante(cedula);
        }

        public Estudiante ActualizarEstudiante(Estudiante estudiante)
        {
            return estudianteData.ActualizarEstudiante(estudiante);
        }

        public int cambiarEncargado(int idEstudiante, String cedulaEncargado)
        {
            return estudianteData.cambiarEncargado(idEstudiante, cedulaEncargado);
        }

        public LinkedList<Estudiante> GetAllEstudiantes()
        {
            return estudianteData.GetAllEstudiantes();
        }
    }
}
