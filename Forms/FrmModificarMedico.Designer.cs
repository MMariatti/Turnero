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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarMedico));
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
      this.TxtPorcentajeDescuento = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.TxtIntervaloTurnos = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.TxtHoraInicio = new System.Windows.Forms.MaskedTextBox();
      this.TxtHoraFin = new System.Windows.Forms.MaskedTextBox();
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
      this.TxtLegajo.Location = new System.Drawing.Point(142, 46);
      this.TxtLegajo.Name = "TxtLegajo";
      this.TxtLegajo.Size = new System.Drawing.Size(121, 20);
      this.TxtLegajo.TabIndex = 0;
      // 
      // BtnSalir
      // 
      this.BtnSalir.Location = new System.Drawing.Point(184, 345);
      this.BtnSalir.Name = "BtnSalir";
      this.BtnSalir.Size = new System.Drawing.Size(75, 23);
      this.BtnSalir.TabIndex = 9;
      this.BtnSalir.Text = "Salir";
      this.BtnSalir.UseVisualStyleBackColor = true;
      this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
      // 
      // BtnGuardar
      // 
      this.BtnGuardar.Location = new System.Drawing.Point(15, 345);
      this.BtnGuardar.Name = "BtnGuardar";
      this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
      this.BtnGuardar.TabIndex = 8;
      this.BtnGuardar.Text = "Guardar";
      this.BtnGuardar.UseVisualStyleBackColor = true;
      this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
      // 
      // TxtNombre
      // 
      this.TxtNombre.Location = new System.Drawing.Point(140, 120);
      this.TxtNombre.Name = "TxtNombre";
      this.TxtNombre.Size = new System.Drawing.Size(123, 20);
      this.TxtNombre.TabIndex = 2;
      this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
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
      this.TxtApellido.Location = new System.Drawing.Point(142, 83);
      this.TxtApellido.Name = "TxtApellido";
      this.TxtApellido.Size = new System.Drawing.Size(121, 20);
      this.TxtApellido.TabIndex = 1;
      this.TxtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellido_KeyPress);
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
      this.CmbEspecialidad.Location = new System.Drawing.Point(140, 156);
      this.CmbEspecialidad.Name = "CmbEspecialidad";
      this.CmbEspecialidad.Size = new System.Drawing.Size(121, 21);
      this.CmbEspecialidad.TabIndex = 3;
      // 
      // TxtPorcentajeDescuento
      // 
      this.TxtPorcentajeDescuento.Location = new System.Drawing.Point(138, 289);
      this.TxtPorcentajeDescuento.Name = "TxtPorcentajeDescuento";
      this.TxtPorcentajeDescuento.Size = new System.Drawing.Size(121, 20);
      this.TxtPorcentajeDescuento.TabIndex = 7;
      this.TxtPorcentajeDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPorcentajeDescuento_KeyPress);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(14, 292);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(119, 13);
      this.label2.TabIndex = 24;
      this.label2.Text = "Porcentaje Descuento :";
      // 
      // TxtIntervaloTurnos
      // 
      this.TxtIntervaloTurnos.Location = new System.Drawing.Point(140, 254);
      this.TxtIntervaloTurnos.Name = "TxtIntervaloTurnos";
      this.TxtIntervaloTurnos.Size = new System.Drawing.Size(121, 20);
      this.TxtIntervaloTurnos.TabIndex = 6;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 197);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(90, 13);
      this.label3.TabIndex = 26;
      this.label3.Text = "Horario de Inicio :";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(14, 228);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(117, 13);
      this.label4.TabIndex = 27;
      this.label4.Text = "Horario de finalización :";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(14, 257);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(113, 13);
      this.label5.TabIndex = 28;
      this.label5.Text = "Intervalo entre turnos :";
      // 
      // TxtHoraInicio
      // 
      this.TxtHoraInicio.Location = new System.Drawing.Point(140, 194);
      this.TxtHoraInicio.Mask = "00:00";
      this.TxtHoraInicio.Name = "TxtHoraInicio";
      this.TxtHoraInicio.Size = new System.Drawing.Size(46, 20);
      this.TxtHoraInicio.TabIndex = 4;
      this.TxtHoraInicio.ValidatingType = typeof(System.DateTime);
      this.TxtHoraInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHoraInicio_KeyPress);
      // 
      // TxtHoraFin
      // 
      this.TxtHoraFin.Location = new System.Drawing.Point(142, 225);
      this.TxtHoraFin.Mask = "00:00";
      this.TxtHoraFin.Name = "TxtHoraFin";
      this.TxtHoraFin.Size = new System.Drawing.Size(44, 20);
      this.TxtHoraFin.TabIndex = 5;
      this.TxtHoraFin.ValidatingType = typeof(System.DateTime);
      this.TxtHoraFin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHoraFin_KeyPress);
      // 
      // FrmModificarMedico
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(282, 393);
      this.Controls.Add(this.TxtHoraFin);
      this.Controls.Add(this.TxtHoraInicio);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.TxtIntervaloTurnos);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.TxtPorcentajeDescuento);
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
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmModificarMedico";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
    protected internal System.Windows.Forms.TextBox TxtPorcentajeDescuento;
    private System.Windows.Forms.Label label2;
    protected internal System.Windows.Forms.TextBox TxtIntervaloTurnos;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    protected internal System.Windows.Forms.MaskedTextBox TxtHoraInicio;
    protected internal System.Windows.Forms.MaskedTextBox TxtHoraFin;
  }
}