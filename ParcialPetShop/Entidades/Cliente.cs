using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class Cliente
	{
		static List<Cliente> clientesList;

		private string nombre;
		private string apellido;
		private string dni;
		private double saldo;
		private static int idStaticCliente=0;
		private int idCliente;

		static Cliente() {
			clientesList = new List<Cliente>();
		}

		public Cliente(string nombre, string apellido, string dni, double saldo)
		{
			idStaticCliente = idStaticCliente + 1;
			this.idCliente = idStaticCliente;
			
			this.nombre = nombre;
			this.apellido = apellido;
			this.dni = dni;
			this.saldo = saldo;
		}


		public string Nombre { get => nombre; set => nombre = value; }
		public string Apellido { get => apellido; set => apellido = value; }
		public string Dni { get => dni; set => dni = value; }
		public int IdCliente { get => idCliente; }
		public double Saldo { get => saldo; set => saldo = value; }

		/// <summary>
		/// Agrega clientes a la lista estatica clientesList
		/// </summary>
		/// <param name="cliente"></param>
		/// <returns></returns>
		static public bool AddToList(Cliente cliente)
		{

			clientesList.Add(cliente);

			return true;
		}

		/// <summary>
		/// Edita clientes de la lista estatica clientesList
		/// </summary>
		/// <param name="idCliente"></param>
		/// <param name="nombre"></param>
		/// <param name="apellido"></param>
		/// <param name="dni"></param>
		/// <param name="saldo"></param>
		/// <returns></returns>
		static public bool EditClienteFromList(int idCliente, string nombre, string apellido, 
												string dni, double saldo)
		{
			foreach (Cliente item in clientesList)
			{
				if (item.IdCliente == idCliente)
				{
					item.Nombre = nombre;
					item.apellido = apellido;
					item.Dni = dni;
					item.Saldo = saldo;
					return true;
				}
			}

			return false;
		}

		/// <summary>
		/// Elimina clientes identificandolos por su id lista estatica clientesList
		/// </summary>
		/// <param name="idCliente"></param>
		/// <returns></returns>
		static public bool DeleteFromList(int idCliente)
		{
			foreach (Cliente item in clientesList)
			{
				if (item.IdCliente == idCliente)
				{
					clientesList.Remove(item);
					return true;
				}
			}

			return false;
		}

		/// <summary>
		/// Busca una coincidencia en la lista estatica clientesList y retorna ese elemento
		/// </summary>
		/// <param name="dni"></param>
		/// <returns></returns>
		static public Cliente Search(string dni)
		{
			foreach (Cliente item in clientesList)
			{
				if (item.Dni == dni)
				{
					return item;
				}
			}
			return null;
		}

		/// <summary>
		/// Busca coincidencia en la lista estatica clientesList y retorna el nombre de ese cliente
		/// </summary>
		/// <param name="dni"></param>
		/// <returns></returns>
		static public string GetNameByDni(string dni)
		{
			foreach (Cliente item in clientesList)
			{
				if (item.Dni == dni)
				{
					StringBuilder name = new StringBuilder();
					name.Append(item.Nombre + " "+ item.Apellido);
					return name.ToString();
				}
			}
			return string.Empty;
		}

		/// <summary>
		/// Obtiene la lista estatica clientesList
		/// </summary>
		/// <returns></returns>
		static public List<Cliente> GetClienteList()
		{
			return clientesList;
		}

		/// <summary>
		/// Parametriza la lista estatica clientesList
		/// </summary>
		static public void CargarClientes() {
			if (clientesList.Count  == 0) {

				Cliente cliente1 = new Cliente("Franco", "Martinez", "42416954", 52000);
				Cliente cliente2 = new Cliente("Stefano", "Magri", "42411421", 100);
				Cliente cliente3 = new Cliente("Ludmila", "Mugetti", "42410214", 0);
				AddToList(cliente1);
				AddToList(cliente2);
				AddToList(cliente3);
			}
		}
		public override string ToString()
		{
			StringBuilder str = new StringBuilder();
			str.Append(this.IdCliente + " " + this.Nombre + " " + this.Apellido + " " + this.Dni + " " + this.Saldo);
			
			return str.ToString();
		}
	}
}
