namespace Turnero.Forms
{
  partial class FrmModificarNombreMedico
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
      this.LblNuevoNombre = new System.Windows.Forms.Label();
      this.LblApellido = new System.Windows.Forms.Label();
      this.LblEspecialidad = new System.Windows.Forms.Label();
      this.TxtApellido = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.TxtNvoNombre = new System.Windows.Forms.TextBox();
      this.BtnCambiarNombre = new System.Windows.Forms.Button();
      this.BtnSalir = new System.Windows.Forms.Button();
      this.TxtEspecialidad = new System.Windows.Forms.TextBox();
      this.TxtLegajo = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // LblNuevoNombre
      // 
      this.LblNuevoNombre.AutoSize = true;
      this.LblNuevoNombre.Location = new System.Drawing.Point(22, 74);
      this.LblNuevoNombre.Name = "LblNuevoNombre";
      this.LblNuevoNombre.Size = new System.Drawing.Size(83, 13);
      this.LblNuevoNombre.TabIndex = 3;
      this.LblNuevoNombre.Text = "Nuevo nombre :";
      // 
      // LblApellido
      // 
      this.LblApellido.AutoSize = true;
      this.LblApellido.Location = new System.Drawing.Point(22, 115);
      this.LblApellido.Name = "LblApellido";
      this.LblApellido.Size = new System.Drawing.Size(50, 13);
      this.LblApellido.TabIndex = 4;
      this.LblApellido.Text = "Apellido :";
      // 
      // LblEspecialidad
      // 
      this.LblEspecialidad.AutoSize = true;
      this.LblEspecialidad.Location = new System.Drawing.Point(22, 151);
      this.LblEspecialidad.Name = "LblEspecialidad";
      this.LblEspecialidad.Size = new System.Drawing.Size(73, 13);
      this.LblEspecialidad.TabIndex = 5;
      this.LblEspecialidad.Text = "Especialidad :";
      // 
      // TxtApellido
      // 
      this.TxtApellido.Enabled = false;
      this.TxtApellido.Location = new System.Drawing.Point(111, 108);
      this.TxtApellido.Name = "TxtApellido";
      this.TxtApellido.Size = new System.Drawing.Size(121, 20);
      this.TxtApellido.TabIndex = 2;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(-211, 24);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(35, 13);
      this.label6.TabIndex = 4;
      this.label6.Text = "label2";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(-211, 59);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(35, 13);
      this.label7.TabIndex = 5;
      this.label7.Text = "label3";
      // 
      // TxtNvoNombre
      // 
      this.TxtNvoNombre.Location = new System.Drawing.Point(111, 67);
      this.TxtNvoNombre.Name = "TxtNvoNombre";
      this.TxtNvoNombre.Size = new System.Drawing.Size(121, 20);
      this.TxtNvoNombre.TabIndex = 1;
      // 
      // BtnCambiarNombre
      // 
      this.BtnCambiarNombre.Location = new System.Drawing.Point(25, 208);
      this.BtnCambiarNombre.Name = "BtnCambiarNombre";
      this.BtnCambiarNombre.Size = new System.Drawing.Size(98, 23);
      this.BtnCambiarNombre.TabIndex = 4;
      this.BtnCambiarNombre.Text = "Cambiar Nombre";
      this.BtnCambiarNombre.UseVisualStyleBackColor = true;
      this.BtnCambiarNombre.Click += new System.EventHandler(this.BtnCambiarNombre_Click);
      // 
      // BtnSalir
      // 
      this.BtnSalir.Location = new System.Drawing.Point(157, 208);
      this.BtnSalir.Name = "BtnSalir";
      this.BtnSalir.Size = new System.Drawing.Size(75, 23);
      this.BtnSalir.TabIndex = 5;
      this.BtnSalir.Text = "Salir";
      this.BtnSalir.UseVisualStyleBackColor = true;
      this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
      // 
      // TxtEspecialidad
      // 
      this.TxtEspecialidad.Enabled = false;
      this.TxtEspecialidad.Location = new System.Drawing.Point(111, 148);
      this.TxtEspecialidad.Name = "TxtEspecialidad";
      this.TxtEspecialidad.Size = new System.Drawing.Size(121, 20);
      this.TxtEspecialidad.TabIndex = 3;
      // 
      // TxtLegajo
      // 
      this.TxtLegajo.Enabled = false;
      this.TxtLegajo.Location = new System.Drawing.Point(111, 32);
      this.TxtLegajo.Name = "TxtLegajo";
      this.TxtLegajo.Size = new System.Drawing.Size(121, 20);
      this.TxtLegajo.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(22, 35);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(45, 13);
      this.label1.TabIndex = 12;
      this.label1.Text = "Legajo :";
      // 
      // FrmModificarNombreMedico
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(272, 267);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.TxtLegajo);
      this.Controls.Add(this.TxtEspecialidad);
      this.Controls.Add(this.BtnSalir);
      this.Controls.Add(this.BtnCambiarNombre);
      this.Controls.Add(this.TxtNvoNombre);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.LblEspecialidad);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.LblApellido);
      this.Controls.Add(this.TxtApellido);
      this.Controls.Add(this.LblNuevoNombre);
      this.Name = "FrmModificarNombreMedico";
      this.Text = "FrmModificarNombreMedico";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmModificarNombreMedico_FormClosing);
      this.Load += new System.EventHandler(this.FrmModificarNombreMedico_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label LblNuevoNombre;
    private System.Windows.Forms.Label LblApellido;
    private System.Windows.Forms.Label LblEspecialidad;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button BtnCambiarNombre;
    private System.Windows.Forms.Button BtnSalir;
    protected internal System.Windows.Forms.TextBox TxtApellido;
    protected internal System.Windows.Forms.TextBox TxtNvoNombre;
    protected internal System.Windows.Forms.TextBox TxtEspecialidad;
    protected internal System.Windows.Forms.TextBox TxtLegajo;
    private System.Windows.Forms.Label label1;
  }
}