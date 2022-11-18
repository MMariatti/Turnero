namespace Turnero.FormsReportes
{
  partial class FrmReciboMedicos
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReciboMedicos));
      this.cmbMedicos = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
      this.SuspendLayout();
      // 
      // cmbMedicos
      // 
      this.cmbMedicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbMedicos.FormattingEnabled = true;
      this.cmbMedicos.Location = new System.Drawing.Point(328, 12);
      this.cmbMedicos.Name = "cmbMedicos";
      this.cmbMedicos.Size = new System.Drawing.Size(121, 21);
      this.cmbMedicos.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(240, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(48, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Medico :";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(491, 12);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(101, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "Generar Factura";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // reportViewer1
      // 
      this.reportViewer1.LocalReport.ReportEmbeddedResource = "Turnero.Reportes.RptFacturacionXMedico.rdlc";
      this.reportViewer1.Location = new System.Drawing.Point(-3, 41);
      this.reportViewer1.Name = "reportViewer1";
      this.reportViewer1.ServerReport.BearerToken = null;
      this.reportViewer1.ShowExportButton = false;
      this.reportViewer1.Size = new System.Drawing.Size(803, 410);
      this.reportViewer1.TabIndex = 2;
      // 
      // FrmReciboMedicos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.reportViewer1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cmbMedicos);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmReciboMedicos";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Facturación medicos";
      this.Load += new System.EventHandler(this.FrmReciboMedicos_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cmbMedicos;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    
  }
}