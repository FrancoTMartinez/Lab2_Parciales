
namespace ParcialPetShop
{
	partial class FrmVentas
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnEliminarDelCarrito = new System.Windows.Forms.Button();
			this.btnModificarCantidadCarrito = new System.Windows.Forms.Button();
			this.btnAgregarAlCarrito = new System.Windows.Forms.Button();
			this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
			this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewCarrito = new System.Windows.Forms.DataGridView();
			this.ColumnIdCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnNombreCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnCantidadCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPrecioCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtPrecioTotal = new System.Windows.Forms.TextBox();
			this.lblTotal = new System.Windows.Forms.Label();
			this.btnComprar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblNombreCliente = new System.Windows.Forms.Label();
			this.lblDni = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrito)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCerrar
			// 
			this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
			this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCerrar.ForeColor = System.Drawing.Color.White;
			this.btnCerrar.Location = new System.Drawing.Point(-1, 436);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(114, 33);
			this.btnCerrar.TabIndex = 5;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = false;
			this.btnCerrar.Click += new System.EventHandler(this.Cerrar);
			// 
			// btnEliminarDelCarrito
			// 
			this.btnEliminarDelCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
			this.btnEliminarDelCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnEliminarDelCarrito.ForeColor = System.Drawing.Color.White;
			this.btnEliminarDelCarrito.Location = new System.Drawing.Point(12, 349);
			this.btnEliminarDelCarrito.Name = "btnEliminarDelCarrito";
			this.btnEliminarDelCarrito.Size = new System.Drawing.Size(257, 28);
			this.btnEliminarDelCarrito.TabIndex = 3;
			this.btnEliminarDelCarrito.Text = "Eliminar Del Carrito";
			this.btnEliminarDelCarrito.UseVisualStyleBackColor = false;
			this.btnEliminarDelCarrito.Click += new System.EventHandler(this.EliminarDelCarrito);
			// 
			// btnModificarCantidadCarrito
			// 
			this.btnModificarCantidadCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
			this.btnModificarCantidadCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnModificarCantidadCarrito.ForeColor = System.Drawing.Color.White;
			this.btnModificarCantidadCarrito.Location = new System.Drawing.Point(12, 302);
			this.btnModificarCantidadCarrito.Name = "btnModificarCantidadCarrito";
			this.btnModificarCantidadCarrito.Size = new System.Drawing.Size(257, 28);
			this.btnModificarCantidadCarrito.TabIndex = 2;
			this.btnModificarCantidadCarrito.Text = "Modificar Cantidad";
			this.btnModificarCantidadCarrito.UseVisualStyleBackColor = false;
			this.btnModificarCantidadCarrito.Click += new System.EventHandler(this.ModificarCantidadCarrito);
			// 
			// btnAgregarAlCarrito
			// 
			this.btnAgregarAlCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
			this.btnAgregarAlCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAgregarAlCarrito.ForeColor = System.Drawing.Color.White;
			this.btnAgregarAlCarrito.Location = new System.Drawing.Point(12, 258);
			this.btnAgregarAlCarrito.Name = "btnAgregarAlCarrito";
			this.btnAgregarAlCarrito.Size = new System.Drawing.Size(257, 28);
			this.btnAgregarAlCarrito.TabIndex = 1;
			this.btnAgregarAlCarrito.Text = "Agregar Al Carrito";
			this.btnAgregarAlCarrito.UseVisualStyleBackColor = false;
			this.btnAgregarAlCarrito.Click += new System.EventHandler(this.AgregarAlCarrito);
			// 
			// dataGridViewProductos
			// 
			this.dataGridViewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
			this.dataGridViewProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(130)))));
			this.dataGridViewProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNombre,
            this.ColumnDescription,
            this.ColumnTipo,
            this.ColumnPrecio,
            this.ColumnStock});
			this.dataGridViewProductos.EnableHeadersVisualStyles = false;
			this.dataGridViewProductos.GridColor = System.Drawing.Color.Black;
			this.dataGridViewProductos.Location = new System.Drawing.Point(11, 12);
			this.dataGridViewProductos.MultiSelect = false;
			this.dataGridViewProductos.Name = "dataGridViewProductos";
			this.dataGridViewProductos.ReadOnly = true;
			this.dataGridViewProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(130)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			this.dataGridViewProductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewProductos.RowTemplate.Height = 25;
			this.dataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewProductos.Size = new System.Drawing.Size(777, 183);
			this.dataGridViewProductos.TabIndex = 13;
			// 
			// ColumnId
			// 
			this.ColumnId.HeaderText = "Id";
			this.ColumnId.Name = "ColumnId";
			this.ColumnId.ReadOnly = true;
			// 
			// ColumnNombre
			// 
			this.ColumnNombre.HeaderText = "Nombre";
			this.ColumnNombre.Name = "ColumnNombre";
			this.ColumnNombre.ReadOnly = true;
			// 
			// ColumnDescription
			// 
			this.ColumnDescription.HeaderText = "Descripcion";
			this.ColumnDescription.Name = "ColumnDescription";
			this.ColumnDescription.ReadOnly = true;
			// 
			// ColumnTipo
			// 
			this.ColumnTipo.HeaderText = "Tipo";
			this.ColumnTipo.Name = "ColumnTipo";
			this.ColumnTipo.ReadOnly = true;
			// 
			// ColumnPrecio
			// 
			this.ColumnPrecio.HeaderText = "Precio";
			this.ColumnPrecio.Name = "ColumnPrecio";
			this.ColumnPrecio.ReadOnly = true;
			// 
			// ColumnStock
			// 
			this.ColumnStock.HeaderText = "Stock";
			this.ColumnStock.Name = "ColumnStock";
			this.ColumnStock.ReadOnly = true;
			// 
			// dataGridViewCarrito
			// 
			this.dataGridViewCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewCarrito.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
			this.dataGridViewCarrito.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(130)))));
			this.dataGridViewCarrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewCarrito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdCarrito,
            this.ColumnNombreCarrito,
            this.ColumnCantidadCarrito,
            this.ColumnPrecioCarrito});
			this.dataGridViewCarrito.EnableHeadersVisualStyles = false;
			this.dataGridViewCarrito.GridColor = System.Drawing.Color.Black;
			this.dataGridViewCarrito.Location = new System.Drawing.Point(391, 201);
			this.dataGridViewCarrito.MultiSelect = false;
			this.dataGridViewCarrito.Name = "dataGridViewCarrito";
			this.dataGridViewCarrito.ReadOnly = true;
			this.dataGridViewCarrito.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewCarrito.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(130)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
			this.dataGridViewCarrito.RowsDefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridViewCarrito.RowTemplate.Height = 25;
			this.dataGridViewCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewCarrito.Size = new System.Drawing.Size(371, 176);
			this.dataGridViewCarrito.TabIndex = 26;
			// 
			// ColumnIdCarrito
			// 
			this.ColumnIdCarrito.HeaderText = "Id";
			this.ColumnIdCarrito.Name = "ColumnIdCarrito";
			this.ColumnIdCarrito.ReadOnly = true;
			// 
			// ColumnNombreCarrito
			// 
			this.ColumnNombreCarrito.HeaderText = "Nombre";
			this.ColumnNombreCarrito.Name = "ColumnNombreCarrito";
			this.ColumnNombreCarrito.ReadOnly = true;
			// 
			// ColumnCantidadCarrito
			// 
			this.ColumnCantidadCarrito.HeaderText = "Cantidad";
			this.ColumnCantidadCarrito.Name = "ColumnCantidadCarrito";
			this.ColumnCantidadCarrito.ReadOnly = true;
			// 
			// ColumnPrecioCarrito
			// 
			this.ColumnPrecioCarrito.HeaderText = "Precio";
			this.ColumnPrecioCarrito.Name = "ColumnPrecioCarrito";
			this.ColumnPrecioCarrito.ReadOnly = true;
			// 
			// txtPrecioTotal
			// 
			this.txtPrecioTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
			this.txtPrecioTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPrecioTotal.ForeColor = System.Drawing.Color.White;
			this.txtPrecioTotal.Location = new System.Drawing.Point(420, 396);
			this.txtPrecioTotal.Name = "txtPrecioTotal";
			this.txtPrecioTotal.ReadOnly = true;
			this.txtPrecioTotal.Size = new System.Drawing.Size(213, 23);
			this.txtPrecioTotal.TabIndex = 28;
			// 
			// lblTotal
			// 
			this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblTotal.ForeColor = System.Drawing.Color.White;
			this.lblTotal.Location = new System.Drawing.Point(344, 396);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(70, 23);
			this.lblTotal.TabIndex = 29;
			this.lblTotal.Text = "Total    $";
			// 
			// btnComprar
			// 
			this.btnComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
			this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnComprar.ForeColor = System.Drawing.Color.White;
			this.btnComprar.Location = new System.Drawing.Point(663, 396);
			this.btnComprar.Name = "btnComprar";
			this.btnComprar.Size = new System.Drawing.Size(99, 23);
			this.btnComprar.TabIndex = 4;
			this.btnComprar.Text = "Comprar";
			this.btnComprar.UseVisualStyleBackColor = false;
			this.btnComprar.Click += new System.EventHandler(this.RealizarCompra);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(239, 422);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(291, 47);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 31;
			this.pictureBox1.TabStop = false;
			// 
			// lblNombreCliente
			// 
			this.lblNombreCliente.AutoSize = true;
			this.lblNombreCliente.ForeColor = System.Drawing.Color.White;
			this.lblNombreCliente.Location = new System.Drawing.Point(13, 216);
			this.lblNombreCliente.Name = "lblNombreCliente";
			this.lblNombreCliente.Size = new System.Drawing.Size(88, 15);
			this.lblNombreCliente.TabIndex = 32;
			this.lblNombreCliente.Text = "NombreCliente";
			// 
			// lblDni
			// 
			this.lblDni.AutoSize = true;
			this.lblDni.ForeColor = System.Drawing.Color.White;
			this.lblDni.Location = new System.Drawing.Point(197, 216);
			this.lblDni.Name = "lblDni";
			this.lblDni.Size = new System.Drawing.Size(25, 15);
			this.lblDni.TabIndex = 33;
			this.lblDni.Text = "Dni";
			// 
			// FrmVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
			this.ClientSize = new System.Drawing.Size(805, 471);
			this.Controls.Add(this.lblDni);
			this.Controls.Add(this.lblNombreCliente);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnComprar);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.txtPrecioTotal);
			this.Controls.Add(this.dataGridViewCarrito);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnEliminarDelCarrito);
			this.Controls.Add(this.btnModificarCantidadCarrito);
			this.Controls.Add(this.btnAgregarAlCarrito);
			this.Controls.Add(this.dataGridViewProductos);
			this.Name = "FrmVentas";
			this.Text = "FrmVentas";
			this.Load += new System.EventHandler(this.FrmVentas_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrito)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnEliminarDelCarrito;
		private System.Windows.Forms.Button btnModificarCantidadCarrito;
		private System.Windows.Forms.DataGridView dataGridViewProductos;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecio;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStock;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdCarrito;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombreCarrito;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidadCarrito;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecioCarrito;
		public System.Windows.Forms.DataGridView dataGridViewCarrito;
		private System.Windows.Forms.TextBox txtPrecioTotal;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Button btnComprar;
		private System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.Button btnAgregarAlCarrito;
		public System.Windows.Forms.Label lblNombreCliente;
		public System.Windows.Forms.Label lblDni;
	}
}