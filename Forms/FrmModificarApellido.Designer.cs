namespace Turnero.Forms
{
  partial class FrmModificarApellido
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
      this.TxtEspecialidad = new System.Windows.Forms.TextBox();
      this.BtnSalir = new System.Windows.Forms.Button();
      this.BtnCambiarApellido = new System.Windows.Forms.Button();
      this.TxtNombre = new System.Windows.Forms.TextBox();
      this.LblEspecialidad = new System.Windows.Forms.Label();
      this.LblApellido = new System.Windows.Forms.Label();
      this.TxtNvoApellido = new System.Windows.Forms.TextBox();
      this.LblNuevoNombre = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(26, 47);
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
      // TxtEspecialidad
      // 
      this.TxtEspecialidad.Enabled = false;
      this.TxtEspecialidad.Location = new System.Drawing.Point(115, 160);
      this.TxtEspecialidad.Name = "TxtEspecialidad";
      this.TxtEspecialidad.Size = new System.Drawing.Size(121, 20);
      this.TxtEspecialidad.TabIndex = 3;
      // 
      // BtnSalir
      // 
      this.BtnSalir.Location = new System.Drawing.Point(161, 220);
      this.BtnSalir.Name = "BtnSalir";
      this.BtnSalir.Size = new System.Drawing.Size(75, 23);
      this.BtnSalir.TabIndex = 5;
      this.BtnSalir.Text = "Salir";
      this.BtnSalir.UseVisualStyleBackColor = true;
      this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
      // 
      // BtnCambiarApellido
      // 
      this.BtnCambiarApellido.Location = new System.Drawing.Point(29, 220);
      this.BtnCambiarApellido.Name = "BtnCambiarApellido";
      this.BtnCambiarApellido.Size = new System.Drawing.Size(98, 23);
      this.BtnCambiarApellido.TabIndex = 4;
      this.BtnCambiarApellido.Text = "Cambiar Apellido";
      this.BtnCambiarApellido.UseVisualStyleBackColor = true;
      this.BtnCambiarApellido.Click += new System.EventHandler(this.BtnCambiarApellido_Click);
      // 
      // TxtNombre
      // 
      this.TxtNombre.Enabled = false;
      this.TxtNombre.Location = new System.Drawing.Point(115, 79);
      this.TxtNombre.Name = "TxtNombre";
      this.TxtNombre.Size = new System.Drawing.Size(121, 20);
      this.TxtNombre.TabIndex = 1;
      // 
      // LblEspecialidad
      // 
      this.LblEspecialidad.AutoSize = true;
      this.LblEspecialidad.Location = new System.Drawing.Point(26, 163);
      this.LblEspecialidad.Name = "LblEspecialidad";
      this.LblEspecialidad.Size = new System.Drawing.Size(73, 13);
      this.LblEspecialidad.TabIndex = 16;
      this.LblEspecialidad.Text = "Especialidad :";
      // 
      // LblApellido
      // 
      this.LblApellido.AutoSize = true;
      this.LblApellido.Location = new System.Drawing.Point(26, 127);
      this.LblApellido.Name = "LblApellido";
      this.LblApellido.Size = new System.Drawing.Size(82, 13);
      this.LblApellido.TabIndex = 15;
      this.LblApellido.Text = "Nuevo Apellido:";
      // 
      // TxtNvoApellido
      // 
      this.TxtNvoApellido.Location = new System.Drawing.Point(115, 120);
      this.TxtNvoApellido.Name = "TxtNvoApellido";
      this.TxtNvoApellido.Size = new System.Drawing.Size(121, 20);
      this.TxtNvoApellido.TabIndex = 2;
      // 
      // LblNuevoNombre
      // 
      this.LblNuevoNombre.AutoSize = true;
      this.LblNuevoNombre.Location = new System.Drawing.Point(26, 86);
      this.LblNuevoNombre.Name = "LblNuevoNombre";
      this.LblNuevoNombre.Size = new System.Drawing.Size(47, 13);
      this.LblNuevoNombre.TabIndex = 14;
      this.LblNuevoNombre.Text = "Nombre:";
      // 
      // FrmModificarApellido
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(274, 290);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.TxtLegajo);
      this.Controls.Add(this.TxtEspecialidad);
      this.Controls.Add(this.BtnSalir);
      this.Controls.Add(this.BtnCambiarApellido);
      this.Controls.Add(this.TxtNombre);
      this.Controls.Add(this.LblEspecialidad);
      this.Controls.Add(this.LblApellido);
      this.Controls.Add(this.TxtNvoApellido);
      this.Controls.Add(this.LblNuevoNombre);
      this.Name = "FrmModificarApellido";
      this.Text = "FrmModificarApellido";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmModificarApellido_FormClosing);
      this.Load += new System.EventHandler(this.FrmModificarApellido_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    protected internal System.Windows.Forms.TextBox TxtLegajo;
    protected internal System.Windows.Forms.TextBox TxtEspecialidad;
    private System.Windows.Forms.Button BtnSalir;
    private System.Windows.Forms.Button BtnCambiarApellido;
    protected internal System.Windows.Forms.TextBox TxtNombre;
    private System.Windows.Forms.Label LblEspecialidad;
    private System.Windows.Forms.Label LblApellido;
    protected internal System.Windows.Forms.TextBox TxtNvoApellido;
    private System.Windows.Forms.Label LblNuevoNombre;
  }
}