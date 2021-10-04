using Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ParcialPetShop
{
	public partial class FrmVentas : Form
	{

		private List<Producto> carritoList;
		private Producto productoCarrito;
		private double PrecioFinal = 0;
		public static string nombre;
		public static string dni;

		System.Windows.Forms.Timer myTimer;

		public FrmVentas()
		{
			InitializeComponent();

			this.lblNombreCliente.Text = nombre;
			this.lblDni.Text = dni;
			carritoList = new List<Producto>();

			myTimer = new System.Windows.Forms.Timer();

			SetTimer();

		}
		private void FrmVentas_Load(object sender, EventArgs e)
		{

			List<Producto> productoList = Producto.GetProductoList();

			dataGridViewProductos.Rows.Clear();
			dataGridViewCarrito.Rows.Clear();

			foreach (Producto item in productoList)
			{
				dataGridViewProductos.Rows.Add(item.Id, item.Nombre, item.Descripcion, item.Tipo, item.Precio, item.Stock);
			}
			foreach (Producto item in carritoList)
			{
				dataGridViewCarrito.Rows.Add(item.Id, item.Nombre, item.Stock, item.Precio);
			}
		}


		/// <summary>
		/// Agrega un Producto seleciconado del DGVProductos a la lista carritoList para despues agregarlo al DGVCarrito,
		/// mientras actualiza el txtBox Total
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AgregarAlCarrito(object sender, EventArgs e)
		{
			ResetTimer();
			if (!ValidateExistingProductInCarrito())
			{
				FrmAgregarAlCarrito frmAgregarAlCarrito = new FrmAgregarAlCarrito();
				frmAgregarAlCarrito.txtProducto.Text = dataGridViewProductos.CurrentRow.Cells["ColumnNombre"].Value.ToString();

				if (frmAgregarAlCarrito.ShowDialog() == DialogResult.OK)
				{
					string cantidad = frmAgregarAlCarrito.txtCantidad.Text;

					productoCarrito = new Producto(int.Parse(dataGridViewProductos.CurrentRow.Cells["ColumnId"].Value.ToString()),
										 dataGridViewProductos.CurrentRow.Cells["ColumnNombre"].Value.ToString(),
										 int.Parse(cantidad),
										 double.Parse(dataGridViewProductos.CurrentRow.Cells["ColumnPrecio"].Value.ToString()));
					
					
					
					bool respuesta= carritoList + productoCarrito;

					CalcularPrecio(int.Parse(cantidad), double.Parse(dataGridViewProductos.CurrentRow.Cells["ColumnPrecio"].Value.ToString()));
					FrmVentas_Load(sender, e);
				}
			}
			else
			{
				MessageBox.Show("No puede haber productos repetidos en el carrito. En caso de querer agregar unidades usar el boton de Modificar Cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		/// <summary>
		/// Modifica la cantidad de un producto seleccionado en el DGVCarrito abirendo otro formulario para indicar la nueva cantidad.
		/// Una vez modificado actualiza el txtBox PrecioTotal
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ModificarCantidadCarrito(object sender, EventArgs e)
		{
			ResetTimer();
			FrmModificarCantidadCarrito frmModificarCantidadCarrito = new FrmModificarCantidadCarrito();
			int cantidad;
			int.TryParse(dataGridViewCarrito.CurrentRow.Cells["ColumnCantidadCarrito"].Value.ToString(), out cantidad);
			int cantidadAnterior = cantidad;
			int cantidadNueva = 0;

			Producto.RestoreStock(dataGridViewCarrito.CurrentRow.Cells["ColumnNombreCarrito"].Value.ToString(), cantidad);


			frmModificarCantidadCarrito.txtProducto.Text = dataGridViewCarrito.CurrentRow.Cells["ColumnNombreCarrito"].Value.ToString();

			if (frmModificarCantidadCarrito.ShowDialog() == DialogResult.OK)
			{
				foreach (Producto item in carritoList)
				{
					if (item.Nombre == dataGridViewCarrito.CurrentRow.Cells["ColumnNombreCarrito"].Value.ToString())
					{
						item.Stock = int.Parse(frmModificarCantidadCarrito.txtCantidad.Text);
						cantidadNueva = int.Parse(frmModificarCantidadCarrito.txtCantidad.Text);
					}
				}
				ModificarPrecioTotal(int.Parse(dataGridViewCarrito.CurrentRow.Cells["ColumnPrecioCarrito"].Value.ToString()), cantidadAnterior, cantidadNueva);
				FrmVentas_Load(sender, e);
			}
		}

		/// <summary>
		/// Elimina un producto seleccionado en el DGVCarrito de la lista carritoList y actualiza el txtPrecioTotal
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EliminarDelCarrito(object sender, EventArgs e)
		{
			ResetTimer();
			List<Producto> toDelete = new List<Producto>(carritoList);
			foreach (Producto item in toDelete)
			{
				if (item.Nombre == dataGridViewCarrito.CurrentRow.Cells["ColumnNombreCarrito"].Value.ToString())
				{
					DescontarProductoEliminado(item.Stock, item.Precio);
					carritoList.Remove(item);
					Producto.RestoreStock(dataGridViewCarrito.CurrentRow.Cells["ColumnNombreCarrito"].Value.ToString(),
										  int.Parse(dataGridViewCarrito.CurrentRow.Cells["ColumnCantidadCarrito"].Value.ToString()));

				}
			}
			FrmVentas_Load(sender, e);
		}

		/// <summary>
		/// Valida que el producto a agregar al carrito no exista
		/// </summary>
		/// <returns></returns>
		private bool ValidateExistingProductInCarrito()
		{
			foreach (Producto item in carritoList)
			{
				if (item.Nombre == dataGridViewProductos.CurrentRow.Cells["ColumnNombre"].Value.ToString())
				{
					return true;
				}
			}
			return false;
		}


		/// <summary>
		/// Calucla el precio y actualiza el Txt Precio Total
		/// </summary>
		/// <param name="cantidad"></param>
		/// <param name="precio"></param>
		private void CalcularPrecio(int cantidad, double precio)
		{
			PrecioFinal = (precio * cantidad) + PrecioFinal;
			this.txtPrecioTotal.Text = PrecioFinal.ToString();
		}

		/// <summary>
		/// Calcula el nuevo precio cuando un producto es eliminado de la lista carritoList
		/// </summary>
		/// <param name="cantidad"></param>
		/// <param name="precio"></param>
		private void DescontarProductoEliminado(int cantidad, double precio)
		{
			double precioProductoEliminado = (precio * cantidad);

			PrecioFinal = PrecioFinal - precioProductoEliminado;

			this.txtPrecioTotal.Text = PrecioFinal.ToString();
		}


		/// <summary>
		/// Calcula el nuevo precio cuando una cantidad de un producto es modificada de la lista carritoList
		/// </summary>
		/// <param name="precio"></param>
		/// <param name="cantidadAnterior"></param>
		/// <param name="cantidadNueva"></param>
		private void ModificarPrecioTotal(double precio, int cantidadAnterior, int cantidadNueva)
		{
			int diferencia;

			if (cantidadAnterior < cantidadNueva)
			{

				diferencia = cantidadNueva - cantidadAnterior;
				PrecioFinal = (precio * diferencia) + PrecioFinal;

				this.txtPrecioTotal.Text = PrecioFinal.ToString();

			}
			else
			{
				diferencia = cantidadAnterior - cantidadNueva;
				PrecioFinal = PrecioFinal - (precio * diferencia);

				this.txtPrecioTotal.Text = PrecioFinal.ToString();
			}

		}

		/// <summary>
		/// Valida que el cliente en sesion tenga saldo disponible para realizar la compra deseada
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RealizarCompra(object sender, EventArgs e)
		{
			Cliente cliente1 = Cliente.Search(this.lblDni.Text);
			double precioTotal = double.Parse(txtPrecioTotal.Text);

			if (cliente1.Saldo >= precioTotal)
			{
				cliente1.Saldo = cliente1.Saldo - precioTotal;

				FrmCompraRealizada frmCompraRealizada = new FrmCompraRealizada();

				StringBuilder str = new StringBuilder();
				
				str.Append("Compra realizada con exito!.No olvide su Factura!");
				frmCompraRealizada.lblMensaje.Text = str.ToString();
				str.Clear();
				str.Append("Su saldo actual es de: " + cliente1.Saldo);
				frmCompraRealizada.lblMensaje2.Text = str.ToString();

				CargarHistorial();
				
				if (frmCompraRealizada.ShowDialog() == DialogResult.OK)
				{
					myTimer.Stop();
					Factura();
					this.Close();
				}
			}
			else
			{
				MessageBox.Show("Imposile realizar la compra. Saldo insuficiente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		/// <summary>
		/// Genera un string con los datos de la compra y del cliente
		/// </summary>
		public void Factura() {
			StringBuilder str = new StringBuilder();

			str.AppendLine("Nombre:			Cantidad:			Precio: ");

			foreach (Producto item in carritoList)
			{
				str.AppendLine(item.Nombre + "			"+item.Stock + "			" + item.Precio);
				str.AppendLine(" ");
				str.AppendLine("-----------------------------------------------------------------------");
				str.AppendLine(" ");
			}
			str.AppendLine(" ");
			str.AppendLine("Cliente: "+ lblNombreCliente.Text + " " + "DNI: "+ lblDni.Text);
			str.AppendLine(" ");

			str.AppendLine("Total: $ " + PrecioFinal);

			Archivos.Exportar(str.ToString());
		}

		/// <summary>
		/// Agrega productos a la lista statica Historial Ventas
		/// </summary>
		public void CargarHistorial()
		{
			HistorialCompras historial = new HistorialCompras(this.lblDni.Text, carritoList);

			HistorialCompras.historialCompras.Enqueue(historial);
		}

		/// <summary>
		/// Inicio el Timer para cerrar la sesion en caso de inactividad
		/// </summary>
		private void SetTimer()
		{
			myTimer.Interval = 120000; //120seg
			myTimer.Tick += new EventHandler(MyTimer_Tick);
			myTimer.Start();
		}


		/// <summary>
		/// Reseteo el Timer en caso de tener actividad en el forms
		/// </summary>
		private void ResetTimer()
		{
			myTimer.Stop();
			myTimer.Start();
		}


		/// <summary>
		/// Despliego el evento cuando el Timer llega a cero
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MyTimer_Tick(object sender, EventArgs e)
		{
			myTimer.Stop();
			MessageBox.Show("Sesion cerrada por inactividad.", "Ventas");
			this.Close();
		}

		private void Cerrar(object sender, EventArgs e)
		{
			myTimer.Stop();
			this.Close();
		}

	}
}
