using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuturaLib.Models
{
    public class UserModel
    {
        //propiedades
        public string RUT { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Permisos { get; set; }
        public string Contrasenia { get; set; }

        //constructor
        public UserModel(string rut, string nombre, string telefono, string correo, string direccion,
            string permisos, string contrasenia)
        {
            RUT = rut;
            Nombre = nombre;
            Telefono = telefono;
            Correo = correo;
            Direccion = direccion;
            Permisos = permisos;
            Contrasenia = contrasenia;
        }

    }
}
