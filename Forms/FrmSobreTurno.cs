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
  public partial class FrmSobreTurno : Form
  {
    public FrmSobreTurno()
    {
      InitializeComponent();
    }

    public int LegajoMedico ;
    public int especialidad;
    public int obraSocial;
    

    private void AgregarTurnos()
    {
      DateTime fechaSobreTurno = DateTime.Parse(TxtFecha.Text);
      DateTime horaSobreTurno = DateTime.Parse(TxtHora.Text);

      DataTable table = Turnos.CheckearTurno(fechaSobreTurno, horaSobreTurno, LegajoMedico);

      Turnos turno = new Turnos(fechaSobreTurno, horaSobreTurno, LegajoMedico, TxtPaciente.Text, especialidad, Convert.ToInt16(CmbPracticas.SelectedValue.ToString()), obraSocial);

      turno.Save();
    }

    private void FrmSobreTurno_Load(object sender, EventArgs e)
    {
      Medicos medico = new Medicos(LegajoMedico);
      especialidad= medico.Especialidad;
      CmbPracticas.DataSource = Practicas.GetAll(especialidad);
      CmbPracticas.DisplayMember = "descripcion";
      CmbPracticas.ValueMember = "idPractica";
      CmbPracticas.SelectedIndex = -1;
      
    }

    private void BtnBuscarPaciente_Click(object sender, EventArgs e)
    {
      if (TxtPaciente.Text != string.Empty)
      {
        Pacientes paciente = new Pacientes(TxtPaciente.Text);

        if (paciente.Nombre != "" && paciente.Apellido != "")
        {
          obraSocial = paciente.ObraSocial;
          ObrasSociales obrasSociales = new ObrasSociales(obraSocial);
          TxtObraSocial.Text = obrasSociales.Descripcion;
          MessageBox.Show("Paciente : " + paciente.Apellido + ", " + paciente.Nombre, "Datos del paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
      else
      {
        MessageBox.Show("Ingrese el dni del paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        TxtPaciente.Focus();
      }
    }

    private void BtnSobreTurno_Click(object sender, EventArgs e)
    {
      if(TxtPaciente.Text == string.Empty || CmbPracticas.SelectedIndex == -1)
      {
        MessageBox.Show("Por favor, complete todos los campos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        DateTime fechaSobreTurno = DateTime.Parse(TxtFecha.Text);
        DateTime horaSobreTurno = DateTime.Parse(TxtHora.Text);

        DataTable table = Turnos.CheckearTurno(fechaSobreTurno, horaSobreTurno, LegajoMedico);
        if (table.Rows.Count == 0)
        {
          AgregarTurnos();
          this.Close();
        }
        else
        {
          MessageBox.Show("Ya ha sido asignado un sobre turno para esta hora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
      }
    }

    private void BtnSalir_Click(object sender, EventArgs e)
    {

      if (MessageBox.Show("¿Está seguro que desea salir? los cambios no guardados se perderan", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        this.Close();
      }
    }
  }
}
