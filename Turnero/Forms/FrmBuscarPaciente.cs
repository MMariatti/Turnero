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

    private void MostrarTurnos(string nombre, string apellido)
    {
      DataTable tabla = new DataTable();
      tabla = Turnos.GetTurnosPaciente(nombre, apellido);
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

    private bool CheckearPaciente(string nombre, string apellido)
    {
      DataTable tabla = new DataTable();
      string query = "SELECT dni, nombre, apellido FROM Pacientes WHERE nombre ='" + nombre + "' AND apellido='" + apellido + "'";
      tabla = BDHelper.ConsultarSQL(query);
      if (tabla.Rows.Count != 0)
      {
        Pacientes paciente = new Pacientes(nombre, apellido);
        TxtDni.Text = paciente.Dni.ToString();
        TxtNombre.Text = nombre;
        TxtApellido.Text = apellido;
        return true;
      }
      else
      {
        return false;
      }
    }

    private void LimpiarCampos()
    {
      TxtNombre.Clear();
      TxtDni.Clear();
      TxtApellido.Clear();
    }
  
 
    /* Eventos */
    private void FrmBuscarPaciente_Load(object sender, EventArgs e)
    {
      List<ItemsComboBox> metodos = new List<ItemsComboBox>
      {
        new ItemsComboBox("DNI", 1),
        new ItemsComboBox("Nombre y Apellido", 2)
      };
      cmbBuscar.DataSource = metodos;
      cmbBuscar.DisplayMember = "Nombre";
      cmbBuscar.ValueMember = "Valor";
      cmbBuscar.SelectedIndex = 0;
      TxtNombre.ReadOnly= true;
      TxtApellido.ReadOnly = true;
      BtnModificar.Enabled = false;
    }

    private void BtnBuscar_Click(object sender, EventArgs e)
    {
      int metodoSeleccionado = cmbBuscar.SelectedIndex;
      switch(metodoSeleccionado)
      {
        case 0:

          string dni = TxtDni.Text.ToString();
          bool ChequeoPacienteDni = CheckearPaciente(dni);
          
          if (TxtDni.Text != string.Empty && ChequeoPacienteDni )
          {
            
            MostrarTurnos(dni);
          }
          else
          {
            MessageBox.Show("El paciente no esta cargado o no ingreso los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          BtnModificar.Enabled = true;
          break;
        case 1:
          
          string nombre = TxtNombre.Text.ToString();
          string apellido = TxtApellido.Text.ToString();
          bool ChequeoPaciente = CheckearPaciente(nombre, apellido);
          if ((TxtApellido.Text != string.Empty && TxtNombre.Text != string.Empty && ChequeoPaciente))
          {
            MostrarTurnos(nombre, apellido);
          }
          else
          {
            MessageBox.Show("El paciente no esta cargado o no ingreso los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          BtnModificar.Enabled = true;
          break;
      }

      
    }

    private void TxtDni_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
      {
        e.Handled = true;
      }
    }

    private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cmbBuscar.SelectedIndex == 0)
      {
        LimpiarCampos();
        TxtDni.ReadOnly = false; 
        TxtNombre.ReadOnly= true;
        TxtApellido.ReadOnly = true;
        BtnModificar.Enabled = false;
      }
      else
      {
        LimpiarCampos();
        TxtDni.ReadOnly = true;
        TxtNombre.ReadOnly = false;
        TxtApellido.ReadOnly = false;
        BtnModificar.Enabled = false;
      }
    }

    private void BtnModificar_Click(object sender, EventArgs e)
    {
      string dni = TxtDni.Text.ToString();
      Pacientes paciente = new Pacientes(dni);
      FrmModificarPaciente frmModificarPaciente = new FrmModificarPaciente();
      frmModificarPaciente.TxtDni.Text = dni;
      frmModificarPaciente.TxtNombre.Text = paciente.Nombre.ToString();
      frmModificarPaciente.TxtApellido.Text = paciente.Apellido.ToString();
      frmModificarPaciente.TxtDireccion.Text = paciente.Direccion.ToString();
      frmModificarPaciente.TxtTelefono.Text = paciente.Telefono.ToString();
      frmModificarPaciente.TxtFechaNac.Text = paciente.fechaNac.ToString();
      frmModificarPaciente.Show();
    }
  }
}
