using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ParcialPetShop
{
	public partial class FrmClientes : Form
	{
		private List<Cliente> clienteList;
		public FrmClientes()
		{
			InitializeComponent();

		}
		private void FrmClientes_Load(object sender, EventArgs e)
		{
			clienteList= Cliente.GetClienteList();

			dataGridViewClientes.Rows.Clear();
			Clear();

			foreach (Cliente item in clienteList)
			{
				dataGridViewClientes.Rows.Add(item.IdCliente, item.Nombre, item.Apellido, item.Dni, item.Saldo);
			}
		}

		/// <summary>
		/// Agrego un Cliente a la lista ClienteList
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AgregarCliente(object sender, EventArgs e)
		{
			if (Validar.ValidarCadenaTexto(txtNombre.Text) &&
				Validar.ValidarCadenaTexto(txtApellido.Text) &&
				Validar.ValidarDNI(txtDni.Text) &&
				Validar.ValidarNumero(txtSaldo.Text))
			{
				if (Validar.ValidateExistingDNI(txtDni.Text))
				{

					Cliente cliente = new Cliente(txtNombre.Text, txtApellido.Text, txtDni.Text, double.Parse(txtSaldo.Text));
					Cliente.AddToList(cliente);

					Console.Beep();
					Console.Beep();

					FrmClientes_Load(sender, e);
					
				}
				else
				{
					MessageBox.Show("El dni ingresado ya esta registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Ocurrio un error. Reintente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Modifico el Cliente de la lista ClienteList a partir del selecionado en el DataGridView
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ModificarClientes(object sender, EventArgs e)
		{
			int id;
			int.TryParse(dataGridViewClientes.CurrentRow.Cells["ColumnId"].Value.ToString(), out id);

			if (Validar.ValidarCadenaTexto(txtNombre.Text) &&
				Validar.ValidarCadenaTexto(txtApellido.Text) &&
				Validar.ValidarDNI(txtDni.Text) &&
				Validar.ValidarNumero(txtSaldo.Text))
			{
				if (Cliente.EditClienteFromList(id, this.txtNombre.Text, this.txtApellido.Text, this.txtDni.Text
												, double.Parse(this.txtSaldo.Text)))
				{
					Console.Beep();

					FrmClientes_Load(sender, e);
				}

			}
			else
			{
				MessageBox.Show("Datos ingresados invalidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		/// <summary>
		/// Elimino un cliente seleccionado en el DataGridView de la lista ClientesList
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Eliminar(object sender, EventArgs e)
		{

			if (Validar.ValidarCadenaTexto(txtNombre.Text) &&
				Validar.ValidarCadenaTexto(txtApellido.Text) &&
				Validar.ValidarDNI(txtDni.Text) &&
				Validar.ValidarNumero(txtSaldo.Text))
			{

				int id;
				int.TryParse(dataGridViewClientes.CurrentRow.Cells["ColumnId"].Value.ToString(), out id);

				Cliente.DeleteFromList(id);

				Console.Beep();
				Console.Beep();
				Console.Beep();

				FrmClientes_Load(sender, e);

			}
			else
			{
				MessageBox.Show("Datos ingresados invalidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Cuando un cliente es seleccionado en el DataGridView todos esos campos son asignados a sus respectivos TextBox
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dataGridViewClientes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (dataGridViewClientes.SelectedRows.Count > 0)
			{
				this.txtNombre.Text = dataGridViewClientes.CurrentRow.Cells["ColumnNombre"].Value.ToString();
				this.txtApellido.Text = dataGridViewClientes.CurrentRow.Cells["ColumnApellido"].Value.ToString();
				this.txtDni.Text = dataGridViewClientes.CurrentRow.Cells["ColumnDni"].Value.ToString();
				this.txtSaldo.Text = dataGridViewClientes.CurrentRow.Cells["ColumnSaldo"].Value.ToString();
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
				dataGridViewClientes.Rows.Clear();

				if (this.txtBuscar.Text == "todos" && e.KeyChar == (char)13)
				{
					dataGridViewClientes.Rows.Clear();
					foreach (Cliente item in clienteList)
					{
						dataGridViewClientes.Rows.Add(item.IdCliente, item.Nombre, item.Apellido, item.Dni, item.Saldo);
					}
				}
				else
				{
					foreach (Cliente item in clienteList)
					{
						if (item.ToString().Contains(this.txtBuscar.Text))
						{
							dataGridViewClientes.Rows.Add(item.IdCliente, item.Nombre, item.Apellido, item.Dni, item.Saldo);

						}
					}
				}
				this.txtBuscar.Text = string.Empty;
			}
		}

		/// <summary>
		/// Seteo todos los textBox en string.Empty
		/// </summary>
		private void Clear()
		{
			this.txtNombre.Text = string.Empty;
			this.txtApellido.Text = string.Empty;
			this.txtDni.Text = string.Empty;
			this.txtSaldo.Text = string.Empty;

		}

		private void Cerrar(object sender, EventArgs e)
		{
			this.Close();
		}


	}
}
