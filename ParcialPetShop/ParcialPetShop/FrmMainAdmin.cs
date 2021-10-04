using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Entidades;

namespace ParcialPetShop
{
	public partial class FrmMainAdmin : Form
	{
		
		System.Windows.Forms.Timer myTimer;
		

		public FrmMainAdmin()
		{
			InitializeComponent();
			Cliente.CargarClientes();
			Producto.CargarProductos();
			HistorialCompras.CargarHistorial();

			myTimer = new System.Windows.Forms.Timer();
			SetTimer();
		}


		/// <summary>
		/// Abre formularios en el panel Forms, en caso de que ya este abierto lo trae al frente.
		/// </summary>
		/// <typeparam name="Miform"></typeparam>
		private void AbrirFormulario<Miform>() where Miform : Form, new() 
		{
			ResetTimer();
			Form formulario;
			formulario = panelForms.Controls.OfType<Miform>().FirstOrDefault();

			if (formulario == null)
			{
				formulario = new Miform();
				formulario.TopLevel = false;
				panelForms.Controls.Add(formulario);
				formulario.FormBorderStyle = FormBorderStyle.None;
				formulario.Dock = DockStyle.Fill;
				formulario.Show();
				formulario.BringToFront();
				formulario.FormClosed += new FormClosedEventHandler(CloseForms);
			}
			else {
				formulario.BringToFront();	
			}
		}

		private void btnMinimizarMainForm_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		/// <summary>
		/// Cuando se cierra un formulario su boton cambia de color
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CloseForms(object sender, FormClosedEventArgs e) {
			ResetTimer();
			if (Application.OpenForms["FrmUsuarios"] == null) {
				btnUsuarios.BackColor = Color.FromArgb(15, 15, 15);
			}
			if (Application.OpenForms["FrmClientes"] == null)
			{
				btnClientes.BackColor = Color.FromArgb(15, 15, 15);
			}
			if (Application.OpenForms["FrmStock"] == null)
			{
				btnStock.BackColor = Color.FromArgb(15, 15, 15);
			}
			if (Application.OpenForms["FrmVentas"] == null)
			{
				btnVentas.BackColor = Color.FromArgb(15, 15, 15);
			}
			if (Application.OpenForms["FrmHistorialVentas"] == null)
			{
				btnHistorialVentas.BackColor = Color.FromArgb(15, 15, 15);
			}
		}

		/// <summary>
		/// Abre formulario de Usuarios
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AbrirFormUsuarios(object sender, EventArgs e)
		{
			ResetTimer();
			AbrirFormulario<FrmUsuarios>();
			btnUsuarios.BackColor = Color.FromArgb(12, 31, 92);
		}


		/// <summary>
		/// Abre formulario de Clientes
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AbrirFormClientes(object sender, EventArgs e)
		{
			ResetTimer();
			AbrirFormulario<FrmClientes>();
			btnClientes.BackColor = Color.FromArgb(12, 31, 92);
		}


		/// <summary>
		/// Abre formulario de Stock
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AbrirFormStock(object sender, EventArgs e)
		{
			ResetTimer();
			AbrirFormulario<FrmStock>();
			btnStock.BackColor = Color.FromArgb(12, 31, 92);
		}


		/// <summary>
		/// Abre formulario de Ventas
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AbrirFormsVentas(object sender, EventArgs e)
		{
			ResetTimer();
			FrmLogInVentas frmLogInVentas = new FrmLogInVentas();

			if (frmLogInVentas.ShowDialog() == DialogResult.OK)
			{
				FrmVentas.dni = frmLogInVentas.txtDni.Text;
				FrmVentas.nombre = Cliente.GetNameByDni(frmLogInVentas.txtDni.Text);

				AbrirFormulario<FrmVentas>();

				btnVentas.BackColor = Color.FromArgb(12, 31, 92);
			}

		}

		/// <summary>
		/// Abre formulario Historial De Ventas
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AbrirFormsHistorialVentas(object sender, EventArgs e)
		{
			ResetTimer();
			AbrirFormulario<FrmHistorialVentas>();
			btnHistorialVentas.BackColor = Color.FromArgb(12, 31, 92);
		}

		/// <summary>
		/// Inicio el Timer para cerrar la sesion en caso de inactividad
		/// </summary>
		private void SetTimer()
		{
			myTimer.Interval = 180000; //180seg 
			myTimer.Tick += new EventHandler(MyTimer_Tick);
			myTimer.Start();
		}

		/// <summary>
		/// Reseteo el Timer en caso de tener actividad en el forms
		/// </summary>
		private void ResetTimer() {
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
			MessageBox.Show("Sesion cerrada por inactividad.", "Main");
			this.Close();
		}
		private void btnCerrarMainForm_Click(object sender, EventArgs e)
		{
			myTimer.Stop();
			this.Close();
		}
		private void LogOut(object sender, EventArgs e)
		{
			myTimer.Stop();
			this.Close();
		}
	}
}
