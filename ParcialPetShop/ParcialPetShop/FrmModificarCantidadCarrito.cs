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
	public partial class FrmModificarCantidadCarrito : Form
	{
		public FrmModificarCantidadCarrito()
		{
			InitializeComponent();
		}

		private void ModificarCantidad(object sender, EventArgs e)
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
			else
			{
				MessageBox.Show("Cantidad incorrecta. Verifique se sea un numero. En caso que haya puesto cero, y no quiere comprar este producto, porfavor eliminelo de la forma correcta.", "Error", MessageBoxButtons.OK);
			}
		}

		private void Cancelar(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
