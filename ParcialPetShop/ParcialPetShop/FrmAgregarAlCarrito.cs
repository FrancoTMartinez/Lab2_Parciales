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
	public partial class FrmAgregarAlCarrito : Form
	{
		public FrmAgregarAlCarrito()
		{
			InitializeComponent();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			if (Validar.ValidarNumero(txtCantidad.Text) && int.Parse(txtCantidad.Text)>0)
			{
				if (Producto.ValidateStock(this.txtProducto.Text, int.Parse(txtCantidad.Text)))
				{
					this.DialogResult = DialogResult.OK;
				}
				else
				{
					MessageBox.Show("Lo sentimos!. El stock disponible es menor a la cantidad que desea comprar.", "Error", MessageBoxButtons.OK);
				}
			}
			else {
				MessageBox.Show("Cantidad incorrecta. Verifique se sea un numero.","Error", MessageBoxButtons.OK);
			}
			
		}

		private void Cerrar(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
