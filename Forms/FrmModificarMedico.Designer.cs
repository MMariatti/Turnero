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
      this.BtnGuardar = new System.Windows.Forms.Button();
      this.TxtNombre = new System.Windows.Forms.TextBox();
      this.LblEspecialidad = new System.Windows.Forms.Label();
      this.LblApellido = new System.Windows.Forms.Label();
      this.TxtApellido = new System.Windows.Forms.TextBox();
      this.LblNuevoNombre = new System.Windows.Forms.Label();
      this.CmbEspecialidad = new System.Windows.Forms.ComboBox();
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
      this.TxtLegajo.Location = new System.Drawing.Point(117, 46);
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
      // BtnGuardar
      // 
      this.BtnGuardar.Location = new System.Drawing.Point(15, 220);
      this.BtnGuardar.Name = "BtnGuardar";
      this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
      this.BtnGuardar.TabIndex = 3;
      this.BtnGuardar.Text = "Guardar";
      this.BtnGuardar.UseVisualStyleBackColor = true;
      this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
      // 
      // TxtNombre
      // 
      this.TxtNombre.Location = new System.Drawing.Point(117, 120);
      this.TxtNombre.Name = "TxtNombre";
      this.TxtNombre.Size = new System.Drawing.Size(121, 20);
      this.TxtNombre.TabIndex = 1;
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
      // FrmModificarMedico
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(252, 290);
      this.Controls.Add(this.CmbEspecialidad);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.TxtLegajo);
      this.Controls.Add(this.BtnSalir);
      this.Controls.Add(this.BtnGuardar);
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
    private System.Windows.Forms.Button BtnGuardar;
    protected internal System.Windows.Forms.TextBox TxtNombre;
    private System.Windows.Forms.Label LblEspecialidad;
    private System.Windows.Forms.Label LblApellido;
    protected internal System.Windows.Forms.TextBox TxtApellido;
    private System.Windows.Forms.Label LblNuevoNombre;
    protected internal System.Windows.Forms.ComboBox CmbEspecialidad;
  }
}