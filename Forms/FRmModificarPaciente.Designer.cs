namespace Turnero.Forms
{
  partial class FrmModificarPaciente
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
      this.TxtTelefono = new System.Windows.Forms.MaskedTextBox();
      this.TxtNombre = new System.Windows.Forms.TextBox();
      this.TxtDireccion = new System.Windows.Forms.TextBox();
      this.TxtApellido = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.TxtDni = new System.Windows.Forms.TextBox();
      this.TxtFechaNac = new System.Windows.Forms.MaskedTextBox();
      this.CmbObraSocial = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.BtnSalir = new System.Windows.Forms.Button();
      this.BtnCambiarApellido = new System.Windows.Forms.Button();
      this.BtnCambiarNombre = new System.Windows.Forms.Button();
      this.BtnCambiarObraSocial = new System.Windows.Forms.Button();
      this.BtnCambiarTelefono = new System.Windows.Forms.Button();
      this.BtnCambiarDireccion = new System.Windows.Forms.Button();
      this.BtnCambiarFechaNac = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // TxtTelefono
      // 
      this.TxtTelefono.Location = new System.Drawing.Point(151, 252);
      this.TxtTelefono.Mask = "(999)000-0000";
      this.TxtTelefono.Name = "TxtTelefono";
      this.TxtTelefono.Size = new System.Drawing.Size(142, 20);
      this.TxtTelefono.TabIndex = 5;
      this.TxtTelefono.Click += new System.EventHandler(this.TxtTelefono_Click);
      // 
      // TxtNombre
      // 
      this.TxtNombre.Location = new System.Drawing.Point(151, 120);
      this.TxtNombre.Name = "TxtNombre";
      this.TxtNombre.Size = new System.Drawing.Size(142, 20);
      this.TxtNombre.TabIndex = 2;
      this.TxtNombre.Click += new System.EventHandler(this.TxtNombre_Click);
      // 
      // TxtDireccion
      // 
      this.TxtDireccion.Location = new System.Drawing.Point(151, 301);
      this.TxtDireccion.Name = "TxtDireccion";
      this.TxtDireccion.Size = new System.Drawing.Size(142, 20);
      this.TxtDireccion.TabIndex = 6;
      this.TxtDireccion.Click += new System.EventHandler(this.TxtDireccion_Click);
      // 
      // TxtApellido
      // 
      this.TxtApellido.Location = new System.Drawing.Point(151, 80);
      this.TxtApellido.Name = "TxtApellido";
      this.TxtApellido.Size = new System.Drawing.Size(142, 20);
      this.TxtApellido.TabIndex = 1;
      this.TxtApellido.Click += new System.EventHandler(this.TxtApellido_Click);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(24, 301);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(58, 13);
      this.label7.TabIndex = 27;
      this.label7.Text = "Dirección :";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(24, 259);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(58, 13);
      this.label6.TabIndex = 26;
      this.label6.Text = "Telefono : ";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(24, 217);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(66, 13);
      this.label5.TabIndex = 25;
      this.label5.Text = "Obra social :";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(24, 127);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(50, 13);
      this.label4.TabIndex = 23;
      this.label4.Text = "Nombre :";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(24, 161);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(115, 13);
      this.label3.TabIndex = 21;
      this.label3.Text = "Fecha de nacimiento : ";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(24, 87);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 13);
      this.label2.TabIndex = 20;
      this.label2.Text = "Apellido :";
      // 
      // TxtDni
      // 
      this.TxtDni.Enabled = false;
      this.TxtDni.Location = new System.Drawing.Point(151, 39);
      this.TxtDni.Name = "TxtDni";
      this.TxtDni.Size = new System.Drawing.Size(142, 20);
      this.TxtDni.TabIndex = 0;
      // 
      // TxtFechaNac
      // 
      this.TxtFechaNac.Location = new System.Drawing.Point(151, 158);
      this.TxtFechaNac.Mask = "00/00/0000";
      this.TxtFechaNac.Name = "TxtFechaNac";
      this.TxtFechaNac.Size = new System.Drawing.Size(142, 20);
      this.TxtFechaNac.TabIndex = 3;
      this.TxtFechaNac.ValidatingType = typeof(System.DateTime);
      this.TxtFechaNac.Click += new System.EventHandler(this.TxtFechaNac_Click);
      // 
      // CmbObraSocial
      // 
      this.CmbObraSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.CmbObraSocial.FormattingEnabled = true;
      this.CmbObraSocial.Location = new System.Drawing.Point(151, 209);
      this.CmbObraSocial.Name = "CmbObraSocial";
      this.CmbObraSocial.Size = new System.Drawing.Size(142, 21);
      this.CmbObraSocial.TabIndex = 4;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(24, 46);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(121, 13);
      this.label1.TabIndex = 15;
      this.label1.Text = "Numero de documento :";
      // 
      // BtnSalir
      // 
      this.BtnSalir.Location = new System.Drawing.Point(409, 372);
      this.BtnSalir.Name = "BtnSalir";
      this.BtnSalir.Size = new System.Drawing.Size(75, 23);
      this.BtnSalir.TabIndex = 13;
      this.BtnSalir.Text = "Salir";
      this.BtnSalir.UseVisualStyleBackColor = true;
      this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
      // 
      // BtnCambiarApellido
      // 
      this.BtnCambiarApellido.Location = new System.Drawing.Point(372, 78);
      this.BtnCambiarApellido.Name = "BtnCambiarApellido";
      this.BtnCambiarApellido.Size = new System.Drawing.Size(112, 23);
      this.BtnCambiarApellido.TabIndex = 7;
      this.BtnCambiarApellido.Text = "Cambiar Apellido";
      this.BtnCambiarApellido.UseVisualStyleBackColor = true;
      this.BtnCambiarApellido.Click += new System.EventHandler(this.BtnCambiarApellido_Click);
      // 
      // BtnCambiarNombre
      // 
      this.BtnCambiarNombre.Location = new System.Drawing.Point(372, 117);
      this.BtnCambiarNombre.Name = "BtnCambiarNombre";
      this.BtnCambiarNombre.Size = new System.Drawing.Size(112, 23);
      this.BtnCambiarNombre.TabIndex = 8;
      this.BtnCambiarNombre.Text = "Cambiar nombre";
      this.BtnCambiarNombre.UseVisualStyleBackColor = true;
      this.BtnCambiarNombre.Click += new System.EventHandler(this.BtnCambiarNombre_Click);
      // 
      // BtnCambiarObraSocial
      // 
      this.BtnCambiarObraSocial.Location = new System.Drawing.Point(372, 207);
      this.BtnCambiarObraSocial.Name = "BtnCambiarObraSocial";
      this.BtnCambiarObraSocial.Size = new System.Drawing.Size(112, 23);
      this.BtnCambiarObraSocial.TabIndex = 10;
      this.BtnCambiarObraSocial.Text = "Cambiar obra social";
      this.BtnCambiarObraSocial.UseVisualStyleBackColor = true;
      this.BtnCambiarObraSocial.Click += new System.EventHandler(this.BtnCambiarObraSocial_Click);
      // 
      // BtnCambiarTelefono
      // 
      this.BtnCambiarTelefono.Location = new System.Drawing.Point(372, 249);
      this.BtnCambiarTelefono.Name = "BtnCambiarTelefono";
      this.BtnCambiarTelefono.Size = new System.Drawing.Size(112, 23);
      this.BtnCambiarTelefono.TabIndex = 11;
      this.BtnCambiarTelefono.Text = "Cambiar Telefono";
      this.BtnCambiarTelefono.UseVisualStyleBackColor = true;
      this.BtnCambiarTelefono.Click += new System.EventHandler(this.BtnCambiarTelefono_Click);
      // 
      // BtnCambiarDireccion
      // 
      this.BtnCambiarDireccion.Location = new System.Drawing.Point(372, 296);
      this.BtnCambiarDireccion.Name = "BtnCambiarDireccion";
      this.BtnCambiarDireccion.Size = new System.Drawing.Size(112, 23);
      this.BtnCambiarDireccion.TabIndex = 12;
      this.BtnCambiarDireccion.Text = "Cambiar Direccion";
      this.BtnCambiarDireccion.UseVisualStyleBackColor = true;
      this.BtnCambiarDireccion.Click += new System.EventHandler(this.BtnCambiarDireccion_Click);
      // 
      // BtnCambiarFechaNac
      // 
      this.BtnCambiarFechaNac.Location = new System.Drawing.Point(372, 155);
      this.BtnCambiarFechaNac.Name = "BtnCambiarFechaNac";
      this.BtnCambiarFechaNac.Size = new System.Drawing.Size(112, 34);
      this.BtnCambiarFechaNac.TabIndex = 9;
      this.BtnCambiarFechaNac.Text = "Cambiar fecha de nacimiento";
      this.BtnCambiarFechaNac.UseVisualStyleBackColor = true;
      this.BtnCambiarFechaNac.Click += new System.EventHandler(this.BtnCambiarFechaNac_Click);
      // 
      // FrmModificarPaciente
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(496, 437);
      this.Controls.Add(this.BtnCambiarFechaNac);
      this.Controls.Add(this.BtnCambiarDireccion);
      this.Controls.Add(this.BtnCambiarTelefono);
      this.Controls.Add(this.BtnCambiarObraSocial);
      this.Controls.Add(this.BtnCambiarNombre);
      this.Controls.Add(this.BtnCambiarApellido);
      this.Controls.Add(this.TxtTelefono);
      this.Controls.Add(this.TxtNombre);
      this.Controls.Add(this.TxtDireccion);
      this.Controls.Add(this.TxtApellido);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.TxtDni);
      this.Controls.Add(this.TxtFechaNac);
      this.Controls.Add(this.CmbObraSocial);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.BtnSalir);
      this.Name = "FrmModificarPaciente";
      this.Text = "FrmNombrePaciente";
      this.Load += new System.EventHandler(this.FrmModificarPaciente_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button BtnSalir;
    protected internal System.Windows.Forms.TextBox TxtNombre;
    protected internal System.Windows.Forms.TextBox TxtApellido;
    protected internal System.Windows.Forms.TextBox TxtDni;
    protected internal System.Windows.Forms.MaskedTextBox TxtFechaNac;
    private System.Windows.Forms.Button BtnCambiarApellido;
    private System.Windows.Forms.Button BtnCambiarNombre;
    private System.Windows.Forms.Button BtnCambiarObraSocial;
    private System.Windows.Forms.Button BtnCambiarTelefono;
    private System.Windows.Forms.Button BtnCambiarDireccion;
    protected internal System.Windows.Forms.MaskedTextBox TxtTelefono;
    protected internal System.Windows.Forms.TextBox TxtDireccion;
    protected internal System.Windows.Forms.ComboBox CmbObraSocial;
    private System.Windows.Forms.Button BtnCambiarFechaNac;
  }
}