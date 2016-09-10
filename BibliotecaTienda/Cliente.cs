using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaTienda
{
    public class Cliente
    {
        private string _nombres;
        private string _apellidos;
        private string _rut;
        private string _direccion;
        private string _email;
        private DateTime _fechaNacimiento;

        public string Nombres
        {
            get
            {
                if (_nombres == null)
                    _nombres = string.Empty;
                return _nombres;
            }

            set
            {
                if (value.Length < 5)
                    throw new ArgumentException("Los nombres no puede tener menos de 5 caracteres");
                _nombres = value;
            }
        }

        public string Apellidos
        {
            get
            {
                if (_apellidos == null)
                    _apellidos = string.Empty;
                return _apellidos;
            }

            set
            {
                if (value.Length < 5)
                    throw new ArgumentException("Los apellidos no pueden tener menos de 5 caracteres");
                _apellidos = value;
            }
        }

        public string Rut
        {
            get
            {
                return _rut;
            }
            set
            {
                if (_rut.Length < 9)
                {
                    throw new ArgumentException("El rut debe tener al menos 9 digitos");
                }
                else
                {
                    _rut = value;
                }

            }
        }

        public string Direccion
        {
            get
            {
                if (_direccion == null)
                    _direccion = string.Empty;
                return _direccion;
            }

            set
            {
                if (value.Length < 5)
                    throw new ArgumentException("La direccion no pueden tener menos de 5 caracteres");
                _direccion = value;
            }
        }

        public string Email
        {
            get
            {
                if (_email == null)
                    _email = string.Empty;
                return _email;
            }

            set
            {
                if (value.Length < 5 || !value.Contains("@") || !value.Contains("."))
                    throw new ArgumentException("El email no pueden tener menos de 5 caracteres. Debe contener '@'' y '.'.");
                _direccion = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                if (_fechaNacimiento == null)
                    _fechaNacimiento = new DateTime();
                return _fechaNacimiento;
            }
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("La fecha de nacimiento no puede superar la fecha de hoy.");
                _fechaNacimiento = value;
            }
        }

        public int Edad
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - _fechaNacimiento.Year;
                if (_fechaNacimiento > today.AddYears(-age))
                    age--;
                return age;
            }
        }

        public Cliente()
        {
            Init();
        }

        private void Init()
        {
            _direccion = string.Empty;
            _email = string.Empty;
            _apellidos = string.Empty;
            _nombres = string.Empty;
            _rut = string.Empty;
            _fechaNacimiento = DateTime.Now;
        }

        public void ObtenerIformacion()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("Nombres: {0}", _nombres));
            result.AppendLine(string.Format("Apellidos: {0}", _apellidos));
            result.AppendLine(string.Format("Direccion: {0}", _direccion));
            result.AppendLine(string.Format("Rut: {0}", _rut));
            result.AppendLine(string.Format("Email: {0}", _email));
            result.AppendLine(string.Format("Fecha de nacimiento: {0}", _fechaNacimiento));
            result.AppendLine(string.Format("Edad: {0}", Edad));
        }


    }
}
