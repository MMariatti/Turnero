using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turnero.DataSets;
using Turnero.DataSets.DataSetFacturacionMedicosTableAdapters;
using Turnero.Classes;
using Microsoft.Reporting.WinForms;

namespace Turnero.FormsReportes
{
  public partial class FrmReciboMedicos : Form
  {
    public FrmReciboMedicos()
    {
      InitializeComponent();
    }

    private void FrmReciboMedicos_Load(object sender, EventArgs e)
    {
      cmbMedicos.DataSource = Medicos.GetAll();
      cmbMedicos.DisplayMember = "apellido";
      cmbMedicos.ValueMember = "legajo";
      cmbMedicos.SelectedIndex = -1;


      this.reportViewer1.RefreshReport();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (cmbMedicos.SelectedIndex != -1)
      {
        var myDataTable = new DataSetFacturacionMedicos.FacturacionMedicoDataTable();
        var myTableAdapter = new FacturacionMedicoTableAdapter();
        myTableAdapter.Fill(myDataTable, Convert.ToInt32(cmbMedicos.SelectedValue.ToString()));
        var rds = new ReportDataSource("DataSet1", myDataTable as DataTable);
        reportViewer1.LocalReport.DataSources.Clear();
        reportViewer1.LocalReport.DataSources.Add(rds);
        reportViewer1.RefreshReport();

      }
      else
      {
        MessageBox.Show("Por favor, seleccione un medico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }
  }
}
