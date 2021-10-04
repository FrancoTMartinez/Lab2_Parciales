
namespace ParcialPetShop
{
	partial class FrmCompraRealizada
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
			this.lblMensaje = new System.Windows.Forms.Label();
			this.btnOk = new System.Windows.Forms.Button();
			this.lblMensaje2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblMensaje
			// 
			this.lblMensaje.AutoSize = true;
			this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblMensaje.ForeColor = System.Drawing.Color.White;
			this.lblMensaje.Location = new System.Drawing.Point(135, 61);
			this.lblMensaje.Name = "lblMensaje";
			this.lblMensaje.Size = new System.Drawing.Size(68, 21);
			this.lblMensaje.TabIndex = 0;
			this.lblMensaje.Text = "Mensaje";
			// 
			// btnOk
			// 
			this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnOk.ForeColor = System.Drawing.Color.White;
			this.btnOk.Location = new System.Drawing.Point(166, 169);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(153, 28);
			this.btnOk.TabIndex = 12;
			this.btnOk.Text = "Ok";
			this.btnOk.UseVisualStyleBackColor = false;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// lblMensaje2
			// 
			this.lblMensaje2.AutoSize = true;
			this.lblMensaje2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblMensaje2.ForeColor = System.Drawing.Color.White;
			this.lblMensaje2.Location = new System.Drawing.Point(135, 104);
			this.lblMensaje2.Name = "lblMensaje2";
			this.lblMensaje2.Size = new System.Drawing.Size(68, 21);
			this.lblMensaje2.TabIndex = 13;
			this.lblMensaje2.Text = "Mensaje";
			// 
			// FrmCompraRealizada
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
			this.ClientSize = new System.Drawing.Size(516, 228);
			this.Controls.Add(this.lblMensaje2);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.lblMensaje);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmCompraRealizada";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmCompraRealizada";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnOk;
		public System.Windows.Forms.Label lblMensaje;
		public System.Windows.Forms.Label lblMensaje2;
	}
}