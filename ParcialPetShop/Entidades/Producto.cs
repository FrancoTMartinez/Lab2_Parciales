using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
	public class Producto
	{
		static List<Producto> productosList;
		static private int idProducto = 0;
		private int id;
		private string nombre;
		private string descripcion;
		private string tipo;
		int stock;
		double precio;


		static Producto()
		{
			productosList = new List<Producto>();
		}

		public Producto(string nombre, string descripcion, string tipo, int stock, double precio)
		{

			idProducto = idProducto + 1;
			this.nombre = nombre;
			this.descripcion = descripcion;
			this.tipo = tipo;
			this.stock = stock;
			this.precio = precio;
			this.id = idProducto;
		}

		public Producto(int id, string nombre, int cantidad, double precio)
		{
			this.Id = id;
			this.Nombre = nombre;
			this.Stock = cantidad;
			this.Precio = precio;
		}

		public int Id { get => id; set => id = value; }
		public string Nombre { get => nombre; set => nombre = value; }
		public string Descripcion { get => descripcion; set => descripcion = value; }
		public string Tipo { get => tipo; set => tipo = value; }
		public int Stock { get => stock; set => stock = value; }
		public double Precio { get => precio; set => precio = value; }


		/// <summary>
		/// Agrega productos a la lista estatica productosList
		/// </summary>
		/// <param name="producto"></param>
		/// <returns></returns>
		static public bool AddToList(Producto producto)
		{

			productosList.Add(producto);
			return true;
		}

		/// <summary>
		/// Elimina productos de la lista estatica productosList
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		static public bool DeleteFromList(int id)
		{
			foreach (Producto item in productosList)
			{
				if (item.Id == id)
				{
					productosList.Remove(item);
					return true;
				}
			}
			return false;
		}

		/// <summary>
		/// Edita productos de la lista estatica productosList
		/// </summary>
		/// <param name="id"></param>
		/// <param name="nombre"></param>
		/// <param name="descripcion"></param>
		/// <param name="tipo"></param>
		/// <param name="stock"></param>
		/// <param name="precio"></param>
		/// <returns></returns>
		static public bool EditFromList(int id, string nombre, string descripcion, string tipo, int stock, double precio)
		{
			foreach (Producto item in productosList)
			{
				if (item.Id == id)
				{
					item.Nombre = nombre;
					item.Descripcion = descripcion;
					item.Tipo = tipo;
					item.Stock = stock;
					item.Precio = precio;
					return true;
				}
			}
			return false;
		}

		/// <summary>
		/// Valida que el pruducto a agregar no sea uno ya existente
		/// </summary>
		/// <param name="nombre"></param>
		/// <returns></returns>
		static public bool ValidateExistingProduct(string nombre)
		{

			foreach (Producto item in productosList)
			{
				if (item.Nombre == nombre)
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>
		/// Parametrizacion de la lista estatica productosList
		/// </summary>
		static public void CargarProductos()
		{
			if (productosList.Count == 0 ) {
				Producto prod1 = new Producto("Dog Chow", "Alimento para pero super premium.", EnumeradosProductos.Alimentos.ToString(), 50, 5291);
				Producto prod2 = new Producto("Pedigree", "Optima digestion para perros Adultos.", EnumeradosProductos.Alimentos.ToString(), 21, 3811);
				Producto prod3 = new Producto("Cama Elastica", "La mejor cama elastica para tu perro.", EnumeradosProductos.Juguetes.ToString(), 12, 875);
				Producto prod4 = new Producto("Casa Perruna", "La mejor casa para tu perro. No se permiten gatos.", EnumeradosProductos.Camas.ToString(), 12, 1453);
				Producto prod5 = new Producto("Platos de Agua o Comida", "Sirve para perros y gatos.", EnumeradosProductos.Limpieza.ToString(), 450, 260);
				Producto prod6 = new Producto("Caja de arena", "Arena exportadad desde el Desierto del Sahara", EnumeradosProductos.Limpieza.ToString(), 2, 5000);
				Producto prod7 = new Producto("RedBullPet", "RedBull para mascotas.", EnumeradosProductos.Farmacia.ToString(), 25, 360);

				AddToList(prod1);
				AddToList(prod2);
				AddToList(prod3);
				AddToList(prod4);
				AddToList(prod5);
				AddToList(prod6);
				AddToList(prod7);
			}
		}

		/// <summary>
		/// Obtener lista estatica productosList
		/// </summary>
		static public List<Producto> GetProductoList()
		{
			return productosList;
		}

		/// <summary>
		/// Valida que la cantidad a ingresa no sea mayor a la disponible en la lista
		/// </summary>
		/// <param name="nombre"></param>
		/// <param name="cantidad"></param>
		/// <returns></returns>
		static public bool ValidateStock(string nombre, int cantidad)
		{
			foreach (Producto item in productosList)
			{
				if (item.Nombre == nombre)
				{
					if (item.Stock >= cantidad)
					{
						item.stock = item.stock - cantidad;
						return true;
					}
				}
			}
			return false;
		}

		/// <summary>
		/// Restaura el stock de la lista estatica productosList en caso de eliminar o modificar un producto del carrito
		/// </summary>
		/// <param name="nombre"></param>
		/// <param name="cantidad"></param>
		/// <returns></returns>
		static public bool RestoreStock(string nombre, int cantidad)
		{
			foreach (Producto item in productosList)
			{
				if (item.Nombre == nombre)
				{
					item.stock = item.stock + cantidad;
					return true;
				}
			}
			return false;
		}

		/// <summary>
		///  Utilizando el operador suma agrega un producto a la lista carritoList
		/// </summary>
		/// <param name="carritoList"></param>
		/// <param name="producto"></param>
		/// <returns></returns>
		public static bool operator +(List<Producto> carritoList, Producto producto)
		{
			 carritoList.Add(producto);
			return true;
		}

		public override string ToString()
		{
			StringBuilder str = new StringBuilder();
			str.Append(this.Id + " " + this.Nombre + " " + this.Descripcion + " " + this.Tipo + " " + this.Precio + " "+ this.Stock);
			
			return str.ToString();
		}

	}
}
