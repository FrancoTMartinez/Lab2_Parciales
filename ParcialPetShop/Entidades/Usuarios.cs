using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public abstract class Usuarios
	{
		private string user;
		private string password;
		private string tipoUsuario;
		private string nombre;
		private string dni;


		public Usuarios(string user, string password, string tipoUsuario, string nombre, string dni)
		{
			this.user = user;
			this.password = password;
			this.tipoUsuario = tipoUsuario;
			this.nombre = nombre;
			this.dni = dni;
		}

		public Usuarios() {
		
		}
		

		public string User { get => user; set => user = value; }
		public string Password { get => password; set => password = value; }
		public string TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }
		public string Nombre { get => nombre; set => nombre = value; }
		public string Dni { get => dni; set => dni = value; }


		abstract public bool AddToList();
		abstract public bool DeleteFromList(int id);
		abstract public bool ModificarFromList(int id,string user, string nombre,string password, string dni);

		abstract public bool ValidateExistingDNI(string dni);


	}
}
