namespace Turnero.FormsReportes
{
  partial class FrmImprimirHc
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImprimirHc));
      this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
      this.label1 = new System.Windows.Forms.Label();
      this.TxtDni = new System.Windows.Forms.TextBox();
      this.BtnVerHc = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // reportViewer1
      // 
      this.reportViewer1.LocalReport.ReportEmbeddedResource = "Turnero.Reportes.RptHistoriaClinica.rdlc";
      this.reportViewer1.Location = new System.Drawing.Point(1, 44);
      this.reportViewer1.Name = "reportViewer1";
      this.reportViewer1.ServerReport.BearerToken = null;
      this.reportViewer1.Size = new System.Drawing.Size(801, 406);
      this.reportViewer1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(266, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(29, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Dni :";
      // 
      // TxtDni
      // 
      this.TxtDni.Location = new System.Drawing.Point(311, 10);
      this.TxtDni.Name = "TxtDni";
      this.TxtDni.Size = new System.Drawing.Size(100, 20);
      this.TxtDni.TabIndex = 2;
      // 
      // BtnVerHc
      // 
      this.BtnVerHc.Location = new System.Drawing.Point(491, 8);
      this.BtnVerHc.Name = "BtnVerHc";
      this.BtnVerHc.Size = new System.Drawing.Size(75, 23);
      this.BtnVerHc.TabIndex = 3;
      this.BtnVerHc.Text = "Ver";
      this.BtnVerHc.UseVisualStyleBackColor = true;
      this.BtnVerHc.Click += new System.EventHandler(this.BtnVerHc_Click);
      // 
      // FrmImprimirHc
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.BtnVerHc);
      this.Controls.Add(this.TxtDni);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.reportViewer1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmImprimirHc";
      this.Text = "Imprimir Historia Clinica";
      this.Load += new System.EventHandler(this.FrmImprimirHc_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    private System.Windows.Forms.Label label1;
    protected internal System.Windows.Forms.TextBox TxtDni;
    private System.Windows.Forms.Button BtnVerHc;
  }
}