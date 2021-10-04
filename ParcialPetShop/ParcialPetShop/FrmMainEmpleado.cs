using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialPetShop
{
	public partial class FrmMainEmpleado : FrmMainAdmin
	{
		public FrmMainEmpleado()
		{
			InitializeComponent();
			this.toolTipUsuarios.SetToolTip(this.btnUsuariosSinFuncion,"Acceso restringido. Solo Administradores");
			this.toolTipUsuarios.SetToolTip(this.btnStockSinFuncion,"Acceso restringido. Solo Administradores");
			this.toolTipUsuarios.SetToolTip(this.btnHistorialSinFuncion,"Acceso restringido. Solo Administradores");
			
		}

		private void LogOut(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}
