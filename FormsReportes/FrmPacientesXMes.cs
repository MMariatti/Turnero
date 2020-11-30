using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turnero.Classes;
using Microsoft.Reporting.WinForms;
using Turnero.DataSets.DataSetPacientesMesTableAdapters;
using Turnero.DataSets;


namespace Turnero.FormsReportes
{
  public partial class FrmPacientesXMes : Form
  {
    public FrmPacientesXMes()
    {
      InitializeComponent();
    }
    
    private void FormPacientesXMes_Load(object sender, EventArgs e)
    {





      cmbMeses.DataSource = Meses.LlenarCmb();
      cmbMeses.DisplayMember = "mes";
      cmbMeses.ValueMember = "id";
      cmbMeses.SelectedIndex = -1;

      cmbMedicos.DataSource = Medicos.GetAll();
      cmbMedicos.DisplayMember = "apellido";
      cmbMedicos.ValueMember = "legajo";
      cmbMedicos.SelectedIndex = -1;

      this.reportViewer1.RefreshReport();
    }

    private void BtnGenerarInforme_Click(object sender, EventArgs e)
    {
     if(cmbMeses.SelectedIndex != -1 && cmbMedicos.SelectedIndex != -1)
      {
        var myDataTable = new DataSetPacientesMes.PacientesXMesDataTable();
        var myTableAdapter = new PacientesXMesTableAdapter();
        myTableAdapter.Fill(myDataTable, Convert.ToInt32(cmbMeses.SelectedValue), Convert.ToInt32(cmbMedicos.SelectedValue));
        var rds = new ReportDataSource("DataSetPacientesXMes", myDataTable as DataTable);

        reportViewer1.LocalReport.DataSources.Clear();
        reportViewer1.LocalReport.DataSources.Add(rds);
        reportViewer1.RefreshReport();
        ;
      }
      else
      {
        MessageBox.Show("Por Favor, seleccione el mes ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
      } 
    }

    
  }
}
