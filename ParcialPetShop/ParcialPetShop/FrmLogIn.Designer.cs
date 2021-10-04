
namespace ParcialPetShop
{
	partial class FrmLogIn
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogIn));
			this.txtUser = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lblUser = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.cmbCredential = new System.Windows.Forms.ComboBox();
			this.lblTipoUsuario = new System.Windows.Forms.Label();
			this.btnIngresar = new System.Windows.Forms.Button();
			this.btnAutoCompleteCredentials = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnMinimizarLogin = new System.Windows.Forms.PictureBox();
			this.btnCerrarLogin = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimizarLogin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCerrarLogin)).BeginInit();
			this.SuspendLayout();
			// 
			// txtUser
			// 
			this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
			this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUser.ForeColor = System.Drawing.Color.White;
			this.txtUser.Location = new System.Drawing.Point(181, 49);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(213, 23);
			this.txtUser.TabIndex = 1;
			// 
			// txtPassword
			// 
			this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPassword.ForeColor = System.Drawing.Color.White;
			this.txtPassword.Location = new System.Drawing.Point(181, 112);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(213, 23);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.TextChanged += new System.EventHandler(this.EnterPassword);
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.Location = new System.Drawing.Point(49, 49);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(47, 15);
			this.lblUser.TabIndex = 2;
			this.lblUser.Text = "Usuario";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(49, 112);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(57, 15);
			this.lblPassword.TabIndex = 3;
			this.lblPassword.Text = "Password";
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
			this.cmbCredential.Location = new System.Drawing.Point(181, 171);
			this.cmbCredential.MaxDropDownItems = 2;
			this.cmbCredential.Name = "cmbCredential";
			this.cmbCredential.Size = new System.Drawing.Size(213, 23);
			this.cmbCredential.TabIndex = 3;
			// 
			// lblTipoUsuario
			// 
			this.lblTipoUsuario.AutoSize = true;
			this.lblTipoUsuario.Location = new System.Drawing.Point(49, 178);
			this.lblTipoUsuario.Name = "lblTipoUsuario";
			this.lblTipoUsuario.Size = new System.Drawing.Size(89, 15);
			this.lblTipoUsuario.TabIndex = 5;
			this.lblTipoUsuario.Text = "Tipo de Usuario";
			// 
			// btnIngresar
			// 
			this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnIngresar.FlatAppearance.BorderSize = 0;
			this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
			this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIngresar.ForeColor = System.Drawing.Color.White;
			this.btnIngresar.Location = new System.Drawing.Point(225, 242);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(75, 23);
			this.btnIngresar.TabIndex = 4;
			this.btnIngresar.Text = "Ingresar";
			this.btnIngresar.UseVisualStyleBackColor = false;
			this.btnIngresar.Click += new System.EventHandler(this.Ingresar);
			// 
			// btnAutoCompleteCredentials
			// 
			this.btnAutoCompleteCredentials.FlatAppearance.BorderSize = 0;
			this.btnAutoCompleteCredentials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAutoCompleteCredentials.ForeColor = System.Drawing.Color.White;
			this.btnAutoCompleteCredentials.Location = new System.Drawing.Point(203, 307);
			this.btnAutoCompleteCredentials.Name = "btnAutoCompleteCredentials";
			this.btnAutoCompleteCredentials.Size = new System.Drawing.Size(126, 23);
			this.btnAutoCompleteCredentials.TabIndex = 5;
			this.btnAutoCompleteCredentials.Text = "AutoCompletar";
			this.btnAutoCompleteCredentials.UseVisualStyleBackColor = true;
			this.btnAutoCompleteCredentials.Click += new System.EventHandler(this.AutoCompletarCredenciales);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.btnMinimizarLogin);
			this.panel1.Controls.Add(this.btnCerrarLogin);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(530, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(250, 330);
			this.panel1.TabIndex = 8;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(174, 163);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(36, 35);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(82, 152);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 34);
			this.label1.TabIndex = 3;
			this.label1.Text = "Pet Shop";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-151, 19);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(581, 237);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// btnMinimizarLogin
			// 
			this.btnMinimizarLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizarLogin.Image")));
			this.btnMinimizarLogin.Location = new System.Drawing.Point(185, -28);
			this.btnMinimizarLogin.Name = "btnMinimizarLogin";
			this.btnMinimizarLogin.Size = new System.Drawing.Size(33, 53);
			this.btnMinimizarLogin.TabIndex = 1;
			this.btnMinimizarLogin.TabStop = false;
			this.btnMinimizarLogin.Click += new System.EventHandler(this.btnMinimizarLogin_Click);
			// 
			// btnCerrarLogin
			// 
			this.btnCerrarLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarLogin.Image")));
			this.btnCerrarLogin.Location = new System.Drawing.Point(224, 0);
			this.btnCerrarLogin.Name = "btnCerrarLogin";
			this.btnCerrarLogin.Size = new System.Drawing.Size(25, 25);
			this.btnCerrarLogin.TabIndex = 0;
			this.btnCerrarLogin.TabStop = false;
			this.btnCerrarLogin.Click += new System.EventHandler(this.btnCerrarLogin_Click);
			// 
			// FrmLogIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.ClientSize = new System.Drawing.Size(780, 330);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnAutoCompleteCredentials);
			this.Controls.Add(this.btnIngresar);
			this.Controls.Add(this.lblTipoUsuario);
			this.Controls.Add(this.cmbCredential);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUser);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUser);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmLogIn";
			this.Opacity = 0.95D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Log In";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimizarLogin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCerrarLogin)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.ComboBox cmbCredential;
		private System.Windows.Forms.Label lblTipoUsuario;
		private System.Windows.Forms.Button btnIngresar;
		private System.Windows.Forms.Button btnAutoCompleteCredentials;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox btnMinimizarLogin;
		private System.Windows.Forms.PictureBox btnCerrarLogin;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}

