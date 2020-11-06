namespace Turnero.FormsReportes
{
  partial class FrmCobroMedicos
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
      this.components = new System.ComponentModel.Container();
      Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCobroMedicos));
      this.cajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dataSetCaja = new Turnero.DataSets.DataSetCaja();
      this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
      this.cajaTableAdapter = new Turnero.DataSets.DataSetCajaTableAdapters.CajaTableAdapter();
      ((System.ComponentModel.ISupportInitialize)(this.cajaBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSetCaja)).BeginInit();
      this.SuspendLayout();
      // 
      // cajaBindingSource
      // 
      this.cajaBindingSource.DataMember = "Caja";
      this.cajaBindingSource.DataSource = this.dataSetCaja;
      // 
      // dataSetCaja
      // 
      this.dataSetCaja.DataSetName = "DataSetCaja";
      this.dataSetCaja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // reportViewer1
      // 
      this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
      reportDataSource1.Name = "DsCierreCaja";
      reportDataSource1.Value = this.cajaBindingSource;
      this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
      this.reportViewer1.LocalReport.ReportEmbeddedResource = "Turnero.Reportes.RptCierreCajardlc.rdlc";
      this.reportViewer1.Location = new System.Drawing.Point(0, 0);
      this.reportViewer1.Name = "reportViewer1";
      this.reportViewer1.ServerReport.BearerToken = null;
      this.reportViewer1.ShowExportButton = false;
      this.reportViewer1.Size = new System.Drawing.Size(800, 450);
      this.reportViewer1.TabIndex = 0;
      // 
      // cajaTableAdapter
      // 
      this.cajaTableAdapter.ClearBeforeFill = true;
      // 
      // FrmCobroMedicos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.reportViewer1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmCobroMedicos";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Cierre de caja";
      this.Load += new System.EventHandler(this.FrmCobroMedicos_Load);
      ((System.ComponentModel.ISupportInitialize)(this.cajaBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSetCaja)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    private DataSets.DataSetCaja dataSetCaja;
    private System.Windows.Forms.BindingSource cajaBindingSource;
    private DataSets.DataSetCajaTableAdapters.CajaTableAdapter cajaTableAdapter;
  }
}