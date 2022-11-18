using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Turnero.DataSets;
using Turnero.DataSets.DataSetHistoriaClinicaTableAdapters;

namespace Turnero.FormsReportes
{
  public partial class FrmImprimirHc : Form
  {
    public FrmImprimirHc()
    {
      InitializeComponent();
    }

    private void FrmImprimirHc_Load(object sender, EventArgs e)
    {

      this.reportViewer1.RefreshReport();
    }

    private void BtnVerHc_Click(object sender, EventArgs e)
    {
      if(TxtDni.Text == string.Empty)
      {
        MessageBox.Show("Por favor, ingrese el dni del paciente","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
      }
      else
      {
        var myDataTable = new DataSetHistoriaClinica.PacientesDataTable();
        var myTableAdapter = new PacientesTableAdapter();
        myTableAdapter.Fill(myDataTable, TxtDni.Text);
        var rds = new ReportDataSource("DShistoriaClinica", myDataTable as DataTable);
        reportViewer1.LocalReport.DataSources.Clear();
        reportViewer1.LocalReport.DataSources.Add(rds);
        reportViewer1.RefreshReport();
      }
    }
  }
}
