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
      DateTime horaTurno = DateTime.Parse(GrdHora.SelectedRows[0].Cells[0].Value.ToString());

      Turnos turno = new Turnos(DateTime.Parse(monthCalendarTurno.SelectionStart.ToString()),horaTurno,idMedico, txtPaciente.Text,especialidad, Convert.ToInt16(cmbPracticas.SelectedValue.ToString()), obraSocial);
      
      turno.Save();
    }
    
    private void FrmTurnos_Load(object sender, EventArgs e)
    {
      DataTable tabla = new DataTable();
      tabla = Medicos.GetAll();
      GrdMedicos.DataSource = tabla;
      GrdMedicos.Columns[0].Visible = false;
      GrdMedicos.Columns[3].Visible = false;
      GrdMedicos.Columns[4].Visible = false;
      GrdMedicos.Columns[5].Visible = false;
      GrdMedicos.Columns[6].Visible = false;
      GrdMedicos.Columns[7].Visible = false;



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
      if(txtPaciente.Text == string.Empty ||GrdMedicos.SelectedRows.Count != 1|| txtObraSocial.Text == string.Empty || txtEspecialidad.Text == string.Empty || GrdHora.SelectedRows.Count!= 1 || cmbPracticas.SelectedIndex == -1  ||monthCalendarTurno.SelectionStart < monthCalendarTurno.TodayDate)
      {
        MessageBox.Show("Por favor, complete todos los campos y/o elija una fecha igual o posterior al dia de hoy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      }
      else
      {
        AgregarTurnos();
        this.Close();
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

        // Esta seccion del codigo coloca la descripcion de la especialidad de cada medico en el TxtEspecialidad 
        idMedico = Convert.ToInt32(GrdMedicos.SelectedRows[0].Cells[0].Value.ToString());
        Medicos medico = new Medicos(idMedico);
        int esp = medico.Especialidad;
        Especialidades especialidades = new Especialidades(esp);
        txtEspecialidad.Text = especialidades.Descripcion;
        especialidad = Convert.ToInt32(GrdMedicos.SelectedRows[0].Cells[3].Value.ToString());

        
        //Esta seccion del codigo muestra en el combo box las practicas asociadas a la especialidad que tiene cargado el medico 
        cmbPracticas.DataSource = Practicas.GetAll(esp);
        cmbPracticas.DisplayMember = "descripcion";
        cmbPracticas.ValueMember = "idPractica";
        cmbPracticas.SelectedIndex = -1;
        //esta seccion del codigo se encarga de llenar la tabla de horarios y deja afuera los horarios que no estan disponible
        DateTime horaInicio = DateTime.Parse(GrdMedicos.SelectedRows[0].Cells[4].Value.ToString());
        DateTime horaFin = DateTime.Parse(GrdMedicos.SelectedRows[0].Cells[5].Value.ToString());
        int minutosAgregados = Convert.ToInt32(GrdMedicos.SelectedRows[0].Cells[6].Value.ToString());
        DateTime fecha = monthCalendarTurno.SelectionStart;
        
        while (horaInicio < horaFin)
        {
          DataTable table = Turnos.CheckearTurno(fecha, horaInicio, idMedico);
          if (table.Rows.Count == 0)
          {
            GrdHora.Rows.Add(horaInicio.ToString("HH:mm"));
            horaInicio = horaInicio.AddMinutes(minutosAgregados);
          }
          else
          {
            horaInicio = horaInicio.AddMinutes(minutosAgregados);
          }
          
        }
      }
      else
      {
        MessageBox.Show("Por favor seleccione un medico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

    private void GrdMedicos_SelectionChanged(object sender, EventArgs e)
    {
      GrdHora.Rows.Clear();
    }

    private void monthCalendarTurno_DateChanged(object sender, DateRangeEventArgs e)
    {
      GrdHora.Rows.Clear();
    }

    private void txtPaciente_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
      {
        MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Handled = true;
        return;
      }
    }
  }
  
}
