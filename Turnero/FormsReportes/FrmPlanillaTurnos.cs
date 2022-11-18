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
using Turnero.DataSets.DataSetTurnosTableAdapters;
using Turnero.Classes;
using Microsoft.Reporting.WinForms;

namespace Turnero.FormsReportes
{
  public partial class FrmPlanillaTurnos : Form
  {
    public FrmPlanillaTurnos()
    {
      InitializeComponent();
    }

    private void FrmPlanillaTurnos_Load(object sender, EventArgs e)
    {
      cmbMedicos.DataSource = Medicos.GetAll();
      cmbMedicos.DisplayMember = "apellido";
      cmbMedicos.ValueMember = "legajo";
      cmbMedicos.SelectedIndex = -1;

      this.reportViewer1.RefreshReport();
    }

    private void BtnGenerarLista_Click(object sender, EventArgs e)
    {
      if(cmbMedicos.SelectedIndex != -1)
      {
        var myDataTable = new DataSetTurnos.TurnosXmedicoDataTable();
        var myTableAdapter = new TurnosXmedicoTableAdapter();
        myTableAdapter.Fill(myDataTable, Convert.ToInt32(cmbMedicos.SelectedValue.ToString()));
        var rds = new ReportDataSource("DsTurnos", myDataTable as DataTable);
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
