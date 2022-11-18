namespace Turnero.Forms
{
  partial class FrmSobreTurno
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSobreTurno));
      this.TxtFecha = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.CmbPracticas = new System.Windows.Forms.ComboBox();
      this.BtnBuscarPaciente = new System.Windows.Forms.Button();
      this.TxtHora = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.TxtMedico = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.TxtPaciente = new System.Windows.Forms.TextBox();
      this.TxtObraSocial = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.TxtEspecialidad = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.BtnSobreTurno = new System.Windows.Forms.Button();
      this.BtnSalir = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // TxtFecha
      // 
      this.TxtFecha.Location = new System.Drawing.Point(125, 46);
      this.TxtFecha.Name = "TxtFecha";
      this.TxtFecha.ReadOnly = true;
      this.TxtFecha.Size = new System.Drawing.Size(100, 20);
      this.TxtFecha.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(22, 53);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(43, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Fecha :";
      // 
      // CmbPracticas
      // 
      this.CmbPracticas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.CmbPracticas.FormattingEnabled = true;
      this.CmbPracticas.Location = new System.Drawing.Point(125, 212);
      this.CmbPracticas.Name = "CmbPracticas";
      this.CmbPracticas.Size = new System.Drawing.Size(178, 21);
      this.CmbPracticas.TabIndex = 0;
      // 
      // BtnBuscarPaciente
      // 
      this.BtnBuscarPaciente.Location = new System.Drawing.Point(596, 44);
      this.BtnBuscarPaciente.Name = "BtnBuscarPaciente";
      this.BtnBuscarPaciente.Size = new System.Drawing.Size(112, 23);
      this.BtnBuscarPaciente.TabIndex = 3;
      this.BtnBuscarPaciente.Text = "Buscar Paciente";
      this.BtnBuscarPaciente.UseVisualStyleBackColor = true;
      this.BtnBuscarPaciente.Click += new System.EventHandler(this.BtnBuscarPaciente_Click);
      // 
      // TxtHora
      // 
      this.TxtHora.Location = new System.Drawing.Point(125, 88);
      this.TxtHora.Name = "TxtHora";
      this.TxtHora.ReadOnly = true;
      this.TxtHora.Size = new System.Drawing.Size(100, 20);
      this.TxtHora.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(22, 91);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(36, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Hora :";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(22, 215);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(52, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Practica :";
      // 
      // TxtMedico
      // 
      this.TxtMedico.Location = new System.Drawing.Point(125, 133);
      this.TxtMedico.Name = "TxtMedico";
      this.TxtMedico.ReadOnly = true;
      this.TxtMedico.Size = new System.Drawing.Size(178, 20);
      this.TxtMedico.TabIndex = 7;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(22, 136);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(48, 13);
      this.label4.TabIndex = 8;
      this.label4.Text = "Medico :";
      // 
      // TxtPaciente
      // 
      this.TxtPaciente.Location = new System.Drawing.Point(447, 46);
      this.TxtPaciente.Name = "TxtPaciente";
      this.TxtPaciente.Size = new System.Drawing.Size(121, 20);
      this.TxtPaciente.TabIndex = 1;
      this.TxtPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPaciente_KeyPress);
      // 
      // TxtObraSocial
      // 
      this.TxtObraSocial.Location = new System.Drawing.Point(447, 84);
      this.TxtObraSocial.Name = "TxtObraSocial";
      this.TxtObraSocial.ReadOnly = true;
      this.TxtObraSocial.Size = new System.Drawing.Size(121, 20);
      this.TxtObraSocial.TabIndex = 2;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(344, 49);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(29, 13);
      this.label5.TabIndex = 11;
      this.label5.Text = "Dni :";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(344, 91);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(68, 13);
      this.label6.TabIndex = 12;
      this.label6.Text = "Obra Social :";
      // 
      // TxtEspecialidad
      // 
      this.TxtEspecialidad.Location = new System.Drawing.Point(125, 172);
      this.TxtEspecialidad.Name = "TxtEspecialidad";
      this.TxtEspecialidad.ReadOnly = true;
      this.TxtEspecialidad.Size = new System.Drawing.Size(178, 20);
      this.TxtEspecialidad.TabIndex = 13;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(22, 179);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(73, 13);
      this.label7.TabIndex = 14;
      this.label7.Text = "Especialidad :";
      // 
      // BtnSobreTurno
      // 
      this.BtnSobreTurno.Location = new System.Drawing.Point(25, 309);
      this.BtnSobreTurno.Name = "BtnSobreTurno";
      this.BtnSobreTurno.Size = new System.Drawing.Size(112, 23);
      this.BtnSobreTurno.TabIndex = 4;
      this.BtnSobreTurno.Text = "Dar Sobre Turno";
      this.BtnSobreTurno.UseVisualStyleBackColor = true;
      this.BtnSobreTurno.Click += new System.EventHandler(this.BtnSobreTurno_Click);
      // 
      // BtnSalir
      // 
      this.BtnSalir.Location = new System.Drawing.Point(608, 309);
      this.BtnSalir.Name = "BtnSalir";
      this.BtnSalir.Size = new System.Drawing.Size(100, 23);
      this.BtnSalir.TabIndex = 5;
      this.BtnSalir.Text = "Salir";
      this.BtnSalir.UseVisualStyleBackColor = true;
      this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
      // 
      // FrmSobreTurno
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(723, 350);
      this.Controls.Add(this.BtnSalir);
      this.Controls.Add(this.BtnSobreTurno);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.TxtEspecialidad);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.TxtObraSocial);
      this.Controls.Add(this.TxtPaciente);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.TxtMedico);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.TxtHora);
      this.Controls.Add(this.BtnBuscarPaciente);
      this.Controls.Add(this.CmbPracticas);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.TxtFecha);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmSobreTurno";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Sobre turnos";
      this.Load += new System.EventHandler(this.FrmSobreTurno_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox CmbPracticas;
    private System.Windows.Forms.Button BtnBuscarPaciente;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    protected internal System.Windows.Forms.TextBox TxtFecha;
    protected internal System.Windows.Forms.TextBox TxtHora;
    protected internal System.Windows.Forms.TextBox TxtMedico;
    private System.Windows.Forms.Label label4;
    protected internal System.Windows.Forms.TextBox TxtPaciente;
    protected internal System.Windows.Forms.TextBox TxtObraSocial;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    protected internal System.Windows.Forms.TextBox TxtEspecialidad;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button BtnSobreTurno;
    private System.Windows.Forms.Button BtnSalir;
  }
}