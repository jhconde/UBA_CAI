using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Entidades
{
    [DataContract]
    public class Cliente
    {
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private DateTime _fechaNacimiento;
        private string _email;
        private string _telefono;

        [DataMember]
        public string Nombre { get => _nombre; set => _nombre = value; }

        [DataMember(Name ="apellido")]
        public string Ape { get => _apellido; set => _apellido = value; }

        [DataMember]
        public string Direccion { get => _direccion; set => _direccion = value; }

        [DataMember]
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }

        [DataMember]
        public string Email { get => _email; set => _email = value; }

        [DataMember]
        public string Telefono { get => _telefono; set => _telefono = value; }

        public string GetEdad()
        {
            int edad = (DateTime.Now - _fechaNacimiento).Days / 365;
            return edad.ToString();
        }

        public override string ToString()
        {
            return string.Format("Cliente {0}, {1}, {2}",this._apellido,this._nombre, this._fechaNacimiento);
        }
    }
}
