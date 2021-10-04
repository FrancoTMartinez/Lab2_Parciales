
namespace ParcialPetShop
{
	partial class FrmAgregarAlCarrito
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.lblCantidad = new System.Windows.Forms.Label();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.txtProducto = new System.Windows.Forms.TextBox();
			this.lblProducto = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtCantidad
			// 
			this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
			this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCantidad.ForeColor = System.Drawing.Color.White;
			this.txtCantidad.Location = new System.Drawing.Point(183, 125);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(213, 23);
			this.txtCantidad.TabIndex = 2;
			// 
			// lblCantidad
			// 
			this.lblCantidad.AutoSize = true;
			this.lblCantidad.ForeColor = System.Drawing.Color.White;
			this.lblCantidad.Location = new System.Drawing.Point(111, 127);
			this.lblCantidad.Name = "lblCantidad";
			this.lblCantidad.Size = new System.Drawing.Size(55, 15);
			this.lblCantidad.TabIndex = 11;
			this.lblCantidad.Text = "Cantidad";
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
			this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAgregar.ForeColor = System.Drawing.Color.White;
			this.btnAgregar.Location = new System.Drawing.Point(183, 194);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(213, 28);
			this.btnAgregar.TabIndex = 3;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// txtProducto
			// 
			this.txtProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
			this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtProducto.ForeColor = System.Drawing.Color.White;
			this.txtProducto.Location = new System.Drawing.Point(183, 64);
			this.txtProducto.Name = "txtProducto";
			this.txtProducto.ReadOnly = true;
			this.txtProducto.Size = new System.Drawing.Size(213, 23);
			this.txtProducto.TabIndex = 1;
			// 
			// lblProducto
			// 
			this.lblProducto.AutoSize = true;
			this.lblProducto.ForeColor = System.Drawing.Color.White;
			this.lblProducto.Location = new System.Drawing.Point(111, 66);
			this.lblProducto.Name = "lblProducto";
			this.lblProducto.Size = new System.Drawing.Size(56, 15);
			this.lblProducto.TabIndex = 14;
			this.lblProducto.Text = "Producto";
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCancelar.ForeColor = System.Drawing.Color.White;
			this.btnCancelar.Location = new System.Drawing.Point(209, 227);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(165, 28);
			this.btnCancelar.TabIndex = 4;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.Cerrar);
			// 
			// FrmAgregarAlCarrito
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
			this.ClientSize = new System.Drawing.Size(532, 267);
			this.ControlBox = false;
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.txtProducto);
			this.Controls.Add(this.lblProducto);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.lblCantidad);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmAgregarAlCarrito";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmAgregarAlCarrito";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lblCantidad;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Label lblProducto;
		private System.Windows.Forms.Button btnCancelar;
		public System.Windows.Forms.TextBox txtCantidad;
		public System.Windows.Forms.TextBox txtProducto;
	}
}