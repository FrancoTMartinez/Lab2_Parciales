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
	public partial class FrmLogInVentas : Form
	{
		public FrmLogInVentas()
		{
			InitializeComponent();
		}

		private void IngresarTienda(object sender, EventArgs e)
		{
			List<Cliente> clientesList = Cliente.GetClienteList();
			bool flag=true;
			foreach (Cliente item in clientesList)
			{
				if (item.Dni == this.txtDni.Text)
				{
					this.DialogResult = DialogResult.OK;
					flag = true;
					break;
				}
				else {
					flag = false;
				}
			}
			if (!flag) {
				MessageBox.Show("El dni ingresado no esta en el sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.DialogResult = DialogResult.Cancel;
			}
		}

		private void btnAutoCompletar_Click(object sender, EventArgs e)
		{
			this.txtDni.Text = "42416954";
		}
	}
}
