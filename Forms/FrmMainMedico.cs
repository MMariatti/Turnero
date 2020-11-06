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
  public partial class FrmMainMedico : Form
  {
    public FrmMainMedico()
    {
      InitializeComponent();
    }

    private void BtnHistoriaClinica_Click(object sender, EventArgs e)
    {
      if (GrdPacientesMedico.SelectedRows.Count == 0)
      {
        MessageBox.Show("Por favor seleccione al paciente del que quiere ver la historia clinica", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        FrmHistoriaClinica frmHistoriaClinica = new FrmHistoriaClinica();
        frmHistoriaClinica.txtDni.Text = GrdPacientesMedico.SelectedRows[0].Cells[8].Value.ToString();
        frmHistoriaClinica.RtbHistoriaClinica.ReadOnly = false;
        frmHistoriaClinica.BtnGuardar.Visible = true;
        frmHistoriaClinica.Show();
      }
     
    }

    private void FrmMainMedico_Load(object sender, EventArgs e)
    {
      cmbMedico.DataSource = Medicos.GetAll();
      cmbMedico.DisplayMember = "apellido";
      cmbMedico.ValueMember = "legajo";
      cmbMedico.SelectedIndex = -1;
    }

    private void VerTurnos()
    {
      DataTable tabla = new DataTable();
      if (monthCalendarMedico.SelectionStart != null && cmbMedico.SelectedIndex !=-1 )
      {
        tabla = Turnos.GetDiaMedico(monthCalendarMedico.SelectionStart, Convert.ToInt32(cmbMedico.SelectedValue.ToString()));
        GrdPacientesMedico.DataSource = tabla;
       // GrdPacientesMedico.Columns[5].Visible = false;
        GrdPacientesMedico.Columns[10].Visible = false;
        GrdPacientesMedico.Columns[11].Visible = false;
        GrdPacientesMedico.Columns[12].Visible = false;

        foreach (DataGridViewRow row in GrdPacientesMedico.Rows)
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
      else
      {
        MessageBox.Show("Por favor seleccione una fecha en el calendario y/o el medico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }
    private void VerTurnosDelDia()
    {
      
      DataTable tabla = new DataTable();
      tabla = Turnos.GetTurnosDelDiaMedico(Convert.ToInt32(cmbMedico.SelectedValue.ToString()));
      GrdPacientesMedico.DataSource = tabla;
      GrdPacientesMedico.Columns[5].Visible = false;
      GrdPacientesMedico.Columns[6].Visible = false;
      GrdPacientesMedico.Columns[7].Visible = false;
      GrdPacientesMedico.Columns[8].Visible = true;
      
      
      
      foreach (DataGridViewRow row in GrdPacientesMedico.Rows)
      {

        if (Convert.ToBoolean(row.Cells[6].Value.ToString()) && Convert.ToBoolean(row.Cells[7].Value.ToString()))
        {
          row.DefaultCellStyle.BackColor = Color.Red;
        }
        else if (Convert.ToBoolean(row.Cells[6].Value.ToString()))
        {
          row.DefaultCellStyle.BackColor = Color.LightBlue;
        }
      }
      
    }

    private void BtnBuscar_Click(object sender, EventArgs e)
    {
      if (cmbMedico.SelectedIndex != -1)
      {
        VerTurnosDelDia();
        BtnAtendido.Enabled = true;
      }
      else
      {
        MessageBox.Show("Por favor seleccione el medico del que quiere ver los turnos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

    private void BtnBuscarTurno_Click(object sender, EventArgs e)
    {
      BtnAtendido.Enabled = false;
      VerTurnos();
    }

    private void BtnAtendido_Click(object sender, EventArgs e)
    {
      if(GrdPacientesMedico.SelectedRows.Count == 0)
      {
        MessageBox.Show("Por favor, seleccione el turno que quiere marcar como atendido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        DateTime fecha = DateTime.Parse(GrdPacientesMedico.SelectedRows[0].Cells[0].Value.ToString());
        DateTime hora = DateTime.Parse(GrdPacientesMedico.SelectedRows[0].Cells[1].Value.ToString());
        int medico = Convert.ToInt32(GrdPacientesMedico.SelectedRows[0].Cells[5].Value.ToString());
        Turnos turno = new Turnos(fecha, hora, medico);
        turno.Atender();
      }
    }

    private void FrmMainMedico_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
        
    }
  }

}
