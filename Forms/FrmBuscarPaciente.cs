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
  public partial class FrmBuscarPaciente : Form
  {
    public FrmBuscarPaciente()
    {
      InitializeComponent();
    }
    /* Metodos */
    private void MostrarTurnos(string dni)
    {
      DataTable tabla = new DataTable();
      tabla = Turnos.GetTurnosPaciente(dni);
      if (tabla.Rows.Count != 0)
      {
        GrdPacientes.DataSource = tabla;
      }
      else
      {
        MessageBox.Show("El paciente no tiene turnos cargados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }
    private bool CheckearPaciente(string dni)
    {
      DataTable tabla = new DataTable();
      string query = "SELECT nombre, apellido FROM Pacientes WHERE dni ='" + dni + "'";
      tabla = BDHelper.ConsultarSQL(query);
      if (tabla.Rows.Count !=0)
      {
        Pacientes paciente = new Pacientes(dni);
        TxtNombre.Text = paciente.Nombre.ToString();
        TxtApellido.Text = paciente.Apellido.ToString();
        return true;
      }
      else
      {
        return false;
      }
    }
 
    /* Eventos */
    private void FrmBuscarPaciente_Load(object sender, EventArgs e)
    {
      TxtApellido.ReadOnly = true;
      TxtNombre.ReadOnly = true; 
    }

    private void BtnBuscar_Click(object sender, EventArgs e)
    {
      if(TxtDni.Text != string.Empty && CheckearPaciente(TxtDni.Text.ToString())== true)
      {
        MostrarTurnos(TxtDni.Text.ToString());
      }
      else
      {
        MessageBox.Show("Por favor ingrese el dni del paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    private void TxtDni_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
      {
        e.Handled = true;
      }
    }
  }
}
