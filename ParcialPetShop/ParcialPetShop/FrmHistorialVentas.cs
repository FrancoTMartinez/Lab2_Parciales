using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace ParcialPetShop
{
	public partial class FrmHistorialVentas : Form
	{
		public FrmHistorialVentas()
		{
			InitializeComponent();
		}

		private void FrmHistorialVentas_Load(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Recarga el DataGridView
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Actualizar(object sender, EventArgs e)
		{
			dataGridViewHistorialVentas.Rows.Clear();
			foreach (HistorialCompras item in HistorialCompras.historialCompras)
			{
				foreach (Producto producto in item.ReturnProductoHistorialList())
				{
					dataGridViewHistorialVentas.Rows.Add(item.DniCliente, producto.Id,producto.Nombre,producto.Stock,producto.Precio);
				}
				dataGridViewHistorialVentas.Rows.Add(1);
			}
		}

		private void Cerrar(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
