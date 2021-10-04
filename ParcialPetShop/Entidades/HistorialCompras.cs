using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class HistorialCompras
	{
		static public Queue<HistorialCompras> historialCompras;
		private List<Producto> productoHistorial;
		private string dniCliente;


		static HistorialCompras() {
			historialCompras = new Queue<HistorialCompras>();
		}
		public HistorialCompras()
		{

		}
		public HistorialCompras(string dniCliente, List<Producto> productoLista)
		{
			this.dniCliente = dniCliente;
			productoHistorial = productoLista;
		}
		public string DniCliente { get => dniCliente; set => dniCliente = value; }

		/// <summary>
		/// Agrega productos a la lista estatica historialCompras
		/// </summary>
		/// <param name="producto"></param>
		/// <returns></returns>
		public void AgregarProducto(Producto producto) {
			productoHistorial.Add(producto);
		}

		/// <summary>
		/// retorna la lista estatica historialCompras
		/// </summary>
		/// <returns></returns>
		public List<Producto> ReturnProductoHistorialList() {

			return productoHistorial;
		}


		/// <summary>
		/// Parametrizo el historial de ventas
		/// </summary>
		static public void CargarHistorial()
		{
			List<Producto> compra1 = new List<Producto>() {
						new Producto(1, "Dog Chow", 2, 5291),
						new Producto(2, "Pedigree", 3, 3811),
						new Producto(3, "Cama Elastica", 4, 875),
						new Producto(4, "Casa Perruna", 1, 1453),
						new Producto(5, "Platos de Agua o Comida", 1, 260),
						new Producto(6, "Caja de arena", 1, 5000),
						new Producto(7, "RedBullPet", 3, 360),
			};
			HistorialCompras historial1 = new HistorialCompras("42416954", compra1);
			List<Producto> compra2 = new List<Producto>() {
						new Producto(7, "RedBullPet", 3, 360),
						new Producto(6, "Caja de arena", 1, 5000),
						new Producto(5, "Platos de Agua o Comida", 1, 260),
						new Producto(4, "Casa Perruna", 1, 1453),
						new Producto(3, "Cama Elastica", 4, 875),
						new Producto(2, "Pedigree", 3, 3811),
						new Producto(1, "Dog Chow", 2, 5291),
			};
			HistorialCompras historial2 = new HistorialCompras("12345678", compra2);


			historialCompras.Enqueue(historial1);
			historialCompras.Enqueue(historial2);
		}
	}
}
