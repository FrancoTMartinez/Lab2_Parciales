
namespace ParcialPetShop
{
	partial class FrmHistorialVentas
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
			this.dataGridViewHistorialVentas = new System.Windows.Forms.DataGridView();
			this.lblHistorialVentas = new System.Windows.Forms.Label();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.ColumnDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorialVentas)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewHistorialVentas
			// 
			this.dataGridViewHistorialVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewHistorialVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
			this.dataGridViewHistorialVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(130)))));
			this.dataGridViewHistorialVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewHistorialVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewHistorialVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewHistorialVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewHistorialVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDNI,
            this.ColumnId,
            this.ColumnProducto,
            this.ColumnCantidad,
            this.ColumnPrecio});
			this.dataGridViewHistorialVentas.EnableHeadersVisualStyles = false;
			this.dataGridViewHistorialVentas.GridColor = System.Drawing.Color.Black;
			this.dataGridViewHistorialVentas.Location = new System.Drawing.Point(127, 27);
			this.dataGridViewHistorialVentas.Name = "dataGridViewHistorialVentas";
			this.dataGridViewHistorialVentas.ReadOnly = true;
			this.dataGridViewHistorialVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewHistorialVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(130)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			this.dataGridViewHistorialVentas.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewHistorialVentas.RowTemplate.Height = 25;
			this.dataGridViewHistorialVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewHistorialVentas.Size = new System.Drawing.Size(592, 339);
			this.dataGridViewHistorialVentas.TabIndex = 27;
			// 
			// lblHistorialVentas
			// 
			this.lblHistorialVentas.AutoSize = true;
			this.lblHistorialVentas.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
			this.lblHistorialVentas.ForeColor = System.Drawing.Color.White;
			this.lblHistorialVentas.Location = new System.Drawing.Point(171, 403);
			this.lblHistorialVentas.Name = "lblHistorialVentas";
			this.lblHistorialVentas.Size = new System.Drawing.Size(238, 37);
			this.lblHistorialVentas.TabIndex = 33;
			this.lblHistorialVentas.Text = "Historial de Ventas";
			// 
			// btnActualizar
			// 
			this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
			this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnActualizar.ForeColor = System.Drawing.Color.White;
			this.btnActualizar.Location = new System.Drawing.Point(431, 412);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(257, 28);
			this.btnActualizar.TabIndex = 34;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = false;
			this.btnActualizar.Click += new System.EventHandler(this.Actualizar);
			// 
			// btnCerrar
			// 
			this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
			this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCerrar.ForeColor = System.Drawing.Color.White;
			this.btnCerrar.Location = new System.Drawing.Point(3, 435);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(114, 33);
			this.btnCerrar.TabIndex = 35;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = false;
			this.btnCerrar.Click += new System.EventHandler(this.Cerrar);
			// 
			// ColumnDNI
			// 
			this.ColumnDNI.HeaderText = "DNI";
			this.ColumnDNI.Name = "ColumnDNI";
			this.ColumnDNI.ReadOnly = true;
			// 
			// ColumnId
			// 
			this.ColumnId.HeaderText = "IdProducto";
			this.ColumnId.Name = "ColumnId";
			this.ColumnId.ReadOnly = true;
			// 
			// ColumnProducto
			// 
			this.ColumnProducto.HeaderText = "Producto";
			this.ColumnProducto.Name = "ColumnProducto";
			this.ColumnProducto.ReadOnly = true;
			// 
			// ColumnCantidad
			// 
			this.ColumnCantidad.HeaderText = "Cantidad";
			this.ColumnCantidad.Name = "ColumnCantidad";
			this.ColumnCantidad.ReadOnly = true;
			// 
			// ColumnPrecio
			// 
			this.ColumnPrecio.HeaderText = "Precio";
			this.ColumnPrecio.Name = "ColumnPrecio";
			this.ColumnPrecio.ReadOnly = true;
			// 
			// FrmHistorialVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
			this.ClientSize = new System.Drawing.Size(805, 471);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.lblHistorialVentas);
			this.Controls.Add(this.dataGridViewHistorialVentas);
			this.Name = "FrmHistorialVentas";
			this.Text = "FrmHistorialVentas";
			this.Load += new System.EventHandler(this.FrmHistorialVentas_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorialVentas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.DataGridView dataGridViewHistorialVentas;
		public System.Windows.Forms.Label lblHistorialVentas;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDNI;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProducto;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecio;
	}
}