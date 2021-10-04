
namespace ParcialPetShop
{
	partial class FrmUsuarios
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
			this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
			this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnTipoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAgregarUsuario = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblTipoUsuario = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.cmbCredential = new System.Windows.Forms.ComboBox();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewUsuarios
			// 
			this.dataGridViewUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
			this.dataGridViewUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(130)))));
			this.dataGridViewUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNombre,
            this.ColumnUser,
            this.ColumnTipoUsuario});
			this.dataGridViewUsuarios.EnableHeadersVisualStyles = false;
			this.dataGridViewUsuarios.GridColor = System.Drawing.Color.Black;
			this.dataGridViewUsuarios.Location = new System.Drawing.Point(1, 1);
			this.dataGridViewUsuarios.MultiSelect = false;
			this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
			this.dataGridViewUsuarios.ReadOnly = true;
			this.dataGridViewUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(130)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			this.dataGridViewUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewUsuarios.RowTemplate.Height = 25;
			this.dataGridViewUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewUsuarios.Size = new System.Drawing.Size(441, 414);
			this.dataGridViewUsuarios.TabIndex = 0;
			this.dataGridViewUsuarios.TabStop = false;
			this.dataGridViewUsuarios.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewUsuarios_RowHeaderMouseClick);
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
			// ColumnUser
			// 
			this.ColumnUser.HeaderText = "User";
			this.ColumnUser.Name = "ColumnUser";
			this.ColumnUser.ReadOnly = true;
			// 
			// ColumnTipoUsuario
			// 
			this.ColumnTipoUsuario.HeaderText = "Tipo Usuario";
			this.ColumnTipoUsuario.Name = "ColumnTipoUsuario";
			this.ColumnTipoUsuario.ReadOnly = true;
			// 
			// btnAgregarUsuario
			// 
			this.btnAgregarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
			this.btnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAgregarUsuario.ForeColor = System.Drawing.Color.White;
			this.btnAgregarUsuario.Location = new System.Drawing.Point(501, 240);
			this.btnAgregarUsuario.Name = "btnAgregarUsuario";
			this.btnAgregarUsuario.Size = new System.Drawing.Size(257, 28);
			this.btnAgregarUsuario.TabIndex = 5;
			this.btnAgregarUsuario.Text = "Agregar";
			this.btnAgregarUsuario.UseVisualStyleBackColor = false;
			this.btnAgregarUsuario.Click += new System.EventHandler(this.AgregarUsuario);
			// 
			// btnModificar
			// 
			this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
			this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnModificar.ForeColor = System.Drawing.Color.White;
			this.btnModificar.Location = new System.Drawing.Point(519, 280);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(225, 28);
			this.btnModificar.TabIndex = 6;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Click += new System.EventHandler(this.ModificarUsuarios);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnEliminar.ForeColor = System.Drawing.Color.White;
			this.btnEliminar.Location = new System.Drawing.Point(519, 326);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(225, 28);
			this.btnEliminar.TabIndex = 7;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.Eliminar);
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.ForeColor = System.Drawing.Color.White;
			this.lblNombre.Location = new System.Drawing.Point(469, 33);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(51, 15);
			this.lblNombre.TabIndex = 4;
			this.lblNombre.Text = "Nombre";
			// 
			// lblUsuario
			// 
			this.lblUsuario.AutoSize = true;
			this.lblUsuario.ForeColor = System.Drawing.Color.White;
			this.lblUsuario.Location = new System.Drawing.Point(473, 74);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(47, 15);
			this.lblUsuario.TabIndex = 5;
			this.lblUsuario.Text = "Usuario";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.ForeColor = System.Drawing.Color.White;
			this.lblPassword.Location = new System.Drawing.Point(473, 122);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(57, 15);
			this.lblPassword.TabIndex = 6;
			this.lblPassword.Text = "Password";
			// 
			// lblTipoUsuario
			// 
			this.lblTipoUsuario.AutoSize = true;
			this.lblTipoUsuario.ForeColor = System.Drawing.Color.White;
			this.lblTipoUsuario.Location = new System.Drawing.Point(473, 179);
			this.lblTipoUsuario.Name = "lblTipoUsuario";
			this.lblTipoUsuario.Size = new System.Drawing.Size(70, 15);
			this.lblTipoUsuario.TabIndex = 7;
			this.lblTipoUsuario.Text = "TipoUsuario";
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
			// txtUsuario
			// 
			this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
			this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUsuario.ForeColor = System.Drawing.Color.White;
			this.txtUsuario.Location = new System.Drawing.Point(545, 72);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(213, 23);
			this.txtUsuario.TabIndex = 2;
			// 
			// txtPassword
			// 
			this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPassword.ForeColor = System.Drawing.Color.White;
			this.txtPassword.Location = new System.Drawing.Point(545, 120);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(213, 23);
			this.txtPassword.TabIndex = 3;
			this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
			// 
			// cmbCredential
			// 
			this.cmbCredential.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
			this.cmbCredential.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCredential.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbCredential.ForeColor = System.Drawing.Color.White;
			this.cmbCredential.FormattingEnabled = true;
			this.cmbCredential.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
			this.cmbCredential.Location = new System.Drawing.Point(549, 176);
			this.cmbCredential.MaxDropDownItems = 2;
			this.cmbCredential.Name = "cmbCredential";
			this.cmbCredential.Size = new System.Drawing.Size(213, 23);
			this.cmbCredential.TabIndex = 4;
			// 
			// btnCerrar
			// 
			this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
			this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCerrar.ForeColor = System.Drawing.Color.White;
			this.btnCerrar.Location = new System.Drawing.Point(1, 435);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(114, 33);
			this.btnCerrar.TabIndex = 9;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = false;
			this.btnCerrar.Click += new System.EventHandler(this.Cerrar);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(239, 421);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(291, 47);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			// 
			// txtBuscar
			// 
			this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
			this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtBuscar.ForeColor = System.Drawing.Color.White;
			this.txtBuscar.Location = new System.Drawing.Point(531, 392);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.PlaceholderText = "Buscar";
			this.txtBuscar.Size = new System.Drawing.Size(213, 23);
			this.txtBuscar.TabIndex = 8;
			this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(739, 149);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(19, 15);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 15;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// FrmUsuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
			this.ClientSize = new System.Drawing.Size(805, 471);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.cmbCredential);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lblTipoUsuario);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUsuario);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnAgregarUsuario);
			this.Controls.Add(this.dataGridViewUsuarios);
			this.Name = "FrmUsuarios";
			this.Text = "FrmUsuarios";
			this.Load += new System.EventHandler(this.FrmUsuarios_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewUsuarios;
		private System.Windows.Forms.Button btnAgregarUsuario;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label lblTipoUsuario;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.ComboBox cmbCredential;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUser;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTipoUsuario;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}