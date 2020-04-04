namespace Turnero.Forms
{
  partial class FrmAgregarPaciente
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
      this.BtnAgregarPaciente = new System.Windows.Forms.Button();
      this.BtnSalir = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.CmbObraSocial = new System.Windows.Forms.ComboBox();
      this.TxtFechaNac = new System.Windows.Forms.MaskedTextBox();
      this.TxtDni = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.TxtApellido = new System.Windows.Forms.TextBox();
      this.TxtDireccion = new System.Windows.Forms.TextBox();
      this.TxtNombre = new System.Windows.Forms.TextBox();
      this.TxtTelefono = new System.Windows.Forms.MaskedTextBox();
      this.SuspendLayout();
      // 
      // BtnAgregarPaciente
      // 
      this.BtnAgregarPaciente.Location = new System.Drawing.Point(43, 331);
      this.BtnAgregarPaciente.Name = "BtnAgregarPaciente";
      this.BtnAgregarPaciente.Size = new System.Drawing.Size(112, 23);
      this.BtnAgregarPaciente.TabIndex = 7;
      this.BtnAgregarPaciente.Text = "Agregar paciente";
      this.BtnAgregarPaciente.UseVisualStyleBackColor = true;
      this.BtnAgregarPaciente.Click += new System.EventHandler(this.BtnAgregarPaciente_Click);
      // 
      // BtnSalir
      // 
      this.BtnSalir.Location = new System.Drawing.Point(234, 331);
      this.BtnSalir.Name = "BtnSalir";
      this.BtnSalir.Size = new System.Drawing.Size(75, 23);
      this.BtnSalir.TabIndex = 8;
      this.BtnSalir.Text = "Salir";
      this.BtnSalir.UseVisualStyleBackColor = true;
      this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(40, 31);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(121, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Numero de documento :";
      // 
      // CmbObraSocial
      // 
      this.CmbObraSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.CmbObraSocial.FormattingEnabled = true;
      this.CmbObraSocial.Location = new System.Drawing.Point(167, 182);
      this.CmbObraSocial.Name = "CmbObraSocial";
      this.CmbObraSocial.Size = new System.Drawing.Size(142, 21);
      this.CmbObraSocial.TabIndex = 4;
      // 
      // TxtFechaNac
      // 
      this.TxtFechaNac.Location = new System.Drawing.Point(167, 143);
      this.TxtFechaNac.Mask = "00/00/0000";
      this.TxtFechaNac.Name = "TxtFechaNac";
      this.TxtFechaNac.Size = new System.Drawing.Size(142, 20);
      this.TxtFechaNac.TabIndex = 3;
      this.TxtFechaNac.ValidatingType = typeof(System.DateTime);
      // 
      // TxtDni
      // 
      this.TxtDni.Location = new System.Drawing.Point(167, 24);
      this.TxtDni.Name = "TxtDni";
      this.TxtDni.Size = new System.Drawing.Size(142, 20);
      this.TxtDni.TabIndex = 0;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(40, 72);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Apellido :";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(40, 146);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(115, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Fecha de nacimiento : ";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(40, 112);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(50, 13);
      this.label4.TabIndex = 8;
      this.label4.Text = "Nombre :";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(40, 190);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(66, 13);
      this.label5.TabIndex = 9;
      this.label5.Text = "Obra social :";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(40, 232);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(58, 13);
      this.label6.TabIndex = 10;
      this.label6.Text = "Telefono : ";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(40, 274);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(58, 13);
      this.label7.TabIndex = 11;
      this.label7.Text = "Dirección :";
      // 
      // TxtApellido
      // 
      this.TxtApellido.Location = new System.Drawing.Point(167, 65);
      this.TxtApellido.Name = "TxtApellido";
      this.TxtApellido.Size = new System.Drawing.Size(142, 20);
      this.TxtApellido.TabIndex = 1;
      // 
      // TxtDireccion
      // 
      this.TxtDireccion.Location = new System.Drawing.Point(167, 267);
      this.TxtDireccion.Name = "TxtDireccion";
      this.TxtDireccion.Size = new System.Drawing.Size(142, 20);
      this.TxtDireccion.TabIndex = 6;
      // 
      // TxtNombre
      // 
      this.TxtNombre.Location = new System.Drawing.Point(167, 105);
      this.TxtNombre.Name = "TxtNombre";
      this.TxtNombre.Size = new System.Drawing.Size(142, 20);
      this.TxtNombre.TabIndex = 2;
      // 
      // TxtTelefono
      // 
      this.TxtTelefono.Location = new System.Drawing.Point(167, 225);
      this.TxtTelefono.Mask = "(999)000-0000";
      this.TxtTelefono.Name = "TxtTelefono";
      this.TxtTelefono.Size = new System.Drawing.Size(142, 20);
      this.TxtTelefono.TabIndex = 5;
      // 
      // FrmAgregarPaciente
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(358, 363);
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
      this.Controls.Add(this.BtnAgregarPaciente);
      this.Name = "FrmAgregarPaciente";
      this.Text = "FrmAgregarPaciente";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAgregarPaciente_FormClosing);
      this.Load += new System.EventHandler(this.FrmAgregarPaciente_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button BtnAgregarPaciente;
    private System.Windows.Forms.Button BtnSalir;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox CmbObraSocial;
    private System.Windows.Forms.MaskedTextBox TxtFechaNac;
    private System.Windows.Forms.TextBox TxtDni;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox TxtApellido;
    private System.Windows.Forms.TextBox TxtDireccion;
    private System.Windows.Forms.TextBox TxtNombre;
    private System.Windows.Forms.MaskedTextBox TxtTelefono;
  }
}