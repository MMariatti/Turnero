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
  public partial class FrmModificarPaciente : Form
  {
    public FrmModificarPaciente()
    {
      InitializeComponent();
    }


    public int nroHc;
    private void BtnSalir_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro que desea salir? Los cambios no confirmados seran borrados", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        this.Close();
      }
    }

    private void ActualizarPaciente()
    {
      string dni = TxtDni.Text;
      string nombre = TxtNombre.Text;
      string apellido = TxtApellido.Text;
      DateTime fechaNacimiento = DateTime.Parse(TxtFechaNac.Text);
      string direccion = TxtDireccion.Text;
      string telefono = TxtTelefono.Text;
      int obraSocial = Convert.ToInt32(CmbObraSocial.SelectedValue);
      Pacientes paciente = new Pacientes(dni);
      paciente.ActualizarPaciente(dni, nombre, apellido, obraSocial, fechaNacimiento, direccion, telefono);
    }

    private void AgregarPaciente()
    {
      string dni = TxtDni.Text;
      string nombre = TxtNombre.Text;
      string apellido = TxtApellido.Text;
      DateTime fechaNac = DateTime.Parse(TxtFechaNac.Text);
      string direccion = TxtDireccion.Text;
      string telefono = TxtTelefono.Text;
      int obraSocial = Convert.ToInt32(CmbObraSocial.SelectedValue);
      DataTable tabla = new DataTable();
      try
      {

        Pacientes paciente = new Pacientes(dni, apellido, nombre, obraSocial, fechaNac, telefono, direccion);
        paciente.Save();

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }
    private void FrmModificarPaciente_Load(object sender, EventArgs e)
    {
      CmbObraSocial.DataSource = ObrasSociales.LlenarCmb();
      CmbObraSocial.DisplayMember = "descripcion";
      CmbObraSocial.ValueMember = "idObraSocial";
      
    }

    private void BtnGuardar_Click(object sender, EventArgs e)
    {

      
      if (TxtApellido.Text != string.Empty && TxtDireccion.Text != string.Empty && TxtFechaNac.Text != string.Empty && TxtDni.Text != string.Empty && TxtNombre.Text != string.Empty && TxtTelefono.Text != string.Empty && CmbObraSocial.SelectedIndex != -1)
      {
        DataTable tabla = Pacientes.CheckearPaciente(TxtDni.Text);
        if (tabla.Rows.Count == 0)
        {
          AgregarPaciente();
          
          this.Close();
        }
        else
        {
          ActualizarPaciente();
          this.Close();
        }
      }
    
      else
      {
        MessageBox.Show("Por favor, complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
     



    
    }

    private void TxtDni_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
      {
        MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Handled = true;
        return;
      }
    }

    private void TxtFechaNac_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
      {
        MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Handled = true;
        return;
      }
    }

    private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
      {
        MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Handled = true;
        return;
      }
    }

    private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
      {
        MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Handled = true;
        return;
      }
    }

    private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
      {
        MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Handled = true;
        return;
      }
    }
  }
}
