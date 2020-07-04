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
    private int especialidad ;
    private int idMedico;
    

    private void AgregarTurnos()
    {
      Turnos turno = new Turnos(DateTime.Parse(monthCalendarTurno.SelectionStart.ToString()),DateTime.Parse(txtHora.Text),idMedico, txtPaciente.Text,especialidad, Convert.ToInt16(cmbPracticas.SelectedValue.ToString()), obraSocial);
      
      turno.Save();
    }
    
    private void FrmTurnos_Load(object sender, EventArgs e)
    {
      DataTable tabla = new DataTable();
      tabla = Medicos.GetAll();
      GrdMedicos.DataSource = tabla;
      GrdMedicos.Columns[0].Visible = false;
      GrdMedicos.Columns[3].Visible = false;

  
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
      if(txtPaciente.Text == string.Empty ||GrdMedicos.SelectedRows.Count == -1|| txtObraSocial.Text == string.Empty || txtEspecialidad.Text == string.Empty || txtHora.Text == string.Empty || cmbPracticas.SelectedIndex == -1 )
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

    private void GrdMedicos_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (GrdMedicos.SelectedRows.Count != 0)
      {
        idMedico = Convert.ToInt32(GrdMedicos.SelectedRows[0].Cells[0].Value.ToString());
        Medicos medico = new Medicos(idMedico);
        int esp = medico.Especialidad;
        Especialidades especialidades = new Especialidades(esp);
        txtEspecialidad.Text = especialidades.Descripcion;
        especialidad = Convert.ToInt32(GrdMedicos.SelectedRows[0].Cells[3].Value.ToString());
      }
      else
      {
        MessageBox.Show("Por favor seleccione un medico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }
  }
  
}
