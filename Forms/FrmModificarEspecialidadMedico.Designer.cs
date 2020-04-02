namespace Turnero.Forms
{
  partial class FrmModificarEspecialidadMedico
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
      this.BtnCambiarEspecialidad = new System.Windows.Forms.Button();
      this.TxtNombre = new System.Windows.Forms.TextBox();
      this.LblEspecialidad = new System.Windows.Forms.Label();
      this.LblApellido = new System.Windows.Forms.Label();
      this.TxtApellido = new System.Windows.Forms.TextBox();
      this.LblNuevoNombre = new System.Windows.Forms.Label();
      this.CmbNvaEspecialidad = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(42, 59);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(45, 13);
      this.label1.TabIndex = 32;
      this.label1.Text = "Legajo :";
      // 
      // TxtLegajo
      // 
      this.TxtLegajo.Enabled = false;
      this.TxtLegajo.Location = new System.Drawing.Point(141, 56);
      this.TxtLegajo.Name = "TxtLegajo";
      this.TxtLegajo.Size = new System.Drawing.Size(121, 20);
      this.TxtLegajo.TabIndex = 0;
      // 
      // BtnSalir
      // 
      this.BtnSalir.Location = new System.Drawing.Point(187, 232);
      this.BtnSalir.Name = "BtnSalir";
      this.BtnSalir.Size = new System.Drawing.Size(75, 23);
      this.BtnSalir.TabIndex = 5;
      this.BtnSalir.Text = "Salir";
      this.BtnSalir.UseVisualStyleBackColor = true;
      this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
      // 
      // BtnCambiarEspecialidad
      // 
      this.BtnCambiarEspecialidad.Location = new System.Drawing.Point(45, 232);
      this.BtnCambiarEspecialidad.Name = "BtnCambiarEspecialidad";
      this.BtnCambiarEspecialidad.Size = new System.Drawing.Size(126, 23);
      this.BtnCambiarEspecialidad.TabIndex = 4;
      this.BtnCambiarEspecialidad.Text = "Cambiar Especialidad";
      this.BtnCambiarEspecialidad.UseVisualStyleBackColor = true;
      this.BtnCambiarEspecialidad.Click += new System.EventHandler(this.BtnCambiarEspecialidad_Click);
      // 
      // TxtNombre
      // 
      this.TxtNombre.Enabled = false;
      this.TxtNombre.Location = new System.Drawing.Point(141, 91);
      this.TxtNombre.Name = "TxtNombre";
      this.TxtNombre.Size = new System.Drawing.Size(121, 20);
      this.TxtNombre.TabIndex = 1;
      // 
      // LblEspecialidad
      // 
      this.LblEspecialidad.AutoSize = true;
      this.LblEspecialidad.Location = new System.Drawing.Point(42, 175);
      this.LblEspecialidad.Name = "LblEspecialidad";
      this.LblEspecialidad.Size = new System.Drawing.Size(73, 13);
      this.LblEspecialidad.TabIndex = 26;
      this.LblEspecialidad.Text = "Especialidad :";
      // 
      // LblApellido
      // 
      this.LblApellido.AutoSize = true;
      this.LblApellido.Location = new System.Drawing.Point(42, 139);
      this.LblApellido.Name = "LblApellido";
      this.LblApellido.Size = new System.Drawing.Size(47, 13);
      this.LblApellido.TabIndex = 25;
      this.LblApellido.Text = "Apellido:";
      // 
      // TxtApellido
      // 
      this.TxtApellido.Enabled = false;
      this.TxtApellido.Location = new System.Drawing.Point(141, 132);
      this.TxtApellido.Name = "TxtApellido";
      this.TxtApellido.Size = new System.Drawing.Size(121, 20);
      this.TxtApellido.TabIndex = 2;
      // 
      // LblNuevoNombre
      // 
      this.LblNuevoNombre.AutoSize = true;
      this.LblNuevoNombre.Location = new System.Drawing.Point(42, 98);
      this.LblNuevoNombre.Name = "LblNuevoNombre";
      this.LblNuevoNombre.Size = new System.Drawing.Size(47, 13);
      this.LblNuevoNombre.TabIndex = 24;
      this.LblNuevoNombre.Text = "Nombre:";
      // 
      // CmbNvaEspecialidad
      // 
      this.CmbNvaEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.CmbNvaEspecialidad.FormattingEnabled = true;
      this.CmbNvaEspecialidad.Location = new System.Drawing.Point(141, 175);
      this.CmbNvaEspecialidad.Name = "CmbNvaEspecialidad";
      this.CmbNvaEspecialidad.Size = new System.Drawing.Size(121, 21);
      this.CmbNvaEspecialidad.TabIndex = 3;
      // 
      // FrmModificarEspecialidadMedico
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(299, 297);
      this.Controls.Add(this.CmbNvaEspecialidad);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.TxtLegajo);
      this.Controls.Add(this.BtnSalir);
      this.Controls.Add(this.BtnCambiarEspecialidad);
      this.Controls.Add(this.TxtNombre);
      this.Controls.Add(this.LblEspecialidad);
      this.Controls.Add(this.LblApellido);
      this.Controls.Add(this.TxtApellido);
      this.Controls.Add(this.LblNuevoNombre);
      this.Name = "FrmModificarEspecialidadMedico";
      this.Text = "FrmModificarEspecialidadMedico";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmModificarEspecialidadMedico_FormClosing);
      this.Load += new System.EventHandler(this.FrmModificarEspecialidadMedico_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    protected internal System.Windows.Forms.TextBox TxtLegajo;
    private System.Windows.Forms.Button BtnSalir;
    private System.Windows.Forms.Button BtnCambiarEspecialidad;
    protected internal System.Windows.Forms.TextBox TxtNombre;
    private System.Windows.Forms.Label LblEspecialidad;
    private System.Windows.Forms.Label LblApellido;
    protected internal System.Windows.Forms.TextBox TxtApellido;
    private System.Windows.Forms.Label LblNuevoNombre;
    private System.Windows.Forms.ComboBox CmbNvaEspecialidad;
  }
}