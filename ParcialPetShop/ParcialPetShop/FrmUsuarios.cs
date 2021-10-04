using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ParcialPetShop
{
	public partial class FrmUsuarios : Form
	{
		private List<Administrador> adminList;
		private List<Empleado> empleadoList;
		private Administrador admin;
		private Empleado empleado;
		private bool flagPassword;

		public FrmUsuarios()
		{
			InitializeComponent();
			adminList = Administrador.GetAdminList();
			empleadoList = Empleado.GetEmpleadoList();
			admin = new Administrador();
			empleado = new Empleado();
			flagPassword = true;
		}

		private void FrmUsuarios_Load(object sender, EventArgs e)
		{
			adminList = Administrador.GetAdminList();
			empleadoList = Empleado.GetEmpleadoList();
			dataGridViewUsuarios.Rows.Clear();
			Clear();

			foreach (Administrador item in adminList)
			{
				dataGridViewUsuarios.Rows.Add(item.IdAdmin, item.Nombre, item.User, item.TipoUsuario);
			}
			dataGridViewUsuarios.Rows.Add("---", "---", "---", "---");
			foreach (Empleado item in empleadoList)
			{
				dataGridViewUsuarios.Rows.Add(item.IdEmpleado, item.Nombre, item.User, item.TipoUsuario);
			}
		}


		/// <summary>
		/// Agrega un Usuario a su correspondiente lista dependiendo el tipo de usuario
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AgregarUsuario(object sender, EventArgs e)
		{
			if (cmbCredential.Text != string.Empty)
			{
				if (Validar.ValidarCadenaTexto(txtNombre.Text) &&
					txtUsuario.Text != string.Empty &&
					txtPassword.Text != string.Empty)
				{

					if (cmbCredential.Text == EnumeradosUsuarios.Administrador.ToString())
					{
						if (Administrador.ValidateExistingUserName(txtUsuario.Text))
						{

							Administrador admin = new Administrador(txtUsuario.Text, txtPassword.Text, EnumeradosUsuarios.Administrador.ToString(), txtNombre.Text);
							admin.AddToList();

							Console.Beep();
							Console.Beep();

							FrmUsuarios_Load(sender, e);

						}
						else
						{
							MessageBox.Show("Nombre de Usuario no disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}

					}
					else
					{
						if (Empleado.ValidateExistingUserName(txtUsuario.Text))
						{

							Empleado empleado = new Empleado(txtUsuario.Text, txtPassword.Text, EnumeradosUsuarios.Empleado.ToString(), txtNombre.Text);
							empleado.AddToList();

							Console.Beep();
							Console.Beep();

							FrmUsuarios_Load(sender, e);

						}
						else
						{
							MessageBox.Show("Nombre de Usuario no disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
				else
				{
					MessageBox.Show("Datos ingresados invalidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Seleccione el tipo de usuario que desea registrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		/// <summary>
		/// Elimino el usuario de su correspondiente lista a partir del selecionado en el DataGridView
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Eliminar(object sender, EventArgs e)
		{
			if (Validar.ValidarCadenaTexto(txtNombre.Text) &&
				txtUsuario.Text != string.Empty)
			{
				if (dataGridViewUsuarios.SelectedRows.Count > 0)
				{
					int id;
					int.TryParse(dataGridViewUsuarios.CurrentRow.Cells["ColumnId"].Value.ToString(), out id);
					if (cmbCredential.Text == EnumeradosUsuarios.Administrador.ToString())
					{
						admin.DeleteFromList(id);

						Console.Beep();
						Console.Beep();
						Console.Beep();

						FrmUsuarios_Load(sender, e);

					}
					else
					{
						empleado.DeleteFromList(id);

						Console.Beep();
						Console.Beep();
						Console.Beep();

						FrmUsuarios_Load(sender, e);

					}
				}
			}
			else
			{
				MessageBox.Show("Datos ingresados invalidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		/// <summary>
		/// Modifico el usuario de su correspondiente lista a partir del selecionado en el DataGridView
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ModificarUsuarios(object sender, EventArgs e)
		{
			int id;
			int.TryParse(dataGridViewUsuarios.CurrentRow.Cells["ColumnId"].Value.ToString(), out id);

			if (Validar.ValidarCadenaTexto(txtNombre.Text) &&
				txtUsuario.Text != string.Empty)
			{

				if (this.cmbCredential.SelectedItem.ToString() == EnumeradosUsuarios.Administrador.ToString())
				{
					if (admin.ModificarFromList(id, this.txtUsuario.Text, this.txtNombre.Text, this.txtPassword.Text))
					{
						Console.Beep();

						dataGridViewUsuarios.Rows.Clear();
						FrmUsuarios_Load(sender, e);

					}
				}
				else
				{
					if (empleado.ModificarFromList(id, this.txtUsuario.Text, this.txtNombre.Text,this.txtPassword.Text))
					{

						Console.Beep();

						dataGridViewUsuarios.Rows.Clear();
						FrmUsuarios_Load(sender, e);

					}
				}
			}
			else
			{
				MessageBox.Show("Datos ingresados invalidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		/// <summary>
		/// Evento del TextBox Buscar, cuando presiona enter busca en las listas todas las coincidencias y las escribe en el DataGridView
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (this.txtBuscar.Text != string.Empty && e.KeyChar == (char)13)
			{
				dataGridViewUsuarios.Rows.Clear();

				if (this.txtBuscar.Text == "todos" && e.KeyChar == (char)13)
				{
					dataGridViewUsuarios.Rows.Clear();
					foreach (Administrador item in adminList)
					{
						dataGridViewUsuarios.Rows.Add(item.IdAdmin, item.Nombre, item.User, item.TipoUsuario);
					}
					dataGridViewUsuarios.Rows.Add("---", "---", "---", "---");
					foreach (Empleado item in empleadoList)
					{
						dataGridViewUsuarios.Rows.Add(item.IdEmpleado, item.Nombre, item.User, item.TipoUsuario);
					}

				}
				else {
					foreach (Administrador item in adminList)
					{
						if (item.ToString().Contains(this.txtBuscar.Text))
						{
							dataGridViewUsuarios.Rows.Add(item.IdAdmin, item.Nombre, item.User, item.TipoUsuario);
						}
					}
					dataGridViewUsuarios.Rows.Add("---", "---", "---", "---");
					foreach (Empleado item in empleadoList)
					{
						if (item.ToString().Contains(this.txtBuscar.Text))
						{
							dataGridViewUsuarios.Rows.Add(item.IdEmpleado, item.Nombre, item.User, item.TipoUsuario);
						}
					}
				}
				this.txtBuscar.Text = string.Empty;
			}
		}


		/// <summary>
		/// Cuando un usuario es seleccionado en el DataGridView todos esos campos son asignados a sus respectivos TextBox
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dataGridViewUsuarios_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (dataGridViewUsuarios.SelectedRows.Count > 0)
			{
				if (Validar.ValidarCadenaTexto(dataGridViewUsuarios.CurrentRow.Cells["ColumnNombre"].Value.ToString())) {
					this.txtNombre.Text = dataGridViewUsuarios.CurrentRow.Cells["ColumnNombre"].Value.ToString();
					this.txtUsuario.Text = dataGridViewUsuarios.CurrentRow.Cells["ColumnUser"].Value.ToString();
					this.cmbCredential.SelectedItem = dataGridViewUsuarios.CurrentRow.Cells["ColumnTipoUsuario"].Value.ToString();

					if (this.cmbCredential.SelectedItem.ToString() == EnumeradosUsuarios.Administrador.ToString())
					{
						this.txtPassword.Text = Administrador.GetPassword(dataGridViewUsuarios.CurrentRow.Cells["ColumnId"].Value.ToString());
					}
					else
					{
						this.txtPassword.Text = Empleado.GetPassword(dataGridViewUsuarios.CurrentRow.Cells["ColumnId"].Value.ToString());
					}
				}

			}
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			if (flagPassword)
			{
				this.txtPassword.UseSystemPasswordChar = false;
				flagPassword = false;
			}
			else {
				this.txtPassword.UseSystemPasswordChar = true;
				flagPassword = true;
			}

		}

		/// <summary>
		/// Seteo todos los textBox en string.Empty
		/// </summary>
		private void Clear()
		{
			this.txtNombre.Text = string.Empty;
			this.txtUsuario.Text = string.Empty;
			this.txtPassword.Text = string.Empty;
			this.cmbCredential.SelectedItem = string.Empty;
		}

		private void Cerrar(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtPassword_TextChanged(object sender, EventArgs e)
		{
			this.txtPassword.UseSystemPasswordChar = true;
		}
	}
}
