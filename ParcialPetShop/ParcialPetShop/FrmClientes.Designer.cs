
namespace ParcialPetShop
{
	partial class FrmClientes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
			this.txtDni = new System.Windows.Forms.TextBox();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lblSaldo = new System.Windows.Forms.Label();
			this.lblDni = new System.Windows.Forms.Label();
			this.lblApellido = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnAgregarCliente = new System.Windows.Forms.Button();
			this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
			this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtSaldo = new System.Windows.Forms.TextBox();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtDni
			// 
			this.txtDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
			this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDni.ForeColor = System.Drawing.Color.White;
			this.txtDni.Location = new System.Drawing.Point(545, 120);
			this.txtDni.Name = "txtDni";
			this.txtDni.Size = new System.Drawing.Size(213, 23);
			this.txtDni.TabIndex = 3;
			// 
			// txtApellido
			// 
			this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
			this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtApellido.ForeColor = System.Drawing.Color.White;
			this.txtApellido.Location = new System.Drawing.Point(545, 72);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(213, 23);
			this.txtApellido.TabIndex = 2;
			// 
			// txtNombre
			// 
			this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
			this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNombre.ForeColor = System.Drawing.Color.White;
			this.txtNombre.Location = new System.Drawing.Point(545, 31);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(213, 23);
			this.txtNombre.TabIndex = 1;
			// 
			// lblSaldo
			// 
			this.lblSaldo.AutoSize = true;
			this.lblSaldo.ForeColor = System.Drawing.Color.White;
			this.lblSaldo.Location = new System.Drawing.Point(473, 169);
			this.lblSaldo.Name = "lblSaldo";
			this.lblSaldo.Size = new System.Drawing.Size(36, 15);
			this.lblSaldo.TabIndex = 19;
			this.lblSaldo.Text = "Saldo";
			// 
			// lblDni
			// 
			this.lblDni.AutoSize = true;
			this.lblDni.ForeColor = System.Drawing.Color.White;
			this.lblDni.Location = new System.Drawing.Point(473, 122);
			this.lblDni.Name = "lblDni";
			this.lblDni.Size = new System.Drawing.Size(27, 15);
			this.lblDni.TabIndex = 18;
			this.lblDni.Text = "DNI";
			// 
			// lblApellido
			// 
			this.lblApellido.AutoSize = true;
			this.lblApellido.ForeColor = System.Drawing.Color.White;
			this.lblApellido.Location = new System.Drawing.Point(473, 74);
			this.lblApellido.Name = "lblApellido";
			this.lblApellido.Size = new System.Drawing.Size(51, 15);
			this.lblApellido.TabIndex = 17;
			this.lblApellido.Text = "Apellido";
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.ForeColor = System.Drawing.Color.White;
			this.lblNombre.Location = new System.Drawing.Point(473, 33);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(51, 15);
			this.lblNombre.TabIndex = 16;
			this.lblNombre.Text = "Nombre";
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnEliminar.ForeColor = System.Drawing.Color.White;
			this.btnEliminar.Location = new System.Drawing.Point(518, 329);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(225, 28);
			this.btnEliminar.TabIndex = 7;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.Eliminar);
			// 
			// btnModificar
			// 
			this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
			this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnModificar.ForeColor = System.Drawing.Color.White;
			this.btnModificar.Location = new System.Drawing.Point(518, 283);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(225, 28);
			this.btnModificar.TabIndex = 6;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Click += new System.EventHandler(this.ModificarClientes);
			// 
			// btnAgregarCliente
			// 
			this.btnAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
			this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAgregarCliente.ForeColor = System.Drawing.Color.White;
			this.btnAgregarCliente.Location = new System.Drawing.Point(501, 240);
			this.btnAgregarCliente.Name = "btnAgregarCliente";
			this.btnAgregarCliente.Size = new System.Drawing.Size(257, 28);
			this.btnAgregarCliente.TabIndex = 5;
			this.btnAgregarCliente.Text = "Agregar";
			this.btnAgregarCliente.UseVisualStyleBackColor = false;
			this.btnAgregarCliente.Click += new System.EventHandler(this.AgregarCliente);
			// 
			// dataGridViewClientes
			// 
			this.dataGridViewClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
			this.dataGridViewClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(130)))));
			this.dataGridViewClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNombre,
            this.ColumnApellido,
            this.ColumnDni,
            this.ColumnSaldo});
			this.dataGridViewClientes.EnableHeadersVisualStyles = false;
			this.dataGridViewClientes.GridColor = System.Drawing.Color.Black;
			this.dataGridViewClientes.Location = new System.Drawing.Point(1, 1);
			this.dataGridViewClientes.MultiSelect = false;
			this.dataGridViewClientes.Name = "dataGridViewClientes";
			this.dataGridViewClientes.ReadOnly = true;
			this.dataGridViewClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(130)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			this.dataGridViewClientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewClientes.RowTemplate.Height = 25;
			this.dataGridViewClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewClientes.Size = new System.Drawing.Size(441, 414);
			this.dataGridViewClientes.TabIndex = 12;
			this.dataGridViewClientes.TabStop = false;
			this.dataGridViewClientes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewClientes_RowHeaderMouseClick);
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
			// ColumnApellido
			// 
			this.ColumnApellido.HeaderText = "Apellido";
			this.ColumnApellido.Name = "ColumnApellido";
			this.ColumnApellido.ReadOnly = true;
			// 
			// ColumnDni
			// 
			this.ColumnDni.HeaderText = "DNI";
			this.ColumnDni.Name = "ColumnDni";
			this.ColumnDni.ReadOnly = true;
			// 
			// ColumnSaldo
			// 
			this.ColumnSaldo.HeaderText = "Saldo";
			this.ColumnSaldo.Name = "ColumnSaldo";
			this.ColumnSaldo.ReadOnly = true;
			// 
			// txtSaldo
			// 
			this.txtSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
			this.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSaldo.ForeColor = System.Drawing.Color.White;
			this.txtSaldo.Location = new System.Drawing.Point(545, 167);
			this.txtSaldo.Name = "txtSaldo";
			this.txtSaldo.Size = new System.Drawing.Size(213, 23);
			this.txtSaldo.TabIndex = 4;
			// 
			// btnCerrar
			// 
			this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
			this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCerrar.ForeColor = System.Drawing.Color.White;
			this.btnCerrar.Location = new System.Drawing.Point(1, 436);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(114, 34);
			this.btnCerrar.TabIndex = 9;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = false;
			this.btnCerrar.Click += new System.EventHandler(this.Cerrar);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(238, 421);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(291, 47);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 25;
			this.pictureBox1.TabStop = false;
			// 
			// txtBuscar
			// 
			this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
			this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtBuscar.ForeColor = System.Drawing.Color.White;
			this.txtBuscar.Location = new System.Drawing.Point(530, 392);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.PlaceholderText = "Buscar";
			this.txtBuscar.Size = new System.Drawing.Size(213, 23);
			this.txtBuscar.TabIndex = 8;
			this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
			// 
			// FrmClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
			this.ClientSize = new System.Drawing.Size(805, 471);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.txtSaldo);
			this.Controls.Add(this.txtDni);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lblSaldo);
			this.Controls.Add(this.lblDni);
			this.Controls.Add(this.lblApellido);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnAgregarCliente);
			this.Controls.Add(this.dataGridViewClientes);
			this.Name = "FrmClientes";
			this.Text = "FrmClientes";
			this.Load += new System.EventHandler(this.FrmClientes_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txtDni;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label lblSaldo;
		private System.Windows.Forms.Label lblDni;
		private System.Windows.Forms.Label lblApellido;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnAgregarCliente;
		private System.Windows.Forms.DataGridView dataGridViewClientes;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApellido;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDni;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSaldo;
		private System.Windows.Forms.TextBox txtSaldo;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtBuscar;
	}
}