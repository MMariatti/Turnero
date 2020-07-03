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
  public partial class FrmTurnos : Form
  {
    public FrmTurnos()
    {
      InitializeComponent();
    }
    private int obraSocial;
    private int especialidad;

    

    private void AgregarTurnos()
    {
      Turnos turno = new Turnos(DateTime.Parse(monthCalendarTurno.SelectionStart.ToString()),DateTime.Parse(txtHora.Text),Convert.ToInt16(cmbMedico.SelectedValue.ToString()), txtPaciente.Text,especialidad, Convert.ToInt16(cmbPracticas.SelectedValue.ToString()), obraSocial);
      
      turno.Save();
    }
    
    private void FrmTurnos_Load(object sender, EventArgs e)
    {
      cmbMedico.DataSource = Medicos.GetAll();
      cmbMedico.DisplayMember = "apellido";
      cmbMedico.ValueMember = "legajo";
      cmbMedico.SelectedIndex = -1;

      cmbPracticas.DataSource = Practicas.GetAll();
      cmbPracticas.DisplayMember = "descripcion";
      cmbPracticas.ValueMember = "idPractica";
      cmbPracticas.SelectedIndex = -1;
    }

    private void Btn_BuscarPaciente_Click(object sender, EventArgs e)
    {
      if(txtPaciente.Text !=string.Empty)
      {
        Pacientes paciente = new Pacientes(txtPaciente.Text);

        if (paciente.Nombre != "" && paciente.Apellido != "")
        {
          obraSocial = paciente.ObraSocial;
          ObrasSociales obrasSociales = new ObrasSociales(obraSocial);
          txtObraSocial.Text = obrasSociales.Descripcion;
          MessageBox.Show("Paciente : " + paciente.Apellido + ", " + paciente.Nombre, "Datos del paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
      else
      {
        MessageBox.Show("Ingrese el dni del paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        txtPaciente.Focus();
      }
      

      
    }

    private void Btn_DarTurno_Click(object sender, EventArgs e)
    {
      if(txtPaciente.Text == string.Empty || cmbMedico.SelectedIndex == -1 || txtObraSocial.Text == string.Empty || txtEspecialidad.Text == string.Empty || txtHora.Text == string.Empty || cmbPracticas.SelectedIndex == -1 )
      {
        MessageBox.Show("Por favor, complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      }
      else
      {
        AgregarTurnos();
      }
    }

    private void Btn_salir_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("¿Está seguro que desea salir? los cambios no guardados se perderan", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        this.Close();
      }
    }

    private void cmbMedico_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cmbMedico.SelectedIndex > -1)
      {
        
        Medicos medicos = new Medicos(Convert.ToInt32(cmbMedico.SelectedValue));
        especialidad = medicos.Especialidad;
        Especialidades especialidades = new Especialidades(especialidad);
        txtEspecialidad.Text = especialidades.Descripcion;
      }
    }
  }
  
}
