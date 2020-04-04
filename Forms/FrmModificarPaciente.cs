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

    private void CambiarApellidoP()
    {
      string nvoApellido = TxtApellido.Text;
      Pacientes paciente = new Pacientes(TxtDni.Text);
      paciente.CambiarApellido(nvoApellido);

    }
    private void CambiarNombreP()
    {
      string nvoApellido = TxtApellido.Text;
      Pacientes paciente = new Pacientes(TxtDni.Text);
      paciente.CambiarNombre(nvoApellido);

    }

    private void CambiarTelefonoP()
    {
      string nvoTelefono = TxtTelefono.Text;
      Pacientes paciente = new Pacientes(TxtDni.Text);
      paciente.CambiarTelefono(nvoTelefono);

    }
    private void CambiarDireccionP()
    {
      string nvaDireccion = TxtDireccion.Text;
      Pacientes paciente = new Pacientes(TxtDni.Text);
      paciente.CambiarDireccion(nvaDireccion);

    }

    private void CambiarObraSocialP()
    {
      int nvaObraSocial = Convert.ToInt32(CmbObraSocial.SelectedValue);
      Pacientes paciente = new Pacientes(TxtDni.Text);
      paciente.CambiarObraSocial(nvaObraSocial);

    }

    private void CambiarFechaNacP()
    {
      string nvaFechaNac = TxtFechaNac.Text;
      Pacientes paciente = new Pacientes(TxtDni.Text);
      paciente.CambiarFechaNac(nvaFechaNac);

    }

    private void BtnSalir_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro que desea salir? Los cambios no confirmados seran borrados", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        this.Close();
      }
    }

    private void FrmModificarPaciente_Load(object sender, EventArgs e)
    {
      CmbObraSocial.DataSource = ObrasSociales.LLenarCmb();
      CmbObraSocial.DisplayMember = "descripcion";
      CmbObraSocial.ValueMember = "idObraSocial";
      
    }

    private void BtnCambiarApellido_Click(object sender, EventArgs e)
    {
      if(TxtApellido.Text == string.Empty)
      {
        MessageBox.Show("Por favor complete el campo que desea modificar ", "Modifica datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        CambiarApellidoP();
        
      }
     
      
    }

    private void BtnCambiarNombre_Click(object sender, EventArgs e)
    {
      if (TxtNombre.Text == string.Empty)
      {
        MessageBox.Show("Por favor complete el campo que desea modificar ", "Modifica datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        CambiarNombreP();
      }
      
      
    }

    private void BtnCambiarObraSocial_Click(object sender, EventArgs e)
    {

      CambiarObraSocialP();
      
    }

    private void BtnCambiarTelefono_Click(object sender, EventArgs e)
    {
      if (TxtTelefono.Text == string.Empty)
      {
        MessageBox.Show("Por favor complete el campo que desea modificar ", "Modifica datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        CambiarTelefonoP();
      }
      CambiarTelefonoP();
      
    }

    private void BtnCambiarDireccion_Click(object sender, EventArgs e)
    {
      if (TxtDireccion.Text == string.Empty)
      {
        MessageBox.Show("Por favor complete el campo que desea modificar ", "Modifica datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        CambiarDireccionP();
      }
     
      
    }

    private void TxtApellido_Click(object sender, EventArgs e)
    {
      TxtApellido.Clear();

    }

    private void TxtNombre_Click(object sender, EventArgs e)
    {
      TxtNombre.Clear();

    }

    private void TxtTelefono_Click(object sender, EventArgs e)
    {
      TxtTelefono.Clear();
    }

    private void TxtDireccion_Click(object sender, EventArgs e)
    {
      TxtDireccion.Clear();
    }

    private void TxtFechaNac_Click(object sender, EventArgs e)
    {
      TxtFechaNac.Clear();
    }

    private void BtnCambiarFechaNac_Click(object sender, EventArgs e)
    {
      CambiarFechaNacP();
      TxtTelefono.Focus();

    }
  }
}
