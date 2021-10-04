
namespace ParcialPetShop
{
	partial class FrmLogInVentas
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
			this.txtDni = new System.Windows.Forms.TextBox();
			this.lblDni = new System.Windows.Forms.Label();
			this.btnIngresar = new System.Windows.Forms.Button();
			this.btnAutoCompletar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtDni
			// 
			this.txtDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
			this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDni.ForeColor = System.Drawing.Color.White;
			this.txtDni.Location = new System.Drawing.Point(180, 92);
			this.txtDni.Name = "txtDni";
			this.txtDni.Size = new System.Drawing.Size(213, 23);
			this.txtDni.TabIndex = 1;
			// 
			// lblDni
			// 
			this.lblDni.AutoSize = true;
			this.lblDni.ForeColor = System.Drawing.Color.White;
			this.lblDni.Location = new System.Drawing.Point(136, 94);
			this.lblDni.Name = "lblDni";
			this.lblDni.Size = new System.Drawing.Size(27, 15);
			this.lblDni.TabIndex = 14;
			this.lblDni.Text = "DNI";
			// 
			// btnIngresar
			// 
			this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
			this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnIngresar.ForeColor = System.Drawing.Color.White;
			this.btnIngresar.Location = new System.Drawing.Point(136, 191);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(257, 28);
			this.btnIngresar.TabIndex = 2;
			this.btnIngresar.Text = "Ingresar";
			this.btnIngresar.UseVisualStyleBackColor = false;
			this.btnIngresar.Click += new System.EventHandler(this.IngresarTienda);
			// 
			// btnAutoCompletar
			// 
			this.btnAutoCompletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
			this.btnAutoCompletar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAutoCompletar.ForeColor = System.Drawing.Color.White;
			this.btnAutoCompletar.Location = new System.Drawing.Point(208, 227);
			this.btnAutoCompletar.Name = "btnAutoCompletar";
			this.btnAutoCompletar.Size = new System.Drawing.Size(110, 28);
			this.btnAutoCompletar.TabIndex = 3;
			this.btnAutoCompletar.Text = "AutoCompletar";
			this.btnAutoCompletar.UseVisualStyleBackColor = false;
			this.btnAutoCompletar.Click += new System.EventHandler(this.btnAutoCompletar_Click);
			// 
			// FrmLogInVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
			this.ClientSize = new System.Drawing.Size(532, 267);
			this.Controls.Add(this.btnAutoCompletar);
			this.Controls.Add(this.txtDni);
			this.Controls.Add(this.lblDni);
			this.Controls.Add(this.btnIngresar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmLogInVentas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LogInVentas";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lblDni;
		private System.Windows.Forms.Button btnIngresar;
		public System.Windows.Forms.TextBox txtDni;
		private System.Windows.Forms.Button btnAutoCompletar;
	}
}