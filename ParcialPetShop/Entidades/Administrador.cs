using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
	public class Administrador : Usuarios
	{
		static List<Administrador> adminList;
		static private int idAdministrador= 0;
		private int idAdmin;

		static Administrador() {
			adminList = new List<Administrador>();
		}
		public Administrador() {
		
		}

		public Administrador(string user, string password,string tipoUsuario, string nombre, string dni) :base(user, password, tipoUsuario, nombre, dni)
		{
			idAdministrador = idAdministrador + 1;
			this.idAdmin = idAdministrador;
		}
		public int IdAdmin { get => idAdmin;}

		/// <summary>
		/// Agrego Administradores a la lista estatica adminList
		/// </summary>
		/// <returns></returns>
		public override bool AddToList()
		{
			adminList.Add(this);
			return true;
		}


		/// <summary>
		/// Elimino administradores de la lista estatica adminList
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public override bool DeleteFromList(int id)
		{
			foreach (Administrador item in adminList)
			{
				if (item.IdAdmin == id)
				{
					adminList.Remove(item);
					return true;
				}
			}

			return false;
		}

		/// <summary>
		/// Modifico Administradores de la lista estatica adminList
		/// </summary>
		/// <param name="id"></param>
		/// <param name="user"></param>
		/// <param name="nombre"></param>
		/// <param name="password"></param>
		/// <returns></returns>
		public override bool ModificarFromList(int id, string user, string nombre,string password, string dni)
		{
			foreach (Administrador admin in adminList)
			{
				if (admin.Dni == dni && admin.idAdmin != id) {
					return false;
				}
			}
			foreach (Administrador item in adminList)
			{
				if (item.IdAdmin == id)
				{
					item.User = user;
					item.Nombre = nombre;
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
		/// Obtengo el usuario del administrador que se encuentra en la primer posicion de la lista estatica adminList
		/// </summary>
		/// <returns></returns>
		static public string GetAdminUserFromList()
		{
			return adminList[0].User;
		}

		/// <summary>
		/// Obtengo el password del administrador que se encuentra en la primer posicion de la lista estatica adminList
		/// </summary>
		/// <returns></returns>
		static public string GetAdminPasswordFromList()
		{
			return adminList[0].Password;
		}

		/// <summary>
		/// Obtengo la lista estatica adminList
		/// </summary>
		/// <returns></returns>
		static public List<Administrador> GetAdminList()
		{
			return adminList;
		}

		/// <summary>
		/// Obtengo el password de un administrador identificandolo por su id
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		static public string GetPassword(string id)
		{
			
			foreach (Administrador item in adminList)
			{
				if (item.IdAdmin == int.Parse(id))
				{
					return item.Password;
				}
			}

			return string.Empty;
		}

		public override string ToString()
		{
			StringBuilder str = new StringBuilder();

			str.Append(this.IdAdmin +" "+ this.Nombre + " " + this.User + " " + this.TipoUsuario);
			return str.ToString();
		}

		/// <summary>
		/// Valido que los valores de los parametros existan y coincidan con algun elemento de la lista estatica adminList
		/// </summary>
		/// <param name="user"></param>
		/// <param name="password"></param>
		/// <returns></returns>
		static public bool ValidateCredentials(string user, string password)
		{
			foreach (Administrador item in adminList)
			{
				if (user == item.User && password == item.Password)
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>
		/// Verifico si el nombre de usuario esta disponible en la lista estatica adminList
		/// </summary>
		/// <param name="user"></param>
		/// <returns></returns>
		static public bool ValidateExistingUserName(string user)
		{
			foreach (Administrador item in adminList)
			{
				if (item.User == user)
				{
					return false;
				}
			}
			return true;
		}

		public override bool ValidateExistingDNI(string dni)
		{
			foreach (Administrador item in adminList)
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
