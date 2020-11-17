namespace Turnero.Forms
{
  partial class FrmAgregarMedico
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarMedico));
      this.BtnAgregar = new System.Windows.Forms.Button();
      this.LblApellido = new System.Windows.Forms.Label();
      this.TxtNombre = new System.Windows.Forms.TextBox();
      this.CmbEspecialidades = new System.Windows.Forms.ComboBox();
      this.LblNombre = new System.Windows.Forms.Label();
      this.LblEspecialidad = new System.Windows.Forms.Label();
      this.TxtApellido = new System.Windows.Forms.TextBox();
      this.BtnCancelar = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.TxtPorcentajeDescuento = new System.Windows.Forms.TextBox();
      this.TxtHoraInicio = new System.Windows.Forms.MaskedTextBox();
      this.TxtHoraFin = new System.Windows.Forms.MaskedTextBox();
      this.TxtIntervaloTurnos = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // BtnAgregar
      // 
      this.BtnAgregar.Location = new System.Drawing.Point(28, 366);
      this.BtnAgregar.Name = "BtnAgregar";
      this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
      this.BtnAgregar.TabIndex = 7;
      this.BtnAgregar.Text = "Agregar";
      this.BtnAgregar.UseVisualStyleBackColor = true;
      this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
      // 
      // LblApellido
      // 
      this.LblApellido.AutoSize = true;
      this.LblApellido.Location = new System.Drawing.Point(25, 44);
      this.LblApellido.Name = "LblApellido";
      this.LblApellido.Size = new System.Drawing.Size(50, 13);
      this.LblApellido.TabIndex = 1;
      this.LblApellido.Text = "Apellido :";
      // 
      // TxtNombre
      // 
      this.TxtNombre.Location = new System.Drawing.Point(148, 87);
      this.TxtNombre.Name = "TxtNombre";
      this.TxtNombre.Size = new System.Drawing.Size(137, 20);
      this.TxtNombre.TabIndex = 1;
      this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
      // 
      // CmbEspecialidades
      // 
      this.CmbEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.CmbEspecialidades.FormattingEnabled = true;
      this.CmbEspecialidades.Location = new System.Drawing.Point(148, 135);
      this.CmbEspecialidades.Name = "CmbEspecialidades";
      this.CmbEspecialidades.Size = new System.Drawing.Size(137, 21);
      this.CmbEspecialidades.TabIndex = 2;
      // 
      // LblNombre
      // 
      this.LblNombre.AutoSize = true;
      this.LblNombre.Location = new System.Drawing.Point(25, 90);
      this.LblNombre.Name = "LblNombre";
      this.LblNombre.Size = new System.Drawing.Size(50, 13);
      this.LblNombre.TabIndex = 4;
      this.LblNombre.Text = "Nombre :";
      // 
      // LblEspecialidad
      // 
      this.LblEspecialidad.AutoSize = true;
      this.LblEspecialidad.Location = new System.Drawing.Point(25, 138);
      this.LblEspecialidad.Name = "LblEspecialidad";
      this.LblEspecialidad.Size = new System.Drawing.Size(73, 13);
      this.LblEspecialidad.TabIndex = 5;
      this.LblEspecialidad.Text = "Especialidad :";
      // 
      // TxtApellido
      // 
      this.TxtApellido.Location = new System.Drawing.Point(148, 41);
      this.TxtApellido.Name = "TxtApellido";
      this.TxtApellido.Size = new System.Drawing.Size(137, 20);
      this.TxtApellido.TabIndex = 0;
      this.TxtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellido_KeyPress);
      // 
      // BtnCancelar
      // 
      this.BtnCancelar.Location = new System.Drawing.Point(210, 366);
      this.BtnCancelar.Name = "BtnCancelar";
      this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
      this.BtnCancelar.TabIndex = 8;
      this.BtnCancelar.Text = "Cancelar";
      this.BtnCancelar.UseVisualStyleBackColor = true;
      this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(25, 323);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(119, 13);
      this.label1.TabIndex = 7;
      this.label1.Text = "Porcentaje Descuento :";
      // 
      // TxtPorcentajeDescuento
      // 
      this.TxtPorcentajeDescuento.Location = new System.Drawing.Point(148, 320);
      this.TxtPorcentajeDescuento.Name = "TxtPorcentajeDescuento";
      this.TxtPorcentajeDescuento.Size = new System.Drawing.Size(137, 20);
      this.TxtPorcentajeDescuento.TabIndex = 6;
      this.TxtPorcentajeDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPorcentajeDescuento_KeyPress);
      // 
      // TxtHoraInicio
      // 
      this.TxtHoraInicio.Location = new System.Drawing.Point(148, 186);
      this.TxtHoraInicio.Mask = "00:00";
      this.TxtHoraInicio.Name = "TxtHoraInicio";
      this.TxtHoraInicio.Size = new System.Drawing.Size(44, 20);
      this.TxtHoraInicio.TabIndex = 3;
      this.TxtHoraInicio.ValidatingType = typeof(System.DateTime);
      this.TxtHoraInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHoraInicio_KeyPress);
      // 
      // TxtHoraFin
      // 
      this.TxtHoraFin.Location = new System.Drawing.Point(148, 227);
      this.TxtHoraFin.Mask = "00:00";
      this.TxtHoraFin.Name = "TxtHoraFin";
      this.TxtHoraFin.Size = new System.Drawing.Size(44, 20);
      this.TxtHoraFin.TabIndex = 4;
      this.TxtHoraFin.ValidatingType = typeof(System.DateTime);
      this.TxtHoraFin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHoraFin_KeyPress);
      // 
      // TxtIntervaloTurnos
      // 
      this.TxtIntervaloTurnos.Location = new System.Drawing.Point(148, 274);
      this.TxtIntervaloTurnos.Name = "TxtIntervaloTurnos";
      this.TxtIntervaloTurnos.Size = new System.Drawing.Size(137, 20);
      this.TxtIntervaloTurnos.TabIndex = 5;
      this.TxtIntervaloTurnos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIntervaloTurnos_KeyPress);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(25, 189);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(90, 13);
      this.label2.TabIndex = 11;
      this.label2.Text = "Horario de Inicio :";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(25, 230);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(120, 13);
      this.label3.TabIndex = 12;
      this.label3.Text = "Horario de Finalización :";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(25, 277);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(117, 13);
      this.label4.TabIndex = 13;
      this.label4.Text = "Intervalo entre Turnos :";
      // 
      // FrmAgregarMedico
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(341, 403);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.TxtIntervaloTurnos);
      this.Controls.Add(this.TxtHoraFin);
      this.Controls.Add(this.TxtHoraInicio);
      this.Controls.Add(this.TxtPorcentajeDescuento);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.BtnCancelar);
      this.Controls.Add(this.TxtApellido);
      this.Controls.Add(this.LblEspecialidad);
      this.Controls.Add(this.LblNombre);
      this.Controls.Add(this.CmbEspecialidades);
      this.Controls.Add(this.TxtNombre);
      this.Controls.Add(this.LblApellido);
      this.Controls.Add(this.BtnAgregar);
      this.Controls.Add(this.label4);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmAgregarMedico";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Agregar Medico";
      this.Load += new System.EventHandler(this.FrmAgregarMedico_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button BtnAgregar;
    private System.Windows.Forms.Label LblApellido;
    private System.Windows.Forms.TextBox TxtNombre;
    private System.Windows.Forms.ComboBox CmbEspecialidades;
    private System.Windows.Forms.Label LblNombre;
    private System.Windows.Forms.Label LblEspecialidad;
    private System.Windows.Forms.TextBox TxtApellido;
    private System.Windows.Forms.Button BtnCancelar;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox TxtPorcentajeDescuento;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.MaskedTextBox TxtHoraInicio;
    private System.Windows.Forms.MaskedTextBox TxtHoraFin;
    private System.Windows.Forms.TextBox TxtIntervaloTurnos;
  }
}