using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class Empleado : Usuarios
	{
		static List<Empleado> empleadosList;
		static private int idEmpleadoEstatico = 0;
		private int idEmpleado;


		static Empleado()
		{
			empleadosList = new List<Empleado>();
		}

		public Empleado() {
		}

		public Empleado(string user, string password,string tipoUsuario, string nombre, string dni) :base(user,password, tipoUsuario, nombre,dni)
		{
			idEmpleadoEstatico = idEmpleadoEstatico + 1;
			this.idEmpleado = idEmpleadoEstatico;
		}
		public int IdEmpleado { get => idEmpleado;}


		/// <summary>
		/// Agrega empleados a la lista estatica empleadosList
		/// </summary>
		/// <returns></returns>
		public override bool AddToList()
		{
			empleadosList.Add(this);

			return true;

		}

		/// <summary>
		/// Elimina empleados de la lista estatica empleadosList buscandolos por su id
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public override bool DeleteFromList(int id)
		{
			foreach (Empleado item in empleadosList)
			{
				if (item.IdEmpleado == id)
				{
					empleadosList.Remove(item);
					return true;
				}
			}

			return false;
		}

		/// <summary>
		/// Modifica empleados de la lista estatica empleadosList
		/// </summary>
		/// <param name="id"></param>
		/// <param name="user"></param>
		/// <param name="nombre"></param>
		/// <returns></returns>
		public override bool ModificarFromList(int id, string user, string nombre, string password, string dni)
		{
			foreach (Empleado emp in empleadosList)
			{
				if (emp.Dni == dni && emp.idEmpleado != id)
				{
					return false;
				}
			}
			foreach (Empleado item in empleadosList)
			{
				if (item.IdEmpleado == id)
				{
					item.User = user;
					item.Nombre =nombre;
					item.Dni = dni;
					if (password != string.Empty) {
						item.Password = password;
					}
					return true;
				}
			}

			return false;
		}

		/// <summary>
		/// Valida que el valor de los parametros existan y coincidan en la lista estatica empleadosList
		/// </summary>
		/// <param name="user"></param>
		/// <param name="password"></param>
		/// <returns></returns>
		static public bool ValidateCredentials(string user, string password)
		{
			foreach (Empleado item in empleadosList)
			{
				if (user == item.User && password == item.Password)
				{
					return true;
				}
			}
			return false;
		}
		/// <summary>
		/// Valida que el valor del parametro exista en la lista estatica empleadosList
		/// </summary>
		/// <param name="user"></param>
		/// <returns></returns>
		static public bool ValidateExistingUserName(string user)
		{

			foreach (Empleado item in empleadosList)
			{
				if (item.User == user)
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>
		/// Obtiene el valor del atributo User de la primer posicion de la lista estatica empleadosList
		/// </summary>
		/// <returns></returns>
		static public string GetEmpleadoUserFromList()
		{
			return empleadosList[0].User;
		}
		/// <summary>
		/// Obtiene el valor del atributo Password de la primer posicion de la lista estatica empleadosList
		/// </summary>
		/// <returns></returns>
		static public string GetEmpleadoPasswordFromList()
		{
			return empleadosList[0].Password;
		}

		/// <summary>
		/// Retorna la lista estatica empleadosList
		/// </summary>
		/// <returns></returns>
		static public List<Empleado> GetEmpleadoList() {
			return empleadosList;
		}

		static public string GetPassword(string id)
		{

			foreach (Empleado item in empleadosList)
			{
				if (item.IdEmpleado == int.Parse(id))
				{
					return item.Password;
				}
			}

			return string.Empty;
		}
		public override string ToString()
		{
			StringBuilder str = new StringBuilder();

			str.Append(this.IdEmpleado + " " + this.Nombre + " " + this.User + " " + this.TipoUsuario);
			return str.ToString();
		}

		public override bool ValidateExistingDNI(string dni)
		{
			foreach (Empleado item in empleadosList)
			{
				if (item.Dni == dni)
				{
					return false;
				}
			}
			return true;
		}
	}
}
