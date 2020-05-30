namespace Turnero.Forms
{
  partial class FrmLogin
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
      this.BtnInciarSesion = new System.Windows.Forms.Button();
      this.Usuario = new System.Windows.Forms.Label();
      this.TxtContra = new System.Windows.Forms.TextBox();
      this.Contraseña = new System.Windows.Forms.Label();
      this.BtnSalir = new System.Windows.Forms.Button();
      this.TxtUsuario = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // BtnInciarSesion
      // 
      this.BtnInciarSesion.Location = new System.Drawing.Point(42, 222);
      this.BtnInciarSesion.Name = "BtnInciarSesion";
      this.BtnInciarSesion.Size = new System.Drawing.Size(86, 23);
      this.BtnInciarSesion.TabIndex = 2;
      this.BtnInciarSesion.Text = "Iniciar Sesion";
      this.BtnInciarSesion.UseVisualStyleBackColor = true;
      this.BtnInciarSesion.Click += new System.EventHandler(this.BtnInciarSesion_Click);
      // 
      // Usuario
      // 
      this.Usuario.AutoSize = true;
      this.Usuario.Location = new System.Drawing.Point(39, 91);
      this.Usuario.Name = "Usuario";
      this.Usuario.Size = new System.Drawing.Size(43, 13);
      this.Usuario.TabIndex = 0;
      this.Usuario.Text = "Usuario";
      // 
      // TxtContra
      // 
      this.TxtContra.Location = new System.Drawing.Point(165, 164);
      this.TxtContra.Name = "TxtContra";
      this.TxtContra.PasswordChar = '*';
      this.TxtContra.Size = new System.Drawing.Size(100, 20);
      this.TxtContra.TabIndex = 1;
      this.TxtContra.UseSystemPasswordChar = true;
      // 
      // Contraseña
      // 
      this.Contraseña.AutoSize = true;
      this.Contraseña.Location = new System.Drawing.Point(39, 164);
      this.Contraseña.Name = "Contraseña";
      this.Contraseña.Size = new System.Drawing.Size(61, 13);
      this.Contraseña.TabIndex = 0;
      this.Contraseña.Text = "Contraseña";
      // 
      // BtnSalir
      // 
      this.BtnSalir.Location = new System.Drawing.Point(179, 222);
      this.BtnSalir.Name = "BtnSalir";
      this.BtnSalir.Size = new System.Drawing.Size(86, 23);
      this.BtnSalir.TabIndex = 3;
      this.BtnSalir.Text = "Salir";
      this.BtnSalir.UseVisualStyleBackColor = true;
      this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
      // 
      // TxtUsuario
      // 
      this.TxtUsuario.Location = new System.Drawing.Point(165, 91);
      this.TxtUsuario.Name = "TxtUsuario";
      this.TxtUsuario.Size = new System.Drawing.Size(100, 20);
      this.TxtUsuario.TabIndex = 0;
      // 
      // FrmLogin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(312, 271);
      this.Controls.Add(this.TxtUsuario);
      this.Controls.Add(this.BtnSalir);
      this.Controls.Add(this.Contraseña);
      this.Controls.Add(this.TxtContra);
      this.Controls.Add(this.Usuario);
      this.Controls.Add(this.BtnInciarSesion);
      this.Name = "FrmLogin";
      this.Text = "FrmLogin";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
      this.Load += new System.EventHandler(this.FrmLogin_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button BtnInciarSesion;
    private System.Windows.Forms.Label Usuario;
    private System.Windows.Forms.TextBox TxtContra;
    private System.Windows.Forms.Label Contraseña;
    private System.Windows.Forms.Button BtnSalir;
    private System.Windows.Forms.TextBox TxtUsuario;
  }
}