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
	public partial class FrmLogIn : Form
	{
		public FrmLogIn()
		{
			InitializeComponent();
			Administrador admin1 = new Administrador("Franco","Franco123","Administrador","Franco Martinez");
			Administrador admin2 = new Administrador("Belen", "Belen123", "Administrador", "Belen Martinez");
			admin1.AddToList();
			admin2.AddToList();
			Empleado emp1 = new Empleado("Stefano", "Stefano123", "Empleado", "Stefano Mugetti");
			Empleado emp2 = new Empleado("Gabriel", "gabyelcrack", "Empleado", "Gabriel Lopez");
			emp1.AddToList();
			emp2.AddToList();
		}


		/// <summary>
		/// Autocompleta datos dependiendo del tipo de usuario seleccionado
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AutoCompletarCredenciales(object sender, EventArgs e)
		{
			if (this.cmbCredential.Text == string.Empty)
			{
				MessageBox.Show("Seleccione el tipo de usuario que desea autoCompletar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (this.cmbCredential.Text == EnumeradosUsuarios.Administrador.ToString())
			{
				this.txtUser.Text = Administrador.GetAdminUserFromList();
				this.txtPassword.UseSystemPasswordChar = true;
				this.txtPassword.Text = Administrador.GetAdminPasswordFromList();
			}
			else {

				this.txtUser.Text = Empleado.GetEmpleadoUserFromList();
				this.txtPassword.UseSystemPasswordChar = true;
				this.txtPassword.Text = Empleado.GetEmpleadoPasswordFromList();
			}
		}


		/// <summary>
		/// Valida los datos ingresados y abre un Forms en base al tipo de usuario
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Ingresar(object sender, EventArgs e)
		{
			string user = this.txtUser.Text;
			string password = this.txtPassword.Text;
			string tipoUsuario = this.cmbCredential.Text;

			if (tipoUsuario == EnumeradosUsuarios.Administrador.ToString())
			{
				if (Administrador.ValidateCredentials(user, password))
				{
					FrmMainAdmin frmMainAdmin = new FrmMainAdmin();

					this.Hide();
					frmMainAdmin.ShowDialog();
					this.Show();
				}
				else {
					MessageBox.Show("Credenciales Incorrectas. Por favor Reintente.", "Error", 
										MessageBoxButtons.OK, MessageBoxIcon.Error);

				}
			}
			else if(tipoUsuario == EnumeradosUsuarios.Empleado.ToString())
			{
				if (Empleado.ValidateCredentials(user, password))
				{
					FrmMainEmpleado frmMainEmpleado = new FrmMainEmpleado();

					this.Hide();
					frmMainEmpleado.ShowDialog();
					this.Show();
				}
				else
				{
					MessageBox.Show("Credenciales Incorrectas. Por favor Reintente.", "Error",
										MessageBoxButtons.OK, MessageBoxIcon.Error);

				}

			}
		}

		private void EnterPassword(object sender, EventArgs e)
		{
			if (this.txtPassword.Text != string.Empty)
			{
				this.txtPassword.UseSystemPasswordChar = true;
			}
		}

		private void btnCerrarLogin_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnMinimizarLogin_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
	}
}
