namespace Turnero.FormsReportes
{
  partial class FrmPacientesXMes
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPacientesXMes));
      this.cmbMeses = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.BtnGenerarInforme = new System.Windows.Forms.Button();
      this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
      this.label2 = new System.Windows.Forms.Label();
      this.cmbMedicos = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // cmbMeses
      // 
      this.cmbMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbMeses.FormattingEnabled = true;
      this.cmbMeses.Location = new System.Drawing.Point(371, 12);
      this.cmbMeses.Name = "cmbMeses";
      this.cmbMeses.Size = new System.Drawing.Size(121, 21);
      this.cmbMeses.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(320, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(33, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Mes :";
      // 
      // BtnGenerarInforme
      // 
      this.BtnGenerarInforme.Location = new System.Drawing.Point(521, 10);
      this.BtnGenerarInforme.Name = "BtnGenerarInforme";
      this.BtnGenerarInforme.Size = new System.Drawing.Size(123, 23);
      this.BtnGenerarInforme.TabIndex = 2;
      this.BtnGenerarInforme.Text = "Generar Informe";
      this.BtnGenerarInforme.UseVisualStyleBackColor = true;
      this.BtnGenerarInforme.Click += new System.EventHandler(this.BtnGenerarInforme_Click);
      // 
      // reportViewer1
      // 
      this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.reportViewer1.LocalReport.ReportEmbeddedResource = "Turnero.Reportes.RptPacientesXMes.rdlc";
      this.reportViewer1.Location = new System.Drawing.Point(0, 39);
      this.reportViewer1.Name = "reportViewer1";
      this.reportViewer1.ServerReport.BearerToken = null;
      this.reportViewer1.ShowExportButton = false;
      this.reportViewer1.Size = new System.Drawing.Size(801, 412);
      this.reportViewer1.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(65, 15);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(48, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Medico :";
      // 
      // cmbMedicos
      // 
      this.cmbMedicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbMedicos.FormattingEnabled = true;
      this.cmbMedicos.Location = new System.Drawing.Point(132, 12);
      this.cmbMedicos.Name = "cmbMedicos";
      this.cmbMedicos.Size = new System.Drawing.Size(149, 21);
      this.cmbMedicos.TabIndex = 4;
      // 
      // FrmPacientesXMes
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(801, 451);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.cmbMedicos);
      this.Controls.Add(this.reportViewer1);
      this.Controls.Add(this.BtnGenerarInforme);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cmbMeses);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmPacientesXMes";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Informe de Pacientes por mes";
      this.Load += new System.EventHandler(this.FormPacientesXMes_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cmbMeses;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button BtnGenerarInforme;
    private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cmbMedicos;
  }
}