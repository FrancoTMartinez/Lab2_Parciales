
namespace ParcialPetShop
{
	partial class FrmStock
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStock));
			this.btnCerrar = new System.Windows.Forms.Button();
			this.cmbTipoProducto = new System.Windows.Forms.ComboBox();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lblPrecio = new System.Windows.Forms.Label();
			this.lblTipoProducto = new System.Windows.Forms.Label();
			this.lblDescripcion = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.btnEliminarProducto = new System.Windows.Forms.Button();
			this.btnModificarProducto = new System.Windows.Forms.Button();
			this.btnAgregarProducto = new System.Windows.Forms.Button();
			this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
			this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtStock = new System.Windows.Forms.TextBox();
			this.lblStock = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCerrar
			// 
			this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
			this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCerrar.ForeColor = System.Drawing.Color.White;
			this.btnCerrar.Location = new System.Drawing.Point(2, 441);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(114, 33);
			this.btnCerrar.TabIndex = 10;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = false;
			this.btnCerrar.Click += new System.EventHandler(this.Cerrar);
			// 
			// cmbTipoProducto
			// 
			this.cmbTipoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
			this.cmbTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbTipoProducto.ForeColor = System.Drawing.Color.White;
			this.cmbTipoProducto.FormattingEnabled = true;
			this.cmbTipoProducto.Items.AddRange(new object[] {
            "Alimentos",
            "Juguetes",
            "Camas",
            "Limpieza",
            "Farmacia"});
			this.cmbTipoProducto.Location = new System.Drawing.Point(258, 318);
			this.cmbTipoProducto.MaxDropDownItems = 2;
			this.cmbTipoProducto.Name = "cmbTipoProducto";
			this.cmbTipoProducto.Size = new System.Drawing.Size(213, 23);
			this.cmbTipoProducto.TabIndex = 3;
			// 
			// txtPrecio
			// 
			this.txtPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
			this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPrecio.ForeColor = System.Drawing.Color.White;
			this.txtPrecio.Location = new System.Drawing.Point(258, 363);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(213, 23);
			this.txtPrecio.TabIndex = 4;
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
			this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDescripcion.ForeColor = System.Drawing.Color.White;
			this.txtDescripcion.Location = new System.Drawing.Point(258, 268);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(213, 23);
			this.txtDescripcion.TabIndex = 2;
			// 
			// txtNombre
			// 
			this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
			this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNombre.ForeColor = System.Drawing.Color.White;
			this.txtNombre.Location = new System.Drawing.Point(258, 227);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(213, 23);
			this.txtNombre.TabIndex = 1;
			// 
			// lblPrecio
			// 
			this.lblPrecio.AutoSize = true;
			this.lblPrecio.ForeColor = System.Drawing.Color.White;
			this.lblPrecio.Location = new System.Drawing.Point(173, 363);
			this.lblPrecio.Name = "lblPrecio";
			this.lblPrecio.Size = new System.Drawing.Size(40, 15);
			this.lblPrecio.TabIndex = 20;
			this.lblPrecio.Text = "Precio";
			this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblTipoProducto
			// 
			this.lblTipoProducto.AutoSize = true;
			this.lblTipoProducto.ForeColor = System.Drawing.Color.White;
			this.lblTipoProducto.Location = new System.Drawing.Point(173, 318);
			this.lblTipoProducto.Name = "lblTipoProducto";
			this.lblTipoProducto.Size = new System.Drawing.Size(82, 15);
			this.lblTipoProducto.TabIndex = 19;
			this.lblTipoProducto.Text = "Tipo Producto";
			this.lblTipoProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblDescripcion
			// 
			this.lblDescripcion.AutoSize = true;
			this.lblDescripcion.ForeColor = System.Drawing.Color.White;
			this.lblDescripcion.Location = new System.Drawing.Point(173, 270);
			this.lblDescripcion.Name = "lblDescripcion";
			this.lblDescripcion.Size = new System.Drawing.Size(69, 15);
			this.lblDescripcion.TabIndex = 18;
			this.lblDescripcion.Text = "Descripcion";
			this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.ForeColor = System.Drawing.Color.White;
			this.lblNombre.Location = new System.Drawing.Point(173, 229);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(51, 15);
			this.lblNombre.TabIndex = 17;
			this.lblNombre.Text = "Nombre";
			this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnEliminarProducto
			// 
			this.btnEliminarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
			this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnEliminarProducto.ForeColor = System.Drawing.Color.White;
			this.btnEliminarProducto.Location = new System.Drawing.Point(542, 378);
			this.btnEliminarProducto.Name = "btnEliminarProducto";
			this.btnEliminarProducto.Size = new System.Drawing.Size(225, 28);
			this.btnEliminarProducto.TabIndex = 8;
			this.btnEliminarProducto.Text = "Eliminar";
			this.btnEliminarProducto.UseVisualStyleBackColor = false;
			this.btnEliminarProducto.Click += new System.EventHandler(this.Eliminar);
			// 
			// btnModificarProducto
			// 
			this.btnModificarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
			this.btnModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnModificarProducto.ForeColor = System.Drawing.Color.White;
			this.btnModificarProducto.Location = new System.Drawing.Point(542, 307);
			this.btnModificarProducto.Name = "btnModificarProducto";
			this.btnModificarProducto.Size = new System.Drawing.Size(225, 28);
			this.btnModificarProducto.TabIndex = 7;
			this.btnModificarProducto.Text = "Modificar";
			this.btnModificarProducto.UseVisualStyleBackColor = false;
			this.btnModificarProducto.Click += new System.EventHandler(this.Modificar);
			// 
			// btnAgregarProducto
			// 
			this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
			this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
			this.btnAgregarProducto.Location = new System.Drawing.Point(542, 242);
			this.btnAgregarProducto.Name = "btnAgregarProducto";
			this.btnAgregarProducto.Size = new System.Drawing.Size(225, 28);
			this.btnAgregarProducto.TabIndex = 6;
			this.btnAgregarProducto.Text = "Agregar";
			this.btnAgregarProducto.UseVisualStyleBackColor = false;
			this.btnAgregarProducto.Click += new System.EventHandler(this.AgregarProducto);
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
            this.ColumnDescripcion,
            this.ColumnTipo,
            this.ColumnPrecio,
            this.ColumnStock});
			this.dataGridViewProductos.EnableHeadersVisualStyles = false;
			this.dataGridViewProductos.GridColor = System.Drawing.Color.Black;
			this.dataGridViewProductos.Location = new System.Drawing.Point(52, 12);
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
			this.dataGridViewProductos.Size = new System.Drawing.Size(703, 183);
			this.dataGridViewProductos.TabIndex = 26;
			this.dataGridViewProductos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewProductos_RowHeaderMouseClick);
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
			// ColumnDescripcion
			// 
			this.ColumnDescripcion.HeaderText = "Descripcion";
			this.ColumnDescripcion.Name = "ColumnDescripcion";
			this.ColumnDescripcion.ReadOnly = true;
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
			// txtStock
			// 
			this.txtStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
			this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtStock.ForeColor = System.Drawing.Color.White;
			this.txtStock.Location = new System.Drawing.Point(258, 405);
			this.txtStock.Name = "txtStock";
			this.txtStock.Size = new System.Drawing.Size(213, 23);
			this.txtStock.TabIndex = 5;
			// 
			// lblStock
			// 
			this.lblStock.AutoSize = true;
			this.lblStock.ForeColor = System.Drawing.Color.White;
			this.lblStock.Location = new System.Drawing.Point(173, 405);
			this.lblStock.Name = "lblStock";
			this.lblStock.Size = new System.Drawing.Size(36, 15);
			this.lblStock.TabIndex = 27;
			this.lblStock.Text = "Stock";
			this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(215, 432);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(291, 47);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 29;
			this.pictureBox1.TabStop = false;
			// 
			// txtBuscar
			// 
			this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
			this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtBuscar.ForeColor = System.Drawing.Color.White;
			this.txtBuscar.Location = new System.Drawing.Point(554, 441);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.PlaceholderText = "Buscar";
			this.txtBuscar.Size = new System.Drawing.Size(213, 23);
			this.txtBuscar.TabIndex = 9;
			this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
			// 
			// FrmStock
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
			this.ClientSize = new System.Drawing.Size(807, 482);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtStock);
			this.Controls.Add(this.lblStock);
			this.Controls.Add(this.dataGridViewProductos);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.cmbTipoProducto);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lblPrecio);
			this.Controls.Add(this.lblTipoProducto);
			this.Controls.Add(this.lblDescripcion);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.btnEliminarProducto);
			this.Controls.Add(this.btnModificarProducto);
			this.Controls.Add(this.btnAgregarProducto);
			this.Name = "FrmStock";
			this.Text = "FrmStock";
			this.Load += new System.EventHandler(this.FrmStock_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.ComboBox cmbTipoProducto;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label lblPrecio;
		private System.Windows.Forms.Label lblTipoProducto;
		private System.Windows.Forms.Label lblDescripcion;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Button btnEliminarProducto;
		private System.Windows.Forms.Button btnModificarProducto;
		private System.Windows.Forms.Button btnAgregarProducto;
		private System.Windows.Forms.TextBox txtStock;
		private System.Windows.Forms.Label lblStock;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecio;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStock;
		private System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.DataGridView dataGridViewProductos;
		private System.Windows.Forms.TextBox txtBuscar;
	}
}