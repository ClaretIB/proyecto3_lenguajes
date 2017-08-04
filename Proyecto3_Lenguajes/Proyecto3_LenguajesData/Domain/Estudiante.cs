using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3_LenguajesData.Domain
{
    public class Estudiante
    {
        private int id;
        private String cedula;
        private String nombre;
        private String apellidos;
        private String grado;
        private String encargado;

        public Estudiante()
        {

        }

        public Estudiante(int id, String cedula, String nombre, String apellidos, String grado, String encargado)
        {
            this.id = id;
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.grado = grado;
            this.Encargado = encargado;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Cedula
        {
            get
            {
                return cedula;
            }

            set
            {
                cedula = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return apellidos;
            }

            set
            {
                apellidos = value;
            }
        }

        public string Grado
        {
            get
            {
                return grado;
            }

            set
            {
                grado = value;
            }
        }

        public string Encargado
        {
            get
            {
                return encargado;
            }

            set
            {
                encargado = value;
            }
        }
    }
}
