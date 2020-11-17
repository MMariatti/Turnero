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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarPaciente));
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
      this.BtnGuardar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // TxtTelefono
      // 
      this.TxtTelefono.Location = new System.Drawing.Point(151, 252);
      this.TxtTelefono.Mask = "(999)000-0000";
      this.TxtTelefono.Name = "TxtTelefono";
      this.TxtTelefono.Size = new System.Drawing.Size(142, 20);
      this.TxtTelefono.TabIndex = 5;
      this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
      // 
      // TxtNombre
      // 
      this.TxtNombre.Location = new System.Drawing.Point(151, 120);
      this.TxtNombre.Name = "TxtNombre";
      this.TxtNombre.Size = new System.Drawing.Size(142, 20);
      this.TxtNombre.TabIndex = 2;
      this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
      // 
      // TxtDireccion
      // 
      this.TxtDireccion.Location = new System.Drawing.Point(151, 301);
      this.TxtDireccion.Name = "TxtDireccion";
      this.TxtDireccion.Size = new System.Drawing.Size(142, 20);
      this.TxtDireccion.TabIndex = 6;
      // 
      // TxtApellido
      // 
      this.TxtApellido.Location = new System.Drawing.Point(151, 80);
      this.TxtApellido.Name = "TxtApellido";
      this.TxtApellido.Size = new System.Drawing.Size(142, 20);
      this.TxtApellido.TabIndex = 1;
      this.TxtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellido_KeyPress);
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
      this.TxtDni.Location = new System.Drawing.Point(151, 39);
      this.TxtDni.Name = "TxtDni";
      this.TxtDni.Size = new System.Drawing.Size(142, 20);
      this.TxtDni.TabIndex = 0;
      this.TxtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDni_KeyPress);
      // 
      // TxtFechaNac
      // 
      this.TxtFechaNac.Location = new System.Drawing.Point(151, 158);
      this.TxtFechaNac.Mask = "00/00/0000";
      this.TxtFechaNac.Name = "TxtFechaNac";
      this.TxtFechaNac.Size = new System.Drawing.Size(142, 20);
      this.TxtFechaNac.TabIndex = 3;
      this.TxtFechaNac.ValidatingType = typeof(System.DateTime);
      this.TxtFechaNac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFechaNac_KeyPress);
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
      this.BtnSalir.Location = new System.Drawing.Point(218, 359);
      this.BtnSalir.Name = "BtnSalir";
      this.BtnSalir.Size = new System.Drawing.Size(75, 23);
      this.BtnSalir.TabIndex = 13;
      this.BtnSalir.Text = "Salir";
      this.BtnSalir.UseVisualStyleBackColor = true;
      this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
      // 
      // BtnGuardar
      // 
      this.BtnGuardar.Location = new System.Drawing.Point(27, 359);
      this.BtnGuardar.Name = "BtnGuardar";
      this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
      this.BtnGuardar.TabIndex = 7;
      this.BtnGuardar.Text = "Guardar";
      this.BtnGuardar.UseVisualStyleBackColor = true;
      this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
      // 
      // FrmModificarPaciente
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(321, 407);
      this.Controls.Add(this.BtnGuardar);
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
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmModificarPaciente";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Modificar Paciente";
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
    private System.Windows.Forms.Button BtnGuardar;
    protected internal System.Windows.Forms.MaskedTextBox TxtTelefono;
    protected internal System.Windows.Forms.TextBox TxtDireccion;
    protected internal System.Windows.Forms.ComboBox CmbObraSocial;
  }
}