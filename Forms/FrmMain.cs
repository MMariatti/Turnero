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
using Turnero.FormsReportes;

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
      GrdTurnos.Columns[10].Visible = false;
      GrdTurnos.Columns[11].Visible = false;
      GrdTurnos.Columns[12].Visible = false;

      foreach (DataGridViewRow row in GrdTurnos.Rows)
      {

        if (Convert.ToBoolean(row.Cells[11].Value.ToString()) && Convert.ToBoolean(row.Cells[12].Value.ToString()))
        {
          row.DefaultCellStyle.BackColor = Color.Red;
        }
        else if (Convert.ToBoolean(row.Cells[11].Value.ToString()))
        {
          row.DefaultCellStyle.BackColor = Color.LightBlue;
        }
      }
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
      Application.Exit();
    }

    private void VerTurnosXMedico(DateTime fecha, int idMedico)
    {
      DataTable tabla = new DataTable();
      tabla = Turnos.GetDiaMedico(fecha, idMedico);
      GrdTurnos.DataSource = tabla;
      GrdTurnos.Columns[10].Visible = false;
      GrdTurnos.Columns[11].Visible = false;
      GrdTurnos.Columns[12].Visible = false;

      foreach (DataGridViewRow row in GrdTurnos.Rows)
      {

        if (Convert.ToBoolean(row.Cells[11].Value.ToString()) && Convert.ToBoolean(row.Cells[12].Value.ToString()))
        {
          row.DefaultCellStyle.BackColor = Color.Red;
        }
        else if (Convert.ToBoolean(row.Cells[11].Value.ToString()))
        {
          row.DefaultCellStyle.BackColor = Color.LightBlue;
        }
      }


    }
   private void VerTurnos(DateTime fecha)
    {
      DataTable tabla = new DataTable();
      tabla = Turnos.GetAllEspecifico(fecha);
      GrdTurnos.DataSource = tabla;
      GrdTurnos.Columns[10].Visible = false;
      GrdTurnos.Columns[11].Visible = false;
      GrdTurnos.Columns[12].Visible = false;

      foreach (DataGridViewRow row in GrdTurnos.Rows)
      {

        if (Convert.ToBoolean(row.Cells[11].Value.ToString()) && Convert.ToBoolean(row.Cells[12].Value.ToString()))
        {
          row.DefaultCellStyle.BackColor = Color.Red;
        }
        else if (Convert.ToBoolean(row.Cells[11].Value.ToString()))
        {
          row.DefaultCellStyle.BackColor = Color.LightBlue;
        }
      }

    }

    public void ConfirmarTurno(DateTime fechaT, DateTime horaT, int legajoM)
    {
      Turnos turno = new Turnos(fechaT,horaT,legajoM);
      turno.Confirmar();
    }

    public void EliminarTurno(DateTime fechaT, DateTime horaT, int legajoM)
    {
      Turnos turno = new Turnos(fechaT, horaT, legajoM);
      turno.BorrarTurno();
    }
    private void FrmMain_Load(object sender, EventArgs e)
    {
      MostrarTurnosDelDia();
      CmbMedicos.DataSource = Medicos.GetAll();
      CmbMedicos.DisplayMember = "apellido";
      CmbMedicos.ValueMember = "legajo";
      CmbMedicos.SelectedIndex = -1;
    }

    private void verHistoriaClinicaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrmHistoriaClinica frmHistoriaClinica = new FrmHistoriaClinica();
      frmHistoriaClinica.Show();
    }

    private void btnActualizar_Click(object sender, EventArgs e)
    {
      MostrarTurnosDelDia();
      BtnConfirmarTurno.Enabled = true;

    }

    private void btnBuscarTurnos_Click(object sender, EventArgs e)
    {
      if(CmbMedicos.SelectedIndex ==-1)
      {
        VerTurnos(monthCalendarTurno.SelectionStart);
        BtnConfirmarTurno.Enabled = false;
      }
      else
      {
        int legajoMedico = Convert.ToInt32(CmbMedicos.SelectedValue);
        VerTurnosXMedico(monthCalendarTurno.SelectionStart, legajoMedico);
        BtnConfirmarTurno.Enabled = false;
      }
      
  
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
       
        int medico = Convert.ToInt32(GrdTurnos.SelectedRows[0].Cells[10].Value);

        ConfirmarTurno(fecha, hora, medico);
      }
    }

    private void planillaTurnosDelDiaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrmPlanillaTurnos frmPlanillaTurnos = new FrmPlanillaTurnos();
      frmPlanillaTurnos.Show();
    }

    private void cierreDeCajaToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      FrmCobroMedicos frmCobroMedicos = new FrmCobroMedicos();
      frmCobroMedicos.Show();
    }

    private void generarFacturaPorMedicoToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      FrmReciboMedicos frmReciboMedicos = new FrmReciboMedicos();
      frmReciboMedicos.Show();
    }

    private void Btn_EliminarTurno_Click(object sender, EventArgs e)
    {
      
        if (GrdTurnos.SelectedRows.Count != 0)
        {
            DateTime fecha = DateTime.Parse(GrdTurnos.SelectedRows[0].Cells[0].Value.ToString());

            DateTime hora = DateTime.Parse(GrdTurnos.SelectedRows[0].Cells[1].Value.ToString());

            int medico = Convert.ToInt32(GrdTurnos.SelectedRows[0].Cells[10].Value);

          if (MessageBox.Show("¿Está seguro que desea eliminar el turno seleccionado? ", "Eliminar Turno", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
          {
            

            EliminarTurno(fecha, hora, medico);

          }
        }
        else
        {
          MessageBox.Show("Por favor, seleccione el turno que desea eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
      
        
    }

    private void BtnBuscarXmedico_Click(object sender, EventArgs e)
    {
      if(CmbMedicos.SelectedIndex == -1)
      {
        MessageBox.Show("Por favor, seleccione un medico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
      else
      {
        BtnConfirmarTurno.Enabled = true;
        int medico = Convert.ToInt32(CmbMedicos.SelectedValue.ToString());
        GrdTurnos.DataSource = Turnos.TurnosMedico(medico);
        GrdTurnos.Columns[10].Visible = false;
        GrdTurnos.Columns[11].Visible = false;
        GrdTurnos.Columns[12].Visible = false;


        foreach (DataGridViewRow row in GrdTurnos.Rows)
        {

          if (Convert.ToBoolean(row.Cells[11].Value.ToString()) && Convert.ToBoolean(row.Cells[12].Value.ToString()))
          {
            row.DefaultCellStyle.BackColor = Color.Red;
          }
          else if (Convert.ToBoolean(row.Cells[11].Value.ToString()))
          {
            row.DefaultCellStyle.BackColor = Color.LightBlue;
          }
        }
      }
    }

    private void BtnSobreTurno_Click(object sender, EventArgs e)
    {
      if (GrdTurnos.SelectedRows.Count == 0)
      {
        MessageBox.Show("Por favor, seleccione un turno para dar el sobre turno","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
      }
      else
      {
        DateTime fechaSobreTurno = DateTime.Parse(GrdTurnos.SelectedRows[0].Cells[0].Value.ToString());
        DateTime horaSobreTurno = DateTime.Parse(GrdTurnos.SelectedRows[0].Cells[1].Value.ToString());
        horaSobreTurno = horaSobreTurno.AddMinutes(5);
       
        FrmSobreTurno frmSobreTurno = new FrmSobreTurno();
        frmSobreTurno.TxtFecha.Text = fechaSobreTurno.ToShortDateString();
        frmSobreTurno.TxtHora.Text = horaSobreTurno.ToShortTimeString();
        frmSobreTurno.LegajoMedico = Convert.ToInt32(GrdTurnos.SelectedRows[0].Cells[10].Value.ToString());
        frmSobreTurno.TxtMedico.Text = GrdTurnos.SelectedRows[0].Cells[2].Value.ToString();
        frmSobreTurno.TxtEspecialidad.Text = GrdTurnos.SelectedRows[0].Cells[3].Value.ToString();
        frmSobreTurno.Show();

      }
    }

    private void GrdTurnos_DataSourceChanged(object sender, EventArgs e)
    {
      //GrdTurnos.DataSource = Turnos.GetAllEspecifico(monthCalendarTurno.SelectionStart);
    }

    private void GrdTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
  }
}
