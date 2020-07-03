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

namespace Turnero.Forms
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
    }

    private void MostrarTurnosDelDia()
    {
      DataTable tabla = new DataTable();
      tabla = Turnos.GetTurnosDelDia();
      GrdTurnos.DataSource = tabla;
    }

    private void gestionarMedicosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrmMedicos frmMedicos;
      frmMedicos = new FrmMedicos();
      frmMedicos.Show();
    }

    private void gestionarEspecialidadesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrmEspecialidades frmEspecialidades;
      frmEspecialidades = new FrmEspecialidades();
      frmEspecialidades.Show();
    }

    private void gestionarObrasSocialesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrmObrasSociales frmObrasSociales;
      frmObrasSociales = new FrmObrasSociales();
      frmObrasSociales.Show();
    }

    private void gestionarPacientesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrmPacientes frmPacientes;
      frmPacientes = new FrmPacientes();
      frmPacientes.Show();
    }

    private void gestionarPracticasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrmPracticas frmPracticas;
      frmPracticas = new FrmPracticas();
      frmPracticas.Show();
    }

    private void gestionarTurnosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrmTurnos frmTurnos;
      frmTurnos = new FrmTurnos();
      frmTurnos.Show();
    }

    private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (MessageBox.Show("¿Está seguro que desea cerrar la aplicacion?", "Cerrar Aplicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        e.Cancel = false;
      else
        e.Cancel = true;
      
    }

   private void VerTurnos(DateTime fecha)
    {
      DataTable tabla = new DataTable();
      tabla = Turnos.GetAllEspecifico(fecha);
      GrdTurnos.DataSource = tabla;
      GrdTurnos.Columns[7].Visible = false;
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
      MostrarTurnosDelDia();
      GrdTurnos.Columns[7].Visible = false;
    }

    private void verHistoriaClinicaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrmHistoriaClinica frmHistoriaClinica = new FrmHistoriaClinica();
      frmHistoriaClinica.Show();
    }

    private void btnActualizar_Click(object sender, EventArgs e)
    {
      MostrarTurnosDelDia();

    }

    private void btnBuscarTurnos_Click(object sender, EventArgs e)
    {
        VerTurnos(monthCalendarTurno.SelectionStart);
  
    }

    private void BtnConfirmarTurno_Click(object sender, EventArgs e)
    {
      if(GrdTurnos.SelectedRows.Count == 0)
      {
        MessageBox.Show("Por favor, seleccione un turno para ser confirmado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      }
      else
      {
        DateTime fecha = DateTime.Parse(GrdTurnos.SelectedRows[0].Cells[1].Value.ToString());
        

        DateTime hora = DateTime.Parse(GrdTurnos.SelectedRows[0].Cells[1].Value.ToString());
       

        int medico = Convert.ToInt32(GrdTurnos.SelectedRows[0].Cells[7].Value);
        Turnos turno = new Turnos(fecha, hora, medico);
        MessageBox.Show(turno.fechaTurno + " /" + turno.horaTurno + " /" + turno.LegajoMedico);
        turno.Confirmar();
      }
    }

    private void btnReporte_Click(object sender, EventArgs e)
    {
      FrmReporteTurnosDelDia frmReporte = new FrmReporteTurnosDelDia();
      frmReporte.Show();
    }

    private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }
  }
}
