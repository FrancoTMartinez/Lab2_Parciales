using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ParcialPetShop
{
	public partial class FrmStock : Form
	{
		private List<Producto> productoList;

		public FrmStock()
		{
			InitializeComponent();

		}

		private void FrmStock_Load(object sender, EventArgs e)
		{
			productoList = Producto.GetProductoList();
			dataGridViewProductos.Rows.Clear();
			Clear();

			foreach (Producto item in productoList)
			{
				dataGridViewProductos.Rows.Add(item.Id, item.Nombre, item.Descripcion, item.Tipo, item.Precio, item.Stock);
			}
		}


		/// <summary>
		/// Agrega un Producto a la lista de productoList validando que el mismo no exista
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AgregarProducto(object sender, EventArgs e)
		{
			if (Validar.ValidarCadenaTexto(txtNombre.Text) && txtDescripcion.Text != string.Empty &&
				cmbTipoProducto.Text != string.Empty && Validar.ValidarNumero(txtStock.Text) && Validar.ValidarNumero(txtPrecio.Text))
			{

				if (Producto.ValidateExistingProduct(txtNombre.Text))
				{
					Producto producto = new Producto(txtNombre.Text, txtDescripcion.Text, cmbTipoProducto.Text,
													int.Parse(txtStock.Text), double.Parse(txtPrecio.Text));
					Producto.AddToList(producto);

					Console.Beep();
					Console.Beep();

					FrmStock_Load(sender, e);
				}
				else
				{
					MessageBox.Show("El producto que desea Ingresar ya se encuentra registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}
			else
			{
				MessageBox.Show("Datos ingresados invalidos, por favor revise.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		/// <summary>
		/// Modifico el Producto de la lista productoList a partir del selecionado en el DataGridView
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Modificar(object sender, EventArgs e)
		{
			int id;
			int.TryParse(dataGridViewProductos.CurrentRow.Cells["ColumnId"].Value.ToString(), out id);

			if (Validar.ValidarCadenaTexto(txtNombre.Text) && txtDescripcion.Text != string.Empty &&
				cmbTipoProducto.Text != string.Empty &&
				Validar.ValidarNumero(txtStock.Text) && Validar.ValidarNumero(txtPrecio.Text))
			{
				if (Producto.EditFromList(id, txtNombre.Text, txtDescripcion.Text, cmbTipoProducto.Text,
											int.Parse(txtStock.Text), double.Parse(txtPrecio.Text)))
				{

					Console.Beep();
					Console.Beep();

					FrmStock_Load(sender, e);

				}
			}
			else
			{
				MessageBox.Show("Datos ingresados invalidos, por favor revise.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		/// <summary>
		/// Elimino un producto seleccionado en el DataGridView de la lista productoList
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Eliminar(object sender, EventArgs e)
		{
			if (Validar.ValidarCadenaTexto(txtNombre.Text) && txtDescripcion.Text != string.Empty &&
				cmbTipoProducto.Text != string.Empty && Validar.ValidarNumero(txtStock.Text) &&
				Validar.ValidarNumero(txtPrecio.Text))
			{
				if (dataGridViewProductos.SelectedRows.Count > 0)
				{
					int id;
					int.TryParse(dataGridViewProductos.CurrentRow.Cells["ColumnId"].Value.ToString(), out id);

					Producto.DeleteFromList(id);

					Console.Beep();
					Console.Beep();
					Console.Beep();


					FrmStock_Load(sender, e);

				}
			}
			else
			{
				MessageBox.Show("Datos ingresados invalidos, por favor revise.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Seteo todos los textBox en string.Empty
		/// </summary>
		public void Clear()
		{
			this.txtNombre.Text = string.Empty;
			this.txtDescripcion.Text = string.Empty;
			this.cmbTipoProducto.SelectedItem = null;
			this.txtStock.Text = string.Empty;
			this.txtPrecio.Text = string.Empty;
		}


		/// <summary>
		/// Cuando un producto es seleccionado en el DataGridView todos esos campos son asignados a sus respectivos TextBox
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dataGridViewProductos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (dataGridViewProductos.SelectedRows.Count > 0)
			{
				this.txtNombre.Text = dataGridViewProductos.CurrentRow.Cells["ColumnNombre"].Value.ToString();
				this.txtDescripcion.Text = dataGridViewProductos.CurrentRow.Cells["ColumnDescripcion"].Value.ToString();
				this.cmbTipoProducto.SelectedItem = dataGridViewProductos.CurrentRow.Cells["ColumnTipo"].Value.ToString();
				this.txtStock.Text = dataGridViewProductos.CurrentRow.Cells["ColumnStock"].Value.ToString();
				this.txtPrecio.Text = dataGridViewProductos.CurrentRow.Cells["ColumnPrecio"].Value.ToString();
			}
		}


		/// <summary>
		/// Evento del TextBox Buscar, cuando presiona enter busca en la lista todas las coincidencias y las escribe en el DataGridView
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (this.txtBuscar.Text != string.Empty && e.KeyChar == (char)13)
			{
				dataGridViewProductos.Rows.Clear();

				if (this.txtBuscar.Text == "todos" && e.KeyChar == (char)13)
				{
					dataGridViewProductos.Rows.Clear();
					foreach (Producto item in productoList)
					{
						dataGridViewProductos.Rows.Add(item.Id, item.Nombre, item.Descripcion, item.Tipo, item.Precio, item.Stock);
					}
				}
				else {
					foreach (Producto item in productoList)
					{
						if (item.ToString().Contains(this.txtBuscar.Text))
						{
							dataGridViewProductos.Rows.Add(item.Id, item.Nombre, item.Descripcion, item.Tipo, item.Precio, item.Stock);
						}
					}
				}
				this.txtBuscar.Text = string.Empty;
			}
		}
		private void Cerrar(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
