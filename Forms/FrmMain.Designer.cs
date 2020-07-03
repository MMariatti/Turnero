namespace Turnero.Forms
{
  partial class FrmMain
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
      this.monthCalendarTurno = new System.Windows.Forms.MonthCalendar();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.medicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.gestionarEspecialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.practicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.gestionarMedicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.gestionarObrasSocialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pacientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.gestionarPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.verHistoriaClinicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.practicasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.gestionarPracticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.turnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.gestionarTurnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.GrdTurnos = new System.Windows.Forms.DataGridView();
      this.btnBuscarTurnos = new System.Windows.Forms.Button();
      this.btnActualizar = new System.Windows.Forms.Button();
      this.BtnConfirmarTurno = new System.Windows.Forms.Button();
      this.btnReporte = new System.Windows.Forms.Button();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.GrdTurnos)).BeginInit();
      this.SuspendLayout();
      // 
      // monthCalendarTurno
      // 
      this.monthCalendarTurno.Location = new System.Drawing.Point(18, 79);
      this.monthCalendarTurno.MaxSelectionCount = 1;
      this.monthCalendarTurno.Name = "monthCalendarTurno";
      this.monthCalendarTurno.TabIndex = 1;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicosToolStripMenuItem,
            this.practicasToolStripMenuItem,
            this.pacientesToolStripMenuItem,
            this.pacientesToolStripMenuItem1,
            this.practicasToolStripMenuItem1,
            this.turnosToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1076, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
      // 
      // medicosToolStripMenuItem
      // 
      this.medicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarEspecialidadesToolStripMenuItem});
      this.medicosToolStripMenuItem.Name = "medicosToolStripMenuItem";
      this.medicosToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
      this.medicosToolStripMenuItem.Text = "Especialidades";
      // 
      // gestionarEspecialidadesToolStripMenuItem
      // 
      this.gestionarEspecialidadesToolStripMenuItem.Name = "gestionarEspecialidadesToolStripMenuItem";
      this.gestionarEspecialidadesToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
      this.gestionarEspecialidadesToolStripMenuItem.Text = "Gestionar Especialidades";
      this.gestionarEspecialidadesToolStripMenuItem.Click += new System.EventHandler(this.gestionarEspecialidadesToolStripMenuItem_Click);
      // 
      // practicasToolStripMenuItem
      // 
      this.practicasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarMedicosToolStripMenuItem});
      this.practicasToolStripMenuItem.Name = "practicasToolStripMenuItem";
      this.practicasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
      this.practicasToolStripMenuItem.Text = "Medicos";
      // 
      // gestionarMedicosToolStripMenuItem
      // 
      this.gestionarMedicosToolStripMenuItem.Name = "gestionarMedicosToolStripMenuItem";
      this.gestionarMedicosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
      this.gestionarMedicosToolStripMenuItem.Text = "Gestionar Medicos";
      this.gestionarMedicosToolStripMenuItem.Click += new System.EventHandler(this.gestionarMedicosToolStripMenuItem_Click);
      // 
      // pacientesToolStripMenuItem
      // 
      this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarObrasSocialesToolStripMenuItem});
      this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
      this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
      this.pacientesToolStripMenuItem.Text = "Obras Sociales";
      // 
      // gestionarObrasSocialesToolStripMenuItem
      // 
      this.gestionarObrasSocialesToolStripMenuItem.Name = "gestionarObrasSocialesToolStripMenuItem";
      this.gestionarObrasSocialesToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
      this.gestionarObrasSocialesToolStripMenuItem.Text = "Gestionar obras sociales";
      this.gestionarObrasSocialesToolStripMenuItem.Click += new System.EventHandler(this.gestionarObrasSocialesToolStripMenuItem_Click);
      // 
      // pacientesToolStripMenuItem1
      // 
      this.pacientesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarPacientesToolStripMenuItem,
            this.verHistoriaClinicaToolStripMenuItem});
      this.pacientesToolStripMenuItem1.Name = "pacientesToolStripMenuItem1";
      this.pacientesToolStripMenuItem1.Size = new System.Drawing.Size(69, 20);
      this.pacientesToolStripMenuItem1.Text = "Pacientes";
      // 
      // gestionarPacientesToolStripMenuItem
      // 
      this.gestionarPacientesToolStripMenuItem.Name = "gestionarPacientesToolStripMenuItem";
      this.gestionarPacientesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
      this.gestionarPacientesToolStripMenuItem.Text = "Gestionar pacientes";
      this.gestionarPacientesToolStripMenuItem.Click += new System.EventHandler(this.gestionarPacientesToolStripMenuItem_Click);
      // 
      // verHistoriaClinicaToolStripMenuItem
      // 
      this.verHistoriaClinicaToolStripMenuItem.Name = "verHistoriaClinicaToolStripMenuItem";
      this.verHistoriaClinicaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
      this.verHistoriaClinicaToolStripMenuItem.Text = "Ver historia clinica";
      this.verHistoriaClinicaToolStripMenuItem.Click += new System.EventHandler(this.verHistoriaClinicaToolStripMenuItem_Click);
      // 
      // practicasToolStripMenuItem1
      // 
      this.practicasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarPracticasToolStripMenuItem});
      this.practicasToolStripMenuItem1.Name = "practicasToolStripMenuItem1";
      this.practicasToolStripMenuItem1.Size = new System.Drawing.Size(66, 20);
      this.practicasToolStripMenuItem1.Text = "Practicas";
      // 
      // gestionarPracticasToolStripMenuItem
      // 
      this.gestionarPracticasToolStripMenuItem.Name = "gestionarPracticasToolStripMenuItem";
      this.gestionarPracticasToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
      this.gestionarPracticasToolStripMenuItem.Text = "Gestionar practicas";
      this.gestionarPracticasToolStripMenuItem.Click += new System.EventHandler(this.gestionarPracticasToolStripMenuItem_Click);
      // 
      // turnosToolStripMenuItem
      // 
      this.turnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarTurnosToolStripMenuItem});
      this.turnosToolStripMenuItem.Name = "turnosToolStripMenuItem";
      this.turnosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
      this.turnosToolStripMenuItem.Text = "Turnos";
      // 
      // gestionarTurnosToolStripMenuItem
      // 
      this.gestionarTurnosToolStripMenuItem.Name = "gestionarTurnosToolStripMenuItem";
      this.gestionarTurnosToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
      this.gestionarTurnosToolStripMenuItem.Text = "Gestionar Turnos";
      this.gestionarTurnosToolStripMenuItem.Click += new System.EventHandler(this.gestionarTurnosToolStripMenuItem_Click);
      // 
      // GrdTurnos
      // 
      this.GrdTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.GrdTurnos.Location = new System.Drawing.Point(244, 79);
      this.GrdTurnos.Name = "GrdTurnos";
      this.GrdTurnos.Size = new System.Drawing.Size(792, 290);
      this.GrdTurnos.TabIndex = 2;
      // 
      // btnBuscarTurnos
      // 
      this.btnBuscarTurnos.Location = new System.Drawing.Point(18, 267);
      this.btnBuscarTurnos.Name = "btnBuscarTurnos";
      this.btnBuscarTurnos.Size = new System.Drawing.Size(99, 23);
      this.btnBuscarTurnos.TabIndex = 3;
      this.btnBuscarTurnos.Text = "Buscar Turnos";
      this.btnBuscarTurnos.UseVisualStyleBackColor = true;
      this.btnBuscarTurnos.Click += new System.EventHandler(this.btnBuscarTurnos_Click);
      // 
      // btnActualizar
      // 
      this.btnActualizar.Location = new System.Drawing.Point(937, 385);
      this.btnActualizar.Name = "btnActualizar";
      this.btnActualizar.Size = new System.Drawing.Size(99, 23);
      this.btnActualizar.TabIndex = 4;
      this.btnActualizar.Text = "Actualizar";
      this.btnActualizar.UseVisualStyleBackColor = true;
      this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
      // 
      // BtnConfirmarTurno
      // 
      this.BtnConfirmarTurno.Location = new System.Drawing.Point(244, 385);
      this.BtnConfirmarTurno.Name = "BtnConfirmarTurno";
      this.BtnConfirmarTurno.Size = new System.Drawing.Size(99, 23);
      this.BtnConfirmarTurno.TabIndex = 5;
      this.BtnConfirmarTurno.Text = "Confirmar Turno";
      this.BtnConfirmarTurno.UseVisualStyleBackColor = true;
      this.BtnConfirmarTurno.Click += new System.EventHandler(this.BtnConfirmarTurno_Click);
      // 
      // btnReporte
      // 
      this.btnReporte.Location = new System.Drawing.Point(553, 385);
      this.btnReporte.Name = "btnReporte";
      this.btnReporte.Size = new System.Drawing.Size(99, 23);
      this.btnReporte.TabIndex = 6;
      this.btnReporte.Text = "Reporte del dia ";
      this.btnReporte.UseVisualStyleBackColor = true;
      this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1076, 450);
      this.Controls.Add(this.btnReporte);
      this.Controls.Add(this.BtnConfirmarTurno);
      this.Controls.Add(this.btnActualizar);
      this.Controls.Add(this.btnBuscarTurnos);
      this.Controls.Add(this.GrdTurnos);
      this.Controls.Add(this.monthCalendarTurno);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "FrmMain";
      this.Text = "FrmMain";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
      this.Load += new System.EventHandler(this.FrmMain_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.GrdTurnos)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MonthCalendar monthCalendarTurno;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem medicosToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem gestionarEspecialidadesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem practicasToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem gestionarMedicosToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem gestionarObrasSocialesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem gestionarPacientesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem practicasToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem gestionarPracticasToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem turnosToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem gestionarTurnosToolStripMenuItem;
    private System.Windows.Forms.DataGridView GrdTurnos;
    private System.Windows.Forms.ToolStripMenuItem verHistoriaClinicaToolStripMenuItem;
    private System.Windows.Forms.Button btnBuscarTurnos;
    private System.Windows.Forms.Button btnActualizar;
    private System.Windows.Forms.Button BtnConfirmarTurno;
    private System.Windows.Forms.Button btnReporte;
  }
}