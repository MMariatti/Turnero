namespace Turnero.Forms
{
  partial class FrmTurnos
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTurnos));
      this.Btn_DarTurno = new System.Windows.Forms.Button();
      this.txtPaciente = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.txtEspecialidad = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.Btn_salir = new System.Windows.Forms.Button();
      this.label6 = new System.Windows.Forms.Label();
      this.cmbPracticas = new System.Windows.Forms.ComboBox();
      this.Btn_BuscarPaciente = new System.Windows.Forms.Button();
      this.txtObraSocial = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.monthCalendarTurno = new System.Windows.Forms.MonthCalendar();
      this.GrdMedicos = new System.Windows.Forms.DataGridView();
      this.GrdHora = new System.Windows.Forms.DataGridView();
      this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.GrdMedicos)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.GrdHora)).BeginInit();
      this.SuspendLayout();
      // 
      // Btn_DarTurno
      // 
      this.Btn_DarTurno.Location = new System.Drawing.Point(29, 358);
      this.Btn_DarTurno.Name = "Btn_DarTurno";
      this.Btn_DarTurno.Size = new System.Drawing.Size(75, 23);
      this.Btn_DarTurno.TabIndex = 8;
      this.Btn_DarTurno.Text = "Dar Turno";
      this.Btn_DarTurno.UseVisualStyleBackColor = true;
      this.Btn_DarTurno.Click += new System.EventHandler(this.Btn_DarTurno_Click);
      // 
      // txtPaciente
      // 
      this.txtPaciente.Location = new System.Drawing.Point(106, 32);
      this.txtPaciente.Name = "txtPaciente";
      this.txtPaciente.Size = new System.Drawing.Size(121, 20);
      this.txtPaciente.TabIndex = 0;
      this.txtPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaciente_KeyPress);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(26, 37);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(71, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Dni Paciente:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(26, 106);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(45, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Medico:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(26, 258);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(52, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Practica :";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(433, 33);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(40, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "Fecha:";
      // 
      // txtEspecialidad
      // 
      this.txtEspecialidad.Location = new System.Drawing.Point(106, 221);
      this.txtEspecialidad.Name = "txtEspecialidad";
      this.txtEspecialidad.ReadOnly = true;
      this.txtEspecialidad.Size = new System.Drawing.Size(273, 20);
      this.txtEspecialidad.TabIndex = 4;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(440, 220);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(33, 13);
      this.label5.TabIndex = 9;
      this.label5.Text = "Hora:";
      // 
      // Btn_salir
      // 
      this.Btn_salir.Location = new System.Drawing.Point(626, 358);
      this.Btn_salir.Name = "Btn_salir";
      this.Btn_salir.Size = new System.Drawing.Size(75, 23);
      this.Btn_salir.TabIndex = 9;
      this.Btn_salir.Text = "Salir";
      this.Btn_salir.UseVisualStyleBackColor = true;
      this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(26, 224);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(73, 13);
      this.label6.TabIndex = 10;
      this.label6.Text = "Especialidad :";
      // 
      // cmbPracticas
      // 
      this.cmbPracticas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbPracticas.FormattingEnabled = true;
      this.cmbPracticas.Location = new System.Drawing.Point(106, 258);
      this.cmbPracticas.Name = "cmbPracticas";
      this.cmbPracticas.Size = new System.Drawing.Size(273, 21);
      this.cmbPracticas.TabIndex = 5;
      // 
      // Btn_BuscarPaciente
      // 
      this.Btn_BuscarPaciente.Location = new System.Drawing.Point(280, 27);
      this.Btn_BuscarPaciente.Name = "Btn_BuscarPaciente";
      this.Btn_BuscarPaciente.Size = new System.Drawing.Size(99, 23);
      this.Btn_BuscarPaciente.TabIndex = 1;
      this.Btn_BuscarPaciente.Text = "Buscar Paciente";
      this.Btn_BuscarPaciente.UseVisualStyleBackColor = true;
      this.Btn_BuscarPaciente.Click += new System.EventHandler(this.Btn_BuscarPaciente_Click);
      // 
      // txtObraSocial
      // 
      this.txtObraSocial.Location = new System.Drawing.Point(106, 70);
      this.txtObraSocial.Name = "txtObraSocial";
      this.txtObraSocial.ReadOnly = true;
      this.txtObraSocial.Size = new System.Drawing.Size(121, 20);
      this.txtObraSocial.TabIndex = 2;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(26, 73);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(68, 13);
      this.label7.TabIndex = 14;
      this.label7.Text = "Obra Social :";
      // 
      // monthCalendarTurno
      // 
      this.monthCalendarTurno.Location = new System.Drawing.Point(509, 32);
      this.monthCalendarTurno.MaxSelectionCount = 1;
      this.monthCalendarTurno.Name = "monthCalendarTurno";
      this.monthCalendarTurno.TabIndex = 6;
      this.monthCalendarTurno.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarTurno_DateChanged);
      // 
      // GrdMedicos
      // 
      this.GrdMedicos.AllowUserToAddRows = false;
      this.GrdMedicos.AllowUserToDeleteRows = false;
      this.GrdMedicos.BackgroundColor = System.Drawing.SystemColors.Menu;
      this.GrdMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.GrdMedicos.Location = new System.Drawing.Point(106, 96);
      this.GrdMedicos.Name = "GrdMedicos";
      this.GrdMedicos.ReadOnly = true;
      this.GrdMedicos.Size = new System.Drawing.Size(273, 115);
      this.GrdMedicos.TabIndex = 3;
      this.GrdMedicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdMedicos_CellClick);
      this.GrdMedicos.SelectionChanged += new System.EventHandler(this.GrdMedicos_SelectionChanged);
      // 
      // GrdHora
      // 
      this.GrdHora.AllowUserToAddRows = false;
      this.GrdHora.AllowUserToDeleteRows = false;
      this.GrdHora.BackgroundColor = System.Drawing.SystemColors.Menu;
      this.GrdHora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.GrdHora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hora});
      this.GrdHora.Location = new System.Drawing.Point(509, 217);
      this.GrdHora.Name = "GrdHora";
      this.GrdHora.ReadOnly = true;
      this.GrdHora.Size = new System.Drawing.Size(174, 115);
      this.GrdHora.TabIndex = 7;
      // 
      // Hora
      // 
      this.Hora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.Hora.HeaderText = "Hora";
      this.Hora.Name = "Hora";
      this.Hora.ReadOnly = true;
      // 
      // FrmTurnos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(727, 407);
      this.Controls.Add(this.GrdHora);
      this.Controls.Add(this.GrdMedicos);
      this.Controls.Add(this.monthCalendarTurno);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.txtObraSocial);
      this.Controls.Add(this.Btn_BuscarPaciente);
      this.Controls.Add(this.cmbPracticas);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.Btn_salir);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txtEspecialidad);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtPaciente);
      this.Controls.Add(this.Btn_DarTurno);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmTurnos";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Turnos";
      this.Load += new System.EventHandler(this.FrmTurnos_Load);
      ((System.ComponentModel.ISupportInitialize)(this.GrdMedicos)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GrdHora)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button Btn_DarTurno;
    private System.Windows.Forms.TextBox txtPaciente;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtEspecialidad;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button Btn_salir;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ComboBox cmbPracticas;
    private System.Windows.Forms.Button Btn_BuscarPaciente;
    private System.Windows.Forms.TextBox txtObraSocial;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.MonthCalendar monthCalendarTurno;
    private System.Windows.Forms.DataGridView GrdMedicos;
    private System.Windows.Forms.DataGridView GrdHora;
    private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
  }
}