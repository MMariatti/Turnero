namespace Turnero.Forms
{
  partial class FrmMainMedico
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMedico));
      this.GrdPacientesMedico = new System.Windows.Forms.DataGridView();
      this.monthCalendarMedico = new System.Windows.Forms.MonthCalendar();
      this.BtnHistoriaClinica = new System.Windows.Forms.Button();
      this.BtnAtendido = new System.Windows.Forms.Button();
      this.BtnBuscar = new System.Windows.Forms.Button();
      this.Lbl_bienvenida = new System.Windows.Forms.Label();
      this.BtnBuscarTurno = new System.Windows.Forms.Button();
      this.Lbl_Legajo = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.GrdPacientesMedico)).BeginInit();
      this.SuspendLayout();
      // 
      // GrdPacientesMedico
      // 
      this.GrdPacientesMedico.AllowUserToAddRows = false;
      this.GrdPacientesMedico.AllowUserToDeleteRows = false;
      this.GrdPacientesMedico.BackgroundColor = System.Drawing.SystemColors.Menu;
      this.GrdPacientesMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.GrdPacientesMedico.GridColor = System.Drawing.SystemColors.Menu;
      this.GrdPacientesMedico.Location = new System.Drawing.Point(259, 81);
      this.GrdPacientesMedico.Name = "GrdPacientesMedico";
      this.GrdPacientesMedico.ReadOnly = true;
      this.GrdPacientesMedico.Size = new System.Drawing.Size(516, 162);
      this.GrdPacientesMedico.TabIndex = 1;
      // 
      // monthCalendarMedico
      // 
      this.monthCalendarMedico.Location = new System.Drawing.Point(9, 81);
      this.monthCalendarMedico.MaxSelectionCount = 1;
      this.monthCalendarMedico.Name = "monthCalendarMedico";
      this.monthCalendarMedico.TabIndex = 2;
      // 
      // BtnHistoriaClinica
      // 
      this.BtnHistoriaClinica.Location = new System.Drawing.Point(259, 297);
      this.BtnHistoriaClinica.Name = "BtnHistoriaClinica";
      this.BtnHistoriaClinica.Size = new System.Drawing.Size(95, 23);
      this.BtnHistoriaClinica.TabIndex = 4;
      this.BtnHistoriaClinica.Text = "Historia Clinica";
      this.BtnHistoriaClinica.UseVisualStyleBackColor = true;
      this.BtnHistoriaClinica.Click += new System.EventHandler(this.BtnHistoriaClinica_Click);
      // 
      // BtnAtendido
      // 
      this.BtnAtendido.Location = new System.Drawing.Point(680, 297);
      this.BtnAtendido.Name = "BtnAtendido";
      this.BtnAtendido.Size = new System.Drawing.Size(95, 23);
      this.BtnAtendido.TabIndex = 5;
      this.BtnAtendido.Text = "Marcar Atendido";
      this.BtnAtendido.UseVisualStyleBackColor = true;
      this.BtnAtendido.Click += new System.EventHandler(this.BtnAtendido_Click);
      // 
      // BtnBuscar
      // 
      this.BtnBuscar.Location = new System.Drawing.Point(680, 32);
      this.BtnBuscar.Name = "BtnBuscar";
      this.BtnBuscar.Size = new System.Drawing.Size(95, 23);
      this.BtnBuscar.TabIndex = 6;
      this.BtnBuscar.Text = "Buscar";
      this.BtnBuscar.UseVisualStyleBackColor = true;
      this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
      // 
      // Lbl_bienvenida
      // 
      this.Lbl_bienvenida.AutoSize = true;
      this.Lbl_bienvenida.Location = new System.Drawing.Point(15, 32);
      this.Lbl_bienvenida.Name = "Lbl_bienvenida";
      this.Lbl_bienvenida.Size = new System.Drawing.Size(48, 13);
      this.Lbl_bienvenida.TabIndex = 7;
      this.Lbl_bienvenida.Text = "Medico :";
      // 
      // BtnBuscarTurno
      // 
      this.BtnBuscarTurno.Location = new System.Drawing.Point(18, 297);
      this.BtnBuscarTurno.Name = "BtnBuscarTurno";
      this.BtnBuscarTurno.Size = new System.Drawing.Size(95, 23);
      this.BtnBuscarTurno.TabIndex = 8;
      this.BtnBuscarTurno.Text = "Buscar Turno";
      this.BtnBuscarTurno.UseVisualStyleBackColor = true;
      this.BtnBuscarTurno.Click += new System.EventHandler(this.BtnBuscarTurno_Click);
      // 
      // Lbl_Legajo
      // 
      this.Lbl_Legajo.AutoSize = true;
      this.Lbl_Legajo.Location = new System.Drawing.Point(256, 268);
      this.Lbl_Legajo.Name = "Lbl_Legajo";
      this.Lbl_Legajo.Size = new System.Drawing.Size(35, 13);
      this.Lbl_Legajo.TabIndex = 9;
      this.Lbl_Legajo.Text = "label2";
      this.Lbl_Legajo.Visible = false;
      // 
      // FrmMainMedico
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 332);
      this.Controls.Add(this.Lbl_Legajo);
      this.Controls.Add(this.BtnBuscarTurno);
      this.Controls.Add(this.Lbl_bienvenida);
      this.Controls.Add(this.BtnBuscar);
      this.Controls.Add(this.BtnAtendido);
      this.Controls.Add(this.BtnHistoriaClinica);
      this.Controls.Add(this.monthCalendarMedico);
      this.Controls.Add(this.GrdPacientesMedico);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmMainMedico";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Menú Principal";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainMedico_FormClosing);
      this.Load += new System.EventHandler(this.FrmMainMedico_Load);
      ((System.ComponentModel.ISupportInitialize)(this.GrdPacientesMedico)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.DataGridView GrdPacientesMedico;
    private System.Windows.Forms.MonthCalendar monthCalendarMedico;
    private System.Windows.Forms.Button BtnHistoriaClinica;
    private System.Windows.Forms.Button BtnAtendido;
    private System.Windows.Forms.Button BtnBuscar;
    private System.Windows.Forms.Label Lbl_bienvenida;
    private System.Windows.Forms.Button BtnBuscarTurno;
    protected internal System.Windows.Forms.Label Lbl_Legajo;
  }
}