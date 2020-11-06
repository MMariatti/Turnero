namespace Turnero.FormsReportes
{
  partial class FrmPlanillaTurnos
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlanillaTurnos));
      this.BtnGenerarLista = new System.Windows.Forms.Button();
      this.cmbMedicos = new System.Windows.Forms.ComboBox();
      this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // BtnGenerarLista
      // 
      this.BtnGenerarLista.Location = new System.Drawing.Point(417, 12);
      this.BtnGenerarLista.Name = "BtnGenerarLista";
      this.BtnGenerarLista.Size = new System.Drawing.Size(157, 23);
      this.BtnGenerarLista.TabIndex = 1;
      this.BtnGenerarLista.Text = "Generar lista de turnos";
      this.BtnGenerarLista.UseVisualStyleBackColor = true;
      this.BtnGenerarLista.Click += new System.EventHandler(this.BtnGenerarLista_Click);
      // 
      // cmbMedicos
      // 
      this.cmbMedicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbMedicos.FormattingEnabled = true;
      this.cmbMedicos.Location = new System.Drawing.Point(252, 14);
      this.cmbMedicos.Name = "cmbMedicos";
      this.cmbMedicos.Size = new System.Drawing.Size(121, 21);
      this.cmbMedicos.TabIndex = 0;
      // 
      // reportViewer1
      // 
      this.reportViewer1.LocalReport.ReportEmbeddedResource = "Turnero.Reportes.RptTurnosXmedico.rdlc";
      this.reportViewer1.Location = new System.Drawing.Point(1, 52);
      this.reportViewer1.Name = "reportViewer1";
      this.reportViewer1.ServerReport.BearerToken = null;
      this.reportViewer1.ShowExportButton = false;
      this.reportViewer1.Size = new System.Drawing.Size(805, 403);
      this.reportViewer1.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(161, 17);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(45, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Medico:";
      // 
      // FrmPlanillaTurnos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(806, 450);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.reportViewer1);
      this.Controls.Add(this.cmbMedicos);
      this.Controls.Add(this.BtnGenerarLista);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmPlanillaTurnos";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Planillas de turnos";
      this.Load += new System.EventHandler(this.FrmPlanillaTurnos_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button BtnGenerarLista;
    private System.Windows.Forms.ComboBox cmbMedicos;
    private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    private System.Windows.Forms.Label label1;
  }
}