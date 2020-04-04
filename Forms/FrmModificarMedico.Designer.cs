namespace Turnero.Forms
{
  partial class FrmModificarMedico
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
      this.label1 = new System.Windows.Forms.Label();
      this.TxtLegajo = new System.Windows.Forms.TextBox();
      this.BtnSalir = new System.Windows.Forms.Button();
      this.BtnCambiarApellido = new System.Windows.Forms.Button();
      this.TxtNombre = new System.Windows.Forms.TextBox();
      this.LblEspecialidad = new System.Windows.Forms.Label();
      this.LblApellido = new System.Windows.Forms.Label();
      this.TxtApellido = new System.Windows.Forms.TextBox();
      this.LblNuevoNombre = new System.Windows.Forms.Label();
      this.CmbEspecialidad = new System.Windows.Forms.ComboBox();
      this.BtnCambiarNombre = new System.Windows.Forms.Button();
      this.BtnCambiarEspecialidad = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(14, 49);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(45, 13);
      this.label1.TabIndex = 22;
      this.label1.Text = "Legajo :";
      // 
      // TxtLegajo
      // 
      this.TxtLegajo.Enabled = false;
      this.TxtLegajo.Location = new System.Drawing.Point(115, 44);
      this.TxtLegajo.Name = "TxtLegajo";
      this.TxtLegajo.Size = new System.Drawing.Size(121, 20);
      this.TxtLegajo.TabIndex = 0;
      // 
      // BtnSalir
      // 
      this.BtnSalir.Location = new System.Drawing.Point(161, 220);
      this.BtnSalir.Name = "BtnSalir";
      this.BtnSalir.Size = new System.Drawing.Size(75, 23);
      this.BtnSalir.TabIndex = 7;
      this.BtnSalir.Text = "Salir";
      this.BtnSalir.UseVisualStyleBackColor = true;
      this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
      // 
      // BtnCambiarApellido
      // 
      this.BtnCambiarApellido.Location = new System.Drawing.Point(279, 76);
      this.BtnCambiarApellido.Name = "BtnCambiarApellido";
      this.BtnCambiarApellido.Size = new System.Drawing.Size(98, 23);
      this.BtnCambiarApellido.TabIndex = 3;
      this.BtnCambiarApellido.Text = "Cambiar Apellido";
      this.BtnCambiarApellido.UseVisualStyleBackColor = true;
      this.BtnCambiarApellido.Click += new System.EventHandler(this.BtnCambiarApellido_Click);
      // 
      // TxtNombre
      // 
      this.TxtNombre.Location = new System.Drawing.Point(117, 120);
      this.TxtNombre.Name = "TxtNombre";
      this.TxtNombre.Size = new System.Drawing.Size(121, 20);
      this.TxtNombre.TabIndex = 1;
      this.TxtNombre.Click += new System.EventHandler(this.TxtNombre_Click);
      this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
      // 
      // LblEspecialidad
      // 
      this.LblEspecialidad.AutoSize = true;
      this.LblEspecialidad.Location = new System.Drawing.Point(12, 159);
      this.LblEspecialidad.Name = "LblEspecialidad";
      this.LblEspecialidad.Size = new System.Drawing.Size(73, 13);
      this.LblEspecialidad.TabIndex = 16;
      this.LblEspecialidad.Text = "Especialidad :";
      // 
      // LblApellido
      // 
      this.LblApellido.AutoSize = true;
      this.LblApellido.Location = new System.Drawing.Point(14, 86);
      this.LblApellido.Name = "LblApellido";
      this.LblApellido.Size = new System.Drawing.Size(47, 13);
      this.LblApellido.TabIndex = 15;
      this.LblApellido.Text = "Apellido:";
      // 
      // TxtApellido
      // 
      this.TxtApellido.Location = new System.Drawing.Point(117, 83);
      this.TxtApellido.Name = "TxtApellido";
      this.TxtApellido.Size = new System.Drawing.Size(121, 20);
      this.TxtApellido.TabIndex = 0;
      this.TxtApellido.Click += new System.EventHandler(this.TxtApellido_Click);
      // 
      // LblNuevoNombre
      // 
      this.LblNuevoNombre.AutoSize = true;
      this.LblNuevoNombre.Location = new System.Drawing.Point(14, 123);
      this.LblNuevoNombre.Name = "LblNuevoNombre";
      this.LblNuevoNombre.Size = new System.Drawing.Size(47, 13);
      this.LblNuevoNombre.TabIndex = 14;
      this.LblNuevoNombre.Text = "Nombre:";
      // 
      // CmbEspecialidad
      // 
      this.CmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.CmbEspecialidad.FormattingEnabled = true;
      this.CmbEspecialidad.Location = new System.Drawing.Point(115, 156);
      this.CmbEspecialidad.Name = "CmbEspecialidad";
      this.CmbEspecialidad.Size = new System.Drawing.Size(121, 21);
      this.CmbEspecialidad.TabIndex = 2;
      // 
      // BtnCambiarNombre
      // 
      this.BtnCambiarNombre.Location = new System.Drawing.Point(279, 113);
      this.BtnCambiarNombre.Name = "BtnCambiarNombre";
      this.BtnCambiarNombre.Size = new System.Drawing.Size(98, 23);
      this.BtnCambiarNombre.TabIndex = 4;
      this.BtnCambiarNombre.Text = "Cambiar Nombre";
      this.BtnCambiarNombre.UseVisualStyleBackColor = true;
      this.BtnCambiarNombre.Click += new System.EventHandler(this.BtnCambiarNombre_Click);
      // 
      // BtnCambiarEspecialidad
      // 
      this.BtnCambiarEspecialidad.Location = new System.Drawing.Point(277, 156);
      this.BtnCambiarEspecialidad.Name = "BtnCambiarEspecialidad";
      this.BtnCambiarEspecialidad.Size = new System.Drawing.Size(98, 34);
      this.BtnCambiarEspecialidad.TabIndex = 6;
      this.BtnCambiarEspecialidad.Text = "Cambiar Especialidad";
      this.BtnCambiarEspecialidad.UseVisualStyleBackColor = true;
      this.BtnCambiarEspecialidad.Click += new System.EventHandler(this.BtnCambiarEspecialidad_Click);
      // 
      // FrmModificarMedico
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(387, 290);
      this.Controls.Add(this.BtnCambiarEspecialidad);
      this.Controls.Add(this.BtnCambiarNombre);
      this.Controls.Add(this.CmbEspecialidad);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.TxtLegajo);
      this.Controls.Add(this.BtnSalir);
      this.Controls.Add(this.BtnCambiarApellido);
      this.Controls.Add(this.TxtNombre);
      this.Controls.Add(this.LblEspecialidad);
      this.Controls.Add(this.LblApellido);
      this.Controls.Add(this.TxtApellido);
      this.Controls.Add(this.LblNuevoNombre);
      this.Name = "FrmModificarMedico";
      this.Text = "Modificar datos del medico";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmModificarApellido_FormClosing);
      this.Load += new System.EventHandler(this.FrmModificarApellido_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    protected internal System.Windows.Forms.TextBox TxtLegajo;
    private System.Windows.Forms.Button BtnSalir;
    private System.Windows.Forms.Button BtnCambiarApellido;
    protected internal System.Windows.Forms.TextBox TxtNombre;
    private System.Windows.Forms.Label LblEspecialidad;
    private System.Windows.Forms.Label LblApellido;
    protected internal System.Windows.Forms.TextBox TxtApellido;
    private System.Windows.Forms.Label LblNuevoNombre;
    protected internal System.Windows.Forms.ComboBox CmbEspecialidad;
    private System.Windows.Forms.Button BtnCambiarNombre;
    private System.Windows.Forms.Button BtnCambiarEspecialidad;
  }
}