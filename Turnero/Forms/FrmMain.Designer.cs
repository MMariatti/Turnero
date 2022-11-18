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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
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
      this.planillaTurnosDelDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.cajaYFacturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.cierreDeCajaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.generarFacturaPorMedicoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.informwaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pacientesDelMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.GrdTurnos = new System.Windows.Forms.DataGridView();
      this.btnBuscarTurnos = new System.Windows.Forms.Button();
      this.btnActualizar = new System.Windows.Forms.Button();
      this.BtnConfirmarTurno = new System.Windows.Forms.Button();
      this.Btn_EliminarTurno = new System.Windows.Forms.Button();
      this.BtnBuscarXmedico = new System.Windows.Forms.Button();
      this.CmbMedicos = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.BtnSobreTurno = new System.Windows.Forms.Button();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.GrdTurnos)).BeginInit();
      this.SuspendLayout();
      // 
      // monthCalendarTurno
      // 
      this.monthCalendarTurno.Location = new System.Drawing.Point(18, 79);
      this.monthCalendarTurno.MaxSelectionCount = 1;
      this.monthCalendarTurno.Name = "monthCalendarTurno";
      this.monthCalendarTurno.TabIndex = 3;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicosToolStripMenuItem,
            this.practicasToolStripMenuItem,
            this.pacientesToolStripMenuItem,
            this.pacientesToolStripMenuItem1,
            this.practicasToolStripMenuItem1,
            this.turnosToolStripMenuItem,
            this.cajaYFacturacionToolStripMenuItem,
            this.informwaToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
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
            this.gestionarTurnosToolStripMenuItem,
            this.planillaTurnosDelDiaToolStripMenuItem});
      this.turnosToolStripMenuItem.Name = "turnosToolStripMenuItem";
      this.turnosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
      this.turnosToolStripMenuItem.Text = "Turnos";
      // 
      // gestionarTurnosToolStripMenuItem
      // 
      this.gestionarTurnosToolStripMenuItem.Name = "gestionarTurnosToolStripMenuItem";
      this.gestionarTurnosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
      this.gestionarTurnosToolStripMenuItem.Text = "Gestionar Turnos";
      this.gestionarTurnosToolStripMenuItem.Click += new System.EventHandler(this.gestionarTurnosToolStripMenuItem_Click);
      // 
      // planillaTurnosDelDiaToolStripMenuItem
      // 
      this.planillaTurnosDelDiaToolStripMenuItem.Name = "planillaTurnosDelDiaToolStripMenuItem";
      this.planillaTurnosDelDiaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
      this.planillaTurnosDelDiaToolStripMenuItem.Text = "Planilla Turnos del dia";
      this.planillaTurnosDelDiaToolStripMenuItem.Click += new System.EventHandler(this.planillaTurnosDelDiaToolStripMenuItem_Click);
      // 
      // cajaYFacturacionToolStripMenuItem
      // 
      this.cajaYFacturacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cierreDeCajaToolStripMenuItem1,
            this.generarFacturaPorMedicoToolStripMenuItem1});
      this.cajaYFacturacionToolStripMenuItem.Name = "cajaYFacturacionToolStripMenuItem";
      this.cajaYFacturacionToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
      this.cajaYFacturacionToolStripMenuItem.Text = "Caja y Facturacion";
      // 
      // cierreDeCajaToolStripMenuItem1
      // 
      this.cierreDeCajaToolStripMenuItem1.Name = "cierreDeCajaToolStripMenuItem1";
      this.cierreDeCajaToolStripMenuItem1.Size = new System.Drawing.Size(221, 22);
      this.cierreDeCajaToolStripMenuItem1.Text = "Cierre de caja";
      this.cierreDeCajaToolStripMenuItem1.Click += new System.EventHandler(this.cierreDeCajaToolStripMenuItem1_Click);
      // 
      // generarFacturaPorMedicoToolStripMenuItem1
      // 
      this.generarFacturaPorMedicoToolStripMenuItem1.Name = "generarFacturaPorMedicoToolStripMenuItem1";
      this.generarFacturaPorMedicoToolStripMenuItem1.Size = new System.Drawing.Size(221, 22);
      this.generarFacturaPorMedicoToolStripMenuItem1.Text = "Generar Factura por medico";
      this.generarFacturaPorMedicoToolStripMenuItem1.Click += new System.EventHandler(this.generarFacturaPorMedicoToolStripMenuItem1_Click);
      // 
      // informwaToolStripMenuItem
      // 
      this.informwaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesDelMesToolStripMenuItem});
      this.informwaToolStripMenuItem.Name = "informwaToolStripMenuItem";
      this.informwaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
      this.informwaToolStripMenuItem.Text = "Informes";
      // 
      // pacientesDelMesToolStripMenuItem
      // 
      this.pacientesDelMesToolStripMenuItem.Name = "pacientesDelMesToolStripMenuItem";
      this.pacientesDelMesToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
      this.pacientesDelMesToolStripMenuItem.Text = "Pacientes del Mes";
      this.pacientesDelMesToolStripMenuItem.Click += new System.EventHandler(this.pacientesDelMesToolStripMenuItem_Click);
      // 
      // GrdTurnos
      // 
      this.GrdTurnos.AllowUserToAddRows = false;
      this.GrdTurnos.AllowUserToDeleteRows = false;
      this.GrdTurnos.BackgroundColor = System.Drawing.SystemColors.Menu;
      this.GrdTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.GrdTurnos.Location = new System.Drawing.Point(278, 77);
      this.GrdTurnos.Name = "GrdTurnos";
      this.GrdTurnos.ReadOnly = true;
      this.GrdTurnos.Size = new System.Drawing.Size(767, 290);
      this.GrdTurnos.TabIndex = 4;
      this.GrdTurnos.DataSourceChanged += new System.EventHandler(this.GrdTurnos_DataSourceChanged);
      this.GrdTurnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdTurnos_CellContentClick);
      // 
      // btnBuscarTurnos
      // 
      this.btnBuscarTurnos.Location = new System.Drawing.Point(18, 385);
      this.btnBuscarTurnos.Name = "btnBuscarTurnos";
      this.btnBuscarTurnos.Size = new System.Drawing.Size(99, 23);
      this.btnBuscarTurnos.TabIndex = 5;
      this.btnBuscarTurnos.Text = "Buscar Turnos";
      this.btnBuscarTurnos.UseVisualStyleBackColor = true;
      this.btnBuscarTurnos.Click += new System.EventHandler(this.btnBuscarTurnos_Click);
      // 
      // btnActualizar
      // 
      this.btnActualizar.Location = new System.Drawing.Point(946, 385);
      this.btnActualizar.Name = "btnActualizar";
      this.btnActualizar.Size = new System.Drawing.Size(99, 23);
      this.btnActualizar.TabIndex = 9;
      this.btnActualizar.Text = "Actualizar";
      this.btnActualizar.UseVisualStyleBackColor = true;
      this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
      // 
      // BtnConfirmarTurno
      // 
      this.BtnConfirmarTurno.Location = new System.Drawing.Point(278, 385);
      this.BtnConfirmarTurno.Name = "BtnConfirmarTurno";
      this.BtnConfirmarTurno.Size = new System.Drawing.Size(99, 23);
      this.BtnConfirmarTurno.TabIndex = 6;
      this.BtnConfirmarTurno.Text = "Confirmar Turno";
      this.BtnConfirmarTurno.UseVisualStyleBackColor = true;
      this.BtnConfirmarTurno.Click += new System.EventHandler(this.BtnConfirmarTurno_Click);
      // 
      // Btn_EliminarTurno
      // 
      this.Btn_EliminarTurno.Location = new System.Drawing.Point(469, 385);
      this.Btn_EliminarTurno.Name = "Btn_EliminarTurno";
      this.Btn_EliminarTurno.Size = new System.Drawing.Size(99, 23);
      this.Btn_EliminarTurno.TabIndex = 7;
      this.Btn_EliminarTurno.Text = "Eliminar Turno";
      this.Btn_EliminarTurno.UseVisualStyleBackColor = true;
      this.Btn_EliminarTurno.Click += new System.EventHandler(this.Btn_EliminarTurno_Click);
      // 
      // BtnBuscarXmedico
      // 
      this.BtnBuscarXmedico.Location = new System.Drawing.Point(881, 50);
      this.BtnBuscarXmedico.Name = "BtnBuscarXmedico";
      this.BtnBuscarXmedico.Size = new System.Drawing.Size(130, 23);
      this.BtnBuscarXmedico.TabIndex = 2;
      this.BtnBuscarXmedico.Text = "Buscar por medico";
      this.BtnBuscarXmedico.UseVisualStyleBackColor = true;
      this.BtnBuscarXmedico.Click += new System.EventHandler(this.BtnBuscarXmedico_Click);
      // 
      // CmbMedicos
      // 
      this.CmbMedicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.CmbMedicos.FormattingEnabled = true;
      this.CmbMedicos.Location = new System.Drawing.Point(346, 50);
      this.CmbMedicos.Name = "CmbMedicos";
      this.CmbMedicos.Size = new System.Drawing.Size(188, 21);
      this.CmbMedicos.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(241, 55);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(48, 13);
      this.label1.TabIndex = 9;
      this.label1.Text = "Medico :";
      // 
      // BtnSobreTurno
      // 
      this.BtnSobreTurno.Location = new System.Drawing.Point(761, 385);
      this.BtnSobreTurno.Name = "BtnSobreTurno";
      this.BtnSobreTurno.Size = new System.Drawing.Size(99, 23);
      this.BtnSobreTurno.TabIndex = 8;
      this.BtnSobreTurno.Text = "Sobre Turno";
      this.BtnSobreTurno.UseVisualStyleBackColor = true;
      this.BtnSobreTurno.Click += new System.EventHandler(this.BtnSobreTurno_Click);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1084, 486);
      this.Controls.Add(this.BtnSobreTurno);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.CmbMedicos);
      this.Controls.Add(this.BtnBuscarXmedico);
      this.Controls.Add(this.Btn_EliminarTurno);
      this.Controls.Add(this.BtnConfirmarTurno);
      this.Controls.Add(this.btnActualizar);
      this.Controls.Add(this.btnBuscarTurnos);
      this.Controls.Add(this.GrdTurnos);
      this.Controls.Add(this.monthCalendarTurno);
      this.Controls.Add(this.menuStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "FrmMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = " ";
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
    private System.Windows.Forms.ToolStripMenuItem planillaTurnosDelDiaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem cajaYFacturacionToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem cierreDeCajaToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem generarFacturaPorMedicoToolStripMenuItem1;
    private System.Windows.Forms.Button Btn_EliminarTurno;
    private System.Windows.Forms.Button BtnBuscarXmedico;
    private System.Windows.Forms.ComboBox CmbMedicos;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button BtnSobreTurno;
    private System.Windows.Forms.ToolStripMenuItem informwaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pacientesDelMesToolStripMenuItem;
  }
}